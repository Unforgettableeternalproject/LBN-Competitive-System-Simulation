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
            this.Home = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.SubPages = new System.Windows.Forms.Panel();
            this.ExpandChatroom = new System.Windows.Forms.Button();
            this.ViewAsGuest = new System.Windows.Forms.Button();
            this.ViewAsPlayer = new System.Windows.Forms.Button();
            this.UserManagement = new System.Windows.Forms.Button();
            this.GameProposal = new System.Windows.Forms.Button();
            this.DataManagement = new System.Windows.Forms.Button();
            this.SystemLog = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Chatroom = new System.Windows.Forms.Panel();
            this.OnlineCount = new System.Windows.Forms.Label();
            this.SubPages.SuspendLayout();
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
            this.Contact.TabIndex = 18;
            this.Contact.Text = "聯絡我們";
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
            // 
            // SwitchRole
            // 
            this.SwitchRole.AutoSize = true;
            this.SwitchRole.BackColor = System.Drawing.Color.Transparent;
            this.SwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F);
            this.SwitchRole.Location = new System.Drawing.Point(155, 803);
            this.SwitchRole.Name = "SwitchRole";
            this.SwitchRole.Size = new System.Drawing.Size(74, 12);
            this.SwitchRole.TabIndex = 20;
            this.SwitchRole.Text = "切換使用者...";
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
            this.SubPages.Controls.Add(this.OnlineCount);
            this.SubPages.Controls.Add(this.ExpandChatroom);
            this.SubPages.Controls.Add(this.ViewAsGuest);
            this.SubPages.Controls.Add(this.ViewAsPlayer);
            this.SubPages.Controls.Add(this.Chatroom);
            this.SubPages.Location = new System.Drawing.Point(237, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1299, 777);
            this.SubPages.TabIndex = 22;
            // 
            // ExpandChatroom
            // 
            this.ExpandChatroom.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.ExpandChat;
            this.ExpandChatroom.FlatAppearance.BorderSize = 0;
            this.ExpandChatroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandChatroom.Location = new System.Drawing.Point(1110, 720);
            this.ExpandChatroom.Name = "ExpandChatroom";
            this.ExpandChatroom.Size = new System.Drawing.Size(189, 57);
            this.ExpandChatroom.TabIndex = 2;
            this.ExpandChatroom.UseVisualStyleBackColor = true;
            // 
            // ViewAsGuest
            // 
            this.ViewAsGuest.FlatAppearance.BorderSize = 0;
            this.ViewAsGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAsGuest.Location = new System.Drawing.Point(1121, 296);
            this.ViewAsGuest.Name = "ViewAsGuest";
            this.ViewAsGuest.Size = new System.Drawing.Size(164, 31);
            this.ViewAsGuest.TabIndex = 1;
            this.ViewAsGuest.UseVisualStyleBackColor = true;
            // 
            // ViewAsPlayer
            // 
            this.ViewAsPlayer.FlatAppearance.BorderSize = 0;
            this.ViewAsPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAsPlayer.Location = new System.Drawing.Point(1121, 255);
            this.ViewAsPlayer.Name = "ViewAsPlayer";
            this.ViewAsPlayer.Size = new System.Drawing.Size(164, 31);
            this.ViewAsPlayer.TabIndex = 0;
            this.ViewAsPlayer.UseVisualStyleBackColor = true;
            this.ViewAsPlayer.Click += new System.EventHandler(this.ViewAsPlayer_Click);
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
            // 
            // Chatroom
            // 
            this.Chatroom.Location = new System.Drawing.Point(882, 343);
            this.Chatroom.Name = "Chatroom";
            this.Chatroom.Size = new System.Drawing.Size(417, 434);
            this.Chatroom.TabIndex = 3;
            // 
            // OnlineCount
            // 
            this.OnlineCount.AutoSize = true;
            this.OnlineCount.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlineCount.Location = new System.Drawing.Point(1152, 55);
            this.OnlineCount.Name = "OnlineCount";
            this.OnlineCount.Size = new System.Drawing.Size(54, 21);
            this.OnlineCount.TabIndex = 4;
            this.OnlineCount.Text = "0 人";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Admin_Base;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.SystemLog);
            this.Controls.Add(this.DataManagement);
            this.Controls.Add(this.GameProposal);
            this.Controls.Add(this.UserManagement);
            this.Controls.Add(this.SubPages);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SubPages.ResumeLayout(false);
            this.SubPages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Contact;
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
    }
}