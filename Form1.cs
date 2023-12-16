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
using System.Drawing.Imaging;
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
            Background.Controls.Add(Disclaimer);
            Background.Controls.Add(Introduction);
            Background.Controls.Add(Ball);
            Disclaimer.Location = new Point(300, -30);
            Introduction.Location = new Point(300, -30);
            Ball.Location = new Point(950, 200);
            Disclaimer.BackColor = Color.Transparent;
            Introduction.BackColor = Color.Transparent;
            Ball.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (intro)
            {
                case 0:
                    Disclaimer.Hide();
                    intro++;
                    break;
                case 1:
                    Introduction.Hide();
                    intro++;
                    break;
                case 2:
                    btn_confirm.Text = "進入!";
                    break;
                default:
                    break;
            }
        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void Disclaimer_Click(object sender, EventArgs e)
        {

        }

        private void Introduction_Click(object sender, EventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

    }
}
