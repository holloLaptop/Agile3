using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Assignment_3
{
    // This form allows the contractor to access and edit imported jobs offline.
    public partial class EditClientInfo : Form
    {
        //Package p = new Package();
        DataTable Clients = new DataTable();
        private OfflineMenuForm _offlineMenuForm; // Keeps track of the parent form of this form.

        public EditClientInfo(OfflineMenuForm offlineMenuForm)
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
            
        }

        private void EmployeeJobs_Load(object sender, EventArgs e)
        {
            
        }

        // Format an imported file into the form to be edited.
        private void btn_import_Click(object sender, EventArgs e)
        {
            
        }

        private void EmployeeJobsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _offlineMenuForm.Show();
        }

        // Ensure only valid text is entered; automatically save the value when it is changed.
        private void txt_amountCharged_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Update the form whenever a different job from the dropdown box is selected.
        private void comboBox_jobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_client_Click(object sender, EventArgs e)
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
            
        }

        private void btn_editClientInfo_Click(object sender, EventArgs e)
        {
            EnableClientFields(true);
        }    

        // Change the client's details according to the edits the contractor has made.
        private void btn_updateClientInfo_Click(object sender, EventArgs e)
        {

        }

        // Load the client's details.
        private void LoadClientDetail()
        {
            this.getClientsTableAdapter1.Fill(this.agileDevelopmentDataSet.GetClients);

            Clients = agileDevelopmentDataSet.GetClients;
            foreach (DataRow row in Clients.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[0].ToString() + ", " + row[2].ToString();
                while (CI.Text.Contains("  ")) CI.Text = CI.Text.Replace("  ", " ");
                CI.Value = row[1].ToString();
                comboBox_client.Items.Add(CI);
            }
        }

        // Change the Enabled value of the Client-related fields to allow editing (when needed).
        private void EnableClientFields(bool value)
        {
            txt_clientName.Enabled = value;
            txt_businessName.Enabled = value;
            txt_address.Enabled = value;
            txt_landLine.Enabled = value;
            txt_mobile.Enabled = value;
            txt_email.Enabled = value;
        }

        // Export the data via the Serialise function in Package.
        private void btn_export_Click(object sender, EventArgs e)
        {
            
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
            
        }

        // Automatically update the paid status when it is changed.
        private void checkBox_paid_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        // Automatically update the notes of the contractor.
        private void txt_notes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_clent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox_client.SelectedIndex;
            DataRow row = Clients.Rows[i];
            

            txt_businessName.Text = row[0].ToString();
            txt_clientName.Text = row[2].ToString();
            txt_email.Text = row[6].ToString();
            txt_landLine.Text = row[4].ToString();
            txt_mobile.Text = row[5].ToString();
            txt_address.Text = row[3].ToString();
            

        }

        private void btn_editClientInfo_Click_1(object sender, EventArgs e)
        {
            EnableClientFields(true);
        }

        private void btn_updateClientInfo_Click_1(object sender, EventArgs e)
        {
            
            int id = int.Parse( ((ComboboxItem) comboBox_client.SelectedItem).Value.ToString());
            queriesTableAdapter1.UpdateClientBusinessName(id, txt_businessName.Text);
            queriesTableAdapter1.UpdatePersonName(id, txt_clientName.Text);
            queriesTableAdapter1.UpdatePersonEmail(id, txt_email.Text);
            queriesTableAdapter1.UpdatePersonLandLine(id, txt_landLine.Text);
            queriesTableAdapter1.UpdatePersonMobile(id, txt_mobile.Text);
            queriesTableAdapter1.UpdatePersonAddress(id, txt_address.Text);

        }
    }
}