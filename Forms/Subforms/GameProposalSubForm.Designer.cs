namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class GameProposalSubform
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
            this.Accept = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.ContactLO = new System.Windows.Forms.Button();
            this.Request = new System.Windows.Forms.GroupBox();
            this.FormatNPeriod = new System.Windows.Forms.Label();
            this.DateNType = new System.Windows.Forms.Label();
            this.FromLeague = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.GroupBox();
            this.Proposal_Tick = new System.Windows.Forms.Timer(this.components);
            this.NotifyText = new System.Windows.Forms.Label();
            this.Request.SuspendLayout();
            this.Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.Location = new System.Drawing.Point(6, 12);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(131, 69);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "確認請求";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Decline
            // 
            this.Decline.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decline.Location = new System.Drawing.Point(192, 12);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(131, 69);
            this.Decline.TabIndex = 1;
            this.Decline.Text = "拒絕請求";
            this.Decline.UseVisualStyleBackColor = true;
            this.Decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // ContactLO
            // 
            this.ContactLO.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.ContactLO.Location = new System.Drawing.Point(6, 92);
            this.ContactLO.Name = "ContactLO";
            this.ContactLO.Size = new System.Drawing.Size(317, 30);
            this.ContactLO.TabIndex = 2;
            this.ContactLO.Text = "聯絡請求發出人";
            this.ContactLO.UseVisualStyleBackColor = true;
            this.ContactLO.Click += new System.EventHandler(this.ContactLO_Click);
            // 
            // Request
            // 
            this.Request.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest;
            this.Request.Controls.Add(this.FormatNPeriod);
            this.Request.Controls.Add(this.DateNType);
            this.Request.Controls.Add(this.FromLeague);
            this.Request.Location = new System.Drawing.Point(71, 65);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(586, 125);
            this.Request.TabIndex = 3;
            this.Request.TabStop = false;
            // 
            // FormatNPeriod
            // 
            this.FormatNPeriod.BackColor = System.Drawing.Color.Transparent;
            this.FormatNPeriod.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.FormatNPeriod.Location = new System.Drawing.Point(21, 92);
            this.FormatNPeriod.Name = "FormatNPeriod";
            this.FormatNPeriod.Size = new System.Drawing.Size(545, 21);
            this.FormatNPeriod.TabIndex = 2;
            this.FormatNPeriod.Text = "使用 [賽制]，為期 [天數]";
            this.FormatNPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateNType
            // 
            this.DateNType.BackColor = System.Drawing.Color.Transparent;
            this.DateNType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNType.Location = new System.Drawing.Point(17, 58);
            this.DateNType.Name = "DateNType";
            this.DateNType.Size = new System.Drawing.Size(549, 21);
            this.DateNType.TabIndex = 1;
            this.DateNType.Text = "希望於 [日期] 舉辦 [賽事種類]";
            this.DateNType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromLeague
            // 
            this.FromLeague.BackColor = System.Drawing.Color.Transparent;
            this.FromLeague.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 22F);
            this.FromLeague.Location = new System.Drawing.Point(24, 10);
            this.FromLeague.Name = "FromLeague";
            this.FromLeague.Size = new System.Drawing.Size(542, 30);
            this.FromLeague.TabIndex = 0;
            this.FromLeague.Text = "來自 未知聯盟";
            this.FromLeague.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.Color.Transparent;
            this.Control.Controls.Add(this.Accept);
            this.Control.Controls.Add(this.ContactLO);
            this.Control.Controls.Add(this.Decline);
            this.Control.Location = new System.Drawing.Point(712, 63);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(330, 132);
            this.Control.TabIndex = 4;
            this.Control.TabStop = false;
            // 
            // Proposal_Tick
            // 
            this.Proposal_Tick.Interval = 1000;
            this.Proposal_Tick.Tick += new System.EventHandler(this.Proposal_Tick_Tick);
            // 
            // NotifyText
            // 
            this.NotifyText.BackColor = System.Drawing.Color.Transparent;
            this.NotifyText.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyText.Location = new System.Drawing.Point(71, 324);
            this.NotifyText.Name = "NotifyText";
            this.NotifyText.Size = new System.Drawing.Size(566, 44);
            this.NotifyText.TabIndex = 5;
            this.NotifyText.Text = "目前沒有新的賽事請求!";
            this.NotifyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameProposalSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.GPPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.NotifyText);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameProposalSubForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameProposalSubForm_Load);
            this.Request.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Decline;
        private System.Windows.Forms.Button ContactLO;
        private System.Windows.Forms.GroupBox Request;
        private System.Windows.Forms.Label DateNType;
        private System.Windows.Forms.Label FromLeague;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Label FormatNPeriod;
        private System.Windows.Forms.Timer Proposal_Tick;
        private System.Windows.Forms.Label NotifyText;
    }
}