namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class LeagueDutySubform
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
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.FeedLBL = new System.Windows.Forms.Label();
            this.MemberLBL = new System.Windows.Forms.Label();
            this.Members = new System.Windows.Forms.RichTextBox();
            this.FavorText = new System.Windows.Forms.Label();
            this.Feed = new System.Windows.Forms.GroupBox();
            this.FeedPic2 = new System.Windows.Forms.PictureBox();
            this.FeedMsg2 = new System.Windows.Forms.Label();
            this.FeedMsg1 = new System.Windows.Forms.Label();
            this.FeedPic1 = new System.Windows.Forms.PictureBox();
            this.LeagueType = new System.Windows.Forms.Label();
            this.LeaguePage = new System.Windows.Forms.Button();
            this.TransferOwner = new System.Windows.Forms.Button();
            this.LeaveLeague = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Rankings = new System.Windows.Forms.Label();
            this.InLeague = new System.Windows.Forms.GroupBox();
            this.OutLeague = new System.Windows.Forms.GroupBox();
            this.ExtendDescription = new System.Windows.Forms.ToolTip(this.components);
            this.LogoLBL = new System.Windows.Forms.Label();
            this.ContactOwner = new System.Windows.Forms.Button();
            this.Feed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.InLeague.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(27, 22);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(131, 25);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "歡迎回到{}!";
            // 
            // FeedLBL
            // 
            this.FeedLBL.AutoSize = true;
            this.FeedLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedLBL.Location = new System.Drawing.Point(27, 270);
            this.FeedLBL.Name = "FeedLBL";
            this.FeedLBL.Size = new System.Drawing.Size(163, 25);
            this.FeedLBL.TabIndex = 1;
            this.FeedLBL.Text = "最新聯盟動態!";
            // 
            // MemberLBL
            // 
            this.MemberLBL.AutoSize = true;
            this.MemberLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberLBL.Location = new System.Drawing.Point(727, 264);
            this.MemberLBL.Name = "MemberLBL";
            this.MemberLBL.Size = new System.Drawing.Size(108, 25);
            this.MemberLBL.TabIndex = 2;
            this.MemberLBL.Text = "聯盟成員";
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.SystemColors.Window;
            this.Members.Enabled = false;
            this.Members.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Members.Location = new System.Drawing.Point(660, 306);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(252, 374);
            this.Members.TabIndex = 3;
            this.Members.Text = "";
            // 
            // FavorText
            // 
            this.FavorText.AutoEllipsis = true;
            this.FavorText.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavorText.Location = new System.Drawing.Point(28, 65);
            this.FavorText.Name = "FavorText";
            this.FavorText.Size = new System.Drawing.Size(347, 19);
            this.FavorText.TabIndex = 4;
            this.FavorText.Text = "座右銘:";
            // 
            // Feed
            // 
            this.Feed.BackColor = System.Drawing.Color.Transparent;
            this.Feed.Controls.Add(this.FeedPic2);
            this.Feed.Controls.Add(this.FeedMsg2);
            this.Feed.Controls.Add(this.FeedMsg1);
            this.Feed.Controls.Add(this.FeedPic1);
            this.Feed.Location = new System.Drawing.Point(32, 307);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(550, 373);
            this.Feed.TabIndex = 5;
            this.Feed.TabStop = false;
            // 
            // FeedPic2
            // 
            this.FeedPic2.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Novia;
            this.FeedPic2.Location = new System.Drawing.Point(388, 147);
            this.FeedPic2.Name = "FeedPic2";
            this.FeedPic2.Size = new System.Drawing.Size(161, 225);
            this.FeedPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FeedPic2.TabIndex = 3;
            this.FeedPic2.TabStop = false;
            // 
            // FeedMsg2
            // 
            this.FeedMsg2.AutoEllipsis = true;
            this.FeedMsg2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedMsg2.Location = new System.Drawing.Point(15, 314);
            this.FeedMsg2.Name = "FeedMsg2";
            this.FeedMsg2.Size = new System.Drawing.Size(349, 21);
            this.FeedMsg2.TabIndex = 2;
            this.FeedMsg2.Text = "[插入動態消息]";
            // 
            // FeedMsg1
            // 
            this.FeedMsg1.AutoEllipsis = true;
            this.FeedMsg1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedMsg1.Location = new System.Drawing.Point(15, 266);
            this.FeedMsg1.Name = "FeedMsg1";
            this.FeedMsg1.Size = new System.Drawing.Size(349, 21);
            this.FeedMsg1.TabIndex = 1;
            this.FeedMsg1.Text = "[插入動態消息]";
            // 
            // FeedPic1
            // 
            this.FeedPic1.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Announement;
            this.FeedPic1.Location = new System.Drawing.Point(19, 29);
            this.FeedPic1.Name = "FeedPic1";
            this.FeedPic1.Size = new System.Drawing.Size(345, 199);
            this.FeedPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FeedPic1.TabIndex = 0;
            this.FeedPic1.TabStop = false;
            // 
            // LeagueType
            // 
            this.LeagueType.AutoSize = true;
            this.LeagueType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueType.Location = new System.Drawing.Point(28, 101);
            this.LeagueType.Name = "LeagueType";
            this.LeagueType.Size = new System.Drawing.Size(90, 19);
            this.LeagueType.TabIndex = 6;
            this.LeagueType.Text = "聯盟類型:";
            // 
            // LeaguePage
            // 
            this.LeaguePage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaguePage.Location = new System.Drawing.Point(798, 8);
            this.LeaguePage.Name = "LeaguePage";
            this.LeaguePage.Size = new System.Drawing.Size(114, 39);
            this.LeaguePage.TabIndex = 7;
            this.LeaguePage.Text = "聯盟頁面";
            this.LeaguePage.UseVisualStyleBackColor = true;
            // 
            // TransferOwner
            // 
            this.TransferOwner.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferOwner.Location = new System.Drawing.Point(798, 55);
            this.TransferOwner.Name = "TransferOwner";
            this.TransferOwner.Size = new System.Drawing.Size(114, 39);
            this.TransferOwner.TabIndex = 8;
            this.TransferOwner.Text = "轉讓所有權";
            this.TransferOwner.UseVisualStyleBackColor = true;
            // 
            // LeaveLeague
            // 
            this.LeaveLeague.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveLeague.Location = new System.Drawing.Point(798, 142);
            this.LeaveLeague.Name = "LeaveLeague";
            this.LeaveLeague.Size = new System.Drawing.Size(114, 39);
            this.LeaveLeague.TabIndex = 9;
            this.LeaveLeague.Text = "離開聯盟";
            this.LeaveLeague.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.LeagueLogo_1;
            this.Logo.Location = new System.Drawing.Point(399, 21);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(140, 140);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // Rankings
            // 
            this.Rankings.AutoSize = true;
            this.Rankings.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rankings.Location = new System.Drawing.Point(28, 162);
            this.Rankings.Name = "Rankings";
            this.Rankings.Size = new System.Drawing.Size(90, 19);
            this.Rankings.TabIndex = 11;
            this.Rankings.Text = "本周排名:";
            // 
            // InLeague
            // 
            this.InLeague.BackColor = System.Drawing.Color.Transparent;
            this.InLeague.Controls.Add(this.ContactOwner);
            this.InLeague.Controls.Add(this.LogoLBL);
            this.InLeague.Controls.Add(this.Rankings);
            this.InLeague.Controls.Add(this.Logo);
            this.InLeague.Controls.Add(this.LeaveLeague);
            this.InLeague.Controls.Add(this.TransferOwner);
            this.InLeague.Controls.Add(this.LeaguePage);
            this.InLeague.Controls.Add(this.LeagueType);
            this.InLeague.Controls.Add(this.Feed);
            this.InLeague.Controls.Add(this.FavorText);
            this.InLeague.Controls.Add(this.Members);
            this.InLeague.Controls.Add(this.MemberLBL);
            this.InLeague.Controls.Add(this.FeedLBL);
            this.InLeague.Controls.Add(this.WelcomeMessage);
            this.InLeague.Location = new System.Drawing.Point(88, 37);
            this.InLeague.Name = "InLeague";
            this.InLeague.Size = new System.Drawing.Size(933, 699);
            this.InLeague.TabIndex = 12;
            this.InLeague.TabStop = false;
            // 
            // OutLeague
            // 
            this.OutLeague.BackColor = System.Drawing.Color.Transparent;
            this.OutLeague.Location = new System.Drawing.Point(88, 39);
            this.OutLeague.Name = "OutLeague";
            this.OutLeague.Size = new System.Drawing.Size(933, 699);
            this.OutLeague.TabIndex = 13;
            this.OutLeague.TabStop = false;
            // 
            // LogoLBL
            // 
            this.LogoLBL.AutoSize = true;
            this.LogoLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLBL.Location = new System.Drawing.Point(433, 173);
            this.LogoLBL.Name = "LogoLBL";
            this.LogoLBL.Size = new System.Drawing.Size(71, 16);
            this.LogoLBL.TabIndex = 12;
            this.LogoLBL.Text = "聯盟標誌";
            // 
            // ContactOwner
            // 
            this.ContactOwner.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactOwner.Location = new System.Drawing.Point(660, 142);
            this.ContactOwner.Name = "ContactOwner";
            this.ContactOwner.Size = new System.Drawing.Size(114, 39);
            this.ContactOwner.TabIndex = 13;
            this.ContactOwner.Text = "聯絡所有者";
            this.ContactOwner.UseVisualStyleBackColor = true;
            // 
            // LeagueDutySubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.LDPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.InLeague);
            this.Controls.Add(this.OutLeague);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeagueDutySubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LeagueDutySubform_Load);
            this.Feed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.InLeague.ResumeLayout(false);
            this.InLeague.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label FeedLBL;
        private System.Windows.Forms.Label MemberLBL;
        private System.Windows.Forms.RichTextBox Members;
        private System.Windows.Forms.Label FavorText;
        private System.Windows.Forms.GroupBox Feed;
        private System.Windows.Forms.Label LeagueType;
        private System.Windows.Forms.Button LeaguePage;
        private System.Windows.Forms.Button TransferOwner;
        private System.Windows.Forms.Button LeaveLeague;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Rankings;
        private System.Windows.Forms.GroupBox InLeague;
        private System.Windows.Forms.PictureBox FeedPic2;
        private System.Windows.Forms.Label FeedMsg2;
        private System.Windows.Forms.Label FeedMsg1;
        private System.Windows.Forms.PictureBox FeedPic1;
        private System.Windows.Forms.GroupBox OutLeague;
        private System.Windows.Forms.ToolTip ExtendDescription;
        private System.Windows.Forms.Label LogoLBL;
        private System.Windows.Forms.Button ContactOwner;
    }
}