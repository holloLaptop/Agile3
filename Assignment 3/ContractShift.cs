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
    public class ContractShift 
    {
        public ContractShift() { }

        public DateTime StartTime;
        public DateTime EndTime;
        public int JobID;
    }
}
