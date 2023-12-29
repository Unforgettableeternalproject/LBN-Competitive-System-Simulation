using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class UserManagementSubForm : Form
    {
        private ID userID;
        private IDwithPartnerCheck selectedUser;
        private string Mode = "None", Users = "None";
        public UserManagementSubForm(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
            cbox_UserType.DropDown += Cbox_UserType_DropDown;
        }

        private void DoNothing()
        {
            ;
        }
        private void UserManagementSubForm_Load(object sender, EventArgs e)
        {
            overallInit();
        }

        private void overallInit()
        {
            Mode = "None";
            lbl_Email.Hide();
            lbl_Password.Hide();
            lbl_Username.Hide();
            lbl_UserType.Hide();
            lbl_Partner.Hide();
            txt_Email.Text = "";  txt_Email.Hide();
            txt_Password.Text = ""; txt_Password.Hide();
            txt_Username.Text = ""; txt_Username.Hide();
            cbox_UserType.Hide();
            chk_Partner.Hide();
            Confim.Hide();
            Cancel.Hide();
            Hint.Show();
            btn_add.Show();
            btn_delete.Show();
            btn_edit.Show();
            RadioBtns.Enabled = true;
            lbl_Select.Show();
        }

        private void addInit()
        {
            Mode = "Add";
            lbl_Email.Show();
            lbl_Password.Show();
            lbl_Username.Show();
            lbl_UserType.Show();
            lbl_Partner.Show();
            txt_Email.Show();
            txt_Password.Show();
            txt_Username.Show();
            cbox_UserType.Show();
            chk_Partner.Show();
            Confim.Show();
            Cancel.Show();
            btn_add.Hide();
            btn_delete.Hide();
            btn_edit.Hide();
            RadioBtns.Enabled = false;

            if(Users == "Normal") { lbl_Partner.Enabled = true; chk_Partner.Enabled = true; }
            else { lbl_Partner.Enabled = false; chk_Partner.Enabled = false; }
        }
        private void gridInit(string type, string role = "")
        {
            Hint.Hide();

            switch (type)
            {
                case "Normal":
                    var normalUsers = JsonConvert.DeserializeObject<List<IDwithPartnerCheck>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                    var partnerUsers = JsonConvert.DeserializeObject<List<IDwithPartnerCheck>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));
                    foreach (var partnerUser in partnerUsers)
                    {
                        partnerUser.IsPartner = "True";
                    }
                    var allUsers = normalUsers.Concat(partnerUsers).ToList();
                    DataGrid.AutoGenerateColumns = false;
                    DataGrid.Columns.Clear();
                    DataGrid.Columns.Add("Username", "Username");
                    DataGrid.Columns.Add("Password", "Password");
                    DataGrid.Columns.Add("Email", "Email");
                    DataGrid.Columns.Add("UUID", "UUID");
                    DataGrid.Columns.Add("Role", "Role");
                    DataGrid.Columns.Add("IsPartner", "IsPartner");
                    DataGrid.DataSource = allUsers;
                    DataGrid.Columns["Username"].DataPropertyName = "Username";
                    DataGrid.Columns["Password"].DataPropertyName = "Password";
                    DataGrid.Columns["Email"].DataPropertyName = "Email";
                    DataGrid.Columns["UUID"].DataPropertyName = "UUID";
                    DataGrid.Columns["Role"].DataPropertyName = "Role";
                    DataGrid.Columns["IsPartner"].DataPropertyName = "IsPartner";
                    break;
                case "Special":
                    var json = File.ReadAllText(@"..\..\ExampleIDs\SpecialUserID.json");
                    var result = JsonConvert.DeserializeObject<List<ID>>(json);
                    DataGrid.AutoGenerateColumns = true;
                    DataGrid.DataSource = result.Where(user => user.Role == role).ToList();
                    break;
                default:
                    break;
            }
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void NormalUsers_CheckedChanged(object sender, EventArgs e)
        {
            Users = "Normal";
            cbox_UserType.Items.Clear();
            cbox_UserType.Items.AddRange(new object[] {"一般用戶", "合作夥伴"});
            if (NormalUsers.Checked)
            {
                gridInit(Users);
                cbox_Roles.SelectedItem = null;
                cbox_Roles.Text = "...";
            }
            else DoNothing();
        }

        private void SpecialUsers_CheckedChanged(object sender, EventArgs e)
        {
            Users = "Special";
            string selectedRole;
            cbox_UserType.Items.Clear();
            cbox_UserType.Items.AddRange(new object[] { "玩家", "聯盟所有人" });
            if (SpecialUsers.Checked && cbox_Roles.SelectedItem != null)
            {
                switch (cbox_Roles.SelectedIndex)
                {
                    case 0:
                        selectedRole = "Player";
                        break;
                    case 1:
                        selectedRole = "League Owner";
                        break;
                    default:
                        selectedRole = "";
                        break;
                }
                gridInit(Users, selectedRole);
            }
            else DoNothing();
        }

        private void cbox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole;
            if (SpecialUsers.Checked && cbox_Roles.SelectedItem != null)
            {
                switch (cbox_Roles.SelectedIndex)
                {
                    case 0:
                        selectedRole = "Admin";
                        break;
                    case 1:
                        selectedRole = "Player";
                        break;
                    case 2:
                        selectedRole = "League Owner";
                        break;
                    default:
                        selectedRole = "";
                        break;
                }
                gridInit("Special", selectedRole);
            }
            else DoNothing();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addInit();
        }
        private void Confim_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string email = txt_Email.Text;
            string usertype = cbox_UserType.SelectedItem == null ? null : cbox_UserType.SelectedItem.ToString();
            bool emailValid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                emailValid = false;
            }
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email)) { MessageBox.Show("沒有填寫所有必要的欄位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipEverything; }
            if(!emailValid) { MessageBox.Show("電子郵件地址格式不正確或者並非真實存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipEverything; }
            if(usertype == null) { MessageBox.Show("沒有選擇一個合法的用戶類別!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipEverything; }
        SkipEverything:
                DoNothing();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            overallInit();
        }

        private void cbox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_UserType.SelectedItem.ToString() == "合作夥伴") chk_Partner.Checked = true;
        }

        private void chk_Partner_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Partner.Checked) cbox_UserType.SelectedIndex = cbox_UserType.FindStringExact("合作夥伴"):
        }

        private void Cbox_UserType_DropDown(object sender, EventArgs e)
        {
            cbox_UserType.ForeColor = SystemColors.ControlText;
        }
    }
    class IDwithPartnerCheck : ID
    {
        public string IsPartner { get; set; }

        public IDwithPartnerCheck() : base()
        {
            IsPartner = "False"; // Default value
        }

        public IDwithPartnerCheck(string username, string password, string email, string role, string uUID) : base(username, password, email, role, uUID)
        {
            IsPartner = "False"; // Default value
        }
    }
}
