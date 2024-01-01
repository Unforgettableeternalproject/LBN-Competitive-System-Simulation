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
        private bool errorMsg = false, passwordToggle = true, allowAlterate = true;
        private string type = "Normal";
        private List<string> keys = new List<string>()
        {
            "gay",
            "special",
            "current",
            "password",
            "supercalifragilisticexpialidocious",
            "12@23#25%%41?"
        };

        public LoginForm(bool _allowAlterate)
        {
            InitializeComponent();
            allowAlterate = _allowAlterate;
            if (allowAlterate) SwitchRole.Show();
            else SwitchRole.Hide();
            loginInit();

            Register.Text = "註冊";
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            txt_Username.Location = new Point(115, 335);
            txt_Password.Location = new Point(115, 443);
            txt_Password.PasswordChar = '*';
            txt_ConfirmPW.PasswordChar = '*';
            btn_confirm.Location = new Point(155, 523);
         //   toolTip.SetToolTip(ToggleInvis, "顯示/隱藏密碼");
            txt_Username.KeyDown += Pressed_Key;
            txt_Password.KeyDown += Pressed_Key;
            txt_Email.KeyDown += Pressed_Key;
            txt_ConfirmPW.KeyDown += Pressed_Key;
            txt_DoubleCheck.KeyDown += Pressed_Key;
        }
        private bool TwoFactor(string factor)
        {
            return keys.Contains(factor);
        }
        private ID Validation(string username, string password)
        {
            bool flag = false;
            ID result = new ID();
            var read = new StreamReader($@"..\..\ExampleIDs\{type}UserID.json");
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
                    if (id.Role == null) result = new ID(id.Username.ToString(), id.Password.ToString(), id.Email.ToString());
                    else result = new ID(id.Username.ToString(), id.Password.ToString(), id.Email.ToString(), id.Role.ToString());
                    flag = true;
                    break;
                }else if(username == id.Username.ToString() && password != id.Password.ToString())
                {
                    errorMsg = true;
                    MessageBox.Show("您的密碼不正確，請重新嘗試!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            bool emailValid = true;
            bool repeated = false;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                emailValid = false;
            }

            var read = new StreamReader($@"..\..\ExampleIDs\{type}UserID.json");
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
                    MessageBox.Show("請填寫所有欄位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                if (password != confirmPassword)//Confirm Password
                {
                    MessageBox.Show("密碼不相符，請檢察輸入的資料!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                if (!emailValid)
                {
                    MessageBox.Show("電子郵件地址格式不正確，請檢察輸入的資料!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                if (repeated)
                {
                    MessageBox.Show("使用者名稱已有人使用，請選擇其他的!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                return new ID(username, password, email);
        }

        private void newID(ID _new)
        {
            var read = new StreamReader($@"..\..\ExampleIDs\{type}UserID.json");
            var json = read.ReadToEnd();

            read.Close();
            read.Dispose();
            var IDList = !string.IsNullOrEmpty(json.ToString()) ? JsonConvert.DeserializeObject<List<ID>>(json) : new List<ID>();
            IDList.Add(_new);

            json = JsonConvert.SerializeObject(IDList);
            var writer = new StreamWriter($@"..\..\ExampleIDs\{type}UserID.json");
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
            txt_DoubleCheck.Text = "";
        }
        private void loginInit()
        {
            clearFields();
            Mode = "Login";
            SwitchRole.Show();
            passwordToggle = true;
            this.Text = "Login Window";
            this.BackgroundImage = Properties.Resources.LoginForm;
            btn_confirm.BackgroundImage = Properties.Resources.btn_Confirm;
            txt_Username.Location = new Point(115, 335);
            txt_Password.Location = new Point(115, 443);
            btn_confirm.Location = new Point(155, 523);
            ToggleInvis.Location = new Point(396, 446);
            txt_DoubleCheck.Hide();
            txt_Email.Hide();
            txt_ConfirmPW.Hide();
            if (allowAlterate) Anonymous.Show();
            else Anonymous.Hide();
            ToggleInvis.Show();
            Register.Show();
            ToggleInvis.BackgroundImage = Properties.Resources.PasswordInvisible;
            txt_Password.PasswordChar = '*';
        }
        private void registerInit()
        {
            clearFields();
            Mode = "Register";
            SwitchRole.Hide();
            this.Text = "Registration Window";
            this.BackgroundImage = Properties.Resources.RegistrationForm;
            btn_confirm.BackgroundImage = Properties.Resources.Submit;
            txt_Username.Location = new Point(115, 257);
            txt_Password.Location = new Point(115, 404);
            btn_confirm.Location = new Point(155, 538);
            ToggleInvis.Location = new Point(396, 407);
            txt_DoubleCheck.Hide();
            txt_Email.Show();
            txt_ConfirmPW.Show();
            Anonymous.Hide();
            ToggleInvis.Show();
            ToggleInvis.BackgroundImage = Properties.Resources.PasswordInvisible;
            txt_Password.PasswordChar = '*';
        }

        private void specialInit()
        {
            clearFields();
            Mode = "Special";
            SwitchRole.Show();
            this.Text = "Back-end Login Window";
            this.BackgroundImage = Properties.Resources.AdminLogin;
            btn_confirm.BackgroundImage = Properties.Resources.btn_ConfirmAdmin;
            txt_Username.Location = new Point(115, 290);
            txt_Password.Location = new Point(115, 386);
            btn_confirm.Location = new Point(155, 542);
            ToggleInvis.Location = new Point(396, 389);
            txt_DoubleCheck.Show();
            txt_Email.Hide();
            txt_ConfirmPW.Hide();
            Anonymous.Hide();
            Register.Hide();
            ToggleInvis.BackgroundImage = Properties.Resources.PasswordInvisible;
            txt_Password.PasswordChar = '*';
        }
        public ID returnID()
        {
            return userID;
        }

        private void Pressed_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                btn_confirm.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void Register_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case "Register":
                    Register.Text = "註冊";
                    loginInit();
                    break;
                case "Login":
                    Register.Text = "返回";
                    registerInit();
                    break;
                default:
                    break;
            }
        }

        private void Anonymous_Click(object sender, EventArgs e)
        {
            userID = new ID("Anonymous", "Not Required", "None");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SwitchRole_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case "Special":
                    type = "Normal";
                    SwitchRole.BackgroundImage = Properties.Resources.SwitchOff;
                    loginInit();
                    break;
                case "Login":
                    type = "Special";
                    SwitchRole.BackgroundImage = Properties.Resources.SwitchOn;
                    specialInit();
                    break;
                default:
                    break;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            errorMsg = false;
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
                    if (!errorMsg && (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text)))
                    {
                        MessageBox.Show("帳號與密碼為必填欄位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorMsg = true;
                    }
                    if (!errorMsg) MessageBox.Show("找不到該用戶，請確認填入資料是否有誤!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearFields();
                }
            }
            if (Mode == "Register")
            {
                var NewID = Verification(txt_Username.Text, txt_Email.Text, txt_Password.Text, txt_ConfirmPW.Text);
                if(NewID != null)
                {
                    newID(NewID);
                    loginInit();
                    MessageBox.Show("已註冊新用戶! 跳轉回登入頁面...", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clearFields();
                }
            }
            if (Mode == "Special")
            {
                userID = Validation(txt_Username.Text, txt_Password.Text);
                if (userID != null && TwoFactor(txt_DoubleCheck.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (!errorMsg && (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrEmpty(txt_Password.Text)))
                    {
                        MessageBox.Show("帳號與密碼為必填欄位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorMsg = true;
                    }
                    if(!TwoFactor(txt_DoubleCheck.Text))
                    {
                        MessageBox.Show("兩步驟驗證失敗! 請確認驗證碼的真實性!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorMsg = true;
                    }
                    if (!errorMsg) MessageBox.Show("找不到該用戶，請確認填入資料是否有誤!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearFields();
                }
            }
        }

        private void ToggleInvis_Click(object sender, EventArgs e)
        {
            if (passwordToggle)
            {
                ToggleInvis.BackgroundImage = Properties.Resources.PasswordVisible;
                txt_Password.PasswordChar = '\0';
                passwordToggle = false;
            }
            else
            {
                ToggleInvis.BackgroundImage = Properties.Resources.PasswordInvisible;
                txt_Password.PasswordChar = '*';
                passwordToggle = true;
            }
        }
    }
    public class ID
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UUID { get; set; }
        public string Role { get; set; }
        public ID()
        {
            Username = null;
            Password = null;
            Email = null;
            UUID = null;
        }
        public ID(string username, string password, string email)
        {
            Guid myuuid = Guid.NewGuid();
            Username = username;
            Password = password;
            Email = email;
            UUID = myuuid.ToString();
            Role = "Normal";
        }
        public ID(string username, string password, string email, string role) : this(username, password, email)
        {
            Role = role;
        }

        public ID(string username, string password, string email, string role, string uUID) : this(username, password, email, role)
        {
            UUID = uUID;
        }
    }
}
