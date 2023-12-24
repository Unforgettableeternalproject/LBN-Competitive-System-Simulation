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
            var testCase = new ID("Bernie", "123456", "ptyc4076@gmail.com");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdvertisementForm(testCase));
            Application.Run(new MainPage());
        }
    }
}
