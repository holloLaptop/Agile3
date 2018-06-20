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
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_importAndExportJobs = new System.Windows.Forms.Button();
            this.btn_assignJobs = new System.Windows.Forms.Button();
            this.btn_newJob = new System.Windows.Forms.Button();
            this.btn_newEmployee = new System.Windows.Forms.Button();
            this.btn_newClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(589, 463);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(173, 39);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Return to Main Menu";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_importAndExportJobs
            // 
            this.btn_importAndExportJobs.BackColor = System.Drawing.Color.Indigo;
            this.btn_importAndExportJobs.BackgroundImage = global::Assignment_3.Properties.Resources.ImportAndExportJobs;
            this.btn_importAndExportJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_importAndExportJobs.FlatAppearance.BorderSize = 0;
            this.btn_importAndExportJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importAndExportJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importAndExportJobs.ForeColor = System.Drawing.Color.Snow;
            this.btn_importAndExportJobs.Location = new System.Drawing.Point(272, 272);
            this.btn_importAndExportJobs.Name = "btn_importAndExportJobs";
            this.btn_importAndExportJobs.Size = new System.Drawing.Size(230, 230);
            this.btn_importAndExportJobs.TabIndex = 5;
            this.btn_importAndExportJobs.Text = "Import and Export Jobs";
            this.btn_importAndExportJobs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_importAndExportJobs.UseVisualStyleBackColor = false;
            this.btn_importAndExportJobs.Click += new System.EventHandler(this.btn_importAndExportJobs_Click);
            // 
            // btn_assignJobs
            // 
            this.btn_assignJobs.BackColor = System.Drawing.Color.Indigo;
            this.btn_assignJobs.BackgroundImage = global::Assignment_3.Properties.Resources.CreateShifts;
            this.btn_assignJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_assignJobs.FlatAppearance.BorderSize = 0;
            this.btn_assignJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assignJobs.ForeColor = System.Drawing.Color.Snow;
            this.btn_assignJobs.Location = new System.Drawing.Point(12, 272);
            this.btn_assignJobs.Name = "btn_assignJobs";
            this.btn_assignJobs.Size = new System.Drawing.Size(230, 230);
            this.btn_assignJobs.TabIndex = 4;
            this.btn_assignJobs.Text = "Assign Jobs (Create Shifts)";
            this.btn_assignJobs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_assignJobs.UseVisualStyleBackColor = false;
            this.btn_assignJobs.Click += new System.EventHandler(this.btn_assignJobs_Click);
            // 
            // btn_newJob
            // 
            this.btn_newJob.BackColor = System.Drawing.Color.Indigo;
            this.btn_newJob.BackgroundImage = global::Assignment_3.Properties.Resources.CreateJob;
            this.btn_newJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_newJob.FlatAppearance.BorderSize = 0;
            this.btn_newJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newJob.ForeColor = System.Drawing.Color.Snow;
            this.btn_newJob.Location = new System.Drawing.Point(532, 12);
            this.btn_newJob.Name = "btn_newJob";
            this.btn_newJob.Size = new System.Drawing.Size(230, 230);
            this.btn_newJob.TabIndex = 3;
            this.btn_newJob.Text = "New Job";
            this.btn_newJob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_newJob.UseVisualStyleBackColor = false;
            this.btn_newJob.Click += new System.EventHandler(this.btn_newJob_Click);
            // 
            // btn_newEmployee
            // 
            this.btn_newEmployee.BackColor = System.Drawing.Color.Indigo;
            this.btn_newEmployee.BackgroundImage = global::Assignment_3.Properties.Resources.CreateEmployee;
            this.btn_newEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_newEmployee.FlatAppearance.BorderSize = 0;
            this.btn_newEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newEmployee.ForeColor = System.Drawing.Color.Snow;
            this.btn_newEmployee.Location = new System.Drawing.Point(272, 12);
            this.btn_newEmployee.Name = "btn_newEmployee";
            this.btn_newEmployee.Size = new System.Drawing.Size(230, 230);
            this.btn_newEmployee.TabIndex = 2;
            this.btn_newEmployee.Text = "New Employee";
            this.btn_newEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_newEmployee.UseVisualStyleBackColor = false;
            this.btn_newEmployee.Click += new System.EventHandler(this.btn_newEmployee_Click);
            // 
            // btn_newClient
            // 
            this.btn_newClient.BackColor = System.Drawing.Color.Indigo;
            this.btn_newClient.BackgroundImage = global::Assignment_3.Properties.Resources.CreateClient;
            this.btn_newClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_newClient.FlatAppearance.BorderSize = 0;
            this.btn_newClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newClient.ForeColor = System.Drawing.Color.Snow;
            this.btn_newClient.Location = new System.Drawing.Point(12, 12);
            this.btn_newClient.Name = "btn_newClient";
            this.btn_newClient.Size = new System.Drawing.Size(230, 230);
            this.btn_newClient.TabIndex = 1;
            this.btn_newClient.Text = "New Client";
            this.btn_newClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_newClient.UseVisualStyleBackColor = false;
            this.btn_newClient.Click += new System.EventHandler(this.btn_newClient_Click);
            // 
            // HomeMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_importAndExportJobs);
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
        private System.Windows.Forms.Button btn_importAndExportJobs;
        private System.Windows.Forms.Button btn_return;
    }
}