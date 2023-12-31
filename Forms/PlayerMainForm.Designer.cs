﻿namespace LBN_Competitive_System_Simulation.Forms
{
    partial class PlayerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMainForm));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.RecentGames = new System.Windows.Forms.Button();
            this.PersonalStats = new System.Windows.Forms.Button();
            this.LeagueDuty = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Chatroom = new System.Windows.Forms.Panel();
            this.ExpandChatroom = new System.Windows.Forms.Button();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SubPages = new System.Windows.Forms.Panel();
            this.Warnings = new System.Windows.Forms.Label();
            this.LeagueDisplay = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Announcement = new System.Windows.Forms.PictureBox();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.RedirectSpinner = new System.Windows.Forms.PictureBox();
            this.redirectTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Announcement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 113);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(121, 22);
            this.WelcomeMessage.TabIndex = 22;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // RecentGames
            // 
            this.RecentGames.BackColor = System.Drawing.Color.Transparent;
            this.RecentGames.FlatAppearance.BorderSize = 0;
            this.RecentGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecentGames.Location = new System.Drawing.Point(-1, 294);
            this.RecentGames.Name = "RecentGames";
            this.RecentGames.Size = new System.Drawing.Size(240, 59);
            this.RecentGames.TabIndex = 24;
            this.RecentGames.UseVisualStyleBackColor = false;
            this.RecentGames.Click += new System.EventHandler(this.RecentGames_Click);
            // 
            // PersonalStats
            // 
            this.PersonalStats.BackColor = System.Drawing.Color.Transparent;
            this.PersonalStats.FlatAppearance.BorderSize = 0;
            this.PersonalStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalStats.Location = new System.Drawing.Point(0, 355);
            this.PersonalStats.Name = "PersonalStats";
            this.PersonalStats.Size = new System.Drawing.Size(239, 57);
            this.PersonalStats.TabIndex = 25;
            this.PersonalStats.UseVisualStyleBackColor = false;
            this.PersonalStats.Click += new System.EventHandler(this.PersonalStats_Click);
            // 
            // LeagueDuty
            // 
            this.LeagueDuty.BackColor = System.Drawing.Color.Transparent;
            this.LeagueDuty.FlatAppearance.BorderSize = 0;
            this.LeagueDuty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeagueDuty.Location = new System.Drawing.Point(-1, 414);
            this.LeagueDuty.Name = "LeagueDuty";
            this.LeagueDuty.Size = new System.Drawing.Size(240, 57);
            this.LeagueDuty.TabIndex = 26;
            this.LeagueDuty.UseVisualStyleBackColor = false;
            this.LeagueDuty.Click += new System.EventHandler(this.LeagueDuty_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Transparent;
            this.Calendar.FlatAppearance.BorderSize = 0;
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.Location = new System.Drawing.Point(0, 472);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(239, 57);
            this.Calendar.TabIndex = 27;
            this.Calendar.UseVisualStyleBackColor = false;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Chatroom
            // 
            this.Chatroom.BackColor = System.Drawing.Color.Transparent;
            this.Chatroom.Location = new System.Drawing.Point(1102, 430);
            this.Chatroom.Name = "Chatroom";
            this.Chatroom.Size = new System.Drawing.Size(434, 434);
            this.Chatroom.TabIndex = 28;
            // 
            // ExpandChatroom
            // 
            this.ExpandChatroom.BackColor = System.Drawing.Color.Transparent;
            this.ExpandChatroom.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.ExpandChat;
            this.ExpandChatroom.FlatAppearance.BorderSize = 0;
            this.ExpandChatroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandChatroom.Location = new System.Drawing.Point(1345, 807);
            this.ExpandChatroom.Name = "ExpandChatroom";
            this.ExpandChatroom.Size = new System.Drawing.Size(189, 57);
            this.ExpandChatroom.TabIndex = 3;
            this.ExpandChatroom.UseVisualStyleBackColor = false;
            this.ExpandChatroom.Click += new System.EventHandler(this.ExpandChatroom_Click);
            // 
            // SwitchRole
            // 
            this.SwitchRole.AutoSize = true;
            this.SwitchRole.BackColor = System.Drawing.Color.Transparent;
            this.SwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.SwitchRole.Location = new System.Drawing.Point(8, 839);
            this.SwitchRole.Name = "SwitchRole";
            this.SwitchRole.Size = new System.Drawing.Size(87, 16);
            this.SwitchRole.TabIndex = 29;
            this.SwitchRole.Text = "切換使用者";
            this.SwitchRole.Click += new System.EventHandler(this.SwitchRole_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(154, 839);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 16);
            this.Exit.TabIndex = 30;
            this.Exit.Text = "離開系統";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SubPages
            // 
            this.SubPages.BackColor = System.Drawing.Color.Transparent;
            this.SubPages.Location = new System.Drawing.Point(237, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1108, 777);
            this.SubPages.TabIndex = 31;
            // 
            // Warnings
            // 
            this.Warnings.AutoSize = true;
            this.Warnings.BackColor = System.Drawing.Color.Transparent;
            this.Warnings.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.Warnings.Location = new System.Drawing.Point(1354, 146);
            this.Warnings.Name = "Warnings";
            this.Warnings.Size = new System.Drawing.Size(108, 25);
            this.Warnings.TabIndex = 5;
            this.Warnings.Text = "沒有警告";
            // 
            // LeagueDisplay
            // 
            this.LeagueDisplay.AutoEllipsis = true;
            this.LeagueDisplay.BackColor = System.Drawing.Color.Transparent;
            this.LeagueDisplay.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.LeagueDisplay.Location = new System.Drawing.Point(1354, 281);
            this.LeagueDisplay.Name = "LeagueDisplay";
            this.LeagueDisplay.Size = new System.Drawing.Size(136, 25);
            this.LeagueDisplay.TabIndex = 32;
            this.LeagueDisplay.Text = "無";
            this.LeagueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(139, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 42);
            this.Home.TabIndex = 33;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Announcement
            // 
            this.Announcement.BackColor = System.Drawing.Color.Transparent;
            this.Announcement.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.LeagueAnnouncementNormal;
            this.Announcement.Location = new System.Drawing.Point(0, 543);
            this.Announcement.Name = "Announcement";
            this.Announcement.Size = new System.Drawing.Size(239, 239);
            this.Announcement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Announcement.TabIndex = 34;
            this.Announcement.TabStop = false;
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // RedirectSpinner
            // 
            this.RedirectSpinner.BackColor = System.Drawing.Color.Transparent;
            this.RedirectSpinner.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Spinner_Blue;
            this.RedirectSpinner.Location = new System.Drawing.Point(530, 224);
            this.RedirectSpinner.Name = "RedirectSpinner";
            this.RedirectSpinner.Size = new System.Drawing.Size(512, 512);
            this.RedirectSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedirectSpinner.TabIndex = 35;
            this.RedirectSpinner.TabStop = false;
            // 
            // redirectTimer
            // 
            this.redirectTimer.Interval = 3000;
            this.redirectTimer.Tick += new System.EventHandler(this.redirectTimer_Tick);
            // 
            // PlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Player_Base;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.Chatroom);
            this.Controls.Add(this.RedirectSpinner);
            this.Controls.Add(this.Announcement);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.LeagueDisplay);
            this.Controls.Add(this.Warnings);
            this.Controls.Add(this.SubPages);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.ExpandChatroom);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.LeagueDuty);
            this.Controls.Add(this.PersonalStats);
            this.Controls.Add(this.RecentGames);
            this.Controls.Add(this.WelcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBN選手儀表板";
            this.Load += new System.EventHandler(this.PlayerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Announcement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button RecentGames;
        private System.Windows.Forms.Button PersonalStats;
        private System.Windows.Forms.Button LeagueDuty;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Panel Chatroom;
        private System.Windows.Forms.Button ExpandChatroom;
        private System.Windows.Forms.Label SwitchRole;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel SubPages;
        private System.Windows.Forms.Label Warnings;
        private System.Windows.Forms.Label LeagueDisplay;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox Announcement;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.PictureBox RedirectSpinner;
        private System.Windows.Forms.Timer redirectTimer;
    }
}