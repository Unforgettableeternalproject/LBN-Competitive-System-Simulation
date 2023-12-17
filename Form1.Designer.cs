namespace LBN_Competitive_System_Simulation
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.PictureBox();
            this.Disclaimer = new System.Windows.Forms.PictureBox();
            this.Introduction = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Property = new System.Windows.Forms.PictureBox();
            this.Sign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disclaimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Introduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sign)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_confirm.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_confirm.Location = new System.Drawing.Point(423, 470);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(192, 68);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "知道了";
            this.btn_confirm.UseMnemonic = false;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(-3, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1047, 643);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 1;
            this.Background.TabStop = false;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // Disclaimer
            // 
            this.Disclaimer.Image = ((System.Drawing.Image)(resources.GetObject("Disclaimer.Image")));
            this.Disclaimer.Location = new System.Drawing.Point(303, 72);
            this.Disclaimer.Name = "Disclaimer";
            this.Disclaimer.Size = new System.Drawing.Size(437, 384);
            this.Disclaimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disclaimer.TabIndex = 2;
            this.Disclaimer.TabStop = false;
            this.Disclaimer.Click += new System.EventHandler(this.Disclaimer_Click);
            // 
            // Introduction
            // 
            this.Introduction.Image = ((System.Drawing.Image)(resources.GetObject("Introduction.Image")));
            this.Introduction.Location = new System.Drawing.Point(303, 72);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(437, 384);
            this.Introduction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Introduction.TabIndex = 3;
            this.Introduction.TabStop = false;
            this.Introduction.Click += new System.EventHandler(this.Introduction_Click);
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(693, 197);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(258, 307);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // Property
            // 
            this.Property.Image = ((System.Drawing.Image)(resources.GetObject("Property.Image")));
            this.Property.Location = new System.Drawing.Point(303, 85);
            this.Property.Name = "Property";
            this.Property.Size = new System.Drawing.Size(437, 350);
            this.Property.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Property.TabIndex = 5;
            this.Property.TabStop = false;
            this.Property.Click += new System.EventHandler(this.Property_Click);
            // 
            // Sign
            // 
            this.Sign.Image = ((System.Drawing.Image)(resources.GetObject("Sign.Image")));
            this.Sign.Location = new System.Drawing.Point(-3, 0);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(995, 643);
            this.Sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sign.TabIndex = 6;
            this.Sign.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1041, 639);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.Property);
            this.Controls.Add(this.Disclaimer);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Disclaimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Introduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox Disclaimer;
        private System.Windows.Forms.PictureBox Introduction;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Property;
        private System.Windows.Forms.PictureBox Sign;
    }
}

