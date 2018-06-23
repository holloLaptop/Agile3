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
            if (p.JobInformation.Count > 0) comboBox_jobs.SelectedIndex = 0;
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
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            //Client information loaded in
            /*Client CurrentClient = SelectedJob.client;
            comboBox_client.Text = CurrentClient.Name ;
            txt_address.Text = CurrentClient.address;
            txt_businessName.Text = CurrentClient.BusinessName;
            txt_email.Text = CurrentClient.Email;
            txt_landLine.Text = CurrentClient.LandLine.ToString();
            txt_mobile.Text = CurrentClient.Mobile.ToString();*/
            LoadClientDetail();

            //Update List of Shifts then selects the first one to trigger auto-load of details.
            comboBox_shifts.Items.Clear();
            List<ContractShift> Shifts = SelectedJob.Shifts;
            for(int i = 0; i < Shifts.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = Shifts[i].StartTime.Date.ToString();
                item.Value = i;
                comboBox_shifts.Items.Add(item);
            }
            if (Shifts.Count > 0) comboBox_shifts.SelectedIndex = 0;
            
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

        private void comboBox_shifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            List<ContractShift> Shifts = SelectedJob.Shifts;
            if (comboBox_shifts.SelectedIndex >= 0)
            {
                int index = comboBox_shifts.SelectedIndex;
                ContractShift Shift = Shifts[index];
                dtp_ShiftStarted.Value = Shift.StartTime;
                dtp_ShiftCompleted.Value = Shift.EndTime;
            }
        }

        private void btn_editClientInfo_Click(object sender, EventArgs e)
        {
            txt_businessName.Enabled = true;
            txt_address.Enabled = true;
            txt_landLine.Enabled = true;
            txt_mobile.Enabled = true;
            txt_email.Enabled = true;
            
        }

        private void btn_updateClientInfo_Click(object sender, EventArgs e)
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            Client CC = SelectedJob.client;

            CC.BusinessName = txt_businessName.Text;
            CC.Address = txt_address.Text;
            CC.SetLandLine(Person.PhoneToInt(txt_landLine.Text));
            CC.SetMobile(Person.PhoneToInt(txt_mobile.Text));
            CC.email = txt_email.Text;

            txt_businessName.Enabled = false;
            txt_address.Enabled = false;
            txt_landLine.Enabled = false;
            txt_mobile.Enabled = false;
            txt_email.Enabled = false;

            

            LoadClientDetail();
        }

        private void LoadClientDetail()
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            //Client information loaded in
            Client CurrentClient = SelectedJob.client;
            comboBox_client.Text = CurrentClient.Name;
            txt_address.Text = CurrentClient.address;
            txt_businessName.Text = CurrentClient.BusinessName;
            txt_email.Text = CurrentClient.Email;
            txt_landLine.Text = CurrentClient.LandLine.ToString();
            txt_mobile.Text = CurrentClient.Mobile.ToString();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            p.Serialise();
        }

        private void txt_landLine_TextChanged(object sender, EventArgs e)
        {
            
            TextBox Parent = (TextBox)sender;
            int x = Parent.SelectionStart;

            Parent.Text = Person.PhoneToString(Person.PhoneToInt(Parent.Text));
            Parent.SelectionStart = x;
        }
    }
}
