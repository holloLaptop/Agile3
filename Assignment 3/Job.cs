using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Job
    {
        public int ID;
        public Client client;
        //possible convert into just ID's for simple relational databasing
        public int Charged;
        public Boolean Paid;

        public String ShotDescription;
        public int priority;
        public String Location;
        public DateTime Ordered;
        public DateTime StartTime;

        public DateTime CompletionTime;


    }
}
