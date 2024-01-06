namespace LBN_Competitive_System_Simulation.Forms
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.Home = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Label();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.SubPages = new System.Windows.Forms.Panel();
            this.OnlineCount = new System.Windows.Forms.Label();
            this.ExpandChatroom = new System.Windows.Forms.Button();
            this.ViewAsGuest = new System.Windows.Forms.Button();
            this.ViewAsPlayer = new System.Windows.Forms.Button();
            this.Chatroom = new System.Windows.Forms.Panel();
            this.UserManagement = new System.Windows.Forms.Button();
            this.GameProposal = new System.Windows.Forms.Button();
            this.DataManagement = new System.Windows.Forms.Button();
            this.SystemLog = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(139, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 42);
            this.Home.TabIndex = 17;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            this.Exit.TabIndex = 19;
            this.Exit.Text = "離開系統";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.SwitchRole.TabIndex = 20;
            this.SwitchRole.Text = "切換使用者";
            this.SwitchRole.Click += new System.EventHandler(this.SwitchRole_Click);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 113);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(121, 22);
            this.WelcomeMessage.TabIndex = 21;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // SubPages
            // 
            this.SubPages.BackColor = System.Drawing.Color.Transparent;
            this.SubPages.Location = new System.Drawing.Point(237, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1108, 777);
            this.SubPages.TabIndex = 22;
            // 
            // OnlineCount
            // 
            this.OnlineCount.AutoSize = true;
            this.OnlineCount.BackColor = System.Drawing.Color.Transparent;
            this.OnlineCount.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineCount.Location = new System.Drawing.Point(1389, 142);
            this.OnlineCount.Name = "OnlineCount";
            this.OnlineCount.Size = new System.Drawing.Size(54, 21);
            this.OnlineCount.TabIndex = 4;
            this.OnlineCount.Text = "0 人";
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
            this.ExpandChatroom.TabIndex = 2;
            this.ExpandChatroom.UseVisualStyleBackColor = false;
            this.ExpandChatroom.Click += new System.EventHandler(this.ExpandChatroom_Click);
            // 
            // ViewAsGuest
            // 
            this.ViewAsGuest.BackColor = System.Drawing.Color.Transparent;
            this.ViewAsGuest.FlatAppearance.BorderSize = 0;
            this.ViewAsGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ViewAsGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ViewAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAsGuest.Location = new System.Drawing.Point(1358, 383);
            this.ViewAsGuest.Name = "ViewAsGuest";
            this.ViewAsGuest.Size = new System.Drawing.Size(164, 31);
            this.ViewAsGuest.TabIndex = 1;
            this.ViewAsGuest.UseVisualStyleBackColor = false;
            this.ViewAsGuest.Click += new System.EventHandler(this.ViewAsGuest_Click);
            // 
            // ViewAsPlayer
            // 
            this.ViewAsPlayer.BackColor = System.Drawing.Color.Transparent;
            this.ViewAsPlayer.FlatAppearance.BorderSize = 0;
            this.ViewAsPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ViewAsPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ViewAsPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAsPlayer.Location = new System.Drawing.Point(1358, 343);
            this.ViewAsPlayer.Name = "ViewAsPlayer";
            this.ViewAsPlayer.Size = new System.Drawing.Size(164, 31);
            this.ViewAsPlayer.TabIndex = 0;
            this.ViewAsPlayer.UseVisualStyleBackColor = false;
            this.ViewAsPlayer.Click += new System.EventHandler(this.ViewAsPlayer_Click);
            // 
            // Chatroom
            // 
            this.Chatroom.BackColor = System.Drawing.Color.Transparent;
            this.Chatroom.Location = new System.Drawing.Point(1102, 430);
            this.Chatroom.Name = "Chatroom";
            this.Chatroom.Size = new System.Drawing.Size(434, 434);
            this.Chatroom.TabIndex = 3;
            // 
            // UserManagement
            // 
            this.UserManagement.BackColor = System.Drawing.Color.Transparent;
            this.UserManagement.FlatAppearance.BorderSize = 0;
            this.UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagement.Location = new System.Drawing.Point(-1, 295);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Size = new System.Drawing.Size(239, 57);
            this.UserManagement.TabIndex = 23;
            this.UserManagement.UseVisualStyleBackColor = false;
            this.UserManagement.Click += new System.EventHandler(this.UserManagement_Click);
            // 
            // GameProposal
            // 
            this.GameProposal.BackColor = System.Drawing.Color.Transparent;
            this.GameProposal.FlatAppearance.BorderSize = 0;
            this.GameProposal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameProposal.Location = new System.Drawing.Point(-1, 355);
            this.GameProposal.Name = "GameProposal";
            this.GameProposal.Size = new System.Drawing.Size(239, 57);
            this.GameProposal.TabIndex = 24;
            this.GameProposal.UseVisualStyleBackColor = false;
            this.GameProposal.Click += new System.EventHandler(this.GameProposal_Click);
            // 
            // DataManagement
            // 
            this.DataManagement.BackColor = System.Drawing.Color.Transparent;
            this.DataManagement.FlatAppearance.BorderSize = 0;
            this.DataManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataManagement.Location = new System.Drawing.Point(-1, 414);
            this.DataManagement.Name = "DataManagement";
            this.DataManagement.Size = new System.Drawing.Size(239, 57);
            this.DataManagement.TabIndex = 25;
            this.DataManagement.UseVisualStyleBackColor = false;
            this.DataManagement.Click += new System.EventHandler(this.DataManagement_Click);
            // 
            // SystemLog
            // 
            this.SystemLog.BackColor = System.Drawing.Color.Transparent;
            this.SystemLog.FlatAppearance.BorderSize = 0;
            this.SystemLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SystemLog.Location = new System.Drawing.Point(-1, 473);
            this.SystemLog.Name = "SystemLog";
            this.SystemLog.Size = new System.Drawing.Size(239, 57);
            this.SystemLog.TabIndex = 26;
            this.SystemLog.UseVisualStyleBackColor = false;
            this.SystemLog.Click += new System.EventHandler(this.SystemLog_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Transparent;
            this.Calendar.FlatAppearance.BorderSize = 0;
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.Location = new System.Drawing.Point(-1, 532);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(239, 57);
            this.Calendar.TabIndex = 27;
            this.Calendar.UseVisualStyleBackColor = false;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Tick
            // 
            this.Tick.Interval = 500;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Admin_Base;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.Chatroom);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.SystemLog);
            this.Controls.Add(this.DataManagement);
            this.Controls.Add(this.ExpandChatroom);
            this.Controls.Add(this.GameProposal);
            this.Controls.Add(this.UserManagement);
            this.Controls.Add(this.ViewAsGuest);
            this.Controls.Add(this.ViewAsPlayer);
            this.Controls.Add(this.OnlineCount);
            this.Controls.Add(this.SubPages);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBN系統後台管理畫面";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label SwitchRole;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Panel SubPages;
        private System.Windows.Forms.Button ViewAsPlayer;
        private System.Windows.Forms.Button UserManagement;
        private System.Windows.Forms.Button GameProposal;
        private System.Windows.Forms.Button DataManagement;
        private System.Windows.Forms.Button SystemLog;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Button ViewAsGuest;
        private System.Windows.Forms.Button ExpandChatroom;
        private System.Windows.Forms.Panel Chatroom;
        private System.Windows.Forms.Label OnlineCount;
        private System.Windows.Forms.Timer Tick;
    }
}