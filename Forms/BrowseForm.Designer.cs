namespace LBN_Competitive_System_Simulation
{
    partial class BrowseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.ExampleVideo = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.MoreInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(2481, 256);
            this.WelcomeMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(318, 58);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            this.WelcomeMessage.Click += new System.EventHandler(this.WelcomeMessage_Click);
            // 
            // ExampleVideo
            // 
            this.ExampleVideo.BackColor = System.Drawing.SystemColors.Window;
            this.ExampleVideo.Location = new System.Drawing.Point(611, 312);
            this.ExampleVideo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ExampleVideo.Name = "ExampleVideo";
            this.ExampleVideo.Size = new System.Drawing.Size(990, 520);
            this.ExampleVideo.TabIndex = 1;
            this.ExampleVideo.UseVisualStyleBackColor = false;
            this.ExampleVideo.Click += new System.EventHandler(this.ExampleVideo_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.BackColor = System.Drawing.Color.Transparent;
            this.Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contact.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(26, 1678);
            this.Contact.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(142, 32);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "聯絡我們";
            // 
            // SwitchRole
            // 
            this.SwitchRole.AutoSize = true;
            this.SwitchRole.BackColor = System.Drawing.Color.Transparent;
            this.SwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F);
            this.SwitchRole.Location = new System.Drawing.Point(327, 1598);
            this.SwitchRole.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SwitchRole.Name = "SwitchRole";
            this.SwitchRole.Size = new System.Drawing.Size(150, 25);
            this.SwitchRole.TabIndex = 3;
            this.SwitchRole.Text = "切換使用者...";
            // 
            // MoreInfo
            // 
            this.MoreInfo.AutoSize = true;
            this.MoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.MoreInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreInfo.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreInfo.Location = new System.Drawing.Point(325, 1678);
            this.MoreInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.Size = new System.Drawing.Size(142, 32);
            this.MoreInfo.TabIndex = 4;
            this.MoreInfo.Text = "更多資訊";
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Stream;
            this.ClientSize = new System.Drawing.Size(3030, 1728);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.ExampleVideo);
            this.Controls.Add(this.WelcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button ExampleVideo;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label SwitchRole;
        private System.Windows.Forms.Label MoreInfo;
    }
}