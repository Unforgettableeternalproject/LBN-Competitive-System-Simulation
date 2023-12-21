namespace LBN_Competitive_System_Simulation
{
    partial class ContactForm
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.CaptchaImg = new System.Windows.Forms.PictureBox();
            this.CaptchaBox = new System.Windows.Forms.TextBox();
            this.Advertise = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Submit;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_submit.Location = new System.Drawing.Point(223, 708);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(129, 55);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.UseMnemonic = false;
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Title.Location = new System.Drawing.Point(83, 294);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(415, 48);
            this.Title.TabIndex = 12;
            this.Title.Text = "輸入訊息主旨...";
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Message.Location = new System.Drawing.Point(83, 371);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(415, 240);
            this.Message.TabIndex = 13;
            this.Message.Text = "輸入訊息內容...";
            // 
            // CaptchaImg
            // 
            this.CaptchaImg.BackColor = System.Drawing.Color.Transparent;
            this.CaptchaImg.Location = new System.Drawing.Point(92, 626);
            this.CaptchaImg.Name = "CaptchaImg";
            this.CaptchaImg.Size = new System.Drawing.Size(200, 54);
            this.CaptchaImg.TabIndex = 14;
            this.CaptchaImg.TabStop = false;
            // 
            // CaptchaBox
            // 
            this.CaptchaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CaptchaBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CaptchaBox.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 20F);
            this.CaptchaBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CaptchaBox.Location = new System.Drawing.Point(337, 647);
            this.CaptchaBox.Name = "CaptchaBox";
            this.CaptchaBox.Size = new System.Drawing.Size(161, 33);
            this.CaptchaBox.TabIndex = 15;
            this.CaptchaBox.Text = "輸入驗證碼...";
            this.CaptchaBox.TextChanged += new System.EventHandler(this.CaptchaBox_TextChanged);
            // 
            // Advertise
            // 
            this.Advertise.AutoSize = true;
            this.Advertise.BackColor = System.Drawing.Color.Transparent;
            this.Advertise.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F);
            this.Advertise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.Advertise.Location = new System.Drawing.Point(244, 779);
            this.Advertise.Name = "Advertise";
            this.Advertise.Size = new System.Drawing.Size(95, 12);
            this.Advertise.TabIndex = 16;
            this.Advertise.Text = "想要推銷廣告嗎?";
            this.Advertise.Click += new System.EventHandler(this.Advertise_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Exit;
            this.btn_exit.Location = new System.Drawing.Point(497, 21);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 74);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Contact;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(587, 800);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Advertise);
            this.Controls.Add(this.CaptchaBox);
            this.Controls.Add(this.CaptchaImg);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btn_submit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Page";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.PictureBox CaptchaImg;
        private System.Windows.Forms.TextBox CaptchaBox;
        private System.Windows.Forms.Label Advertise;
        private System.Windows.Forms.Button btn_exit;
    }
}