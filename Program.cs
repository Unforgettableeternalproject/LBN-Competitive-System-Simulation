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
        static readonly List<string> leagues = new List<string>()
        {
            "大美國聯合聯盟",
            "美麗島共和國",
            "你說得隊",
            "完全勝利團隊",
            "啊對對隊",
            "大老鷹隊",
            "王國之淚五百小隊",
            "美麗生活",
            "小人物聯盟",
            "車諾比戰隊",
            "自然聯盟",
            "老二高爾夫協會",
            "血盟騎士團",
            "弒獸之者",
            "風切鬥士",
            "蜂蜜聯盟"
        };
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new AdminMainForm(testCase[0]));
                Application.Run(new PlayerMainForm(testCase[1]));
            //Application.Run(new MainPage());
        }
    }
}
