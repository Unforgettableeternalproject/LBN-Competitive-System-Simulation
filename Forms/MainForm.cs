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
            Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Disclaimer;
            Ball.BackColor = Color.Transparent;
            btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
            LoadingSpinner.Hide();
            WelcomeDisplay.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (intro)
            {
                case 0:
                    Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Introduction;
                      intro++;
                    break;
                case 1:
                    Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Property;
                    intro++;
                    break;
                case 2:
                    Introduction.Hide();
                    WelcomeDisplay.Hide();
                    btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Enter;
                    var next = new LoginForm();

                    LoadingSpinner.Show();
                    if (next.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("登入成功!!");
                        userID = next.returnID();
                        userName = userID.Username != "Anonymous" ? userID.Username : "匿名訪客";
                        RedirectingTimer.Enabled = true;
                        RedirectingTimer.Start();

                        btn_confirm.Hide();
                        WelcomeDisplay.Text = $"歡迎, {userName}!\r\n將在{counter}秒後自動跳轉至瀏覽頁面...";
                        WelcomeDisplay.Show();
                    }
                    else 
                    {
                        MessageBox.Show("登入失敗!");
                        WelcomeDisplay.Text = $"登入程序出現錯誤，請重新嘗試!";
                        WelcomeDisplay.Show();
                    } 

                    next.Dispose();
                    LoadingSpinner.Hide();

                    break;
                default:
                    break;
            }
        }

        private void Introduction_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

        private void RedirectingTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0) 
            {
                RedirectingTimer.Stop();
                WelcomeDisplay.Hide();
                var redirect = new BrowseForm(userID); //Will change depending on user-type, but that's for later
                redirect.Show();
                this.Hide();
            }
            WelcomeDisplay.Text = $"歡迎, {userName}!\r\n將在{counter}秒後自動跳轉至瀏覽頁面...";
        }

        private void WelcomeDisplay_Click_1(object sender, EventArgs e)
        {

        }
    }
}
