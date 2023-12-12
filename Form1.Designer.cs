namespace LBN_Competitive_System_Simulation
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_enter = new System.Windows.Forms.Button();
            this.labTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(435, 264);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(415, 135);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "進入";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // labTest
            // 
            this.labTest.AutoSize = true;
            this.labTest.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTest.Location = new System.Drawing.Point(607, 431);
            this.labTest.Name = "labTest";
            this.labTest.Size = new System.Drawing.Size(67, 34);
            this.labTest.TabIndex = 1;
            this.labTest.Text = "Test";
            this.labTest.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1334, 697);
            this.Controls.Add(this.labTest);
            this.Controls.Add(this.btn_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label labTest;
    }
}

