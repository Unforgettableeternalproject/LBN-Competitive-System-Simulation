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
    public partial class AdminMainForm : Form
    {
        private ID userID;
        private readonly Random random = new Random();
        private int people = 0;
        private UserManagementSubForm um;
        public AdminMainForm(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            Tick.Start();
            people = random.Next(250);
            Chatroom.Hide();
            ExpandChatroom.Show();
            WelcomeMessage.Text = $"歡迎回來, {userID.Username}\n\n今天過得如何?\n\n希望一切都還順利!";
            OnlineCount.Text = $"{people} 人";
            overallInit();
            UMInit();
        }

        private void overallInit()
        {
            um = new UserManagementSubForm(userID);
            um.TopLevel = false;
            um.Dock = DockStyle.Fill;
        }
        private void UMInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(um);
            SubPages.Tag = um;
            um.Show();
        }

        private void GPInit()
        {

        }

        private void GMInit()
        {

        }

        private void SLInit()
        {

        }

        private void CInit()
        {

        }
        private void ViewAsPlayer_Click(object sender, EventArgs e)
        {

        }
        private void ViewAsGuest_Click(object sender, EventArgs e)
        {

        }
        private void UserManagement_Click(object sender, EventArgs e)
        {
            UMInit();
        }
        private void GameProposal_Click(object sender, EventArgs e)
        {
            GPInit();
        }
        private void DataManagement_Click(object sender, EventArgs e)
        {
            GMInit();
        }
        private void SystemLog_Click(object sender, EventArgs e)
        {
            SLInit();
        }
        private void Calendar_Click(object sender, EventArgs e)
        {
            CInit();
        }
        private void SwitchRole_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            UserManagement.PerformClick();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            people += random.Next(-7, 10);
            OnlineCount.Text = $"{people} 人";
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

        private void SubPages_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnlineCount_Click(object sender, EventArgs e)
        {

        }
    }
}
