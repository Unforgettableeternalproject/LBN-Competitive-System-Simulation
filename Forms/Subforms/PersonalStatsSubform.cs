using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    /// <summary>
    /// Provides function to view personal statistics for the players.
    /// </summary>
    public partial class PersonalStatsSubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private readonly ID userID;
        private League affiliatedLeague = null;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private bool isDefault = true, adminMode = false, isInLeague, uploaded = false;
        private List<Proposal> pastGames = new List<Proposal>();
        private int defaultChance = 200;
        private readonly List<string> leagues = new List<string>()
        {
            "大美國聯合聯盟",
            "美麗島共和國",
            "你說得隊",
            "完全勝利團隊",
            "啊對對隊",
            "大老鷹隊",
            "王國之淚五百小隊",
            "美麗生活",
            "小人物聯盟",
            "車諾比戰隊",
            "自然聯盟",
            "老二高爾夫協會",
            "血盟騎士團",
            "弒獸之者",
            "風切鬥士",
            "蜂蜜聯盟"
        };
        private readonly List<string> gameType = new List<string>()
        {
            "友誼賽",
            "邀請賽",
            "錦標賽",
            "聯盟賽",
            "猴友誼賽"
        };
        private readonly List<string> gameFormat = new List<string>()
        {
            "單淘汰賽制",
            "雙淘汰賽制",
            "小組賽制",
            "圓桌賽制",
            "混合團體賽制",
            "速度賽制"
        };
        public bool IsInLeague { get => isInLeague; set { isInLeague = value; } }
        public PersonalStatsSubform(ID _userID, bool _adminMode)
        {
            InitializeComponent();
            userID = _userID;
            adminMode = _adminMode;
            SignatureTXT.Enter += SignatureTXT_Enter;
            SignatureTXT.Leave += SignatureTXT_Leave;
        }

        private void fetchLeague()
        {
            var leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            foreach (League league in leagueList)
            {
                if (league.Members.Any(e => e.UUID == userID.UUID)) { isInLeague = true; affiliatedLeague = league; }
            }
        }

        private void PersonalStatsSubform_Load(object sender, EventArgs e)
        {
            Nickname.Text = "玩家暱稱: " + userID.Username;
            Identifier.Text = "識別碼: " + userID.UUID;
            fetchLeague();
            if(isInLeague)
            {
                AffiliatedLeague.Text = "所屬聯盟: " + affiliatedLeague.Name;
                LeagueRole.Text = "成員身分: " + (affiliatedLeague.Owner.UUID == userID.UUID ? "所有者" : "成員");
                Ratings.Text = "評分排名: 第 " + random.Next(1, 6).ToString() + " 名";
                NoRecord.Hide();
                createPastGames();
            }
            else
            {
                AffiliatedLeague.Text = "所屬聯盟: 無";
                LeagueRole.Text = "成員身分: 無";
                Ratings.Text = "評分排名: 無";
                foreach(Control c in History.Controls) c.Visible = false;
                NoRecord.Show();
            }

            Participated.Text = "歷史參與賽事數: " + pastGames.Count;
            Warning.Text = "收到過的警告數: " + (adminMode ? "0" : random.Next(5).ToString());

        }

        public void update()
        {
            fetchLeague();
            if (isInLeague)
            {
                AffiliatedLeague.Text = "所屬聯盟: " + affiliatedLeague.Name;
                LeagueRole.Text = "成員身分: " + (affiliatedLeague.Owner.UUID == userID.UUID ? "所有者" : "成員");
                Ratings.Text = "評分排名: 尚未更新";
                NoRecord.Hide();
            }
            else
            {
                AffiliatedLeague.Text = "所屬聯盟: 無";
                LeagueRole.Text = "成員身分: 無";
                Ratings.Text = "評分排名: 無";
                foreach (Control c in History.Controls) c.Visible = false;
                NoRecord.Show();
            }
        }
        private void createPastGames()
        {
            while(defaultChance > 0)
            {
                defaultChance -= random.Next(15, 50);
                pastGames.Add(new Proposal(leagues[random.Next(leagues.Count)], DateTime.Now.AddDays(random.Next(-200, -1)), gameType[random.Next(gameType.Count)], gameFormat[random.Next(gameFormat.Count)], random.Next(5, 15)));
            }
            pastGames.Sort((x,y) => DateTime.Compare(y.Date, x.Date));
            defaultChance = 200;
            updatePastGames();
        }

        private void updatePastGames()
        {
            for (int i = 1; i <= 6; i++) History.Controls[$"Game_{i}"].Visible = false;

            int maxEventsToShow = Math.Min(pastGames.Count, 6);

            for(int i = 0; i < maxEventsToShow; i++)
            {
                var display = $"{pastGames[i].Date.ToShortDateString()} 由 {pastGames[i].LeagueName} 舉辦的 {pastGames[i].GameType} ";
                History.Controls[$"Game_{i+1}"].Visible = true;
                History.Controls[$"Game_{i+1}"].Text = display;
                ExtendDescription.SetToolTip(History.Controls[$"Game_{i + 1}"], $"比賽結果: 主方 ({random.Next(70)}) - 客方 ({random.Next(70)})");
            }

            if (pastGames.Count > 6) { Etc.Show(); Etc.Text = $"以及其他 {pastGames.Count - 6} 場賽事..."; ExtendDescription.SetToolTip(Etc, "還有以下賽事: \n" + string.Join("\n", pastGames.Skip(6).Select(game => $"{game.Date.ToShortDateString()} 由 {game.LeagueName} 舉辦的 {game.GameType}"))); }
            else Etc.Hide();
        }
        private void Upload_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (uploaded) result = MessageBox.Show("你要更換你的使用者頭像嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else goto SkipComfirmation;

            if (result == DialogResult.No) return;

            SkipComfirmation:

            OpenFileDialog of = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg",
                FilterIndex = 1
            };
            if (of.ShowDialog() == DialogResult.OK) { AvatarIMG.Image = new Bitmap(of.FileName); uploaded = true;  MessageBox.Show("已成功更換頭貼!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (uploaded) result = MessageBox.Show("你要移除現有的使用者頭像嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else { MessageBox.Show("你還沒有上傳任何頭像!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if (result == DialogResult.No) return;

            AvatarIMG.Image = Properties.Resources.Placeholder4;
            uploaded = false;
            MessageBox.Show("已移除現有頭貼!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            if (!SignatureTXT.Enabled)
            {
                SignatureTXT.Enabled = true;
                Modify.Text = "完成";
            }
            else
            {
                if(string.IsNullOrEmpty(SignatureTXT.Text) || isDefault)
                {
                    MessageBox.Show("你並沒有填寫任何內容!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    SignatureTXT.Enabled = false;
                    Modify.Text = "修改";
                    MessageBox.Show("已儲存個性簽名!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if(pastGames.Count == 0) { MessageBox.Show("您並沒有任何過往的賽事記錄!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel表單檔案 (*.xlsx)|*.xlsx|所有檔案 (*.*)|*.*",
                Title = "儲存文件",
                FileName = "PastGames.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("PastGames");

                    // Headers
                    worksheet.Cells["A1"].Value = "主辦聯盟";
                    worksheet.Cells["B1"].Value = "競賽類別";
                    worksheet.Cells["C1"].Value = "日期";
                    worksheet.Cells["D1"].Value = "持續時間";
                    // Add more headers as needed

                    // Data
                    for (int i = 0; i < pastGames.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = pastGames[i].LeagueName;
                        worksheet.Cells[i + 2, 2].Value = pastGames[i].GameType;
                        worksheet.Cells[i + 2, 3].Value = pastGames[i].Date.ToShortDateString();
                        worksheet.Cells[i + 2, 4].Value = pastGames[i].DurationDays.ToString() + "天";
                        // Add more data columns as needed
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(excelFile);

                    Console.WriteLine($"Exported to Excel: {excelFile.FullName}");
                }

                MessageBox.Show("已成功匯出檔案!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SignatureTXT_Enter(object sender, EventArgs e)
        {
            var prompt = "加入你的個性簽名吧!";
            if (SignatureTXT.Text == prompt)
            {
                isDefault = false;
                SignatureTXT.Text = string.Empty;
                SignatureTXT.ForeColor = SystemColors.ControlText;
            }
        }

        private void SignatureTXT_Leave(object sender, EventArgs e)
        {
            var prompt = "加入你的個性簽名吧!";
            if (string.IsNullOrEmpty(SignatureTXT.Text.Trim()))
            {
                isDefault = true;
                SignatureTXT.Text = prompt;
                SignatureTXT.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
