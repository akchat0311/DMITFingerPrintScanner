
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace YouniqueDMITFingurePrintCaptureApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static LoginForm loginForm = new LoginForm();
        public static Data data = new Data();
        public static Menu mainForm = new Menu(ref data);
        public static Settings settings_form = new Settings(ref data);
        public static PersonalDetails pd_form = new PersonalDetails(ref data);

        [STAThread]
        static void Main()
        {

            

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(loginForm);
            //MessageBox.Show("Hi I am playing Sound Here", "Alert");

        }
    }
}