using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assignment_3
{
    public class Package 
    {
        //saved variables
        public Contractors Contractor = new Contractors();
        public List<Job> JobInformation = new List<Job>();
        
        public bool UniqueJobID(int x)
        {
            for (int i = 0; i < JobInformation.Count; i++) if (JobInformation[i].ID == x) return false;
            return true;
        }

        //adds and prevents duplications of jobs
        public void AddJob(Job add) {
            bool toggle = true;
            for (int i = 0; i < JobInformation.Count; i++)
            {
                if (JobInformation[i].ID == add.ID) { toggle = false; i = JobInformation.Count; }
            }
            if(toggle) JobInformation.Add(add);
        }

        //finds the Job and adds the shift
        public void AddShift(ContractShift add) {
            for (int i = 0; i < JobInformation.Count; i++)
            {
                if (JobInformation[i].ID == add.JobID)
                {
                    JobInformation[i].Shifts.Add(add);
                    i = JobInformation.Count;
                }
            }
        }

        public Package() { /*we do nothing*/ }
        
        public void Serialise() {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Non Executable Binary|*.nbn";
            fileDialog.Title = "Export Data";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName != "" && fileDialog.CheckPathExists)
            {
                //stream
                Stream stream = File.Open(fileDialog.FileName, FileMode.Create);

                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(GetType());
                x.Serialize(stream, this);

                Console.WriteLine("Writing Job Information");
                stream.Close();
            }
        }
        public void Deserialise() {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Non Executable Binary|*.nbn";
            fileDialog.Title = "Import Data";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName != "" && fileDialog.CheckPathExists)
            {
                Stream stream = File.Open(fileDialog.FileName, FileMode.Open);
                
                //serializer
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(GetType());
                Package placeHolder =  (Package) x.Deserialize(stream);                
                Console.WriteLine("Reading Employee Information");
                //copying over information
                this.Contractor = placeHolder.Contractor;
                this.JobInformation = placeHolder.JobInformation;
                //this.Shifts = placeHolder.Shifts;
                //closing stream
                stream.Close();
                //test Passed
                //Serialise();
            }
        }
    }
}
