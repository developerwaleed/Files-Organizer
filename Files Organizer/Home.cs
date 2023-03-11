using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Files_Organizer
{
    public partial class Home : Form
    {
        string folderPath = null;
        public Home()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                string newFolder = Path.Combine(folderPath, extension.TrimStart('.'));
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }
                string newFilePath = Path.Combine(newFolder, Path.GetFileName(file));
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            customFolderPanel.Enabled = checkBox1.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
