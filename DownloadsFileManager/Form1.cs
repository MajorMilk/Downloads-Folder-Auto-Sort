using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadsFileManager
{
    public partial class DownloadsAutoSort : Form
    {


        private string[] audioExtensions = { ".mp3", ".wav", ".wma", ".aac", ".m4a", ".flac", ".ogg", ".opus", ".alac", ".aiff", ".dsd", ".dsf", ".dff" };

        private string[] videoExtensions = { ".mp4", ".mov", ".avi", ".wmv", ".mkv", ".flv", ".webm", ".m4v", ".mpeg", ".mpg", ".3gp", ".3g2", ".ogg", ".ogv", ".qt", ".rm", ".rmvb", ".vob", ".asf", ".divx", ".swf" };

        private string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".svg", ".webp", ".ico", ".jfif", ".pjpeg", ".pjp" };

        private string[] documentExtensions = { ".doc", ".docx", ".ppt", ".pptx", ".xls", ".xlsx", ".pdf", ".rtf", ".txt", ".csv", ".txt" };

        private string[] compressedExtensions = { ".zip", ".rar", ".7z", ".gz", ".tar", ".bz2", ".xz", ".z", ".tgz", ".tbz2", ".txz", ".tlz", ".lzma", ".cab", ".iso", ".dmg" };

        private string[] executableExtensions = { ".exe", ".msi", ".bat", ".cmd" };

        private string[] modelExtensions = { ".stl", ".obj", ".fbx", ".3ds", ".ply", ".dae", ".glb", ".gltf", ".3mf" };


        private bool CreateFolders = false;
        private bool MoveCompressed = false;
        private int FilesModified = 0;


        string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
        string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        string videosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string imagePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


        private string musicDestination;
        private string videosDestination;
        private string documentsDestination;
        private string compressedDestination;
        private string imageDestination;
        private string executableDestination;
        private string modelDestination;



        Dictionary<string, string> extensionToDestination = new Dictionary<string, string>();


        /// <summary>
        /// Loads all of the arrays of extensions into the disctionary as keys along with their destination.
        /// </summary>
        private void UpdateDictionary()
        {
            extensionToDestination = new Dictionary<string, string>();

            // Audio extensions
            foreach (string str in audioExtensions)
            {
                if (!extensionToDestination.ContainsKey(str)) 
                    extensionToDestination.Add(str, musicDestination);
            }

            // Video extensions
            foreach (string str in videoExtensions)
            {
                if (!extensionToDestination.ContainsKey(str)) 
                    extensionToDestination.Add(str, videosDestination);
            }

            // Image extensions
            foreach (string str in imageExtensions)
            {
                if (!extensionToDestination.ContainsKey(str))
                    extensionToDestination.Add(str, imageDestination);
            }

            // Document extensions
            foreach (string str in documentExtensions)
            {
                if (!extensionToDestination.ContainsKey(str))
                    extensionToDestination.Add(str, documentsDestination);
            }

            // Compressed extensions
            foreach (string str in compressedExtensions)
            {
                if (!extensionToDestination.ContainsKey(str))
                    extensionToDestination.Add(str, compressedDestination);
            }

            // Executable extensions
            foreach (string str in executableExtensions)
            {
                if (!extensionToDestination.ContainsKey(str))
                    extensionToDestination.Add(str, executableDestination);
            }

            // 3D model extensions
            foreach (string str in modelExtensions)
            {
                if (!extensionToDestination.ContainsKey(str))
                    extensionToDestination.Add(str, modelDestination);
            }
        }


        /// <summary>
        /// Sets the destinations to their default values.
        /// </summary>
        private void SetDestinations()
        {
            musicDestination = musicPath;
            videosDestination = videosPath;
            documentsDestination = documentsPath;
            compressedDestination = downloadsPath + @"\Compressed";
            imageDestination = imagePath;
            executableDestination = downloadsPath + @"\Executables";
            modelDestination = downloadsPath + @"\3DModels";
        }



        /// <summary>
        /// Returns true if you are able to write a file to the specified destination.
        /// </summary>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        private bool IsDirectoryWritable(string directoryPath, bool CreateFolderMode)
        {
            if(CreateFolderMode)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
            try
            {
                // Get the security information for the directory
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                // Get the rules for the current user
                SecurityIdentifier currentUser = WindowsIdentity.GetCurrent().User;
                AuthorizationRuleCollection accessRules = directorySecurity.GetAccessRules(true, true, typeof(SecurityIdentifier));

                // Check if the current user has write access to the directory
                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if (currentUser.Equals(rule.IdentityReference))
                    {
                        if ((FileSystemRights.Write & rule.FileSystemRights) == FileSystemRights.Write)
                        {
                            if (rule.AccessControlType == AccessControlType.Allow)
                            {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Makes sure you have the proper permission to modify the downloads and other folders
        /// </summary>
        /// <returns></returns>
        private bool CheckFolders()
        {
            //If you can access these folders, I'm assuming you could access the others.
            if (IsDirectoryWritable(downloadsPath, false) &  IsDirectoryWritable(videosPath, false) & IsDirectoryWritable(musicPath, false) & IsDirectoryWritable(documentsPath, false)) return true; 
            else return false;
        }


        /// <summary>
        /// Moves files from one place to another.
        /// if the destination folder doesnt exist (in the case of default destinations)
        /// a folder will be made.
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="DestinationFolderPath"></param>
        /// <returns></returns>
        private bool MoveFile(string FilePath, string DestinationFolderPath)
        {
            if (!Directory.Exists(DestinationFolderPath))
            {
                Directory.CreateDirectory(DestinationFolderPath);
            }
            FilesModified++;
            UpdateFileModified();
            string destinationFilePath = Path.Combine(DestinationFolderPath, Path.GetFileName(FilePath));
            File.Move(FilePath, destinationFilePath);
            return true;

        }

        public DownloadsAutoSort()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!CheckFolders()) WriteMessage("ERROR: Insufficent permissions");
            else WriteMessage("READY");

            SetDestinations();
            UpdateDictionary();
        }


        /// <summary>
        /// For Sending messages to the main rich text box
        /// </summary>
        /// <param name="str"></param>
        private void WriteMessage(string str)
        {
            ConsoleBox.Text += str + '\n';
        }

        private void ConsoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilesModifiedTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void UpdateFileModified()
        {
            FilesModifiedTextBox.Text = FilesModified.ToString();
        }



        /// <summary>
        /// Sets CustomPaths to specified values dependoning on if the ascociated Radio Button is pressed
        /// </summary>
        private void UpdateCustomPaths()
        {
            if (CustomMusicPathCheckBox.Checked)
            {
                musicDestination = CustomMusicPathBox.Text;
            }
            if (CustomVideoPathCheckBox.Checked)
            {
                videosDestination = CustomVideoPathBox.Text;
            }
            if (CustomImagePathCheckBox.Checked)
            {
                imageDestination = CustomImagePathBox.Text;
            }
            if (CustomDocumentPathCheckBox.Checked)
            {
                documentsDestination = CustomDocPathBox.Text;
            }
            if (CustomExePathCheckbox.Checked)
            {
                executableDestination = CustomExePathBox.Text;
            }
            if (CustomModelPathCheckbox.Checked)
            {
                modelDestination = CustomModelPathBox.Text;
            }
            if (CustomCompressedPathCheckbox.Checked)
            {
                compressedDestination = CustomCompPathBox.Text;
            }
        }

        /// <summary>
        /// Checks Destination Folders to make sure theyre all writable
        /// </summary>
        /// <returns></returns>
        private bool CheckDestinations()
        {
            if (!IsDirectoryWritable(musicDestination, true))
            {
                MessageBox.Show("Music destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(videosDestination, true))
            {
                MessageBox.Show("Videos destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(imageDestination, true))
            {
                MessageBox.Show("Images destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(documentsDestination, true))
            {
                MessageBox.Show("Documents destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(compressedDestination, true))
            {
                MessageBox.Show("Compressed destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(executableDestination, true))
            {
                MessageBox.Show("Executable destination is not writable.");
                return false;
            }
            if (!IsDirectoryWritable(modelDestination, true))
            {
                MessageBox.Show("Model destination is not writable.");
                return false;
            }

            return true;
        }





        /// <summary>
        /// Main Program logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainButton_Click(object sender, EventArgs e)
        {
            SetDestinations();
            UpdateCustomPaths();

            if (!CheckDestinations()) { WriteMessage("CUSTOM PATH ERROR"); return; }
            UpdateDictionary();

            string[] files = Directory.GetFiles(downloadsPath, "*");
            foreach (string file in files)
            {
                WriteMessage($"Looking at {file} ");
                string FileDestination = GetDestination(file);
                WriteMessage($"Going to {FileDestination}");
                if (FileDestination == "NONE") continue;
                else
                {
                    MoveFile(file, FileDestination);
                }
            }

        }

        /// <summary>
        /// Dictionary lookup function.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string GetDestination(string file)
        {
            string fileExtension = Path.GetExtension(file);
            if (extensionToDestination.TryGetValue(fileExtension, out string destinationPath))
            {
                return destinationPath;
            }
            else
            {
                return "NONE";
            }

        }
    }
}
