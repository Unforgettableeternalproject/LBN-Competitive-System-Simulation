using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class RatingManagementSubform : Form //This Form is purely cosmetic as it does not contain any practical data exchanges or W/R
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private League league;
        private List<Proposal> scheduledGames = new List<Proposal>(), updated = null;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        public List<Proposal> Updated { set { updated = value; scheduledGames = updated; updateSchedule(); } }
        public RatingManagementSubform(League _league)
        {
            InitializeComponent();
            league = _league;
        }

        private void RatingManagementSubform_Load(object sender, EventArgs e)
        {
            getLeaderboard_L();
            getLeaderboard_P();
            updateSchedule();
            MostActivePlayer.Text = $"最活躍玩家: {league.Members[random.Next(league.Members.Count)].Username}";
        }

        private void getLeaderboard_L()
        {
            string[] symbols = new string[] { "♚", "♛", "♝", "♞", "♜" }, chineseNumbers = new string[] { "一", "二", "三", "四", "五" };
            List<League> leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            shuffle(leagueList);
            var randomLeaderboard = leagueList.Where(l => l.Name != league.Name).Take(5).ToList();
            for(int i = 0; i < 5; i++)
            {
                LeaderBoard_L.Controls[$"L_{i + 1}"].Text = $"{symbols[i]}第{chineseNumbers[i]}名: " + randomLeaderboard[i].Name;
            }
        }

        private void getLeaderboard_P()
        {
            string[] symbols = new string[] { "♚", "♛", "♝", "♞", "♜" }, chineseNumbers = new string[] {"一", "二", "三", "四", "五"};
            List<ID> playerList = new List<ID>();
            playerList.AddRange(league.Members);
            shuffle(playerList);
            var randomLeaderboard = playerList.Take(5).ToList();
            for (int i = 0; i < 5; i++)
            {
                if (i < randomLeaderboard.Count) LeaderBoard_P.Controls[$"P_{i + 1}"].Text = $"{symbols[i]}第{chineseNumbers[i]}名: " + randomLeaderboard[i].Username;
                else LeaderBoard_P.Controls[$"P_{i + 1}"].Text = $"{symbols[i]}第{chineseNumbers[i]}名: 暫缺";
            }
        }
        private void updateSchedule()
        {
            var ScheduleControl = ScheduledGames.Controls;
            foreach (Control c in ScheduleControl) c.Hide();

            var MaxDisplay = Math.Min(scheduledGames.Count, 3);

            if(MaxDisplay == 0) { Empty_SG.Show(); return; }

            for(int i = 0; i < MaxDisplay; i++)
            {
                ScheduleControl[$"Game{i + 1}"].Text = $"於 {scheduledGames[i].Date.ToShortDateString()} 舉辦的 {scheduledGames[i].GameType}";
                ScheduleControl[$"Game{i + 1}"].Show();
            }

            if (MaxDisplay > 3) { Etc.Show(); Etc.Text = $"還有其他 {scheduledGames.Count - 3} 個賽事..."; }
        }

        private void shuffle<T>(List<T> list)
        {
            Random rand = new Random();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private void AnnounceWinner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的聯盟還沒有參與過任何賽事，只有在令聯盟主辦的賽事結束後才可以宣布優勝者!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetLeaderboard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要重置賽季嗎? 聯盟內的玩家排行榜將會更新!", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) getLeaderboard_P();
        }

        private void Reexamine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的聯盟還沒有參與過任何賽事，因此無法向管理員申請重新審查!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            var leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));

            var updatedLeague = leagueList.FirstOrDefault(l => l.Name == league.Name);
            league = updatedLeague;

            getLeaderboard_P();
        }

        private void Highlights_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("將導覽至最近的精采回顧影片，此舉動將會開啟瀏覽器，是否繼續?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (result == DialogResult.No) return;

            string urlToOpen = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"; //RickRoll Lol

            try
            {
                Process.Start(urlToOpen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening web page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
