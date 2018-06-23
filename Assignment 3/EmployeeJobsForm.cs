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
        Package p = new Package();
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
            p.Deserialise();
            //clears imported jobs to prevent duplicates
            comboBox_jobs.Controls.Clear();
            //importing jobs into dropdown box
            for (int i = 0; i < p.JobInformation.Count; i++) {
                Job currentJob = p.JobInformation[i];
                //used the custom class for simplification
                ComboboxItem item = new ComboboxItem();
                item.Text = currentJob.client.BusinessName + ", " + currentJob.Location;
                while (item.Text.Contains("  ")) item.Text = item.Text.Replace("  ", " ");
                item.Value = currentJob.ID;

                comboBox_jobs.Items.Add(item);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeJobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            offlineMenuForm.Show();
        }

        private void txt_amountCharged_TextChanged(object sender, EventArgs e)
        {
            String t = "0123456789.";
            for (int i = 0; i < txt_amountCharged.Text.Length; i++) {
                if (!t.Contains(txt_amountCharged.Text.Substring(i, 1))){
                    txt_amountCharged.Text = "0";
                }
            }
        }

        private void comboBox_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int x = int.Parse(comboBox_jobs.SelectedValue.ToString());
            //fetch and load information in dynamically.
            Client CurrentClient = p.JobInformation[comboBox_jobs.SelectedIndex].client;
            comboBox_client.Text = CurrentClient.Name ;
            txt_address.Text = CurrentClient.address;
            txt_businessName.Text = CurrentClient.BusinessName;
            txt_email.Text = CurrentClient.Email;
            txt_landLine.Text = CurrentClient.LandLine.ToString();
            txt_mobile.Text = CurrentClient.Mobile.ToString();



        }

        private void lbl_client_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_description_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_shortDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
