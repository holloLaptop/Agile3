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
        private Form mainForm = new MainForm();

        public OfflineMenuForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btn_viewJobs_Click(object sender, EventArgs e)
        {
            Form employeeJobsForm = new EmployeeJobsForm(this);
            employeeJobsForm.Show();
            this.Hide();
        }

        private void OfflineMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
