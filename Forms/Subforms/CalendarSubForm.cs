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
    public partial class CalendarSubForm : Form
    { 
        private List<Proposal> eventList = null;
        private DateTime selectedDate;
        private int timeSpan = 0;
        private List<string> eventName = new List<string>();
        private string Mode = "View";
        private readonly string prompt = "輸入活動名稱...";
        private bool hasEvent = false, isDefault = true;
        public CalendarSubForm()
        {
            InitializeComponent();
            EventName.Enter += EventName_Enter;
            EventName.Leave += EventName_Leave;
        }

        public void getProposals(List<Proposal> input)
        {
            eventList = input;
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
                if(eventName.Count <= 10) AdditionalDisplay.SetToolTip(EventDisplay, "還有以下活動:\n" + string.Join("\n", eventName));
                else AdditionalDisplay.SetToolTip(EventDisplay, "還有以下活動:\n" + string.Join("\n", eventName.Take(10)) + "\n等...");
            }
        }
        private void updateEvent()
        {
            throw new NotImplementedException();
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
                            EventName.Text = eventName.Count > 1 ? $"{eventName.Count-1}個活動" : eventName[0];
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
                        EventName.Text = eventName.Count > 1 ? $"{eventName[0]} 以及其他 {eventName.Count - 1} 個..." : eventName[0];
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
            Console.WriteLine(selectedDate);
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
            AddEvent.Show();
            DeleteEvent.Show();
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
            eInit("A");
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            eInit("R");
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(Mode == "Edit-A")
            {
                if (string.IsNullOrEmpty(EventName.Text) || isDefault) { MessageBox.Show("您沒有填寫活動名稱!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                updateEvent();
            }else if(Mode == "Edit-R")
            {
                if(!hasEvent) { MessageBox.Show("您並沒有選擇具有活動的有效日期!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                if (eventName.Count == 1) goto SkipQuestion;
                DialogResult result = MessageBox.Show("這麼做將會刪除此時間段上的所有活動，是否確定繼續?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No) return;
            SkipQuestion:
                updateEvent();
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            vInit();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.MinDate = StartDate.Value;
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
    }
}
