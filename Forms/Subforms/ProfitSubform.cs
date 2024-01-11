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
    /// <summary>
    /// Provides function to view estimated revenue for the advertisers.
    /// </summary>
    public partial class ProfitSubform : Form
    {
        private ID userID;
        private bool isDeployed;
        public ProfitSubform(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
        }
        public void setStatus(bool _isDeployed, double costTotal)
        {
            isDeployed = _isDeployed;
            if (isDeployed)
            {
                Random random = new Random();
                Diagram.Show();
                Status_1.Text = "刊登中";
                Status_1.ForeColor = Color.LimeGreen;
                Status_2.Text = "安全";
                Status_2.ForeColor = Color.LimeGreen;
                Profit.Text = random.Next((int)costTotal + 50).ToString();
                Exposure.Text = random.Next((int)costTotal + 350).ToString();

            }
            else
            {
                Diagram.Hide();
                Status_1.Text = "尚未刊登";
                Status_1.ForeColor = Color.Firebrick;
                Status_2.Text = "無";
                Status_2.ForeColor = Color.Firebrick;
                Profit.Text = "0";
                Exposure.Text = "0";
            }
        }
        private void ProfitSubform_Load(object sender, EventArgs e)
        {
            UserTag.Text = userID.Username;
        }
    }
}
