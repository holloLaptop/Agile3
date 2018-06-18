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
            this.lbl_address.Location = new System.Drawing.Point(13, 60);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(68, 20);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(13, 110);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_landLine
            // 
            this.lbl_landLine.AutoSize = true;
            this.lbl_landLine.Location = new System.Drawing.Point(13, 160);
            this.lbl_landLine.Name = "lbl_landLine";
            this.lbl_landLine.Size = new System.Drawing.Size(79, 20);
            this.lbl_landLine.TabIndex = 3;
            this.lbl_landLine.Text = "Land Line";
            // 
            // lbl_mobilePhone
            // 
            this.lbl_mobilePhone.AutoSize = true;
            this.lbl_mobilePhone.Location = new System.Drawing.Point(13, 210);
            this.lbl_mobilePhone.Name = "lbl_mobilePhone";
            this.lbl_mobilePhone.Size = new System.Drawing.Size(105, 20);
            this.lbl_mobilePhone.TabIndex = 4;
            this.lbl_mobilePhone.Text = "Mobile Phone";
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_mobilePhone);
            this.Controls.Add(this.lbl_landLine);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_landLine;
        private System.Windows.Forms.Label lbl_mobilePhone;
    }
}