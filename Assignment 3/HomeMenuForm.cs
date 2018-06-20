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
    public partial class HomeMenuForm : Form
    {
        // Keeps track of the parent form.
        private Form mainForm = new MainForm();

        public HomeMenuForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_newClient_Click(object sender, EventArgs e)
        {
            Form createNewClientForm = new CreateNewClientForm(this);
            createNewClientForm.Show();
            this.Hide();
        }

        private void btn_newEmployee_Click(object sender, EventArgs e)
        {
            Form newEmployeeForm = new CreateEmployeeForm(this);
            newEmployeeForm.Show();
            this.Hide();
        }

        private void btn_newJob_Click(object sender, EventArgs e)
        {
            Form createJobForm = new CreateJobForm(this);
            createJobForm.Show();
            this.Hide();
        }

        private void btn_assignJobs_Click(object sender, EventArgs e)
        {
            Form createShiftForm = new CreateShiftForm(this);
            createShiftForm.Show();
            this.Hide();
        }

        private void HomeMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
