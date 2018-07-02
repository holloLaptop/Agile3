using System;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class CreateEmployeeForm : Form
    {
        // Keeps track of the parent form.
        private HomeMenuForm _homeMenuForm;

        public CreateEmployeeForm(HomeMenuForm homeMenuForm)
        {
            InitializeComponent();
            _homeMenuForm = homeMenuForm;
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        // Create the employee in the database.
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (_homeMenuForm.IsOnline() && DataFilled()) 
            {
                try
                {
                    queriesTableAdapter1.CreateEmployee(txt_name.Text, txt_address.Text, txt_landLine.Text, txt_mobilePhone.Text, txt_email.Text);
                    queriesTableAdapter1.Dispose();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error: A problem has occured while trying to access the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void CreateEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _homeMenuForm.Show();
        }

        // Ensure valid text (numbers) are entered and convert them into a landline number format. 
        private void txt_landLine_TextChanged(object sender, EventArgs e)
        {
            TextBox Parent = (TextBox)sender;
            int x = Parent.SelectionStart;

            Parent.Text = Person.PhoneToString(Person.PhoneToInt(Parent.Text));
            Parent.SelectionStart = x;
        }

        // Make sure the required data fields are filled in.
        private Boolean DataFilled()
        {
            if (txt_name.Text != "" && txt_address.Text != "" && txt_email.Text != "") {
                return true;
            }

            MessageBox.Show("Error: Required values missing.", "Empty Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
    }
}
