using LBN_Competitive_System_Simulation.Forms;
using System;
using System.Collections.Generic;
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
            var testCase = new ID("Berniee", "122334", "ptyc4076@gmail.com", "Admin", "a4df083d-dd7b-4d6e-81b0-2686d24acc64");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new AdminMainForm(testCase));
            Application.Run(new PlayerMainForm(testCase));
            //    Application.Run(new MainPage());
        }
    }
}
