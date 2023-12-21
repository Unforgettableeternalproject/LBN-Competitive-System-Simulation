using AxWMPLib;
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

namespace LBN_Competitive_System_Simulation
{
    public partial class BrowseForm : Form
    {
        private ID userID;
        private TimeSpan streamTime = new TimeSpan(1, 25, 34);
        private int viewerCount = 238;
        private Random random = new Random();
        private double videoPosition = 0;
        private string Mode = "Browse";

        private List<string> prewrittenMessages = new List<string>
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
            "現在購買SurfShark VPN再享五折優惠!!",
            "哈哈笑死",
            "我討厭高爾夫球= =",
            "自己加分，自己加分",
            "有沒有人可以借我一件褲子?",
            "☺☺☺☺☺☺☺☺☺☺☺☺☺",
            "喔是喔5555555"
        };

        private List<string> demoIDs = new List<string>
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
        private void UpdateUI()
        {
            // Update labels with the current stream time and viewer count
            StreamTime.Text = $"{streamTime.ToString(@"hh\:mm\:ss")}";
            ViewersCount.Text = $"{viewerCount}";
        }
        private void AddMessage(string message, string user)
        {
            ChatMessage.AppendText($"[❦] {user}: {message}\n");
            ChatMessage.ScrollToCaret(); // Scroll to the end to show the latest messages
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
            btn_return.Hide();
            btn_send.Hide();
            ChatMessage.Hide();
            ChatTextbox.Hide();
            StreamTime.Hide();
            ViewersCount.Hide();
            Console.WriteLine("Pos: {0}", videoPosition);
            Stream.Ctlcontrols.stop();
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
            btn_return.Show();
            btn_send.Show();
            ChatMessage.Show();
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
        public BrowseForm(ID userID)
        {
            InitializeComponent();
            browseInit();
            this.userID = userID;
            if (userID.Username != "Anonymous") WelcomeMessage.Text = $"歡迎回來, {userID.Username}!\n\n今天想要觀看甚麼賽事?";
            else WelcomeMessage.Text = "您現在是以訪客身分登入\n\n匿名用戶無法使用釘選等功能\n\n，但仍然可以進行聊天!";
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            Stream.uiMode = "None";
            Stream.settings.autoStart = false;
            Stream.URL = Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Demo.mp4"));
            Stream.settings.setMode("loop", false);
            ChatMessage.Enter += (s, args) => { this.ActiveControl = null; };
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
            DialogResult result = MessageBox.Show("你確定要離開系統嗎?", "離開系統?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ContactForm cf = new ContactForm(userID);
            cf.FormClosed += ContactForm_FormClosed;
            cf.ShowDialog();
            cf.Dispose();
        }

        private void ContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
