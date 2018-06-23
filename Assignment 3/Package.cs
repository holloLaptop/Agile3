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
        public List<Client> Clients = new List<Client>();

        public bool UniqueJobID(int x)
        {
            for (int i = 0; i < JobInformation.Count; i++) if (JobInformation[i].ID == x) return false;
            return true;
        }

        //adds and prevents duplications of jobs
        public void AddJob(Job add)
        {
            bool toggle = true;
            for (int i = 0; i < JobInformation.Count; i++)
            {
                if (JobInformation[i].ID == add.ID) { toggle = false; i = JobInformation.Count; }
            }
            if (toggle) JobInformation.Add(add);
        }

        //finds the Job and adds the shift
        public void AddShift(ContractShift add)
        {
            for (int i = 0; i < JobInformation.Count; i++)
            {
                if (JobInformation[i].ID == add.JobID)
                {
                    JobInformation[i].Shifts.Add(add);
                    i = JobInformation.Count;
                }
            }
        }

        public void AddClient(Client add)
        {
            bool toggle = true;
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].id == add.id)
                {
                    toggle = false;
                }
            }
            if (toggle) Clients.Add(add);
        }
        public Client getClient(int id)
        {
            for (int i = 0; i < Clients.Count; i++) if (Clients[i].id == id) return Clients[i];
            return null;
        }

        public Package() { /*we do nothing*/ }

        public void Serialise()
        {
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
        public void Deserialise()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Non Executable Binary|*.nbn";
            fileDialog.Title = "Import Data";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName != "" && fileDialog.CheckPathExists)
            {
                Stream stream = File.Open(fileDialog.FileName, FileMode.Open);

                //serializer
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(GetType());
                Package placeHolder = (Package)x.Deserialize(stream);
                Console.WriteLine("Reading Employee Information");
                //copying over information
                this.Contractor = placeHolder.Contractor;
                this.JobInformation = placeHolder.JobInformation;
                this.Clients = placeHolder.Clients;
                //now due to the binding we'll rebind the Clients to JobInformation
                //this shall prevent inconsistancy errors
                for (int i = 0; i < JobInformation.Count; i++)
                {
                    Job CJ = this.JobInformation[i];
                    for (int j = 0; j < Clients.Count; j++)
                    {
                        if (CJ.client.id == Clients[j].id)
                        {
                            CJ.client = Clients[j];
                            j = Clients.Count;
                        }

                    }
                }

                //closing stream
                stream.Close();
                //test Passed
                //Serialise();
            }
            
        }
    }
}
