namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    partial class CalendarSubForm
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.EventDisplay = new System.Windows.Forms.Label();
            this.AddEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.EventName = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.AdditionalDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.Menu;
            this.Calendar.CalendarDimensions = new System.Drawing.Size(3, 4);
            this.Calendar.Location = new System.Drawing.Point(109, 82);
            this.Calendar.MaxSelectionCount = 14;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // EventDisplay
            // 
            this.EventDisplay.AutoEllipsis = true;
            this.EventDisplay.BackColor = System.Drawing.Color.Transparent;
            this.EventDisplay.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 16F);
            this.EventDisplay.Location = new System.Drawing.Point(800, 107);
            this.EventDisplay.Name = "EventDisplay";
            this.EventDisplay.Size = new System.Drawing.Size(242, 164);
            this.EventDisplay.TabIndex = 1;
            this.EventDisplay.Text = "預排活動:";
            // 
            // AddEvent
            // 
            this.AddEvent.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15F);
            this.AddEvent.Location = new System.Drawing.Point(801, 382);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(221, 54);
            this.AddEvent.TabIndex = 2;
            this.AddEvent.Text = "新增活動";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 15F);
            this.DeleteEvent.Location = new System.Drawing.Point(801, 478);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(221, 54);
            this.DeleteEvent.TabIndex = 4;
            this.DeleteEvent.Text = "刪除活動";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // EventName
            // 
            this.EventName.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EventName.Location = new System.Drawing.Point(801, 397);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(221, 30);
            this.EventName.TabIndex = 5;
            this.EventName.Text = "輸入活動名稱...";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(817, 596);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(84, 36);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "確認添加";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(801, 450);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(221, 30);
            this.StartDate.TabIndex = 7;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.BackColor = System.Drawing.Color.Transparent;
            this.To.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(899, 496);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(28, 19);
            this.To.TabIndex = 8;
            this.To.Text = "至";
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(801, 542);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(221, 30);
            this.EndDate.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("腾祥睿黑GB18030-W3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(921, 596);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 36);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "放棄離開";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CalendarSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LBN_Competitive_System_Simulation.Properties.Resources.SLPage;
            this.ClientSize = new System.Drawing.Size(1108, 777);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.To);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.EventDisplay);
            this.Controls.Add(this.Calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarSubForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CalendarSubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.ToolTip AdditionalDisplay;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.Label EventDisplay;
    }
}