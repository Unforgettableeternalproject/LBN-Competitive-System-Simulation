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
            var read = new StreamReader($@"..\..\ExampleIDs\PartnerUserID.json");
            var json = read.ReadToEnd();

            read.Close();
            read.Dispose();

            if (string.IsNullOrEmpty(json.ToString()))
            {
                return false;
            }

            List<ID> IDs = JsonConvert.DeserializeObject<List<ID>>(json);

            return IDs.Any(id => 
                userID.Username == id.Username &&
                userID.Password == id.Password &&
                userID.Email == id.Email);
        }
        private bool reLogin()
        {
            bool success = false;
            LoginForm relogin = new LoginForm("Normal", false);
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
            var read = new StreamReader($@"..\..\ExampleIDs\PartnerUserID.json");
            var json = read.ReadToEnd();

            read.Close();
            read.Dispose();
            var IDList = !string.IsNullOrEmpty(json.ToString()) ? JsonConvert.DeserializeObject<List<ID>>(json) : new List<ID>();
            IDList.Add(userID);

            json = JsonConvert.SerializeObject(IDList);
            var writer = new StreamWriter($@"..\..\ExampleIDs\PartnerUserID.json");
            writer.Write(json);

            writer.Flush();
            writer.Close();
            writer.Dispose();
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
            ds = new DeploymentSubform(userID);
            ds.TopLevel = false;
            ds.FormBorderStyle = FormBorderStyle.None;
            ds.Dock = DockStyle.Fill;
            ps = new ProfitSubform(userID);
            ps.TopLevel = false;
            ps.FormBorderStyle = FormBorderStyle.None;
            ps.Dock = DockStyle.Fill;
            us = new InfoSubform(userID);
            us.TopLevel = false;
            us.FormBorderStyle = FormBorderStyle.None;
            us.Dock = DockStyle.Fill;
            if (newUser) { MessageBox.Show("新用戶請先設定帳戶資訊和配額方式!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); infoInit(); }
            else deployInit();
        }

        private void deployInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ds);
            SubPages.Tag = ds;
            ds.Show();
        }

        private void dashboardInit()
        {
            ps.setStatus(isDeployed, costTotal);
            SubPages.Controls.Clear();
            SubPages.Controls.Add(ps);
            SubPages.Tag = ps;
            ps.Show();
        }

        private void infoInit()
        {
            SubPages.Controls.Clear();
            SubPages.Controls.Add(us);
            SubPages.Tag = us;
            us.Show();
        }
        private void AdvertisementForm_Load(object sender, EventArgs e)
        {
            AdSpot.Show();
            Tick.Start();
            WelcomeMessage.Hide();
            AdvertisementDeploy.Hide();
            Dashboard.Hide();
            PersonalInfo.Hide();
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
            DialogResult result = MessageBox.Show("你確定要離開系統嗎?", "離開系統?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
}
