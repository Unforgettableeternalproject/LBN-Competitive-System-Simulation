namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class DataManagementSubForm
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
            this.Graph1 = new System.Windows.Forms.PictureBox();
            this.Graph2 = new System.Windows.Forms.PictureBox();
            this.Leagues = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Label();
            this.Games = new System.Windows.Forms.Label();
            this.Downtime = new System.Windows.Forms.Label();
            this.SystemVersion = new System.Windows.Forms.Label();
            this.FatalError = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph1
            // 
            this.Graph1.BackColor = System.Drawing.Color.Transparent;
            this.Graph1.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Graph_2;
            this.Graph1.Location = new System.Drawing.Point(87, 64);
            this.Graph1.Name = "Graph1";
            this.Graph1.Size = new System.Drawing.Size(333, 299);
            this.Graph1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Graph1.TabIndex = 0;
            this.Graph1.TabStop = false;
            // 
            // Graph2
            // 
            this.Graph2.BackColor = System.Drawing.Color.Transparent;
            this.Graph2.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Graph_1;
            this.Graph2.Location = new System.Drawing.Point(87, 416);
            this.Graph2.Name = "Graph2";
            this.Graph2.Size = new System.Drawing.Size(333, 299);
            this.Graph2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Graph2.TabIndex = 1;
            this.Graph2.TabStop = false;
            // 
            // Leagues
            // 
            this.Leagues.AutoSize = true;
            this.Leagues.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leagues.Location = new System.Drawing.Point(574, 153);
            this.Leagues.Name = "Leagues";
            this.Leagues.Size = new System.Drawing.Size(162, 25);
            this.Leagues.TabIndex = 2;
            this.Leagues.Text = "已註冊聯盟數:";
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(574, 219);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(162, 25);
            this.Users.TabIndex = 3;
            this.Users.Text = "已註冊用戶數:";
            // 
            // Games
            // 
            this.Games.AutoSize = true;
            this.Games.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games.Location = new System.Drawing.Point(574, 291);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(162, 25);
            this.Games.TabIndex = 4;
            this.Games.Text = "已排程競賽數:";
            // 
            // Downtime
            // 
            this.Downtime.AutoSize = true;
            this.Downtime.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downtime.Location = new System.Drawing.Point(574, 464);
            this.Downtime.Name = "Downtime";
            this.Downtime.Size = new System.Drawing.Size(303, 25);
            this.Downtime.TabIndex = 5;
            this.Downtime.Text = "上次停機時間: 2023/12/20";
            // 
            // SystemVersion
            // 
            this.SystemVersion.AutoSize = true;
            this.SystemVersion.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemVersion.Location = new System.Drawing.Point(574, 536);
            this.SystemVersion.Name = "SystemVersion";
            this.SystemVersion.Size = new System.Drawing.Size(222, 25);
            this.SystemVersion.TabIndex = 6;
            this.SystemVersion.Text = "系統版本: v_1.105.4";
            // 
            // FatalError
            // 
            this.FatalError.AutoSize = true;
            this.FatalError.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatalError.Location = new System.Drawing.Point(574, 611);
            this.FatalError.Name = "FatalError";
            this.FatalError.Size = new System.Drawing.Size(186, 25);
            this.FatalError.TabIndex = 7;
            this.FatalError.Text = "近期重大錯誤數:";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(983, 81);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 76);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // DataManagementSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.DMPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.FatalError);
            this.Controls.Add(this.SystemVersion);
            this.Controls.Add(this.Downtime);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Leagues);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.Graph1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataManagementSubForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataManagementSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Graph1;
        private System.Windows.Forms.PictureBox Graph2;
        private System.Windows.Forms.Label Leagues;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.Label Games;
        private System.Windows.Forms.Label Downtime;
        private System.Windows.Forms.Label SystemVersion;
        private System.Windows.Forms.Label FatalError;
        private System.Windows.Forms.Button btn_Refresh;
    }
}