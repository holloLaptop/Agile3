namespace Assignment_3
{
    partial class OfflineMenuForm
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
            this.btn_viewJobs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewJobs
            // 
            this.btn_viewJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewJobs.Location = new System.Drawing.Point(13, 13);
            this.btn_viewJobs.Name = "btn_viewJobs";
            this.btn_viewJobs.Size = new System.Drawing.Size(198, 58);
            this.btn_viewJobs.TabIndex = 0;
            this.btn_viewJobs.Text = "View Jobs";
            this.btn_viewJobs.UseVisualStyleBackColor = true;
            this.btn_viewJobs.Click += new System.EventHandler(this.btn_viewJobs_Click);
            // 
            // OfflineMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.btn_viewJobs);
            this.Name = "OfflineMenuForm";
            this.Text = "Offline Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfflineMenuForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewJobs;
    }
}