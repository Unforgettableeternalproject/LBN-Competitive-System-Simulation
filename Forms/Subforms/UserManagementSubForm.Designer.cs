namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class UserManagementSubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.NormalUsers = new System.Windows.Forms.RadioButton();
            this.RadioBtns = new System.Windows.Forms.GroupBox();
            this.cbox_Roles = new System.Windows.Forms.ComboBox();
            this.SpecialUsers = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_Select = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.cbox_UserType = new System.Windows.Forms.ComboBox();
            this.Confim = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.Label();
            this.lbl_Partner = new System.Windows.Forms.Label();
            this.chk_Partner = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.RadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(107, 260);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(871, 484);
            this.DataGrid.TabIndex = 0;
            // 
            // NormalUsers
            // 
            this.NormalUsers.AutoSize = true;
            this.NormalUsers.BackColor = System.Drawing.Color.Transparent;
            this.NormalUsers.FlatAppearance.BorderSize = 0;
            this.NormalUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalUsers.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalUsers.Location = new System.Drawing.Point(6, 12);
            this.NormalUsers.Name = "NormalUsers";
            this.NormalUsers.Size = new System.Drawing.Size(88, 20);
            this.NormalUsers.TabIndex = 1;
            this.NormalUsers.TabStop = true;
            this.NormalUsers.Text = "一般用戶";
            this.NormalUsers.UseVisualStyleBackColor = false;
            this.NormalUsers.CheckedChanged += new System.EventHandler(this.NormalUsers_CheckedChanged);
            // 
            // RadioBtns
            // 
            this.RadioBtns.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtns.Controls.Add(this.cbox_Roles);
            this.RadioBtns.Controls.Add(this.SpecialUsers);
            this.RadioBtns.Controls.Add(this.NormalUsers);
            this.RadioBtns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioBtns.Location = new System.Drawing.Point(827, 98);
            this.RadioBtns.Name = "RadioBtns";
            this.RadioBtns.Size = new System.Drawing.Size(134, 103);
            this.RadioBtns.TabIndex = 2;
            this.RadioBtns.TabStop = false;
            // 
            // cbox_Roles
            // 
            this.cbox_Roles.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Roles.FormattingEnabled = true;
            this.cbox_Roles.Items.AddRange(new object[] {
            "P",
            "LO"});
            this.cbox_Roles.Location = new System.Drawing.Point(100, 81);
            this.cbox_Roles.Name = "cbox_Roles";
            this.cbox_Roles.Size = new System.Drawing.Size(31, 20);
            this.cbox_Roles.TabIndex = 3;
            this.cbox_Roles.Text = "...";
            this.cbox_Roles.SelectedIndexChanged += new System.EventHandler(this.cbox_Roles_SelectedIndexChanged);
            // 
            // SpecialUsers
            // 
            this.SpecialUsers.AutoSize = true;
            this.SpecialUsers.FlatAppearance.BorderSize = 0;
            this.SpecialUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpecialUsers.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialUsers.Location = new System.Drawing.Point(6, 81);
            this.SpecialUsers.Name = "SpecialUsers";
            this.SpecialUsers.Size = new System.Drawing.Size(88, 20);
            this.SpecialUsers.TabIndex = 2;
            this.SpecialUsers.TabStop = true;
            this.SpecialUsers.Text = "特殊用戶";
            this.SpecialUsers.UseVisualStyleBackColor = true;
            this.SpecialUsers.CheckedChanged += new System.EventHandler(this.SpecialUsers_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Add;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(170, 119);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 65);
            this.btn_add.TabIndex = 3;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Edit;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Location = new System.Drawing.Point(396, 119);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(142, 65);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Delete;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(623, 119);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 65);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_Select
            // 
            this.lbl_Select.AutoSize = true;
            this.lbl_Select.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Select.Location = new System.Drawing.Point(831, 69);
            this.lbl_Select.Name = "lbl_Select";
            this.lbl_Select.Size = new System.Drawing.Size(123, 19);
            this.lbl_Select.TabIndex = 6;
            this.lbl_Select.Text = "選擇用戶類型";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(166, 86);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(90, 19);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "用戶名稱:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F);
            this.txt_Username.Location = new System.Drawing.Point(267, 80);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(204, 30);
            this.txt_Username.TabIndex = 8;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(128, 140);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(128, 19);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "電子郵件信箱:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F);
            this.txt_Email.Location = new System.Drawing.Point(267, 133);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(204, 30);
            this.txt_Email.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(166, 193);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(90, 19);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "預設密碼:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F);
            this.txt_Password.Location = new System.Drawing.Point(267, 186);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(204, 30);
            this.txt_Password.TabIndex = 12;
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserType.Location = new System.Drawing.Point(515, 86);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(90, 19);
            this.lbl_UserType.TabIndex = 13;
            this.lbl_UserType.Text = "用戶類型:";
            // 
            // cbox_UserType
            // 
            this.cbox_UserType.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F);
            this.cbox_UserType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbox_UserType.FormattingEnabled = true;
            this.cbox_UserType.Items.AddRange(new object[] {
            "一般用戶",
            "合作夥伴"});
            this.cbox_UserType.Location = new System.Drawing.Point(611, 81);
            this.cbox_UserType.Name = "cbox_UserType";
            this.cbox_UserType.Size = new System.Drawing.Size(134, 27);
            this.cbox_UserType.TabIndex = 14;
            this.cbox_UserType.Text = "選擇類型...";
            this.cbox_UserType.SelectedIndexChanged += new System.EventHandler(this.cbox_UserType_SelectedIndexChanged);
            // 
            // Confim
            // 
            this.Confim.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confim.Location = new System.Drawing.Point(519, 183);
            this.Confim.Name = "Confim";
            this.Confim.Size = new System.Drawing.Size(97, 32);
            this.Confim.TabIndex = 15;
            this.Confim.Text = "確認並添加";
            this.Confim.UseVisualStyleBackColor = true;
            this.Confim.Click += new System.EventHandler(this.Confim_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(648, 183);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 32);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "取消並返回";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Hint.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 48F);
            this.Hint.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Hint.Location = new System.Drawing.Point(319, 453);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(475, 64);
            this.Hint.TabIndex = 17;
            this.Hint.Text = "選擇用戶以開始";
            // 
            // lbl_Partner
            // 
            this.lbl_Partner.AutoSize = true;
            this.lbl_Partner.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Partner.Location = new System.Drawing.Point(515, 140);
            this.lbl_Partner.Name = "lbl_Partner";
            this.lbl_Partner.Size = new System.Drawing.Size(90, 19);
            this.lbl_Partner.TabIndex = 18;
            this.lbl_Partner.Text = "合作夥伴:";
            // 
            // chk_Partner
            // 
            this.chk_Partner.AutoSize = true;
            this.chk_Partner.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F);
            this.chk_Partner.Location = new System.Drawing.Point(611, 139);
            this.chk_Partner.Name = "chk_Partner";
            this.chk_Partner.Size = new System.Drawing.Size(74, 23);
            this.chk_Partner.TabIndex = 19;
            this.chk_Partner.Text = "是/否";
            this.chk_Partner.UseVisualStyleBackColor = true;
            this.chk_Partner.CheckedChanged += new System.EventHandler(this.chk_Partner_CheckedChanged);
            // 
            // UserManagementSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.UMPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.chk_Partner);
            this.Controls.Add(this.lbl_Partner);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confim);
            this.Controls.Add(this.cbox_UserType);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_Select);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.RadioBtns);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UserManagementSubForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserManagementSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.RadioBtns.ResumeLayout(false);
            this.RadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.RadioButton NormalUsers;
        private System.Windows.Forms.GroupBox RadioBtns;
        private System.Windows.Forms.RadioButton SpecialUsers;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_Select;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.ComboBox cbox_UserType;
        private System.Windows.Forms.Button Confim;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.ComboBox cbox_Roles;
        private System.Windows.Forms.Label lbl_Partner;
        private System.Windows.Forms.CheckBox chk_Partner;
    }
}