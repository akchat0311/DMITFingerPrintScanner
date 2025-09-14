using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouniqueDMITFingurePrintCaptureApp;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public partial class Settings : Form
    {
        Data data;
        public Settings(ref Data data)
        {
            InitializeComponent();
            this.data = data;
            txtFolderPath.Text = this.data.DatabasePath;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFolderPath.Text))
            {
                this.data.initDatabase(txtFolderPath.Text);
            }

        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = true; // Allows creating a new folder

                // Show the dialog and check if the user selected a folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolderPath.Text = folderBrowserDialog.SelectedPath;

                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }



    }
}