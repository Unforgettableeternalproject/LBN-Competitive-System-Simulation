namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class SystemLogSubForm
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
            this.SLWindow = new System.Windows.Forms.RichTextBox();
            this.ClearLog = new System.Windows.Forms.Button();
            this.CopytoClipBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SLWindow
            // 
            this.SLWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SLWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLWindow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SLWindow.Location = new System.Drawing.Point(77, 51);
            this.SLWindow.Name = "SLWindow";
            this.SLWindow.Size = new System.Drawing.Size(954, 565);
            this.SLWindow.TabIndex = 0;
            this.SLWindow.Text = "LBN 競技賽事系統 系統紀錄";
            // 
            // ClearLog
            // 
            this.ClearLog.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLog.Location = new System.Drawing.Point(77, 661);
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(149, 58);
            this.ClearLog.TabIndex = 1;
            this.ClearLog.Text = "清除所有紀錄";
            this.ClearLog.UseVisualStyleBackColor = true;
            // 
            // CopytoClipBoard
            // 
            this.CopytoClipBoard.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopytoClipBoard.Location = new System.Drawing.Point(882, 661);
            this.CopytoClipBoard.Name = "CopytoClipBoard";
            this.CopytoClipBoard.Size = new System.Drawing.Size(149, 58);
            this.CopytoClipBoard.TabIndex = 2;
            this.CopytoClipBoard.Text = "複製到剪貼簿";
            this.CopytoClipBoard.UseVisualStyleBackColor = true;
            // 
            // SystemLogSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.SLPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.CopytoClipBoard);
            this.Controls.Add(this.ClearLog);
            this.Controls.Add(this.SLWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemLogSubForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SLWindow;
        private System.Windows.Forms.Button ClearLog;
        private System.Windows.Forms.Button CopytoClipBoard;
    }
}