﻿using LBN_Competitive_System_Simulation.Forms.Subforms;
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
    public partial class LeagueMainForm : Form
    {
        private ID userID;
        private Bitmap logo;
        private League league;
        private LeagueOverviewSubform lo;
        private ChatroomSubform chat;
        public Bitmap Logo => logo;
        public League League => league;
        public LeagueMainForm(ID _userID, Bitmap _logo, League _league)
        {
            InitializeComponent();
            userID = _userID;
            logo = _logo;
            league = _league;
            LeagueLogo.Image = logo;
        }
        private void LeagueMainForm_Load(object sender, EventArgs e)
        {
            Tick.Start();
            WelcomeMessage.Text = $"這裡是聯盟的後台\n\n只有你能看到\n\n這裡所做的更動";
            Chatroom.Hide();
            ExpandChatroom.Show();
            overallInit();
            LOInit();
        }
        private void overallInit()
        {
            chat = new ChatroomSubform("League Owner")
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            lo = new LeagueOverviewSubform(league, logo)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            
            lo.Show();
            chat.Show();
            chat.VisibleChanged += Chat_VisibleChanged;
            Chatroom.Controls.Add(chat);
            Chatroom.Tag = "active";
        }

        private void LOInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(lo);
            SubPages.Tag = lo;
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

        private void Return_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
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

        private void LeagueOverview_Click(object sender, EventArgs e)
        {
            LOInit();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            logo = lo.Logo;
            league = lo.League;
            LeagueLogo.Image = logo;
        }
    }
}
