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
        public AdvertisementForm(ID _userID)
        {
            userID = _userID;
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Advertise_Front;
            btn_enter.Show();
            Hint.Show();
            Hint.Text = "";
        }

        private bool isExist(ID userID)
        {
            var read = new StreamReader($@"..\..\ExampleIDs\PartnerUserID.json");
            var json = read.ReadToEnd();

            if (string.IsNullOrEmpty(json.ToString()))
            {
                read.Close();
                read.Dispose();
                return false;
            }

            dynamic IDs = JsonConvert.DeserializeObject(json);
            foreach (var id in IDs)
            {
                if (userID.Username == id.Username.ToString() && userID.Password == id.Password.ToString() && userID.Email == id.Email.ToString()) //I know this is dumb but I don't know otherwise
                {
                    read.Close();
                    read.Dispose();
                    return true;
                }
            }

            read.Close();
            read.Dispose();
            return false;
        }
        private bool reLogin()
        {
            bool proceed = false;
            LoginForm relogin = new LoginForm("Normal", false);
            var result = relogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("登入成功!!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userID = relogin.returnID();
                proceed = true;
            }
            else
            {
                MessageBox.Show("登入失敗!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            relogin.Dispose();
            return proceed;
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
            Hint.Hide();
            WelcomeMessage.Show();
            AdvertisementDeploy.Show();
            Daskboard.Show();
            PersonalInfo.Show();
            WelcomeMessage.Text = $"歡迎回來, {userID.Username}\n\n今天過得如何?";
        }

        private void deployInit()
        {
            DeploymentSubform ds = new DeploymentSubform(userID);
            ds.TopLevel = false;
            ds.FormBorderStyle = FormBorderStyle.None;
            ds.Dock = DockStyle.Fill;
            SubPages.Controls.Add(ds);
            SubPages.Tag = ds;
            ds.Show();
        }

        private void AdvertisementForm_Load(object sender, EventArgs e)
        {
            WelcomeMessage.Hide();
            AdvertisementDeploy.Hide();
            Daskboard.Hide();
            PersonalInfo.Hide();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            bool proceed;

            if (userID.Username == "Anonymous") { Hint.Text = "請先登入一個現有的帳戶";  proceed = reLogin(); goto SkipAccountCreation; }

            if (isExist(userID)) { proceed = true; }
            else
            {
                var createNew = MessageBox.Show("將以現有帳號加入合作夥伴計畫，是否繼續?", "資訊", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (createNew == DialogResult.Yes)
                {
                    register(userID);
                    proceed = true;
                }
                else proceed = false;
            }

        SkipAccountCreation:
            if (proceed) { overallInit(); deployInit(); }
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
    }
}
