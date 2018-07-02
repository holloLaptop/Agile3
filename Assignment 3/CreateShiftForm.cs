using System;
using System.Data;
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

            // Load the relevant data fields into the controls.
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

        // Create a new Shift in the database.
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (_homeMenuForm.IsOnline() && DataFilled())
            {
                try
                {
                    int EmployeeID = Convert.ToInt32(((ComboboxItem)comboBox_employeeID.SelectedItem).Value);
                    int JobID = Convert.ToInt32(((ComboboxItem)comboBox_job.SelectedItem).Value);
                    queriesTableAdapter1.CreateShift(EmployeeID, JobID, date_startTime.Value, date_endTime.Value);

                    //Make the query safe.
                    queriesTableAdapter1.Dispose();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error: A problem has occured while trying to access the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Make sure the required data fields are filled in.
        private Boolean DataFilled()
        {
            if (comboBox_employeeID.SelectedText.ToString() != "" && comboBox_job.SelectedText.ToString() != "")
            {
                return true;
            }

            MessageBox.Show("Error: Required values missing.", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void CreateShiftForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }
    }
}
