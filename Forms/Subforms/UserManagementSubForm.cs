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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class UserManagementSubform : Form
    {
        private IDwithPartnerCheck originalUser;
        private string Mode = "None", Users = "None";
        bool isFirstClick = true;
        public UserManagementSubform()
        {
            InitializeComponent();
            cbox_UserType.DropDown += Cbox_UserType_DropDown;
            cbox_UserType.DropDownClosed += Cbox_UserType_DropDownClosed;
            DataGrid.CellClick += DataGrid_CellClick;
        }
        private void DoNothing()
        {
            ;
        }
        private void UserManagementSubForm_Load(object sender, EventArgs e)
        {
            Hint.Show();
            cbox_UserType.Items.Clear();
            cbox_UserType.Items.AddRange(new object[] { "一般用戶", "合作夥伴" });
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.MultiSelect = false;
            DataGrid.SelectionChanged += DataGrid_SelectionChanged;
            overallInit();
        }
        private bool isExist(ID newUser, bool isPartner = false)
        {
            List<ID> userList;
            if(Users == "Normal")
            {
                if(isPartner) userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));
                else userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
            }
            else
            {
                userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
            }
            return userList.Any(user => user.Username == newUser.Username && user.Password == newUser.Password);
        }

        private void enableAll()
        {
            lbl_Email.Enabled = true;
            lbl_Password.Enabled = true;
            lbl_Username.Enabled = true;
            txt_Email.Enabled = true;
            txt_Password.Enabled = true;
            txt_Username.Enabled = true;
            if (Users == "Normal")
            {
                lbl_UserType.Enabled = true; cbox_UserType.Enabled = true;
                lbl_Partner.Enabled = true; chk_Partner.Enabled = true;
            }
        }

        private void disableAll()
        {
            lbl_Email.Enabled = false;
            lbl_Password.Enabled = false;
            lbl_Username.Enabled = false;
            lbl_UserType.Enabled = false;
            lbl_Partner.Enabled = false;
            txt_Email.Enabled = false;
            txt_Password.Enabled = false;
            txt_Username.Enabled = false;
            chk_Partner.Enabled = false;
            cbox_UserType.Enabled = false;
        }
        private void overallInit()
        {
            Mode = "None";
            DataGrid.ClearSelection();
            originalUser = null;
            enableAll();
            lbl_Email.Hide();
            lbl_Password.Hide();
            lbl_Username.Hide();
            lbl_UserType.Hide();
            lbl_Partner.Hide();
            txt_Email.Text = ""; txt_Email.Hide();
            txt_Password.Text = ""; txt_Password.Hide();
            txt_Username.Text = ""; txt_Username.Hide();
            chk_Partner.Checked = false;
            cbox_UserType.SelectedItem = null;
            cbox_UserType.Text = "選擇類型...";
            cbox_UserType.ForeColor = SystemColors.GrayText;
            cbox_UserType.Hide();
            chk_Partner.Hide();
            Confim.Hide();
            Cancel.Hide();
            btn_add.Show();
            btn_delete.Show();
            btn_edit.Show();
            RadioBtns.Enabled = true;
            isFirstClick = true;
            lbl_Select.Show();
        }

        private void deleteInit()
        {
            Mode = "Delete";
            DataGrid.ClearSelection();
            disableAll();
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
            Confim.Text = "確認並刪除";
            RadioBtns.Enabled = false;
        }
        private void editInit()
        {
            Mode = "Edit";
            disableAll();
            DataGrid.ClearSelection();
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
            Confim.Text = "確認並更改";
            RadioBtns.Enabled = false;
        }
        private void addInit()
        {
            Mode = "Add";
            DataGrid.ClearSelection();
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
            Confim.Text = "確認並添加";
            if(Users == "Normal") { lbl_Partner.Enabled = true; chk_Partner.Enabled = true; lbl_UserType.Enabled = true; cbox_UserType.Enabled = true; }
            else { lbl_Partner.Enabled = false; chk_Partner.Enabled = false; lbl_UserType.Enabled = false; cbox_UserType.Enabled = false; }
        }
        private void gridInit(string type, string role = "")
        {
            Hint.Hide();

            switch (type)
            {
                case "Normal":
                    var normalUsers = JsonConvert.DeserializeObject<List<IDwithPartnerCheck>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                    var partnerUsers = JsonConvert.DeserializeObject<List<IDwithPartnerCheck>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));

                    // Create a list to hold all users (no repetitions)
                    var allUsers = new List<IDwithPartnerCheck>();

                    // Add normal users to the list
                    allUsers.AddRange(normalUsers);

                    // Iterate through partner users
                    foreach (var partnerUser in partnerUsers)
                    {
                        // Check if the user is not already in the list
                        if (!allUsers.Any(user => user.UUID == partnerUser.UUID))
                        {
                            // Add the partner user to the list
                            allUsers.Add(partnerUser);
                        }

                        // Set IsPartner to true for normal users who are also partner users
                        var correspondingNormalUser = normalUsers.FirstOrDefault(normalUser => normalUser.UUID == partnerUser.UUID);
                        if (correspondingNormalUser != null)
                        {
                            correspondingNormalUser.IsPartner = "True";
                        }
                    }

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

        private void deleteUser()
        {
            if (Users == "Normal")
            { 
                var userList_n = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                var userList_p = JsonConvert.DeserializeObject<List<PartnerID>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));
                string usersJson = "", usersJson2 = "";
                userList_p.RemoveAll(u => u.UUID == originalUser.UUID);
                userList_n.RemoveAll(u => u.UUID == originalUser.UUID);
                usersJson = JsonConvert.SerializeObject(userList_p, Formatting.Indented);
                usersJson2 = JsonConvert.SerializeObject(userList_n, Formatting.Indented);
                File.WriteAllText(@"..\..\ExampleIDs\PartnerUserID.json", usersJson);
                File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson2);
                gridInit("Normal");
            }
            else
            {
                var userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\SpecialUserID.json"));
                userList.RemoveAll(u => u.UUID == originalUser.UUID);
                string usersJson = JsonConvert.SerializeObject(userList, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(@"..\..\ExampleIDs\SpecialUserID.json", usersJson);
                gridInit("Special", originalUser.Role);
            }
            originalUser = null;
            txt_Email.Text = "";
            txt_Password.Text = "";
            txt_Username.Text = "";
            if (Users == "Normal")
            {
                chk_Partner.Checked = false;
                cbox_UserType.SelectedItem = null;
                cbox_UserType.Text = "選擇類型...";
                cbox_UserType.ForeColor = SystemColors.GrayText;
            }
            isFirstClick = true;
        }

        private void editUser(IDwithPartnerCheck revisedUser)
        {
            if(Users == "Normal")
            {
                var userList_n = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                var userList_p = JsonConvert.DeserializeObject<List<PartnerID>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));
                string usersJson = "", usersJson2 = "";
                if (originalUser.IsPartner == revisedUser.IsPartner)
                {
                    if(originalUser.IsPartner == "True")
                    {
                        userList_p.RemoveAll(u => u.UUID == originalUser.UUID);
                        userList_n.RemoveAll(u => u.UUID == originalUser.UUID);
                        userList_p.Add(new PartnerID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                        userList_n.Add(new ID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                        usersJson = JsonConvert.SerializeObject(userList_p, Formatting.Indented);
                        usersJson2 = JsonConvert.SerializeObject(userList_n, Formatting.Indented);

                        File.WriteAllText(@"..\..\ExampleIDs\PartnerUserID.json", usersJson);
                        File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson2);
                    }
                    else
                    {
                        userList_n.RemoveAll(u => u.UUID == originalUser.UUID);
                        userList_n.Add(new ID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                        usersJson2 = JsonConvert.SerializeObject(userList_n, Formatting.Indented);

                        File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson2);
                    }
                }
                if(originalUser.IsPartner == "True" && revisedUser.IsPartner == "False")
                {
                    userList_p.RemoveAll(u => u.UUID == originalUser.UUID);
                    userList_n.RemoveAll(u => u.UUID == originalUser.UUID);
                    userList_n.Add(new ID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                    usersJson = JsonConvert.SerializeObject(userList_p, Formatting.Indented);
                    usersJson2 = JsonConvert.SerializeObject(userList_n, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleIDs\PartnerUserID.json", usersJson);
                    File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson2);
                }
                if(originalUser.IsPartner == "False" && revisedUser.IsPartner == "True")
                {
                    userList_n.RemoveAll(u => u.UUID == originalUser.UUID);
                    userList_p.Add(new PartnerID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                    userList_n.Add(new ID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                    usersJson = JsonConvert.SerializeObject(userList_p, Formatting.Indented);
                    usersJson2 = JsonConvert.SerializeObject(userList_n, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleIDs\PartnerUserID.json", usersJson);
                    File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson2);
                }
                gridInit("Normal");
            }
            else
            {
                var userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\SpecialUserID.json"));
                userList.RemoveAll(u => u.UUID == originalUser.UUID);
                userList.Add(new ID(revisedUser.Username, revisedUser.Password, revisedUser.Email, revisedUser.Role, originalUser.UUID));
                string usersJson = JsonConvert.SerializeObject(userList, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(@"..\..\ExampleIDs\SpecialUserID.json", usersJson);
                gridInit("Special", revisedUser.Role);
            }

            originalUser = null;
            txt_Email.Text = "";
            txt_Password.Text = "";
            txt_Username.Text = "";
            if(Users == "Normal") 
            {
                chk_Partner.Checked = false;
                cbox_UserType.SelectedItem = null;
                cbox_UserType.Text = "選擇類型...";
                cbox_UserType.ForeColor = SystemColors.GrayText;
            }
            disableAll();
            isFirstClick = true;
        }
        private void addUser(IDwithPartnerCheck newUser)
        {
            if(Users == "Normal") 
            {
                if (newUser.IsPartner == "True")
                {
                    var NewUser = new ID(newUser.Username, newUser.Password, newUser.Email, newUser.Role);
                    var existingNormalUser = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json")).FirstOrDefault(normalUser => normalUser.Username == NewUser.Username && normalUser.Password == NewUser.Password);
                    var userList = JsonConvert.DeserializeObject<List<PartnerID>>(File.ReadAllText(@"..\..\ExampleIDs\PartnerUserID.json"));

                    if (existingNormalUser == null) userList.Add(new PartnerID(NewUser.Username, NewUser.Password, NewUser.Email, NewUser.Role, NewUser.UUID));
                    else userList.Add(new PartnerID(NewUser.Username, NewUser.Password, NewUser.Email, NewUser.Role, existingNormalUser.UUID));

                    string usersJson = JsonConvert.SerializeObject(userList, Formatting.Indented);

                    if(isExist(NewUser)) goto SkipP2N;
                    var p2n_userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                    p2n_userList.Add(NewUser);
                    string p2n_usersJson = JsonConvert.SerializeObject(p2n_userList, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", p2n_usersJson);
                // Write the JSON to the file

                SkipP2N:
                    File.WriteAllText(@"..\..\ExampleIDs\PartnerUserID.json", usersJson);
                    gridInit("Normal");
                }
                else
                {
                    var userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\NormalUserID.json"));
                    userList.Add(new ID(newUser.Username, newUser.Password, newUser.Email, newUser.Role));
                    string usersJson = JsonConvert.SerializeObject(userList, Formatting.Indented);

                    // Write the JSON to the file
                    File.WriteAllText(@"..\..\ExampleIDs\NormalUserID.json", usersJson);
                    gridInit("Normal");
                }
            }
            else
            {
                var userList = JsonConvert.DeserializeObject<List<ID>>(File.ReadAllText(@"..\..\ExampleIDs\SpecialUserID.json"));
                userList.Add(new ID(newUser.Username, newUser.Password, newUser.Email, newUser.Role));
                string usersJson = JsonConvert.SerializeObject(userList, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(@"..\..\ExampleIDs\SpecialUserID.json", usersJson);
                gridInit("Special", newUser.Role);
            }
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Mode == "Add" || Mode == "None") return;
            if (isFirstClick)
            {
                isFirstClick = false;
                if (DataGrid.CurrentRow != null && Users == "Normal" && DataGrid.CurrentRow.DataBoundItem is IDwithPartnerCheck selectedUser)
                {
                    // Display the selected user's information in the text boxes
                    var role = selectedUser.IsPartner == "True" ? "合作夥伴" : "一般用戶";
                    originalUser = selectedUser;
                    txt_Username.Text = selectedUser.Username;
                    txt_Password.Text = selectedUser.Password;
                    txt_Email.Text = selectedUser.Email;
                    cbox_UserType.ForeColor = SystemColors.ControlText;
                    cbox_UserType.SelectedIndex = cbox_UserType.FindStringExact(role);
                    chk_Partner.Checked = selectedUser.IsPartner == "True";
                }else if (DataGrid.CurrentRow != null && Users != "Normal" && DataGrid.CurrentRow.DataBoundItem is ID selectedUser_s)
                {
                    var transID = new IDwithPartnerCheck(selectedUser_s);
                    originalUser = transID;
                    txt_Username.Text = transID.Username;
                    txt_Password.Text = transID.Password;
                    txt_Email.Text = transID.Email;
                }
                else Console.WriteLine("Debug");

                if(Mode == "Edit") enableAll();
            }
            else
            {
                DialogResult result;
                string strPartner = chk_Partner.Checked ? "True" : "False";
                if (originalUser.Username == txt_Username.Text && originalUser.Password == txt_Password.Text && originalUser.Email == txt_Email.Text && originalUser.IsPartner == strPartner) result = DialogResult.Yes;
                else result = MessageBox.Show("您還有未保存的變更，要捨棄並開始編輯其他用戶嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    if (DataGrid.CurrentRow != null && Users == "Normal" && DataGrid.CurrentRow.DataBoundItem is IDwithPartnerCheck selectedUser)
                    {
                        var role = selectedUser.IsPartner == "True" ? "合作夥伴" : "一般用戶";
                        // Display the selected user's information in the text boxes
                        originalUser = selectedUser;
                        txt_Username.Text = selectedUser.Username;
                        txt_Password.Text = selectedUser.Password;
                        txt_Email.Text = selectedUser.Email;
                        cbox_UserType.ForeColor = SystemColors.ControlText;
                        Console.WriteLine(selectedUser.IsPartner + " - NF");
                        cbox_UserType.SelectedIndex = cbox_UserType.FindStringExact(role);
                        chk_Partner.Checked = selectedUser.IsPartner == "True";
                    }
                    else if (DataGrid.CurrentRow != null && Users != "Normal" && DataGrid.CurrentRow.DataBoundItem is ID selectedUser_s)
                    {
                        var transID = new IDwithPartnerCheck(selectedUser_s);
                        originalUser = transID;
                        txt_Username.Text = transID.Username;
                        txt_Password.Text = transID.Password;
                        txt_Email.Text = transID.Email;
                    }
                    else Console.WriteLine("Debug");
                }
                DoNothing();
            }
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataGrid.ClearSelection();
            }
        }
        private void NormalUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalUsers.Checked)
            {
                cbox_UserType.Items.Clear();
                cbox_UserType.Items.AddRange(new object[] { "一般用戶", "合作夥伴" });
                Users = "Normal";
                gridInit(Users);
                cbox_Roles.SelectedItem = null;
                cbox_Roles.Text = "...";
            }
            else DoNothing();
        }

        private void SpecialUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (SpecialUsers.Checked && cbox_Roles.SelectedItem != null)
            {
                cbox_UserType.Items.Clear();
                cbox_UserType.Items.AddRange(new object[] { "玩家", "聯盟所有者" });
                switch (cbox_Roles.SelectedIndex)
                {
                    case 0:
                        cbox_UserType.SelectedIndex = 0;
                        Users = "Player";
                        break;
                    case 1:
                        cbox_UserType.SelectedIndex = 1;
                        Users = "League Owner";
                        break;
                    default:
                        Users = "None";
                        break;
                }
                gridInit("Special", Users);
            }
            else if(SpecialUsers.Checked && cbox_Roles.SelectedItem == null) { MessageBox.Show("你還沒有選擇一個特殊用戶的分類!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); NormalUsers.Checked = true; }
            else DoNothing();
        }

        private void cbox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpecialUsers.Checked && cbox_Roles.SelectedItem != null)
            {
                cbox_UserType.Items.Clear();
                cbox_UserType.Items.AddRange(new object[] { "玩家", "聯盟所有者" });
                switch (cbox_Roles.SelectedIndex)
                {
                    case 0:
                        cbox_UserType.SelectedIndex = 0;
                        Users = "Player";
                        break;
                    case 1:
                        cbox_UserType.SelectedIndex = 1;
                        Users = "League Owner";
                        break;
                    default:
                        Users = "None";
                        break;
                }
                gridInit("Special", Users);
            }
            else DoNothing();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Users != "None") addInit();
            else MessageBox.Show("你還沒有選擇一個用戶群體類型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (Users != "None") editInit();
            else MessageBox.Show("你還沒有選擇一個用戶群體類型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Users != "None") deleteInit();
            else MessageBox.Show("你還沒有選擇一個用戶群體類型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void Confim_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string email = txt_Email.Text;
            string usertype = cbox_UserType.SelectedItem == null ? null : cbox_UserType.SelectedItem.ToString();
            string isPartner = chk_Partner.Checked ? "True" : "False";
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
            if (usertype == null) { MessageBox.Show("沒有選擇一個合法的用戶類別!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipEverything; }
            switch (Mode)
            {
                case "Add":
                    if (isExist(new ID(username, password, email, Users), chk_Partner.Checked)) { MessageBox.Show("該用戶已經存在於系統裡!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipEverything; }
                    addUser(new IDwithPartnerCheck(username, password, email, Users, isPartner));
                    break;
                case "Edit":
                    editUser(new IDwithPartnerCheck(username, password, email, Users, isPartner));
                    break;
                case "Delete":
                    deleteUser();
                    break;
                default:
                    break;
            }
        SkipEverything:
                DoNothing();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            overallInit();
        }

        private void cbox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Users == "Normal" && Mode != "None" && cbox_UserType.SelectedItem != null)
            {
                if (cbox_UserType.SelectedItem.ToString() == "合作夥伴") chk_Partner.Checked = true;
                else chk_Partner.Checked = false;
            }
        }

        private void chk_Partner_CheckedChanged(object sender, EventArgs e)
        {
            cbox_UserType.ForeColor = SystemColors.ControlText;
            if (chk_Partner.Checked) cbox_UserType.SelectedIndex = cbox_UserType.FindStringExact("合作夥伴");
            else cbox_UserType.SelectedIndex = cbox_UserType.FindStringExact("一般用戶");
        }

        private void Cbox_UserType_DropDown(object sender, EventArgs e)
        {
            cbox_UserType.ForeColor = SystemColors.ControlText;
        }

        private void Cbox_UserType_DropDownClosed(object sender, EventArgs e)
        {
            if (cbox_UserType.SelectedItem == null) cbox_UserType.ForeColor = SystemColors.GrayText;
        }

        private class IDwithPartnerCheck : ID
        {
            public string IsPartner { get; set; }

            public IDwithPartnerCheck() : base()
            {
                IsPartner = "False"; // Default value
            }

            public IDwithPartnerCheck(ID baseID) : base(baseID.Username, baseID.Password, baseID.Email, baseID.Role, baseID.UUID)
            {
                IsPartner = "False";
            }

            public IDwithPartnerCheck(string username, string password, string email, string role, string isPartner = "false") : base(username, password, email, role)
            {
                IsPartner = isPartner;
            }
        }

        private class PartnerID : ID
        {
            public string Account { get; set; }
            public string Quota { get; set; }
            public bool Notify { get; set; }

            public PartnerID(string username, string password, string email, string role, string uUID) : base(username, password, email, role, uUID)
            {
                Account = "";
                Quota = "";
                Notify = false;
            }
        }
    }
  
}
