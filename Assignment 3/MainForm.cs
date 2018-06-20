﻿using Assignment_3.Properties;
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
            //IsOnline();     
         
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            IsOnline();
        }

        private void IsOnline()
        {
            try
            {
                btn_home.BackgroundImage = Resources.HomeMenu;
                Object dummy = dummyTableAdapter1.GetData(0);
                btn_home.Enabled = true;
            }
            catch
            {
                btn_home.BackgroundImage = Resources.HomeMenu___Faded;
                btn_home.Enabled = false;
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            btn_home.BackgroundImage = Resources.HomeMenu;
            btn_offline.BackgroundImage = Resources.OfflineMode;
            IsOnline();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // Make sure the user really is online before preceding.
            IsOnline();
            if (btn_home.Enabled == true) {
                Form homeMenuForm = new HomeMenuForm(this);
                homeMenuForm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Cannot connect to the internet.");
            }
        }

        private void btn_offline_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form offlineMenuForm = new OfflineMenuForm(this);
            offlineMenuForm.Show();
            this.Hide();
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
