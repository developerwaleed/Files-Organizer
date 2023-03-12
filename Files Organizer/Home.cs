using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using Files_Organizer.Properties;
using System.Linq;
using System.Collections.Specialized;

namespace Files_Organizer
{
    public partial class Home : Form
    {
        List<string> list = new List<string>();
        DataTable extensionFolderTable = new DataTable();

        string folderPath = null;
        public Home()
        {
            InitializeComponent();
        }

        private string GetBasicFolderForExtension(string extension)
        {
            switch (extension)
            {
                case "mp3":
                case "wav":
                case "aac":
                    return "audio";
                case "jpg":
                case "jpeg":
                case "png":
                case "svg":

                    return "images";
                case "zip":
                case "rar":
                    return "compressed";
                case "doc":
                case "docx":
                case "pdf":
                case "pptx":
                    return "documents";
                case "mp4":
                    return "Videos";
                case "exe":
                case "msi":
                    return "programs";
                default:
                    return "other";
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

            string[] basicFolders = { "Audio", "Images","Videos", "Compressed", "Documents", "Programs" };
            foreach (string basicFolder in basicFolders)
            {
                string newFolder = Path.Combine(folderPath, basicFolder);
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }
            }

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file).TrimStart('.');
                string basicFolder = GetBasicFolderForExtension(extension);
                string extensionFolder = Path.Combine(folderPath, basicFolder, extension);
                if (!Directory.Exists(extensionFolder))
                {
                    Directory.CreateDirectory(extensionFolder);
                }
                string newFilePath = Path.Combine(extensionFolder, Path.GetFileName(file));
                File.Move(file, newFilePath);
            }

            MessageBox.Show("Files have been organized.");

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                folderPath = dirName.Text = folderBrowserDialog1.SelectedPath;
                dirName.Visible= true;
                dir.Visible= true;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong Try Again Please!");
                }
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void extName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFolderName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
