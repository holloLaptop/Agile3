namespace Assignment_3
{
    partial class PrintJobForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_job = new System.Windows.Forms.Label();
            this.comboBox_jobs = new System.Windows.Forms.ComboBox();
            this.btn_importJobs = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_businessName = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_landLine = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.grpBox_client = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_landLine = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_business = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_contractor = new System.Windows.Forms.Label();
            this.txt_contractor = new System.Windows.Forms.TextBox();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.btn_confirmPrint = new System.Windows.Forms.Button();
            this.grpBox_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Location = new System.Drawing.Point(11, 10);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(31, 17);
            this.lbl_job.TabIndex = 0;
            this.lbl_job.Text = "Job";
            // 
            // comboBox_jobs
            // 
            this.comboBox_jobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_jobs.FormattingEnabled = true;
            this.comboBox_jobs.Location = new System.Drawing.Point(95, 8);
            this.comboBox_jobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_jobs.Name = "comboBox_jobs";
            this.comboBox_jobs.Size = new System.Drawing.Size(260, 24);
            this.comboBox_jobs.TabIndex = 1;
            // 
            // btn_importJobs
            // 
            this.btn_importJobs.Location = new System.Drawing.Point(359, 6);
            this.btn_importJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_importJobs.Name = "btn_importJobs";
            this.btn_importJobs.Size = new System.Drawing.Size(95, 29);
            this.btn_importJobs.TabIndex = 2;
            this.btn_importJobs.Text = "Import Jobs";
            this.btn_importJobs.UseVisualStyleBackColor = true;
            this.btn_importJobs.Click += new System.EventHandler(this.btn_importJobs_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(11, 74);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 3;
            this.lbl_description.Text = "Description";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(5, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            // 
            // lbl_businessName
            // 
            this.lbl_businessName.AutoSize = true;
            this.lbl_businessName.Location = new System.Drawing.Point(5, 58);
            this.lbl_businessName.Name = "lbl_businessName";
            this.lbl_businessName.Size = new System.Drawing.Size(65, 17);
            this.lbl_businessName.TabIndex = 14;
            this.lbl_businessName.Text = "Business";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(5, 90);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 15;
            this.lbl_address.Text = "Address";
            // 
            // lbl_landLine
            // 
            this.lbl_landLine.AutoSize = true;
            this.lbl_landLine.Location = new System.Drawing.Point(5, 122);
            this.lbl_landLine.Name = "lbl_landLine";
            this.lbl_landLine.Size = new System.Drawing.Size(97, 17);
            this.lbl_landLine.TabIndex = 16;
            this.lbl_landLine.Text = "Land Line No.";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Location = new System.Drawing.Point(5, 154);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(75, 17);
            this.lbl_mobile.TabIndex = 17;
            this.lbl_mobile.Text = "Mobile No.";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(5, 186);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email";
            // 
            // grpBox_client
            // 
            this.grpBox_client.Controls.Add(this.txt_email);
            this.grpBox_client.Controls.Add(this.txt_mobile);
            this.grpBox_client.Controls.Add(this.txt_landLine);
            this.grpBox_client.Controls.Add(this.txt_address);
            this.grpBox_client.Controls.Add(this.txt_business);
            this.grpBox_client.Controls.Add(this.txt_name);
            this.grpBox_client.Controls.Add(this.lbl_name);
            this.grpBox_client.Controls.Add(this.lbl_email);
            this.grpBox_client.Controls.Add(this.lbl_businessName);
            this.grpBox_client.Controls.Add(this.lbl_mobile);
            this.grpBox_client.Controls.Add(this.lbl_address);
            this.grpBox_client.Controls.Add(this.lbl_landLine);
            this.grpBox_client.Location = new System.Drawing.Point(14, 166);
            this.grpBox_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_client.Name = "grpBox_client";
            this.grpBox_client.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_client.Size = new System.Drawing.Size(355, 226);
            this.grpBox_client.TabIndex = 19;
            this.grpBox_client.TabStop = false;
            this.grpBox_client.Text = "Client";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(109, 183);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(232, 22);
            this.txt_email.TabIndex = 24;
            // 
            // txt_mobile
            // 
            this.txt_mobile.BackColor = System.Drawing.SystemColors.Control;
            this.txt_mobile.Enabled = false;
            this.txt_mobile.Location = new System.Drawing.Point(109, 151);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.ReadOnly = true;
            this.txt_mobile.Size = new System.Drawing.Size(232, 22);
            this.txt_mobile.TabIndex = 23;
            // 
            // txt_landLine
            // 
            this.txt_landLine.BackColor = System.Drawing.SystemColors.Control;
            this.txt_landLine.Enabled = false;
            this.txt_landLine.Location = new System.Drawing.Point(109, 119);
            this.txt_landLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.ReadOnly = true;
            this.txt_landLine.Size = new System.Drawing.Size(232, 22);
            this.txt_landLine.TabIndex = 22;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Control;
            this.txt_address.Enabled = false;
            this.txt_address.Location = new System.Drawing.Point(109, 87);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.ReadOnly = true;
            this.txt_address.Size = new System.Drawing.Size(232, 22);
            this.txt_address.TabIndex = 21;
            // 
            // txt_business
            // 
            this.txt_business.BackColor = System.Drawing.SystemColors.Control;
            this.txt_business.Enabled = false;
            this.txt_business.Location = new System.Drawing.Point(109, 55);
            this.txt_business.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_business.Name = "txt_business";
            this.txt_business.ReadOnly = true;
            this.txt_business.Size = new System.Drawing.Size(232, 22);
            this.txt_business.TabIndex = 20;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(109, 23);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(232, 22);
            this.txt_name.TabIndex = 19;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.Control;
            this.txt_description.Enabled = false;
            this.txt_description.Location = new System.Drawing.Point(95, 72);
            this.txt_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(260, 47);
            this.txt_description.TabIndex = 25;
            // 
            // lbl_contractor
            // 
            this.lbl_contractor.AutoSize = true;
            this.lbl_contractor.Location = new System.Drawing.Point(11, 42);
            this.lbl_contractor.Name = "lbl_contractor";
            this.lbl_contractor.Size = new System.Drawing.Size(74, 17);
            this.lbl_contractor.TabIndex = 26;
            this.lbl_contractor.Text = "Contractor";
            // 
            // txt_contractor
            // 
            this.txt_contractor.BackColor = System.Drawing.SystemColors.Control;
            this.txt_contractor.Enabled = false;
            this.txt_contractor.Location = new System.Drawing.Point(95, 40);
            this.txt_contractor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contractor.Name = "txt_contractor";
            this.txt_contractor.ReadOnly = true;
            this.txt_contractor.Size = new System.Drawing.Size(260, 22);
            this.txt_contractor.TabIndex = 27;
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Location = new System.Drawing.Point(11, 130);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(32, 17);
            this.lbl_fee.TabIndex = 28;
            this.lbl_fee.Text = "Fee";
            // 
            // txt_fee
            // 
            this.txt_fee.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fee.Enabled = false;
            this.txt_fee.Location = new System.Drawing.Point(95, 128);
            this.txt_fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.ReadOnly = true;
            this.txt_fee.Size = new System.Drawing.Size(260, 22);
            this.txt_fee.TabIndex = 29;
            // 
            // btn_confirmPrint
            // 
            this.btn_confirmPrint.Location = new System.Drawing.Point(374, 394);
            this.btn_confirmPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirmPrint.Name = "btn_confirmPrint";
            this.btn_confirmPrint.Size = new System.Drawing.Size(80, 29);
            this.btn_confirmPrint.TabIndex = 30;
            this.btn_confirmPrint.Text = "Print";
            this.btn_confirmPrint.UseVisualStyleBackColor = true;
            this.btn_confirmPrint.Click += new System.EventHandler(this.btn_confirmPrint_Click);
            // 
            // PrintJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 439);
            this.Controls.Add(this.btn_confirmPrint);
            this.Controls.Add(this.txt_fee);
            this.Controls.Add(this.lbl_fee);
            this.Controls.Add(this.txt_contractor);
            this.Controls.Add(this.lbl_contractor);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.grpBox_client);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.btn_importJobs);
            this.Controls.Add(this.comboBox_jobs);
            this.Controls.Add(this.lbl_job);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(482, 486);
            this.MinimumSize = new System.Drawing.Size(482, 486);
            this.Name = "PrintJobForm";
            this.Text = "Print Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintJobForm_FormClosed);
            this.Load += new System.EventHandler(this.PrintJobForm_Load);
            this.grpBox_client.ResumeLayout(false);
            this.grpBox_client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.ComboBox comboBox_jobs;
        private System.Windows.Forms.Button btn_importJobs;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_businessName;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_landLine;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.GroupBox grpBox_client;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_landLine;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_business;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_contractor;
        private System.Windows.Forms.TextBox txt_contractor;
        private System.Windows.Forms.Label lbl_fee;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.Button btn_confirmPrint;
    }
}