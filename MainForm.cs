using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LBN_Competitive_System_Simulation
{
    public partial class MainPage : Form
    {
        static int intro = 0;
        public MainPage()
        {
            InitializeComponent();
            intro = 0;
            Introduction.BackColor = Color.Transparent;
            Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Disclaimer;
            Ball.BackColor = Color.Transparent;
            btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Confirm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (intro)
            {
                case 0:
                    Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Introduction;
                      intro++;
                    break;
                case 1:
                    Introduction.Image = LBN_Competitive_System_Simulation.Properties.Resources.Property;
                    intro++;
                    break;
                case 2:
                    Introduction.Hide();
                    btn_confirm.BackgroundImage = LBN_Competitive_System_Simulation.Properties.Resources.btn_Enter;
                    var next = new LoginFrom();
                    next.Show();
                    break;
                default:
                    break;
            }
        }

        private void Introduction_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }
    }
}
