using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment_3
{
    // This form allows the contractor to access and edit imported jobs offline.
    public partial class EmployeeJobsForm : Form
    {
        Package p = new Package();
        private OfflineMenuForm _offlineMenuForm; // Keeps track of the parent form of this form.

        public EmployeeJobsForm(OfflineMenuForm offlineMenuForm)
        {
            InitializeComponent();
            _offlineMenuForm = offlineMenuForm;
        }

        // Check the input a user is entering.
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

        // Show an additional set of data fields when the job is completed.
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

        // Format an imported file into the form to be edited.
        private void btn_import_Click(object sender, EventArgs e)
        {
            //clears imported jobs to prevent duplicates
            p.Clients.Clear();
            p.JobInformation.Clear();
            p.Contractor = null;
            comboBox_jobs.Controls.Clear();
            comboBox_jobs.Items.Clear();

            //Loads data
            p.Deserialise();

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

        private void EmployeeJobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _offlineMenuForm.Show();
        }

        // Ensure only valid text is entered; automatically save the value when it is changed.
        private void txt_amountCharged_TextChanged(object sender, EventArgs e)
        {
            String t = "0123456789.";
            for (int i = 0; i < txt_amountCharged.Text.Length; i++) {
                if (!t.Contains(txt_amountCharged.Text.Substring(i, 1))){
                    txt_amountCharged.Text = "0";
                }
            }

            // Make sure we're assigning the value to a non-null job; program crashes otherwise.
            if (comboBox_jobs.SelectedIndex != -1)
            {
                try
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Charged = Convert.ToDecimal(txt_amountCharged.Text);
                } catch
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Charged = 0; // Default
                }
            }
        }

        // Update the form whenever a different job from the dropdown box is selected.
        private void comboBox_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            txt_description.Text = SelectedJob.ShortDescription;
            
            //Client information loaded in Client
            /*  CurrentClient = SelectedJob.client;
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

        // Save the values related to a shift's start and end time whenever they are changed.
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
            EnableClientFields(true);
        }    

        // Change the client's details according to the edits the contractor has made.
        private void btn_updateClientInfo_Click(object sender, EventArgs e)
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            Client CC = SelectedJob.client;

            CC.BusinessName = txt_businessName.Text;
            CC.address = txt_address.Text;
            CC.SetLandLine(Person.PhoneToInt(txt_landLine.Text));
            CC.SetMobile(Person.PhoneToInt(txt_mobile.Text));
            CC.email = txt_email.Text;

            EnableClientFields(false);

            LoadClientDetail();
        }

        // Load the client's details.
        private void LoadClientDetail()
        {
            Job SelectedJob = p.JobInformation[comboBox_jobs.SelectedIndex];
            //Client information loaded in
            Client CurrentClient = SelectedJob.client;
            comboBox_client.Text = CurrentClient.name;
            txt_address.Text = CurrentClient.address;
            txt_businessName.Text = CurrentClient.BusinessName;
            txt_email.Text = CurrentClient.email;
            txt_landLine.Text = CurrentClient.landLine.ToString();
            txt_mobile.Text = CurrentClient.mobile.ToString();
        }

        // Change the Enabled value of the Client-related fields to allow editing (when needed).
        private void EnableClientFields(bool value)
        {
            txt_businessName.Enabled = value;
            txt_address.Enabled = value;
            txt_landLine.Enabled = value;
            txt_mobile.Enabled = value;
            txt_email.Enabled = value;
        }

        // Export the data via the Serialise function in Package.
        private void btn_export_Click(object sender, EventArgs e)
        {
            p.Serialise();
        }

        // Constantly check and save that valid text (numbers) is being entered.
        private void txt_landLine_TextChanged(object sender, EventArgs e)
        {
            
            TextBox Parent = (TextBox)sender;
            int x = Parent.SelectionStart;

            Parent.Text = Person.PhoneToString(Person.PhoneToInt(Parent.Text));
            Parent.SelectionStart = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Automatically save the completion time when it is changed.
        private void date_completedTime_ValueChanged(object sender, EventArgs e)
        {
            // Make sure we're assigning the value to a non-null job; crashes otherwise.
            if (comboBox_jobs.SelectedIndex != -1)
            {
                try
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].CompletionTime = date_completedTime.Value;
                }
                catch
                {
                    MessageBox.Show("Error: Chosen calendar date is invalid.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Automatically update the paid status when it is changed.
        private void checkBox_paid_CheckStateChanged(object sender, EventArgs e)
        {
            // Make sure we're assigning the value to a non-null job; crashes otherwise.
            if (comboBox_jobs.SelectedIndex != -1)
            {
                try
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Paid = checkBox_paid.Checked;
                }
                catch
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Paid = false; // Default
                }
            }
        }

        // Automatically update the notes of the contractor.
        private void txt_notes_TextChanged(object sender, EventArgs e)
        {
            // Make sure we're assigning the value to a non-null job; crashes otherwise.
            if (comboBox_jobs.SelectedIndex != -1)
            {
                try
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Notes = txt_notes.Text;
                }
                catch
                {
                    p.JobInformation[comboBox_jobs.SelectedIndex].Notes = "None";
                }
            }
        }
    }
}