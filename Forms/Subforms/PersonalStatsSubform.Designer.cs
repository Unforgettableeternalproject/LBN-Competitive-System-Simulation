namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class PersonalStatsSubform
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
            this.Nickname = new System.Windows.Forms.Label();
            this.AvatarIMG = new System.Windows.Forms.PictureBox();
            this.AvatarLBL = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SignatureLBL = new System.Windows.Forms.Label();
            this.ExtendDescription = new System.Windows.Forms.ToolTip(this.components);
            this.AffiliatedLeague = new System.Windows.Forms.Label();
            this.Ratings = new System.Windows.Forms.Label();
            this.LeagueRole = new System.Windows.Forms.Label();
            this.Participated = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.Identifier = new System.Windows.Forms.Label();
            this.SignatureTXT = new System.Windows.Forms.RichTextBox();
            this.Modify = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.PictureBox();
            this.PastGames = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.GroupBox();
            this.NoRecord = new System.Windows.Forms.Label();
            this.Etc = new System.Windows.Forms.Label();
            this.Game_6 = new System.Windows.Forms.Label();
            this.Game_5 = new System.Windows.Forms.Label();
            this.Game_4 = new System.Windows.Forms.Label();
            this.Game_3 = new System.Windows.Forms.Label();
            this.Game_2 = new System.Windows.Forms.Label();
            this.Game_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.History.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nickname.Location = new System.Drawing.Point(111, 75);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(99, 21);
            this.Nickname.TabIndex = 0;
            this.Nickname.Text = "玩家暱稱:";
            // 
            // AvatarIMG
            // 
            this.AvatarIMG.BackColor = System.Drawing.Color.Transparent;
            this.AvatarIMG.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Placeholder4;
            this.AvatarIMG.Location = new System.Drawing.Point(465, 87);
            this.AvatarIMG.Name = "AvatarIMG";
            this.AvatarIMG.Size = new System.Drawing.Size(128, 128);
            this.AvatarIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarIMG.TabIndex = 1;
            this.AvatarIMG.TabStop = false;
            // 
            // AvatarLBL
            // 
            this.AvatarLBL.AutoSize = true;
            this.AvatarLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 11F);
            this.AvatarLBL.Location = new System.Drawing.Point(492, 51);
            this.AvatarLBL.Name = "AvatarLBL";
            this.AvatarLBL.Size = new System.Drawing.Size(67, 15);
            this.AvatarLBL.TabIndex = 2;
            this.AvatarLBL.Text = "玩家頭像";
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(457, 228);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(61, 32);
            this.Upload.TabIndex = 3;
            this.Upload.Text = "上傳";
            this.ExtendDescription.SetToolTip(this.Upload, "建議上傳大小為128x128的圖片");
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(538, 228);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(62, 32);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "移除";
            this.ExtendDescription.SetToolTip(this.Remove, "移除當前的頭像");
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SignatureLBL
            // 
            this.SignatureLBL.AutoSize = true;
            this.SignatureLBL.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureLBL.Location = new System.Drawing.Point(111, 155);
            this.SignatureLBL.Name = "SignatureLBL";
            this.SignatureLBL.Size = new System.Drawing.Size(99, 21);
            this.SignatureLBL.TabIndex = 5;
            this.SignatureLBL.Text = "個性簽名:";
            // 
            // AffiliatedLeague
            // 
            this.AffiliatedLeague.AutoEllipsis = true;
            this.AffiliatedLeague.AutoSize = true;
            this.AffiliatedLeague.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AffiliatedLeague.Location = new System.Drawing.Point(737, 75);
            this.AffiliatedLeague.Name = "AffiliatedLeague";
            this.AffiliatedLeague.Size = new System.Drawing.Size(99, 21);
            this.AffiliatedLeague.TabIndex = 7;
            this.AffiliatedLeague.Text = "所屬聯盟:";
            // 
            // Ratings
            // 
            this.Ratings.AutoEllipsis = true;
            this.Ratings.AutoSize = true;
            this.Ratings.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratings.Location = new System.Drawing.Point(737, 235);
            this.Ratings.Name = "Ratings";
            this.Ratings.Size = new System.Drawing.Size(99, 21);
            this.Ratings.TabIndex = 8;
            this.Ratings.Text = "評分排名:";
            // 
            // LeagueRole
            // 
            this.LeagueRole.AutoEllipsis = true;
            this.LeagueRole.AutoSize = true;
            this.LeagueRole.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueRole.Location = new System.Drawing.Point(737, 155);
            this.LeagueRole.Name = "LeagueRole";
            this.LeagueRole.Size = new System.Drawing.Size(99, 21);
            this.LeagueRole.TabIndex = 9;
            this.LeagueRole.Text = "成員身分:";
            // 
            // Participated
            // 
            this.Participated.AutoEllipsis = true;
            this.Participated.AutoSize = true;
            this.Participated.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Participated.Location = new System.Drawing.Point(737, 366);
            this.Participated.Name = "Participated";
            this.Participated.Size = new System.Drawing.Size(162, 21);
            this.Participated.TabIndex = 10;
            this.Participated.Text = "歷史參與賽事數:";
            // 
            // Warning
            // 
            this.Warning.AutoEllipsis = true;
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.Location = new System.Drawing.Point(737, 450);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(162, 21);
            this.Warning.TabIndex = 11;
            this.Warning.Text = "收到過的警告數:";
            // 
            // Identifier
            // 
            this.Identifier.AutoSize = true;
            this.Identifier.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Identifier.Location = new System.Drawing.Point(115, 108);
            this.Identifier.Name = "Identifier";
            this.Identifier.Size = new System.Drawing.Size(44, 12);
            this.Identifier.TabIndex = 12;
            this.Identifier.Text = "識別碼:";
            // 
            // SignatureTXT
            // 
            this.SignatureTXT.Enabled = false;
            this.SignatureTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SignatureTXT.Location = new System.Drawing.Point(115, 190);
            this.SignatureTXT.Name = "SignatureTXT";
            this.SignatureTXT.Size = new System.Drawing.Size(272, 84);
            this.SignatureTXT.TabIndex = 13;
            this.SignatureTXT.Text = "加入你的個性簽名吧!";
            // 
            // Modify
            // 
            this.Modify.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify.Location = new System.Drawing.Point(216, 151);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(61, 32);
            this.Modify.TabIndex = 14;
            this.Modify.Text = "修改";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            this.Graph.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Graph_2;
            this.Graph.Location = new System.Drawing.Point(752, 496);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(236, 231);
            this.Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Graph.TabIndex = 15;
            this.Graph.TabStop = false;
            // 
            // PastGames
            // 
            this.PastGames.AutoEllipsis = true;
            this.PastGames.AutoSize = true;
            this.PastGames.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastGames.Location = new System.Drawing.Point(115, 366);
            this.PastGames.Name = "PastGames";
            this.PastGames.Size = new System.Drawing.Size(120, 21);
            this.PastGames.TabIndex = 16;
            this.PastGames.Text = "過往的賽局:";
            // 
            // Export
            // 
            this.Export.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(258, 362);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(107, 32);
            this.Export.TabIndex = 17;
            this.Export.Text = "匯出為表格..";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.Transparent;
            this.History.Controls.Add(this.NoRecord);
            this.History.Controls.Add(this.Etc);
            this.History.Controls.Add(this.Game_6);
            this.History.Controls.Add(this.Game_5);
            this.History.Controls.Add(this.Game_4);
            this.History.Controls.Add(this.Game_3);
            this.History.Controls.Add(this.Game_2);
            this.History.Controls.Add(this.Game_1);
            this.History.Location = new System.Drawing.Point(119, 417);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(480, 299);
            this.History.TabIndex = 18;
            this.History.TabStop = false;
            // 
            // NoRecord
            // 
            this.NoRecord.AutoSize = true;
            this.NoRecord.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRecord.Location = new System.Drawing.Point(151, 119);
            this.NoRecord.Name = "NoRecord";
            this.NoRecord.Size = new System.Drawing.Size(163, 25);
            this.NoRecord.TabIndex = 8;
            this.NoRecord.Text = "沒有賽局紀錄!";
            // 
            // Etc
            // 
            this.Etc.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etc.Location = new System.Drawing.Point(13, 258);
            this.Etc.Name = "Etc";
            this.Etc.Size = new System.Drawing.Size(468, 19);
            this.Etc.TabIndex = 7;
            this.Etc.Text = "以及其他 {} 場賽事...";
            this.Etc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game_6
            // 
            this.Game_6.AutoSize = true;
            this.Game_6.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_6.Location = new System.Drawing.Point(9, 220);
            this.Game_6.Name = "Game_6";
            this.Game_6.Size = new System.Drawing.Size(75, 19);
            this.Game_6.TabIndex = 5;
            this.Game_6.Text = "Game_6";
            // 
            // Game_5
            // 
            this.Game_5.AutoSize = true;
            this.Game_5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_5.Location = new System.Drawing.Point(9, 180);
            this.Game_5.Name = "Game_5";
            this.Game_5.Size = new System.Drawing.Size(75, 19);
            this.Game_5.TabIndex = 4;
            this.Game_5.Text = "Game_5";
            // 
            // Game_4
            // 
            this.Game_4.AutoSize = true;
            this.Game_4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_4.Location = new System.Drawing.Point(9, 140);
            this.Game_4.Name = "Game_4";
            this.Game_4.Size = new System.Drawing.Size(75, 19);
            this.Game_4.TabIndex = 3;
            this.Game_4.Text = "Game_4";
            // 
            // Game_3
            // 
            this.Game_3.AutoSize = true;
            this.Game_3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_3.Location = new System.Drawing.Point(9, 100);
            this.Game_3.Name = "Game_3";
            this.Game_3.Size = new System.Drawing.Size(75, 19);
            this.Game_3.TabIndex = 2;
            this.Game_3.Text = "Game_3";
            // 
            // Game_2
            // 
            this.Game_2.AutoSize = true;
            this.Game_2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_2.Location = new System.Drawing.Point(9, 60);
            this.Game_2.Name = "Game_2";
            this.Game_2.Size = new System.Drawing.Size(75, 19);
            this.Game_2.TabIndex = 1;
            this.Game_2.Text = "Game_2";
            // 
            // Game_1
            // 
            this.Game_1.AutoSize = true;
            this.Game_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_1.Location = new System.Drawing.Point(9, 20);
            this.Game_1.Name = "Game_1";
            this.Game_1.Size = new System.Drawing.Size(71, 19);
            this.Game_1.TabIndex = 0;
            this.Game_1.Text = "Game_1";
            // 
            // PersonalStatsSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.PSPage;
            this.ClientSize = new System.Drawing.Size(1115, 777);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.PastGames);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.SignatureTXT);
            this.Controls.Add(this.Identifier);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Participated);
            this.Controls.Add(this.LeagueRole);
            this.Controls.Add(this.Ratings);
            this.Controls.Add(this.AffiliatedLeague);
            this.Controls.Add(this.SignatureLBL);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.AvatarLBL);
            this.Controls.Add(this.AvatarIMG);
            this.Controls.Add(this.Nickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalStatsSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonalStatsSubform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.PictureBox AvatarIMG;
        private System.Windows.Forms.Label AvatarLBL;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label SignatureLBL;
        private System.Windows.Forms.ToolTip ExtendDescription;
        private System.Windows.Forms.Label AffiliatedLeague;
        private System.Windows.Forms.Label Ratings;
        private System.Windows.Forms.Label LeagueRole;
        private System.Windows.Forms.Label Participated;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label Identifier;
        private System.Windows.Forms.RichTextBox SignatureTXT;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.PictureBox Graph;
        private System.Windows.Forms.Label PastGames;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.GroupBox History;
        private System.Windows.Forms.Label Etc;
        private System.Windows.Forms.Label Game_6;
        private System.Windows.Forms.Label Game_5;
        private System.Windows.Forms.Label Game_4;
        private System.Windows.Forms.Label Game_3;
        private System.Windows.Forms.Label Game_2;
        private System.Windows.Forms.Label Game_1;
        private System.Windows.Forms.Label NoRecord;
    }
}