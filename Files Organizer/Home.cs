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
        public Home()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog1 = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                dirName.Text = folderBrowserDialog1.SelectedPath;
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
    }
}
