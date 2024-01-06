using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class MemberManagerSubform : Form
    {
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private GroupBox groupBox4;
        private Button button5;
        private Button button6;
        private Label label3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private TextBox SearchTXT;
        private Button SearchBTN;
        private Label label7;
        private Label label8;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;

        public MemberManagerSubform()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTXT = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(168, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "加入請求: 來自{}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "接受";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(253, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "拒絕";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(168, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(253, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "拒絕";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(115, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "接受";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label2.Location = new System.Drawing.Point(0, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "加入請求: 來自{}";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.NewRequest1;
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(1, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 127);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(253, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "拒絕";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(115, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 38);
            this.button6.TabIndex = 1;
            this.button6.Text = "接受";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label3.Location = new System.Drawing.Point(0, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "加入請求: 來自{}";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "還有 {} 個其他請求...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 211);
            this.dataGridView1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.label5.Location = new System.Drawing.Point(922, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "成員列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label6.Location = new System.Drawing.Point(748, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "搜尋成員:";
            // 
            // SearchTXT
            // 
            this.SearchTXT.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchTXT.Location = new System.Drawing.Point(858, 394);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.Size = new System.Drawing.Size(289, 30);
            this.SearchTXT.TabIndex = 7;
            this.SearchTXT.Text = "輸入成員名稱...";
            // 
            // SearchBTN
            // 
            this.SearchBTN.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Search;
            this.SearchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBTN.Location = new System.Drawing.Point(1157, 394);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(30, 30);
            this.SearchBTN.TabIndex = 8;
            this.SearchBTN.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label7.Location = new System.Drawing.Point(726, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "選取的成員: 無";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.label8.Location = new System.Drawing.Point(748, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "進行動作:";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(869, 539);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 37);
            this.button7.TabIndex = 11;
            this.button7.Text = "踢出成員";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(983, 539);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 37);
            this.button8.TabIndex = 12;
            this.button8.Text = "封禁成員";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(1100, 539);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 37);
            this.button9.TabIndex = 13;
            this.button9.Text = "聯絡成員";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // MemberManagerSubform
            // 
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.MMPage;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberManagerSubform";
            this.Load += new System.EventHandler(this.MemberManagerSubform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MemberManagerSubform_Load(object sender, EventArgs e)
        {

        }
    }
}
