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
using System.Windows;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class MemberManagementSubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private League league;
        private ChatroomSubform chat;
        private List<MemberDisplay> members;
        private List<ID> requests = new List<ID>();
        private ID userID;
        private MemberDisplay chosenMember = null;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private bool isDefault = true;
        private List<string> contactedMember = new List<string>(),
                             randomNames = new List<string>
                             {
                                 "Pinelopi",
                                 "Quintinus",
                                 "神奇人",
                                 "神奇小捲毛",
                                 "柏鈞",
                                 "麥當勞叔叔",
                                 "四十四隻石獅子",
                                 "切克斯冰山",
                                 "統魔",
                                 "奪胎叔叔",
                                 "045",
                                 "無敵的吧",
                                 "冰凍的奶油",
                                 "喝咖啡不加奶精",
                                 "我不會玩Celeste",
                                 "犽索上路",
                                 "申",
                                 "巴別圖書館",
                                 "帕絲蒂蘭斯"
                             };
        private int delayTime = 3;
        public MemberManagementSubform(ChatroomSubform _chat, League _league, ID _userID)
        {
            InitializeComponent();
            league = _league;
            chat = _chat;
            userID = _userID;
            SearchTXT.Enter += SearchTXT_Enter;
            SearchTXT.Leave += SearchTXT_Leave;
            SearchTXT.KeyDown += Pressed_Key;
            MemberData.CellClick += MemberData_CellClick;
            for (int i = 0; i < 3; i++)
            {
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Accept{i + 1}"].Click += AcceptButton_Click;
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Decline{i + 1}"].Click += DeclineButton_Click;
            }
        }

        private void MemberManagementSubform_Load(object sender, EventArgs e)
        {
            Tick.Start();
            getMembers();
            foreach (Control c in JoinRequests.Controls) c.Hide();
            gridInit();
            Kick.Enabled = false;
            Ban.Enabled = false;
            Contact.Enabled = false;
            Clear.Enabled = false;
        }

        private void writeBackLeague()
        {
            var leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));

            leagueList.RemoveAll(m => m.Name == league.Name);
            leagueList.Add(league);

            string leagueJson = JsonConvert.SerializeObject(leagueList, Formatting.Indented);
            // Write the JSON to the file
            File.WriteAllText(@"..\..\ExampleJSONs\Leagues.json", leagueJson);
        }
        private void generateRequest()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_)(*%$#@!?";
            string[] domains = new string[] { "@gmail.com", "@yahoo.com", "@outlook.com", "@hotmail.com", "@icloud.com" };
            var username = randomNames[random.Next(randomNames.Count)];
            while(league.Members.Any(p => p.Username == username) || requests.Any(u => u.Username == username)) username = randomNames[random.Next(randomNames.Count)];
            var password =  new string(Enumerable.Repeat(chars, random.Next(8, 15)).Select(s => s[random.Next(s.Length)]).ToArray());
            var email = new string(Enumerable.Repeat(chars, random.Next(4, 8)).Select(s => s[random.Next(s.Length)]).ToArray()) + domains[random.Next(domains.Length)];
            requests.Add(new ID(username, password, email, "Player"));
            updateUI();
        }

        private void updateUI()
        {
            for(int i = 0; i < 3; i++)
            {
                JoinRequests.Controls[$"Request{i + 1}"].Hide();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"RequestTitle{i + 1}"].Hide();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Accept{i + 1}"].Hide();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Decline{i + 1}"].Hide();
            }

            var maxCount = Math.Min(requests.Count, 3);

            for(int i = 0; i < maxCount; i++)
            {
                JoinRequests.Controls[$"Request{i + 1}"].Show();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"RequestTitle{i + 1}"].Text = $"加入請求: 來自 {requests[i].Username}";
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"RequestTitle{i + 1}"].Show();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Accept{i + 1}"].Tag = requests[i];
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Accept{i + 1}"].Show();
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Decline{i + 1}"].Tag = requests[i];
                JoinRequests.Controls[$"Request{i + 1}"].Controls[$"Decline{i + 1}"].Show();
            }

            if (requests.Count > 3) { Etc.Show(); Etc.Text = $"還有 {requests.Count - 3} 個其他請求..."; }
            else Etc.Hide();
        }
        private void getMembers()
        {
            members = league.Members.Where(u => u.UUID != userID.UUID).Select(user => new MemberDisplay
            {
                Name = user.Username,
                Email = user.Email,
                JoinDate = DateTime.Now.AddDays(random.Next(-180, -2)*random.NextDouble())
            }).ToList();
        }

        private void gridInit(List<MemberDisplay> filtered = null)
        {
            var source = members;
            MemberData.AutoGenerateColumns = true;
            if(filtered != null) source = filtered;

            MemberData.DataSource = null;
            MemberData.DataSource = source;

            MemberData.Refresh();
            writeBackLeague();
            if (source.Count > 0) NoResult.Hide();
            else NoResult.Show();
        }
        private void Kick_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"要將{chosenMember.Name}踢出聯盟嗎? 他們可以再次申請加入。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No) return;

            league.Members.RemoveAll(u => u.Username == chosenMember.Name);
            members.Remove(chosenMember);
            gridInit();
        }

        private void Ban_Click(object sender, EventArgs e) //We don't do actual blacklist yet
        {
            DialogResult result = MessageBox.Show($"要將{chosenMember.Name}封禁嗎? 除非被解除封禁，否則他們沒有辦法再次加入此聯盟。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No) return;

            league.Members.RemoveAll(u => u.Username == chosenMember.Name);
            members.Remove(chosenMember);
            gridInit();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            if (contactedMember.Contains(chosenMember.Name)) return;
            contactedMember.Add(chosenMember.Name);
            chat.outerAccess(chosenMember.Name, new List<string>() { "✎這是你們訊息的開端!\n" });
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            chosenMember = null;
            MemberData.ClearSelection();
            SelectedMember.Text = "選取的成員: 無";
            Kick.Enabled = false;
            Ban.Enabled = false;
            Contact.Enabled = false;
            Clear.Enabled = false;
            SearchTXT.Text = string.Empty; //Adding this to force gridInit
            isDefault = true;
            SearchTXT.Text = "輸入成員名稱...";
            SearchTXT.ForeColor = SystemColors.GrayText;
        }
        private void SearchBTN_Click(object sender, EventArgs e)
        {
            var input = SearchTXT.Text.Trim();
            if (string.IsNullOrEmpty(input) || isDefault) { return; }

            var leagueDisplays = league.Members.Select(user => new MemberDisplay
            {
                Name = user.Username,
                Email = user.Email,
                JoinDate = DateTime.Now.AddDays(random.Next(-180, -2) * random.NextDouble())
            }).ToList();

            var filtered = leagueDisplays.Where(s => s.Name.Contains(input)).ToList();

            gridInit(filtered);
        }
        #region ExtraEvents
        private void Pressed_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                SearchBTN.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void MemberData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MemberData.CurrentRow != null && MemberData.CurrentRow.DataBoundItem is MemberDisplay member)
            {
                chosenMember = member;
                SelectedMember.Text = $"選取的成員: {member.Name}";
                Kick.Enabled = true;
                Ban.Enabled = true;
                Contact.Enabled = true;
                Clear.Enabled = true;
            }
        }
        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            MemberData.ClearSelection();
            SelectedMember.Text = "選取的成員: 無";
            if (string.IsNullOrEmpty(SearchTXT.Text.Trim())) gridInit();
        }

        private void SearchTXT_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入成員名稱...";
            if (SearchTXT.Text == prompt)
            {
                isDefault = false;
                SearchTXT.Text = string.Empty;
                SearchTXT.ForeColor = SystemColors.ControlText;
            }
        }
        private void SearchTXT_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入成員名稱...";
            if (string.IsNullOrEmpty(SearchTXT.Text.Trim()))
            {
                isDefault = true;
                SearchTXT.Text = prompt;
                SearchTXT.ForeColor = SystemColors.GrayText;
            }
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var eventHolder = sender as Button;
            if (eventHolder.Tag is ID player) result = MessageBox.Show($"允許{player.Username}加入聯盟嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else return;

            if (result == DialogResult.Yes) HandleApplication(sender as Button, "Accept");
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            var eventHolder = sender as Button;
            if (eventHolder.Tag is ID player) result = MessageBox.Show($"婉拒{player.Username}的加入請求嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else return;

            if (result == DialogResult.Yes) HandleApplication(sender as Button, "Decline");
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (requests.Count == 0) Empty.Show();
            else Empty.Hide();

            if (delayTime != 0) { delayTime--; return; }
            if(random.Next(450) < 50) { Empty.Hide(); delayTime = 3; generateRequest(); }
        }

        private void HandleApplication(Button button, string mode)
        {
            if (button != null && button.Tag is ID newPlayer)
            {
                if (mode == "Accept") { league.Members.Add(newPlayer); members.Add(new MemberDisplay(newPlayer)); }
                requests.Remove(newPlayer);
                updateUI();
                gridInit();
            }
        }
        #endregion
        class MemberDisplay
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime JoinDate { get; set; }

            public MemberDisplay() { }
            public MemberDisplay(ID baseID)
            {
                Name = baseID.Username;
                Email = baseID.Email;
                JoinDate = DateTime.Now;
            }
        }
    }
}
