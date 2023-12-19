using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LBN_Competitive_System_Simulation
{
    public partial class LoginForm : Form
    {
        String Mode = "Login";
        private ID userID = null;
        private ID Validation(string username, string password)
        {
            bool flag = false;
            ID result = new ID();
            var read = new StreamReader(@"..\..\ExampleIDs\NormalUserID.json");
            var json = read.ReadToEnd();

            if (string.IsNullOrEmpty(json.ToString()))
            {
                read.Close();
                read.Dispose();
                return null;
            }

            dynamic IDs = JsonConvert.DeserializeObject(json);
            foreach(var id in IDs)
            {
                if (username == id.Username.ToString() && password == id.Password.ToString())
                {
                    result = new ID(id.Username.ToString(), id.Password.ToString(), id.Email.ToString());
                    flag = true;
                    break;
                }else if(username == id.Username.ToString() && password != id.Password.ToString())
                {
                    MessageBox.Show("您的密碼不正確，請重新嘗試!");
                    break;
                }
            }

            read.Close();
            read.Dispose();
            if (flag) return result;
            else return null;
        }

        private ID Verification(string username, string email, string password, string confirmPassword)
        {
            bool emailVaild = true;
            bool repeated = false;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                emailVaild = false;
            }

            var read = new StreamReader(@"..\..\ExampleIDs\NormalUserID.json");
            var json = read.ReadToEnd();

            if (string.IsNullOrEmpty(json.ToString()))
            {
                goto ExceptionHandling;
            }

            dynamic IDs = JsonConvert.DeserializeObject(json);

            foreach (var id in IDs)
            {
                if (username == id.Username.ToString())
                {
                    repeated = true;
                    break;
                }
            }

            ExceptionHandling:
                read.Close();
                read.Dispose();

                if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_ConfirmPW.Text))
                {
                    MessageBox.Show("請填寫所有欄位");
                    return null;
                }

                if (password != confirmPassword)//Confirm Password
                {
                    MessageBox.Show("密碼不相符，請檢察輸入的資料!");
                    return null;
                }

                if (!emailVaild)
                {
                    MessageBox.Show("電子郵件地址格式不正確，請檢察輸入的資料!");
                    return null;
                }

                if (repeated)
                {
                    MessageBox.Show("使用者名稱已有人使用，請選擇其他的!");
                    return null;
                }

                return new ID(username, password, email);
        }

        private void newID(ID _new)
        {
            var read = new StreamReader(@"..\..\ExampleIDs\NormalUserID.json");
            var json = read.ReadToEnd();

            read.Close();
            read.Dispose();
            var IDList = !string.IsNullOrEmpty(json.ToString()) ? JsonConvert.DeserializeObject<List<ID>>(json) : new List<ID>();
            IDList.Add(_new);

            json = JsonConvert.SerializeObject(IDList);
            var writer = new StreamWriter(@"..\..\ExampleIDs\NormalUserID.json");
            writer.Write(json);

            writer.Flush();
            writer.Close();
            writer.Dispose();
        }

        private void clearFields()
        {
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_ConfirmPW.Text = "";
            txt_Email.Text = "";
        }
        private void switchMode()
        {
            clearFields();
            switch (Mode)
            {
                case "Login":
                    Mode = "Register";
                    this.Text = "Registration Window";
                    this.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.RegistrationForm;
                    btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.Submit;
                    txt_Username.Location = new Point(115, 257);
                    txt_Password.Location = new Point(115, 404);
                    btn_confirm.Location = new Point(155, 538);
                    txt_Email.Show();
                    txt_ConfirmPW.Show();
                    Anonymous.Hide();
                    Register.Text = "返回";
                    break;
                case "Register":
                    Mode = "Login";
                    this.Text = "Login Window";
                    this.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.LoginForm;
                    btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
                    txt_Username.Location = new Point(115, 335);
                    txt_Password.Location = new Point(115, 443);
                    btn_confirm.Location = new Point(155, 523);
                    txt_Email.Hide();
                    txt_ConfirmPW.Hide();
                    Anonymous.Show();
                    Register.Text = "註冊";
                    break;
                default:
                    break;
            }
        }

        public ID returnID()
        {
            return userID;
        }
        public LoginForm()
        {
            InitializeComponent();
            Mode = "Login";
            this.Text = "Login Window";
            this.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.LoginForm;
            btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
            clearFields();
            txt_Username.Location = new Point(115, 335);
            txt_Password.Location = new Point(115, 443);
            btn_confirm.Location = new Point(155, 523);
            txt_Email.Hide();
            txt_ConfirmPW.Hide();
            Anonymous.Show();
            Register.Text = "註冊";
        }

        private void Register_Click(object sender, EventArgs e)
        {
            switchMode();
        }

        private void Anonymous_Click(object sender, EventArgs e)
        {
            userID = new ID("Anonymous", "Not Required", "None");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(Mode == "Login")
            {
                userID = Validation(txt_Username.Text, txt_Password.Text);
                if (userID != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text))
                    {
                        MessageBox.Show("帳號與密碼為必填欄位!");
                    }
                    else MessageBox.Show("找不到該已註冊的用戶，請重新嘗試!");
                    clearFields();
                }
            }
            else
            {
                var NewID = Verification(txt_Username.Text, txt_Email.Text, txt_Password.Text, txt_ConfirmPW.Text);
                if(NewID != null)
                {
                    newID(NewID);
                    switchMode();
                    MessageBox.Show("已註冊新用戶! 跳轉回登入頁面...");
                }
                else
                {
                    clearFields();
                }
            }
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
    }
    public class ID
    {
        public string Username;
        public string Password;
        public string Email;
        public ID()
        {
            Username = null;
            Password = null;
            Email = null;
        }
        public ID(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
