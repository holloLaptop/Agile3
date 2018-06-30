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
    public partial class CreateJobForm : Form
    {
        // Keeps track of the parent form.
        Form homeMenuForm = new HomeMenuForm(null);

        public CreateJobForm(Form homeMenuForm)
        {
            InitializeComponent();
            this.homeMenuForm = homeMenuForm;
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

        private void btn_submit_Click(object sender, EventArgs e) {
            try
            {
                this.getClientsTableAdapter.Fill(this.agileDevelopmentDataSet.GetClients);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            try
            {

                int ClientID = Convert.ToInt32(((ComboboxItem)comboBox_clientID.SelectedItem).Value);
                //please this work
                queriesTableAdapter1.CreateJob(ClientID, txt_shortDescription.Text, txt_location.Text, (byte)numUD_priority.Value, date_startTime.Value, null, 0, false);
                queriesTableAdapter1.Dispose();
                this.Close();
            }
            catch { Console.Out.WriteLine("oops"); }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateJobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeMenuForm.Show();
        }
    }
}
