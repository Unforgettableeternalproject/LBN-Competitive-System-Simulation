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
    public partial class AdminMainForm : Form
    {
        private ID userID;
        public AdminMainForm(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void ViewAsPlayer_Click(object sender, EventArgs e)
        {

        }

        private void UserManagement_Click(object sender, EventArgs e)
        {

        }

        private void SwitchRole_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
