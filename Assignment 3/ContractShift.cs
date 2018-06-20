using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Assignment_3
{
    [Serializable()]
    public class ContractShift : ISerializable
    {
        public ContractShift() { }
        public ContractShift(SerializationInfo info, StreamingContext ctxt)
        {
            //Contractor = (Contractors)info.GetValue("Contractor", typeof(Contractors));
            //JobInformation = (List<Job>)info.GetValue("JobInfo", typeof(List<Job>));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //info.AddValue("Contractor", Contractor);
            //info.AddValue("JobInfo", JobInformation);
        }
        public DateTime StartTime;
        public DateTime EndTime;
        public int JobID;
    }
}
