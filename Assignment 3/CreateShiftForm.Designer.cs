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
            this.lbl_job = new System.Windows.Forms.Label();
            this.comboBox_job = new System.Windows.Forms.ComboBox();
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_endTime = new System.Windows.Forms.Label();
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
            this.comboBox_employeeID.Location = new System.Drawing.Point(121, 10);
            this.comboBox_employeeID.Name = "comboBox_employeeID";
            this.comboBox_employeeID.Size = new System.Drawing.Size(296, 28);
            this.comboBox_employeeID.TabIndex = 1;
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Location = new System.Drawing.Point(13, 53);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(35, 20);
            this.lbl_job.TabIndex = 2;
            this.lbl_job.Text = "Job";
            // 
            // comboBox_job
            // 
            this.comboBox_job.FormattingEnabled = true;
            this.comboBox_job.Location = new System.Drawing.Point(121, 50);
            this.comboBox_job.Name = "comboBox_job";
            this.comboBox_job.Size = new System.Drawing.Size(296, 28);
            this.comboBox_job.TabIndex = 3;
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(13, 93);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(86, 20);
            this.lbl_startTime.TabIndex = 4;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2018, 6, 18, 0, 0, 0, 0);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(322, 175);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(95, 36);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(12, 133);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(80, 20);
            this.lbl_endTime.TabIndex = 10;
            this.lbl_endTime.Text = "End Time:";
            // 
            // CreateShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 223);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_startTime);
            this.Controls.Add(this.comboBox_job);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.comboBox_employeeID);
            this.Controls.Add(this.lbl_employeeID);
            this.MaximumSize = new System.Drawing.Size(454, 279);
            this.MinimumSize = new System.Drawing.Size(454, 279);
            this.Name = "CreateShiftForm";
            this.Text = "CreateShiftForm";
            this.Load += new System.EventHandler(this.CreateShiftForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.ComboBox comboBox_employeeID;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.ComboBox comboBox_job;
        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_endTime;
    }
}