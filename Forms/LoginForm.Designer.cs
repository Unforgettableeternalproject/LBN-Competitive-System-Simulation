namespace LBN_Competitive_System_Simulation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.Anonymous = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPW = new System.Windows.Forms.TextBox();
            this.ToggleInvis = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(115, 404);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(316, 31);
            this.txt_Password.TabIndex = 2;
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(115, 257);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(316, 31);
            this.txt_Username.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
            this.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_confirm.Location = new System.Drawing.Point(152, 538);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(180, 76);
            this.btn_confirm.TabIndex = 10;
            this.btn_confirm.UseMnemonic = false;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.Register.Location = new System.Drawing.Point(365, 548);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(66, 27);
            this.Register.TabIndex = 4;
            this.Register.Text = "註冊";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Anonymous
            // 
            this.Anonymous.AutoSize = true;
            this.Anonymous.BackColor = System.Drawing.Color.Transparent;
            this.Anonymous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Anonymous.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9.75F);
            this.Anonymous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.Anonymous.Location = new System.Drawing.Point(212, 613);
            this.Anonymous.Name = "Anonymous";
            this.Anonymous.Size = new System.Drawing.Size(59, 13);
            this.Anonymous.TabIndex = 5;
            this.Anonymous.Text = "跳過登入";
            this.Anonymous.Click += new System.EventHandler(this.Anonymous_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(115, 330);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(316, 31);
            this.txt_Email.TabIndex = 1;
            // 
            // txt_ConfirmPW
            // 
            this.txt_ConfirmPW.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPW.Location = new System.Drawing.Point(115, 478);
            this.txt_ConfirmPW.Name = "txt_ConfirmPW";
            this.txt_ConfirmPW.Size = new System.Drawing.Size(316, 31);
            this.txt_ConfirmPW.TabIndex = 3;
            // 
            // ToggleInvis
            // 
            this.ToggleInvis.AutoSize = true;
            this.ToggleInvis.BackColor = System.Drawing.Color.Transparent;
            this.ToggleInvis.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.PasswordInvisible;
            this.ToggleInvis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleInvis.FlatAppearance.BorderSize = 0;
            this.ToggleInvis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleInvis.Location = new System.Drawing.Point(396, 446);
            this.ToggleInvis.Name = "ToggleInvis";
            this.ToggleInvis.Size = new System.Drawing.Size(26, 26);
            this.ToggleInvis.TabIndex = 11;
            this.ToggleInvis.UseVisualStyleBackColor = false;
            this.ToggleInvis.Click += new System.EventHandler(this.ToggleInvis_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.LoginForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 707);
            this.Controls.Add(this.ToggleInvis);
            this.Controls.Add(this.txt_ConfirmPW);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.Anonymous);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_confirm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label Anonymous;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_ConfirmPW;
        private System.Windows.Forms.Button ToggleInvis;
        private System.Windows.Forms.ToolTip toolTip;
    }
}