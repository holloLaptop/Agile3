using System;
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

        // Open a new form that allows a contractor to view and edit assigned jobs.
        private void btn_viewJobs_Click(object sender, EventArgs e)
        {
            Form employeeJobsForm = new EmployeeJobsForm(this);
            employeeJobsForm.Show();
            this.Hide();
        }

        // Open a new form that allows a contractor to print an invoice for a job.
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
