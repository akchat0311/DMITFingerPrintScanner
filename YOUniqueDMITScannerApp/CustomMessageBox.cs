using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            this.MessageLabel.Text = message;
            this.Text = title;
        }
        public static void Show(string message, string title="Alert")
        {
            CustomMessageBox customMessageBox = new CustomMessageBox(message, title);
            customMessageBox.ShowDialog();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
