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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dummyTableAdapter1 = new Assignment_3.AgileDevelopmentDataSetTableAdapters.DummyTableAdapter();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_offline = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dummyTableAdapter1
            // 
            this.dummyTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(391, 251);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(102, 38);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_offline
            // 
            this.btn_offline.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_offline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_offline.BackgroundImage")));
            this.btn_offline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_offline.FlatAppearance.BorderSize = 0;
            this.btn_offline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_offline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_offline.ForeColor = System.Drawing.Color.Snow;
            this.btn_offline.Location = new System.Drawing.Point(263, 12);
            this.btn_offline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_offline.Name = "btn_offline";
            this.btn_offline.Size = new System.Drawing.Size(230, 230);
            this.btn_offline.TabIndex = 1;
            this.btn_offline.Text = "Offline Mode";
            this.btn_offline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_offline.UseVisualStyleBackColor = false;
            this.btn_offline.Click += new System.EventHandler(this.btn_offline_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Snow;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(230, 230);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 289);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_offline);
            this.Controls.Add(this.btn_home);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(520, 345);
            this.MinimumSize = new System.Drawing.Size(520, 345);
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
        private System.Windows.Forms.Timer timer1;
    }
}