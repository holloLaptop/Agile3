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
    public partial class OfflineMenuForm : Form
    {
        // Keeps track of the parent form.
        private MainForm _mainForm;

        public OfflineMenuForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btn_viewJobs_Click(object sender, EventArgs e)
        {
            Form employeeJobsForm = new EmployeeJobsForm(this);
            employeeJobsForm.Show();
            this.Hide();
        }

        private void btn_printJobs_Click(object sender, EventArgs e)
        {
            Form printJobForm = new PrintJobForm(this);
            printJobForm.Show();
            this.Hide();
        }

        private void OfflineMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OfflineMenuForm_Load(object sender, EventArgs e)
        {

        }

    }
}
