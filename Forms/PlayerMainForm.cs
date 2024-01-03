using LBN_Competitive_System_Simulation.Forms.Subforms;
using Newtonsoft.Json;
using OfficeOpenXml.Style;
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

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class PlayerMainForm : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private List<Proposal> eventList = new List<Proposal>(), extraEventList = null;
        private List<League> leagueList = new List<League>();
        private bool isInLeague, isOwner, adminMode, redirectToLO = false;
        private League affiliatedLeague = null;
        private readonly ID userID;
        private static readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private RecentGamesSubform rg;
        private PersonalStatsSubform ps;
        private LeagueDutySubform ld;
        private ChatroomSubform chat;
        private CalendarSubform c;
        private DateTime updateTime;
        public PlayerMainForm(ID _userID, bool _adminMode = false, List<Proposal> outerEventList = null)
        {
            InitializeComponent();
            userID = _userID;
            adminMode = _adminMode;
            if(outerEventList != null) extraEventList = outerEventList;
            if (adminMode) SwitchRole.Text = "返回管理頁面";
            else SwitchRole.Text = "切換使用者...";
            getLeagueList();
            fetchLeague();
            if (!isInLeague) Announcement.Image = Properties.Resources.LeagueAnnouncementEmpty;
            else Announcement.Image = Properties.Resources.LeagueAnnouncementNormal;
        }

        private void PlayerMainForm_Load(object sender, EventArgs e)
        {
            Tick.Start();
            WelcomeMessage.Text = $"好久不見, {userID.Username}\n\n見到你真開心!\n\n今天也要再加把勁喔!";
            Chatroom.Hide();
            RedirectSpinner.Hide();
            ExpandChatroom.Show();
            overallInit();
            RGInit();
        }

        private void fetchLeague()
        {
            Console.WriteLine("Debug-1");
            foreach (League league in leagueList)
            {
                if (league.Members.Any(e => e.UUID == userID.UUID)) { isInLeague = true; LeagueDisplay.Text = league.Name; affiliatedLeague = league; }
                foreach(ID user in league.Members) Console.WriteLine(user.UUID.ToString() + " : " + userID.UUID);
            }
            if (affiliatedLeague != null && affiliatedLeague.Owner.UUID == userID.UUID) isOwner = true;
            else isOwner = false;
        }
        private void getLeagueList()
        {
            Console.WriteLine("Debug-2");
            leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            Console.WriteLine(leagueList[0].Members.Count);
        }
        private void overallInit()
        {
            chat = new ChatroomSubform("Player")
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            rg = new RecentGamesSubform(isInLeague, extraEventList)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            ps = new PersonalStatsSubform(userID, adminMode)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            ld = new LeagueDutySubform(userID, chat)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            c = new CalendarSubform(false)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            rg.Show();
            ps.Show();
            ld.Show();
            chat.Show();
            c.Show();
            chat.VisibleChanged += Chat_VisibleChanged;
            Chatroom.Controls.Add(chat);
            Chatroom.Tag = "active";
        }

        private void LOredirect()
        {
            SubPages.Controls.Clear();
            RedirectSpinner.Show();
            redirectTimer.Start();
        }
        private void RGInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(rg);
            SubPages.Tag = rg;
        }

        private void PSInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ps);
            SubPages.Tag = ps;
        }

        private void LDInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ld);
            SubPages.Tag = ld;
        }
        private void CInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(c);
            SubPages.Tag = c;
        }
        private void SwitchRole_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要離開系統嗎?", "離開系統?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ExpandChatroom_Click(object sender, EventArgs e)
        {
            ExpandChatroom.Hide();
            Chatroom.Show();
            chat.Show();
        }

        private void Chat_VisibleChanged(object sender, EventArgs e)
        {
            if (chat.Visible == false)
            {
                ExpandChatroom.Show();
                Chatroom.Hide();
            }
        }

        private void RecentGames_Click(object sender, EventArgs e)
        {
            RGInit();
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            CInit();
        }

        private void redirectTimer_Tick(object sender, EventArgs e)
        {
            redirectTimer.Stop();
            RedirectSpinner.Hide();
            this.Hide();
            LeagueMainForm league = new LeagueMainForm(userID);
            league.ShowDialog();

            this.Show();
            ld.RedirectToLO = false;
            Home.PerformClick();
        }

        private void PersonalStats_Click(object sender, EventArgs e)
        {
            PSInit();
        }

        private void LeagueDuty_Click(object sender, EventArgs e)
        {
            LDInit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            RGInit();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(updateTime, rg.UpdateTime) < 0) { eventList = rg.EventList; updateTime = DateTime.Now; }
            c.EventList = eventList;
            if(isInLeague != ld.IsInLeague) { isInLeague = ld.IsInLeague; ps.IsInLeague = isInLeague; ps.update(); }
            if(isOwner != ld.IsOwner) { isOwner = ld.IsOwner; ps.update(); }
            redirectToLO = ld.RedirectToLO;

            if (redirectToLO) LOredirect();
        }
        
    }

    public class League
    {
        public string Name { get; set; }
        public string Motto { get; set; }
        public string LeagueType { get; set; }
        public ID Owner { get; set; }
        public List<ID> Members { get; set; }

        public League()
        {
            Members = new List<ID>();
        }
        public League(string name, ID owner)
        {
            Name = name;
            Members = new List<ID>();
            Owner = owner;
        }
        public League(string name, ID owner, List<ID> players) : this(name, owner)
        {
            Members = players;
        }

        public League(string name, ID owner, string lt, string motto, List<ID> players) : this(name, owner, players)
        {
            Motto = motto;
            LeagueType = lt;
        }
    }
}
