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
            this.CancelTransfer = new System.Windows.Forms.Button();
            this.EnterUsername = new System.Windows.Forms.TextBox();
            this.ContactOwner = new System.Windows.Forms.Button();
            this.LogoLBL = new System.Windows.Forms.Label();
            this.OutLeague = new System.Windows.Forms.GroupBox();
            this.Hint2 = new System.Windows.Forms.Label();
            this.Hint = new System.Windows.Forms.Label();
            this.PrevPage = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.ModeCreate = new System.Windows.Forms.Button();
            this.ModeSearch = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.CreateLeague = new System.Windows.Forms.GroupBox();
            this.Create = new System.Windows.Forms.Button();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.UploadBTN = new System.Windows.Forms.Button();
            this.UploadLBL = new System.Windows.Forms.Label();
            this.UploadBox = new System.Windows.Forms.PictureBox();
            this.LType_R3 = new System.Windows.Forms.RadioButton();
            this.LType_R2 = new System.Windows.Forms.RadioButton();
            this.LType_R1 = new System.Windows.Forms.RadioButton();
            this.LMottoTXT = new System.Windows.Forms.TextBox();
            this.LNameTXT = new System.Windows.Forms.TextBox();
            this.LTypeLBL = new System.Windows.Forms.Label();
            this.LMottoLBL = new System.Windows.Forms.Label();
            this.LNameLBL = new System.Windows.Forms.Label();
            this.LeagueGridDisplay = new System.Windows.Forms.GroupBox();
            this.NoResult = new System.Windows.Forms.Label();
            this.LeagueListDisplay = new System.Windows.Forms.DataGridView();
            this.ExtendDescription = new System.Windows.Forms.ToolTip(this.components);
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.Feed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.InLeague.SuspendLayout();
            this.OutLeague.SuspendLayout();
            this.CreateLeague.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBox)).BeginInit();
            this.LeagueGridDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeagueListDisplay)).BeginInit();
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
            this.LeaguePage.Click += new System.EventHandler(this.LeaguePage_Click);
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
            this.TransferOwner.Click += new System.EventHandler(this.TransferOwner_Click);
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
            this.LeaveLeague.Click += new System.EventHandler(this.LeaveLeague_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.LeagueLogo_1;
            this.Logo.Location = new System.Drawing.Point(399, 21);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(140, 140);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.InLeague.Controls.Add(this.CancelTransfer);
            this.InLeague.Controls.Add(this.EnterUsername);
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
            // CancelTransfer
            // 
            this.CancelTransfer.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelTransfer.Location = new System.Drawing.Point(798, 101);
            this.CancelTransfer.Name = "CancelTransfer";
            this.CancelTransfer.Size = new System.Drawing.Size(114, 39);
            this.CancelTransfer.TabIndex = 15;
            this.CancelTransfer.Text = "取消";
            this.CancelTransfer.UseVisualStyleBackColor = true;
            this.CancelTransfer.Click += new System.EventHandler(this.CancelTransfer_Click);
            // 
            // EnterUsername
            // 
            this.EnterUsername.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EnterUsername.Location = new System.Drawing.Point(629, 60);
            this.EnterUsername.Name = "EnterUsername";
            this.EnterUsername.Size = new System.Drawing.Size(163, 30);
            this.EnterUsername.TabIndex = 14;
            this.EnterUsername.Text = "輸入使用者名稱...";
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
            this.ContactOwner.Click += new System.EventHandler(this.ContactOwner_Click);
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
            // OutLeague
            // 
            this.OutLeague.BackColor = System.Drawing.Color.Transparent;
            this.OutLeague.Controls.Add(this.Hint2);
            this.OutLeague.Controls.Add(this.Hint);
            this.OutLeague.Controls.Add(this.PrevPage);
            this.OutLeague.Controls.Add(this.SearchBTN);
            this.OutLeague.Controls.Add(this.SearchTXT);
            this.OutLeague.Controls.Add(this.ModeCreate);
            this.OutLeague.Controls.Add(this.ModeSearch);
            this.OutLeague.Controls.Add(this.Status);
            this.OutLeague.Controls.Add(this.CreateLeague);
            this.OutLeague.Controls.Add(this.LeagueGridDisplay);
            this.OutLeague.Location = new System.Drawing.Point(88, 39);
            this.OutLeague.Name = "OutLeague";
            this.OutLeague.Size = new System.Drawing.Size(933, 699);
            this.OutLeague.TabIndex = 13;
            this.OutLeague.TabStop = false;
            // 
            // Hint2
            // 
            this.Hint2.AutoSize = true;
            this.Hint2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint2.Location = new System.Drawing.Point(239, 91);
            this.Hint2.Name = "Hint2";
            this.Hint2.Size = new System.Drawing.Size(462, 32);
            this.Hint2.TabIndex = 8;
            this.Hint2.Text = "填寫下方的資料來創建一個聯盟";
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint.Location = new System.Drawing.Point(360, 152);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(215, 16);
            this.Hint.TabIndex = 7;
            this.Hint.Text = "雙擊一個聯盟來發送加入邀請";
            // 
            // PrevPage
            // 
            this.PrevPage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevPage.Location = new System.Drawing.Point(834, 155);
            this.PrevPage.Name = "PrevPage";
            this.PrevPage.Size = new System.Drawing.Size(77, 31);
            this.PrevPage.TabIndex = 6;
            this.PrevPage.Text = "上一頁";
            this.PrevPage.UseVisualStyleBackColor = true;
            this.PrevPage.Click += new System.EventHandler(this.PrevPage_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Search;
            this.SearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBTN.Location = new System.Drawing.Point(651, 108);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(30, 30);
            this.SearchBTN.TabIndex = 5;
            this.ExtendDescription.SetToolTip(this.SearchBTN, "搜尋");
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchTXT.Location = new System.Drawing.Point(301, 108);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(323, 30);
            this.SearchTXT.TabIndex = 4;
            this.SearchTXT.Text = "輸入聯盟名稱...";
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // ModeCreate
            // 
            this.ModeCreate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeCreate.Location = new System.Drawing.Point(545, 85);
            this.ModeCreate.Name = "ModeCreate";
            this.ModeCreate.Size = new System.Drawing.Size(226, 84);
            this.ModeCreate.TabIndex = 3;
            this.ModeCreate.Text = "創建新的聯盟";
            this.ModeCreate.UseVisualStyleBackColor = true;
            this.ModeCreate.Click += new System.EventHandler(this.ModeCreate_Click);
            // 
            // ModeSearch
            // 
            this.ModeSearch.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeSearch.Location = new System.Drawing.Point(167, 85);
            this.ModeSearch.Name = "ModeSearch";
            this.ModeSearch.Size = new System.Drawing.Size(226, 84);
            this.ModeSearch.TabIndex = 2;
            this.ModeSearch.Text = "搜尋現有的聯盟";
            this.ModeSearch.UseVisualStyleBackColor = true;
            this.ModeSearch.Click += new System.EventHandler(this.ModeSearch_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(356, 24);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(226, 21);
            this.Status.TabIndex = 1;
            this.Status.Text = "你還沒有加入任何聯盟!";
            // 
            // CreateLeague
            // 
            this.CreateLeague.Controls.Add(this.Create);
            this.CreateLeague.Controls.Add(this.RemoveBTN);
            this.CreateLeague.Controls.Add(this.UploadBTN);
            this.CreateLeague.Controls.Add(this.UploadLBL);
            this.CreateLeague.Controls.Add(this.UploadBox);
            this.CreateLeague.Controls.Add(this.LType_R3);
            this.CreateLeague.Controls.Add(this.LType_R2);
            this.CreateLeague.Controls.Add(this.LType_R1);
            this.CreateLeague.Controls.Add(this.LMottoTXT);
            this.CreateLeague.Controls.Add(this.LNameTXT);
            this.CreateLeague.Controls.Add(this.LTypeLBL);
            this.CreateLeague.Controls.Add(this.LMottoLBL);
            this.CreateLeague.Controls.Add(this.LNameLBL);
            this.CreateLeague.Location = new System.Drawing.Point(21, 253);
            this.CreateLeague.Name = "CreateLeague";
            this.CreateLeague.Size = new System.Drawing.Size(890, 424);
            this.CreateLeague.TabIndex = 2;
            this.CreateLeague.TabStop = false;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(357, 318);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(204, 69);
            this.Create.TabIndex = 14;
            this.Create.Text = "確認並創立";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBTN.Location = new System.Drawing.Point(718, 248);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(68, 32);
            this.RemoveBTN.TabIndex = 11;
            this.RemoveBTN.Text = "移除";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // UploadBTN
            // 
            this.UploadBTN.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBTN.Location = new System.Drawing.Point(636, 248);
            this.UploadBTN.Name = "UploadBTN";
            this.UploadBTN.Size = new System.Drawing.Size(68, 32);
            this.UploadBTN.TabIndex = 10;
            this.UploadBTN.Text = "上傳";
            this.UploadBTN.UseVisualStyleBackColor = true;
            this.UploadBTN.Click += new System.EventHandler(this.UploadBTN_Click);
            // 
            // UploadLBL
            // 
            this.UploadLBL.AutoSize = true;
            this.UploadLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadLBL.Location = new System.Drawing.Point(636, 37);
            this.UploadLBL.Name = "UploadLBL";
            this.UploadLBL.Size = new System.Drawing.Size(150, 21);
            this.UploadLBL.TabIndex = 9;
            this.UploadLBL.Text = "聯盟標誌(選填)";
            // 
            // UploadBox
            // 
            this.UploadBox.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder41;
            this.UploadBox.Location = new System.Drawing.Point(636, 76);
            this.UploadBox.Name = "UploadBox";
            this.UploadBox.Size = new System.Drawing.Size(150, 150);
            this.UploadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadBox.TabIndex = 8;
            this.UploadBox.TabStop = false;
            // 
            // LType_R3
            // 
            this.LType_R3.AutoSize = true;
            this.LType_R3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LType_R3.Location = new System.Drawing.Point(443, 247);
            this.LType_R3.Name = "LType_R3";
            this.LType_R3.Size = new System.Drawing.Size(65, 23);
            this.LType_R3.TabIndex = 7;
            this.LType_R3.Text = "合作";
            this.LType_R3.UseVisualStyleBackColor = true;
            // 
            // LType_R2
            // 
            this.LType_R2.AutoSize = true;
            this.LType_R2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LType_R2.Location = new System.Drawing.Point(355, 248);
            this.LType_R2.Name = "LType_R2";
            this.LType_R2.Size = new System.Drawing.Size(65, 23);
            this.LType_R2.TabIndex = 6;
            this.LType_R2.Text = "競技";
            this.LType_R2.UseVisualStyleBackColor = true;
            // 
            // LType_R1
            // 
            this.LType_R1.AutoSize = true;
            this.LType_R1.Checked = true;
            this.LType_R1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LType_R1.Location = new System.Drawing.Point(260, 248);
            this.LType_R1.Name = "LType_R1";
            this.LType_R1.Size = new System.Drawing.Size(65, 23);
            this.LType_R1.TabIndex = 5;
            this.LType_R1.TabStop = true;
            this.LType_R1.Text = "休閒";
            this.LType_R1.UseVisualStyleBackColor = true;
            // 
            // LMottoTXT
            // 
            this.LMottoTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 13F);
            this.LMottoTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LMottoTXT.Location = new System.Drawing.Point(259, 155);
            this.LMottoTXT.Name = "LMottoTXT";
            this.LMottoTXT.Size = new System.Drawing.Size(159, 28);
            this.LMottoTXT.TabIndex = 4;
            this.LMottoTXT.Text = "輸入座右銘...";
            // 
            // LNameTXT
            // 
            this.LNameTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 13F);
            this.LNameTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LNameTXT.Location = new System.Drawing.Point(259, 66);
            this.LNameTXT.Name = "LNameTXT";
            this.LNameTXT.Size = new System.Drawing.Size(159, 28);
            this.LNameTXT.TabIndex = 3;
            this.LNameTXT.Text = "輸入聯盟名稱...";
            // 
            // LTypeLBL
            // 
            this.LTypeLBL.AutoSize = true;
            this.LTypeLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTypeLBL.Location = new System.Drawing.Point(130, 250);
            this.LTypeLBL.Name = "LTypeLBL";
            this.LTypeLBL.Size = new System.Drawing.Size(99, 21);
            this.LTypeLBL.TabIndex = 2;
            this.LTypeLBL.Text = "聯盟類型:";
            // 
            // LMottoLBL
            // 
            this.LMottoLBL.AutoSize = true;
            this.LMottoLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMottoLBL.Location = new System.Drawing.Point(53, 160);
            this.LMottoLBL.Name = "LMottoLBL";
            this.LMottoLBL.Size = new System.Drawing.Size(176, 21);
            this.LMottoLBL.TabIndex = 1;
            this.LMottoLBL.Text = "聯盟座右銘(選填):";
            // 
            // LNameLBL
            // 
            this.LNameLBL.AutoSize = true;
            this.LNameLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLBL.Location = new System.Drawing.Point(130, 70);
            this.LNameLBL.Name = "LNameLBL";
            this.LNameLBL.Size = new System.Drawing.Size(99, 21);
            this.LNameLBL.TabIndex = 0;
            this.LNameLBL.Text = "聯盟名稱:";
            // 
            // LeagueGridDisplay
            // 
            this.LeagueGridDisplay.Controls.Add(this.NoResult);
            this.LeagueGridDisplay.Controls.Add(this.LeagueListDisplay);
            this.LeagueGridDisplay.Location = new System.Drawing.Point(21, 253);
            this.LeagueGridDisplay.Name = "LeagueGridDisplay";
            this.LeagueGridDisplay.Size = new System.Drawing.Size(890, 424);
            this.LeagueGridDisplay.TabIndex = 0;
            this.LeagueGridDisplay.TabStop = false;
            // 
            // NoResult
            // 
            this.NoResult.AutoSize = true;
            this.NoResult.BackColor = System.Drawing.Color.DarkGray;
            this.NoResult.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoResult.ForeColor = System.Drawing.Color.DarkRed;
            this.NoResult.Location = new System.Drawing.Point(368, 198);
            this.NoResult.Name = "NoResult";
            this.NoResult.Size = new System.Drawing.Size(167, 29);
            this.NoResult.TabIndex = 1;
            this.NoResult.Text = "找不到結果!";
            // 
            // LeagueListDisplay
            // 
            this.LeagueListDisplay.AllowUserToAddRows = false;
            this.LeagueListDisplay.AllowUserToDeleteRows = false;
            this.LeagueListDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeagueListDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LeagueListDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeagueListDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeagueListDisplay.Location = new System.Drawing.Point(29, 9);
            this.LeagueListDisplay.Name = "LeagueListDisplay";
            this.LeagueListDisplay.ReadOnly = true;
            this.LeagueListDisplay.RowTemplate.Height = 24;
            this.LeagueListDisplay.Size = new System.Drawing.Size(831, 414);
            this.LeagueListDisplay.TabIndex = 0;
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // LeagueDutySubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.LDPage2;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.OutLeague);
            this.Controls.Add(this.InLeague);
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
            this.OutLeague.ResumeLayout(false);
            this.OutLeague.PerformLayout();
            this.CreateLeague.ResumeLayout(false);
            this.CreateLeague.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadBox)).EndInit();
            this.LeagueGridDisplay.ResumeLayout(false);
            this.LeagueGridDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeagueListDisplay)).EndInit();
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
        private System.Windows.Forms.TextBox EnterUsername;
        private System.Windows.Forms.Button CancelTransfer;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Button ModeCreate;
        private System.Windows.Forms.Button ModeSearch;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.GroupBox LeagueGridDisplay;
        private System.Windows.Forms.DataGridView LeagueListDisplay;
        private System.Windows.Forms.Button PrevPage;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.Label NoResult;
        private System.Windows.Forms.GroupBox CreateLeague;
        private System.Windows.Forms.Label LTypeLBL;
        private System.Windows.Forms.Label LMottoLBL;
        private System.Windows.Forms.Label LNameLBL;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button UploadBTN;
        private System.Windows.Forms.Label UploadLBL;
        private System.Windows.Forms.PictureBox UploadBox;
        private System.Windows.Forms.RadioButton LType_R3;
        private System.Windows.Forms.RadioButton LType_R2;
        private System.Windows.Forms.RadioButton LType_R1;
        private System.Windows.Forms.TextBox LMottoTXT;
        private System.Windows.Forms.TextBox LNameTXT;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label Hint2;
        private System.Windows.Forms.Timer Tick;
    }
}