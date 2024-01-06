namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class MemberManagerSubform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

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
            this.JoinRequests = new System.Windows.Forms.GroupBox();
            this.Request1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Kick = new System.Windows.Forms.Button();
            this.Ban = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.JoinRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // JoinRequests
            // 
            this.JoinRequests.BackColor = System.Drawing.Color.Transparent;
            this.JoinRequests.Controls.Add(this.label1);
            this.JoinRequests.Controls.Add(this.groupBox1);
            this.JoinRequests.Controls.Add(this.Request1);
            this.JoinRequests.Location = new System.Drawing.Point(166, 156);
            this.JoinRequests.Name = "JoinRequests";
            this.JoinRequests.Size = new System.Drawing.Size(476, 490);
            this.JoinRequests.TabIndex = 0;
            this.JoinRequests.TabStop = false;
            // 
            // Request1
            // 
            this.Request1.Location = new System.Drawing.Point(0, 18);
            this.Request1.Name = "Request1";
            this.Request1.Size = new System.Drawing.Size(475, 121);
            this.Request1.TabIndex = 0;
            this.Request1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(166, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "還有 {} 個其他請求...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(710, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 256);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "成員列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "搜尋成員:";
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchTXT.Location = new System.Drawing.Point(867, 409);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(323, 30);
            this.SearchTXT.TabIndex = 5;
            this.SearchTXT.Text = "輸入成員名稱...";
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Search;
            this.SearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBTN.Location = new System.Drawing.Point(1207, 409);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(30, 30);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "進行動作:";
            // 
            // Kick
            // 
            this.Kick.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kick.Location = new System.Drawing.Point(867, 559);
            this.Kick.Name = "Kick";
            this.Kick.Size = new System.Drawing.Size(96, 37);
            this.Kick.TabIndex = 8;
            this.Kick.Text = "踢出成員";
            this.Kick.UseVisualStyleBackColor = true;
            // 
            // Ban
            // 
            this.Ban.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.Location = new System.Drawing.Point(1000, 559);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(96, 37);
            this.Ban.TabIndex = 9;
            this.Ban.Text = "封禁成員";
            this.Ban.UseVisualStyleBackColor = true;
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(1131, 559);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(96, 37);
            this.Contact.TabIndex = 10;
            this.Contact.Text = "聯絡成員";
            this.Contact.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(724, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "選擇的成員: 無";
            // 
            // MemberManagerSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.MMPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.Kick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.JoinRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberManagerSubform";
            this.Text = "Form1";
            this.JoinRequests.ResumeLayout(false);
            this.JoinRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox JoinRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Request1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTXT;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Kick;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Label label5;
    }
}