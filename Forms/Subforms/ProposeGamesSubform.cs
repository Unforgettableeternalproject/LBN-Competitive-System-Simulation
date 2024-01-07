using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class ProposeGamesSubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private List<Proposal> proposals = new List<Proposal>(), acceptedProposals = new List<Proposal>();
        private ChatroomSubform chat;
        private League currentLeague;
        private int onGoing = 0, accepted = 0, declined = 0, history = 0;
        private List<string> typeDes = new List<string>()
        {
            "友誼賽為短時賽事，其通常\n在二到四個聯盟之間舉辦，比賽結果\n將不被列入評級標準之中",
            "邀請賽是一種一對一進行的\n回合制小型競賽，由發起邀請的聯盟\n決定比賽類型與規則",
            "錦標賽會涉及眾多聯盟的對\n抗，由最後勝利者獲得所有積分與獎\n勵，通常由系統認定比賽結果",
            "聯盟賽是龐大且嚴謹的賽事\n參與聯盟可以以其積分作為籌碼，爭\n取加倍機會或者全盤皆輸"
        }, 
                             formatDes = new List<string>()
        {
            "在單淘汰賽制中，參賽者一\n旦輸掉比賽就會被淘汰，沒有機會再\n參與後續比賽",
            "雙淘汰賽制允許參賽者輸掉\n一場比賽，需要再次失利才會被淘汰\n，提供了一次機會來挽回局勢",
            "小組賽制將參賽隊伍分成若\n干小組，每組進行循環對戰，最後脫\n穎而出的隊伍晉級",
            "圓桌賽制是一種每位參賽者\n都與其他所有選手對戰的形式，以多\n樣性的對手檢驗參賽者的實力",
            "混合團體賽制是不同項目的\n選手組成一支隊伍參賽，體現個體和\n集體的協同作戰",
            "速度賽強調參賽者快速且高\n效地完成比賽任務，對反應速度和技\n能要求高"
        };
        private bool contact = false;
        private Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        public List<Proposal> AcceptedProposals => acceptedProposals;
        public ProposeGamesSubform(ChatroomSubform _chat, League _currentLeague)
        {
            InitializeComponent();
            chat = _chat;
            TypeChooser.DropDown += TypeChooser_DropDown;
            TypeChooser.DropDownClosed += TypeChooser_DropDownClosed;
            TypeChooser.SelectedIndexChanged += TypeChooser_SelectedIndexChanged;
            FormatChooser.DropDown += FormatChooser_DropDown;
            FormatChooser.DropDownClosed += FormatChooser_DropDownClosed;
            FormatChooser.SelectedIndexChanged += FormatChooser_SelectedIndexChanged;
            Remove1.Click += RemoveButton_Click;
            Remove2.Click += RemoveButton_Click;
            currentLeague = _currentLeague;
        }

        private void updateStatus()
        {
            InQueue.Text = $"進行中: {onGoing} 個";
            Adopted.Text = $"已准許: {accepted} 個";
            Rejected.Text = $"已駁回: {declined} 個";
            Record.Text = $"歷史: {history} 個";
        }
        private void WInit()
        {
            ProposalDisplay.Hide();
            ProposalMaker.Hide();
            WebDisplay.Show();
            NewProposal.Show();
            RemoveProposal.Show();
        }
        private void AInit()
        {
            ProposalDisplay.Hide();
            ProposalMaker.Show();
            WebDisplay.Hide();
            NewProposal.Hide();
            RemoveProposal.Hide();
            TypeChooser.SelectedItem = null; TypeChooser.Text = "選擇類型..."; TypeChooser.ForeColor = SystemColors.GrayText;
            FormatChooser.SelectedItem = null; FormatChooser.Text = "選擇模式..."; FormatChooser.ForeColor = SystemColors.GrayText;
            StartDate.Value = DateTime.Now.AddDays(5); EndDate.Value = DateTime.Now.AddDays(5);
            DoNotify.Checked = false;
        }
        private void RInit()
        {
            ProposalDisplay.Show();
            ProposalMaker.Hide();
            WebDisplay.Hide();
            NewProposal.Hide();
            RemoveProposal.Hide();
            foreach(Control c in ProposalDisplay.Controls) c.Hide();
            if (proposals.Count == 0) Empty.Show();
            else
            {
                var maxDisplay = Math.Min(proposals.Count, 2);
                for(int i = 0; i < maxDisplay; i++)
                {
                    ProposalDisplay.Controls[$"Proposal{i + 1}"].Text = $"於 {proposals[i].Date.ToShortDateString()} 舉行 {proposals[i].GameType}";
                    Explaination.SetToolTip(ProposalDisplay.Controls[$"Proposal{i + 1}"], $"模式: {proposals[i].GameFormat}\n持續時間: {proposals[i].DurationDays} 天");
                    ProposalDisplay.Controls[$"Remove{i + 1}"].Tag = proposals[i];
                    ProposalDisplay.Controls[$"Proposal{i + 1}"].Show();
                    ProposalDisplay.Controls[$"Remove{i + 1}"].Show();
                }
            }
            Return_R.Show();
        }
        private void ProposeGamesSubform_Load(object sender, EventArgs e)
        {
            StartDate.MinDate = DateTime.Now.AddDays(5);
            EndDate.MinDate = StartDate.MinDate;
            Tick.Start();
            updateStatus();
            WInit();
        }
        private void NewProposal_Click(object sender, EventArgs e)
        {
            AInit();
        }

        private void RemoveProposal_Click(object sender, EventArgs e)
        {
            RInit();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(proposals.Count == 2) { MessageBox.Show("一次最多只能同時有兩個正在進行的請求!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            bool hasChange = TypeChooser.SelectedItem != null && FormatChooser.SelectedItem != null;
            if(!hasChange) { MessageBox.Show("您還沒有填寫所有必要的資訊!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            DialogResult result = MessageBox.Show("您即將送出新的賽事請求，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;
            if (result == DialogResult.No) return;

            MessageBox.Show("已送出賽事請求!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            proposals.Add(new Proposal(currentLeague.Name, StartDate.Value, TypeChooser.SelectedItem.ToString(), FormatChooser.SelectedItem.ToString(), EndDate.Value.Subtract(StartDate.Value).Days+1));
            onGoing++; history++;
            updateStatus();
            AInit();
        }
        private void ContactAdmin_Click(object sender, EventArgs e)
        {
            if(!contact) chat.outerAccess("管理員", new List<string>() { "✎這是你們訊息的開端!\n" });
            contact = true;
        }

        private void RemoveIdle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的聯盟並沒有被標記為閒置!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Return_A_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            bool hasChange = TypeChooser.SelectedItem != null || FormatChooser.SelectedItem != null || DoNotify.Checked;
            if (hasChange) result = MessageBox.Show("您有未儲存的變更，確定要捨棄嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;

            if (result == DialogResult.No) return;
            WInit();
        }

        private void Return_R_Click(object sender, EventArgs e)
        {
            WInit();
        }
        #region UnitTest
        public DialogResult ProposeGame()
        {
            NewProposal.PerformClick();
            TypeChooser.SelectedIndex = 2;
            FormatChooser.SelectedIndex = 3;
            DoNotify.Checked = true;
            Submit.PerformClick();
            return DialogResult.OK;
        }
        #endregion

        #region ExtraEvents
        private void FormatChooser_DropDownClosed(object sender, EventArgs e)
        {
            if (FormatChooser.SelectedItem == null) { FormatChooser.Text = "選擇模式...";  FormatChooser.ForeColor = SystemColors.GrayText; }
        }

        private void FormatChooser_DropDown(object sender, EventArgs e)
        {
            FormatChooser.ForeColor = SystemColors.ControlText;
        }

        private void FormatChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var defaultDes = "您尚未選擇一種競賽模式!";
            if (FormatChooser.SelectedItem == null) FormatDescription.Text = "模式說明: " + defaultDes;
            else FormatDescription.Text = "模式說明: " + formatDes[FormatChooser.SelectedIndex];
        }
        private void TypeChooser_DropDownClosed(object sender, EventArgs e)
        {
            if(TypeChooser.SelectedItem == null) { TypeChooser.Text = "選擇類型..."; TypeChooser.ForeColor = SystemColors.GrayText; }
        }

        private void TypeChooser_DropDown(object sender, EventArgs e)
        {
            TypeChooser.ForeColor = SystemColors.ControlText;
        }

        private void TypeChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var defaultDes = "您尚未選擇一種競賽類型!";
            if (TypeChooser.SelectedItem == null) TypeDescription.Text = "類型說明: " + defaultDes;
            else TypeDescription.Text = "類型說明: " + typeDes[TypeChooser.SelectedIndex];
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            var rndNumber = random.Next(450);
            if (proposals.Count > 0 && rndNumber <= 15)
            {
                if(random.NextDouble() > 0.5)
                {
                    var index = random.Next(proposals.Count);
                    accepted++;
                    onGoing--;
                    acceptedProposals.Add(proposals[index]);
                    proposals.Remove(proposals[index]);
                    updateStatus();
                }
                else
                {
                    declined++;
                    onGoing--;
                    proposals.Remove(proposals[random.Next(proposals.Count)]);
                    updateStatus();
                }
            }
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.MinDate = StartDate.Value;
        }
        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            if(EndDate.Value > StartDate.Value.AddDays(14))
            {
                MessageBox.Show("最多只能安排長達十五天的賽程!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EndDate.Value = StartDate.Value.AddDays(14);
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("將移出此賽事請求，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes) HandleApplication(sender as Button);
        }

        private void HandleApplication(Button button)
        {
            if (button != null && button.Tag is Proposal selectedEvent)
            {
                onGoing--;
                proposals.Remove(selectedEvent);
                RInit();
                updateStatus();
            }
        }
        #endregion
    }
}
