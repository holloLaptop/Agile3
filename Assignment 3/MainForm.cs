﻿using Assignment_3.Properties;
using System;
using System.Net.NetworkInformation;
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

        // Update the Main menu based on whether a user is online or not; block Home button if not.
        private void UpdateOnlineStatus()
        {
            if (IsOnline())
            {
                btn_home.BackgroundImage = Resources.HomeMenu;
                btn_home.Enabled = true;
            }
            else
            {
                btn_home.BackgroundImage = Resources.HomeMenu___Faded;
                btn_home.Enabled = false;
            }
        }

        // Determines if the user can connect online and returns true/false.
        private Boolean IsOnline()
        {
            Ping ping = new Ping();

            try
            {
                //Google DNS 
                PingReply pingReply = ping.Send("8.8.4.4");

                if (pingReply.Status == IPStatus.Success) //Preference of succeeding...
                {
                    return true;
                }
                else //failure
                {
                    return false;
                }
            }
            catch
            {
                // Return false if this fails for whatever reason.
                return false;
            }
        }

        //Enables and disables Auto-pinging of server when form is hidden/shown.
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            timer1.Enabled = Visible;
            if (Visible) UpdateOnlineStatus();
        }
        
        // See above.
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateOnlineStatus();
        }

        // Open a new form that leads to Home (online version) of the program.
        private void btn_home_Click(object sender, EventArgs e)
        {
            // Make sure that the user really is online before connecting.
            UpdateOnlineStatus();
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

        // Open a new form that leads to the offline version of the program.
        private void btn_offline_Click(object sender, EventArgs e)
        {
            Form offlineMenuForm = new OfflineMenuForm(this);
            offlineMenuForm.Show();
            this.Hide();
        }
    } 
}
