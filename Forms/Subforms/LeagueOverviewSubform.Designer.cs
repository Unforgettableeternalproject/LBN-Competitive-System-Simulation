namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class LeagueOverviewSubform
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
            this.LeagueName = new System.Windows.Forms.Label();
            this.LeagueMotto = new System.Windows.Forms.Label();
            this.LeagueType = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.Modify_1 = new System.Windows.Forms.Button();
            this.LMotto = new System.Windows.Forms.TextBox();
            this.LType = new System.Windows.Forms.ComboBox();
            this.Modify_2 = new System.Windows.Forms.Button();
            this.Modify_3 = new System.Windows.Forms.Button();
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.LeagueLogo = new System.Windows.Forms.Label();
            this.VerifyStatus = new System.Windows.Forms.Label();
            this.MemberCount = new System.Windows.Forms.Label();
            this.LeagueRating = new System.Windows.Forms.Label();
            this.SendVerification = new System.Windows.Forms.Button();
            this.EventLog = new System.Windows.Forms.RichTextBox();
            this.LeagueEvent = new System.Windows.Forms.Label();
            this.LeagueAnnounement = new System.Windows.Forms.Label();
            this.AnnouncementCreator = new System.Windows.Forms.GroupBox();
            this.Publish = new System.Windows.Forms.Button();
            this.ANEndDate = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.ANStartDate = new System.Windows.Forms.DateTimePicker();
            this.AnnouncementLasts = new System.Windows.Forms.Label();
            this.ANContext = new System.Windows.Forms.RichTextBox();
            this.AnnouncementContext = new System.Windows.Forms.Label();
            this.ANName = new System.Windows.Forms.TextBox();
            this.AnnouncementName = new System.Windows.Forms.Label();
            this.CreateAnnoucement = new System.Windows.Forms.Button();
            this.DeleteLog = new System.Windows.Forms.Button();
            this.CopyToClipboard = new System.Windows.Forms.Button();
            this.PublishStatus = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.AnnouncementCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeagueName
            // 
            this.LeagueName.AutoSize = true;
            this.LeagueName.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueName.Location = new System.Drawing.Point(144, 98);
            this.LeagueName.Name = "LeagueName";
            this.LeagueName.Size = new System.Drawing.Size(99, 21);
            this.LeagueName.TabIndex = 1;
            this.LeagueName.Text = "聯盟名稱:";
            // 
            // LeagueMotto
            // 
            this.LeagueMotto.AutoSize = true;
            this.LeagueMotto.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueMotto.Location = new System.Drawing.Point(123, 158);
            this.LeagueMotto.Name = "LeagueMotto";
            this.LeagueMotto.Size = new System.Drawing.Size(120, 21);
            this.LeagueMotto.TabIndex = 2;
            this.LeagueMotto.Text = "聯盟座右銘:";
            // 
            // LeagueType
            // 
            this.LeagueType.AutoSize = true;
            this.LeagueType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueType.Location = new System.Drawing.Point(144, 218);
            this.LeagueType.Name = "LeagueType";
            this.LeagueType.Size = new System.Drawing.Size(99, 21);
            this.LeagueType.TabIndex = 3;
            this.LeagueType.Text = "聯盟類型:";
            // 
            // LName
            // 
            this.LName.Enabled = false;
            this.LName.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(251, 94);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(151, 30);
            this.LName.TabIndex = 4;
            // 
            // Modify_1
            // 
            this.Modify_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Modify_1.Location = new System.Drawing.Point(418, 94);
            this.Modify_1.Name = "Modify_1";
            this.Modify_1.Size = new System.Drawing.Size(64, 30);
            this.Modify_1.TabIndex = 5;
            this.Modify_1.Text = "修改";
            this.Modify_1.UseVisualStyleBackColor = true;
            this.Modify_1.Click += new System.EventHandler(this.Modify_1_Click);
            // 
            // LMotto
            // 
            this.LMotto.Enabled = false;
            this.LMotto.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMotto.Location = new System.Drawing.Point(251, 154);
            this.LMotto.Name = "LMotto";
            this.LMotto.Size = new System.Drawing.Size(151, 30);
            this.LMotto.TabIndex = 6;
            // 
            // LType
            // 
            this.LType.Enabled = false;
            this.LType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LType.FormattingEnabled = true;
            this.LType.Items.AddRange(new object[] {
            "休閒型聯盟",
            "競技型聯盟",
            "合作型聯盟"});
            this.LType.Location = new System.Drawing.Point(251, 217);
            this.LType.Name = "LType";
            this.LType.Size = new System.Drawing.Size(151, 27);
            this.LType.TabIndex = 7;
            // 
            // Modify_2
            // 
            this.Modify_2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Modify_2.Location = new System.Drawing.Point(418, 154);
            this.Modify_2.Name = "Modify_2";
            this.Modify_2.Size = new System.Drawing.Size(64, 30);
            this.Modify_2.TabIndex = 8;
            this.Modify_2.Text = "修改";
            this.Modify_2.UseVisualStyleBackColor = true;
            this.Modify_2.Click += new System.EventHandler(this.Modify_2_Click);
            // 
            // Modify_3
            // 
            this.Modify_3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Modify_3.Location = new System.Drawing.Point(418, 214);
            this.Modify_3.Name = "Modify_3";
            this.Modify_3.Size = new System.Drawing.Size(64, 30);
            this.Modify_3.TabIndex = 9;
            this.Modify_3.Text = "修改";
            this.Modify_3.UseVisualStyleBackColor = true;
            this.Modify_3.Click += new System.EventHandler(this.Modify_3_Click);
            // 
            // LogoImg
            // 
            this.LogoImg.BackColor = System.Drawing.Color.Transparent;
            this.LogoImg.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder4;
            this.LogoImg.Location = new System.Drawing.Point(540, 98);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(128, 128);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 10;
            this.LogoImg.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(540, 236);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(61, 32);
            this.Upload.TabIndex = 11;
            this.Upload.Text = "上傳";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(607, 236);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(62, 32);
            this.Remove.TabIndex = 12;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // LeagueLogo
            // 
            this.LeagueLogo.AutoSize = true;
            this.LeagueLogo.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 11F);
            this.LeagueLogo.Location = new System.Drawing.Point(569, 74);
            this.LeagueLogo.Name = "LeagueLogo";
            this.LeagueLogo.Size = new System.Drawing.Size(67, 15);
            this.LeagueLogo.TabIndex = 13;
            this.LeagueLogo.Text = "聯盟標誌";
            // 
            // VerifyStatus
            // 
            this.VerifyStatus.AutoSize = true;
            this.VerifyStatus.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyStatus.Location = new System.Drawing.Point(807, 98);
            this.VerifyStatus.Name = "VerifyStatus";
            this.VerifyStatus.Size = new System.Drawing.Size(173, 21);
            this.VerifyStatus.TabIndex = 14;
            this.VerifyStatus.Text = "驗證狀態: 待驗證";
            // 
            // MemberCount
            // 
            this.MemberCount.AutoSize = true;
            this.MemberCount.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberCount.Location = new System.Drawing.Point(807, 158);
            this.MemberCount.Name = "MemberCount";
            this.MemberCount.Size = new System.Drawing.Size(99, 21);
            this.MemberCount.TabIndex = 15;
            this.MemberCount.Text = "成員數量:";
            // 
            // LeagueRating
            // 
            this.LeagueRating.AutoSize = true;
            this.LeagueRating.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueRating.Location = new System.Drawing.Point(807, 218);
            this.LeagueRating.Name = "LeagueRating";
            this.LeagueRating.Size = new System.Drawing.Size(99, 21);
            this.LeagueRating.TabIndex = 16;
            this.LeagueRating.Text = "聯盟評級:";
            // 
            // SendVerification
            // 
            this.SendVerification.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendVerification.Location = new System.Drawing.Point(1013, 86);
            this.SendVerification.Name = "SendVerification";
            this.SendVerification.Size = new System.Drawing.Size(77, 44);
            this.SendVerification.TabIndex = 17;
            this.SendVerification.Text = "送出驗證請求";
            this.SendVerification.UseVisualStyleBackColor = true;
            this.SendVerification.Click += new System.EventHandler(this.SendVerification_Click);
            // 
            // EventLog
            // 
            this.EventLog.Enabled = false;
            this.EventLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EventLog.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EventLog.Location = new System.Drawing.Point(835, 389);
            this.EventLog.Name = "EventLog";
            this.EventLog.Size = new System.Drawing.Size(301, 278);
            this.EventLog.TabIndex = 18;
            this.EventLog.Text = "米糕";
            // 
            // LeagueEvent
            // 
            this.LeagueEvent.AutoSize = true;
            this.LeagueEvent.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueEvent.Location = new System.Drawing.Point(920, 352);
            this.LeagueEvent.Name = "LeagueEvent";
            this.LeagueEvent.Size = new System.Drawing.Size(115, 21);
            this.LeagueEvent.TabIndex = 19;
            this.LeagueEvent.Text = "聯盟內事件";
            // 
            // LeagueAnnounement
            // 
            this.LeagueAnnounement.AutoSize = true;
            this.LeagueAnnounement.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueAnnounement.Location = new System.Drawing.Point(144, 352);
            this.LeagueAnnounement.Name = "LeagueAnnounement";
            this.LeagueAnnounement.Size = new System.Drawing.Size(141, 21);
            this.LeagueAnnounement.TabIndex = 20;
            this.LeagueAnnounement.Text = "公告發布系統:";
            // 
            // AnnouncementCreator
            // 
            this.AnnouncementCreator.BackColor = System.Drawing.Color.Transparent;
            this.AnnouncementCreator.Controls.Add(this.Publish);
            this.AnnouncementCreator.Controls.Add(this.ANEndDate);
            this.AnnouncementCreator.Controls.Add(this.To);
            this.AnnouncementCreator.Controls.Add(this.ANStartDate);
            this.AnnouncementCreator.Controls.Add(this.AnnouncementLasts);
            this.AnnouncementCreator.Controls.Add(this.ANContext);
            this.AnnouncementCreator.Controls.Add(this.AnnouncementContext);
            this.AnnouncementCreator.Controls.Add(this.ANName);
            this.AnnouncementCreator.Controls.Add(this.AnnouncementName);
            this.AnnouncementCreator.Enabled = false;
            this.AnnouncementCreator.Location = new System.Drawing.Point(145, 389);
            this.AnnouncementCreator.Name = "AnnouncementCreator";
            this.AnnouncementCreator.Size = new System.Drawing.Size(545, 277);
            this.AnnouncementCreator.TabIndex = 21;
            this.AnnouncementCreator.TabStop = false;
            // 
            // Publish
            // 
            this.Publish.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Publish.Location = new System.Drawing.Point(368, 218);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(102, 40);
            this.Publish.TabIndex = 26;
            this.Publish.Text = "確認發布";
            this.Publish.UseVisualStyleBackColor = true;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // ANEndDate
            // 
            this.ANEndDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANEndDate.Location = new System.Drawing.Point(315, 142);
            this.ANEndDate.Name = "ANEndDate";
            this.ANEndDate.Size = new System.Drawing.Size(210, 30);
            this.ANEndDate.TabIndex = 32;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(399, 106);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(31, 21);
            this.To.TabIndex = 31;
            this.To.Text = "至";
            // 
            // ANStartDate
            // 
            this.ANStartDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANStartDate.Location = new System.Drawing.Point(315, 65);
            this.ANStartDate.Name = "ANStartDate";
            this.ANStartDate.Size = new System.Drawing.Size(210, 30);
            this.ANStartDate.TabIndex = 30;
            this.ANStartDate.ValueChanged += new System.EventHandler(this.ANStartDate_ValueChanged);
            // 
            // AnnouncementLasts
            // 
            this.AnnouncementLasts.AutoSize = true;
            this.AnnouncementLasts.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementLasts.Location = new System.Drawing.Point(311, 18);
            this.AnnouncementLasts.Name = "AnnouncementLasts";
            this.AnnouncementLasts.Size = new System.Drawing.Size(99, 21);
            this.AnnouncementLasts.TabIndex = 29;
            this.AnnouncementLasts.Text = "公告日期:";
            // 
            // ANContext
            // 
            this.ANContext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ANContext.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ANContext.Location = new System.Drawing.Point(20, 102);
            this.ANContext.Name = "ANContext";
            this.ANContext.Size = new System.Drawing.Size(257, 156);
            this.ANContext.TabIndex = 28;
            this.ANContext.Text = "輸入內文...";
            // 
            // AnnouncementContext
            // 
            this.AnnouncementContext.AutoSize = true;
            this.AnnouncementContext.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementContext.Location = new System.Drawing.Point(16, 65);
            this.AnnouncementContext.Name = "AnnouncementContext";
            this.AnnouncementContext.Size = new System.Drawing.Size(99, 21);
            this.AnnouncementContext.TabIndex = 27;
            this.AnnouncementContext.Text = "公告內文:";
            // 
            // ANName
            // 
            this.ANName.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ANName.Location = new System.Drawing.Point(127, 13);
            this.ANName.Name = "ANName";
            this.ANName.Size = new System.Drawing.Size(151, 30);
            this.ANName.TabIndex = 26;
            this.ANName.Text = "輸入標題...";
            // 
            // AnnouncementName
            // 
            this.AnnouncementName.AutoSize = true;
            this.AnnouncementName.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementName.Location = new System.Drawing.Point(16, 18);
            this.AnnouncementName.Name = "AnnouncementName";
            this.AnnouncementName.Size = new System.Drawing.Size(99, 21);
            this.AnnouncementName.TabIndex = 26;
            this.AnnouncementName.Text = "公告標題:";
            // 
            // CreateAnnoucement
            // 
            this.CreateAnnoucement.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.CreateAnnoucement.Location = new System.Drawing.Point(300, 348);
            this.CreateAnnoucement.Name = "CreateAnnoucement";
            this.CreateAnnoucement.Size = new System.Drawing.Size(102, 30);
            this.CreateAnnoucement.TabIndex = 22;
            this.CreateAnnoucement.Text = "創建新公告";
            this.CreateAnnoucement.UseVisualStyleBackColor = true;
            this.CreateAnnoucement.Click += new System.EventHandler(this.CreateAnnoucement_Click);
            // 
            // DeleteLog
            // 
            this.DeleteLog.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLog.Location = new System.Drawing.Point(835, 673);
            this.DeleteLog.Name = "DeleteLog";
            this.DeleteLog.Size = new System.Drawing.Size(114, 32);
            this.DeleteLog.TabIndex = 23;
            this.DeleteLog.Text = "刪除事件紀錄";
            this.DeleteLog.UseVisualStyleBackColor = true;
            this.DeleteLog.Click += new System.EventHandler(this.DeleteLog_Click);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyToClipboard.Location = new System.Drawing.Point(1022, 673);
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(114, 32);
            this.CopyToClipboard.TabIndex = 24;
            this.CopyToClipboard.Text = "複製到剪貼簿";
            this.CopyToClipboard.UseVisualStyleBackColor = true;
            this.CopyToClipboard.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // PublishStatus
            // 
            this.PublishStatus.AutoSize = true;
            this.PublishStatus.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishStatus.Location = new System.Drawing.Point(144, 684);
            this.PublishStatus.Name = "PublishStatus";
            this.PublishStatus.Size = new System.Drawing.Size(213, 21);
            this.PublishStatus.TabIndex = 25;
            this.PublishStatus.Text = "目前有{}則公告張貼中";
            // 
            // Tick
            // 
            this.Tick.Interval = 1000;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // LeagueOverviewSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.LOPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.PublishStatus);
            this.Controls.Add(this.CopyToClipboard);
            this.Controls.Add(this.DeleteLog);
            this.Controls.Add(this.CreateAnnoucement);
            this.Controls.Add(this.AnnouncementCreator);
            this.Controls.Add(this.LeagueAnnounement);
            this.Controls.Add(this.LeagueEvent);
            this.Controls.Add(this.EventLog);
            this.Controls.Add(this.SendVerification);
            this.Controls.Add(this.LeagueRating);
            this.Controls.Add(this.MemberCount);
            this.Controls.Add(this.VerifyStatus);
            this.Controls.Add(this.LeagueLogo);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.LogoImg);
            this.Controls.Add(this.Modify_3);
            this.Controls.Add(this.Modify_2);
            this.Controls.Add(this.LType);
            this.Controls.Add(this.LMotto);
            this.Controls.Add(this.Modify_1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LeagueType);
            this.Controls.Add(this.LeagueMotto);
            this.Controls.Add(this.LeagueName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeagueOverviewSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LeagueOverviewSubform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.AnnouncementCreator.ResumeLayout(false);
            this.AnnouncementCreator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeagueName;
        private System.Windows.Forms.Label LeagueMotto;
        private System.Windows.Forms.Label LeagueType;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Button Modify_1;
        private System.Windows.Forms.TextBox LMotto;
        private System.Windows.Forms.ComboBox LType;
        private System.Windows.Forms.Button Modify_2;
        private System.Windows.Forms.Button Modify_3;
        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label LeagueLogo;
        private System.Windows.Forms.Label VerifyStatus;
        private System.Windows.Forms.Label MemberCount;
        private System.Windows.Forms.Label LeagueRating;
        private System.Windows.Forms.Button SendVerification;
        private System.Windows.Forms.RichTextBox EventLog;
        private System.Windows.Forms.Label LeagueEvent;
        private System.Windows.Forms.Label LeagueAnnounement;
        private System.Windows.Forms.GroupBox AnnouncementCreator;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.DateTimePicker ANEndDate;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker ANStartDate;
        private System.Windows.Forms.Label AnnouncementLasts;
        private System.Windows.Forms.RichTextBox ANContext;
        private System.Windows.Forms.Label AnnouncementContext;
        private System.Windows.Forms.TextBox ANName;
        private System.Windows.Forms.Label AnnouncementName;
        private System.Windows.Forms.Button CreateAnnoucement;
        private System.Windows.Forms.Button DeleteLog;
        private System.Windows.Forms.Button CopyToClipboard;
        private System.Windows.Forms.Label PublishStatus;
        private System.Windows.Forms.Timer Tick;
    }
}