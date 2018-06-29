using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class PrintJobForm : Form
    {
        Package p = new Package();

        PaintEventArgs paintEventArg; // Creates a global PEA that can be used for Print (without having to pass as parameter).

        // Keeps track of the parent form.
        Form offlineMenuForm = new OfflineMenuForm(null);

        public PrintJobForm(Form offlineMenuForm)
        {
            InitializeComponent();
            this.offlineMenuForm = offlineMenuForm;
        }

        private void PrintJobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            offlineMenuForm.Show();
        }

        private void btn_importJobs_Click(object sender, EventArgs e)
        {
            //clears imported jobs to prevent duplicates
            p.Clients.Clear();
            p.JobInformation.Clear();
            p.Contractor = null;
            comboBox_jobs.Controls.Clear();
            comboBox_jobs.Items.Clear();

            //Loads data
            p.Deserialise();

            int countJobs = 0; // Keep track of how many jobs are imported into the form.

            //importing jobs into dropdown box
            for (int i = 0; i < p.JobInformation.Count; i++)
            {
                // We only want to be able to print invoices for completed jobs;
                //  completion is determined by whether the client has been 'charged' or not.
                if (p.JobInformation[i].Charged > 0)
                {
                    updateFormDetails(p.JobInformation[i]);
                    countJobs += 1;
                }
            }

            if (countJobs > 0)
            {
                comboBox_jobs.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error: There are no jobs to print.", "No Jobs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updateFormDetails(Job currentJob)
        {
            Contractors contractor = p.Contractor;

            //used the custom class for simplification
            ComboboxItem item = new ComboboxItem();

            // JOB
            //  Job
            item.Text = currentJob.ID.ToString();
            while (item.Text.Contains("  ")) item.Text = item.Text.Replace("  ", " ");
            item.Value = currentJob.ID;
            comboBox_jobs.Items.Add(item);

            //  Contractor
            txt_contractor.Text = contractor.Name.ToString();

            //  Description
            txt_description.Text = currentJob.ShortDescription;

            //  Fee
            txt_fee.Text = currentJob.Charged.ToString();

            // CLIENT
            //  Name
            txt_name.Text = currentJob.client.name;

            //  Business
            txt_business.Text = currentJob.client.BusinessName;

            //  Address
            txt_address.Text = currentJob.client.address;

            //  Land Line
            txt_landLine.Text = currentJob.client.landLine.ToString();

            //  Mobile
            txt_mobile.Text = currentJob.client.mobile.ToString();

            //  Email
            txt_email.Text = currentJob.client.email;
        }

        // Prepare the information for printing.
        private void btn_confirmPrint_Click(object sender, EventArgs e)
        {
            // Check if Fee is null; safest value to check as we already check this when we import jobs.
            if (txt_fee != null)
            {
                string text = "Contractor: " + txt_contractor.Text + "\n" +
                    "Job Description: " + txt_description.Text + "\n" +
                    "Charged: $" + txt_fee.Text + "\n" + "\n" +
                    "FOR THE CLIENT:" + "\n" +
                    "Name: " + txt_name.Text + "\n" +
                    "Business: " + txt_business.Text + "\n" +
                    "Address: " + txt_address.Text + "\n" +
                    "Land Line No.: " + txt_landLine.Text + "\n" +
                    "Mobile Ph. No.: " + txt_mobile.Text + "\n" +
                    "Email: " + txt_email.Text + "\n";

                Print(text);
            } else
            {
                MessageBox.Show("Error: Required fields missing.", "Fields Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Print the page in an invoice format.
        private void Print(string text)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPageEvent);

            Graphics g = paintEventArg.Graphics;

            SolidBrush solidBlackBrush = new SolidBrush(Color.Black);
            Font arial12 = new Font("Arial", 12);
            g.DrawString(text, arial12, solidBlackBrush, 10, 10);

            base.OnPaint(paintEventArg);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = pd;
            printPreview.ShowDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintPageEvent(object sender, PrintPageEventArgs ev)
        {
            Graphics g = ev.Graphics;

            float maxHeight = ev.PageSettings.PrintableArea.Height;
            float maxWidth = ev.PageSettings.PrintableArea.Width;
            float marginLeft = ev.PageSettings.Margins.Left;
            float marginRight = ev.PageSettings.Margins.Right;
            float marginTop = ev.PageSettings.Margins.Top;
            float marginBottom = ev.PageSettings.Margins.Bottom;
        }
    }
}
