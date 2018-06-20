namespace Assignment_3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_offline = new System.Windows.Forms.Button();
            this.dummyTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.DummyTableAdapter();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(240, 230);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_offline
            // 
            this.btn_offline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_offline.BackgroundImage")));
            this.btn_offline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_offline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_offline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_offline.Location = new System.Drawing.Point(267, 12);
            this.btn_offline.Name = "btn_offline";
            this.btn_offline.Size = new System.Drawing.Size(240, 230);
            this.btn_offline.TabIndex = 1;
            this.btn_offline.Text = "Offline Mode";
            this.btn_offline.UseVisualStyleBackColor = true;
            this.btn_offline.Click += new System.EventHandler(this.btn_offline_Click);
            // 
            // dummyTableAdapter1
            // 
            this.dummyTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(405, 248);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(102, 38);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 284);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_offline);
            this.Controls.Add(this.btn_home);
            this.MaximumSize = new System.Drawing.Size(535, 340);
            this.MinimumSize = new System.Drawing.Size(535, 340);
            this.Name = "MainForm";
            this.Text = "IQ Incorporated";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_offline;
        private AgileDevelopmentDataSetTableAdapters.DummyTableAdapter dummyTableAdapter1;
        private System.Windows.Forms.Button btn_refresh;
    }
}