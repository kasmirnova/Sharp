
namespace LAB_7
{
    partial class MainForm
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
            this.CreateFolder = new System.Windows.Forms.Button();
            this.CreateSubFolder = new System.Windows.Forms.Button();
            this.CheckMaxSubFolders = new System.Windows.Forms.Button();
            this.TextFile = new System.Windows.Forms.TextBox();
            this.TextBoxFind = new System.Windows.Forms.TextBox();
            this.StartFindButton = new System.Windows.Forms.Button();
            this.Tip_1 = new System.Windows.Forms.Label();
            this.Tip_2 = new System.Windows.Forms.Label();
            this.TextBoxFindPlace = new System.Windows.Forms.TextBox();
            this.Tip_3 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.CheckFolderNameLengthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateFolder
            // 
            this.CreateFolder.Location = new System.Drawing.Point(12, 12);
            this.CreateFolder.Name = "CreateFolder";
            this.CreateFolder.Size = new System.Drawing.Size(205, 43);
            this.CreateFolder.TabIndex = 0;
            this.CreateFolder.Text = "CREATE 100 FOLDERS";
            this.CreateFolder.UseVisualStyleBackColor = true;
            this.CreateFolder.Click += new System.EventHandler(this.CreateFolder_Click);
            // 
            // CreateSubFolder
            // 
            this.CreateSubFolder.Location = new System.Drawing.Point(12, 61);
            this.CreateSubFolder.Name = "CreateSubFolder";
            this.CreateSubFolder.Size = new System.Drawing.Size(205, 45);
            this.CreateSubFolder.TabIndex = 3;
            this.CreateSubFolder.Text = "CREAT 100 SUBFOLDERS";
            this.CreateSubFolder.UseVisualStyleBackColor = true;
            this.CreateSubFolder.Click += new System.EventHandler(this.CreateSubFolder_Click);
            // 
            // CheckMaxSubFolders
            // 
            this.CheckMaxSubFolders.Location = new System.Drawing.Point(12, 112);
            this.CheckMaxSubFolders.Name = "CheckMaxSubFolders";
            this.CheckMaxSubFolders.Size = new System.Drawing.Size(205, 45);
            this.CheckMaxSubFolders.TabIndex = 4;
            this.CheckMaxSubFolders.Text = "CHECK MAXIMUM FOLDERS";
            this.CheckMaxSubFolders.UseVisualStyleBackColor = true;
            this.CheckMaxSubFolders.Click += new System.EventHandler(this.CheckMaxSubFolders_Click);
            // 
            // TextFile
            // 
            this.TextFile.Location = new System.Drawing.Point(241, 12);
            this.TextFile.Multiline = true;
            this.TextFile.Name = "TextFile";
            this.TextFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextFile.Size = new System.Drawing.Size(535, 483);
            this.TextFile.TabIndex = 5;
            // 
            // TextBoxFind
            // 
            this.TextBoxFind.Location = new System.Drawing.Point(12, 186);
            this.TextBoxFind.Multiline = true;
            this.TextBoxFind.Name = "TextBoxFind";
            this.TextBoxFind.Size = new System.Drawing.Size(205, 27);
            this.TextBoxFind.TabIndex = 6;
            // 
            // StartFindButton
            // 
            this.StartFindButton.Location = new System.Drawing.Point(12, 276);
            this.StartFindButton.Name = "StartFindButton";
            this.StartFindButton.Size = new System.Drawing.Size(205, 31);
            this.StartFindButton.TabIndex = 7;
            this.StartFindButton.Text = "Find";
            this.StartFindButton.UseVisualStyleBackColor = true;
            this.StartFindButton.Click += new System.EventHandler(this.StartFindButton_Click);
            // 
            // Tip_1
            // 
            this.Tip_1.Location = new System.Drawing.Point(12, 160);
            this.Tip_1.Name = "Tip_1";
            this.Tip_1.Size = new System.Drawing.Size(205, 23);
            this.Tip_1.TabIndex = 8;
            this.Tip_1.Text = "ENTER NAME: ";
            // 
            // Tip_2
            // 
            this.Tip_2.Location = new System.Drawing.Point(12, 216);
            this.Tip_2.Name = "Tip_2";
            this.Tip_2.Size = new System.Drawing.Size(205, 23);
            this.Tip_2.TabIndex = 9;
            this.Tip_2.Text = "ENTER PLACE FOR SEARCHING: ";
            // 
            // TextBoxFindPlace
            // 
            this.TextBoxFindPlace.Location = new System.Drawing.Point(12, 242);
            this.TextBoxFindPlace.Multiline = true;
            this.TextBoxFindPlace.Name = "TextBoxFindPlace";
            this.TextBoxFindPlace.Size = new System.Drawing.Size(205, 27);
            this.TextBoxFindPlace.TabIndex = 10;
            this.TextBoxFindPlace.Click += new System.EventHandler(this.TextBoxFindPlace_Click);
            // 
            // Tip_3
            // 
            this.Tip_3.Location = new System.Drawing.Point(12, 310);
            this.Tip_3.Name = "Tip_3";
            this.Tip_3.Size = new System.Drawing.Size(205, 37);
            this.Tip_3.TabIndex = 11;
            this.Tip_3.Text = "FILE`S NAME FOR OPENNING: ";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(12, 350);
            this.FileNameTextBox.Multiline = true;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(205, 64);
            this.FileNameTextBox.TabIndex = 12;
            this.FileNameTextBox.Click += new System.EventHandler(this.FileNameTextBox_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 420);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(205, 31);
            this.OpenFileButton.TabIndex = 13;
            this.OpenFileButton.Text = "Find";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // CheckFolderNameLengthButton
            // 
            this.CheckFolderNameLengthButton.Location = new System.Drawing.Point(12, 457);
            this.CheckFolderNameLengthButton.Name = "CheckFolderNameLengthButton";
            this.CheckFolderNameLengthButton.Size = new System.Drawing.Size(205, 44);
            this.CheckFolderNameLengthButton.TabIndex = 14;
            this.CheckFolderNameLengthButton.Text = "FOLDER`S MAXIMUM SIZE";
            this.CheckFolderNameLengthButton.UseVisualStyleBackColor = true;
            this.CheckFolderNameLengthButton.Click += new System.EventHandler(this.CheckFolderNameLengthButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 507);
            this.Controls.Add(this.CheckFolderNameLengthButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.Tip_3);
            this.Controls.Add(this.TextBoxFindPlace);
            this.Controls.Add(this.Tip_2);
            this.Controls.Add(this.Tip_1);
            this.Controls.Add(this.StartFindButton);
            this.Controls.Add(this.TextBoxFind);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.CheckMaxSubFolders);
            this.Controls.Add(this.CreateSubFolder);
            this.Controls.Add(this.CreateFolder);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CheckFolderNameLengthButton;

        private System.Windows.Forms.Button CheckFolderNameLenght;

        private System.Windows.Forms.Label Tip_3;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button OpenFileButton;

        private System.Windows.Forms.Label Tip_1;
        private System.Windows.Forms.Label Tip_2;
        private System.Windows.Forms.TextBox TextBoxFindPlace;

        private System.Windows.Forms.TextBox TextBoxFind;
        private System.Windows.Forms.Button StartFindButton;

        private System.Windows.Forms.TextBox TextFile;

        #endregion

        private System.Windows.Forms.Button CreateFolder;
        private System.Windows.Forms.Button CreateSubFolder;
        private System.Windows.Forms.Button CheckMaxSubFolders;
    }
}
