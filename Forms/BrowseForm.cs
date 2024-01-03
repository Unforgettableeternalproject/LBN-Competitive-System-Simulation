using AxWMPLib;
using LBN_Competitive_System_Simulation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation
{
    public partial class BrowseForm : Form
    {
        private ID userID;
        private TimeSpan streamTime = new TimeSpan(1, 25, 34);
        private int viewerCount = 238;
        private readonly Random random = new Random();
        private double videoPosition = 0;
        private string Mode = "Browse";
        private Bitmap ad, spad;
        private bool adminMode;

        private readonly List<string> prewrittenMessages = new List<string>
        {
            "猛的",
            "安安，現在是甚麼情況?",
            "幹網路很當",
            "我覺得有料",
            "靠杯，剛剛那是三小",
            "啦啦啦",
            "777777777",
            "CNMBNMSL",
            "這個人看起來很解欸",
            "哪門子的高爾夫球可以跳= =",
            "哈哈笑死",
            "我討厭高爾夫球= =",
            "自己加分，自己加分",
            "有沒有人可以借我一件褲子?",
            "☺☺☺☺☺☺☺☺☺☺☺☺☺",
            "喔是喔真的假的5555555",
            "???????????",
            "急了",
            "0",
            "這不是肯德基",
            "這就是ㄘㄨㄚˋ執政的下場!",
            "猛的內"
        };

        private readonly List<string> demoIDs = new List<string>
        {
            "史丹利123",
            "墊子小男孩",
            "大魚兒",
            "一生的蘿莉擁護者<3",
            "AA潮濕草",
            "洋歌",
            "沒有人喜歡的Lonely",
            "CYY",
            "三哥",
            "約德爾游擊隊"
        };
        public BrowseForm(ID _userID, bool _adminMode = false)
        {
            InitializeComponent();
            browseInit();
            userID = _userID;
            adminMode = _adminMode;
            if (userID.Username != "Anonymous") WelcomeMessage.Text = $"歡迎回來, {userID.Username}!\n\n今天想要觀看甚麼賽事?";
            else WelcomeMessage.Text = "您現在是以訪客身分登入\n\n匿名用戶無法使用釘選等功能\n\n，但仍然可以進行聊天!";

            if (adminMode) SwitchRole.Text = "返回管理頁面";
            else SwitchRole.Text = "切換使用者...";
        }
        private void UpdateUI()
        {
            // Update labels with the current stream time and viewer count
            StreamTime.Text = $"{streamTime:hh\\:mm\\:ss}";
            ViewersCount.Text = $"{viewerCount}";
        }
        private void AddMessage(string message, string user)
        {
            ChatMessage.AppendText($"[❦] {user}: {message}\n");
            ChatMessage.SelectionStart = ChatMessage.Text.Length;
            ChatMessage.ScrollToCaret(); // Scroll to the end to show the latest messages
        }

        private void advertiseInit()
        {
            Mode = "Redirect";
            this.BackgroundImage = Properties.Resources.Empty;
            AdSpot2.Hide();
            AdSpot3.Hide();
            RedirectSpinner.Show();
            btn_return.Hide();
            btn_send.Hide();
            ChatMessage.Hide();
            ChatTextbox.Hide();
            StreamTime.Hide();
            ViewersCount.Hide();
            WelcomeMessage.Hide();
            ExampleVideo.Hide();
            SwitchRole.Hide();
            Stream.Ctlcontrols.stop();
            timerStream.Stop();
            Stream.Hide();
            Home.Hide();
            Contact.Enabled = false;
            Exit.Enabled = false;
            redirectTimer.Start();
        }
        private void browseInit()
        {
            Mode = "Browse";
            this.BackgroundImage = Properties.Resources.Browse;
            WelcomeMessage.Show();
            Exit.Show();
            Contact.Show();
            SwitchRole.Show();
            ExampleVideo.Show();
            AdSpot2.Show();
            AdSpot3.Hide();
            btn_return.Hide();
            btn_send.Hide();
            ChatMessage.Hide();
            ChatTextbox.Hide();
            StreamTime.Hide();
            ViewersCount.Hide();
            Stream.Ctlcontrols.stop();
            Home.Hide();
            timerStream.Stop();
            Stream.Hide();
        }

        private void streamInit()
        {
            Mode = "Stream";
            this.BackgroundImage = Properties.Resources.Stream;
            WelcomeMessage.Hide();
            ExampleVideo.Hide();
            SwitchRole.Hide();
            AdSpot2.Hide();
            AdSpot3.Show();
            btn_return.Show();
            btn_send.Show();
            ChatMessage.Show();
            Home.Show();
            ChatMessage.Enabled = false;
            ChatTextbox.Show();
            StreamTime.Show();
            ViewersCount.Show();
            Stream.Show();
            UpdateUI();
            timerStream.Start();
            Stream.Ctlcontrols.play();
            Stream.Ctlcontrols.currentPosition = videoPosition;
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            AdSpot1.Show();
            RedirectSpinner.Hide();
            Stream.uiMode = "None";
            Stream.settings.autoStart = false;
            Stream.URL = Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Demo.mp4"));
            Stream.settings.setMode("loop", false);
            ChatMessage.Enter += (s, args) => { this.ActiveControl = null; };
            ChatTextbox.KeyDown += this.Pressed_Key;
            toolTip.SetToolTip(btn_return, "返回上一頁");
            toolTip.SetToolTip(Home, "返回主瀏覽介面");
        }

        private void ExampleVideo_Click(object sender, EventArgs e)
        {
            streamInit();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            videoPosition = Stream.Ctlcontrols.currentPosition;
            browseInit();
        }

        private void timerStream_Tick(object sender, EventArgs e)
        {
            // Simulate streaming time increase every second
            streamTime = streamTime.Add(TimeSpan.FromSeconds(1));

            // Simulate viewer count fluctuations
            viewerCount += random.Next(-5, 6); // Random increase/decrease between -5 and 5

            string randomMessage = prewrittenMessages[random.Next(prewrittenMessages.Count)];
            if(random.Next(1,6) == 2) AddMessage(randomMessage, demoIDs[random.Next(demoIDs.Count)]);

            UpdateUI();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string userMessage = ChatTextbox.Text;
            if (!string.IsNullOrWhiteSpace(userMessage))
            {
                AddMessage(userMessage, userID.Username);
                ChatTextbox.Clear(); // Clear the input textbox
            }
        }
        private void Pressed_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Mode == "Stream")
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                btn_send.PerformClick(); // Simulate a click on the Send Message button
            }
        }

        private void SwitchRole_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void Contact_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ContactForm cf = new ContactForm(userID, !adminMode);
            cf.FormClosed += ContactForm_FormClosed;
            cf.ShowDialog();

            if (cf.getRedirect()) advertiseInit();
            cf.Dispose();
        }

        private void ContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            btn_return.PerformClick();
        }

        private void redirectTimer_Tick(object sender, EventArgs e)
        {
            redirectTimer.Stop();
            this.Hide();
            AdvertisementForm af = new AdvertisementForm(userID, spad);
            var _return = af.ShowDialog();

            if (_return == DialogResult.OK) 
            {
                if (af.IsDeployed)
                {
                    ad = (Bitmap)af.AdImage[0];
                    switch ((string)af.AdImage[1])
                    {
                        case "左側工作欄下方":
                            AdSpot1.Image = ad;
                            spad = ad;
                            break;
                        case "主要瀏覽頁面中右側":
                            AdSpot2.Image = ad;
                            break;
                        case "實況頁面下方":
                            AdSpot3.Image = ad;
                            break;
                    }
                }
                userID = af.UserID;
                WelcomeMessage.Text = $"歡迎回來, {userID.Username}!\n\n今天想要觀看甚麼賽事?";
                this.Show();  
                browseInit(); 
            }
            Contact.Enabled = true;
            Exit.Enabled = true;
            RedirectSpinner.Hide();
            af.Dispose();
        }
    }
}
