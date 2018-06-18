using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Job
    {
        Client client;
        //possible convert into just ID's for simple relational databasing
        List<Contractors> contractors;

        String ShotDescription;
        int priority;
        String Location;
        DateTime Ordered;
        DateTime StartTime;
        int deletethis;
        int deletemore;

        DateTime CompletionTime;

    }
}
