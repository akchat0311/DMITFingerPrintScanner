using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YouniqueDMITFingurePrintCaptureApp
{
    public class User
    {

        
        public string Name;
        public string parentName;
        public string instituition;
        public string DoB;
        public string gender;
        public string qualification;
        public string email;
        public string contact;
        public string address;
        public string city;
        public string state;
        public string pracCode;
        public string pracName;
        public string PCE;

        public User() {
            
            Name = "";
            parentName = "";
            instituition = "";
            DoB = DateTime.Now.ToString("dd MMMM yyyy");
            gender ="";
            qualification ="";
            email ="";
            contact ="";
            address ="";
            city ="";
            state ="";
            pracCode ="";
            pracName ="";
            PCE ="";
        }
        public void saveFile(string path,string ID)
        {
            string filePath = path.Trim() + "/Candidate Profile.dat";
            string line = "";

            line += $"ID: {ID}\n";
            line += $"Name: {Name}\n";
            line += $"Parent Name: {parentName} \n";
            line += $"DoB: {DoB}\n";
            line += $"Gender: {gender}\n";
            line += $"Qualification: {qualification}\n";
            line += $"Email: {email}\n";
            line += $"Contact: {contact}\n";
            line += $"Instituition: {instituition}\n";
            line += $"Address: {address}\n";
            line += $"City: {city}\n";
            line += $"State: {state}\n";
            line += $"PracCode: {pracCode}\n";
            line += $"PracName: {pracName}\n";
            line += $"PCE: {PCE}\n";

            
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath);
            file.WriteLine(line);

            file.Close();
        }

    }
}
