namespace Assignment_3
{
    partial class EmployeeJobs
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
            this.comboBox_shortDescription = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.grpBox_completed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_jobs
            // 
            this.lbl_jobs.AutoSize = true;
            this.lbl_jobs.Location = new System.Drawing.Point(11, 10);
            this.lbl_jobs.Name = "lbl_jobs";
            this.lbl_jobs.Size = new System.Drawing.Size(38, 17);
            this.lbl_jobs.TabIndex = 0;
            this.lbl_jobs.Text = "Jobs";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(11, 42);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(43, 17);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(11, 74);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "Description";
            // 
            // grpBox_completed
            // 
            this.grpBox_completed.Controls.Add(this.date_completedTime);
            this.grpBox_completed.Controls.Add(this.lbl_dateCompleted);
            this.grpBox_completed.Controls.Add(this.txt_amountCharged);
            this.grpBox_completed.Controls.Add(this.txt_notes);
            this.grpBox_completed.Controls.Add(this.lbl_notes);
            this.grpBox_completed.Controls.Add(this.lbl_priceCharged);
            this.grpBox_completed.Location = new System.Drawing.Point(14, 162);
            this.grpBox_completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_completed.Name = "grpBox_completed";
            this.grpBox_completed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBox_completed.Size = new System.Drawing.Size(415, 187);
            this.grpBox_completed.TabIndex = 5;
            this.grpBox_completed.TabStop = false;
            // 
            // date_completedTime
            // 
            this.date_completedTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_completedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_completedTime.Location = new System.Drawing.Point(144, 18);
            this.date_completedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_completedTime.Name = "date_completedTime";
            this.date_completedTime.Size = new System.Drawing.Size(258, 22);
            this.date_completedTime.TabIndex = 6;
            // 
            // lbl_dateCompleted
            // 
            this.lbl_dateCompleted.AutoSize = true;
            this.lbl_dateCompleted.Location = new System.Drawing.Point(6, 21);
            this.lbl_dateCompleted.Name = "lbl_dateCompleted";
            this.lbl_dateCompleted.Size = new System.Drawing.Size(113, 17);
            this.lbl_dateCompleted.TabIndex = 5;
            this.lbl_dateCompleted.Text = "Date Completed:";
            // 
            // txt_amountCharged
            // 
            this.txt_amountCharged.Location = new System.Drawing.Point(144, 50);
            this.txt_amountCharged.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amountCharged.Name = "txt_amountCharged";
            this.txt_amountCharged.Size = new System.Drawing.Size(123, 22);
            this.txt_amountCharged.TabIndex = 4;
            this.txt_amountCharged.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amountCharged_KeyPress);
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(144, 82);
            this.txt_notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(258, 95);
            this.txt_notes.TabIndex = 3;
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(6, 85);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(45, 17);
            this.lbl_notes.TabIndex = 1;
            this.lbl_notes.Text = "Notes";
            // 
            // lbl_priceCharged
            // 
            this.lbl_priceCharged.AutoSize = true;
            this.lbl_priceCharged.Location = new System.Drawing.Point(6, 53);
            this.lbl_priceCharged.Name = "lbl_priceCharged";
            this.lbl_priceCharged.Size = new System.Drawing.Size(114, 17);
            this.lbl_priceCharged.TabIndex = 0;
            this.lbl_priceCharged.Text = "Amount Charged";
            // 
            // checkBox_completed
            // 
            this.checkBox_completed.AutoSize = true;
            this.checkBox_completed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_completed.Location = new System.Drawing.Point(12, 146);
            this.checkBox_completed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_completed.Name = "checkBox_completed";
            this.checkBox_completed.Size = new System.Drawing.Size(105, 21);
            this.checkBox_completed.TabIndex = 4;
            this.checkBox_completed.Text = "Completed?";
            this.checkBox_completed.UseVisualStyleBackColor = true;
            this.checkBox_completed.CheckedChanged += new System.EventHandler(this.checkBox_completed_CheckedChanged);
            // 
            // comboBox_jobs
            // 
            this.comboBox_jobs.FormattingEnabled = true;
            this.comboBox_jobs.Location = new System.Drawing.Point(100, 8);
            this.comboBox_jobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_jobs.Name = "comboBox_jobs";
            this.comboBox_jobs.Size = new System.Drawing.Size(181, 24);
            this.comboBox_jobs.TabIndex = 6;
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
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(100, 40);
            this.comboBox_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(181, 25);
            this.comboBox_client.TabIndex = 7;
            this.comboBox_client.ValueMember = "PersonID";
            // 
            // comboBox_shortDescription
            // 
            this.comboBox_shortDescription.DataSource = this.getJobsBindingSource;
            this.comboBox_shortDescription.DisplayMember = "ShortDescription";
            this.comboBox_shortDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_shortDescription.FormattingEnabled = true;
            this.comboBox_shortDescription.Location = new System.Drawing.Point(100, 72);
            this.comboBox_shortDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_shortDescription.Name = "comboBox_shortDescription";
            this.comboBox_shortDescription.Size = new System.Drawing.Size(316, 73);
            this.comboBox_shortDescription.TabIndex = 8;
            this.comboBox_shortDescription.ValueMember = "ShortDescription";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(346, 357);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 29);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(311, 8);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(105, 22);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "Import Jobs";
            this.btn_import.UseVisualStyleBackColor = true;
            // 
            // EmployeeJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 394);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox_shortDescription);
            this.Controls.Add(this.comboBox_client);
            this.Controls.Add(this.comboBox_jobs);
            this.Controls.Add(this.checkBox_completed);
            this.Controls.Add(this.grpBox_completed);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_jobs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeJobs";
            this.Text = "EmployeeJobs";
            this.Load += new System.EventHandler(this.EmployeeJobs_Load);
            this.grpBox_completed.ResumeLayout(false);
            this.grpBox_completed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox comboBox_shortDescription;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_import;
    }
}