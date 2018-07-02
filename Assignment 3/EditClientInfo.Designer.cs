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
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_updateClientInfo = new System.Windows.Forms.Button();
            this.btn_editClientInfo = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_landLine = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            this.txt_businessName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_updateEmployee = new System.Windows.Forms.Button();
            this.btn_editEmployee = new System.Windows.Forms.Button();
            this.txt_eEmail = new System.Windows.Forms.TextBox();
            this.txt_eMobile = new System.Windows.Forms.TextBox();
            this.txt_eLandLine = new System.Windows.Forms.TextBox();
            this.txt_eAddress = new System.Windows.Forms.TextBox();
            this.txt_employeeName = new System.Windows.Forms.TextBox();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_employee = new System.Windows.Forms.ComboBox();
            this.getJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileDevelopmentDataSet = new Assignment_3.AgileDevelopmentDataSet();
            this.getJobsTableAdapter = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetJobsTableAdapter();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.getClientsTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetClientsTableAdapter();
            this.getClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getEmployeesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(7, 15);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(101, 20);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "Client Name*";
            // 
            // comboBox_client
            // 
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(162, 15);
            this.comboBox_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(290, 28);
            this.comboBox_client.TabIndex = 7;
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_clent_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(14, 15);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(484, 346);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(476, 313);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Client Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_updateClientInfo
            // 
            this.btn_updateClientInfo.Location = new System.Drawing.Point(314, 265);
            this.btn_updateClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateClientInfo.Name = "btn_updateClientInfo";
            this.btn_updateClientInfo.Size = new System.Drawing.Size(138, 29);
            this.btn_updateClientInfo.TabIndex = 9;
            this.btn_updateClientInfo.Text = "Update Info";
            this.btn_updateClientInfo.UseVisualStyleBackColor = true;
            this.btn_updateClientInfo.Click += new System.EventHandler(this.btn_updateClientInfo_Click_1);
            // 
            // btn_editClientInfo
            // 
            this.btn_editClientInfo.Location = new System.Drawing.Point(162, 266);
            this.btn_editClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editClientInfo.Name = "btn_editClientInfo";
            this.btn_editClientInfo.Size = new System.Drawing.Size(138, 29);
            this.btn_editClientInfo.TabIndex = 9;
            this.btn_editClientInfo.Text = "Edit Client Info";
            this.btn_editClientInfo.UseVisualStyleBackColor = true;
            this.btn_editClientInfo.Click += new System.EventHandler(this.btn_editClientInfo_Click_1);
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(162, 230);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(290, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Enabled = false;
            this.txt_mobile.Location = new System.Drawing.Point(162, 195);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(290, 26);
            this.txt_mobile.TabIndex = 8;
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_landLine
            // 
            this.txt_landLine.Enabled = false;
            this.txt_landLine.Location = new System.Drawing.Point(162, 160);
            this.txt_landLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(290, 26);
            this.txt_landLine.TabIndex = 8;
            this.txt_landLine.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Location = new System.Drawing.Point(162, 124);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(290, 26);
            this.txt_address.TabIndex = 8;
            // 
            // txt_clientName
            // 
            this.txt_clientName.Enabled = false;
            this.txt_clientName.Location = new System.Drawing.Point(162, 54);
            this.txt_clientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.Size = new System.Drawing.Size(290, 26);
            this.txt_clientName.TabIndex = 8;
            // 
            // txt_businessName
            // 
            this.txt_businessName.Enabled = false;
            this.txt_businessName.Location = new System.Drawing.Point(162, 89);
            this.txt_businessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(290, 26);
            this.txt_businessName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "LandLine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Business Name*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name*";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_updateEmployee);
            this.tabPage1.Controls.Add(this.btn_editEmployee);
            this.tabPage1.Controls.Add(this.txt_eEmail);
            this.tabPage1.Controls.Add(this.txt_eMobile);
            this.tabPage1.Controls.Add(this.txt_eLandLine);
            this.tabPage1.Controls.Add(this.txt_eAddress);
            this.tabPage1.Controls.Add(this.txt_employeeName);
            this.tabPage1.Controls.Add(this.txt_employeeID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.comboBox_employee);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(476, 313);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Employee Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_updateEmployee
            // 
            this.btn_updateEmployee.Location = new System.Drawing.Point(314, 268);
            this.btn_updateEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateEmployee.Name = "btn_updateEmployee";
            this.btn_updateEmployee.Size = new System.Drawing.Size(138, 29);
            this.btn_updateEmployee.TabIndex = 24;
            this.btn_updateEmployee.Text = "Update Info";
            this.btn_updateEmployee.UseVisualStyleBackColor = true;
            this.btn_updateEmployee.Click += new System.EventHandler(this.btn_updateEmployee_Click_1);
            // 
            // btn_editEmployee
            // 
            this.btn_editEmployee.Location = new System.Drawing.Point(162, 269);
            this.btn_editEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_editEmployee.Name = "btn_editEmployee";
            this.btn_editEmployee.Size = new System.Drawing.Size(138, 29);
            this.btn_editEmployee.TabIndex = 25;
            this.btn_editEmployee.Text = "Edit Employee Info";
            this.btn_editEmployee.UseVisualStyleBackColor = true;
            this.btn_editEmployee.Click += new System.EventHandler(this.btn_editEmployee_Click);
            // 
            // txt_eEmail
            // 
            this.txt_eEmail.Enabled = false;
            this.txt_eEmail.Location = new System.Drawing.Point(162, 232);
            this.txt_eEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_eEmail.Name = "txt_eEmail";
            this.txt_eEmail.Size = new System.Drawing.Size(290, 26);
            this.txt_eEmail.TabIndex = 18;
            // 
            // txt_eMobile
            // 
            this.txt_eMobile.Enabled = false;
            this.txt_eMobile.Location = new System.Drawing.Point(162, 198);
            this.txt_eMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_eMobile.Name = "txt_eMobile";
            this.txt_eMobile.Size = new System.Drawing.Size(290, 26);
            this.txt_eMobile.TabIndex = 19;
            this.txt_eMobile.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_eLandLine
            // 
            this.txt_eLandLine.Enabled = false;
            this.txt_eLandLine.Location = new System.Drawing.Point(162, 162);
            this.txt_eLandLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_eLandLine.Name = "txt_eLandLine";
            this.txt_eLandLine.Size = new System.Drawing.Size(290, 26);
            this.txt_eLandLine.TabIndex = 20;
            this.txt_eLandLine.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_eAddress
            // 
            this.txt_eAddress.Enabled = false;
            this.txt_eAddress.Location = new System.Drawing.Point(162, 126);
            this.txt_eAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_eAddress.Name = "txt_eAddress";
            this.txt_eAddress.Size = new System.Drawing.Size(290, 26);
            this.txt_eAddress.TabIndex = 21;
            // 
            // txt_employeeName
            // 
            this.txt_employeeName.Enabled = false;
            this.txt_employeeName.Location = new System.Drawing.Point(162, 56);
            this.txt_employeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_employeeName.Name = "txt_employeeName";
            this.txt_employeeName.Size = new System.Drawing.Size(290, 26);
            this.txt_employeeName.TabIndex = 22;
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Enabled = false;
            this.txt_employeeID.Location = new System.Drawing.Point(162, 91);
            this.txt_employeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(290, 26);
            this.txt_employeeID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mobile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "LandLine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Address*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Employee ID*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Employee Name*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Employee Name*";
            // 
            // comboBox_employee
            // 
            this.comboBox_employee.FormattingEnabled = true;
            this.comboBox_employee.Location = new System.Drawing.Point(162, 18);
            this.comboBox_employee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_employee.Name = "comboBox_employee";
            this.comboBox_employee.Size = new System.Drawing.Size(290, 28);
            this.comboBox_employee.TabIndex = 17;
            this.comboBox_employee.SelectedIndexChanged += new System.EventHandler(this.comboBox_employee_SelectedIndexChanged);
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
            // getClientsTableAdapter1
            // 
            this.getClientsTableAdapter1.ClearBeforeFill = true;
            // 
            // getClientsBindingSource
            // 
            this.getClientsBindingSource.DataMember = "GetClients";
            this.getClientsBindingSource.DataSource = this.agileDevelopmentDataSet;
            // 
            // getEmployeesTableAdapter1
            // 
            this.getEmployeesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 375);
            this.Controls.Add(this.tabControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(530, 431);
            this.MinimumSize = new System.Drawing.Size(530, 431);
            this.Name = "EditClientInfo";
            this.Text = "Edit Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditClientInfo_FormClosed);
            this.Load += new System.EventHandler(this.EditClientInfo_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileDevelopmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getClientsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource getClientsBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_updateEmployee;
        private System.Windows.Forms.Button btn_editEmployee;
        private System.Windows.Forms.TextBox txt_eEmail;
        private System.Windows.Forms.TextBox txt_eMobile;
        private System.Windows.Forms.TextBox txt_eLandLine;
        private System.Windows.Forms.TextBox txt_eAddress;
        private System.Windows.Forms.TextBox txt_employeeName;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_employee;
        private AgileDevelopmentDataSetTableAdapters.GetEmployeesTableAdapter getEmployeesTableAdapter1;
    }
}