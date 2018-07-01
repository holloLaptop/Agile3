namespace Assignment_3
{
    partial class ExportJobsForm
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
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.date_startTime = new System.Windows.Forms.DateTimePicker();
            this.date_endTime = new System.Windows.Forms.DateTimePicker();
            this.btn_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.agileDevelopmentDataSet1 = new Assignment_3.AgileDevelopmentDataSet();
            this.getEmployeesTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.getShiftForEmployeeTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetShiftForEmployeeTableAdapter();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getShiftForEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getShiftForEmployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShiftForEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShiftForEmployeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(17, 52);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(86, 20);
            this.lbl_startTime.TabIndex = 0;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(17, 92);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(80, 20);
            this.lbl_endTime.TabIndex = 1;
            this.lbl_endTime.Text = "End Time:";
            // 
            // date_startTime
            // 
            this.date_startTime.Location = new System.Drawing.Point(109, 50);
            this.date_startTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_startTime.Name = "date_startTime";
            this.date_startTime.Size = new System.Drawing.Size(296, 26);
            this.date_startTime.TabIndex = 2;
            this.date_startTime.ValueChanged += new System.EventHandler(this.date_startTime_ValueChanged);
            // 
            // date_endTime
            // 
            this.date_endTime.Location = new System.Drawing.Point(109, 90);
            this.date_endTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_endTime.Name = "date_endTime";
            this.date_endTime.Size = new System.Drawing.Size(296, 26);
            this.date_endTime.TabIndex = 3;
            this.date_endTime.ValueChanged += new System.EventHandler(this.date_startTime_ValueChanged);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(310, 132);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(94, 36);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contractor";
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
            // agileDevelopmentDataSet1
            // 
            this.agileDevelopmentDataSet1.DataSetName = "AgileDevelopmentDataSet";
            this.agileDevelopmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeesTableAdapter
            // 
            this.getEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // getJobsBindingSource
            // 
            this.getJobsBindingSource.DataMember = "GetJobs";
            this.getJobsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // getJobsTableAdapter
            // 
            this.getJobsTableAdapter.ClearBeforeFill = true;
            // 
            // getShiftForEmployeeTableAdapter1
            // 
            this.getShiftForEmployeeTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getEmployeesBindingSource, "EmployeeID", true));
            this.comboBox_employeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(109, 10);
            this.comboBox_employeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(296, 28);
            this.comboBox_employeeID.TabIndex = 13;
            this.comboBox_employeeID.SelectedIndexChanged += new System.EventHandler(this.date_startTime_ValueChanged);
            this.comboBox_employeeID.ValueMemberChanged += new System.EventHandler(this.date_startTime_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.jobIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.landLineDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getShiftForEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(28, 31, 28, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 441);
            this.dataGridView1.TabIndex = 14;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // landLineDataGridViewTextBoxColumn
            // 
            this.landLineDataGridViewTextBoxColumn.DataPropertyName = "LandLine";
            this.landLineDataGridViewTextBoxColumn.HeaderText = "LandLine";
            this.landLineDataGridViewTextBoxColumn.Name = "landLineDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // getShiftForEmployeeBindingSource
            // 
            this.getShiftForEmployeeBindingSource.DataMember = "GetShiftForEmployee";
            this.getShiftForEmployeeBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // getShiftForEmployeeBindingSource1
            // 
            this.getShiftForEmployeeBindingSource1.DataMember = "GetShiftForEmployee";
            this.getShiftForEmployeeBindingSource1.DataSource = this.agileDevelopmentDataSet;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(212, 132);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(94, 36);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // ExportJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.date_endTime);
            this.Controls.Add(this.date_startTime);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.lbl_startTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1065, 681);
            this.Name = "ExportJobsForm";
            this.Text = "Import and Export Jobs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportJobsForm_FormClosed);
            this.Load += new System.EventHandler(this.ExportJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShiftForEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getShiftForEmployeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.DateTimePicker date_startTime;
        private System.Windows.Forms.DateTimePicker date_endTime;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource getEmployeesBindingSource;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private AgileDevelopmentDataSet agileDevelopmentDataSet1;
        private AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter getEmployeesTableAdapter;
        private System.Windows.Forms.BindingSource getJobsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter getJobsTableAdapter;
        public AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private AgileDevelopmentDataSetTableAdapters.GetShiftForEmployeeTableAdapter getShiftForEmployeeTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getShiftForEmployeeBindingSource;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.BindingSource getShiftForEmployeeBindingSource1;
        private System.Windows.Forms.ComboBox comboBox_employeeID;
    }
}