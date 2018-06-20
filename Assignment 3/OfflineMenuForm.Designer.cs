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
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_viewJobs
            // 
            this.btn_viewJobs.BackColor = System.Drawing.Color.Indigo;
            this.btn_viewJobs.BackgroundImage = global::Assignment_3.Properties.Resources.ViewJobs;
            this.btn_viewJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewJobs.FlatAppearance.BorderSize = 0;
            this.btn_viewJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewJobs.ForeColor = System.Drawing.Color.Snow;
            this.btn_viewJobs.Location = new System.Drawing.Point(57, 12);
            this.btn_viewJobs.Name = "btn_viewJobs";
            this.btn_viewJobs.Size = new System.Drawing.Size(230, 230);
            this.btn_viewJobs.TabIndex = 0;
            this.btn_viewJobs.Text = "View Jobs";
            this.btn_viewJobs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_viewJobs.UseVisualStyleBackColor = false;
            this.btn_viewJobs.Click += new System.EventHandler(this.btn_viewJobs_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(87, 257);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(173, 39);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "Return to Main Menu";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // OfflineMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 308);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_viewJobs);
            this.Name = "OfflineMenuForm";
            this.Text = "Offline Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfflineMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.OfflineMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_viewJobs;
        private System.Windows.Forms.Button btn_return;
    }
}