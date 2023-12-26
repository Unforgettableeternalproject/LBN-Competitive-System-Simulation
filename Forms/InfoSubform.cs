using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class InfoSubform : Form
    {
        private ID userID;
        private readonly dynamic[] defaults = new dynamic[] { "尚未填寫帳戶資訊", "尚未選擇", false };
        private dynamic[] userInfo = new dynamic[3];
        private bool[] buttonStatus = new bool[] { false, false };
        public InfoSubform(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
            AccountChange.KeyDown += Pressed_Key_1;
            QuotaChange.KeyDown += Pressed_Key_2;
        }

        private void InfoSubform_Load(object sender, EventArgs e)
        {
            UserTag.Text = $"{userID.Username}";
            Account.Text = defaults[0]; Account.ForeColor = Color.Firebrick;
            Quota.Text = defaults[1]; Quota.ForeColor = Color.Firebrick;
            Notify.Checked = defaults[2];
            AccountChange.Hide();
            QuotaChange.Hide();
        }

        private void btn_acc_change_Click(object sender, EventArgs e)
        {
            bool isInitial = userInfo[0] == null ? true : false;

            if(!isInitial && !buttonStatus[0]) 
            { 
                DialogResult ans = MessageBox.Show("您確定要更改帳戶資訊嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes) ;
                else goto SkipAccChange;
            }

            if (!buttonStatus[0])
            {
                Account.Hide();
                AccountChange.Show();
                AccountChange.Text = "";
                btn_acc_change.Text = "確認";
                buttonStatus[0] = true;
            }
            else
            {
                string result = String.Concat(AccountChange.Text.Where(c => !Char.IsWhiteSpace(c)));
                Console.WriteLine(result);
                bool IsAllDigits(string s) => s.All(char.IsDigit);
                if (result.Length == 14 && IsAllDigits(result))
                {
                    MessageBox.Show("成功設定新的帳戶資料!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userInfo[0] = $"{result.Substring(0, 3)}**** {result.Substring(7, 3)}****";
                    Account.Text = userInfo[0];
                    Account.ForeColor = SystemColors.ControlText;
                    Account.Show();
                    AccountChange.Hide();
                    btn_acc_change.Text = "變更";
                    buttonStatus[0] = false;
                }
                else
                {
                    MessageBox.Show("帳戶資訊格式不正確，請於檢查後重新嘗試", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    AccountChange.Text = "";
                }
            }

            SkipAccChange:
            ;
        }

        private void btn_quo_change_Click(object sender, EventArgs e)
        {
            bool isInitial = userInfo[1] == null ? true : false;

            if (!isInitial && !buttonStatus[1])
            {
                DialogResult ans = MessageBox.Show("您確定要更改配額方式嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes) ;
                else goto SkipQuoChange;
            }

            if (!buttonStatus[1])
            {
                Quota.Hide();
                QuotaChange.Show();
                QuotaChange.SelectedItem = null;
                QuotaChange.SelectedText = "選擇一種方案";
                btn_quo_change.Text = "確認";
                buttonStatus[1] = true;
            }
            else
            {
                string newPlan = "";
                if (QuotaChange.SelectedItem != null) newPlan = QuotaChange.SelectedItem.ToString();
                else { MessageBox.Show("你並沒有選擇一種方案!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipQuoChange; }

                DialogResult ans = MessageBox.Show($"配額方式將被更改為{newPlan}, 確定嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes) ;
                else goto SkipQuoChange;

                userInfo[1] = newPlan;
                Quota.Text = newPlan;
                Quota.ForeColor = SystemColors.ControlText;
                Quota.Show();
                QuotaChange.Hide();
                btn_quo_change.Text = "變更";
                buttonStatus[1] = false;
            }

            SkipQuoChange:
            ;
        }

        private void Pressed_Key_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                btn_acc_change.PerformClick(); // Simulate a click on the Send Message button
            }
        }

        private void Pressed_Key_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                btn_quo_change.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void Notify_CheckedChanged(object sender, EventArgs e)
        {
            if (userInfo[2] == null) userInfo[2] = true;
            else userInfo[2] = !userInfo[2];
        }
    }
}
