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
    /// <summary>
    /// Provides chatroom function for special users.
    /// </summary>
    public partial class ChatroomSubform : Form
    {
        static readonly long currentTime = DateTime.Now.Ticks;
        private int contacts = 0, replyChance = 1500;
        private List<Contact> contactsList = new List<Contact>(6) { null, null, null, null, null, null};
        private Contact currentContact = null;
        private bool isDefault = true, canReply = false;
        private Random random = new Random((int)(currentTime & 0xFFFFFFFF));
        private List<string> replys = new List<string>()
        {
            "瞭解!",
            "明白了",
            "好，我知道了",
            "笑死ww",
            "欸不是...",
            "所以呢?",
            "果不其然嗎...",
            "那你還在幹嘛?",
            "痾...好喔",
            "不予置評",
            "那你也是很認真內",
            "不錯喔~",
            "然後類?",
            "我看，你很勇喔"
        };
        public ChatroomSubform(string user)
        {
            InitializeComponent();
            MsgBox.Enter += MsgBox_Enter;
            MsgBox.Leave += MsgBox_Leave;
            MsgBox.TextChanged += MsgBox_TextChanged;
            MsgBox.KeyDown += Pressed_Key;
            Contact defaultContact = null;
            switch (user)
            {
                case "Admin":
                    defaultContact = new Contact("首席管理員(HA)", new List<string> (){ $"[{DateTime.Now.AddHours(random.Next(-10, -1)*random.NextDouble()).ToShortTimeString()}] 首席管理員(HA): 最近的系統狀況如何?" });
                    break;
                case "Player":
                    defaultContact = new Contact("HX閃電狼", new List<string>() { $"[{DateTime.Now.AddHours(random.Next(-10, -1) * random.NextDouble()).ToShortTimeString()}] HX閃電狼: 欸阿你之前還欠我五百內!" });
                    break;
                case "League Owner":
                    defaultContact = new Contact("系統支援", new List<string>() { $"[{DateTime.Now.AddHours(random.Next(-10, -1) * random.NextDouble()).ToShortTimeString()}] 系統支援: 有什麼我可以幫您的嗎?" });
                    break;
                default:
                    defaultContact = new Contact("伯尼");
                    break;
            }
            addContact(defaultContact);
            currentContact = defaultContact;
            contactsList[0] = currentContact;
        }

        private void ChatroomSubform_Load(object sender, EventArgs e)
        {
            foreach(Control c in Contacts.Controls)
            {
                c.Hide();
            }
            Contact1.Show();
            displayContact();
            ReplyTick.Start();
        }

        public void outerAccess(string name, List<string> messages)
        {
            currentContact = new Contact(name, messages);
            addContact(currentContact);
        }
        private void addContact(Contact contact)
        {
            var skip = 0;
            contacts++;

            if (contacts > 6) goto SkipAddition;

            contactsList[contacts-1] = contact;
            foreach (Control c in Contacts.Controls)
            {
                skip++;
                if (skip == contacts) { c.Show(); c.Text = contact.Name; }
                else continue;
            }

        SkipAddition:
            if (contacts > 6) Etc.Show();
            else Etc.Hide();
            Etc.Text = $"還有 {contacts - 6} 個聯絡人...";
        }

        private void addMessage(string message)
        {
            currentContact.Message.Add($"[{DateTime.Now.ToShortTimeString()}] 您: {message}");
            displayContact();
            MsgBox.Text = string.Empty;
        }

        private void Reply()
        {
            currentContact.Message.Add($"[{DateTime.Now.ToShortTimeString()}] {currentContact.Name}: {replys[random.Next(replys.Count)]}");
            displayContact();
        }
        private void displayContact()
        {
            var contactIndex = contactsList.IndexOf(currentContact);
            Chat.Clear();
            Chat.Lines = currentContact.Message.ToArray();
            Chat.SelectionStart = Chat.Text.Length;
            Chat.ScrollToCaret();
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void MsgBox_Enter(object sender, EventArgs e)
        {
            var prompt = "輸入訊息吧!";
            if (MsgBox.Text == prompt)
            {
                isDefault = false;
                MsgBox.Text = string.Empty;
                MsgBox.ForeColor = SystemColors.ControlText;
            }
        }
        private void MsgBox_Leave(object sender, EventArgs e)
        {
            var prompt = "輸入訊息吧!";
            if (string.IsNullOrEmpty(MsgBox.Text.Trim()))
            {
                isDefault = true;
                MsgBox.Text = prompt;
                MsgBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void MsgBox_TextChanged(object sender, EventArgs e)
        {
            var prompt = "輸入訊息吧!";
            if (MsgBox.Text != prompt) MsgBox.ForeColor = SystemColors.ControlText;
        }
        private void Pressed_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                Send.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            var message = MsgBox.Text.Trim();
            if (string.IsNullOrEmpty(message) || isDefault) { return; }
            addMessage(message);
            canReply = true;
        }

        private void Contact1_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[0];
            displayContact();
        }

        private void Contact2_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[1];
            displayContact();
        }

        private void Contact3_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[2];
            displayContact();
        }

        private void Contact4_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[3];
            displayContact();
        }

        private void Contact5_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[4];
            displayContact();
        }

        private void Contact6_Click(object sender, EventArgs e)
        {
            currentContact = contactsList[5];
            displayContact();
        }
        class Contact
        {
            public string Name { get; set; }
            public List<string> Message { get; set; }

            public Contact(string name)
            {
                string defaultMsg = "\t   ☞歡迎來到聊天室的開端☜\r\n";
                Name = name;
                Message = new List<string>() { defaultMsg };
            }
            public Contact(string name, List<string> message)
            {
                string defaultMsg = "\t   ☞歡迎來到聊天室的開端☜\r\n";
                var msgList = new List<string>() { defaultMsg };
                msgList.AddRange(message);
                Name = name;
                Message = msgList;
            }
        }

        private void ReplyTick_Tick(object sender, EventArgs e)
        {
            if (!canReply) return;
            replyChance -= random.Next(0, 301);
            if(replyChance <= 0) { canReply = false; replyChance = 1500; Reply(); }
        }
    }
}
