namespace Assignment_3
{
    partial class CreateJobForm
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
            this.lbl_clientID = new System.Windows.Forms.Label();
            this.lbl_shortDescription = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.comboBox_clientID = new System.Windows.Forms.ComboBox();
            this.getClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.txt_shortDescription = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.numUD_priority = new System.Windows.Forms.NumericUpDown();
            this.date_startTime = new System.Windows.Forms.DateTimePicker();
            this.date_endTime = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.getClientsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetClientsTableAdapter();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_priority)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_clientID
            // 
            this.lbl_clientID.AutoSize = true;
            this.lbl_clientID.Location = new System.Drawing.Point(14, 12);
            this.lbl_clientID.Name = "lbl_clientID";
            this.lbl_clientID.Size = new System.Drawing.Size(76, 20);
            this.lbl_clientID.TabIndex = 0;
            this.lbl_clientID.Text = "Client ID*";
            // 
            // lbl_shortDescription
            // 
            this.lbl_shortDescription.AutoSize = true;
            this.lbl_shortDescription.Location = new System.Drawing.Point(14, 52);
            this.lbl_shortDescription.Name = "lbl_shortDescription";
            this.lbl_shortDescription.Size = new System.Drawing.Size(138, 20);
            this.lbl_shortDescription.TabIndex = 1;
            this.lbl_shortDescription.Text = "Short Description*";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(14, 92);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(76, 20);
            this.lbl_location.TabIndex = 3;
            this.lbl_location.Text = "Location*";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Location = new System.Drawing.Point(14, 132);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(56, 20);
            this.lbl_priority.TabIndex = 4;
            this.lbl_priority.Text = "Priority";
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(14, 172);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(86, 20);
            this.lbl_startTime.TabIndex = 5;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(14, 212);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(80, 20);
            this.lbl_endTime.TabIndex = 6;
            this.lbl_endTime.Text = "End Time:";
            // 
            // comboBox_clientID
            // 
            this.comboBox_clientID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.getClientsBindingSource, "PersonID", true));
            this.comboBox_clientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientID.FormattingEnabled = true;
            this.comboBox_clientID.Location = new System.Drawing.Point(158, 12);
            this.comboBox_clientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_clientID.Name = "comboBox_clientID";
            this.comboBox_clientID.Size = new System.Drawing.Size(371, 28);
            this.comboBox_clientID.TabIndex = 7;
            // 
            // getClientsBindingSource
            // 
            this.getClientsBindingSource.DataMember = "GetClients";
            this.getClientsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // agileDevelopmentDataSet
            // 
            this.agileDevelopmentDataSet.DataSetName = "AgileDevelopmentDataSet";
            this.agileDevelopmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_shortDescription
            // 
            this.txt_shortDescription.Location = new System.Drawing.Point(158, 52);
            this.txt_shortDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_shortDescription.Name = "txt_shortDescription";
            this.txt_shortDescription.Size = new System.Drawing.Size(371, 26);
            this.txt_shortDescription.TabIndex = 8;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(158, 92);
            this.txt_location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(371, 26);
            this.txt_location.TabIndex = 10;
            // 
            // numUD_priority
            // 
            this.numUD_priority.Location = new System.Drawing.Point(158, 132);
            this.numUD_priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUD_priority.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUD_priority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_priority.Name = "numUD_priority";
            this.numUD_priority.Size = new System.Drawing.Size(46, 26);
            this.numUD_priority.TabIndex = 11;
            this.numUD_priority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // date_startTime
            // 
            this.date_startTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_startTime.Location = new System.Drawing.Point(158, 172);
            this.date_startTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_startTime.Name = "date_startTime";
            this.date_startTime.Size = new System.Drawing.Size(296, 26);
            this.date_startTime.TabIndex = 12;
            // 
            // date_endTime
            // 
            this.date_endTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.date_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_endTime.Location = new System.Drawing.Point(158, 212);
            this.date_endTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_endTime.Name = "date_endTime";
            this.date_endTime.Size = new System.Drawing.Size(296, 26);
            this.date_endTime.TabIndex = 13;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(433, 259);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 36);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // getClientsTableAdapter
            // 
            this.getClientsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 296);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.date_endTime);
            this.Controls.Add(this.date_startTime);
            this.Controls.Add(this.numUD_priority);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_shortDescription);
            this.Controls.Add(this.comboBox_clientID);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.lbl_startTime);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_shortDescription);
            this.Controls.Add(this.lbl_clientID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(559, 352);
            this.MinimumSize = new System.Drawing.Size(559, 352);
            this.Name = "CreateJobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "New Job";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateJobForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_clientID;
        private System.Windows.Forms.Label lbl_shortDescription;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.ComboBox comboBox_clientID;
        private System.Windows.Forms.TextBox txt_shortDescription;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.NumericUpDown numUD_priority;
        private System.Windows.Forms.DateTimePicker date_startTime;
        private System.Windows.Forms.DateTimePicker date_endTime;
        private System.Windows.Forms.Button btn_submit;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private System.Windows.Forms.BindingSource getClientsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetClientsTableAdapter getClientsTableAdapter;
        private AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}