using Assignment_3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            // Fade the background image of Home until an SQL connection is established.
            btn_home.BackgroundImage = Resources.HomeMenu___Faded;
            btn_home.Enabled = false;
            timer1.Enabled = true; // Timer to delay the time before an SQL connection is attempted.
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            IsOnline();
        }

        private void IsOnline()
        {
            Ping ping = new Ping();
            try
            {
                //Google DNS 
                PingReply pingReply = ping.Send("8.8.8.8");

                if (pingReply.Status == IPStatus.Success) //Preference of succeeding...
                {
                    Object dummy = dummyTableAdapter1.GetData(0);
                    btn_home.BackgroundImage = Resources.HomeMenu;
                    btn_home.Enabled = true;
                }
                else //failure
                {
                    btn_home.BackgroundImage = Resources.HomeMenu___Faded;
                    btn_home.Enabled = false;
                }
            }
            catch { //ultimate failure
                btn_home.BackgroundImage = Resources.HomeMenu___Faded;
                btn_home.Enabled = false;
            }
            //made a method that pings a server
            /*
            try
            {                
                Object dummy = dummyTableAdapter1.GetData(0);
                btn_home.BackgroundImage = Resources.HomeMenu;
                btn_home.Enabled = true;
            }
            catch
            {
                btn_home.BackgroundImage = Resources.HomeMenu___Faded;
                btn_home.Enabled = false;
            }*/
        }

        

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            //enables and disables Auto-pinging of server when form is hidden/Shown
            timer1.Enabled = Visible;
            //MessageBox.Show("Timer 1 has been " + Visible + "d");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            IsOnline();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Make sure that the user really is online before connecting.
            IsOnline();
            if (btn_home.Enabled == true)
            {
                Form homeMenuForm = new HomeMenuForm(this);
                homeMenuForm.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Cannot connect to the internet.");
            }
        }

        private void btn_offline_Click(object sender, EventArgs e)
        {
            Form offlineMenuForm = new OfflineMenuForm(this);
            offlineMenuForm.Show();
            this.Hide();
        }
    }

    // Checks if a connection can be made to the database or not.
    //try removing below to see if optimizing stuff
    /*
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
    }*/
}
