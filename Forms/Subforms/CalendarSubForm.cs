using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class CalendarSubform : Form
    { 
        private List<Proposal> eventList = new List<Proposal>();
        private DateTime selectedDate, updateTime;
        private int timeSpan = 0;
        private List<string> eventName = new List<string>();
        private string Mode = "View";
        private readonly string prompt = "輸入活動名稱...";
        private bool hasEvent = false, isDefault = true, editable = true;
        public List<Proposal> EventList
        {
            get => eventList;
            set { eventList = value; updateTime = DateTime.Now; }
        }
        public DateTime UpdateTime => updateTime;

        public CalendarSubform(bool _editable)
        {
            InitializeComponent();
            EventName.Enter += EventName_Enter;
            EventName.Leave += EventName_Leave;
            editable = _editable;
        }

        private void CalendarSubForm_Load(object sender, EventArgs e)
        {
            selectedDate = DateTime.Now;
            vInit();
            updateDisplay();
        }
        private void updateDisplay()
        {
            eventName = new List<string>();
            if (eventList == null) { EventDisplay.Text = $"預排活動:\n本日沒有活動!"; AdditionalDisplay.SetToolTip(EventDisplay, ""); hasEvent = false; return; }
            foreach (Proposal proposal in eventList)
            {
                if (DateTime.Compare(selectedDate.Date, proposal.Date.Date) >= 0 && DateTime.Compare(selectedDate.Date, proposal.Date.AddDays(proposal.DurationDays).Date) <= 0) { Console.WriteLine($"Found!"); eventName.Add($"{proposal.LeagueName} : {proposal.GameType}"); }
            }

            if (eventName.Count != 0) { EventDisplay.Text = $"預排活動:\n{eventName[0]}"; hasEvent = true; }
            else { EventDisplay.Text = $"預排活動:\n本日沒有活動!"; AdditionalDisplay.SetToolTip(EventDisplay, ""); hasEvent = false; }
            if (eventName.Count > 1)
            {
                EventDisplay.Text += $"\n\n還有 {eventName.Count-1} 個其他活動...";
                if(eventName.Count <= 10) AdditionalDisplay.SetToolTip(EventDisplay, "還有以下活動:\n" + string.Join("\n", eventName.Skip(1)));
                else AdditionalDisplay.SetToolTip(EventDisplay, "還有以下活動:\n" + string.Join("\n", eventName.Skip(1).Take(10)) + "\n等...");
            }
        }
        private void updateEvent()
        {
            switch (Mode)
            {
                case "Edit-A":
                    eventList.Add(new Proposal("管理員", StartDate.Value, EventName.Text, "", EndDate.Value.Subtract(StartDate.Value).Days));
                    break;
                case "Edit-R":
                    eventList.RemoveAll(e => DateTime.Compare(StartDate.Value.Date, e.Date.Date) >= 0 && DateTime.Compare(StartDate.Value.Date, e.Date.AddDays(e.DurationDays).Date) <= 0);
                    break;
            }
            updateTime = DateTime.Now;
            Calendar.MaxSelectionCount = 1;
            Calendar.SelectionStart = Calendar.TodayDate;
            updateFill(true);
        }

        private void updateFill(bool init)
        {
            if (init)
            {
                switch (Mode)
                {
                    case "Edit-A":
                        Calendar.MaxSelectionCount = 14;
                        EventName.Text = prompt;
                        EventName.ForeColor = SystemColors.GrayText;
                        StartDate.Value = selectedDate;
                        EndDate.Value = selectedDate.AddDays(timeSpan);
                        EventName.Enabled = true;
                        StartDate.Enabled = true;
                        EndDate.Enabled = true;
                        break;
                    case "Edit-R":
                        Calendar.MaxSelectionCount = 1;
                        if (!hasEvent)
                        {
                            EventName.Text = "選擇有活動的日期...";
                            EventName.ForeColor = SystemColors.GrayText;
                            StartDate.Value = selectedDate;
                            EndDate.Value = selectedDate.AddDays(timeSpan);
                            EventName.Enabled = false;
                            StartDate.Enabled = false;
                            EndDate.Enabled = false;
                        }
                        else
                        {
                            EventName.Text = eventName.Count > 1 ? $"{eventName.Count}個活動" : eventName[0];
                            EventName.ForeColor = SystemColors.GrayText;
                            StartDate.Value = selectedDate;
                            EndDate.Value = selectedDate.AddDays(timeSpan);
                            EventName.Enabled = false;
                            StartDate.Enabled = false;
                            EndDate.Enabled = false;
                        }
                        break;
                }
            }
            else
            {
                if (Mode == "Edit-R")
                {
                    if (!hasEvent)
                    {
                        EventName.Text = "選擇有活動的日期...";
                        EventName.ForeColor = SystemColors.GrayText;
                        StartDate.Value = selectedDate;
                        EndDate.Value = selectedDate.AddDays(timeSpan);
                        EventName.Enabled = false;
                        StartDate.Enabled = false;
                        EndDate.Enabled = false;
                    }
                    else
                    {
                        EventName.Text = eventName.Count > 1 ? $"{eventName.Count - 1}個活動" : eventName[0];
                        EventName.ForeColor = SystemColors.GrayText;
                        StartDate.Value = selectedDate;
                        EndDate.Value = selectedDate.AddDays(timeSpan);
                        EventName.Enabled = false;
                        StartDate.Enabled = false;
                        EndDate.Enabled = false;
                    }
                }
                else if (Mode == "Edit-A")
                {
                    EventName.ForeColor = SystemColors.GrayText;
                    StartDate.Value = selectedDate;
                    EndDate.Value = selectedDate.AddDays(timeSpan);
                    EventName.Enabled = true;
                    StartDate.Enabled = true;
                    EndDate.Enabled = true;
                }
            }
        }
        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = Calendar.SelectionStart;
            timeSpan = (int)(Calendar.SelectionEnd - Calendar.SelectionStart).TotalDays;
            updateDisplay();
            if(Mode != "View") updateFill(false);
        }

        private void vInit()
        {
            Mode = "View";
            Calendar.MaxSelectionCount = 1;
            EventName.Hide();
            EventName.Text = "";
            Confirm.Hide();
            Cancel.Hide();
            StartDate.Hide();
            To.Hide();
            EndDate.Hide();
            if (editable) { AddEvent.Show(); DeleteEvent.Show(); }
            else { AddEvent.Hide(); DeleteEvent.Hide(); }
        }

        private void eInit(string subMode)
        {
            Mode = $"Edit-{subMode}";
            AddEvent.Hide();
            DeleteEvent.Hide();
            EventName.Show();
            To.Show();
            StartDate.Show();
            EndDate.Show();
            Confirm.Show();
            Cancel.Show();
            updateFill(true);
        }
        private void AddEvent_Click(object sender, EventArgs e)
        {
            Confirm.Text = "確認添加";
            eInit("A");
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            Confirm.Text = "確認刪除";
            eInit("R");
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(Mode == "Edit-A")
            {
                if (string.IsNullOrEmpty(EventName.Text) || isDefault) { MessageBox.Show("您沒有填寫活動名稱!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                updateEvent();
                MessageBox.Show("已經成功添加活動!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(Mode == "Edit-R")
            {
                if(!hasEvent) { MessageBox.Show("您並沒有選擇具有活動的有效日期!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (eventName.Count == 1) goto SkipQuestion;
                DialogResult result = MessageBox.Show("這麼做將會刪除此時間段上的所有活動，是否確定繼續?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No) return;
            SkipQuestion:
                updateEvent();
                MessageBox.Show("已經成功刪除活動!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            vInit();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            if (selectedDate.AddDays(14) < EndDate.MinDate) EndDate.MinDate = selectedDate; ;
            EndDate.MaxDate = selectedDate.AddDays(14);
            EndDate.MinDate = selectedDate;
        }

        private void EventName_Enter(object sender, EventArgs e)
        {
            if (EventName.Text == prompt)
            {
                isDefault = false;
                EventName.Text = string.Empty;
                EventName.ForeColor = SystemColors.ControlText;
            }
        }

        private void EventName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EventName.Text.Trim()))
            {
                isDefault = true;
                EventName.Text = prompt;
                EventName.ForeColor = SystemColors.GrayText;
            }
        }
        #region UnitTest
        public DialogResult NewEvent()
        {
            AddEvent.PerformClick();
            EventName.Text = "測試"; isDefault = false;
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now.AddDays(5);
            Confirm.PerformClick();
            return DialogResult.OK;
        }
        #endregion
    }
}
