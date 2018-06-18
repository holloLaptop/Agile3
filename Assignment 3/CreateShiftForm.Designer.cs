namespace Assignment_3
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
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.comboBox_employeeID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Location = new System.Drawing.Point(13, 13);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(100, 20);
            this.lbl_employeeID.TabIndex = 0;
            this.lbl_employeeID.Text = "Employee ID";
            // 
            // comboBox_employeeID
            // 
            this.comboBox_employeeID.FormattingEnabled = true;
            this.comboBox_employeeID.Location = new System.Drawing.Point(119, 10);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(150, 28);
            this.comboBox_employeeID.TabIndex = 1;
            // 
            // CreateShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 458);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.lbl_employeeID);
            this.Name = "CreateShiftForm";
            this.Text = "CreateShiftForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.ComboBox comboBox_employeeID;
    }
}