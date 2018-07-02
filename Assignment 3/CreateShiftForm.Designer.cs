namespace Assignment_3
{
    partial class CreateShiftForm
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
            this.lbl_employeeName = new System.Windows.Forms.Label();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.getEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.lbl_job = new System.Windows.Forms.Label();
            this.comboBox_job = new System.Windows.Forms.ComboBox();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.date_endTime = new System.Windows.Forms.DateTimePicker();
            this.date_startTime = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.getEmployeesTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter();
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.agileDevelopmentDataSet1 = new Assignment_3.AgileDevelopmentDataSet();
            this.queriesTableAdapter2 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_employeeName
            // 
            this.lbl_employeeName.AutoSize = true;
            this.lbl_employeeName.Location = new System.Drawing.Point(14, 12);
            this.lbl_employeeName.Name = "lbl_employeeName";
            this.lbl_employeeName.Size = new System.Drawing.Size(131, 20);
            this.lbl_employeeName.TabIndex = 0;
            this.lbl_employeeName.Text = "Employee Name*";
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getEmployeesBindingSource, "EmployeeID", true));
            this.comboBox_employeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(145, 10);
            this.comboBox_employeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(296, 28);
            this.comboBox_employeeID.TabIndex = 1;
            // 
            // getEmployeesBindingSource
            // 
            this.getEmployeesBindingSource.DataMember = "GetEmployees";
            this.getEmployeesBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // agileDevelopmentDataSet
            // 
            this.agileDevelopmentDataSet.DataSetName = "AgileDevelopmentDataSet";
            this.agileDevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Location = new System.Drawing.Point(14, 52);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(41, 20);
            this.lbl_job.TabIndex = 2;
            this.lbl_job.Text = "Job*";
            // 
            // comboBox_job
            // 
            this.comboBox_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_job.FormattingEnabled = true;
            this.comboBox_job.Location = new System.Drawing.Point(145, 50);
            this.comboBox_job.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_job.Name = "comboBox_job";
            this.comboBox_job.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_job.Size = new System.Drawing.Size(296, 28);
            this.comboBox_job.TabIndex = 3;
            // 
            // getJobsBindingSource
            // 
            this.getJobsBindingSource.DataMember = "GetJobs";
            this.getJobsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(14, 92);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(86, 20);
            this.lbl_startTime.TabIndex = 4;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // date_endTime
            // 
            this.date_endTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_endTime.Location = new System.Drawing.Point(145, 130);
            this.date_endTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_endTime.Name = "date_endTime";
            this.date_endTime.Size = new System.Drawing.Size(296, 26);
            this.date_endTime.TabIndex = 7;
            // 
            // date_startTime
            // 
            this.date_startTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_startTime.Location = new System.Drawing.Point(145, 90);
            this.date_startTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_startTime.Name = "date_startTime";
            this.date_startTime.Size = new System.Drawing.Size(296, 26);
            this.date_startTime.TabIndex = 8;
            this.date_startTime.Value = new System.DateTime(2018, 6, 18, 0, 0, 0, 0);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(346, 172);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 36);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(14, 132);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(80, 20);
            this.lbl_endTime.TabIndex = 10;
            this.lbl_endTime.Text = "End Time:";
            // 
            // getEmployeesTableAdapter
            // 
            this.getEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // getJobsTableAdapter
            // 
            this.getJobsTableAdapter.ClearBeforeFill = true;
            // 
            // agileDevelopmentDataSet1
            // 
            this.agileDevelopmentDataSet1.DataSetName = "AgileDevelopmentDataSet";
            this.agileDevelopmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "GetEmployees";
            this.bindingSource1.DataSource = this.agileDevelopmentDataSet1;
            // 
            // CreateShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(450, 211);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.date_startTime);
            this.Controls.Add(this.date_endTime);
            this.Controls.Add(this.lbl_startTime);
            this.Controls.Add(this.comboBox_job);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.lbl_employeeName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(472, 267);
            this.MinimumSize = new System.Drawing.Size(472, 267);
            this.Name = "CreateShiftForm";
            this.Text = "Create Shift";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateShiftForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateShiftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employeeName;
        private System.Windows.Forms.ComboBox comboBox_employeeID;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.ComboBox comboBox_job;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.DateTimePicker date_endTime;
        private System.Windows.Forms.DateTimePicker date_startTime;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_endTime;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private System.Windows.Forms.BindingSource getEmployeesBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter getEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource getJobsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter getJobsTableAdapter;
        public AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private AgileDevelopmentDataSet agileDevelopmentDataSet1;
        public AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}