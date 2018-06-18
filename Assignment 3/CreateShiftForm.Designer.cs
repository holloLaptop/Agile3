﻿namespace Assignment_3
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
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.getEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.lbl_job = new System.Windows.Forms.Label();
            this.comboBox_job = new System.Windows.Forms.ComboBox();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.getEmployeesTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter();
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Location = new System.Drawing.Point(12, 10);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(87, 17);
            this.lbl_employeeID.TabIndex = 0;
            this.lbl_employeeID.Text = "Employee ID";
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getEmployeesBindingSource, "EmployeeID", true));
            this.comboBox_employeeID.DataSource = this.getEmployeesBindingSource;
            this.comboBox_employeeID.DisplayMember = "Name";
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(108, 8);
            this.comboBox_employeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(264, 24);
            this.comboBox_employeeID.TabIndex = 1;
            this.comboBox_employeeID.ValueMember = "EmployeeID";
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
            this.lbl_job.Location = new System.Drawing.Point(12, 42);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(31, 17);
            this.lbl_job.TabIndex = 2;
            this.lbl_job.Text = "Job";
            // 
            // comboBox_job
            // 
            this.comboBox_job.DataSource = this.getJobsBindingSource;
            this.comboBox_job.DisplayMember = "BusinessName";
            this.comboBox_job.FormattingEnabled = true;
            this.comboBox_job.Location = new System.Drawing.Point(108, 40);
            this.comboBox_job.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_job.Name = "comboBox_job";
            this.comboBox_job.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_job.Size = new System.Drawing.Size(264, 24);
            this.comboBox_job.TabIndex = 3;
            this.comboBox_job.ValueMember = "JobID";
            // 
            // getJobsBindingSource
            // 
            this.getJobsBindingSource.DataMember = "GetJobs";
            this.getJobsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(12, 74);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(77, 17);
            this.lbl_startTime.TabIndex = 4;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 104);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 72);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2018, 6, 18, 0, 0, 0, 0);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(286, 140);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 29);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(11, 106);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(72, 17);
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
            // CreateShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_startTime);
            this.Controls.Add(this.comboBox_job);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.lbl_employeeID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(406, 233);
            this.MinimumSize = new System.Drawing.Size(406, 233);
            this.Name = "CreateShiftForm";
            this.Text = "CreateShiftForm";
            this.Load += new System.EventHandler(this.CreateShiftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.ComboBox comboBox_employeeID;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.ComboBox comboBox_job;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_endTime;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private System.Windows.Forms.BindingSource getEmployeesBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter getEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource getJobsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter getJobsTableAdapter;
        public AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}