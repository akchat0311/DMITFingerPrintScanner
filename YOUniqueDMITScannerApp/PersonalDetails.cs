
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouniqueDMITFingurePrintCaptureApp
{
    
    public partial class PersonalDetails : Form
    {
        Data data;
        private readonly int minYear = 1800;
        private readonly int maxYear = DateTime.Now.Year;
        public PersonalDetails(ref Data data)
        {
            InitializeComponent();
            string[] genderList = { "Male", "Female", "Other" };
            comboGender.Items.AddRange(genderList);
            comboGender.SelectedIndex = 0;
            string[] PCEList = { "Parents", "Company", "Education" };
            comboPCE.Items.AddRange(PCEList);
            comboPCE.SelectedIndex = 0;
            this.data = data;
            PopulateYears();
            string[] days = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
            comboDoBDay.Items.AddRange(days);
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            comboDoBMonth.Items.AddRange(months);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListBox(this.data.DatabasePath);
            cameraBtn.Enabled = false;
            FingerPrintBtn.Enabled = false; 
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        private void PopulateListBox(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                // Get directories
                PersonList.Items.Clear();

                string[] directories = Directory.GetDirectories(folderPath);

                // Add directories to ListBox
                foreach (string directory in directories)
                {
                    PersonList.Items.Add($"{Path.GetFileName(directory)}");

                }
            }
            else
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("Folder does not exist!");
            }
        }

        private void PopulateYears()
        {
            comboDoBYear.BeginUpdate();
            comboDoBYear.Items.Clear();
            for (int y = maxYear; y >= minYear; y--) // descending often better UX
            {
                comboDoBYear.Items.Add(y);
            }
            comboDoBYear.EndUpdate();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                this.data.user.Name = txtName.Text;
                this.data.user.parentName = txtParentName.Text;
                this.data.user.instituition = txtInstituition.Text;
                this.data.user.DoB = comboDoBDay.Text + ' ' + comboDoBMonth.Text + ' ' + comboDoBYear.Text;                this.data.user.gender = comboGender.Text;
                this.data.user.qualification = txtQualification.Text;
                this.data.user.email = txtEmail.Text;
                this.data.user.contact = txtContact.Text;
                this.data.user.address = txtResidence.Text;
                this.data.user.city = txtCity.Text;
                this.data.user.state = txtState.Text;
                this.data.user.pracCode = txtPracCode.Text;
                this.data.user.pracName = txtPracName.Text;
                this.data.user.PCE = comboPCE.Text;

                this.data.addData();
                IDnumberLabel.Text = this.data.ID;
                RegistrationDateLabel.Text = this.data.registrationDateTime.ToString();
                PopulateListBox(this.data.DatabasePath);
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show($"Candidate Profile saved in {this.data.DatabasePath} successfully.","Alert");
            }
            else
            {
                SystemSounds.Exclamation.Play();
                CustomMessageBox.Show("Save operation cannot be performed as Name field is empty.", "Alert");
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtParentName.Text = "";
            txtInstituition.Text = "";
            comboDoBDay.Text = "";
            comboDoBMonth.Text = "";
            comboDoBYear.Text = "";
            comboGender.Text = "Male";
            txtQualification.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtResidence.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtPracCode.Text = "";
            txtPracName.Text = "";
            comboPCE.Text = "Parents";
            IDnumberLabel.Text = "";
            RegistrationDateLabel.Text = "";
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            ClearBtn_Click(sender, e);
        }
        private void PersonList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedPerson = PersonList.SelectedItem.ToString();

            string[] tokens = selectedPerson.Split(' ');
            string[] subtokens = tokens[0].Split('-');
            string userid = subtokens[1].Trim();
            
            if (IDnumberLabel.Text == userid)
            {
                return;
            }
            IDnumberLabel.Text = userid;
            string dateString = userid; // Example input

            RegistrationDateLabel.Text = userid.Substring(4, 2) + "-" + userid.Substring(2, 2) + "-20" + userid.Substring(0, 2) + " " + userid.Substring(6, 2) + ":" + userid.Substring(8, 2) + ":" + userid.Substring(10, 2);
            this.data.photoPath = this.data.DatabasePath + "/" + selectedPerson;
            string datFilePath = this.data.photoPath + "/Candidate Profile.dat";
            this.data.ID = userid;
            this.data.registrationDateTime = DateTime.ParseExact(RegistrationDateLabel.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            // Read all lines from the file
            var lines = File.ReadAllLines(datFilePath).Where(line => !string.IsNullOrWhiteSpace(line));

            foreach (string line in lines)
            {
                // Split data by a delimiter (e.g., comma, space, etc.)
                string[] data = line.Split(':');

                if (data.Length > 0)
                {
                    data[0] = data[0].Trim();
                    data[1] = data[1].Trim();

                    switch (data[0])
                    {
                        case "Name":
                            txtName.Text = data[1];
                            break;
                        case "Parent Name":
                            txtParentName.Text = data[1];
                            break;
                        case "DoB":
                            //txtDoB.Text = data[1];
                            string[] dateparts = data[1].Split(' ');
                            comboDoBDay.Text = dateparts[0];
                            comboDoBMonth.Text = dateparts[1];
                            comboDoBYear.Text = dateparts[2];
                            break;
                        case "Gender":
                            comboGender.Text = data[1];
                            break;
                        case "Qualification":
                            txtQualification.Text = data[1];
                            break;
                        case "Email":
                            txtEmail.Text = data[1];
                            break;
                        case "Contact":
                            txtContact.Text = data[1];
                            break;
                        case "Address":
                            txtResidence.Text = data[1];
                            break;
                        case "City":
                            txtCity.Text = data[1];
                            break;
                        case "State":
                            txtState.Text = data[1];
                            break;
                        case "PracCode":
                            txtPracCode.Text = data[1];
                            break;
                        case "PracName":
                            txtPracName.Text = data[1];
                            break;
                        case "PCE":
                            comboPCE.Text = data[1];
                            break;
                        case "Instituition":
                            txtInstituition.Text = data[1];
                            break;

                    }

                }

            }

        }

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            PhotoCapture photoCapture = new PhotoCapture(ref this.data);
            photoCapture.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FingerPrintBtn_Click(object sender, EventArgs e)
        {
            FingerPrintCapture fingerPrintCapture = new FingerPrintCapture(ref this.data);
            //fingerPrintCapture.Show();            
            fingerPrintCapture.Show();
            Program.pd_form.Hide();

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
        
        private void IDnumberLabel_TextChanged(object sender, EventArgs e)
        {
            if (IDnumberLabel.Text == "")
            {
                FingerPrintBtn.Enabled = false;
                cameraBtn.Enabled = false;
            }
            else
            {
                FingerPrintBtn.Enabled = true;
                cameraBtn.Enabled = true;
            }
        }



    }
}
