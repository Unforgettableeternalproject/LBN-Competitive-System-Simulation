﻿using Newtonsoft.Json;
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
    public partial class DataManagementSubform : Form
    {
        /// <summary>
        /// Provides data management function for the admins.
        /// </summary>
        private int leagueCount = 0, userCount = 0, gameCount = 0, errorCount = 0;
        public DataManagementSubform()
        {
            InitializeComponent();
        }

        private void DataManagementSubForm_Load(object sender, EventArgs e)
        {
            Graph1.Show();
            Graph2.Show();
            btn_Refresh.PerformClick();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            getLeagueCount();
            getUserCount();
            Leagues.Text = $"已註冊聯盟數: {leagueCount}";
            Users.Text = $"已註冊用戶數: {userCount}";
            Games.Text = $"已排程競賽數: {gameCount}";
            FatalError.Text = $"近期重大錯誤數: {errorCount += (random.Next(10) < 3 ? random.Next(5) : 0)}";
        }

        private void getLeagueCount()
        {
            List<League> leagues = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));

            leagueCount = leagues.Count();
        }
        private void getUserCount()
        {
            List<ID> users = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleJSONs\NormalUserID.json"));
            users.AddRange(JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleJSONs\SpecialUserID.json")));

            userCount = users.Count();
        }

        public void getProposals(List<Proposal> input)
        {
            gameCount = input.Count;
        }
    }
}