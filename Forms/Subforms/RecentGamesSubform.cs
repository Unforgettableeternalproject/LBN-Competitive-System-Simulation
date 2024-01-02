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
    public partial class RecentGamesSubform : Form
    {
        //▲▼
        private List<Proposal> eventList = new List<Proposal>();
        private DateTime updateTime;
        public List<Proposal> EventList { get => eventList; set { eventList = value; updateTime = DateTime.Now; } }
        public DateTime UpdateTime => updateTime;
        public RecentGamesSubform()
        {
            InitializeComponent();
        }

        private void RecentGamesSubform_Load(object sender, EventArgs e)
        {
            Recent7Days.Hide();
            Recent30Days.Hide();
            lbl_7.Text = "近七天的賽事 ▲";
            lbl_30.Text = "近三十天的賽事 ▲";
            foreach(Control c in Recent7Days.Controls)
            {
                c.Hide();
            }
            foreach (Control c in Recent30Days.Controls)
            {
                c.Hide();
            }
            updateEvent();
        }

        private void updateEvent()
        {
            var in7days = eventList.Where(e => e.Date > DateTime.Now && e.Date <= DateTime.Now.AddDays(7)).ToList();
            var in30days = eventList.Where(e => e.Date > DateTime.Now.AddDays(7) && e.Date <= DateTime.Now.AddDays(30)).ToList();

            UpdateEventDisplay(in7days, Recent7Days, "7");
            UpdateEventDisplay(in30days, Recent30Days, "30");
        }
        private void UpdateEventDisplay(List<Proposal> events, GroupBox groupBox, string prefix)
        {
            // Hide all labels and buttons initially
            for (int i = 1; i <= 3; i++)
            {
                groupBox.Controls[$"lbl_Game_{prefix}_{i}"].Visible = false;
                groupBox.Controls[$"Apply_{prefix}_{i}"].Visible = false;
                groupBox.Controls[$"Ignore_{prefix}_{i}"].Visible = false;
            }

            // Limit the number of events to display
            int maxEventsToShow = Math.Min(events.Count, 3);

            for (int i = 0; i < maxEventsToShow; i++)
            {
                // Set the text for the label
                groupBox.Controls[$"lbl_Game_{prefix}_{i + 1}"].Text = $"Game {i + 1}: {events[i].LeagueName}";

                // Set visibility for label and buttons
                groupBox.Controls[$"lbl_Game_{prefix}_{i + 1}"].Visible = true;
                groupBox.Controls[$"Apply_{prefix}_{i + 1}"].Tag = events[i];
                groupBox.Controls[$"Apply_{prefix}_{i + 1}"].Visible = true;
                groupBox.Controls[$"Ignore_{prefix}_{i + 1}"].Tag = events[i];
                groupBox.Controls[$"Ignore_{prefix}_{i + 1}"].Visible = true;
            }
        }
        private void lbl_7_Click(object sender, EventArgs e)
        {
            if (Recent7Days.Visible)
            {
                lbl_7.Text = "近七天的賽事 ▲";
                Recent7Days.Hide();
            }
            else
            {
                lbl_7.Text = "近七天的賽事 ▼";
                Recent7Days.Show();
            }
        }
        private void lbl_30_Click(object sender, EventArgs e)
        {
            if (Recent30Days.Visible)
            {
                lbl_30.Text = "近三十天的賽事 ▲";
                Recent30Days.Hide();
            }
            else
            {
                lbl_30.Text = "近三十天的賽事 ▼";
                Recent30Days.Show();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            HandleApplication(sender as Button);
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {
            HandleApplication(sender as Button);
        }

        private void HandleApplication(Button button)
        {
            if (button != null && button.Tag is Proposal selectedEvent)
            {
                // Handle the application or ignore logic here

                // Remove the event from the list
                eventList.Remove(selectedEvent);

                // Update the display for both group boxes
                updateEvent();
            }
        }
    }
}
