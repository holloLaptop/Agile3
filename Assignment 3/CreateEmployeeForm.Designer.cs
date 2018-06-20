namespace Assignment_3
{
    partial class CreateEmployeeForm
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_landLine = new System.Windows.Forms.Label();
            this.lbl_mobilePhone = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_landLine = new System.Windows.Forms.TextBox();
            this.txt_mobilePhone = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(14, 12);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(14, 52);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(68, 20);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(14, 92);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_landLine
            // 
            this.lbl_landLine.AutoSize = true;
            this.lbl_landLine.Location = new System.Drawing.Point(14, 132);
            this.lbl_landLine.Name = "lbl_landLine";
            this.lbl_landLine.Size = new System.Drawing.Size(79, 20);
            this.lbl_landLine.TabIndex = 3;
            this.lbl_landLine.Text = "Land Line";
            // 
            // lbl_mobilePhone
            // 
            this.lbl_mobilePhone.AutoSize = true;
            this.lbl_mobilePhone.Location = new System.Drawing.Point(14, 172);
            this.lbl_mobilePhone.Name = "lbl_mobilePhone";
            this.lbl_mobilePhone.Size = new System.Drawing.Size(105, 20);
            this.lbl_mobilePhone.TabIndex = 4;
            this.lbl_mobilePhone.Text = "Mobile Phone";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(403, 218);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 36);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(127, 10);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(371, 26);
            this.txt_name.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(127, 50);
            this.txt_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(371, 26);
            this.txt_address.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(127, 90);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(371, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_landLine
            // 
            this.txt_landLine.Location = new System.Drawing.Point(127, 130);
            this.txt_landLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(371, 26);
            this.txt_landLine.TabIndex = 9;
            // 
            // txt_mobilePhone
            // 
            this.txt_mobilePhone.Location = new System.Drawing.Point(127, 170);
            this.txt_mobilePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mobilePhone.Name = "txt_mobilePhone";
            this.txt_mobilePhone.Size = new System.Drawing.Size(371, 26);
            this.txt_mobilePhone.TabIndex = 10;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.txt_mobilePhone);
            this.Controls.Add(this.txt_landLine);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_mobilePhone);
            this.Controls.Add(this.lbl_landLine);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(528, 318);
            this.MinimumSize = new System.Drawing.Size(528, 318);
            this.Name = "CreateEmployeeForm";
            this.Text = "New Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEmployeeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_landLine;
        private System.Windows.Forms.Label lbl_mobilePhone;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_landLine;
        private System.Windows.Forms.TextBox txt_mobilePhone;
        private AgileDevelopmentDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}