namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class InfoSubform
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
            this.UserTag = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.Quota = new System.Windows.Forms.Label();
            this.Notify = new System.Windows.Forms.CheckBox();
            this.btn_acc_change = new System.Windows.Forms.Button();
            this.btn_quo_change = new System.Windows.Forms.Button();
            this.AccountChange = new System.Windows.Forms.TextBox();
            this.QuotaChange = new System.Windows.Forms.ComboBox();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UserTag
            // 
            this.UserTag.AutoSize = true;
            this.UserTag.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32F);
            this.UserTag.Location = new System.Drawing.Point(375, 130);
            this.UserTag.Name = "UserTag";
            this.UserTag.Size = new System.Drawing.Size(102, 43);
            this.UserTag.TabIndex = 0;
            this.UserTag.Text = "User";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(375, 286);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(460, 43);
            this.Account.TabIndex = 1;
            this.Account.Text = "0000 **** **** 1234";
            // 
            // Quota
            // 
            this.Quota.AutoSize = true;
            this.Quota.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quota.Location = new System.Drawing.Point(375, 445);
            this.Quota.Name = "Quota";
            this.Quota.Size = new System.Drawing.Size(253, 43);
            this.Quota.TabIndex = 2;
            this.Quota.Text = "每月入/出帳";
            // 
            // Notify
            // 
            this.Notify.AutoSize = true;
            this.Notify.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notify.Location = new System.Drawing.Point(485, 602);
            this.Notify.Name = "Notify";
            this.Notify.Size = new System.Drawing.Size(143, 47);
            this.Notify.TabIndex = 4;
            this.Notify.Text = "是/否";
            this.Notify.UseVisualStyleBackColor = true;
            this.Notify.CheckedChanged += new System.EventHandler(this.Notify_CheckedChanged);
            // 
            // btn_acc_change
            // 
            this.btn_acc_change.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_change.Location = new System.Drawing.Point(1005, 281);
            this.btn_acc_change.Name = "btn_acc_change";
            this.btn_acc_change.Size = new System.Drawing.Size(142, 57);
            this.btn_acc_change.TabIndex = 6;
            this.btn_acc_change.Text = "變更";
            this.btn_acc_change.UseVisualStyleBackColor = true;
            this.btn_acc_change.Click += new System.EventHandler(this.btn_acc_change_Click);
            // 
            // btn_quo_change
            // 
            this.btn_quo_change.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quo_change.Location = new System.Drawing.Point(1005, 431);
            this.btn_quo_change.Name = "btn_quo_change";
            this.btn_quo_change.Size = new System.Drawing.Size(142, 57);
            this.btn_quo_change.TabIndex = 7;
            this.btn_quo_change.Text = "變更";
            this.btn_quo_change.UseVisualStyleBackColor = true;
            this.btn_quo_change.Click += new System.EventHandler(this.btn_quo_change_Click);
            // 
            // AccountChange
            // 
            this.AccountChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountChange.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountChange.Location = new System.Drawing.Point(372, 279);
            this.AccountChange.Name = "AccountChange";
            this.AccountChange.Size = new System.Drawing.Size(467, 59);
            this.AccountChange.TabIndex = 8;
            // 
            // QuotaChange
            // 
            this.QuotaChange.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotaChange.FormattingEnabled = true;
            this.QuotaChange.Items.AddRange(new object[] {
            "每月入/出帳",
            "每雙月入/出帳",
            "每季入/出帳",
            "每年入/出帳",
            "自領"});
            this.QuotaChange.Location = new System.Drawing.Point(370, 442);
            this.QuotaChange.Name = "QuotaChange";
            this.QuotaChange.Size = new System.Drawing.Size(324, 51);
            this.QuotaChange.TabIndex = 9;
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // InfoSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Info;
            this.ClientSize = new System.Drawing.Size(1284, 740);
            this.Controls.Add(this.btn_quo_change);
            this.Controls.Add(this.btn_acc_change);
            this.Controls.Add(this.Notify);
            this.Controls.Add(this.Quota);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.UserTag);
            this.Controls.Add(this.AccountChange);
            this.Controls.Add(this.QuotaChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InfoSubform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserTag;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label Quota;
        private System.Windows.Forms.CheckBox Notify;
        private System.Windows.Forms.Button btn_acc_change;
        private System.Windows.Forms.Button btn_quo_change;
        private System.Windows.Forms.TextBox AccountChange;
        private System.Windows.Forms.ComboBox QuotaChange;
        private System.Windows.Forms.Timer Tick;
    }
}