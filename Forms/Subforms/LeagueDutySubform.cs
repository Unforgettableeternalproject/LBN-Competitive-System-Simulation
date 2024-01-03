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
        private bool inLeague;
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
        public LeagueDutySubform(ID _userID, ChatroomSubform _chat)
        {
            InitializeComponent();
            userID = _userID;
            chat = _chat;
            inLeague = fetchLeague();
        }

        private void LeagueDutySubform_Load(object sender, EventArgs e)
        {
            if (inLeague) 
            { 
                InLeague.Show(); 
                OutLeague.Hide();
                WelcomeMessage.Text = $"歡迎回到{affiliatedLeague.Name}!";
                FavorText.Text = "座右銘: " + affiliatedLeague.Motto;
                LeagueType.Text = "聯盟類型: " + affiliatedLeague.LeagueType;
                Rankings.Text = "本周排名: 第 " + random.Next(1, leagueList.Count).ToString() + " 名";
                Logo.Image = logos[random.Next(logos.Count)];
                int index1 = random.Next(feed.Count), index2;
                FeedMsg1.Text = feed[index1];
                ExtendDescription.SetToolTip(FeedMsg1, feed[index1]);

                do { index2 = random.Next(feed.Count); } while (index2 == index1);

                FeedMsg2.Text = feed[index2];
                ExtendDescription.SetToolTip(FeedMsg2, feed[index2]);
                updateMember();

                if(userID.UUID == affiliatedLeague.Owner.UUID)
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
            }
            else { OutLeague.Show(); InLeague.Hide(); }
        }
        private bool fetchLeague()
        {
            bool result = false;
            leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            foreach (League league in leagueList)
            {
                if (league.Members.Any(e => e.UUID == userID.UUID)) { result = true; affiliatedLeague = league; }
            }
            return result;
        }

        private void updateMember()
        {
            List<string> display = new List<string>() { "聯盟所有者:", "⚜︎" + affiliatedLeague.Owner.Username, "------------------\n成員:"};
            foreach(ID member in affiliatedLeague.Members)
            {
                if(member.UUID != affiliatedLeague.Owner.UUID) display.Add("❣︎" + member.Username);
            }

            Members.Lines = display.ToArray();
        }
    }
}
