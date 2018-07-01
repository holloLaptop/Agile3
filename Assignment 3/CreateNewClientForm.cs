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
        // Keeps track of the parent form.
        private HomeMenuForm _homeMenuForm;

        public CreateNewClientForm(HomeMenuForm homeMenuForm)
        {
            InitializeComponent();
            _homeMenuForm = homeMenuForm;
        }

        private void CreateNewClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (_homeMenuForm.IsOnline())
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

        private void CreateNewClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }

        private void txt_mobilePhone_TextChanged(object sender, EventArgs e)
        {
            TextBox Parent = (TextBox)sender;
            int x = Parent.SelectionStart;

            Parent.Text = Person.PhoneToString(Person.PhoneToInt(Parent.Text));
            Parent.SelectionStart = x;
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
