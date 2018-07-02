using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Assignment_3
{
    // This form allows the user to edit a client's or employee's info.
    public partial class EditClientInfo : Form
    {
        DataTable Clients = new DataTable();
        DataTable Employee = new DataTable();
        private HomeMenuForm _homeMenuForm; // Keeps track of the parent form of this form.

        public EditClientInfo(HomeMenuForm homeMenuForm)
        {
            InitializeComponent();
            _homeMenuForm = homeMenuForm;
        }

        private void EditClientInfo_Load(object sender, EventArgs e)
        {
            LoadClientDetail();
            LoadEmployeeDetail();
        }

        private void EditClientInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }

        private void btn_editClientInfo_Click(object sender, EventArgs e)
        {
            EnableClientFields(true);
        }    

        // Load the client's details.
        private void LoadClientDetail()
        {
            this.getClientsTableAdapter1.Fill(this.agileDevelopmentDataSet.GetClients);
            comboBox_client.Items.Clear();
            Clients = agileDevelopmentDataSet.GetClients;
            foreach (DataRow row in Clients.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[0].ToString() + ", " + row[2].ToString();
                while (CI.Text.Contains("  ")) CI.Text = CI.Text.Replace("  ", " ");
                CI.Value = row[1].ToString();
                comboBox_client.Items.Add(CI);
            }
            comboBox_client.SelectedIndex = 0;
        }

        private void LoadEmployeeDetail()
        {
            this.getEmployeesTableAdapter1.Fill(this.agileDevelopmentDataSet.GetEmployees);
            comboBox_employee.Items.Clear();
            Employee = agileDevelopmentDataSet.GetEmployees;
            foreach (DataRow row in Employee.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[2].ToString();
                while (CI.Text.Contains("  ")) CI.Text = CI.Text.Replace("  ", " ");
                CI.Value = row[1].ToString();
                comboBox_employee.Items.Add(CI);
            }
            comboBox_employee.SelectedIndex = 0;
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

        // Constantly check and save that valid text (numbers) is being entered.
        private void txt_landLine_TextChanged(object sender, EventArgs e)
        {
            
            TextBox Parent = (TextBox)sender;
            int x = Parent.SelectionStart;

            Parent.Text = Person.PhoneToString(Person.PhoneToInt(Parent.Text));
            Parent.SelectionStart = x;
        }

        // Update the form whenever a different client is selected.
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

        // Save the new values of the client's info.
        private void btn_updateClientInfo_Click_1(object sender, EventArgs e)
        {
            if (ClientDataFilled())
            {
                int id = int.Parse(((ComboboxItem)comboBox_client.SelectedItem).Value.ToString());
                queriesTableAdapter1.UpdateClientBusinessName(id, txt_businessName.Text);
                queriesTableAdapter1.UpdatePersonName(id, txt_clientName.Text);
                queriesTableAdapter1.UpdatePersonEmail(id, txt_email.Text);
                queriesTableAdapter1.UpdatePersonLandLine(id, txt_landLine.Text);
                queriesTableAdapter1.UpdatePersonMobile(id, txt_mobile.Text);
                queriesTableAdapter1.UpdatePersonAddress(id, txt_address.Text);
                LoadClientDetail();
                EnableClientFields(false);
            }
        }

        // Make sure the required data fields are filled in.
        private Boolean ClientDataFilled()
        {
            if (comboBox_client.SelectedText.ToString() != "" && txt_clientName.Text != "" && txt_businessName.Text != "" &&
                txt_address.Text != "" && txt_email.Text != "")
            {
                return true;
            }

            MessageBox.Show("Error: Required values missing.", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void btn_editEmployee_Click(object sender, EventArgs e)
        {
            txt_eAddress.Enabled = true;
            txt_eLandLine.Enabled = true;
            txt_eEmail.Enabled = true;
            txt_eMobile.Enabled = true;
            txt_employeeName.Enabled = true;
            //txt_employeeID
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(((ComboboxItem)comboBox_employee.SelectedItem).Value.ToString());
            queriesTableAdapter1.UpdatePersonAddress(id, txt_eAddress.Text);
            queriesTableAdapter1.UpdatePersonName(id, txt_employeeName.Text);
            queriesTableAdapter1.UpdatePersonEmail(id, txt_eEmail.Text);

            queriesTableAdapter1.UpdatePersonMobile(id, txt_eMobile.Text);
            queriesTableAdapter1.UpdatePersonLandLine(id, txt_eLandLine.Text);

            txt_eAddress.Enabled = false;
            txt_eLandLine.Enabled = false;
            txt_eEmail.Enabled = false;
            txt_eMobile.Enabled = false;
            txt_employeeName.Enabled = false;
            LoadEmployeeDetail();

        }

        private void comboBox_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox_employee.SelectedIndex;
            DataRow row = Employee.Rows[i];


            txt_employeeID.Text = row[0].ToString();
            txt_employeeName.Text = row[2].ToString();
            txt_eEmail.Text = row[6].ToString();
            txt_eLandLine.Text = row[4].ToString();
            txt_eMobile.Text = row[5].ToString();
            txt_eAddress.Text = row[3].ToString();
        }
    }
}