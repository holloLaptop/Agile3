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
    public partial class CreateShiftForm : Form
    {
        // Keeps track of the parent form.
        Form homeMenuForm = new HomeMenuForm(null);

        public CreateShiftForm(Form homeMenuForm)
        {
            InitializeComponent();
            this.homeMenuForm = homeMenuForm;
        }

        private void CreateShiftForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetJobs' table. You can move, or remove it, as needed.
            this.getJobsTableAdapter.Fill(this.agileDevelopmentDataSet.GetJobs);
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetEmployees' table. You can move, or remove it, as needed.
            this.getEmployeesTableAdapter.Fill(this.agileDevelopmentDataSet.GetEmployees);

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = Convert.ToInt32(comboBox_employeeID.SelectedValue.ToString());
                int JobID = Convert.ToInt32(comboBox_job.SelectedValue.ToString());
                queriesTableAdapter1.CreateShift(EmployeeID, JobID, date_startTime.Value, date_endTime.Value);
                //make it safe please
                queriesTableAdapter1.Dispose();
                this.Close();
            }
            catch { Console.Out.WriteLine("oops");}            
        }

        private void CreateShiftForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeMenuForm.Show();
        }
    }
}
