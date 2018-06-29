namespace Assignment_3
{
    partial class EmployeeJobsForm
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
            this.components = new System.ComponentModel.Container();
            this.lbl_jobs = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.grpBox_completed = new System.Windows.Forms.GroupBox();
            this.date_completedTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateCompleted = new System.Windows.Forms.Label();
            this.txt_amountCharged = new System.Windows.Forms.TextBox();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.lbl_priceCharged = new System.Windows.Forms.Label();
            this.checkBox_completed = new System.Windows.Forms.CheckBox();
            this.comboBox_jobs = new System.Windows.Forms.ComboBox();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_updateClientInfo = new System.Windows.Forms.Button();
            this.btn_editClientInfo = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_landLine = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_businessName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_ShiftCompleted = new System.Windows.Forms.DateTimePicker();
            this.dtp_ShiftStarted = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_shifts = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.checkBox_paid = new System.Windows.Forms.CheckBox();
            this.grpBox_completed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_jobs
            // 
            this.lbl_jobs.AutoSize = true;
            this.lbl_jobs.Location = new System.Drawing.Point(7, 10);
            this.lbl_jobs.Name = "lbl_jobs";
            this.lbl_jobs.Size = new System.Drawing.Size(43, 20);
            this.lbl_jobs.TabIndex = 0;
            this.lbl_jobs.Text = "Jobs";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(7, 15);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(95, 20);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client Name";
            this.lbl_client.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(7, 51);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(89, 20);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Description";
            this.lbl_description.Click += new System.EventHandler(this.lbl_description_Click);
            // 
            // grpBox_completed
            // 
            this.grpBox_completed.Controls.Add(this.checkBox_paid);
            this.grpBox_completed.Controls.Add(this.date_completedTime);
            this.grpBox_completed.Controls.Add(this.lbl_dateCompleted);
            this.grpBox_completed.Controls.Add(this.txt_amountCharged);
            this.grpBox_completed.Controls.Add(this.txt_notes);
            this.grpBox_completed.Controls.Add(this.lbl_notes);
            this.grpBox_completed.Controls.Add(this.lbl_priceCharged);
            this.grpBox_completed.Location = new System.Drawing.Point(3, 228);
            this.grpBox_completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_completed.Name = "grpBox_completed";
            this.grpBox_completed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_completed.Size = new System.Drawing.Size(467, 234);
            this.grpBox_completed.TabIndex = 5;
            this.grpBox_completed.TabStop = false;
            // 
            // date_completedTime
            // 
            this.date_completedTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_completedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_completedTime.Location = new System.Drawing.Point(162, 22);
            this.date_completedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_completedTime.Name = "date_completedTime";
            this.date_completedTime.Size = new System.Drawing.Size(290, 26);
            this.date_completedTime.TabIndex = 6;
            this.date_completedTime.ValueChanged += new System.EventHandler(this.date_completedTime_ValueChanged);
            // 
            // lbl_dateCompleted
            // 
            this.lbl_dateCompleted.AutoSize = true;
            this.lbl_dateCompleted.Location = new System.Drawing.Point(7, 26);
            this.lbl_dateCompleted.Name = "lbl_dateCompleted";
            this.lbl_dateCompleted.Size = new System.Drawing.Size(129, 20);
            this.lbl_dateCompleted.TabIndex = 5;
            this.lbl_dateCompleted.Text = "Date Completed:";
            // 
            // txt_amountCharged
            // 
            this.txt_amountCharged.Location = new System.Drawing.Point(162, 62);
            this.txt_amountCharged.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amountCharged.Name = "txt_amountCharged";
            this.txt_amountCharged.Size = new System.Drawing.Size(138, 26);
            this.txt_amountCharged.TabIndex = 4;
            this.txt_amountCharged.TextChanged += new System.EventHandler(this.txt_amountCharged_TextChanged);
            this.txt_amountCharged.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amountCharged_KeyPress);
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(162, 102);
            this.txt_notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(290, 118);
            this.txt_notes.TabIndex = 3;
            this.txt_notes.TextChanged += new System.EventHandler(this.txt_notes_TextChanged);
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(7, 106);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(51, 20);
            this.lbl_notes.TabIndex = 1;
            this.lbl_notes.Text = "Notes";
            // 
            // lbl_priceCharged
            // 
            this.lbl_priceCharged.AutoSize = true;
            this.lbl_priceCharged.Location = new System.Drawing.Point(7, 66);
            this.lbl_priceCharged.Name = "lbl_priceCharged";
            this.lbl_priceCharged.Size = new System.Drawing.Size(130, 20);
            this.lbl_priceCharged.TabIndex = 0;
            this.lbl_priceCharged.Text = "Amount Charged";
            // 
            // checkBox_completed
            // 
            this.checkBox_completed.AutoSize = true;
            this.checkBox_completed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_completed.Location = new System.Drawing.Point(7, 196);
            this.checkBox_completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_completed.Name = "checkBox_completed";
            this.checkBox_completed.Size = new System.Drawing.Size(121, 24);
            this.checkBox_completed.TabIndex = 4;
            this.checkBox_completed.Text = "Completed?";
            this.checkBox_completed.UseVisualStyleBackColor = true;
            this.checkBox_completed.CheckedChanged += new System.EventHandler(this.checkBox_completed_CheckedChanged);
            // 
            // comboBox_jobs
            // 
            this.comboBox_jobs.FormattingEnabled = true;
            this.comboBox_jobs.Location = new System.Drawing.Point(107, 8);
            this.comboBox_jobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_jobs.Name = "comboBox_jobs";
            this.comboBox_jobs.Size = new System.Drawing.Size(203, 28);
            this.comboBox_jobs.TabIndex = 6;
            this.comboBox_jobs.SelectedIndexChanged += new System.EventHandler(this.comboBox_jobs_SelectedIndexChanged);
            // 
            // getJobsBindingSource
            // 
            this.getJobsBindingSource.DataMember = "GetJobs";
            this.getJobsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // agileDevelopmentDataSet
            // 
            this.agileDevelopmentDataSet.DataSetName = "AgileDevelopmentDataSet";
            this.agileDevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getJobsTableAdapter
            // 
            this.getJobsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_client
            // 
            this.comboBox_client.DataSource = this.getJobsBindingSource;
            this.comboBox_client.DisplayMember = "Name";
            this.comboBox_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_client.Enabled = false;
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(162, 15);
            this.comboBox_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(290, 30);
            this.comboBox_client.TabIndex = 7;
            this.comboBox_client.ValueMember = "PersonID";
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_client_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(389, 642);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 36);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(343, 1);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(119, 38);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "Import Jobs";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 511);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_description);
            this.tabPage1.Controls.Add(this.lbl_jobs);
            this.tabPage1.Controls.Add(this.btn_import);
            this.tabPage1.Controls.Add(this.grpBox_completed);
            this.tabPage1.Controls.Add(this.checkBox_completed);
            this.tabPage1.Controls.Add(this.comboBox_jobs);
            this.tabPage1.Controls.Add(this.lbl_description);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(468, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_description
            // 
            this.txt_description.Enabled = false;
            this.txt_description.Location = new System.Drawing.Point(107, 51);
            this.txt_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(348, 88);
            this.txt_description.TabIndex = 12;
            this.txt_description.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(486, 206);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(484, 310);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_updateClientInfo);
            this.tabPage2.Controls.Add(this.btn_editClientInfo);
            this.tabPage2.Controls.Add(this.txt_email);
            this.tabPage2.Controls.Add(this.txt_mobile);
            this.tabPage2.Controls.Add(this.txt_landLine);
            this.tabPage2.Controls.Add(this.txt_address);
            this.tabPage2.Controls.Add(this.txt_businessName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbl_client);
            this.tabPage2.Controls.Add(this.comboBox_client);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(476, 277);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Client Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_updateClientInfo
            // 
            this.btn_updateClientInfo.Location = new System.Drawing.Point(314, 229);
            this.btn_updateClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateClientInfo.Name = "btn_updateClientInfo";
            this.btn_updateClientInfo.Size = new System.Drawing.Size(138, 29);
            this.btn_updateClientInfo.TabIndex = 9;
            this.btn_updateClientInfo.Text = "Update Info";
            this.btn_updateClientInfo.UseVisualStyleBackColor = true;
            this.btn_updateClientInfo.Click += new System.EventHandler(this.btn_updateClientInfo_Click);
            // 
            // btn_editClientInfo
            // 
            this.btn_editClientInfo.Location = new System.Drawing.Point(162, 230);
            this.btn_editClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editClientInfo.Name = "btn_editClientInfo";
            this.btn_editClientInfo.Size = new System.Drawing.Size(138, 29);
            this.btn_editClientInfo.TabIndex = 9;
            this.btn_editClientInfo.Text = "Edit Client Info";
            this.btn_editClientInfo.UseVisualStyleBackColor = true;
            this.btn_editClientInfo.Click += new System.EventHandler(this.btn_editClientInfo_Click);
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(162, 194);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(290, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Enabled = false;
            this.txt_mobile.Location = new System.Drawing.Point(162, 159);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(290, 26);
            this.txt_mobile.TabIndex = 8;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_landLine
            // 
            this.txt_landLine.Enabled = false;
            this.txt_landLine.Location = new System.Drawing.Point(162, 124);
            this.txt_landLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(290, 26);
            this.txt_landLine.TabIndex = 8;
            this.txt_landLine.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Location = new System.Drawing.Point(162, 88);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(290, 26);
            this.txt_address.TabIndex = 8;
            // 
            // txt_businessName
            // 
            this.txt_businessName.Enabled = false;
            this.txt_businessName.Location = new System.Drawing.Point(162, 52);
            this.txt_businessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(290, 26);
            this.txt_businessName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mobile";
            this.label6.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "LandLine";
            this.label5.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Business Name";
            this.label3.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(486, 5);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(484, 194);
            this.tabControl3.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dtp_ShiftCompleted);
            this.tabPage3.Controls.Add(this.dtp_ShiftStarted);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.comboBox_shifts);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(476, 161);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Shift Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update Shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_ShiftCompleted
            // 
            this.dtp_ShiftCompleted.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtp_ShiftCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ShiftCompleted.Location = new System.Drawing.Point(162, 84);
            this.dtp_ShiftCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ShiftCompleted.Name = "dtp_ShiftCompleted";
            this.dtp_ShiftCompleted.Size = new System.Drawing.Size(290, 26);
            this.dtp_ShiftCompleted.TabIndex = 6;
            // 
            // dtp_ShiftStarted
            // 
            this.dtp_ShiftStarted.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtp_ShiftStarted.Enabled = false;
            this.dtp_ShiftStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ShiftStarted.Location = new System.Drawing.Point(162, 51);
            this.dtp_ShiftStarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ShiftStarted.Name = "dtp_ShiftStarted";
            this.dtp_ShiftStarted.Size = new System.Drawing.Size(290, 26);
            this.dtp_ShiftStarted.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Shift Completed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift";
            this.label1.Click += new System.EventHandler(this.lbl_client_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shift Started:";
            // 
            // comboBox_shifts
            // 
            this.comboBox_shifts.DisplayMember = "Name";
            this.comboBox_shifts.FormattingEnabled = true;
            this.comboBox_shifts.Location = new System.Drawing.Point(162, 11);
            this.comboBox_shifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_shifts.Name = "comboBox_shifts";
            this.comboBox_shifts.Size = new System.Drawing.Size(290, 28);
            this.comboBox_shifts.TabIndex = 7;
            this.comboBox_shifts.ValueMember = "PersonID";
            this.comboBox_shifts.SelectedIndexChanged += new System.EventHandler(this.comboBox_shifts_SelectedIndexChanged);
            this.comboBox_shifts.TextUpdate += new System.EventHandler(this.comboBox_shifts_SelectedIndexChanged);
            this.comboBox_shifts.SelectedValueChanged += new System.EventHandler(this.comboBox_shifts_SelectedIndexChanged);
            this.comboBox_shifts.TextChanged += new System.EventHandler(this.comboBox_shifts_SelectedIndexChanged);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(846, 522);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(119, 38);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // checkBox_paid
            // 
            this.checkBox_paid.AutoSize = true;
            this.checkBox_paid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_paid.Location = new System.Drawing.Point(327, 66);
            this.checkBox_paid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_paid.Name = "checkBox_paid";
            this.checkBox_paid.Size = new System.Drawing.Size(75, 24);
            this.checkBox_paid.TabIndex = 7;
            this.checkBox_paid.Text = "Paid?";
            this.checkBox_paid.UseVisualStyleBackColor = true;
            this.checkBox_paid.CheckStateChanged += new System.EventHandler(this.checkBox_paid_CheckStateChanged);
            // 
            // EmployeeJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 569);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeJobsForm";
            this.Text = "Export Jobs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeJobsForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeJobs_Load);
            this.grpBox_completed.ResumeLayout(false);
            this.grpBox_completed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_jobs;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.GroupBox grpBox_completed;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.Label lbl_priceCharged;
        private System.Windows.Forms.TextBox txt_amountCharged;
        private System.Windows.Forms.CheckBox checkBox_completed;
        private System.Windows.Forms.ComboBox comboBox_jobs;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private System.Windows.Forms.BindingSource getJobsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter getJobsTableAdapter;
        private System.Windows.Forms.DateTimePicker date_completedTime;
        private System.Windows.Forms.Label lbl_dateCompleted;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtp_ShiftStarted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_landLine;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_businessName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_updateClientInfo;
        private System.Windows.Forms.Button btn_editClientInfo;
        private System.Windows.Forms.DateTimePicker dtp_ShiftCompleted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.CheckBox checkBox_paid;
    }
}