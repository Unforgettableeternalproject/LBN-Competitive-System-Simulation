using LBN_Competitive_System_Simulation.Forms.Subforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class PlayerMainForm : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private List<Proposal> eventList = new List<Proposal>();
        private readonly ID userID;
        private readonly Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private RecentGamesSubform rg = new RecentGamesSubform();
        private ChatroomSubform chat;
        public PlayerMainForm(ID _userID, bool adminMode = false)
        {
            InitializeComponent();
            userID = _userID;

            if (adminMode) SwitchRole.Text = "返回管理頁面";
            else SwitchRole.Text = "切換使用者...";
        }

        private void PlayerMainForm_Load(object sender, EventArgs e)
        {
            Tick.Start();
            WelcomeMessage.Text = $"好久不見, {userID.Username}\n\n見到你真開心!\n\n今天也要再加把勁喔!";
            Chatroom.Hide();
            ExpandChatroom.Show();
            overallInit();
            RGInit();
        }

        private void overallInit()
        {
            chat = new ChatroomSubform("Player")
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            rg = new RecentGamesSubform()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            rg.Show();
            chat.Show();
            chat.VisibleChanged += Chat_VisibleChanged;
            Chatroom.Controls.Add(chat);
            Chatroom.Tag = "active";
        }

        private void RGInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(rg);
            SubPages.Tag = rg;
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
    }

    public class League
    {
        public string Name;
        public List<ID> Players;

        public League(string name)
        {
            Name = name;
            Players = new List<ID>();
        }
        public League(string name, List<ID> players) : this(name)
        {
            this.Players = players;
        }
    }
}
