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
    public partial class CreateEmployeeForm : Form
    {
        // Keeps track of the parent form.
        Form homeMenuForm = new HomeMenuForm(null);

        public CreateEmployeeForm(Form homeMenuForm)
        {
            InitializeComponent();
            this.homeMenuForm = homeMenuForm;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try {
                queriesTableAdapter1.CreateEmployee(txt_name.Text, txt_address.Text, txt_landLine.Text, txt_mobilePhone.Text, txt_email.Text);
            queriesTableAdapter1.Dispose();
            this.Close();
        }
            catch { Console.Out.WriteLine("oops"); }
}

        private void CreateEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeMenuForm.Show();
        }
    }
}
