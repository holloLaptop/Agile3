using System;
using System.Collections.Generic;

namespace Assignment_3
{
    public class Job 
    {
        public Job() { }

        // Pre-determined Job values.
        public int ID;
        public Client client;
        public String ShortDescription;
        public int priority;
        public String Location;
        public DateTime Ordered;
        public DateTime StartTime;

        // Contractor related values.
        public DateTime CompletionTime;
        public decimal Charged;
        public Boolean Paid;
        public String Notes;

        public List<ContractShift> Shifts = new List<ContractShift>();

    }
}
