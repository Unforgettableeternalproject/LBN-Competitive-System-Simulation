namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class ProposeGamesSubform
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
            this.GameManagementLBL = new System.Windows.Forms.Label();
            this.NewProposal = new System.Windows.Forms.Button();
            this.RemoveProposal = new System.Windows.Forms.Button();
            this.ProposalMaker = new System.Windows.Forms.GroupBox();
            this.Return_A = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.Button();
            this.DoNotify = new System.Windows.Forms.CheckBox();
            this.Notify = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.GameDate = new System.Windows.Forms.Label();
            this.FormatDescription = new System.Windows.Forms.Label();
            this.FormatChooser = new System.Windows.Forms.ComboBox();
            this.GameFormat = new System.Windows.Forms.Label();
            this.TypeDescription = new System.Windows.Forms.Label();
            this.TypeChooser = new System.Windows.Forms.ComboBox();
            this.GameType = new System.Windows.Forms.Label();
            this.ProposalStatus = new System.Windows.Forms.Label();
            this.InQueue = new System.Windows.Forms.Label();
            this.Adopted = new System.Windows.Forms.Label();
            this.Rejected = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.Label();
            this.ProposalDisplay = new System.Windows.Forms.GroupBox();
            this.Return_R = new System.Windows.Forms.Button();
            this.Remove2 = new System.Windows.Forms.Button();
            this.Proposal2 = new System.Windows.Forms.Label();
            this.Remove1 = new System.Windows.Forms.Button();
            this.Proposal1 = new System.Windows.Forms.Label();
            this.Empty = new System.Windows.Forms.Label();
            this.Others = new System.Windows.Forms.Label();
            this.ContactAdmin = new System.Windows.Forms.Button();
            this.RemoveIdle = new System.Windows.Forms.Button();
            this.Explaination = new System.Windows.Forms.ToolTip(this.components);
            this.WebDisplay = new System.Windows.Forms.GroupBox();
            this.GameInfo = new System.Windows.Forms.Label();
            this.Web = new System.Windows.Forms.WebBrowser();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.ProposalMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ProposalDisplay.SuspendLayout();
            this.WebDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameManagementLBL
            // 
            this.GameManagementLBL.AutoSize = true;
            this.GameManagementLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameManagementLBL.Location = new System.Drawing.Point(153, 108);
            this.GameManagementLBL.Name = "GameManagementLBL";
            this.GameManagementLBL.Size = new System.Drawing.Size(99, 21);
            this.GameManagementLBL.TabIndex = 0;
            this.GameManagementLBL.Text = "競賽管理:";
            // 
            // NewProposal
            // 
            this.NewProposal.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProposal.Location = new System.Drawing.Point(301, 100);
            this.NewProposal.Name = "NewProposal";
            this.NewProposal.Size = new System.Drawing.Size(115, 40);
            this.NewProposal.TabIndex = 1;
            this.NewProposal.Text = "建立新的競賽";
            this.NewProposal.UseVisualStyleBackColor = true;
            this.NewProposal.Click += new System.EventHandler(this.NewProposal_Click);
            // 
            // RemoveProposal
            // 
            this.RemoveProposal.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProposal.Location = new System.Drawing.Point(489, 100);
            this.RemoveProposal.Name = "RemoveProposal";
            this.RemoveProposal.Size = new System.Drawing.Size(115, 40);
            this.RemoveProposal.TabIndex = 2;
            this.RemoveProposal.Text = "移除現有請求";
            this.RemoveProposal.UseVisualStyleBackColor = true;
            this.RemoveProposal.Click += new System.EventHandler(this.RemoveProposal_Click);
            // 
            // ProposalMaker
            // 
            this.ProposalMaker.BackColor = System.Drawing.Color.Transparent;
            this.ProposalMaker.Controls.Add(this.Return_A);
            this.ProposalMaker.Controls.Add(this.pictureBox1);
            this.ProposalMaker.Controls.Add(this.Submit);
            this.ProposalMaker.Controls.Add(this.DoNotify);
            this.ProposalMaker.Controls.Add(this.Notify);
            this.ProposalMaker.Controls.Add(this.EndDate);
            this.ProposalMaker.Controls.Add(this.To);
            this.ProposalMaker.Controls.Add(this.StartDate);
            this.ProposalMaker.Controls.Add(this.GameDate);
            this.ProposalMaker.Controls.Add(this.FormatDescription);
            this.ProposalMaker.Controls.Add(this.FormatChooser);
            this.ProposalMaker.Controls.Add(this.GameFormat);
            this.ProposalMaker.Controls.Add(this.TypeDescription);
            this.ProposalMaker.Controls.Add(this.TypeChooser);
            this.ProposalMaker.Controls.Add(this.GameType);
            this.ProposalMaker.Location = new System.Drawing.Point(138, 165);
            this.ProposalMaker.Name = "ProposalMaker";
            this.ProposalMaker.Size = new System.Drawing.Size(532, 511);
            this.ProposalMaker.TabIndex = 3;
            this.ProposalMaker.TabStop = false;
            // 
            // Return_A
            // 
            this.Return_A.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_A.Location = new System.Drawing.Point(462, 477);
            this.Return_A.Name = "Return_A";
            this.Return_A.Size = new System.Drawing.Size(69, 33);
            this.Return_A.TabIndex = 26;
            this.Return_A.Text = "返回";
            this.Return_A.UseVisualStyleBackColor = true;
            this.Return_A.Click += new System.EventHandler(this.Return_A_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Golf;
            this.pictureBox1.Location = new System.Drawing.Point(363, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(208, 445);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(125, 45);
            this.Submit.TabIndex = 24;
            this.Submit.Text = "送出請求";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DoNotify
            // 
            this.DoNotify.AutoSize = true;
            this.DoNotify.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoNotify.Location = new System.Drawing.Point(178, 398);
            this.DoNotify.Name = "DoNotify";
            this.DoNotify.Size = new System.Drawing.Size(74, 23);
            this.DoNotify.TabIndex = 23;
            this.DoNotify.Text = "是/否";
            this.DoNotify.UseVisualStyleBackColor = true;
            // 
            // Notify
            // 
            this.Notify.AutoSize = true;
            this.Notify.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify.Location = new System.Drawing.Point(31, 397);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(141, 21);
            this.Notify.TabIndex = 22;
            this.Notify.Text = "通知聯盟成員:";
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(339, 318);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(152, 27);
            this.EndDate.TabIndex = 21;
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(302, 321);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(31, 21);
            this.To.TabIndex = 20;
            this.To.Text = "至";
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(144, 318);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(152, 27);
            this.StartDate.TabIndex = 19;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // GameDate
            // 
            this.GameDate.AutoSize = true;
            this.GameDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDate.Location = new System.Drawing.Point(31, 321);
            this.GameDate.Name = "GameDate";
            this.GameDate.Size = new System.Drawing.Size(99, 21);
            this.GameDate.TabIndex = 18;
            this.GameDate.Text = "選擇時程:";
            // 
            // FormatDescription
            // 
            this.FormatDescription.AutoSize = true;
            this.FormatDescription.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.FormatDescription.Location = new System.Drawing.Point(32, 229);
            this.FormatDescription.Name = "FormatDescription";
            this.FormatDescription.Size = new System.Drawing.Size(264, 16);
            this.FormatDescription.TabIndex = 17;
            this.FormatDescription.Text = "模式說明: 您尚未選擇一種競賽模式!";
            // 
            // FormatChooser
            // 
            this.FormatChooser.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatChooser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormatChooser.FormattingEnabled = true;
            this.FormatChooser.Items.AddRange(new object[] {
            "單淘汰賽制",
            "雙淘汰賽制",
            "小組賽制",
            "圓桌賽制",
            "混合團體賽制",
            "速度賽制"});
            this.FormatChooser.Location = new System.Drawing.Point(144, 180);
            this.FormatChooser.Name = "FormatChooser";
            this.FormatChooser.Size = new System.Drawing.Size(166, 27);
            this.FormatChooser.TabIndex = 16;
            this.FormatChooser.Text = "選擇模式...";
            // 
            // GameFormat
            // 
            this.GameFormat.AutoSize = true;
            this.GameFormat.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameFormat.Location = new System.Drawing.Point(31, 183);
            this.GameFormat.Name = "GameFormat";
            this.GameFormat.Size = new System.Drawing.Size(99, 21);
            this.GameFormat.TabIndex = 15;
            this.GameFormat.Text = "競賽模式:";
            // 
            // TypeDescription
            // 
            this.TypeDescription.AutoSize = true;
            this.TypeDescription.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.TypeDescription.Location = new System.Drawing.Point(32, 87);
            this.TypeDescription.Name = "TypeDescription";
            this.TypeDescription.Size = new System.Drawing.Size(264, 16);
            this.TypeDescription.TabIndex = 14;
            this.TypeDescription.Text = "類型說明: 您尚未選擇一種競賽類型!";
            // 
            // TypeChooser
            // 
            this.TypeChooser.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeChooser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TypeChooser.FormattingEnabled = true;
            this.TypeChooser.Items.AddRange(new object[] {
            "友誼賽",
            "邀請賽",
            "錦標賽",
            "聯盟賽"});
            this.TypeChooser.Location = new System.Drawing.Point(144, 39);
            this.TypeChooser.Name = "TypeChooser";
            this.TypeChooser.Size = new System.Drawing.Size(166, 27);
            this.TypeChooser.TabIndex = 13;
            this.TypeChooser.Text = "選擇類型...";
            // 
            // GameType
            // 
            this.GameType.AutoSize = true;
            this.GameType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameType.Location = new System.Drawing.Point(31, 41);
            this.GameType.Name = "GameType";
            this.GameType.Size = new System.Drawing.Size(99, 21);
            this.GameType.TabIndex = 12;
            this.GameType.Text = "競賽類型:";
            // 
            // ProposalStatus
            // 
            this.ProposalStatus.AutoSize = true;
            this.ProposalStatus.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProposalStatus.Location = new System.Drawing.Point(765, 108);
            this.ProposalStatus.Name = "ProposalStatus";
            this.ProposalStatus.Size = new System.Drawing.Size(141, 21);
            this.ProposalStatus.TabIndex = 4;
            this.ProposalStatus.Text = "賽事請求狀態:";
            // 
            // InQueue
            // 
            this.InQueue.AutoSize = true;
            this.InQueue.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InQueue.Location = new System.Drawing.Point(806, 143);
            this.InQueue.Name = "InQueue";
            this.InQueue.Size = new System.Drawing.Size(135, 21);
            this.InQueue.TabIndex = 5;
            this.InQueue.Text = "進行中: {} 個";
            // 
            // Adopted
            // 
            this.Adopted.AutoSize = true;
            this.Adopted.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adopted.Location = new System.Drawing.Point(806, 176);
            this.Adopted.Name = "Adopted";
            this.Adopted.Size = new System.Drawing.Size(135, 21);
            this.Adopted.TabIndex = 6;
            this.Adopted.Text = "已准許: {} 個";
            // 
            // Rejected
            // 
            this.Rejected.AutoSize = true;
            this.Rejected.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejected.Location = new System.Drawing.Point(982, 143);
            this.Rejected.Name = "Rejected";
            this.Rejected.Size = new System.Drawing.Size(135, 21);
            this.Rejected.TabIndex = 7;
            this.Rejected.Text = "已駁回: {} 個";
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(982, 176);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(114, 21);
            this.Record.TabIndex = 8;
            this.Record.Text = "歷史: {} 個";
            // 
            // ProposalDisplay
            // 
            this.ProposalDisplay.Controls.Add(this.Return_R);
            this.ProposalDisplay.Controls.Add(this.Remove2);
            this.ProposalDisplay.Controls.Add(this.Proposal2);
            this.ProposalDisplay.Controls.Add(this.Remove1);
            this.ProposalDisplay.Controls.Add(this.Proposal1);
            this.ProposalDisplay.Controls.Add(this.Empty);
            this.ProposalDisplay.Location = new System.Drawing.Point(138, 165);
            this.ProposalDisplay.Name = "ProposalDisplay";
            this.ProposalDisplay.Size = new System.Drawing.Size(532, 511);
            this.ProposalDisplay.TabIndex = 4;
            this.ProposalDisplay.TabStop = false;
            // 
            // Return_R
            // 
            this.Return_R.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_R.Location = new System.Drawing.Point(463, 478);
            this.Return_R.Name = "Return_R";
            this.Return_R.Size = new System.Drawing.Size(69, 33);
            this.Return_R.TabIndex = 27;
            this.Return_R.Text = "返回";
            this.Return_R.UseVisualStyleBackColor = true;
            this.Return_R.Click += new System.EventHandler(this.Return_R_Click);
            // 
            // Remove2
            // 
            this.Remove2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove2.Location = new System.Drawing.Point(422, 118);
            this.Remove2.Name = "Remove2";
            this.Remove2.Size = new System.Drawing.Size(72, 35);
            this.Remove2.TabIndex = 4;
            this.Remove2.Text = "撤銷";
            this.Remove2.UseVisualStyleBackColor = true;
            // 
            // Proposal2
            // 
            this.Proposal2.AutoEllipsis = true;
            this.Proposal2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.Proposal2.Location = new System.Drawing.Point(31, 124);
            this.Proposal2.Name = "Proposal2";
            this.Proposal2.Size = new System.Drawing.Size(385, 22);
            this.Proposal2.TabIndex = 3;
            this.Proposal2.Text = "請求二";
            // 
            // Remove1
            // 
            this.Remove1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove1.Location = new System.Drawing.Point(422, 49);
            this.Remove1.Name = "Remove1";
            this.Remove1.Size = new System.Drawing.Size(72, 35);
            this.Remove1.TabIndex = 2;
            this.Remove1.Text = "撤銷";
            this.Remove1.UseVisualStyleBackColor = true;
            // 
            // Proposal1
            // 
            this.Proposal1.AutoEllipsis = true;
            this.Proposal1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.Proposal1.Location = new System.Drawing.Point(31, 55);
            this.Proposal1.Name = "Proposal1";
            this.Proposal1.Size = new System.Drawing.Size(385, 31);
            this.Proposal1.TabIndex = 1;
            this.Proposal1.Text = "請求一";
            // 
            // Empty
            // 
            this.Empty.AutoSize = true;
            this.Empty.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 24F);
            this.Empty.Location = new System.Drawing.Point(105, 216);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(312, 32);
            this.Empty.TabIndex = 0;
            this.Empty.Text = "沒有任何送出的請求!";
            // 
            // Others
            // 
            this.Others.AutoSize = true;
            this.Others.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Others.Location = new System.Drawing.Point(765, 237);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(99, 21);
            this.Others.TabIndex = 9;
            this.Others.Text = "其他功能:";
            // 
            // ContactAdmin
            // 
            this.ContactAdmin.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactAdmin.Location = new System.Drawing.Point(810, 289);
            this.ContactAdmin.Name = "ContactAdmin";
            this.ContactAdmin.Size = new System.Drawing.Size(113, 55);
            this.ContactAdmin.TabIndex = 10;
            this.ContactAdmin.Text = "連絡管理員";
            this.ContactAdmin.UseVisualStyleBackColor = true;
            this.ContactAdmin.Click += new System.EventHandler(this.ContactAdmin_Click);
            // 
            // RemoveIdle
            // 
            this.RemoveIdle.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveIdle.Location = new System.Drawing.Point(986, 289);
            this.RemoveIdle.Name = "RemoveIdle";
            this.RemoveIdle.Size = new System.Drawing.Size(113, 55);
            this.RemoveIdle.TabIndex = 11;
            this.RemoveIdle.Text = "移除閒置狀態(?)";
            this.Explaination.SetToolTip(this.RemoveIdle, "向系統申請誼出此聯盟的閒置狀態");
            this.RemoveIdle.UseVisualStyleBackColor = true;
            this.RemoveIdle.Click += new System.EventHandler(this.RemoveIdle_Click);
            // 
            // WebDisplay
            // 
            this.WebDisplay.Controls.Add(this.GameInfo);
            this.WebDisplay.Controls.Add(this.Web);
            this.WebDisplay.Location = new System.Drawing.Point(138, 165);
            this.WebDisplay.Name = "WebDisplay";
            this.WebDisplay.Size = new System.Drawing.Size(532, 511);
            this.WebDisplay.TabIndex = 15;
            this.WebDisplay.TabStop = false;
            // 
            // GameInfo
            // 
            this.GameInfo.AutoSize = true;
            this.GameInfo.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfo.Location = new System.Drawing.Point(15, 18);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(141, 21);
            this.GameInfo.TabIndex = 14;
            this.GameInfo.Text = "最新遊戲資訊:";
            // 
            // Web
            // 
            this.Web.Location = new System.Drawing.Point(0, 55);
            this.Web.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web.Name = "Web";
            this.Web.ScriptErrorsSuppressed = true;
            this.Web.Size = new System.Drawing.Size(532, 435);
            this.Web.TabIndex = 13;
            this.Web.Url = new System.Uri("https://www.team17.com/games/golf-with-your-friends/", System.UriKind.Absolute);
            this.Web.WebBrowserShortcutsEnabled = false;
            // 
            // Tick
            // 
            this.Tick.Interval = 1000;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // ProposeGamesSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.PGPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.RemoveIdle);
            this.Controls.Add(this.ContactAdmin);
            this.Controls.Add(this.Others);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Rejected);
            this.Controls.Add(this.Adopted);
            this.Controls.Add(this.InQueue);
            this.Controls.Add(this.ProposalStatus);
            this.Controls.Add(this.ProposalMaker);
            this.Controls.Add(this.ProposalDisplay);
            this.Controls.Add(this.WebDisplay);
            this.Controls.Add(this.RemoveProposal);
            this.Controls.Add(this.NewProposal);
            this.Controls.Add(this.GameManagementLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProposeGamesSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProposeGamesSubform_Load);
            this.ProposalMaker.ResumeLayout(false);
            this.ProposalMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ProposalDisplay.ResumeLayout(false);
            this.ProposalDisplay.PerformLayout();
            this.WebDisplay.ResumeLayout(false);
            this.WebDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameManagementLBL;
        private System.Windows.Forms.Button NewProposal;
        private System.Windows.Forms.Button RemoveProposal;
        private System.Windows.Forms.GroupBox ProposalMaker;
        private System.Windows.Forms.Label ProposalStatus;
        private System.Windows.Forms.Label InQueue;
        private System.Windows.Forms.Label Adopted;
        private System.Windows.Forms.Label Rejected;
        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.GroupBox ProposalDisplay;
        private System.Windows.Forms.Label Others;
        private System.Windows.Forms.Button ContactAdmin;
        private System.Windows.Forms.Button RemoveIdle;
        private System.Windows.Forms.ToolTip Explaination;
        private System.Windows.Forms.Label GameType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.CheckBox DoNotify;
        private System.Windows.Forms.Label Notify;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label GameDate;
        private System.Windows.Forms.Label FormatDescription;
        private System.Windows.Forms.ComboBox FormatChooser;
        private System.Windows.Forms.Label GameFormat;
        private System.Windows.Forms.Label TypeDescription;
        private System.Windows.Forms.ComboBox TypeChooser;
        private System.Windows.Forms.Button Remove2;
        private System.Windows.Forms.Label Proposal2;
        private System.Windows.Forms.Button Remove1;
        private System.Windows.Forms.Label Proposal1;
        private System.Windows.Forms.Label Empty;
        private System.Windows.Forms.GroupBox WebDisplay;
        private System.Windows.Forms.Label GameInfo;
        private System.Windows.Forms.WebBrowser Web;
        private System.Windows.Forms.Button Return_A;
        private System.Windows.Forms.Button Return_R;
        private System.Windows.Forms.Timer Tick;
    }
}