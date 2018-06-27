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
    public partial class PrintJobForm : Form
    {
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
    }
}
