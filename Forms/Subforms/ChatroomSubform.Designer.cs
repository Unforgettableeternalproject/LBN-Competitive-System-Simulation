namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class ChatroomSubform
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
            this.Chat = new System.Windows.Forms.RichTextBox();
            this.MsgBox = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Contacts = new System.Windows.Forms.GroupBox();
            this.Etc = new System.Windows.Forms.Label();
            this.Contact6 = new System.Windows.Forms.Button();
            this.Contact5 = new System.Windows.Forms.Button();
            this.Contact4 = new System.Windows.Forms.Button();
            this.Contact3 = new System.Windows.Forms.Button();
            this.Contact2 = new System.Windows.Forms.Button();
            this.Contact1 = new System.Windows.Forms.Button();
            this.HideChat = new System.Windows.Forms.Button();
            this.ReplyTick = new System.Windows.Forms.Timer(this.components);
            this.Contacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chat
            // 
            this.Chat.Enabled = false;
            this.Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Chat.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Chat.Location = new System.Drawing.Point(124, 54);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(311, 300);
            this.Chat.TabIndex = 0;
            this.Chat.Text = "\t   ☞歡迎來到聊天室的開端☜\n\n: 你好\n: 我不好";
            // 
            // MsgBox
            // 
            this.MsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MsgBox.Location = new System.Drawing.Point(124, 353);
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(311, 39);
            this.MsgBox.TabIndex = 1;
            this.MsgBox.Text = "輸入訊息吧!";
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(373, 395);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(54, 33);
            this.Send.TabIndex = 2;
            this.Send.Text = "送出";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Contacts
            // 
            this.Contacts.Controls.Add(this.Contact1);
            this.Contacts.Controls.Add(this.Contact2);
            this.Contacts.Controls.Add(this.Contact3);
            this.Contacts.Controls.Add(this.Contact5);
            this.Contacts.Controls.Add(this.Contact6);
            this.Contacts.Controls.Add(this.Contact4);
            this.Contacts.Controls.Add(this.Etc);
            this.Contacts.Location = new System.Drawing.Point(1, 55);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(123, 379);
            this.Contacts.TabIndex = 3;
            this.Contacts.TabStop = false;
            // 
            // Etc
            // 
            this.Etc.AutoSize = true;
            this.Etc.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etc.Location = new System.Drawing.Point(14, 275);
            this.Etc.Name = "Etc";
            this.Etc.Size = new System.Drawing.Size(92, 12);
            this.Etc.TabIndex = 6;
            this.Etc.Text = "還有 個聯絡人...";
            // 
            // Contact6
            // 
            this.Contact6.AutoEllipsis = true;
            this.Contact6.Location = new System.Drawing.Point(0, 213);
            this.Contact6.Name = "Contact6";
            this.Contact6.Size = new System.Drawing.Size(123, 35);
            this.Contact6.TabIndex = 5;
            this.Contact6.Text = "聯絡人六號";
            this.Contact6.UseVisualStyleBackColor = true;
            this.Contact6.Click += new System.EventHandler(this.Contact6_Click);
            // 
            // Contact5
            // 
            this.Contact5.AutoEllipsis = true;
            this.Contact5.Location = new System.Drawing.Point(0, 172);
            this.Contact5.Name = "Contact5";
            this.Contact5.Size = new System.Drawing.Size(123, 35);
            this.Contact5.TabIndex = 4;
            this.Contact5.Text = "聯絡人五號";
            this.Contact5.UseVisualStyleBackColor = true;
            this.Contact5.Click += new System.EventHandler(this.Contact5_Click);
            // 
            // Contact4
            // 
            this.Contact4.AutoEllipsis = true;
            this.Contact4.Location = new System.Drawing.Point(0, 131);
            this.Contact4.Name = "Contact4";
            this.Contact4.Size = new System.Drawing.Size(123, 35);
            this.Contact4.TabIndex = 3;
            this.Contact4.Text = "聯絡人四號";
            this.Contact4.UseVisualStyleBackColor = true;
            this.Contact4.Click += new System.EventHandler(this.Contact4_Click);
            // 
            // Contact3
            // 
            this.Contact3.AutoEllipsis = true;
            this.Contact3.Location = new System.Drawing.Point(0, 90);
            this.Contact3.Name = "Contact3";
            this.Contact3.Size = new System.Drawing.Size(123, 35);
            this.Contact3.TabIndex = 2;
            this.Contact3.Text = "聯絡人三號";
            this.Contact3.UseVisualStyleBackColor = true;
            this.Contact3.Click += new System.EventHandler(this.Contact3_Click);
            // 
            // Contact2
            // 
            this.Contact2.AutoEllipsis = true;
            this.Contact2.Location = new System.Drawing.Point(0, 49);
            this.Contact2.Name = "Contact2";
            this.Contact2.Size = new System.Drawing.Size(123, 35);
            this.Contact2.TabIndex = 1;
            this.Contact2.Text = "聯絡人二號";
            this.Contact2.UseVisualStyleBackColor = true;
            this.Contact2.Click += new System.EventHandler(this.Contact2_Click);
            // 
            // Contact1
            // 
            this.Contact1.AutoEllipsis = true;
            this.Contact1.Location = new System.Drawing.Point(0, 8);
            this.Contact1.Name = "Contact1";
            this.Contact1.Size = new System.Drawing.Size(123, 35);
            this.Contact1.TabIndex = 0;
            this.Contact1.Text = "聯絡人一號";
            this.Contact1.UseVisualStyleBackColor = true;
            this.Contact1.Click += new System.EventHandler(this.Contact1_Click);
            // 
            // HideChat
            // 
            this.HideChat.BackColor = System.Drawing.Color.Transparent;
            this.HideChat.FlatAppearance.BorderSize = 0;
            this.HideChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.HideChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HideChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideChat.Location = new System.Drawing.Point(1, 0);
            this.HideChat.Name = "HideChat";
            this.HideChat.Size = new System.Drawing.Size(30, 25);
            this.HideChat.TabIndex = 4;
            this.HideChat.UseVisualStyleBackColor = false;
            this.HideChat.Click += new System.EventHandler(this.Hide_Click);
            // 
            // ReplyTick
            // 
            this.ReplyTick.Interval = 500;
            this.ReplyTick.Tick += new System.EventHandler(this.ReplyTick_Tick);
            // 
            // ChatroomSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Chatroom;
            this.ClientSize = new System.Drawing.Size(434, 434);
            this.Controls.Add(this.HideChat);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.Chat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatroomSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChatroomSubform_Load);
            this.Contacts.ResumeLayout(false);
            this.Contacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Chat;
        private System.Windows.Forms.RichTextBox MsgBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.GroupBox Contacts;
        private System.Windows.Forms.Label Etc;
        private System.Windows.Forms.Button Contact6;
        private System.Windows.Forms.Button Contact5;
        private System.Windows.Forms.Button Contact4;
        private System.Windows.Forms.Button Contact3;
        private System.Windows.Forms.Button Contact2;
        private System.Windows.Forms.Button Contact1;
        private System.Windows.Forms.Button HideChat;
        private System.Windows.Forms.Timer ReplyTick;
    }
}