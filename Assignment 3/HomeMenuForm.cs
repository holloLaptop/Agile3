using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createNewClientForm = new CreateNewClientForm(this);
                createNewClientForm.Show();
                this.Hide();
            }
        }

        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form newEmployeeForm = new CreateEmployeeForm(this);
                newEmployeeForm.Show();
                this.Hide();
            }
        }

        private void btn_newJob_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createJobForm = new CreateJobForm(this);
                createJobForm.Show();
                this.Hide();
            }
        }

        private void btn_assignJobs_Click(object sender, EventArgs e)
        {
            if (IsOnline())
            {
                Form createShiftForm = new CreateShiftForm(this);
                createShiftForm.Show();
                this.Hide();
            }
        }

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
    }
}
