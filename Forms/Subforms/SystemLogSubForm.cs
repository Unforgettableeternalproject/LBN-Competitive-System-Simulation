using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class SystemLogSubForm : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private List<string> log = new List<string>()
        {
            "LBN 競技賽事系統 系統紀錄",
            "   ",
            "正在初始化..."
        }, randomLog = new List<string>()
        {
            "系統一切正常",
            "直播介面穩定運作中",
            "瀏覽介面穩定運作中",
            "合作夥伴後台介面穩定運作中",
            "玩家儀表板介面穩定運作中",
            "聯盟所有人儀表板介面穩定運作中",
            "註冊程序正常",
            "偵測到不明網路流量，正在查明緣由",
            "處理傳輸資訊當中...等待網路",
            "偵測到不明攻擊嘗試，正在查明緣由"
        };
        private Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private int loadtime = 3;
        public SystemLogSubForm()
        {
            InitializeComponent();
        }

        private void SystemLogSubForm_Load(object sender, EventArgs e)
        {
            ClearLog.Show();
            CopytoClipBoard.Show();
            SLWindow.Show();
            SLWindow.Enabled = false;
            SLWindow.Clear();
            SLWindow.Lines = log.ToArray();
            SLWindow.SelectionStart = SLWindow.Text.Length;
            SLWindow.ScrollToCaret();
            Tick.Start();
        }

        private void updateLog()
        {
            SLWindow.Clear();
            SLWindow.Lines = log.ToArray();
            SLWindow.SelectionStart = SLWindow.Text.Length;
            SLWindow.ScrollToCaret();
        }
        private void addLog()
        {
            log.Add($"[{DateTime.Now.ToLocalTime()}]: {randomLog[random.Next(randomLog.Count)]}");
        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("將會清除所有系統紀錄，確認嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                log = new List<string>() { "LBN 競技賽事系統 系統紀錄", "   " };
                updateLog();
                MessageBox.Show("已清除系統紀錄!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if(loadtime > 0) { loadtime--; return; }
            if (log.Any(s => s == "正在初始化...")) log.Remove("正在初始化...");

            if (random.Next(120) > 84) { addLog(); updateLog(); loadtime = 3; }

        }

        private void CopytoClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SLWindow.Text);
            MessageBox.Show("已複製至剪貼簿!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
