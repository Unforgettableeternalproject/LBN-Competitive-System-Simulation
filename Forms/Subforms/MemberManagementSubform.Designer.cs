namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class MemberManagementSubform
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
            this.components = new System.ComponentModel.Container();
            this.JoinRequests = new System.Windows.Forms.GroupBox();
            this.Request2 = new System.Windows.Forms.GroupBox();
            this.Empty = new System.Windows.Forms.Label();
            this.Decline2 = new System.Windows.Forms.Button();
            this.Accept2 = new System.Windows.Forms.Button();
            this.RequestTitle2 = new System.Windows.Forms.Label();
            this.Etc = new System.Windows.Forms.Label();
            this.Request3 = new System.Windows.Forms.GroupBox();
            this.Decline3 = new System.Windows.Forms.Button();
            this.Accept3 = new System.Windows.Forms.Button();
            this.RequestTitle3 = new System.Windows.Forms.Label();
            this.Request1 = new System.Windows.Forms.GroupBox();
            this.Decline1 = new System.Windows.Forms.Button();
            this.Accept1 = new System.Windows.Forms.Button();
            this.RequestTitle1 = new System.Windows.Forms.Label();
            this.MemberData = new System.Windows.Forms.DataGridView();
            this.MemberList = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Button();
            this.Ban = new System.Windows.Forms.Button();
            this.Kick = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Label();
            this.SelectedMember = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.SearchMember = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.NoResult = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.JoinRequests.SuspendLayout();
            this.Request2.SuspendLayout();
            this.Request3.SuspendLayout();
            this.Request1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberData)).BeginInit();
            this.SuspendLayout();
            // 
            // JoinRequests
            // 
            this.JoinRequests.Controls.Add(this.Empty);
            this.JoinRequests.Controls.Add(this.Request2);
            this.JoinRequests.Controls.Add(this.Etc);
            this.JoinRequests.Controls.Add(this.Request3);
            this.JoinRequests.Controls.Add(this.Request1);
            this.JoinRequests.Location = new System.Drawing.Point(169, 152);
            this.JoinRequests.Name = "JoinRequests";
            this.JoinRequests.Size = new System.Drawing.Size(472, 497);
            this.JoinRequests.TabIndex = 1;
            this.JoinRequests.TabStop = false;
            // 
            // Request2
            // 
            this.Request2.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.Request2.Controls.Add(this.Decline2);
            this.Request2.Controls.Add(this.Accept2);
            this.Request2.Controls.Add(this.RequestTitle2);
            this.Request2.Location = new System.Drawing.Point(1, 165);
            this.Request2.Name = "Request2";
            this.Request2.Size = new System.Drawing.Size(471, 127);
            this.Request2.TabIndex = 3;
            this.Request2.TabStop = false;
            // 
            // Empty
            // 
            this.Empty.AutoSize = true;
            this.Empty.BackColor = System.Drawing.Color.Transparent;
            this.Empty.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empty.Location = new System.Drawing.Point(120, 210);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(225, 29);
            this.Empty.TabIndex = 3;
            this.Empty.Text = "還沒有加入請求!";
            // 
            // Decline2
            // 
            this.Decline2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decline2.Location = new System.Drawing.Point(253, 73);
            this.Decline2.Name = "Decline2";
            this.Decline2.Size = new System.Drawing.Size(95, 38);
            this.Decline2.TabIndex = 2;
            this.Decline2.Text = "拒絕";
            this.Decline2.UseVisualStyleBackColor = true;
            // 
            // Accept2
            // 
            this.Accept2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept2.Location = new System.Drawing.Point(115, 73);
            this.Accept2.Name = "Accept2";
            this.Accept2.Size = new System.Drawing.Size(95, 38);
            this.Accept2.TabIndex = 1;
            this.Accept2.Text = "接受";
            this.Accept2.UseVisualStyleBackColor = true;
            // 
            // RequestTitle2
            // 
            this.RequestTitle2.AutoEllipsis = true;
            this.RequestTitle2.BackColor = System.Drawing.Color.Transparent;
            this.RequestTitle2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.RequestTitle2.Location = new System.Drawing.Point(0, 18);
            this.RequestTitle2.Name = "RequestTitle2";
            this.RequestTitle2.Size = new System.Drawing.Size(472, 25);
            this.RequestTitle2.TabIndex = 0;
            this.RequestTitle2.Text = "加入請求: 來自{}";
            this.RequestTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Etc
            // 
            this.Etc.AutoSize = true;
            this.Etc.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etc.Location = new System.Drawing.Point(164, 460);
            this.Etc.Name = "Etc";
            this.Etc.Size = new System.Drawing.Size(159, 16);
            this.Etc.TabIndex = 4;
            this.Etc.Text = "還有 {} 個其他請求...";
            // 
            // Request3
            // 
            this.Request3.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.Request3.Controls.Add(this.Decline3);
            this.Request3.Controls.Add(this.Accept3);
            this.Request3.Controls.Add(this.RequestTitle3);
            this.Request3.Location = new System.Drawing.Point(1, 312);
            this.Request3.Name = "Request3";
            this.Request3.Size = new System.Drawing.Size(471, 127);
            this.Request3.TabIndex = 3;
            this.Request3.TabStop = false;
            // 
            // Decline3
            // 
            this.Decline3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decline3.Location = new System.Drawing.Point(253, 73);
            this.Decline3.Name = "Decline3";
            this.Decline3.Size = new System.Drawing.Size(95, 38);
            this.Decline3.TabIndex = 2;
            this.Decline3.Text = "拒絕";
            this.Decline3.UseVisualStyleBackColor = true;
            // 
            // Accept3
            // 
            this.Accept3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept3.Location = new System.Drawing.Point(115, 73);
            this.Accept3.Name = "Accept3";
            this.Accept3.Size = new System.Drawing.Size(95, 38);
            this.Accept3.TabIndex = 1;
            this.Accept3.Text = "接受";
            this.Accept3.UseVisualStyleBackColor = true;
            // 
            // RequestTitle3
            // 
            this.RequestTitle3.AutoEllipsis = true;
            this.RequestTitle3.BackColor = System.Drawing.Color.Transparent;
            this.RequestTitle3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.RequestTitle3.Location = new System.Drawing.Point(0, 18);
            this.RequestTitle3.Name = "RequestTitle3";
            this.RequestTitle3.Size = new System.Drawing.Size(472, 25);
            this.RequestTitle3.TabIndex = 0;
            this.RequestTitle3.Text = "加入請求: 來自{}";
            this.RequestTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Request1
            // 
            this.Request1.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.Request1.Controls.Add(this.Decline1);
            this.Request1.Controls.Add(this.Accept1);
            this.Request1.Controls.Add(this.RequestTitle1);
            this.Request1.Location = new System.Drawing.Point(0, 19);
            this.Request1.Name = "Request1";
            this.Request1.Size = new System.Drawing.Size(471, 127);
            this.Request1.TabIndex = 0;
            this.Request1.TabStop = false;
            // 
            // Decline1
            // 
            this.Decline1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decline1.Location = new System.Drawing.Point(253, 73);
            this.Decline1.Name = "Decline1";
            this.Decline1.Size = new System.Drawing.Size(95, 38);
            this.Decline1.TabIndex = 2;
            this.Decline1.Text = "拒絕";
            this.Decline1.UseVisualStyleBackColor = true;
            // 
            // Accept1
            // 
            this.Accept1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept1.Location = new System.Drawing.Point(115, 73);
            this.Accept1.Name = "Accept1";
            this.Accept1.Size = new System.Drawing.Size(95, 38);
            this.Accept1.TabIndex = 1;
            this.Accept1.Text = "接受";
            this.Accept1.UseVisualStyleBackColor = true;
            // 
            // RequestTitle1
            // 
            this.RequestTitle1.AutoEllipsis = true;
            this.RequestTitle1.BackColor = System.Drawing.Color.Transparent;
            this.RequestTitle1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.RequestTitle1.Location = new System.Drawing.Point(0, 18);
            this.RequestTitle1.Name = "RequestTitle1";
            this.RequestTitle1.Size = new System.Drawing.Size(472, 25);
            this.RequestTitle1.TabIndex = 0;
            this.RequestTitle1.Text = "加入請求: 來自{}";
            this.RequestTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberData
            // 
            this.MemberData.AllowUserToAddRows = false;
            this.MemberData.AllowUserToDeleteRows = false;
            this.MemberData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberData.Location = new System.Drawing.Point(735, 157);
            this.MemberData.MultiSelect = false;
            this.MemberData.Name = "MemberData";
            this.MemberData.ReadOnly = true;
            this.MemberData.RowTemplate.Height = 24;
            this.MemberData.Size = new System.Drawing.Size(528, 211);
            this.MemberData.TabIndex = 5;
            // 
            // MemberList
            // 
            this.MemberList.AutoSize = true;
            this.MemberList.BackColor = System.Drawing.Color.Transparent;
            this.MemberList.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.MemberList.Location = new System.Drawing.Point(945, 100);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(108, 25);
            this.MemberList.TabIndex = 6;
            this.MemberList.Text = "成員列表";
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(1105, 547);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(92, 37);
            this.Contact.TabIndex = 21;
            this.Contact.Text = "聯絡成員";
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Ban
            // 
            this.Ban.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.Location = new System.Drawing.Point(988, 547);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(92, 37);
            this.Ban.TabIndex = 20;
            this.Ban.Text = "封禁成員";
            this.Ban.UseVisualStyleBackColor = true;
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // Kick
            // 
            this.Kick.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kick.Location = new System.Drawing.Point(874, 547);
            this.Kick.Name = "Kick";
            this.Kick.Size = new System.Drawing.Size(92, 37);
            this.Kick.TabIndex = 19;
            this.Kick.Text = "踢出成員";
            this.Kick.UseVisualStyleBackColor = true;
            this.Kick.Click += new System.EventHandler(this.Kick_Click);
            // 
            // Actions
            // 
            this.Actions.AutoSize = true;
            this.Actions.BackColor = System.Drawing.Color.Transparent;
            this.Actions.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.Actions.Location = new System.Drawing.Point(753, 553);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(104, 22);
            this.Actions.TabIndex = 18;
            this.Actions.Text = "進行動作:";
            // 
            // SelectedMember
            // 
            this.SelectedMember.AutoEllipsis = true;
            this.SelectedMember.BackColor = System.Drawing.Color.Transparent;
            this.SelectedMember.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.SelectedMember.Location = new System.Drawing.Point(731, 480);
            this.SelectedMember.Name = "SelectedMember";
            this.SelectedMember.Size = new System.Drawing.Size(368, 22);
            this.SelectedMember.TabIndex = 17;
            this.SelectedMember.Text = "選取的成員: 無";
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Search;
            this.SearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBTN.Location = new System.Drawing.Point(1162, 402);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(30, 30);
            this.SearchBTN.TabIndex = 16;
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchTXT.Location = new System.Drawing.Point(863, 402);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(289, 30);
            this.SearchTXT.TabIndex = 15;
            this.SearchTXT.Text = "輸入成員名稱...";
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // SearchMember
            // 
            this.SearchMember.AutoSize = true;
            this.SearchMember.BackColor = System.Drawing.Color.Transparent;
            this.SearchMember.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.SearchMember.Location = new System.Drawing.Point(753, 406);
            this.SearchMember.Name = "SearchMember";
            this.SearchMember.Size = new System.Drawing.Size(104, 22);
            this.SearchMember.TabIndex = 14;
            this.SearchMember.Text = "搜尋成員:";
            // 
            // Tick
            // 
            this.Tick.Interval = 1000;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // NoResult
            // 
            this.NoResult.AutoSize = true;
            this.NoResult.BackColor = System.Drawing.Color.DarkGray;
            this.NoResult.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.NoResult.Location = new System.Drawing.Point(905, 237);
            this.NoResult.Name = "NoResult";
            this.NoResult.Size = new System.Drawing.Size(187, 25);
            this.NoResult.TabIndex = 22;
            this.NoResult.Text = "找不到其他成員!";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1105, 474);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 37);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "清除";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // MemberManagementSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.MMPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NoResult);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.Kick);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.SelectedMember);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.SearchMember);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.MemberData);
            this.Controls.Add(this.JoinRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberManagementSubform";
            this.Load += new System.EventHandler(this.MemberManagementSubform_Load);
            this.JoinRequests.ResumeLayout(false);
            this.JoinRequests.PerformLayout();
            this.Request2.ResumeLayout(false);
            this.Request3.ResumeLayout(false);
            this.Request1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox JoinRequests;
        private System.Windows.Forms.Label Etc;
        private System.Windows.Forms.GroupBox Request3;
        private System.Windows.Forms.Button Decline3;
        private System.Windows.Forms.Button Accept3;
        private System.Windows.Forms.Label RequestTitle3;
        private System.Windows.Forms.GroupBox Request1;
        private System.Windows.Forms.Button Decline1;
        private System.Windows.Forms.Button Accept1;
        private System.Windows.Forms.Label RequestTitle1;
        private System.Windows.Forms.GroupBox Request2;
        private System.Windows.Forms.Button Decline2;
        private System.Windows.Forms.Button Accept2;
        private System.Windows.Forms.Label RequestTitle2;
        private System.Windows.Forms.DataGridView MemberData;
        private System.Windows.Forms.Label MemberList;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Button Kick;
        private System.Windows.Forms.Label Actions;
        private System.Windows.Forms.Label SelectedMember;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Label SearchMember;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label NoResult;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Empty;
    }
}