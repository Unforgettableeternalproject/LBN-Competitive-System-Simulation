namespace LBN_Competitive_System_Simulation.Forms
{
    partial class DeploymentSubform
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
            this.AdPreview = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.ChooseLocation = new System.Windows.Forms.ComboBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Cost = new System.Windows.Forms.Label();
            this.Warning_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.btn_deploy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTag
            // 
            this.UserTag.AutoSize = true;
            this.UserTag.BackColor = System.Drawing.Color.Transparent;
            this.UserTag.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.UserTag.Location = new System.Drawing.Point(244, 116);
            this.UserTag.Name = "UserTag";
            this.UserTag.Size = new System.Drawing.Size(84, 25);
            this.UserTag.TabIndex = 0;
            this.UserTag.Text = "用戶名";
            // 
            // AdPreview
            // 
            this.AdPreview.BackColor = System.Drawing.Color.Transparent;
            this.AdPreview.Location = new System.Drawing.Point(820, 299);
            this.AdPreview.Name = "AdPreview";
            this.AdPreview.Size = new System.Drawing.Size(374, 381);
            this.AdPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdPreview.TabIndex = 1;
            this.AdPreview.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.Upload.Location = new System.Drawing.Point(422, 329);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(96, 37);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "上傳";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // ChooseLocation
            // 
            this.ChooseLocation.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.ChooseLocation.FormattingEnabled = true;
            this.ChooseLocation.Items.AddRange(new object[] {
            "主要瀏覽頁面中右側",
            "實況頁面下方",
            "左側工作欄下方"});
            this.ChooseLocation.Location = new System.Drawing.Point(354, 393);
            this.ChooseLocation.Name = "ChooseLocation";
            this.ChooseLocation.Size = new System.Drawing.Size(161, 24);
            this.ChooseLocation.TabIndex = 3;
            this.ChooseLocation.SelectedIndexChanged += new System.EventHandler(this.ChooseLocation_SelectedIndexChanged);
            // 
            // StartDate
            // 
            this.StartDate.CalendarFont = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.StartDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.StartDate.Location = new System.Drawing.Point(322, 454);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(151, 27);
            this.StartDate.TabIndex = 4;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "至";
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(521, 454);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(147, 27);
            this.EndDate.TabIndex = 6;
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(425, 567);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(93, 29);
            this.Cost.TabIndex = 7;
            this.Cost.Text = "000元";
            // 
            // Warning_1
            // 
            this.Warning_1.AutoSize = true;
            this.Warning_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning_1.ForeColor = System.Drawing.Color.Firebrick;
            this.Warning_1.Location = new System.Drawing.Point(533, 396);
            this.Warning_1.Name = "Warning_1";
            this.Warning_1.Size = new System.Drawing.Size(145, 16);
            this.Warning_1.TabIndex = 8;
            this.Warning_1.Text = "必須選擇一個位置!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.label3.Location = new System.Drawing.Point(129, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "目前計畫方案: 普通會員";
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // btn_deploy
            // 
            this.btn_deploy.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.btn_deploy.Location = new System.Drawing.Point(322, 630);
            this.btn_deploy.Name = "btn_deploy";
            this.btn_deploy.Size = new System.Drawing.Size(118, 37);
            this.btn_deploy.TabIndex = 10;
            this.btn_deploy.Text = "確認刊登";
            this.btn_deploy.UseVisualStyleBackColor = true;
            this.btn_deploy.Click += new System.EventHandler(this.btn_deploy_Click);
            // 
            // DeploymentSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Deployment;
            this.ClientSize = new System.Drawing.Size(1284, 740);
            this.Controls.Add(this.btn_deploy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Warning_1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.ChooseLocation);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.AdPreview);
            this.Controls.Add(this.UserTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeploymentSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DeploymentSubform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserTag;
        private System.Windows.Forms.PictureBox AdPreview;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.ComboBox ChooseLocation;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Warning_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Button btn_deploy;
    }
}