﻿using LBN_Competitive_System_Simulation.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("zh-TW");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            var testCase = new List<ID>()
            {
                new ID("Bernie", "123456", "ptyc4076@gmail.com", "Admin", "bcd2611f-a230-41e6-bd31-f4eac0d98cb5"),
                new ID("Berniee", "122334", "ptyc4076@gmail.com", "League Owner", "a4df083d-dd7b-4d6e-81b0-2686d24acc64"),
            };
            var testLeague = new League("測試聯盟", testCase[1]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new AdminMainForm(testCase[0]));
            //  Application.Run(new PlayerMainForm(testCase[1]));
            Application.Run(new LeagueMainForm(null, testLeague));
            try
            {
             //   Application.Run(new MainPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
