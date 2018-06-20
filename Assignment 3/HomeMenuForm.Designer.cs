namespace Assignment_3
{
    partial class HomeMenuForm
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
            this.btn_newClient = new System.Windows.Forms.Button();
            this.btn_newEmployee = new System.Windows.Forms.Button();
            this.btn_newJob = new System.Windows.Forms.Button();
            this.btn_assignJobs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newClient
            // 
            this.btn_newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newClient.Location = new System.Drawing.Point(12, 12);
            this.btn_newClient.Name = "btn_newClient";
            this.btn_newClient.Size = new System.Drawing.Size(198, 58);
            this.btn_newClient.TabIndex = 1;
            this.btn_newClient.Text = "New Client";
            this.btn_newClient.UseVisualStyleBackColor = true;
            this.btn_newClient.Click += new System.EventHandler(this.btn_newClient_Click);
            // 
            // btn_newEmployee
            // 
            this.btn_newEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newEmployee.Location = new System.Drawing.Point(12, 90);
            this.btn_newEmployee.Name = "btn_newEmployee";
            this.btn_newEmployee.Size = new System.Drawing.Size(198, 58);
            this.btn_newEmployee.TabIndex = 2;
            this.btn_newEmployee.Text = "New Employee";
            this.btn_newEmployee.UseVisualStyleBackColor = true;
            this.btn_newEmployee.Click += new System.EventHandler(this.btn_newEmployee_Click);
            // 
            // btn_newJob
            // 
            this.btn_newJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newJob.Location = new System.Drawing.Point(12, 169);
            this.btn_newJob.Name = "btn_newJob";
            this.btn_newJob.Size = new System.Drawing.Size(198, 58);
            this.btn_newJob.TabIndex = 3;
            this.btn_newJob.Text = "New Job";
            this.btn_newJob.UseVisualStyleBackColor = true;
            this.btn_newJob.Click += new System.EventHandler(this.btn_newJob_Click);
            // 
            // btn_assignJobs
            // 
            this.btn_assignJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assignJobs.Location = new System.Drawing.Point(12, 249);
            this.btn_assignJobs.Name = "btn_assignJobs";
            this.btn_assignJobs.Size = new System.Drawing.Size(198, 113);
            this.btn_assignJobs.TabIndex = 4;
            this.btn_assignJobs.Text = "Assign Jobs (Create Shifts)";
            this.btn_assignJobs.UseVisualStyleBackColor = true;
            this.btn_assignJobs.Click += new System.EventHandler(this.btn_assignJobs_Click);
            // 
            // HomeMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_assignJobs);
            this.Controls.Add(this.btn_newJob);
            this.Controls.Add(this.btn_newEmployee);
            this.Controls.Add(this.btn_newClient);
            this.Name = "HomeMenuForm";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeMenuForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newClient;
        private System.Windows.Forms.Button btn_newEmployee;
        private System.Windows.Forms.Button btn_newJob;
        private System.Windows.Forms.Button btn_assignJobs;
    }
}