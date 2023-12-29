namespace LBN_Competitive_System_Simulation.Forms
{
    partial class AdminMainForm
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
            this.Home = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SwitchRole = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(139, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 42);
            this.Home.TabIndex = 17;
            this.Home.UseVisualStyleBackColor = false;
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
            this.Contact.TabIndex = 18;
            this.Contact.Text = "聯絡我們";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(154, 839);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 16);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "離開系統";
            // 
            // SwitchRole
            // 
            this.SwitchRole.AutoSize = true;
            this.SwitchRole.BackColor = System.Drawing.Color.Transparent;
            this.SwitchRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F);
            this.SwitchRole.Location = new System.Drawing.Point(155, 803);
            this.SwitchRole.Name = "SwitchRole";
            this.SwitchRole.Size = new System.Drawing.Size(74, 12);
            this.SwitchRole.TabIndex = 20;
            this.SwitchRole.Text = "切換使用者...";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeMessage.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 113);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(121, 22);
            this.WelcomeMessage.TabIndex = 21;
            this.WelcomeMessage.Text = "歡迎回來, !";
            this.WelcomeMessage.UseMnemonic = false;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Admin_Base;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.SwitchRole);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label SwitchRole;
        private System.Windows.Forms.Label WelcomeMessage;
    }
}