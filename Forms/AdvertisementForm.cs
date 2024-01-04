using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class AdvertisementForm : Form
    {
        private ID userID;
        private bool isDeployed, newUser = false;
        private DeploymentSubform ds;
        private ProfitSubform ps;
        private InfoSubform us;
        private double costTotal = 0;
        private object[] adImage = null;
        public ID UserID
        {
            get { return userID; }
        }
        public bool IsDeployed
        {
            get { return isDeployed; }
        }
        public object[] AdImage
        {
            get { return adImage; }
        }
        public AdvertisementForm(ID _userID, Bitmap ad)
        {
            userID = _userID;
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Advertise_Front;
            if(ad != null) AdSpot.Image = ad;
            btn_enter.Show();
            AdSpot.Show();
            Hint.Show();
            Hint.Text = "";
        }

        private bool isExist(ID userID)
        {
            var IDs= JsonConvert.DeserializeObject<List<PartnerID>>(File.ReadAllText(@"..\..\ExampleJSONs\PartnerUserID.json"));

            if (IDs.Count == 0)
            {
                return false;
            }


            return IDs.Any(id => userID.UUID == id.UUID);
        }
        private bool reLogin()
        {
            bool success = false;
            LoginForm relogin = new LoginForm(false);
            var result = relogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("登入成功!!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userID = relogin.returnID();
                success = true;
            }
            else
            {
                MessageBox.Show("登入失敗!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            relogin.Dispose();
            return success;
        }

        private void register(ID userID)
        {
            var IDList = JsonConvert.DeserializeObject<List<PartnerID>>(File.ReadAllText(@"..\..\ExampleJSONs\PartnerUserID.json"));
            IDList.Add(new PartnerID(userID));

            string json = JsonConvert.SerializeObject(IDList, Formatting.Indented);
            File.WriteAllText(@"..\..\ExampleJSONs\PartnerUserID.json", json);
        }
        private void overallInit() 
        {
            this.BackgroundImage = Properties.Resources.Advertise_Base;
            btn_enter.Hide();
            AdSpot.Hide();
            Hint.Hide();
            WelcomeMessage.Show();
            AdvertisementDeploy.Show();
            Dashboard.Show();
            PersonalInfo.Show();
            WelcomeMessage.Text = $"歡迎回來, {userID.Username}\n\n今天過得如何?";
            ds = new DeploymentSubform(userID)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            ps = new ProfitSubform(userID)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            us = new InfoSubform(userID)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            ds.Show();
            ps.Show();
            us.Show();
            if (newUser) { MessageBox.Show("新用戶請先設定帳戶資訊和配額方式!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); infoInit(); }
            else deployInit();
        }

        private void deployInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ds);
            SubPages.Tag = ds;
        }

        private void dashboardInit()
        {
            ps.setStatus(isDeployed, costTotal);
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ps);
            SubPages.Tag = ps;
        }

        private void infoInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(us);
            SubPages.Tag = us;
        }
        private void AdvertisementForm_Load(object sender, EventArgs e)
        {
            AdSpot.Show();
            Tick.Start();
            WelcomeMessage.Hide();
            AdvertisementDeploy.Hide();
            Dashboard.Hide();
            PersonalInfo.Hide();
            toolTip.SetToolTip(Home, "返回主瀏覽介面");
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            bool proceed = false, successfulLogin = true;

            if (userID.Username == "Anonymous") { Hint.Text = "請先登入一個現有的帳戶";  successfulLogin = reLogin();}

            if (!successfulLogin) goto SkipAccountCreation;

            if (isExist(userID)) { proceed = true; }
            else
            {
                var createNew = MessageBox.Show("將以現有帳號加入合作夥伴計畫，是否繼續?", "資訊", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (createNew == DialogResult.Yes)
                {
                    register(userID);
                    proceed = true;
                    newUser = true;
                }
                else proceed = false;
            }

            SkipAccountCreation:
            if (proceed) { overallInit();}
            else { Hint.ForeColor = Color.Tomato; Hint.Text = "請先登入一個現有的帳戶!!"; }
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

        private void Home_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if(ds != null) ds.Dispose();
            if(ps != null) ps.Dispose();
            if (us != null) us.Dispose();
            Close();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ContactForm cf = new ContactForm(userID, false);
            cf.FormClosed += ContactForm_FormClosed;
            cf.ShowDialog();
            cf.Dispose();
        }

        private void ContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        private void AdvertisementDeploy_Click(object sender, EventArgs e)
        {
            deployInit();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            dashboardInit();
        }

        private void PersonalInfo_Click(object sender, EventArgs e)
        {
            infoInit();
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            if (ds != null) { isDeployed = ds.IsDeployed; adImage = ds.Image; costTotal = ds.Total; } 
        }
    }
    public class PartnerID : ID
    {
        public string Account { get; set; }
        public string Quota { get; set; }
        public string Notify { get; set; }

        public PartnerID()
        {

        }

        public PartnerID(ID baseID) : base(baseID.Username, baseID.Password, baseID.Email, baseID.Role, baseID.UUID)
        {
            Account = "";
            Quota = "";
            Notify = "False";
        }

        public PartnerID(ID baseID, string account, string quota, string notify) : base(baseID.Username, baseID.Password, baseID.Email, baseID.Role, baseID.UUID)
        {
            Account = account;
            Quota = quota;
            Notify = notify;
        }
        public PartnerID(string username, string password, string email, string role, string uUID) : base(username, password, email, role, uUID)
        {
            Account = "";
            Quota = "";
            Notify = "False";
        }
    }
}
