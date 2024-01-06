namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class RatingManagementSubform
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
            this.LeagueLeaderBoard = new System.Windows.Forms.Label();
            this.LeaderBoard_L = new System.Windows.Forms.GroupBox();
            this.L_5 = new System.Windows.Forms.Label();
            this.L_4 = new System.Windows.Forms.Label();
            this.L_3 = new System.Windows.Forms.Label();
            this.L_2 = new System.Windows.Forms.Label();
            this.L_1 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.Label();
            this.MostActivePlayer = new System.Windows.Forms.Label();
            this.GamesHosted = new System.Windows.Forms.Label();
            this.LeagueRatings = new System.Windows.Forms.Label();
            this.LeagueGoals = new System.Windows.Forms.Label();
            this.GoalLists = new System.Windows.Forms.CheckedListBox();
            this.HistoryGames = new System.Windows.Forms.Label();
            this.QuickAction = new System.Windows.Forms.Label();
            this.PlayerLeaderboard = new System.Windows.Forms.Label();
            this.LeaderBoard_P = new System.Windows.Forms.GroupBox();
            this.P_5 = new System.Windows.Forms.Label();
            this.P_4 = new System.Windows.Forms.Label();
            this.P_3 = new System.Windows.Forms.Label();
            this.P_2 = new System.Windows.Forms.Label();
            this.P_1 = new System.Windows.Forms.Label();
            this.AnnounceWinner = new System.Windows.Forms.Button();
            this.EndedGames = new System.Windows.Forms.GroupBox();
            this.Empty_EG = new System.Windows.Forms.Label();
            this.ScheduledGames = new System.Windows.Forms.GroupBox();
            this.Etc = new System.Windows.Forms.Label();
            this.Game3 = new System.Windows.Forms.Label();
            this.Game2 = new System.Windows.Forms.Label();
            this.Game1 = new System.Windows.Forms.Label();
            this.Empty_SG = new System.Windows.Forms.Label();
            this.ResetLeaderboard = new System.Windows.Forms.Button();
            this.Reexamine = new System.Windows.Forms.Button();
            this.Highlights = new System.Windows.Forms.Button();
            this.ExtendDescriptions = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshBTN = new System.Windows.Forms.Button();
            this.LeaderBoard_L.SuspendLayout();
            this.LeaderBoard_P.SuspendLayout();
            this.EndedGames.SuspendLayout();
            this.ScheduledGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeagueLeaderBoard
            // 
            this.LeagueLeaderBoard.AutoSize = true;
            this.LeagueLeaderBoard.BackColor = System.Drawing.Color.Transparent;
            this.LeagueLeaderBoard.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueLeaderBoard.Location = new System.Drawing.Point(989, 19);
            this.LeagueLeaderBoard.Name = "LeagueLeaderBoard";
            this.LeagueLeaderBoard.Size = new System.Drawing.Size(229, 21);
            this.LeagueLeaderBoard.TabIndex = 0;
            this.LeagueLeaderBoard.Text = "整體聯盟排行榜: (本月)";
            // 
            // LeaderBoard_L
            // 
            this.LeaderBoard_L.BackColor = System.Drawing.Color.Transparent;
            this.LeaderBoard_L.Controls.Add(this.L_5);
            this.LeaderBoard_L.Controls.Add(this.L_4);
            this.LeaderBoard_L.Controls.Add(this.L_3);
            this.LeaderBoard_L.Controls.Add(this.L_2);
            this.LeaderBoard_L.Controls.Add(this.L_1);
            this.LeaderBoard_L.Location = new System.Drawing.Point(984, 43);
            this.LeaderBoard_L.Name = "LeaderBoard_L";
            this.LeaderBoard_L.Size = new System.Drawing.Size(300, 260);
            this.LeaderBoard_L.TabIndex = 1;
            this.LeaderBoard_L.TabStop = false;
            // 
            // L_5
            // 
            this.L_5.AutoSize = true;
            this.L_5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L_5.Location = new System.Drawing.Point(20, 223);
            this.L_5.Name = "L_5";
            this.L_5.Size = new System.Drawing.Size(85, 19);
            this.L_5.TabIndex = 4;
            this.L_5.Text = "♜第五名:";
            // 
            // L_4
            // 
            this.L_4.AutoSize = true;
            this.L_4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_4.ForeColor = System.Drawing.Color.Gray;
            this.L_4.Location = new System.Drawing.Point(20, 173);
            this.L_4.Name = "L_4";
            this.L_4.Size = new System.Drawing.Size(85, 19);
            this.L_4.TabIndex = 3;
            this.L_4.Text = "♞第四名:";
            // 
            // L_3
            // 
            this.L_3.AutoSize = true;
            this.L_3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_3.ForeColor = System.Drawing.Color.Chocolate;
            this.L_3.Location = new System.Drawing.Point(20, 123);
            this.L_3.Name = "L_3";
            this.L_3.Size = new System.Drawing.Size(85, 19);
            this.L_3.TabIndex = 2;
            this.L_3.Text = "♝第三名:";
            // 
            // L_2
            // 
            this.L_2.AutoSize = true;
            this.L_2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_2.ForeColor = System.Drawing.Color.Silver;
            this.L_2.Location = new System.Drawing.Point(20, 73);
            this.L_2.Name = "L_2";
            this.L_2.Size = new System.Drawing.Size(85, 19);
            this.L_2.TabIndex = 1;
            this.L_2.Text = "♛第二名:";
            // 
            // L_1
            // 
            this.L_1.AutoSize = true;
            this.L_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_1.ForeColor = System.Drawing.Color.Orange;
            this.L_1.Location = new System.Drawing.Point(20, 23);
            this.L_1.Name = "L_1";
            this.L_1.Size = new System.Drawing.Size(85, 19);
            this.L_1.TabIndex = 0;
            this.L_1.Text = "♚第一名:";
            // 
            // Statistics
            // 
            this.Statistics.AutoSize = true;
            this.Statistics.BackColor = System.Drawing.Color.Transparent;
            this.Statistics.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.Location = new System.Drawing.Point(837, 344);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(157, 21);
            this.Statistics.TabIndex = 2;
            this.Statistics.Text = "聯盟內狀況統計";
            // 
            // MostActivePlayer
            // 
            this.MostActivePlayer.AutoSize = true;
            this.MostActivePlayer.BackColor = System.Drawing.Color.Transparent;
            this.MostActivePlayer.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostActivePlayer.Location = new System.Drawing.Point(874, 403);
            this.MostActivePlayer.Name = "MostActivePlayer";
            this.MostActivePlayer.Size = new System.Drawing.Size(145, 21);
            this.MostActivePlayer.TabIndex = 3;
            this.MostActivePlayer.Text = "最活躍玩家: {}";
            // 
            // GamesHosted
            // 
            this.GamesHosted.AutoSize = true;
            this.GamesHosted.BackColor = System.Drawing.Color.Transparent;
            this.GamesHosted.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesHosted.Location = new System.Drawing.Point(874, 457);
            this.GamesHosted.Name = "GamesHosted";
            this.GamesHosted.Size = new System.Drawing.Size(217, 21);
            this.GamesHosted.TabIndex = 4;
            this.GamesHosted.Text = "已舉辦比賽數量: 0 場";
            // 
            // LeagueRatings
            // 
            this.LeagueRatings.AutoSize = true;
            this.LeagueRatings.BackColor = System.Drawing.Color.Transparent;
            this.LeagueRatings.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueRatings.Location = new System.Drawing.Point(874, 513);
            this.LeagueRatings.Name = "LeagueRatings";
            this.LeagueRatings.Size = new System.Drawing.Size(152, 21);
            this.LeagueRatings.TabIndex = 5;
            this.LeagueRatings.Text = "聯盟評級: 青銅";
            // 
            // LeagueGoals
            // 
            this.LeagueGoals.AutoSize = true;
            this.LeagueGoals.BackColor = System.Drawing.Color.Transparent;
            this.LeagueGoals.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueGoals.Location = new System.Drawing.Point(837, 586);
            this.LeagueGoals.Name = "LeagueGoals";
            this.LeagueGoals.Size = new System.Drawing.Size(289, 21);
            this.LeagueGoals.TabIndex = 6;
            this.LeagueGoals.Text = "聯盟目標 (加油! 我們可以的!)";
            // 
            // GoalLists
            // 
            this.GoalLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoalLists.Enabled = false;
            this.GoalLists.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.GoalLists.FormattingEnabled = true;
            this.GoalLists.Items.AddRange(new object[] {
            "舉辦第一場競賽",
            "成員達到十人",
            "被評選為精選聯盟",
            "進入本月排行榜",
            "舉辦每一種競賽",
            "讓一名管理員加入聯盟"});
            this.GoalLists.Location = new System.Drawing.Point(878, 621);
            this.GoalLists.Name = "GoalLists";
            this.GoalLists.Size = new System.Drawing.Size(183, 132);
            this.GoalLists.TabIndex = 7;
            // 
            // HistoryGames
            // 
            this.HistoryGames.AutoSize = true;
            this.HistoryGames.BackColor = System.Drawing.Color.Transparent;
            this.HistoryGames.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryGames.Location = new System.Drawing.Point(29, 19);
            this.HistoryGames.Name = "HistoryGames";
            this.HistoryGames.Size = new System.Drawing.Size(157, 21);
            this.HistoryGames.TabIndex = 8;
            this.HistoryGames.Text = "歷史賽事一覽表";
            // 
            // QuickAction
            // 
            this.QuickAction.AutoSize = true;
            this.QuickAction.BackColor = System.Drawing.Color.Transparent;
            this.QuickAction.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickAction.Location = new System.Drawing.Point(498, 344);
            this.QuickAction.Name = "QuickAction";
            this.QuickAction.Size = new System.Drawing.Size(99, 21);
            this.QuickAction.TabIndex = 9;
            this.QuickAction.Text = "快速動作:";
            // 
            // PlayerLeaderboard
            // 
            this.PlayerLeaderboard.AutoSize = true;
            this.PlayerLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLeaderboard.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLeaderboard.Location = new System.Drawing.Point(498, 19);
            this.PlayerLeaderboard.Name = "PlayerLeaderboard";
            this.PlayerLeaderboard.Size = new System.Drawing.Size(292, 21);
            this.PlayerLeaderboard.TabIndex = 10;
            this.PlayerLeaderboard.Text = "聯盟內玩家排行: (依照積分數)";
            // 
            // LeaderBoard_P
            // 
            this.LeaderBoard_P.BackColor = System.Drawing.Color.Transparent;
            this.LeaderBoard_P.Controls.Add(this.RefreshBTN);
            this.LeaderBoard_P.Controls.Add(this.P_5);
            this.LeaderBoard_P.Controls.Add(this.P_4);
            this.LeaderBoard_P.Controls.Add(this.P_3);
            this.LeaderBoard_P.Controls.Add(this.P_2);
            this.LeaderBoard_P.Controls.Add(this.P_1);
            this.LeaderBoard_P.Location = new System.Drawing.Point(514, 43);
            this.LeaderBoard_P.Name = "LeaderBoard_P";
            this.LeaderBoard_P.Size = new System.Drawing.Size(422, 260);
            this.LeaderBoard_P.TabIndex = 5;
            this.LeaderBoard_P.TabStop = false;
            // 
            // P_5
            // 
            this.P_5.AutoSize = true;
            this.P_5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.P_5.Location = new System.Drawing.Point(20, 223);
            this.P_5.Name = "P_5";
            this.P_5.Size = new System.Drawing.Size(85, 19);
            this.P_5.TabIndex = 4;
            this.P_5.Text = "♜第五名:";
            // 
            // P_4
            // 
            this.P_4.AutoSize = true;
            this.P_4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_4.ForeColor = System.Drawing.Color.Gray;
            this.P_4.Location = new System.Drawing.Point(20, 173);
            this.P_4.Name = "P_4";
            this.P_4.Size = new System.Drawing.Size(85, 19);
            this.P_4.TabIndex = 3;
            this.P_4.Text = "♞第四名:";
            // 
            // P_3
            // 
            this.P_3.AutoSize = true;
            this.P_3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_3.ForeColor = System.Drawing.Color.Chocolate;
            this.P_3.Location = new System.Drawing.Point(20, 123);
            this.P_3.Name = "P_3";
            this.P_3.Size = new System.Drawing.Size(85, 19);
            this.P_3.TabIndex = 2;
            this.P_3.Text = "♝第三名:";
            // 
            // P_2
            // 
            this.P_2.AutoSize = true;
            this.P_2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_2.ForeColor = System.Drawing.Color.Silver;
            this.P_2.Location = new System.Drawing.Point(20, 73);
            this.P_2.Name = "P_2";
            this.P_2.Size = new System.Drawing.Size(85, 19);
            this.P_2.TabIndex = 1;
            this.P_2.Text = "♛第二名:";
            // 
            // P_1
            // 
            this.P_1.AutoSize = true;
            this.P_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_1.ForeColor = System.Drawing.Color.Orange;
            this.P_1.Location = new System.Drawing.Point(20, 23);
            this.P_1.Name = "P_1";
            this.P_1.Size = new System.Drawing.Size(85, 19);
            this.P_1.TabIndex = 0;
            this.P_1.Text = "♚第一名:";
            // 
            // AnnounceWinner
            // 
            this.AnnounceWinner.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.AnnounceWinner.Location = new System.Drawing.Point(514, 390);
            this.AnnounceWinner.Name = "AnnounceWinner";
            this.AnnounceWinner.Size = new System.Drawing.Size(94, 51);
            this.AnnounceWinner.TabIndex = 11;
            this.AnnounceWinner.Text = "宣布賽事優勝者";
            this.AnnounceWinner.UseVisualStyleBackColor = true;
            this.AnnounceWinner.Click += new System.EventHandler(this.AnnounceWinner_Click);
            // 
            // EndedGames
            // 
            this.EndedGames.Controls.Add(this.Empty_EG);
            this.EndedGames.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndedGames.Location = new System.Drawing.Point(7, 56);
            this.EndedGames.Name = "EndedGames";
            this.EndedGames.Size = new System.Drawing.Size(455, 246);
            this.EndedGames.TabIndex = 12;
            this.EndedGames.TabStop = false;
            this.EndedGames.Text = "已結束";
            // 
            // Empty_EG
            // 
            this.Empty_EG.AutoSize = true;
            this.Empty_EG.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.Empty_EG.Location = new System.Drawing.Point(127, 91);
            this.Empty_EG.Name = "Empty_EG";
            this.Empty_EG.Size = new System.Drawing.Size(163, 25);
            this.Empty_EG.TabIndex = 0;
            this.Empty_EG.Text = "沒有賽事紀錄!";
            // 
            // ScheduledGames
            // 
            this.ScheduledGames.Controls.Add(this.Etc);
            this.ScheduledGames.Controls.Add(this.Game3);
            this.ScheduledGames.Controls.Add(this.Game2);
            this.ScheduledGames.Controls.Add(this.Game1);
            this.ScheduledGames.Controls.Add(this.Empty_SG);
            this.ScheduledGames.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduledGames.Location = new System.Drawing.Point(7, 308);
            this.ScheduledGames.Name = "ScheduledGames";
            this.ScheduledGames.Size = new System.Drawing.Size(455, 246);
            this.ScheduledGames.TabIndex = 13;
            this.ScheduledGames.TabStop = false;
            this.ScheduledGames.Text = "已排程";
            // 
            // Etc
            // 
            this.Etc.AutoSize = true;
            this.Etc.Location = new System.Drawing.Point(102, 197);
            this.Etc.Name = "Etc";
            this.Etc.Size = new System.Drawing.Size(208, 21);
            this.Etc.TabIndex = 5;
            this.Etc.Text = "還有其他 {} 個賽事...";
            // 
            // Game3
            // 
            this.Game3.AutoSize = true;
            this.Game3.Location = new System.Drawing.Point(22, 150);
            this.Game3.Name = "Game3";
            this.Game3.Size = new System.Drawing.Size(73, 21);
            this.Game3.TabIndex = 4;
            this.Game3.Text = "賽事三";
            // 
            // Game2
            // 
            this.Game2.AutoSize = true;
            this.Game2.Location = new System.Drawing.Point(22, 100);
            this.Game2.Name = "Game2";
            this.Game2.Size = new System.Drawing.Size(73, 21);
            this.Game2.TabIndex = 3;
            this.Game2.Text = "賽事二";
            // 
            // Game1
            // 
            this.Game1.AutoSize = true;
            this.Game1.Location = new System.Drawing.Point(22, 50);
            this.Game1.Name = "Game1";
            this.Game1.Size = new System.Drawing.Size(73, 21);
            this.Game1.TabIndex = 2;
            this.Game1.Text = "賽事一";
            // 
            // Empty_SG
            // 
            this.Empty_SG.AutoSize = true;
            this.Empty_SG.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.Empty_SG.Location = new System.Drawing.Point(127, 95);
            this.Empty_SG.Name = "Empty_SG";
            this.Empty_SG.Size = new System.Drawing.Size(163, 25);
            this.Empty_SG.TabIndex = 1;
            this.Empty_SG.Text = "沒有賽事紀錄!";
            // 
            // ResetLeaderboard
            // 
            this.ResetLeaderboard.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.ResetLeaderboard.Location = new System.Drawing.Point(661, 390);
            this.ResetLeaderboard.Name = "ResetLeaderboard";
            this.ResetLeaderboard.Size = new System.Drawing.Size(94, 51);
            this.ResetLeaderboard.TabIndex = 14;
            this.ResetLeaderboard.Text = "重置聯盟賽季";
            this.ResetLeaderboard.UseVisualStyleBackColor = true;
            this.ResetLeaderboard.Click += new System.EventHandler(this.ResetLeaderboard_Click);
            // 
            // Reexamine
            // 
            this.Reexamine.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Reexamine.Location = new System.Drawing.Point(514, 470);
            this.Reexamine.Name = "Reexamine";
            this.Reexamine.Size = new System.Drawing.Size(94, 51);
            this.Reexamine.TabIndex = 15;
            this.Reexamine.Text = "申請重新審查";
            this.Reexamine.UseVisualStyleBackColor = true;
            this.Reexamine.Click += new System.EventHandler(this.Reexamine_Click);
            // 
            // Highlights
            // 
            this.Highlights.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F);
            this.Highlights.Location = new System.Drawing.Point(661, 470);
            this.Highlights.Name = "Highlights";
            this.Highlights.Size = new System.Drawing.Size(94, 51);
            this.Highlights.TabIndex = 16;
            this.Highlights.Text = "檢視精華回顧";
            this.Highlights.UseVisualStyleBackColor = true;
            this.Highlights.Click += new System.EventHandler(this.Highlights_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.FlatAppearance.BorderSize = 0;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.Location = new System.Drawing.Point(372, 10);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(45, 45);
            this.RefreshBTN.TabIndex = 5;
            this.RefreshBTN.UseVisualStyleBackColor = true;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // RatingManagementSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.RMPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.Highlights);
            this.Controls.Add(this.Reexamine);
            this.Controls.Add(this.ResetLeaderboard);
            this.Controls.Add(this.ScheduledGames);
            this.Controls.Add(this.EndedGames);
            this.Controls.Add(this.AnnounceWinner);
            this.Controls.Add(this.LeaderBoard_P);
            this.Controls.Add(this.PlayerLeaderboard);
            this.Controls.Add(this.QuickAction);
            this.Controls.Add(this.HistoryGames);
            this.Controls.Add(this.GoalLists);
            this.Controls.Add(this.LeagueGoals);
            this.Controls.Add(this.LeagueRatings);
            this.Controls.Add(this.GamesHosted);
            this.Controls.Add(this.MostActivePlayer);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.LeaderBoard_L);
            this.Controls.Add(this.LeagueLeaderBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RatingManagementSubform";
            this.Load += new System.EventHandler(this.RatingManagementSubform_Load);
            this.LeaderBoard_L.ResumeLayout(false);
            this.LeaderBoard_L.PerformLayout();
            this.LeaderBoard_P.ResumeLayout(false);
            this.LeaderBoard_P.PerformLayout();
            this.EndedGames.ResumeLayout(false);
            this.EndedGames.PerformLayout();
            this.ScheduledGames.ResumeLayout(false);
            this.ScheduledGames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeagueLeaderBoard;
        private System.Windows.Forms.GroupBox LeaderBoard_L;
        private System.Windows.Forms.Label L_5;
        private System.Windows.Forms.Label L_4;
        private System.Windows.Forms.Label L_3;
        private System.Windows.Forms.Label L_2;
        private System.Windows.Forms.Label L_1;
        private System.Windows.Forms.Label Statistics;
        private System.Windows.Forms.Label MostActivePlayer;
        private System.Windows.Forms.Label GamesHosted;
        private System.Windows.Forms.Label LeagueRatings;
        private System.Windows.Forms.Label LeagueGoals;
        private System.Windows.Forms.CheckedListBox GoalLists;
        private System.Windows.Forms.Label HistoryGames;
        private System.Windows.Forms.Label QuickAction;
        private System.Windows.Forms.Label PlayerLeaderboard;
        private System.Windows.Forms.GroupBox LeaderBoard_P;
        private System.Windows.Forms.Label P_5;
        private System.Windows.Forms.Label P_4;
        private System.Windows.Forms.Label P_3;
        private System.Windows.Forms.Label P_2;
        private System.Windows.Forms.Label P_1;
        private System.Windows.Forms.Button AnnounceWinner;
        private System.Windows.Forms.GroupBox EndedGames;
        private System.Windows.Forms.GroupBox ScheduledGames;
        private System.Windows.Forms.Button ResetLeaderboard;
        private System.Windows.Forms.Button Reexamine;
        private System.Windows.Forms.Button Highlights;
        private System.Windows.Forms.Label Empty_EG;
        private System.Windows.Forms.Label Game3;
        private System.Windows.Forms.Label Game2;
        private System.Windows.Forms.Label Game1;
        private System.Windows.Forms.Label Empty_SG;
        private System.Windows.Forms.Label Etc;
        private System.Windows.Forms.ToolTip ExtendDescriptions;
        private System.Windows.Forms.Button RefreshBTN;
    }
}