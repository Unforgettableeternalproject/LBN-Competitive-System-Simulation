using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class ProfitSubform : Form
    {
        private ID userID;
        private bool isDeployed;
        private int default_Profit, default_Exposure;
        public ProfitSubform(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
            Random random = new Random();
            default_Profit = random.Next(100);
            default_Exposure = random.Next(560);
        }
        public void setStatus(bool _isDeployed)
        {
            isDeployed = _isDeployed;
            if (isDeployed)
            {
                Diagram.Show();
                Status_1.Text = "刊登中";
                Status_1.ForeColor = Color.LimeGreen;
                Status_2.Text = "安全";
                Status_2.ForeColor = Color.LimeGreen;
                Profit.Text = default_Profit.ToString();
                Exposure.Text = default_Exposure.ToString();

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

        private void Profit_Click(object sender, EventArgs e)
        {

        }
    }
}
