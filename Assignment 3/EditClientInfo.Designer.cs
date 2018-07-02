namespace Assignment_3
{
    partial class EditClientInfo
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
            this.lbl_client = new System.Windows.Forms.Label();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
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
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.getClientsTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetClientsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(6, 12);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(84, 17);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client Name";
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
            this.comboBox_client.Location = new System.Drawing.Point(144, 12);
            this.comboBox_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(258, 25);
            this.comboBox_client.TabIndex = 7;
            this.comboBox_client.ValueMember = "PersonID";
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_clent_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(430, 277);
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
            this.tabPage2.Controls.Add(this.txt_clientName);
            this.tabPage2.Controls.Add(this.txt_businessName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_client);
            this.tabPage2.Controls.Add(this.comboBox_client);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(422, 248);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Client Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_updateClientInfo
            // 
            this.btn_updateClientInfo.Location = new System.Drawing.Point(279, 212);
            this.btn_updateClientInfo.Name = "btn_updateClientInfo";
            this.btn_updateClientInfo.Size = new System.Drawing.Size(123, 23);
            this.btn_updateClientInfo.TabIndex = 9;
            this.btn_updateClientInfo.Text = "Update Info";
            this.btn_updateClientInfo.UseVisualStyleBackColor = true;
            this.btn_updateClientInfo.Click += new System.EventHandler(this.btn_updateClientInfo_Click_1);
            // 
            // btn_editClientInfo
            // 
            this.btn_editClientInfo.Location = new System.Drawing.Point(144, 213);
            this.btn_editClientInfo.Name = "btn_editClientInfo";
            this.btn_editClientInfo.Size = new System.Drawing.Size(123, 23);
            this.btn_editClientInfo.TabIndex = 9;
            this.btn_editClientInfo.Text = "Edit Client Info";
            this.btn_editClientInfo.UseVisualStyleBackColor = true;
            this.btn_editClientInfo.Click += new System.EventHandler(this.btn_editClientInfo_Click_1);
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(144, 184);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(258, 22);
            this.txt_email.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Enabled = false;
            this.txt_mobile.Location = new System.Drawing.Point(144, 156);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(258, 22);
            this.txt_mobile.TabIndex = 8;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_landLine
            // 
            this.txt_landLine.Enabled = false;
            this.txt_landLine.Location = new System.Drawing.Point(144, 128);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(258, 22);
            this.txt_landLine.TabIndex = 8;
            this.txt_landLine.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Location = new System.Drawing.Point(144, 99);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(258, 22);
            this.txt_address.TabIndex = 8;
            // 
            // txt_businessName
            // 
            this.txt_businessName.Enabled = false;
            this.txt_businessName.Location = new System.Drawing.Point(144, 71);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(258, 22);
            this.txt_businessName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "LandLine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Business Name";
            // 
            // getClientsTableAdapter1
            // 
            this.getClientsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name";
            // 
            // txt_clientName
            // 
            this.txt_clientName.Enabled = false;
            this.txt_clientName.Location = new System.Drawing.Point(144, 43);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.Size = new System.Drawing.Size(258, 22);
            this.txt_clientName.TabIndex = 8;
            // 
            // EditClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 300);
            this.Controls.Add(this.tabControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditClientInfo";
            this.Text = "Edit Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeJobsForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_client;
        private AgileDevelopmentDataSet agileDevelopmentDataSet;
        private System.Windows.Forms.BindingSource getJobsBindingSource;
        private AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter getJobsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TextBox txt_clientName;
        private System.Windows.Forms.Label label1;
        private AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private AgileDevelopmentDataSetTableAdapters.GetClientsTableAdapter getClientsTableAdapter1;
    }
}