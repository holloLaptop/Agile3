namespace Assignment_3
{
    partial class CreateNewClientForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_landLine = new System.Windows.Forms.Label();
            this.lbl_mobilePhone = new System.Windows.Forms.Label();
            this.lbl_business = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_landLine = new System.Windows.Forms.TextBox();
            this.txt_mobilePhone = new System.Windows.Forms.TextBox();
            this.txt_businessName = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 42);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_landLine
            // 
            this.lbl_landLine.AutoSize = true;
            this.lbl_landLine.Location = new System.Drawing.Point(12, 106);
            this.lbl_landLine.Name = "lbl_landLine";
            this.lbl_landLine.Size = new System.Drawing.Size(71, 17);
            this.lbl_landLine.TabIndex = 2;
            this.lbl_landLine.Text = "Land Line";
            // 
            // lbl_mobilePhone
            // 
            this.lbl_mobilePhone.AutoSize = true;
            this.lbl_mobilePhone.Location = new System.Drawing.Point(12, 138);
            this.lbl_mobilePhone.Name = "lbl_mobilePhone";
            this.lbl_mobilePhone.Size = new System.Drawing.Size(94, 17);
            this.lbl_mobilePhone.TabIndex = 3;
            this.lbl_mobilePhone.Text = "Mobile Phone";
            // 
            // lbl_business
            // 
            this.lbl_business.AutoSize = true;
            this.lbl_business.Location = new System.Drawing.Point(12, 170);
            this.lbl_business.Name = "lbl_business";
            this.lbl_business.Size = new System.Drawing.Size(106, 17);
            this.lbl_business.TabIndex = 4;
            this.lbl_business.Text = "Business Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 74);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(124, 8);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(330, 22);
            this.txt_name.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(124, 40);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(330, 22);
            this.txt_address.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(124, 72);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(330, 22);
            this.txt_email.TabIndex = 8;
            // 
            // txt_landLine
            // 
            this.txt_landLine.Location = new System.Drawing.Point(124, 104);
            this.txt_landLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(330, 22);
            this.txt_landLine.TabIndex = 9;
            this.txt_landLine.TextChanged += new System.EventHandler(this.txt_landLine_TextChanged);
            // 
            // txt_mobilePhone
            // 
            this.txt_mobilePhone.Location = new System.Drawing.Point(124, 136);
            this.txt_mobilePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobilePhone.Name = "txt_mobilePhone";
            this.txt_mobilePhone.Size = new System.Drawing.Size(330, 22);
            this.txt_mobilePhone.TabIndex = 10;
            this.txt_mobilePhone.TextChanged += new System.EventHandler(this.txt_mobilePhone_TextChanged);
            // 
            // txt_businessName
            // 
            this.txt_businessName.Location = new System.Drawing.Point(124, 168);
            this.txt_businessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(330, 22);
            this.txt_businessName.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(370, 204);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 29);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // CreateNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 251);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_businessName);
            this.Controls.Add(this.txt_mobilePhone);
            this.Controls.Add(this.txt_landLine);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_business);
            this.Controls.Add(this.lbl_mobilePhone);
            this.Controls.Add(this.lbl_landLine);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(488, 298);
            this.MinimumSize = new System.Drawing.Size(488, 298);
            this.Name = "CreateNewClientForm";
            this.Text = "New Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewClientForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateNewClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_landLine;
        private System.Windows.Forms.Label lbl_mobilePhone;
        private System.Windows.Forms.Label lbl_business;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_landLine;
        private System.Windows.Forms.TextBox txt_mobilePhone;
        private System.Windows.Forms.TextBox txt_businessName;
        private System.Windows.Forms.Button btn_submit;
        private AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}