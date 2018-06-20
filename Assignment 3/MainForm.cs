using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.Dummy;
            }
            catch {
                MessageBox.Show("Offline Mode only available.");
                btn_home.Enabled = false;
                btn_home.BackgroundImage = System.Drawing.Image.FromFile("HomeMenu - Faded.png");
            }
        }
    }

    // Checks if a connection can be made to the database or not.
    public static class SqlExtensions
    {
        public static bool IsAvailable(this SqlConnection connection)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }
    }
}
