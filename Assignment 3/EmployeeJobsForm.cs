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
    // This form allows the contractor to access and edit imported jobs offline.
    public partial class EmployeeJobsForm : Form
    {
        // Keeps track of the parent form of this form.
        Form offlineMenuForm = new OfflineMenuForm(null);

        public EmployeeJobsForm(Form offlineMenuForm)
        {
            InitializeComponent();
            this.offlineMenuForm = offlineMenuForm;
        }

        private void txt_amountCharged_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow users to only enter numbers with a single decimal place; does NOT prevent incorrect 
            //  input via Copy-Pasting.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                (e.KeyChar != '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void checkBox_completed_CheckedChanged(object sender, EventArgs e)
        {
            // Show the required data fields once the job is Completed. 
            if (checkBox_completed.Checked != true)
            {
                grpBox_completed.Hide();
            } else if (checkBox_completed.Checked == true)
            {
                grpBox_completed.Show();
            }
        }

        private void EmployeeJobs_Load(object sender, EventArgs e)
        {
            grpBox_completed.Hide();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeJobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            offlineMenuForm.Show();
        }
    }
}
