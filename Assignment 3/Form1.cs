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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //does nothing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agileDevelopmentDataSet.GetClients' table. You can move, or remove it, as needed.
            this.getClientsTableAdapter.Fill(this.agileDevelopmentDataSet.GetClients);
            SqlConnection MyConnection = new SqlConnection("Data Source=agiledevunisa.database.windows.net;Initial Catalog=AgileDevelopment;Persist Security Info=True;User ID=Agile;Password=Geek4335!");

            SqlCommand MyCommand = new SqlCommand("SELECT TOP (1000) * FROM[dbo].[GetClients]", MyConnection);
            // Set the command type that you will run.
            MyCommand.CommandType = CommandType.Text;

            // Open the connection.
            MyCommand.Connection.Open();

            // Run the SQL statement, and then get the returned rows to the DataReader.
            SqlDataReader MyDataReader = MyCommand.ExecuteReader();

            // If any rows are returned, the stored procedure that you are trying 
            // to create already exists. Therefore, try to create the stored procedure
            // only if it does not exist.
            if (!MyDataReader.Read())
            {
               /* MyCommand.CommandText = "create procedure GetAuthorsByLastName" +
                " (@au_lname varchar(40), select * from authors where" +
                " au_lname like @au_lname; select @RowCount=@@ROWCOUNT";*/
                MyDataReader.Close();
                MyCommand.ExecuteNonQuery();
            }
            else
            {

                MyDataReader.Close();
            }

            MyCommand.Dispose();  //Dispose of the Command object.
            MyConnection.Close(); //Close the connection.
        }

        // Add the event handler to the Button_Click event.
         //this.btnGetAuthors.Click += new System.EventHandler(this.btnGetAuthors_Click);

        }
    }