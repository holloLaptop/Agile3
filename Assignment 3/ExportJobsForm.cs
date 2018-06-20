using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class ExportJobsForm : Form
    {
        public ExportJobsForm()
        {
            InitializeComponent();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Package p = new Package();
            int PersonID = 0; //temp value
            DateTime Start = date_startTime.Value;
            DateTime End = date_endTime.Value;
            AgileDevelopmentDataSet.GetShiftForEmployeeDataTable Value;
            Value = getShiftForEmployeeTableAdapter1.GetData(PersonID, Start, End);

            for (int i = 0; i < Value.Rows.Count; i++) {
                //Shift
                ContractShift newShift = new ContractShift();
                newShift.StartTime = (DateTime)Value.Rows[i][1];
                newShift.EndTime = (DateTime)Value.Rows[i][2];
                newShift.JobID = (int)Value.Rows[i][3];

                //not needed int id = Value.Rows[0][0].ToString();
                Job newJob = new Job();
                newJob.ID = (int)Value.Rows[i][3];
                newJob.ShotDescription = (String)Value.Rows[i][4];
                newJob.Ordered = (DateTime)Value.Rows[i][5];
                newJob.Location = (String)Value.Rows[i][6];
                newJob.priority = (int)Value.Rows[i][7];
                newJob.StartTime = (DateTime)Value.Rows[i][8];
                newJob.CompletionTime = (DateTime)Value.Rows[i][9];
                newJob.Charged =  (int)Value.Rows[i][10];
                newJob.Paid = (Boolean)Value.Rows[i][11];

                //Client info
                Client client = new Client();
                client.id = (int)Value.Rows[i][12];
                client.name = (String)Value.Rows[i][13];
                client.Address = (String)Value.Rows[i][14];
                client.SetLandLine((int)Value.Rows[i][15]);
                client.SetMobile((int)Value.Rows[i][16]);
                client.Email = (String)Value.Rows[i][17];


                //setting values of the new Job
                p.AddJob(newJob);
                p.AddShift(newShift);
            }
           

            p.Serialise();
        }
    }
}
