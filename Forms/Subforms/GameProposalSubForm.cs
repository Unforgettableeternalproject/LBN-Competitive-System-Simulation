﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class GameProposalSubForm : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;

        // Use the current time as the seed for the random number generator
        private List<Proposal> proposals = new List<Proposal>(), acceptedProposals = new List<Proposal>();
        private List<string> leagues = new List<string>()
        {
            "大美國聯合聯盟",
            "美麗島共和國",
            "你說得隊",
            "完全勝利團隊",
            "啊對對隊",
            "大老鷹隊",
            "王國之淚五百小隊"
        },
                             gameType = new List<string>()
        {
            "友誼賽",
            "邀請賽",
            "錦標賽",
            "聯盟賽",
            "猴友誼賽"
        },
                             gameFormat = new List<string>()
                             {
                                 "單淘汰賽制",
                                 "雙淘汰賽制",
                                 "小組賽制",
                                 "圓桌賽制",
                                 "混合團體賽制",
                                 "速度賽制"
                             };
        private Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private bool hasProposal = false;
        private Proposal activeProposal = null;
        private int delayTime = 0;
        public List<Proposal> AcceptedProposals
        {
            get { return acceptedProposals; }
        }
        public GameProposalSubForm()
        {
            InitializeComponent();
        }
        private void DoNothing()
        {
            ;
        }
        private void HideAndClear()
        {
            hasProposal = false;
            FromLeague.Text = "";
            DateNType.Text = "";
            FormatNPeriod.Text = "";
            Request.Hide();
            Control.Hide();

            if(proposals.Count == 0)
            {
                NotifyText.Text = $"目前沒有新的賽事請求!";
                NotifyText.Show();
            }
        }
        private void ShowAndDeploy()
        {
            if (hasProposal) goto SkipDeploying;

            hasProposal = true;
            activeProposal = proposals.First();
            FromLeague.Text = $"來自 {activeProposal.LeagueName}";
            DateNType.Text = $"希望於 {activeProposal.Date} 舉辦 {activeProposal.GameType}";
            FormatNPeriod.Text = $"使用 {activeProposal.GameFormat}，為期 {activeProposal.DurationDays} 天";
            Request.Show();
            Control.Show();
            proposals.Remove(activeProposal);

            SkipDeploying:
            if (proposals.Count > 0)
            {
                NotifyText.Text = $"還有 {proposals.Count} 個其他的請求...";
                NotifyText.Show();
            }
            else if (proposals.Count == 0) NotifyText.Hide();
        }
        private Proposal GenerateRandomProposal()
        {
            // Implement logic to generate a random proposal
            // (For simplicity, you can create a new Proposal with random data)
            return new Proposal
            {
                LeagueName = leagues[random.Next(leagues.Count)],
                Date = DateTime.Now.AddDays(random.Next(30)),
                GameType = gameType[random.Next(gameType.Count)],
                GameFormat = gameFormat[random.Next(gameFormat.Count)],
                DurationDays = random.Next(5, 15)
            };
        }

        private void Proposal_Tick_Tick(object sender, EventArgs e)
        {
            if(delayTime > 0) { delayTime--; goto SkipCreation; }
            if (random.Next(20) == 1) { proposals.Add(GenerateRandomProposal()); delayTime = 5; }

            SkipCreation:
            if (proposals.Count > 0) ShowAndDeploy();
            else if(!hasProposal) HideAndClear();
        }

        private void ContactLO_Click(object sender, EventArgs e)
        {
            //This is to be added
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已婉拒比賽的請求，並已告知聯盟所有人!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            activeProposal = null;
            HideAndClear();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已准許比賽，並加入至公開時程表!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            acceptedProposals.Add(activeProposal);
            activeProposal = null;
            HideAndClear();
        }

        private void GameProposalSubForm_Load(object sender, EventArgs e)
        {
            Request.Hide();
            Control.Hide();
            HideAndClear();
            Proposal_Tick.Start();
        }
    }
    public class Proposal
    {
        public string LeagueName { get; set; }
        public DateTime Date { get; set; }
        public string GameType { get; set; }
        public string GameFormat { get; set; }
        public int DurationDays { get; set; }
    }
}
