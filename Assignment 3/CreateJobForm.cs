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
            try
            {
                int PersonID = Convert.ToInt32(comboBox_client.SelectedValue.ToString());
                String ShortDescription = Convert.ToString(txt_shortDescription);
                String Location = Convert.ToString(txt_location);
                int Priority 

                queriesTableAdapter1.CreateShift(EmployeeID, JobID, dateTimePicker2.Value, dateTimePicker1.Value);
                //make it safe please
                queriesTableAdapter1.Dispose();

                this.Close();

            }
            catch { Console.Out.WriteLine("oops"); }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getClientsTableAdapter.FillBy(this.agileDevelopmentDataSet.GetClients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
