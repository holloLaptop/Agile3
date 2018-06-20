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
    public class Job : ISerializable
    {
        public Job() { }
        public Job(SerializationInfo info, StreamingContext ctxt)
        {
            
            ID = (int)info.GetValue("ID", typeof(int));
            client = (Client)info.GetValue("Client", typeof(Client));
            Charged = (decimal)info.GetValue("Charged", typeof(decimal));
            Paid = (Boolean)info.GetValue("Paid", typeof(Boolean));
            ShortDescription = (String)info.GetValue("ShortDesc", typeof(String));
            priority = (int)info.GetValue("priority", typeof(int));
            Location = (String)info.GetValue("location", typeof(String));
            Ordered = (DateTime)info.GetValue("Ordered", typeof(DateTime));
            StartTime = (DateTime)info.GetValue("StartTime", typeof(DateTime));
            CompletionTime = (DateTime)info.GetValue("Completion", typeof(DateTime));
        }

        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("ID", ID);
            info.AddValue("Client", client);
            info.AddValue("Charged", typeof(int));
            info.AddValue("Paid", typeof(Boolean));
            //info.AddValue("JobInfo", JobInformation);
            info.AddValue("ShortDesc",typeof(String));
            info.AddValue("priority", typeof(int));
            info.AddValue("location", typeof(String));
            info.AddValue("Ordered", typeof(DateTime));
            info.AddValue("StartTime", typeof(DateTime));
            info.AddValue("Completion", typeof(DateTime));
        }

        public int ID;
        public Client client;
        //possible convert into just ID's for simple relational databasing
        public decimal Charged;
        public Boolean Paid;

        public String ShortDescription;
        public int priority;
        public String Location;
        public DateTime Ordered;
        public DateTime StartTime;
        public DateTime CompletionTime;


    }
}
