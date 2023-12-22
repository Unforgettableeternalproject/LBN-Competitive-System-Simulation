namespace LBN_Competitive_System_Simulation.Forms
{
    partial class AdvertisementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertisementForm));
            this.SubPages = new System.Windows.Forms.Panel();
            this.AdvertisementDeploy = new System.Windows.Forms.Button();
            this.Daskboard = new System.Windows.Forms.Button();
            this.PersonalInfo = new System.Windows.Forms.Button();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SubPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubPages
            // 
            this.SubPages.BackColor = System.Drawing.Color.Transparent;
            this.SubPages.Controls.Add(this.btn_enter);
            this.SubPages.Location = new System.Drawing.Point(238, 87);
            this.SubPages.Name = "SubPages";
            this.SubPages.Size = new System.Drawing.Size(1283, 741);
            this.SubPages.TabIndex = 0;
            // 
            // AdvertisementDeploy
            // 
            this.AdvertisementDeploy.BackColor = System.Drawing.Color.Transparent;
            this.AdvertisementDeploy.FlatAppearance.BorderSize = 0;
            this.AdvertisementDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvertisementDeploy.Location = new System.Drawing.Point(-1, 297);
            this.AdvertisementDeploy.Name = "AdvertisementDeploy";
            this.AdvertisementDeploy.Size = new System.Drawing.Size(239, 57);
            this.AdvertisementDeploy.TabIndex = 1;
            this.AdvertisementDeploy.UseVisualStyleBackColor = false;
            // 
            // Daskboard
            // 
            this.Daskboard.BackColor = System.Drawing.Color.Transparent;
            this.Daskboard.FlatAppearance.BorderSize = 0;
            this.Daskboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daskboard.Location = new System.Drawing.Point(-1, 360);
            this.Daskboard.Name = "Daskboard";
            this.Daskboard.Size = new System.Drawing.Size(239, 57);
            this.Daskboard.TabIndex = 2;
            this.Daskboard.UseVisualStyleBackColor = false;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.PersonalInfo.FlatAppearance.BorderSize = 0;
            this.PersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalInfo.Location = new System.Drawing.Point(-1, 423);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(239, 55);
            this.PersonalInfo.TabIndex = 3;
            this.PersonalInfo.UseVisualStyleBackColor = false;
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 110);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(123, 24);
            this.WelcomeMessage.TabIndex = 4;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // btn_enter
            // 
            this.btn_enter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_enter.BackColor = System.Drawing.Color.Transparent;
            this.btn_enter.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Enter;
            this.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.FlatAppearance.BorderSize = 0;
            this.btn_enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(545, 436);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(165, 67);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.UseMnemonic = false;
            this.btn_enter.UseVisualStyleBackColor = false;
            // 
            // AdvertisementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Advertise_Front;
            this.ClientSize = new System.Drawing.Size(1520, 825);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.PersonalInfo);
            this.Controls.Add(this.Daskboard);
            this.Controls.Add(this.AdvertisementDeploy);
            this.Controls.Add(this.SubPages);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvertisementForm";
            this.Text = "AdvertisementScreen";
            this.SubPages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SubPages;
        private System.Windows.Forms.Button AdvertisementDeploy;
        private System.Windows.Forms.Button Daskboard;
        private System.Windows.Forms.Button PersonalInfo;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button btn_enter;
    }
}