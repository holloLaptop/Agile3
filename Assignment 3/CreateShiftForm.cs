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
        private HomeMenuForm _homeMenuForm;

        public CreateShiftForm(HomeMenuForm homeMenuForm)
        {
            InitializeComponent();
            _homeMenuForm = homeMenuForm;
        }

        private void CreateShiftForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetJobs' table. You can move, or remove it, as needed.
            this.getJobsTableAdapter.Fill(this.agileDevelopmentDataSet.GetJobs);
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetEmployees' table. You can move, or remove it, as needed.
            this.getEmployeesTableAdapter.Fill(this.agileDevelopmentDataSet.GetEmployees);
            DataTable jobs = agileDevelopmentDataSet.GetJobs;
            foreach (DataRow row in jobs.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[9].ToString() + "," + row[11].ToString();
                while (CI.Text.Contains("  ")) CI.Text = CI.Text.Replace("  ", " ");
                CI.Value = row[0].ToString();
                comboBox_job.Items.Add(CI);
            }

            DataTable Employees = agileDevelopmentDataSet.GetEmployees;
            foreach (DataRow row in Employees.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[2].ToString();
                CI.Value = row[0].ToString();
                comboBox_employeeID.Items.Add(CI);
            }


        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (_homeMenuForm.IsOnline())
            {
                //try
                // {
                int EmployeeID = Convert.ToInt32(((ComboboxItem)comboBox_employeeID.SelectedItem).Value);
                int JobID = Convert.ToInt32(((ComboboxItem)comboBox_job.SelectedItem).Value);
                queriesTableAdapter1.CreateShift(EmployeeID, JobID, date_startTime.Value, date_endTime.Value);
                //make it safe please
                queriesTableAdapter1.Dispose();
                this.Close();
                //}
                //catch { Console.Out.WriteLine("oops");}   
            }
        }

        private void CreateShiftForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }
    }
}
