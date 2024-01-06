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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class LeagueOverviewSubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private League affiliatedLeague;
        private Bitmap logo = null;
        private bool requestSent = false, uploaded = false;
        private bool[] buttonStatus = new bool[] { true, true, true }, isDefault = new bool[] { true, true };
        private int announements = 0, delayTime = 3;
        private List<string> logs = new List<string>() { "這是聯盟紀錄的開端...\n" }, randomLogs = new List<string>()
        {
            "有新的聯盟被創立了!",
            "新的專家評分規則已被制定，請至官網公告查詢",
            "有人向您的聯盟發起了對戰請求! 詳情請至...",
            "永遠不會放棄你，永遠不會讓你失望",
            $"連假期間系統將關閉保養，請於{DateTime.Now.AddDays(14).ToShortDateString()}後登入來查看更新",
            "有惡意人士正在攻擊系統，目前已經找到攻擊者的IP，正在採取進一步行動",
            "你認真覺得這裡會有能看的公告嗎?",
            "說實話我也不知道聯盟紀錄能寫甚麼"
        };
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private DateTime updateTime;
        public DateTime UpdateTime => updateTime;
        public Bitmap Logo => logo;
        public League League { get => affiliatedLeague; set { affiliatedLeague = value; updateTime = DateTime.Now; MemberCount.Text = $"成員數量: {affiliatedLeague.Members.Count} 名成員"; } }
        public LeagueOverviewSubform(League _affiliatedLeague, Bitmap _logo)
        {
            InitializeComponent();
            affiliatedLeague = _affiliatedLeague;
            logo = _logo;
            if (logo != null) uploaded = true;
            Modify_1.KeyDown += Pressed_Key1;
            Modify_2.KeyDown += Pressed_Key2;
            Modify_3.KeyDown += Pressed_Key3;
            ANName.Enter += ANName_Enter;
            ANName.Leave += ANName_Leave;
            ANContext.Enter += ANContext_Enter;
            ANContext.Leave += ANContext_Leave;
        }

        private void LeagueOverviewSubform_Load(object sender, EventArgs e)
        {
            Tick.Start();
            LName.Text = affiliatedLeague.Name;
            LMotto.Text = affiliatedLeague.Motto;
            LType.SelectedIndex = LType.FindStringExact(affiliatedLeague.LeagueType);
            LogoImg.Image = logo; 
            MemberCount.Text = $"成員數量: {affiliatedLeague.Members.Count} 名成員";
            LeagueRating.Text = $"聯盟評級: 本月第 {random.Next(10, 15)} 名";
            PublishStatus.Text = $"目前有{announements}則公告張貼中";
            AnnouncementCreator.Enabled = false;
            updateLog();
        }

        private void writeBackLeague(League newLeague)
        {
            var leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));

            leagueList.RemoveAll(m => m.Name == affiliatedLeague.Name);
            leagueList.Add(newLeague);

            affiliatedLeague = newLeague;
            updateTime = DateTime.Now;
            string leagueJson = JsonConvert.SerializeObject(leagueList, Formatting.Indented);

            // Write the JSON to the file
            File.WriteAllText(@"..\..\ExampleJSONs\Leagues.json", leagueJson);
        }

        private void updateLog(string newLog = null)
        {
            if(newLog != null) logs.Add(newLog);
            EventLog.Lines = logs.ToArray();
            EventLog.SelectionStart = EventLog.Text.Length;
            EventLog.ScrollToCaret();
        }
        private void SendVerification_Click(object sender, EventArgs e)
        {
            if(!requestSent) MessageBox.Show("已向管理員送出聯盟驗證請求!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("您已經有一個正在進行的請求!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            requestSent = true;
        }

        private void Upload_Click(object sender, EventArgs e)
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
            if (of.ShowDialog() == DialogResult.OK) { logo = new Bitmap(of.FileName); LogoImg.Image = logo; uploaded = true; MessageBox.Show("已成功上傳圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else MessageBox.Show("上傳失敗! 請重新嘗試!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CreateAnnoucement_Click(object sender, EventArgs e)
        {
            if(!AnnouncementCreator.Enabled) AnnouncementCreator.Enabled = true;
        }

        private void Publish_Click(object sender, EventArgs e)
        {
            string title = ANName.Text, context = ANContext.Text;
            DialogResult result = DialogResult.Yes;
            if((string.IsNullOrEmpty(title) || isDefault[0]) && (string.IsNullOrEmpty(context) || isDefault[1])) { MessageBox.Show("你並沒有填寫任何標題或內文", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if((string.IsNullOrEmpty(title) || isDefault[0])) { result = MessageBox.Show("你並沒有填寫任何標題，確定要發布嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }
            if ((string.IsNullOrEmpty(context) || isDefault[1])) { result = MessageBox.Show("你並沒有填寫任何內文，確定要發布嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information); }

            if (result == DialogResult.No) return;

            announements++;
            PublishStatus.Text = $"目前有{announements}則公告張貼中";

            ANName.Text = "輸入標題..."; ANName.ForeColor = SystemColors.GrayText;
            ANContext.Text = "輸入內文..."; ANName.ForeColor = SystemColors.GrayText;
            ANStartDate.Value = DateTime.Now; ANEndDate.Value = DateTime.Now;

            MessageBox.Show("已成功刊登公告!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AnnouncementCreator.Enabled = false;
        }

        private void Modify_1_Click(object sender, EventArgs e)
        {
            if (buttonStatus[0])
            {
                buttonStatus[0] = false;
                LName.Enabled = true;
                Modify_1.Text = "確認";
            }
            else
            {
                var newLeague = new League(affiliatedLeague);
                if(string.IsNullOrEmpty(LName.Text)) { MessageBox.Show("你並沒有填寫任何文字!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                newLeague.Name = LName.Text;
                writeBackLeague(newLeague);
                buttonStatus[0] = true;
                LName.Enabled = false;
                Modify_1.Text = "修改";
            }
        }

        private void Modify_2_Click(object sender, EventArgs e)
        {
            if (buttonStatus[1])
            {
                buttonStatus[1] = false;
                LMotto.Enabled = true;
                Modify_2.Text = "確認";
            }
            else
            {
                var newLeague = new League(affiliatedLeague);
                if (string.IsNullOrEmpty(LMotto.Text)) { MessageBox.Show("你並沒有填寫任何文字!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                newLeague.Motto = LMotto.Text;
                writeBackLeague(newLeague);
                buttonStatus[1] = true;
                LMotto.Enabled = false;
                Modify_2.Text = "修改";
            }
        }

        private void Modify_3_Click(object sender, EventArgs e)
        {
            if (buttonStatus[2])
            {
                buttonStatus[2] = false;
                LType.Enabled = true;
                Modify_3.Text = "確認";
            }
            else
            {
                var newLeague = new League(affiliatedLeague);
                if (LType.SelectedItem == null) { MessageBox.Show("你並沒有選擇一種類型!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                newLeague.LeagueType = LType.SelectedItem.ToString();
                writeBackLeague(newLeague);
                buttonStatus[2] = true;
                LType.Enabled = false;
                Modify_3.Text = "修改";
            }
        }
        private void DeleteLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("將會刪除所有事件紀錄，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No) return;

            logs = new List<string>() { "這是聯盟紀錄的開端...\n" };
            updateLog();
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EventLog.Text);
            MessageBox.Show("已複製至剪貼簿!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (delayTime > 0) { delayTime--; return; }
            if (random.Next(60) < 7) { updateLog($"[{DateTime.Now.ToShortTimeString()}] ✒ {randomLogs[random.Next(randomLogs.Count)]}"); delayTime = 3; } 
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (uploaded) result = MessageBox.Show("你要移除現有的聯盟標誌嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else { MessageBox.Show("你還沒有上傳任何圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            if (result == DialogResult.No) return;

            logo = Properties.Resources.Placeholder4;
            LogoImg.Image = logo;
            uploaded = false;
            MessageBox.Show("已移除現有圖片!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region ExtraEvents
        private void Pressed_Key1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                Modify_1.PerformClick(); // Simulate a click on the Send Message button
            }
        }

        private void Pressed_Key2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                Modify_2.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void Pressed_Key3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                Modify_3.PerformClick(); // Simulate a click on the Send Message button
            }
        }

        private void ANName_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入標題...";
            if (ANName.Text == prompt)
            {
                isDefault[0] = false;
                ANName.Text = string.Empty;
                ANName.ForeColor = SystemColors.ControlText;
            }
        }

        private void ANStartDate_ValueChanged(object sender, EventArgs e)
        {
            ANEndDate.MinDate = ANStartDate.Value;
        }

        private void ANName_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入標題...";
            if (string.IsNullOrEmpty(ANName.Text.Trim()))
            {
                isDefault[0] = true;
                ANName.Text = prompt;
                ANName.ForeColor = SystemColors.GrayText;
            }
        }
        private void ANContext_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入內文...";
            if (ANContext.Text == prompt)
            {
                isDefault[1] = false;
                ANContext.Text = string.Empty;
                ANContext.ForeColor = SystemColors.ControlText;
            }
        }
        private void ANContext_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入內文...";
            if (string.IsNullOrEmpty(ANContext.Text.Trim()))
            {
                isDefault[1] = true;
                ANContext.Text = prompt;
                ANContext.ForeColor = SystemColors.GrayText;
            }
        }
        #endregion
    }
}
