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
        // Keeps track of the parent form.
        Form homeMenuForm = new HomeMenuForm(null);

        public ExportJobsForm(Form homeMenuForm)
        {
            InitializeComponent();
            this.homeMenuForm = homeMenuForm;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Package p = new Package();
            DateTime Start = date_startTime.Value;
            DateTime End = date_endTime.Value;
            //fetches data from sql server
            DataTable table = getShiftForEmployeeTableAdapter1.GetData(Convert.ToInt32(comboBox_employeeID.SelectedValue), Start, End);
            //counting rows
            Console.WriteLine(table.Rows.Count);
            //for each row
            for (int i = 0; i < table.Rows.Count; i++) {
                Console.WriteLine("Writing Shift");
                //New Shift
                ContractShift newShift = new ContractShift();
                newShift.StartTime = DateTime.Parse(table.Rows[i][1].ToString());
                newShift.EndTime = DateTime.Parse(table.Rows[i][2].ToString());
                newShift.JobID = int.Parse(table.Rows[i][3].ToString());
                Console.WriteLine(newShift.ToString());

                //New Job if Job doesn't already exist
                int JobID = int.Parse(table.Rows[i][3].ToString());
                if (p.UniqueJobID(JobID))
                {
                    Job newJob = new Job();
                    newJob.ID = JobID;
                    newJob.ShortDescription = (String)table.Rows[i][4].ToString();
                    newJob.Ordered = DateTime.Parse(table.Rows[i][5].ToString());
                    newJob.Location = (String)table.Rows[i][6].ToString();
                    newJob.priority = int.Parse(table.Rows[i][7].ToString());
                    newJob.StartTime = DateTime.Parse(table.Rows[i][8].ToString());
                    newJob.CompletionTime = DateTime.Parse(table.Rows[i][9].ToString());
                    newJob.Charged = decimal.Parse(table.Rows[i][10].ToString());
                    newJob.Paid = Boolean.Parse(table.Rows[i][11].ToString());

                    //Client info
                    Client client = new Client();
                    client.id = int.Parse(table.Rows[i][13].ToString());
                    client.name = (String)table.Rows[i][14].ToString();
                    client.BusinessName = (String)table.Rows[i][12].ToString();
                    client.Address = (String)table.Rows[i][15].ToString();
                    try
                    {
                        client.SetLandLine(int.Parse(table.Rows[i][16].ToString()));
                    }
                    catch { client.SetLandLine(0); }
                    try
                    {
                        client.SetMobile(int.Parse(table.Rows[i][17].ToString()));
                    }
                    catch { client.SetMobile(0); }
                    client.Email = (String)table.Rows[i][18].ToString();

                    
                    p.AddClient(client);


                    //add client to Job
                    newJob.client = p.getClient(client.id);

                    //Console.WriteLine(newJob.ToString());
                    //setting values of the new Job
                    p.AddJob(newJob);
                }
                p.AddShift(newShift);
            }
            //save file
            p.Serialise();
        }

        private void ExportJobsForm_Load(object sender, EventArgs e)
        {
            this.getEmployeesTableAdapter.Fill(this.agileDevelopmentDataSet.GetEmployees);
            
            //this.getEmployeesBindingSource.Fill(this.agileDevelopmentDataSet.GetEmployees);
        }

        private void date_startTime_ValueChanged(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(comboBox_employeeID.SelectedValue);
            DateTime Start = date_startTime.Value;
            DateTime End = date_endTime.Value;

            try
            {
                dataGridView1.DataSource = getShiftForEmployeeTableAdapter1.GetData(PersonID, Start, End);
            } catch
            {
              MessageBox.Show("Error: Client/Date selected is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            //so simple, nothing else needed
            Package p = new Package();
            p.Deserialise();
            //Updates All client information
            foreach (Client c in p.Clients)
            {
                int ID = c.id;
                queriesTableAdapter1.UpdateClientBusinessName(ID, c.BusinessName);
                queriesTableAdapter1.UpdatePersonAddress(ID, c.address);
                queriesTableAdapter1.UpdatePersonEmail(ID, c.email);
                queriesTableAdapter1.UpdatePersonLandLine(ID, c.LandLine);
                queriesTableAdapter1.UpdatePersonMobile(ID, c.Mobile);
                queriesTableAdapter1.UpdatePersonName(ID, c.name);
            }
            //updating all jobs and shifts
            foreach (Job J in p.JobInformation)
            {
                //updates Job
                queriesTableAdapter1.UpdateJob(J.ID, J.ShortDescription, J.Location, (byte)J.priority, J.StartTime, J.CompletionTime, J.Charged, J.Paid);
                //update each Shift
                foreach (ContractShift CS in J.Shifts)
                {
                    queriesTableAdapter1.UpdateShiftEndTime(p.Contractor.id, J.ID, CS.StartTime, CS.EndTime);
                }
            }
            
        }

        private void ExportJobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeMenuForm.Show();
        }
    }
}
