using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public class Data
    {
        public string DatabasePath; // folder path
        public string DatabaseName; //csv file
        public string ID;
        public User user;
        public DateTime registrationDateTime;
        public string photoPath;

        public Data() {
            System.IO.StreamReader file = new System.IO.StreamReader("AppConfig.txt");
            DatabasePath = file.ReadToEnd().Trim();
            
            file.Close();
            DatabaseName = DatabasePath + "/YouniqueDMITDatabase.csv"; //csv file
            ID = "";
            user = new User();
            photoPath = "";
        }
        public void addData()
        {
            this.registrationDateTime = DateTime.Now;
            this.ID = registrationDateTime.ToString("yyMMddHHmmss");
            this.photoPath = DatabasePath.Trim() + "/ADMIN-"+ this.ID.Trim()+" "+ this.user.Name.Trim()+ " DoB " + this.user.DoB.Trim();
            if (!Directory.Exists(this.photoPath))
            {
                Directory.CreateDirectory(this.photoPath);
            }
            this.user.saveFile(this.photoPath, this.ID);

            string header = "ID,Name,Parent Name,DoB,Gender ,Qualification,Email,Contact,Instituition,Address,City,State,PracCode,PracName,PCE,RegistrationDate,Path";


            if (!File.Exists("YouniqueDMITDatabase.csv"))
            {                
                
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("YouniqueDMITDatabase.csv"))
                {
                    file.WriteLine(header);
                }
                Task.Delay(2000).Wait();
            }
            
            if (!File.Exists(this.DatabaseName))          
            {
                               
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(this.DatabaseName))
                {
                    file.WriteLine(header);
                }
                Task.Delay(2000).Wait();
            }

            string line = this.ID + "," + this.user.Name + "," + this.user.parentName + "," + this.user.DoB + "," +
                this.user.gender + "," + this.user.qualification + "," + this.user.email + "," + this.user.contact + "," +
                this.user.instituition + "," + this.user.address + "," + this.user.city + "," + this.user.state + "," + this.user.pracCode + "," +
                this.user.pracName + "," + this.user.PCE + "," + this.registrationDateTime + "," + this.photoPath;


            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.DatabaseName, append: true))
            {
                writer.WriteLine(line);
            }
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("YouniqueDMITDatabase.csv", append: true))
            {
                writer.WriteLine(line);
            }
        }

        public void initDatabase(string DatabasePath)
        {
            this.DatabasePath = DatabasePath;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("AppConfig.txt"))
            {
                file.WriteLine(DatabasePath);
            }
            this.DatabaseName = this.DatabasePath + "/YouniqueDMITDatabase.csv"; //csv file

            string line = "ID,Name,Parent Name,DoB,Gender ,Qualification,Email,Contact,Instituition,Address,City,State,PracCode,PracName,PCE,RegistrationDate,Path";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(this.DatabaseName))
            {
                file.WriteLine(line);
            }
            SystemSounds.Exclamation.Play();
            CustomMessageBox.Show($"Database created in {this.DatabasePath}", "Alert");
            this.ID = "";
            this.user = new User();           


        }


    }
}
