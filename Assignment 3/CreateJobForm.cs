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
        public CreateJobForm()
        {
            InitializeComponent();
        }

        private void CreateJobForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetClients' table. You can move, or remove it, as needed.
            this.getClientsTableAdapter.Fill(this.agileDevelopmentDataSet.GetClients);

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try { 
            int ClientID = Convert.ToInt32(comboBox_clientID.SelectedValue);
            //please this work
            queriesTableAdapter1.CreateJob(ClientID, txt_shortDescription.Text, txt_location.Text, (byte) numUD_priority.Value, date_startTime.Value, null, 0, false);
                queriesTableAdapter1.Dispose();
                this.Close();
            }
            catch { Console.Out.WriteLine("oops"); }
        }
    }
}
