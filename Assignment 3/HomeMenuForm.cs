using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class HomeMenuForm : Form
    {
        // Keeps track of the parent form.
        private Form _mainForm = new MainForm();

        public HomeMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        // Open a new form to allow a new Client to be created.
        private void btn_newClient_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createNewClientForm = new CreateNewClientForm(this);
                createNewClientForm.Show();
                this.Hide();
            }
        }

        // Open a new form to allow a new Employee to be added.
        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form newEmployeeForm = new CreateEmployeeForm(this);
                newEmployeeForm.Show();
                this.Hide();
            }
        }

        // Open a new form to allow new Jobs to be created.
        private void btn_newJob_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createJobForm = new CreateJobForm(this);
                createJobForm.Show();
                this.Hide();
            }
        }

        // Open a new form to edit a client/employee's info.
        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        // Open a new form to assign Jobs to contractors.
        private void btn_assignJobs_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createShiftForm = new CreateShiftForm(this);
                createShiftForm.Show();
                this.Hide();
            }
        }

        // Open a new form to import and export files to/from the database.
        private void btn_importAndExportJobs_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form exportJobsForm = new ExportJobsForm(this);
                exportJobsForm.Show();
                this.Hide();
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        // A method instantiated to be used in further child classes as well as this class.
        //  This was re-written from MainForm so that we can get a customised error message as well as be able
        //  to call this method from further child classes.
        public Boolean IsOnline()
        {
            Ping ping = new Ping();

            try
            {
                //Google DNS 
                PingReply pingReply = ping.Send("8.8.4.4");

                if (pingReply.Status == IPStatus.Success) //Preference of succeeding...
                {
                    return true;
                }
                else //failure
                {
                    MessageBox.Show("Error: Internet connection has been lost. Reconnect and try again.", "Offline", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch
            {
                // Return false if this fails for whatever reason.
                MessageBox.Show("Error: Internet connection has been lost. Reconnect and try again.", "Offline", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void HomeMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form EditClientInfo = new EditClientInfo(this);
                EditClientInfo.Show();
                this.Hide();
            }
        }
    }
}
