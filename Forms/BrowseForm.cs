using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBN_Competitive_System_Simulation
{
    public partial class BrowseForm : Form
    {
        private ID userID;

        private void browseInit()
        {
            this.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.Browse;
            WelcomeMessage.Show();
            MoreInfo.Show();
            Contact.Show();
            ExampleVideo.Show();
        }

        private void streamInit()
        {
            this.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.Stream;
            WelcomeMessage.Hide();
            MoreInfo.Hide();
            Contact.Hide();
            ExampleVideo.Hide();
        }
        public BrowseForm(ID userID)
        {
            InitializeComponent();
            browseInit();
            this.userID = userID;
            WelcomeMessage.Text = $"歡迎回來, {userID.Username}!\n\n今天想要觀看甚麼賽事?";
        }

        private void WelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {

        }

        private void ExampleVideo_Click(object sender, EventArgs e)
        {
            streamInit();
        }
    }
}
