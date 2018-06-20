namespace Assignment_3
{
    partial class ExportJobsForm
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
            this.lbl_startTime = new System.Windows.Forms.Label();
            this.lbl_endTime = new System.Windows.Forms.Label();
            this.date_startTime = new System.Windows.Forms.DateTimePicker();
            this.date_endTime = new System.Windows.Forms.DateTimePicker();
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_startTime
            // 
            this.lbl_startTime.AutoSize = true;
            this.lbl_startTime.Location = new System.Drawing.Point(14, 12);
            this.lbl_startTime.Name = "lbl_startTime";
            this.lbl_startTime.Size = new System.Drawing.Size(86, 20);
            this.lbl_startTime.TabIndex = 0;
            this.lbl_startTime.Text = "Start Time:";
            // 
            // lbl_endTime
            // 
            this.lbl_endTime.AutoSize = true;
            this.lbl_endTime.Location = new System.Drawing.Point(14, 52);
            this.lbl_endTime.Name = "lbl_endTime";
            this.lbl_endTime.Size = new System.Drawing.Size(80, 20);
            this.lbl_endTime.TabIndex = 1;
            this.lbl_endTime.Text = "End Time:";
            // 
            // date_startTime
            // 
            this.date_startTime.Location = new System.Drawing.Point(106, 10);
            this.date_startTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_startTime.Name = "date_startTime";
            this.date_startTime.Size = new System.Drawing.Size(291, 26);
            this.date_startTime.TabIndex = 2;
            // 
            // date_endTime
            // 
            this.date_endTime.Location = new System.Drawing.Point(106, 50);
            this.date_endTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_endTime.Name = "date_endTime";
            this.date_endTime.Size = new System.Drawing.Size(291, 26);
            this.date_endTime.TabIndex = 3;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(303, 90);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(94, 36);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ExportJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 135);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.date_endTime);
            this.Controls.Add(this.date_startTime);
            this.Controls.Add(this.lbl_endTime);
            this.Controls.Add(this.lbl_startTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(432, 191);
            this.MinimumSize = new System.Drawing.Size(432, 191);
            this.Name = "ExportJobsForm";
            this.Text = "Export Jobs";
            this.Load += new System.EventHandler(this.ExportJobsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startTime;
        private System.Windows.Forms.Label lbl_endTime;
        private System.Windows.Forms.DateTimePicker date_startTime;
        private System.Windows.Forms.DateTimePicker date_endTime;
        private System.Windows.Forms.Button btn_export;
    }
}