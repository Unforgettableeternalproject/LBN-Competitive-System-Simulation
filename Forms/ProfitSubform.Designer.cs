namespace LBN_Competitive_System_Simulation.Forms
{
    partial class ProfitSubform
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
            this.Diagram = new System.Windows.Forms.PictureBox();
            this.UserTag = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.Exposure = new System.Windows.Forms.Label();
            this.Status_2 = new System.Windows.Forms.Label();
            this.Status_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // Diagram
            // 
            this.Diagram.BackColor = System.Drawing.Color.Transparent;
            this.Diagram.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Diagram;
            this.Diagram.Location = new System.Drawing.Point(87, 427);
            this.Diagram.Name = "Diagram";
            this.Diagram.Size = new System.Drawing.Size(557, 230);
            this.Diagram.TabIndex = 0;
            this.Diagram.TabStop = false;
            // 
            // UserTag
            // 
            this.UserTag.AutoSize = true;
            this.UserTag.BackColor = System.Drawing.Color.Transparent;
            this.UserTag.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.UserTag.Location = new System.Drawing.Point(895, 99);
            this.UserTag.Name = "UserTag";
            this.UserTag.Size = new System.Drawing.Size(84, 25);
            this.UserTag.TabIndex = 1;
            this.UserTag.Text = "用戶名";
            // 
            // Membership
            // 
            this.Membership.AutoSize = true;
            this.Membership.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 18F);
            this.Membership.Location = new System.Drawing.Point(946, 209);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(108, 25);
            this.Membership.TabIndex = 10;
            this.Membership.Text = "普通會員";
            // 
            // Profit
            // 
            this.Profit.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 36F);
            this.Profit.Location = new System.Drawing.Point(762, 467);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(195, 48);
            this.Profit.TabIndex = 11;
            this.Profit.Text = "0";
            this.Profit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Profit.Click += new System.EventHandler(this.Profit_Click);
            // 
            // Exposure
            // 
            this.Exposure.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 36F);
            this.Exposure.Location = new System.Drawing.Point(1031, 467);
            this.Exposure.Name = "Exposure";
            this.Exposure.Size = new System.Drawing.Size(190, 48);
            this.Exposure.TabIndex = 12;
            this.Exposure.Text = "0";
            this.Exposure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_2
            // 
            this.Status_2.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 36F);
            this.Status_2.ForeColor = System.Drawing.Color.LimeGreen;
            this.Status_2.Location = new System.Drawing.Point(422, 168);
            this.Status_2.Name = "Status_2";
            this.Status_2.Size = new System.Drawing.Size(236, 48);
            this.Status_2.TabIndex = 13;
            this.Status_2.Text = "安全";
            this.Status_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_1
            // 
            this.Status_1.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 36F);
            this.Status_1.ForeColor = System.Drawing.Color.Firebrick;
            this.Status_1.Location = new System.Drawing.Point(74, 168);
            this.Status_1.Name = "Status_1";
            this.Status_1.Size = new System.Drawing.Size(236, 48);
            this.Status_1.TabIndex = 14;
            this.Status_1.Text = "尚無刊登";
            this.Status_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfitSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Profits;
            this.ClientSize = new System.Drawing.Size(1284, 740);
            this.Controls.Add(this.Status_1);
            this.Controls.Add(this.Status_2);
            this.Controls.Add(this.Exposure);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.UserTag);
            this.Controls.Add(this.Diagram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfitSubform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProfitSubform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Diagram;
        private System.Windows.Forms.Label UserTag;
        private System.Windows.Forms.Label Membership;
        private System.Windows.Forms.Label Profit;
        private System.Windows.Forms.Label Exposure;
        private System.Windows.Forms.Label Status_2;
        private System.Windows.Forms.Label Status_1;
    }
}