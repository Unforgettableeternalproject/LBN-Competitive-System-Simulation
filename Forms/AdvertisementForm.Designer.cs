namespace LBN_Competitive_System_Simulation.Forms
{
    partial class AdvertisementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertisementForm));
            this.SubPages = new System.Windows.Forms.Panel();
            this.Hint = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.AdvertisementDeploy = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.PersonalInfo = new System.Windows.Forms.Button();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.AdSpot = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SubPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot)).BeginInit();
            this.SuspendLayout();
            // 
            // SubPages
            // 
            this.SubPages.BackColor = System.Drawing.Color.Transparent;
            this.SubPages.Controls.Add(this.Hint);
            this.SubPages.Controls.Add(this.btn_enter);
            this.SubPages.Location = new System.Drawing.Point(238, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1300, 779);
            this.SubPages.TabIndex = 0;
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint.Location = new System.Drawing.Point(511, 567);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(241, 21);
            this.Hint.TabIndex = 6;
            this.Hint.Text = "請先登入一個現有的帳號";
            // 
            // btn_enter
            // 
            this.btn_enter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_enter.BackColor = System.Drawing.Color.Transparent;
            this.btn_enter.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Enter;
            this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.FlatAppearance.BorderSize = 0;
            this.btn_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(548, 428);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(165, 67);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.UseMnemonic = false;
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // AdvertisementDeploy
            // 
            this.AdvertisementDeploy.BackColor = System.Drawing.Color.Transparent;
            this.AdvertisementDeploy.FlatAppearance.BorderSize = 0;
            this.AdvertisementDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvertisementDeploy.Location = new System.Drawing.Point(-1, 297);
            this.AdvertisementDeploy.Name = "AdvertisementDeploy";
            this.AdvertisementDeploy.Size = new System.Drawing.Size(239, 57);
            this.AdvertisementDeploy.TabIndex = 1;
            this.AdvertisementDeploy.UseVisualStyleBackColor = false;
            this.AdvertisementDeploy.Click += new System.EventHandler(this.AdvertisementDeploy_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Location = new System.Drawing.Point(-1, 360);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(239, 57);
            this.Dashboard.TabIndex = 2;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.PersonalInfo.FlatAppearance.BorderSize = 0;
            this.PersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalInfo.Location = new System.Drawing.Point(-1, 423);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(239, 55);
            this.PersonalInfo.TabIndex = 3;
            this.PersonalInfo.UseVisualStyleBackColor = false;
            this.PersonalInfo.Click += new System.EventHandler(this.PersonalInfo_Click);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 110);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(121, 22);
            this.WelcomeMessage.TabIndex = 4;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(139, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 42);
            this.Home.TabIndex = 5;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.BackColor = System.Drawing.Color.Transparent;
            this.Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contact.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(12, 839);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(71, 16);
            this.Contact.TabIndex = 6;
            this.Contact.Text = "聯絡我們";
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit.Location = new System.Drawing.Point(150, 839);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 16);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "離開系統";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // AdSpot
            // 
            this.AdSpot.BackColor = System.Drawing.Color.Transparent;
            this.AdSpot.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder11;
            this.AdSpot.Location = new System.Drawing.Point(1, 560);
            this.AdSpot.Name = "AdSpot";
            this.AdSpot.Size = new System.Drawing.Size(237, 218);
            this.AdSpot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdSpot.TabIndex = 14;
            this.AdSpot.TabStop = false;
            // 
            // AdvertisementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Advertise_Front;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.AdSpot);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.PersonalInfo);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.AdvertisementDeploy);
            this.Controls.Add(this.SubPages);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvertisementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvertisementScreen";
            this.Load += new System.EventHandler(this.AdvertisementForm_Load);
            this.SubPages.ResumeLayout(false);
            this.SubPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SubPages;
        private System.Windows.Forms.Button AdvertisementDeploy;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button PersonalInfo;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.PictureBox AdSpot;
        private System.Windows.Forms.ToolTip toolTip;
    }
}