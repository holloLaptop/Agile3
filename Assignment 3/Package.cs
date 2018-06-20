using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Assignment_3
{
    [Serializable()]
    public class Package : ISerializable
    {
        //saved variables
        Contractors Contractor = new Contractors();
        List<Job> JobInformation = new List<Job>();
        List<ContractShift> Shifts = new List<ContractShift>();

        public void AddJob(Job add) {
            JobInformation.Add(add);
        }
        public void AddShift(ContractShift add) {
            Shifts.Add(add);
        }

        public Package() { /*we do nothing*/ }

        public Package(SerializationInfo info, StreamingContext ctxt)
        {
            Contractor = (Contractors)info.GetValue("Contractor", typeof(Contractors));
            JobInformation = (List<Job>)info.GetValue("JobInfo", typeof(List<Job>));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Contractor", Contractor);
            info.AddValue("JobInfo", JobInformation);
        }

        public void Serialise() {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Non Executable Binary|*.nbn";
            fileDialog.Title = "Export Data";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null)
            {
                Stream stream = File.Open(fileDialog.FileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();

                Console.WriteLine("Writing Job Information");
                bformatter.Serialize(stream, this);
                stream.Close();
            }
        }
        public void Deserialise() {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Non Executable Binary|*.nbn";
            fileDialog.Title = "Import Data";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null)
            {
                Stream stream = File.Open("JobInfo.osl", FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();


                Console.WriteLine("Reading Employee Information");
                Package placeHolder = (Package)bformatter.Deserialize(stream);
                this.Contractor = placeHolder.Contractor;
                this.JobInformation = placeHolder.JobInformation;
                stream.Close();
            }
        }
    }
}
