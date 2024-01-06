using LBN_Competitive_System_Simulation.Forms;
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region ForTestAndDebug
            //var testCase = new List<ID>()
            //{
            //    new ID("Bernie", "123456", "ptyc4076@gmail.com", "Admin", "bcd2611f-a230-41e6-bd31-f4eac0d98cb5"),
            //    new ID("Berniee", "122334", "ptyc4076@gmail.com", "League Owner", "a4df083d-dd7b-4d6e-81b0-2686d24acc64"),
            //};
            //var testLeague = new League("測試聯盟", testCase[1], "休閒型聯盟", "測試", new List<ID>()
            //{
            //    testCase[1],
            //    new ID("Joja", "OOPP", "ligk@gmail.com", "Player"),
            //    new ID("Coca", "Kilpw", "JOgaot@gmail.com", "Player"),
            //    new ID("Celena", "Yes123", "GoodHi@gmail.com", "Player")
            //});
            //Application.Run(new AdminMainForm(testCase[0]));
            //Application.Run(new PlayerMainForm(testCase[1]));
            //Application.Run(new LeagueMainForm(testCase[1], Properties.Resources.LeagueLogo_5, testLeague));
            #endregion

            try
            {
                Application.Run(new MainPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
