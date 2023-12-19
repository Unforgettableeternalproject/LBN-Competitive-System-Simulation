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
            this.components = new System.ComponentModel.Container();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Introduction = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.LoadingSpinner = new System.Windows.Forms.PictureBox();
            this.RedirectingTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Introduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
            this.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_confirm.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_confirm.Location = new System.Drawing.Point(986, 924);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(390, 152);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.UseMnemonic = false;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Introduction
            // 
            this.Introduction.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Disclaimer;
            this.Introduction.Location = new System.Drawing.Point(520, 106);
            this.Introduction.Margin = new System.Windows.Forms.Padding(6);
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(1313, 932);
            this.Introduction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Introduction.TabIndex = 3;
            this.Introduction.TabStop = false;
            this.Introduction.Click += new System.EventHandler(this.Introduction_Click);
            // 
            // Ball
            // 
            this.Ball.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Golf;
            this.Ball.Location = new System.Drawing.Point(1844, 728);
            this.Ball.Margin = new System.Windows.Forms.Padding(6);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(494, 556);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // LoadingSpinner
            // 
            this.LoadingSpinner.BackColor = System.Drawing.Color.Transparent;
            this.LoadingSpinner.Image = global::LBN_Competitive_System_Simulation.Properties.Resources.Spinner;
            this.LoadingSpinner.Location = new System.Drawing.Point(923, 254);
            this.LoadingSpinner.Name = "LoadingSpinner";
            this.LoadingSpinner.Size = new System.Drawing.Size(512, 512);
            this.LoadingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingSpinner.TabIndex = 5;
            this.LoadingSpinner.TabStop = false;
            // 
            // RedirectingTimer
            // 
            this.RedirectingTimer.Interval = 1000;
            this.RedirectingTimer.Tick += new System.EventHandler(this.RedirectingTimer_Tick);
            // 
            // WelcomeDisplay
            // 
            this.WelcomeDisplay.AutoSize = true;
            this.WelcomeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeDisplay.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(161)))));
            this.WelcomeDisplay.Location = new System.Drawing.Point(434, 279);
            this.WelcomeDisplay.Name = "WelcomeDisplay";
            this.WelcomeDisplay.Size = new System.Drawing.Size(232, 96);
            this.WelcomeDisplay.TabIndex = 6;
            this.WelcomeDisplay.Text = "訊息";
            this.WelcomeDisplay.Click += new System.EventHandler(this.WelcomeDisplay_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2256, 1100);
            this.Controls.Add(this.WelcomeDisplay);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.LoadingSpinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Introduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox Introduction;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox LoadingSpinner;
        private System.Windows.Forms.Timer RedirectingTimer;
        private System.Windows.Forms.Label WelcomeDisplay;
    }
}

