namespace DownloadsFileManager
{
    partial class DownloadsAutoSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConsoleBox = new System.Windows.Forms.RichTextBox();
            this.FilesModifiedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainButton = new System.Windows.Forms.Button();
            this.CustomPathLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomMusicPathBox = new System.Windows.Forms.TextBox();
            this.CustomVideoPathBox = new System.Windows.Forms.TextBox();
            this.CustomImagePathBox = new System.Windows.Forms.TextBox();
            this.CustomDocPathBox = new System.Windows.Forms.TextBox();
            this.CustomCompPathBox = new System.Windows.Forms.TextBox();
            this.CustomExePathBox = new System.Windows.Forms.TextBox();
            this.CustomModelPathBox = new System.Windows.Forms.TextBox();
            this.CustomMusicPathCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomVideoPathCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomImagePathCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomDocumentPathCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomCompressedPathCheckbox = new System.Windows.Forms.CheckBox();
            this.CustomExePathCheckbox = new System.Windows.Forms.CheckBox();
            this.CustomModelPathCheckbox = new System.Windows.Forms.CheckBox();
            this.CustomPathLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(12, 646);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.Size = new System.Drawing.Size(900, 203);
            this.ConsoleBox.TabIndex = 0;
            this.ConsoleBox.Text = "";
            this.ConsoleBox.TextChanged += new System.EventHandler(this.ConsoleBox_TextChanged);
            // 
            // FilesModifiedTextBox
            // 
            this.FilesModifiedTextBox.Location = new System.Drawing.Point(735, 617);
            this.FilesModifiedTextBox.Name = "FilesModifiedTextBox";
            this.FilesModifiedTextBox.ReadOnly = true;
            this.FilesModifiedTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilesModifiedTextBox.TabIndex = 2;
            this.FilesModifiedTextBox.TextChanged += new System.EventHandler(this.FilesModifiedTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files Modified";
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(12, 279);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(217, 80);
            this.MainButton.TabIndex = 5;
            this.MainButton.Text = "Begin";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // CustomPathLayoutPanel
            // 
            this.CustomPathLayoutPanel.ColumnCount = 2;
            this.CustomPathLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35484F));
            this.CustomPathLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.64516F));
            this.CustomPathLayoutPanel.Controls.Add(this.CustomMusicPathBox, 1, 0);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomVideoPathBox, 1, 1);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomImagePathBox, 1, 2);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomDocPathBox, 1, 3);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomCompPathBox, 1, 4);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomExePathBox, 1, 5);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomModelPathBox, 1, 6);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomMusicPathCheckBox, 0, 0);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomVideoPathCheckBox, 0, 1);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomImagePathCheckBox, 0, 2);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomDocumentPathCheckBox, 0, 3);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomCompressedPathCheckbox, 0, 4);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomExePathCheckbox, 0, 5);
            this.CustomPathLayoutPanel.Controls.Add(this.CustomModelPathCheckbox, 0, 6);
            this.CustomPathLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.CustomPathLayoutPanel.Name = "CustomPathLayoutPanel";
            this.CustomPathLayoutPanel.RowCount = 7;
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28526F));
            this.CustomPathLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28844F));
            this.CustomPathLayoutPanel.Size = new System.Drawing.Size(899, 261);
            this.CustomPathLayoutPanel.TabIndex = 6;
            // 
            // CustomMusicPathBox
            // 
            this.CustomMusicPathBox.Location = new System.Drawing.Point(177, 3);
            this.CustomMusicPathBox.Name = "CustomMusicPathBox";
            this.CustomMusicPathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomMusicPathBox.TabIndex = 7;
            // 
            // CustomVideoPathBox
            // 
            this.CustomVideoPathBox.Location = new System.Drawing.Point(177, 40);
            this.CustomVideoPathBox.Name = "CustomVideoPathBox";
            this.CustomVideoPathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomVideoPathBox.TabIndex = 8;
            // 
            // CustomImagePathBox
            // 
            this.CustomImagePathBox.Location = new System.Drawing.Point(177, 77);
            this.CustomImagePathBox.Name = "CustomImagePathBox";
            this.CustomImagePathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomImagePathBox.TabIndex = 9;
            // 
            // CustomDocPathBox
            // 
            this.CustomDocPathBox.Location = new System.Drawing.Point(177, 114);
            this.CustomDocPathBox.Name = "CustomDocPathBox";
            this.CustomDocPathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomDocPathBox.TabIndex = 10;
            // 
            // CustomCompPathBox
            // 
            this.CustomCompPathBox.Location = new System.Drawing.Point(177, 151);
            this.CustomCompPathBox.Name = "CustomCompPathBox";
            this.CustomCompPathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomCompPathBox.TabIndex = 11;
            // 
            // CustomExePathBox
            // 
            this.CustomExePathBox.Location = new System.Drawing.Point(177, 188);
            this.CustomExePathBox.Name = "CustomExePathBox";
            this.CustomExePathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomExePathBox.TabIndex = 12;
            // 
            // CustomModelPathBox
            // 
            this.CustomModelPathBox.Location = new System.Drawing.Point(177, 225);
            this.CustomModelPathBox.Name = "CustomModelPathBox";
            this.CustomModelPathBox.Size = new System.Drawing.Size(719, 20);
            this.CustomModelPathBox.TabIndex = 13;
            // 
            // CustomMusicPathCheckBox
            // 
            this.CustomMusicPathCheckBox.AutoSize = true;
            this.CustomMusicPathCheckBox.Location = new System.Drawing.Point(3, 3);
            this.CustomMusicPathCheckBox.Name = "CustomMusicPathCheckBox";
            this.CustomMusicPathCheckBox.Size = new System.Drawing.Size(117, 17);
            this.CustomMusicPathCheckBox.TabIndex = 14;
            this.CustomMusicPathCheckBox.Text = "Custom Music Path";
            this.CustomMusicPathCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomVideoPathCheckBox
            // 
            this.CustomVideoPathCheckBox.AutoSize = true;
            this.CustomVideoPathCheckBox.Location = new System.Drawing.Point(3, 40);
            this.CustomVideoPathCheckBox.Name = "CustomVideoPathCheckBox";
            this.CustomVideoPathCheckBox.Size = new System.Drawing.Size(116, 17);
            this.CustomVideoPathCheckBox.TabIndex = 15;
            this.CustomVideoPathCheckBox.Text = "Custom Video Path";
            this.CustomVideoPathCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomImagePathCheckBox
            // 
            this.CustomImagePathCheckBox.AutoSize = true;
            this.CustomImagePathCheckBox.Location = new System.Drawing.Point(3, 77);
            this.CustomImagePathCheckBox.Name = "CustomImagePathCheckBox";
            this.CustomImagePathCheckBox.Size = new System.Drawing.Size(118, 17);
            this.CustomImagePathCheckBox.TabIndex = 16;
            this.CustomImagePathCheckBox.Text = "Custom Image Path";
            this.CustomImagePathCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomDocumentPathCheckBox
            // 
            this.CustomDocumentPathCheckBox.AutoSize = true;
            this.CustomDocumentPathCheckBox.Location = new System.Drawing.Point(3, 114);
            this.CustomDocumentPathCheckBox.Name = "CustomDocumentPathCheckBox";
            this.CustomDocumentPathCheckBox.Size = new System.Drawing.Size(138, 17);
            this.CustomDocumentPathCheckBox.TabIndex = 17;
            this.CustomDocumentPathCheckBox.Text = "Custom Document Path";
            this.CustomDocumentPathCheckBox.UseVisualStyleBackColor = true;
            // 
            // CustomCompressedPathCheckbox
            // 
            this.CustomCompressedPathCheckbox.AutoSize = true;
            this.CustomCompressedPathCheckbox.Location = new System.Drawing.Point(3, 151);
            this.CustomCompressedPathCheckbox.Name = "CustomCompressedPathCheckbox";
            this.CustomCompressedPathCheckbox.Size = new System.Drawing.Size(147, 17);
            this.CustomCompressedPathCheckbox.TabIndex = 18;
            this.CustomCompressedPathCheckbox.Text = "Custom Compressed Path";
            this.CustomCompressedPathCheckbox.UseVisualStyleBackColor = true;
            // 
            // CustomExePathCheckbox
            // 
            this.CustomExePathCheckbox.AutoSize = true;
            this.CustomExePathCheckbox.Location = new System.Drawing.Point(3, 188);
            this.CustomExePathCheckbox.Name = "CustomExePathCheckbox";
            this.CustomExePathCheckbox.Size = new System.Drawing.Size(142, 17);
            this.CustomExePathCheckbox.TabIndex = 19;
            this.CustomExePathCheckbox.Text = "Custom Executable Path";
            this.CustomExePathCheckbox.UseVisualStyleBackColor = true;
            // 
            // CustomModelPathCheckbox
            // 
            this.CustomModelPathCheckbox.AutoSize = true;
            this.CustomModelPathCheckbox.Location = new System.Drawing.Point(3, 225);
            this.CustomModelPathCheckbox.Name = "CustomModelPathCheckbox";
            this.CustomModelPathCheckbox.Size = new System.Drawing.Size(118, 17);
            this.CustomModelPathCheckbox.TabIndex = 20;
            this.CustomModelPathCheckbox.Text = "Custom Model Path";
            this.CustomModelPathCheckbox.UseVisualStyleBackColor = true;
            // 
            // DownloadsAutoSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 861);
            this.Controls.Add(this.CustomPathLayoutPanel);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesModifiedTextBox);
            this.Controls.Add(this.ConsoleBox);
            this.MaximumSize = new System.Drawing.Size(940, 900);
            this.MinimumSize = new System.Drawing.Size(940, 900);
            this.Name = "DownloadsAutoSort";
            this.Text = "Downloads AutoSort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustomPathLayoutPanel.ResumeLayout(false);
            this.CustomPathLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleBox;
        private System.Windows.Forms.TextBox FilesModifiedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.TableLayoutPanel CustomPathLayoutPanel;
        private System.Windows.Forms.TextBox CustomMusicPathBox;
        private System.Windows.Forms.TextBox CustomVideoPathBox;
        private System.Windows.Forms.TextBox CustomImagePathBox;
        private System.Windows.Forms.TextBox CustomDocPathBox;
        private System.Windows.Forms.TextBox CustomCompPathBox;
        private System.Windows.Forms.TextBox CustomExePathBox;
        private System.Windows.Forms.TextBox CustomModelPathBox;
        private System.Windows.Forms.CheckBox CustomMusicPathCheckBox;
        private System.Windows.Forms.CheckBox CustomVideoPathCheckBox;
        private System.Windows.Forms.CheckBox CustomImagePathCheckBox;
        private System.Windows.Forms.CheckBox CustomDocumentPathCheckBox;
        private System.Windows.Forms.CheckBox CustomCompressedPathCheckbox;
        private System.Windows.Forms.CheckBox CustomExePathCheckbox;
        private System.Windows.Forms.CheckBox CustomModelPathCheckbox;
    }
}

