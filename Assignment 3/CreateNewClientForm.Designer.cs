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
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 53);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(68, 20);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_landLine
            // 
            this.lbl_landLine.AutoSize = true;
            this.lbl_landLine.Location = new System.Drawing.Point(13, 133);
            this.lbl_landLine.Name = "lbl_landLine";
            this.lbl_landLine.Size = new System.Drawing.Size(79, 20);
            this.lbl_landLine.TabIndex = 2;
            this.lbl_landLine.Text = "Land Line";
            // 
            // lbl_mobilePhone
            // 
            this.lbl_mobilePhone.AutoSize = true;
            this.lbl_mobilePhone.Location = new System.Drawing.Point(13, 173);
            this.lbl_mobilePhone.Name = "lbl_mobilePhone";
            this.lbl_mobilePhone.Size = new System.Drawing.Size(105, 20);
            this.lbl_mobilePhone.TabIndex = 3;
            this.lbl_mobilePhone.Text = "Mobile Phone";
            // 
            // lbl_business
            // 
            this.lbl_business.AutoSize = true;
            this.lbl_business.Location = new System.Drawing.Point(13, 213);
            this.lbl_business.Name = "lbl_business";
            this.lbl_business.Size = new System.Drawing.Size(120, 20);
            this.lbl_business.TabIndex = 4;
            this.lbl_business.Text = "Business Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(13, 93);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(139, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(371, 26);
            this.txt_name.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(139, 50);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(371, 26);
            this.txt_address.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(139, 90);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(371, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_landLine
            // 
            this.txt_landLine.Location = new System.Drawing.Point(139, 130);
            this.txt_landLine.Name = "txt_landLine";
            this.txt_landLine.Size = new System.Drawing.Size(371, 26);
            this.txt_landLine.TabIndex = 9;
            // 
            // txt_mobilePhone
            // 
            this.txt_mobilePhone.Location = new System.Drawing.Point(139, 170);
            this.txt_mobilePhone.Name = "txt_mobilePhone";
            this.txt_mobilePhone.Size = new System.Drawing.Size(371, 26);
            this.txt_mobilePhone.TabIndex = 10;
            // 
            // txt_businessName
            // 
            this.txt_businessName.Location = new System.Drawing.Point(139, 210);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(371, 26);
            this.txt_businessName.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(416, 255);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(95, 36);
            this.btn_submit.TabIndex = 12;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // CreateNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 307);
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
            this.MaximumSize = new System.Drawing.Size(548, 363);
            this.MinimumSize = new System.Drawing.Size(548, 363);
            this.Name = "CreateNewClientForm";
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
    }
}