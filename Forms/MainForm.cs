using LBN_Competitive_System_Simulation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LBN_Competitive_System_Simulation
{
    public partial class MainPage : Form
    {
        static int intro = 0;
        private int counter = 3;
        ID userID = null;
        string userName;
        public MainPage()
        {
            InitializeComponent();
            intro = 0;
            Introduction.BackColor = Color.Transparent;
            Introduction.Image = Properties.Resources.Disclaimer;
            Ball.BackColor = Color.Transparent;
            btn_confirm.BackgroundImage = Properties.Resources.btn_Confirm;
            LoadingSpinner.Hide();
            WelcomeDisplay.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (intro)
            {
                case 0:
                    Introduction.Image = Properties.Resources.Introduction;
                    intro++;
                    break;
                case 1:
                    Introduction.Image = Properties.Resources.Property;
                    intro++;
                    break;
                case 2:
                    Introduction.Hide();
                    WelcomeDisplay.Hide();
                    btn_confirm.BackgroundImage = Properties.Resources.btn_Enter;
                    var login = new LoginForm(true);

                    LoadingSpinner.Show();
                    var result = login.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        counter = 3;
                        MessageBox.Show("登入成功!!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userID = login.returnID();
                        userName = userID.Username != "Anonymous" ? userID.Username : "匿名訪客";
                        RedirectingTimer.Enabled = true;
                        RedirectingTimer.Start();

                        btn_confirm.Hide();
                        updateMessage();
                        WelcomeDisplay.Show();
                    }
                    else
                    {
                        WelcomeDisplay.ForeColor = Color.FromArgb(145, 204, 161);
                        MessageBox.Show("登入失敗!", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        WelcomeDisplay.Text = "登入程序出現錯誤，請重新嘗試!";
                        WelcomeDisplay.Show();
                    }

                    login.Dispose();
                    LoadingSpinner.Hide();

                    break;
                default:
                    break;
            }
        }

        private void updateMessage()
        {
            switch (userID.Role)
            {
                case "Normal":
                    WelcomeDisplay.ForeColor = Color.FromArgb(145, 204, 161);
                    WelcomeDisplay.Text = $"歡迎, {userName}!\r\n將在{counter}秒後自動跳轉至瀏覽頁面...";
                    break;
                case "Admin":
                    WelcomeDisplay.ForeColor = Color.FromArgb(180, 89, 85);
                    WelcomeDisplay.Text = $"今天過得好嗎, {userName}?\r\n將在{counter}秒後自動跳轉至管理頁面...";
                    break;
                case "Player":
                    WelcomeDisplay.ForeColor = Color.FromArgb(85, 114, 180);
                    WelcomeDisplay.Text = $"歡迎回來, {userName}!\r\n將在{counter}秒後自動跳轉至儀表板...";
                    break;
            }
        }

        private void RedirectingTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            updateMessage();
            if (counter == 0) 
            {
                RedirectingTimer.Stop();
                WelcomeDisplay.Hide();
                Form redirect = null;
                switch (userID.Role)
                {
                    case "Normal":
                        redirect = new BrowseForm(userID);
                        break;
                    case "Admin":
                        redirect = new AdminMainForm(userID);
                        break;
                    case "Player":
                        redirect = new PlayerMainForm(userID);
                        break;
                }
                
                this.Hide();
                if (redirect.ShowDialog() == DialogResult.OK)
                {
                    redirect.Dispose();
                    this.Show();
                    btn_confirm.Show();
                    btn_confirm.PerformClick();
                }
            }
        }

        private void WelcomeDisplay_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("欸? 您找到了隱藏小彩蛋!", "恭喜!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Introduction_Click(object sender, EventArgs e)
        {

        }
    }
}
