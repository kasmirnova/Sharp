using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_7
{
    public partial class MainForm : Form
    {
        private const string FolderName = "Folder_";
        
        private const string TestDirectoryName = "LAB_7";
        
        private const int NumberSubFolders = 100;
        
        private int _subFoldersCount;
        
        private readonly DirectoryInfo _dirInfo;

        public MainForm()
        {
            InitializeComponent();
            _dirInfo = new DirectoryInfo(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + TestDirectoryName);
        }

        private void DeleteFolders()
        {
            foreach (var folder in _dirInfo.GetDirectories())
            {
                folder.Delete(true);
            }
        }
        private void ShowMaxNumberSubFolder()
        {
            string path = "D:";
            int count = 0;

            try
            {
                while (true)
                {
                    path += @"\" + 'a';
                    count++;
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("MAXIMUM FOLDERS " + count);
            }

            Directory.Delete(@"D:\a",true);
        }
        
        private void CreateSubFolders(DirectoryInfo dir)
        {
            try
            {
                if (_subFoldersCount == NumberSubFolders)
                    return;

                dir.CreateSubdirectory(FolderName + _subFoldersCount++);
                CreateSubFolders(dir.GetDirectories()[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("MAXIMUM FOLDERS " + _subFoldersCount);
            }
        }

        private void CreateFolder_Click(object sender, EventArgs e)
        {
            if (!_dirInfo.Exists)
            {
                _dirInfo.Create();
            }

            for (int i = 0; i < 100; i++)
            {
                _dirInfo.CreateSubdirectory(FolderName + i);
            }

            MessageBox.Show("100 FOLDERS WERE CREATED " +
                "CLICK ON \"Ок\" TO DELETE");

            if (_dirInfo.Exists)
            {
                DeleteFolders();
            }

            _dirInfo.Delete(true);
        }
        private void CreateSubFolder_Click(object sender, EventArgs e)
        {
            if (!_dirInfo.Exists)
            {
                _dirInfo.Create();
            }
            else
            {
                DeleteFolders();
            }

            CreateSubFolders(_dirInfo);
        }
        private void CheckMaxSubFolders_Click(object sender, EventArgs e)
        {
            ShowMaxNumberSubFolder();
        }

        private void StartFindButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxFind.Text) && !string.IsNullOrEmpty(TextBoxFindPlace.Text))
            {
                foreach (string path in EnumerateAllFiles(TextBoxFindPlace.Text, TextBoxFind.Text))
                {
                    if (MessageBox.Show($"OPEN FILE: {path}", "OPENED:",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            using (StreamReader streamReader = new StreamReader(path))
                            {
                                TextFile.Text = streamReader.ReadToEnd();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("ERROR");
                            throw;
                        }
                    }
                }
            }
        }

        private void TextBoxFindPlace_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxFindPlace.Text = browserDialog.SelectedPath;
            }
        }

        private static IEnumerable<string> EnumerateAllFiles(string path, string pattern)
        { 
            IEnumerable<string> files = null;
            try
            {
                files = Directory.EnumerateFiles(path, pattern);
            }
            catch
            {
                // ignored
            }

            if (files != null)
            {
                foreach (var file in files) yield return file;
            }

            IEnumerable<string> directories = null;
            try
            {
                directories = Directory.EnumerateDirectories(path);
            }
            catch
            {
                // ignored
            }

            if (directories != null)
            {
                foreach (var file in directories.SelectMany(d => EnumerateAllFiles(d, pattern)))
                {
                    yield return file;
                }
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileNameTextBox.Text))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(FileNameTextBox.Text))
                    {
                        TextFile.Text = streamReader.ReadToEnd();
                    }
                }
                catch
                {
                    MessageBox.Show( "ERROR");
                    throw;
                }
            }
        }

        private void FileNameTextBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileNameTextBox.Text = fileDialog.FileName;
            }
        }

        private int TryCreateFolder()
        {
            string tempName = "a";
            
            try
            {
                while (true)
                {
                    if (!_dirInfo.Exists)
                    {
                        _dirInfo.Create();
                    }
                    _dirInfo.CreateSubdirectory(tempName);
                    tempName += "a";
                    _dirInfo.Delete(true);
                }
            }
            catch
            {
                return tempName.Length - 1;
            }
            
        }

        private void CheckFolderNameLengthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TryCreateFolder().ToString());
        }
    }
}
