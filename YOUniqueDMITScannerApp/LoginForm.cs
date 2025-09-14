using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
           
            string id = txtUserId.Text;
            string pass = txtPassword.Text;
            if (id == "admin" && pass == "admin")
            {
                Program.mainForm.Show();
                this.Hide();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("Invalid credentials. Please try again.","Alert");
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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
