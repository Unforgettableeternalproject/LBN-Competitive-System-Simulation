using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class LeagueDutySubform : Form
    {
        private ID userID;
        private League affiliatedLeague = null;
        private bool inLeague;
        public LeagueDutySubform(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
            inLeague = IsInLeague();
        }

        private void LeagueDutySubform_Load(object sender, EventArgs e)
        {
            if (inLeague) { InLeague.Show(); OutLeague.Hide(); }
            else { OutLeague.Show(); InLeague.Hide(); }
        }
        private bool IsInLeague()
        {
            bool result = false;
            var leagueList = JsonConvert.DeserializeObject<List<League>>(File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
            foreach (League league in leagueList)
            {
                if (league.Members.Any(e => e.UUID == userID.UUID)) { result = true; affiliatedLeague = league; }
            }
            return result;
        }
    }
}
