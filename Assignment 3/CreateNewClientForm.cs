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
    public partial class CreateNewClientForm : Form
    {
        public CreateNewClientForm()
        {
            InitializeComponent();
        }

        private void CreateNewClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.CreateClient(txt_name.Text, txt_address.Text, txt_landLine.Text, txt_mobilePhone.Text, txt_email.Text, txt_businessName.Text);

                //make it safe please
                queriesTableAdapter1.Dispose();
                this.Close();
            }
            catch { Console.Out.WriteLine("oops"); }
        }
    }
}
