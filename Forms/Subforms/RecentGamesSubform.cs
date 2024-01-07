using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class RecentGamesSubform : Form
    {
        //▲▼
        static readonly long currentTime = DateTime.Now.Ticks;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private static readonly List<Proposal> defaultEventList = new List<Proposal>()
        {
            new Proposal("小人物聯盟", DateTime.Now.AddDays(random.Next(1, 14)*random.NextDouble()), "友誼賽", "單一淘汰賽制", random.Next(14)),
            new Proposal("自然聯盟",  DateTime.Now.AddDays(random.Next(1, 14)*random.NextDouble()), "錦標賽", "圓桌賽制", random.Next(14)),
            new Proposal("美麗生活",  DateTime.Now.AddDays(random.Next(1, 14)*random.NextDouble()), "聯盟賽", "小組賽制", random.Next(14))
        };
        private List<Proposal> eventList = new List<Proposal>(), acceptedEventList = new List<Proposal>();
        private DateTime updateTime;
        private bool isInLeague;
        public List<Proposal> EventList { get => acceptedEventList; }
        public DateTime UpdateTime => updateTime;
        public RecentGamesSubform(bool IsInLeague, List<Proposal> extraEvents = null)
        {
            InitializeComponent();
            if (extraEvents != null) eventList.AddRange(extraEvents);
            else eventList.AddRange(defaultEventList);
            isInLeague = IsInLeague;

            for(int i = 0; i < 3; i++) 
            {
                Recent7Days.Controls[$"Apply_7_{i + 1}"].Click += ApplyButton_Click;
                Recent30Days.Controls[$"Apply_30_{i + 1}"].Click += ApplyButton_Click;
                Recent7Days.Controls[$"Ignore_7_{i + 1}"].Click += IgnoreButton_Click;
                Recent30Days.Controls[$"Ignore_30_{i + 1}"].Click += IgnoreButton_Click;
            }
        }

        private void RecentGamesSubform_Load(object sender, EventArgs e)
        {
            Recent7Days.Hide();
            Recent30Days.Hide();
            lbl_7.Text = "近七天的賽事 ▲";
            lbl_30.Text = "近三十天的賽事 ▲";
            foreach(Control c in Recent7Days.Controls)
            {
                c.Hide();
            }
            foreach (Control c in Recent30Days.Controls)
            {
                c.Hide();
            }
            updateEvent();
        }

        private void updateEvent()
        {
            var in7days = eventList.Where(e => e.Date >= DateTime.Now && e.Date <= DateTime.Now.AddDays(7)).ToList();
            var in30days = eventList.Where(e => e.Date > DateTime.Now.AddDays(7) && e.Date <= DateTime.Now.AddDays(30)).ToList();

            UpdateEventDisplay(in7days, Recent7Days, "7");
            UpdateEventDisplay(in30days, Recent30Days, "30");
        }
        private void UpdateEventDisplay(List<Proposal> events, GroupBox groupBox, string prefix)
        {
            // Hide all labels and buttons initially
            for (int i = 1; i <= 3; i++)
            {
                groupBox.Controls[$"lbl_Game_{prefix}_{i}"].Visible = false;
                groupBox.Controls[$"Apply_{prefix}_{i}"].Visible = false;
                groupBox.Controls[$"Ignore_{prefix}_{i}"].Visible = false;
            }

            // Limit the number of events to display
            int maxEventsToShow = Math.Min(events.Count, 3);

            for (int i = 0; i < maxEventsToShow; i++)
            {
                var title = $"{events[i].LeagueName} 主辦 {events[i].GameType}，於 {events[i].Date.ToShortDateString()} 開始為期 {events[i].DurationDays} 天";
                // Set the text for the label
                groupBox.Controls[$"lbl_Game_{prefix}_{i + 1}"].Text = title;
                FullDescription.SetToolTip(groupBox.Controls[$"lbl_Game_{prefix}_{i + 1}"], title);
                // Set visibility for label and buttons
                groupBox.Controls[$"lbl_Game_{prefix}_{i + 1}"].Visible = true;
                groupBox.Controls[$"Apply_{prefix}_{i + 1}"].Tag = events[i];
                groupBox.Controls[$"Apply_{prefix}_{i + 1}"].Visible = true;
                groupBox.Controls[$"Ignore_{prefix}_{i + 1}"].Tag = events[i];
                groupBox.Controls[$"Ignore_{prefix}_{i + 1}"].Visible = true;
            }

            if (events.Count > 3)
            {
                groupBox.Controls[$"Etc_{prefix}"].Show();
                groupBox.Controls[$"Etc_{prefix}"].Text = $"還有 {events.Count-3} 個未顯示的賽事...";
            } else groupBox.Controls[$"Etc_{prefix}"].Hide();
        }
        private void lbl_7_Click(object sender, EventArgs e)
        {
            if (Recent7Days.Visible)
            {
                lbl_7.Text = "近七天的賽事 ▲";
                Recent7Days.Hide();
            }
            else
            {
                lbl_7.Text = "近七天的賽事 ▼";
                Recent7Days.Show();
            }
        }
        private void lbl_30_Click(object sender, EventArgs e)
        {
            if (Recent30Days.Visible)
            {
                lbl_30.Text = "近三十天的賽事 ▲";
                Recent30Days.Hide();
            }
            else
            {
                lbl_30.Text = "近三十天的賽事 ▼";
                Recent30Days.Show();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (!isInLeague) { MessageBox.Show("你還沒有加入任何聯盟!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            DialogResult result = MessageBox.Show("將向聯盟所有人申請加入競賽，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) HandleApplication(sender as Button, "Apply");
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {
            if (!isInLeague) { MessageBox.Show("你還沒有加入任何聯盟!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
            DialogResult result = MessageBox.Show("將忽略此賽事並將其移出近期賽事外，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) HandleApplication(sender as Button, "Ignore");
        }

        private void HandleApplication(Button button, string mode)
        {
            if (button != null && button.Tag is Proposal selectedEvent)
            {
                if (mode == "Apply") { acceptedEventList.Add(selectedEvent); updateTime = DateTime.Now; }
                eventList.Remove(selectedEvent);
                updateEvent();
            }
        }

        #region UnitTest
        public DialogResult JoinGame()
        {
            lbl_7.Text = "近七天的賽事 ▼";
            Recent7Days.Show();
            Apply_7_1.PerformClick();
            return DialogResult.OK;
        }
        #endregion
    }
}
