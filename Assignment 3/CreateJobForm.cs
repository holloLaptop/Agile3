using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class CreateJobForm : Form
    {
        // Keeps track of the parent form.
        private HomeMenuForm _homeMenuForm;

        public CreateJobForm(HomeMenuForm homeMenuForm)
        {
            InitializeComponent();
            _homeMenuForm = homeMenuForm;
        }

        private void CreateJobForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetClients' table. You can move, or remove it, as needed.
            this.getClientsTableAdapter.Fill(this.agileDevelopmentDataSet.GetClients);

            DataTable Clients = agileDevelopmentDataSet.GetClients;
            foreach (DataRow row in Clients.Rows)
            {
                ComboboxItem CI = new ComboboxItem();
                CI.Text = row[0].ToString() + ", " + row[2].ToString();
                while (CI.Text.Contains("  ")) CI.Text = CI.Text.Replace("  ", " ");
                CI.Value = row[1].ToString();
                comboBox_clientID.Items.Add(CI);
            }
        }

        // Save the data entered in the form as a Job in the database.
        private void btn_submit_Click(object sender, EventArgs e) {
            if (_homeMenuForm.IsOnline())
            {
                try
                {
                    this.getClientsTableAdapter.Fill(this.agileDevelopmentDataSet.GetClients);

                }
                catch
                {
                    MessageBox.Show("Error: A problem has occured while trying to access the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                try
                {
                    int ClientID = Convert.ToInt32(((ComboboxItem)comboBox_clientID.SelectedItem).Value);
                    queriesTableAdapter1.CreateJob(ClientID, txt_shortDescription.Text, txt_location.Text, (byte)numUD_priority.Value, date_startTime.Value, null, 0, false);
                    queriesTableAdapter1.Dispose();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error: A problem has occured while trying to access the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateJobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }
    }
}
