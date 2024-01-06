using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class LeagueDutySubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private ID userID;
        private League affiliatedLeague = null;
        private List<League> leagueList;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private bool inLeague, isOwner, hadContact = false, uploaded = false, redirectToLO = false, adminMode;
        private bool[] isDefault = new bool[] { true, true, true, true };
        private List<string> feed = new List<string>()
        {
            "震驚! XX選手竟然宣布退賽!",
            "總有人在冰箱裡放發霉的橘子，真是可惡!",
            "最新聯盟成立! 其名為美麗島共榮圈!",
            "為甚麼台灣的天氣總是這麼熱...",
            "瑞克搖已經老早就過時了，現在的趨勢是沒牙跳舞!",
            "聽說自然聯盟跟美麗生活又槓上了?! 這裡是懶人包",
            "只有萬分之一的人知道這個事實: 這個系統是假的"
        };
        private List<Bitmap> logos = new List<Bitmap>()
        {
            Properties.Resources.LeagueLogo_1,
            Properties.Resources.LeagueLogo_2,
            Properties.Resources.LeagueLogo_3,
            Properties.Resources.LeagueLogo_4,
            Properties.Resources.LeagueLogo_5,
            Properties.Resources.LeagueLogo_6
        };
        private ChatroomSubform chat;
        private Bitmap leagueLogo = null;
        public bool IsOwner { get => isOwner; }
        public bool IsInLeague { get => inLeague; }
        public bool RedirectToLO { get => redirectToLO; set { redirectToLO = value; } }
        public Bitmap LeagueLogo { get => leagueLogo; set { leagueLogo = value; } }

        public LeagueDutySubform(ID _userID, ChatroomSubform _chat, bool _adminMode)
        {
            InitializeComponent();
            userID = _userID;
            chat = _chat;
            adminMode = _adminMode;
            fetchLeague();
            EnterUsername.Enter += EnterUsername_Enter;
            EnterUsername.Leave += EnterUsername_Leave;
            SearchTXT.Enter += SearchTXT_Enter;
            SearchTXT.Leave += SearchTXT_Leave;
            LNameTXT.Enter += LNameTXT_Enter;
            LNameTXT.Leave += LNameTXT_Leave;
            LMottoTXT.Enter += LMottoTXT_Enter;
            LMottoTXT.Leave += LMottoTXT_Leave;
            EnterUsername.KeyDown += Pressed_Key1;
            SearchTXT.KeyDown += Pressed_Key2;
            LNameTXT.KeyDown += Pressed_Key3;
            LMottoTXT.KeyDown += Pressed_Key3;
            LeagueListDisplay.CellDoubleClick += LeagueListDisplay_CellDoubleClick;
            LeagueListDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LeagueListDisplay.MultiSelect = false;
        }
        private void LeagueDutySubform_Load(object sender, EventArgs e)
        {
            Tick.Start();
            if (inLeague) 
            {
                leagueInit(true);
            }
            else { non_leagueInit(); }
        }

        public void refresh(League newLeague)
        {
            affiliatedLeague = newLeague;
            leagueInit();
        }
        private void leagueInit(bool isNew = false)
        {
            BackgroundImage = Properties.Resources.LDPage;
            InLeague.Show();
            OutLeague.Hide();
            WelcomeMessage.Text = $"歡迎回到{affiliatedLeague.Name}!";
            FavorText.Text = "座右銘: " + affiliatedLeague.Motto;
            LeagueType.Text = "聯盟類型: " + affiliatedLeague.LeagueType;
            updateMember();
            EnterUsername.Hide();
            CancelTransfer.Hide();
            if (isOwner)
            {
                LeaguePage.Show();
                TransferOwner.Show();
                ContactOwner.Hide();
                LeaveLeague.Hide();
            }
            else
            {
                LeaguePage.Hide();
                TransferOwner.Hide();
                ContactOwner.Show();
                LeaveLeague.Show();
            }
            if (isNew)
            {
                Rankings.Text = "本周排名: 第 " + random.Next(1, leagueList.Count).ToString() + " 名";
                if(leagueLogo == null) leagueLogo = logos[random.Next(logos.Count)];
                int index1 = random.Next(feed.Count), index2;
                FeedMsg1.Text = feed[index1];
                ExtendDescription.SetToolTip(FeedMsg1, feed[index1]);

                do { index2 = random.Next(feed.Count); } while (index2 == index1);

                FeedMsg2.Text = feed[index2];
                ExtendDescription.SetToolTip(FeedMsg2, feed[index2]);
            }
        }

        private void non_leagueInit()
        {
            BackgroundImage = Properties.Resources.LDPage2;
            InLeague.Hide();
            OutLeague.Show();
            LeagueGridDisplay.Hide();
            CreateLeague.Hide();
            ModeCreate.Show();
            ModeSearch.Show();
            Status.Show();
            SearchBTN.Hide();
            SearchTXT.Hide();
            PrevPage.Hide();
            Hint.Hide();
            Hint2.Hide();
        }

        private void gridInit(List<LeagueDisplay> newList = null)
        {
            List<LeagueDisplay> leagueDisplays;
            if (newList != null) { leagueDisplays = newList; goto SkipToUpdate; }

            leagueDisplays = leagueList.Select(league => new LeagueDisplay
            {
                Name = league.Name,
                LeagueType = league.LeagueType,
                OwnerName = league.Owner.Username,
                MemberCount = league.Members.Count.ToString(),
            }).ToList();

            SkipToUpdate:
           
            LeagueListDisplay.AutoGenerateColumns = true;
            LeagueListDisplay.DataSource = leagueDisplays;
            if (leagueDisplays.Count > 0)  NoResult.Hide();
            else NoResult.Show();
        }
        private void fetchLeague()
        {
            leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            foreach (League league in leagueList)
            {
                if (league.Members.Any(e => e.UUID == userID.UUID)) { inLeague = true; affiliatedLeague = league; }
            }
            if (affiliatedLeague != null && userID.UUID == affiliatedLeague.Owner.UUID) isOwner = true;
            else isOwner = false;
        }

        private void writeBackLeague(League newToLeague = null)
        {
            var specialUsers = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleJSONs\SpecialUserID.json"));
            if (newToLeague != null) { affiliatedLeague = newToLeague; inLeague = true; }
            if (affiliatedLeague == null) return;
            
            leagueList.RemoveAll(m => m.Name == affiliatedLeague.Name);
            leagueList.Add(affiliatedLeague);
            
            foreach(var members in affiliatedLeague.Members)
            {
                if(specialUsers.Any(u => u.UUID == members.UUID))
                {
                    specialUsers.RemoveAll(u => u.UUID == members.UUID);
                    specialUsers.Add(members);
                }
            }
            string leagueJson = JsonConvert.SerializeObject(leagueList, Formatting.Indented),
                   userJson = JsonConvert.SerializeObject(specialUsers, Formatting.Indented);

            // Write the JSON to the file
            File.WriteAllText(@"..\..\ExampleJSONs\Leagues.json", leagueJson);
            File.WriteAllText(@"..\..\ExampleJSONs\SpecialUserID.json", userJson);
        }
        private void TransferOwner_Click(object sender, EventArgs e)
        {
            if (EnterUsername.Visible == true) goto Transfer;
            if(affiliatedLeague.Members.Count == 1) { MessageBox.Show("您的聯盟並沒有其他成員可以被指派為所有人!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DialogResult result = MessageBox.Show("這麼做將會使您失去聯盟所有者的身分，確定要轉移嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(result == DialogResult.Yes)
            {
                EnterUsername.Show();
                TransferOwner.Text = "確認";
                LeaguePage.Enabled = false;
                CancelTransfer.Show();
            }

            return;

            Transfer:
            var newOwnerName = EnterUsername.Text.Trim();
            if (string.IsNullOrEmpty(newOwnerName) || isDefault[0] || !affiliatedLeague.Members.Any(m => m.Username == newOwnerName)) { MessageBox.Show("您並沒有輸入一個存在於聯盟中的用戶名稱!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            var newOwner = affiliatedLeague.Members.First(m => m.Username == newOwnerName);
            newOwner.Role = "League Owner";
            userID.Role = "Player";

            affiliatedLeague.Owner = newOwner;
            affiliatedLeague.Members.RemoveAll(m => m.UUID == userID.UUID);
            affiliatedLeague.Members.Add(userID);

            MessageBox.Show($"已成功轉移所有者身分給 {newOwnerName}!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LeaguePage.Enabled = true;
            TransferOwner.Text = "轉移所有者";
            writeBackLeague();
            isOwner = false;
            leagueInit();
        }

        private void updateMember()
        {
            List<string> display = new List<string>() { "聯盟所有者:", "⚜︎" + affiliatedLeague.Owner.Username, "------------------\n成員:"};
            if (affiliatedLeague.Members.Count == 1) { display.Add("尚無其他成員"); goto SkipMemberCheck; }
            foreach(ID member in affiliatedLeague.Members)
            {
                if(member.UUID != affiliatedLeague.Owner.UUID) display.Add("❣︎" + member.Username);
            }

            SkipMemberCheck:
            Members.Lines = display.ToArray();
        }

        private void LeaguePage_Click(object sender, EventArgs e)
        {
            redirectToLO = true;
        }
        private void CancelTransfer_Click(object sender, EventArgs e)
        {
            EnterUsername.Text = "輸入使用者名稱...";
            EnterUsername.ForeColor = SystemColors.GrayText;
            LeaguePage.Enabled = true;
            TransferOwner.Text = "轉移所有者";
            leagueInit();
        }

        private void LeaveLeague_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"您確定要離開{affiliatedLeague.Name}嗎? 除非再次受到邀請，否則無法再次進入!", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No) return;

            inLeague = false; leagueLogo = null;
            affiliatedLeague.Members.RemoveAll(u => u.UUID == userID.UUID);
            writeBackLeague();
            non_leagueInit();
        }

        private void LeagueListDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LeagueDisplay league;
            if (LeagueListDisplay.CurrentRow != null && LeagueListDisplay.CurrentRow.DataBoundItem is LeagueDisplay selectedLeague)
            {
                league = selectedLeague;
                DialogResult result = MessageBox.Show("將向該聯盟送出加入申請，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No) return;

                DialogResult waity = MessageBox.Show("申請已經被允許!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var newToLeague = leagueList.FirstOrDefault(l => l.Name == league.Name);
                newToLeague.Members.Add(userID);
                writeBackLeague(newToLeague);
                leagueInit(true);
            }
        }

        private void ModeSearch_Click(object sender, EventArgs e)
        {
            if(adminMode) { MessageBox.Show("匿蹤模式下無法瀏覽或創建聯盟!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            ModeCreate.Hide();
            ModeSearch.Hide();
            LeagueGridDisplay.Show();
            gridInit();
            SearchTXT.Show();
            SearchBTN.Show();
            PrevPage.Show();
            Hint.Show();
        }

        private void ModeCreate_Click(object sender, EventArgs e)
        {
            if (adminMode) { MessageBox.Show("匿蹤模式下無法瀏覽或創建聯盟!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            ModeCreate.Hide();
            ModeSearch.Hide();
            LeagueGridDisplay.Hide();
            PrevPage.Show();
            CreateLeague.Show();
            Hint2.Show();
        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            non_leagueInit();
        }

        private void ContactOwner_Click(object sender, EventArgs e)
        {
            if(!hadContact) chat.outerAccess(affiliatedLeague.Owner.Username, new List<string>() { "✎這是你們訊息的開端!\n" });
            hadContact = true;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            var input = SearchTXT.Text.Trim();
            if(string.IsNullOrEmpty(input) || isDefault[1]) { return; }

            var leagueDisplays = leagueList.Select(league => new LeagueDisplay
            {
                Name = league.Name,
                LeagueType = league.LeagueType,
                OwnerName = league.Owner.Username,
                MemberCount = league.Members.Count.ToString(),
            }).ToList();

            var filtered = leagueDisplays.Where(s => s.Name.Contains(input)).ToList();

            gridInit(filtered);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var LeagueName = LNameTXT.Text;
            var LeagueMotto = string.IsNullOrEmpty(LMottoTXT.Text) ? "無" : LMottoTXT.Text;
            if(string.IsNullOrEmpty(LeagueName) || isDefault[2]) { MessageBox.Show("聯盟名稱為必填欄位!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            string LeagueType = null;
            if (LType_R1.Checked) LeagueType = "休閒型聯盟";
            if (LType_R2.Checked) LeagueType = "競技型聯盟";
            if (LType_R3.Checked) LeagueType = "合作型聯盟";

            DialogResult result = MessageBox.Show("將以您的身分去創建一個新聯盟，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No) return;

            var newLeague = new League(LeagueName, userID, LeagueType, LeagueMotto, new List<ID>() { userID });
            leagueLogo = uploaded ? (Bitmap)UploadBox.Image : null;
            isOwner = true;
            writeBackLeague(newLeague);
            leagueInit(true);
        }

        private void UploadBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            if (uploaded) result = MessageBox.Show("你要更換現有的聯盟標誌嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No) return;

            OpenFileDialog of = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg",
                FilterIndex = 1
            };
            if (of.ShowDialog() == DialogResult.OK) { UploadBox.Image = new Bitmap(of.FileName); uploaded = true; MessageBox.Show("已成功上傳圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show("上傳失敗! 請重新嘗試!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (uploaded) result = MessageBox.Show("你要移除現有的聯盟標誌嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else { MessageBox.Show("你還沒有上傳任何圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if (result == DialogResult.No) return;

            UploadBox.Image = Properties.Resources.Placeholder4;
            uploaded = false;
            MessageBox.Show("已移除現有圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region ExtraEvents

        private void Pressed_Key1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                TransferOwner.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void Pressed_Key2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                SearchBTN.PerformClick(); // Simulate a click on the Send Message button
            }
        }

        private void Pressed_Key3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                Create.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void EnterUsername_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入使用者名稱...";
            if (EnterUsername.Text == prompt)
            {
                isDefault[0] = false;
                EnterUsername.Text = string.Empty;
                EnterUsername.ForeColor = SystemColors.ControlText;
            }
        }
        private void EnterUsername_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入使用者名稱...";
            if (string.IsNullOrEmpty(EnterUsername.Text.Trim()))
            {
                isDefault[0] = true;
                EnterUsername.Text = prompt;
                EnterUsername.ForeColor = SystemColors.GrayText;
            }
        }
        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTXT.Text.Trim())) gridInit();
        }

        private void SearchTXT_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入聯盟名稱...";
            if (SearchTXT.Text == prompt)
            {
                isDefault[1] = false;
                SearchTXT.Text = string.Empty;
                SearchTXT.ForeColor = SystemColors.ControlText;
            }
        }
        private void SearchTXT_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入聯盟名稱...";
            if (string.IsNullOrEmpty(SearchTXT.Text.Trim()))
            {
                isDefault[1] = true;
                SearchTXT.Text = prompt;
                SearchTXT.ForeColor = SystemColors.GrayText;
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (leagueLogo != null) Logo.Image = leagueLogo;
        }

        private void LNameTXT_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入聯盟名稱...";
            if(LNameTXT.Text == prompt)
            {
                isDefault[2] = false;
                LNameTXT.Text = string.Empty;
                LNameTXT.ForeColor = SystemColors.ControlText;
            }
        }

        private void LNameTXT_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入聯盟名稱...";
            if (string.IsNullOrEmpty(LNameTXT.Text.Trim()))
            {
                isDefault[2] = true;
                LNameTXT.Text = prompt;
                LNameTXT.ForeColor = SystemColors.GrayText;
            }
        }
        private void LMottoTXT_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入座右銘...";
            if (LMottoTXT.Text == prompt)
            {
                isDefault[3] = false;
                LMottoTXT.Text = string.Empty;
                LMottoTXT.ForeColor = SystemColors.ControlText;
            }
        }
        private void LMottoTXT_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入座右銘...";
            if (string.IsNullOrEmpty(LMottoTXT.Text.Trim()))
            {
                isDefault[3] = true;
                LMottoTXT.Text = prompt;
                LMottoTXT.ForeColor = SystemColors.GrayText;
            }
        }

        #endregion
    }
    class LeagueDisplay
    {
        public string Name { get; set; }
        public string LeagueType { get; set; }
        public string OwnerName { get; set; }
        public string MemberCount { get; set; }
    }
}
