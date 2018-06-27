using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_3
{
    public class Job 
    {
        public Job() { }
        
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

        public List<ContractShift> Shifts = new List<ContractShift>();

    }
}
