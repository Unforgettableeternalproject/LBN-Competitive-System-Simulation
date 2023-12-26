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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.ExampleVideo = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.ChatTextbox = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.ChatMessage = new System.Windows.Forms.RichTextBox();
            this.StreamTime = new System.Windows.Forms.Label();
            this.ViewersCount = new System.Windows.Forms.Label();
            this.Stream = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerStream = new System.Windows.Forms.Timer(this.components);
            this.RedirectSpinner = new System.Windows.Forms.PictureBox();
            this.redirectTimer = new System.Windows.Forms.Timer(this.components);
            this.AdSpot1 = new System.Windows.Forms.PictureBox();
            this.AdSpot2 = new System.Windows.Forms.PictureBox();
            this.AdSpot3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Stream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot3)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WelcomeMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(1135, 126);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(162, 31);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // ExampleVideo
            // 
            this.ExampleVideo.BackColor = System.Drawing.SystemColors.Window;
            this.ExampleVideo.Location = new System.Drawing.Point(282, 156);
            this.ExampleVideo.Name = "ExampleVideo";
            this.ExampleVideo.Size = new System.Drawing.Size(457, 260);
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
            this.Contact.Location = new System.Drawing.Point(12, 839);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(71, 16);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "聯絡我們";
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // SwitchRole
            // 
            this.SwitchRole.AutoSize = true;
            this.SwitchRole.BackColor = System.Drawing.Color.Transparent;
            this.SwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F);
            this.SwitchRole.Location = new System.Drawing.Point(151, 799);
            this.SwitchRole.Name = "SwitchRole";
            this.SwitchRole.Size = new System.Drawing.Size(74, 12);
            this.SwitchRole.TabIndex = 3;
            this.SwitchRole.Text = "切換使用者...";
            this.SwitchRole.Click += new System.EventHandler(this.SwitchRole_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit.Location = new System.Drawing.Point(150, 839);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 16);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "離開系統";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btn_return
            // 
            this.btn_return.AutoSize = true;
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Return;
            this.btn_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_return.FlatAppearance.BorderSize = 0;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Location = new System.Drawing.Point(203, 19);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(47, 45);
            this.btn_return.TabIndex = 5;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ChatTextbox
            // 
            this.ChatTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatTextbox.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatTextbox.Location = new System.Drawing.Point(1169, 742);
            this.ChatTextbox.Name = "ChatTextbox";
            this.ChatTextbox.Size = new System.Drawing.Size(309, 35);
            this.ChatTextbox.TabIndex = 6;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_send.Location = new System.Drawing.Point(1458, 794);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(66, 41);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "送出";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // ChatMessage
            // 
            this.ChatMessage.Cursor = System.Windows.Forms.Cursors.No;
            this.ChatMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatMessage.Location = new System.Drawing.Point(1156, 174);
            this.ChatMessage.Name = "ChatMessage";
            this.ChatMessage.ReadOnly = true;
            this.ChatMessage.Size = new System.Drawing.Size(367, 520);
            this.ChatMessage.TabIndex = 8;
            this.ChatMessage.Text = "";
            // 
            // StreamTime
            // 
            this.StreamTime.AutoSize = true;
            this.StreamTime.BackColor = System.Drawing.Color.Transparent;
            this.StreamTime.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 20F);
            this.StreamTime.Location = new System.Drawing.Point(1020, 667);
            this.StreamTime.Name = "StreamTime";
            this.StreamTime.Size = new System.Drawing.Size(114, 27);
            this.StreamTime.TabIndex = 9;
            this.StreamTime.Text = "01:25:34";
            // 
            // ViewersCount
            // 
            this.ViewersCount.AutoSize = true;
            this.ViewersCount.BackColor = System.Drawing.Color.Transparent;
            this.ViewersCount.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 30F);
            this.ViewersCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ViewersCount.Location = new System.Drawing.Point(1007, 613);
            this.ViewersCount.Name = "ViewersCount";
            this.ViewersCount.Size = new System.Drawing.Size(87, 41);
            this.ViewersCount.TabIndex = 10;
            this.ViewersCount.Text = "238";
            // 
            // Stream
            // 
            this.Stream.Enabled = true;
            this.Stream.Location = new System.Drawing.Point(238, 85);
            this.Stream.Name = "Stream";
            this.Stream.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Stream.OcxState")));
            this.Stream.Size = new System.Drawing.Size(912, 516);
            this.Stream.TabIndex = 11;
            // 
            // timerStream
            // 
            this.timerStream.Interval = 1000;
            this.timerStream.Tick += new System.EventHandler(this.timerStream_Tick);
            // 
            // RedirectSpinner
            // 
            this.RedirectSpinner.BackColor = System.Drawing.Color.Transparent;
            this.RedirectSpinner.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Spinner;
            this.RedirectSpinner.Location = new System.Drawing.Point(664, 224);
            this.RedirectSpinner.Name = "RedirectSpinner";
            this.RedirectSpinner.Size = new System.Drawing.Size(512, 512);
            this.RedirectSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedirectSpinner.TabIndex = 12;
            this.RedirectSpinner.TabStop = false;
            // 
            // redirectTimer
            // 
            this.redirectTimer.Interval = 3000;
            this.redirectTimer.Tick += new System.EventHandler(this.redirectTimer_Tick);
            // 
            // AdSpot1
            // 
            this.AdSpot1.BackColor = System.Drawing.Color.Transparent;
            this.AdSpot1.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder1;
            this.AdSpot1.Location = new System.Drawing.Point(-1, 560);
            this.AdSpot1.Name = "AdSpot1";
            this.AdSpot1.Size = new System.Drawing.Size(239, 219);
            this.AdSpot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdSpot1.TabIndex = 13;
            this.AdSpot1.TabStop = false;
            // 
            // AdSpot2
            // 
            this.AdSpot2.BackColor = System.Drawing.Color.Transparent;
            this.AdSpot2.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder3;
            this.AdSpot2.Location = new System.Drawing.Point(1249, 433);
            this.AdSpot2.Name = "AdSpot2";
            this.AdSpot2.Size = new System.Drawing.Size(287, 431);
            this.AdSpot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdSpot2.TabIndex = 14;
            this.AdSpot2.TabStop = false;
            // 
            // AdSpot3
            // 
            this.AdSpot3.BackColor = System.Drawing.Color.Transparent;
            this.AdSpot3.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder2;
            this.AdSpot3.Location = new System.Drawing.Point(235, 775);
            this.AdSpot3.Name = "AdSpot3";
            this.AdSpot3.Size = new System.Drawing.Size(910, 91);
            this.AdSpot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdSpot3.TabIndex = 15;
            this.AdSpot3.TabStop = false;
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Stream;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.AdSpot3);
            this.Controls.Add(this.AdSpot2);
            this.Controls.Add(this.AdSpot1);
            this.Controls.Add(this.RedirectSpinner);
            this.Controls.Add(this.Stream);
            this.Controls.Add(this.ViewersCount);
            this.Controls.Add(this.StreamTime);
            this.Controls.Add(this.ChatMessage);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.ChatTextbox);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.ExampleVideo);
            this.Controls.Add(this.WelcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedirectSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdSpot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Button ExampleVideo;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label SwitchRole;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.TextBox ChatTextbox;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox ChatMessage;
        private System.Windows.Forms.Label StreamTime;
        private System.Windows.Forms.Label ViewersCount;
        private AxWMPLib.AxWindowsMediaPlayer Stream;
        private System.Windows.Forms.Timer timerStream;
        private System.Windows.Forms.PictureBox RedirectSpinner;
        private System.Windows.Forms.Timer redirectTimer;
        private System.Windows.Forms.PictureBox AdSpot1;
        private System.Windows.Forms.PictureBox AdSpot2;
        private System.Windows.Forms.PictureBox AdSpot3;
    }
}