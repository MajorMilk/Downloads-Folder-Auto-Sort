# Downloads-Folder-Auto-Sort
This program is designed to go through your downloads folder and sort files base on file extensions.


It is also cusomizable, meaning to add an extension to be sorted, it is as simple as adding ".example" to one of the the following arrays

private string[] audioExtensions = { ".mp3", ".wav", ".wma", ".aac", ".m4a", ".flac", ".ogg", ".opus", ".alac", ".aiff", ".dsd", ".dsf", ".dff" };


private string[] videoExtensions = { ".mp4", ".mov", ".avi", ".wmv", ".mkv", ".flv", ".webm", ".m4v", ".mpeg", ".mpg", ".3gp", ".3g2", ".ogg", ".ogv", ".qt", ".rm", ".rmvb", ".vob", ".asf", ".divx", ".swf" };


private string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".svg", ".webp", ".ico", ".jfif", ".pjpeg", ".pjp" };


private string[] documentExtensions = { ".doc", ".docx", ".ppt", ".pptx", ".xls", ".xlsx", ".pdf", ".rtf", ".txt", ".csv", ".txt" };


private string[] compressedExtensions = { ".zip", ".rar", ".7z", ".gz", ".tar", ".bz2", ".xz", ".z", ".tgz", ".tbz2", ".txz", ".tlz", ".lzma", ".cab", ".iso", ".dmg" };


private string[] executableExtensions = { ".exe", ".msi", ".bat", ".cmd" };


private string[] modelExtensions = { ".stl", ".obj", ".fbx", ".3ds", ".ply", ".dae", ".glb", ".gltf", ".3mf" };

to add a new category of things would be more involved but could be done through the following steps...


1: Create a new array containing the extensions you want.

2:Create a private string for that type of file (private string exampleDestinaion)

3:Add a foreach loop int the UpdateDictionary() function. It should be linked with the ascociated destination.

Thats it


The default destinations are:

the Music, Videos, Pictures, Documents folders
and folders inside the the downloads folder called Compressed, Executables, and 3dModels
