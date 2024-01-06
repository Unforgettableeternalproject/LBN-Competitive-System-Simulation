namespace LBN_Competitive_System_Simulation.Forms
{
    partial class LeagueMainForm
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
            this.LeagueOverview = new System.Windows.Forms.Button();
            this.ProposeGames = new System.Windows.Forms.Button();
            this.MemberManagement = new System.Windows.Forms.Button();
            this.RatingManagement = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.LeagueLogo = new System.Windows.Forms.PictureBox();
            this.ExpandChatroom = new System.Windows.Forms.Button();
            this.Chatroom = new System.Windows.Forms.Panel();
            this.SubPages = new System.Windows.Forms.Panel();
            this.Return = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LeagueLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LeagueOverview
            // 
            this.LeagueOverview.BackColor = System.Drawing.Color.Transparent;
            this.LeagueOverview.FlatAppearance.BorderSize = 0;
            this.LeagueOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeagueOverview.Location = new System.Drawing.Point(0, 294);
            this.LeagueOverview.Name = "LeagueOverview";
            this.LeagueOverview.Size = new System.Drawing.Size(240, 59);
            this.LeagueOverview.TabIndex = 25;
            this.LeagueOverview.UseVisualStyleBackColor = false;
            this.LeagueOverview.Click += new System.EventHandler(this.LeagueOverview_Click);
            // 
            // ProposeGames
            // 
            this.ProposeGames.BackColor = System.Drawing.Color.Transparent;
            this.ProposeGames.FlatAppearance.BorderSize = 0;
            this.ProposeGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProposeGames.Location = new System.Drawing.Point(0, 354);
            this.ProposeGames.Name = "ProposeGames";
            this.ProposeGames.Size = new System.Drawing.Size(240, 59);
            this.ProposeGames.TabIndex = 26;
            this.ProposeGames.UseVisualStyleBackColor = false;
            this.ProposeGames.Click += new System.EventHandler(this.ProposeGames_Click);
            // 
            // MemberManagement
            // 
            this.MemberManagement.BackColor = System.Drawing.Color.Transparent;
            this.MemberManagement.FlatAppearance.BorderSize = 0;
            this.MemberManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberManagement.Location = new System.Drawing.Point(0, 413);
            this.MemberManagement.Name = "MemberManagement";
            this.MemberManagement.Size = new System.Drawing.Size(240, 59);
            this.MemberManagement.TabIndex = 27;
            this.MemberManagement.UseVisualStyleBackColor = false;
            // 
            // RatingManagement
            // 
            this.RatingManagement.BackColor = System.Drawing.Color.Transparent;
            this.RatingManagement.FlatAppearance.BorderSize = 0;
            this.RatingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingManagement.Location = new System.Drawing.Point(0, 472);
            this.RatingManagement.Name = "RatingManagement";
            this.RatingManagement.Size = new System.Drawing.Size(240, 59);
            this.RatingManagement.TabIndex = 28;
            this.RatingManagement.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(139, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 42);
            this.Home.TabIndex = 34;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 113);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(121, 22);
            this.WelcomeMessage.TabIndex = 35;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
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
            this.Exit.TabIndex = 37;
            this.Exit.Text = "離開系統";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LeagueLogo
            // 
            this.LeagueLogo.BackColor = System.Drawing.Color.Transparent;
            this.LeagueLogo.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.LeagueLogo_11;
            this.LeagueLogo.Location = new System.Drawing.Point(8, 552);
            this.LeagueLogo.Name = "LeagueLogo";
            this.LeagueLogo.Size = new System.Drawing.Size(222, 222);
            this.LeagueLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeagueLogo.TabIndex = 38;
            this.LeagueLogo.TabStop = false;
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
            this.ExpandChatroom.TabIndex = 39;
            this.ExpandChatroom.UseVisualStyleBackColor = false;
            this.ExpandChatroom.Click += new System.EventHandler(this.ExpandChatroom_Click);
            // 
            // Chatroom
            // 
            this.Chatroom.BackColor = System.Drawing.Color.Transparent;
            this.Chatroom.Location = new System.Drawing.Point(1102, 430);
            this.Chatroom.Name = "Chatroom";
            this.Chatroom.Size = new System.Drawing.Size(434, 434);
            this.Chatroom.TabIndex = 40;
            // 
            // SubPages
            // 
            this.SubPages.BackColor = System.Drawing.Color.Transparent;
            this.SubPages.Location = new System.Drawing.Point(237, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1299, 777);
            this.SubPages.TabIndex = 41;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.Black;
            this.Return.Location = new System.Drawing.Point(8, 839);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(87, 16);
            this.Return.TabIndex = 42;
            this.Return.Text = "回到儀表板";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // LeagueMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.LO_Base;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ExpandChatroom);
            this.Controls.Add(this.LeagueLogo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.RatingManagement);
            this.Controls.Add(this.MemberManagement);
            this.Controls.Add(this.ProposeGames);
            this.Controls.Add(this.LeagueOverview);
            this.Controls.Add(this.Chatroom);
            this.Controls.Add(this.SubPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeagueMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBN聯盟後台";
            this.Load += new System.EventHandler(this.LeagueMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeagueLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeagueOverview;
        private System.Windows.Forms.Button ProposeGames;
        private System.Windows.Forms.Button MemberManagement;
        private System.Windows.Forms.Button RatingManagement;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox LeagueLogo;
        private System.Windows.Forms.Button ExpandChatroom;
        private System.Windows.Forms.Panel Chatroom;
        private System.Windows.Forms.Panel SubPages;
        private System.Windows.Forms.Label Return;
        private System.Windows.Forms.Timer Tick;
    }
}