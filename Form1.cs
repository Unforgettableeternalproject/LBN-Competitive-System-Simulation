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
            Background.Controls.Add(Sign);
            Sign.Controls.Add(Disclaimer);
            Sign.Controls.Add(Introduction);
            Sign.Controls.Add(Property);
            Sign.Controls.Add(Ball);


            Sign.Location = new Point(0, 0);
            btn_confirm.Location = new Point(423, 470);
            Background.Location = new Point(0, 0);
            Disclaimer.Location = new Point(300, 70);
            Introduction.Location = new Point(300, 70);
            Property.Location = new Point(300, 93);
            Ball.Location = new Point(700, 150);
            Background.BackColor = Color.Transparent;
            Disclaimer.BackColor = Color.Transparent;
            Introduction.BackColor = Color.Transparent;
            Property.BackColor = Color.Transparent;
            Ball.BackColor = Color.Transparent;
            Sign.BackColor = Color.Transparent;
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
                    Property.Hide();
                    btn_confirm.Text = "進入!";
                    btn_confirm.Location = new Point(400, 250);
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

        private void Property_Click(object sender, EventArgs e)
        {

        }

        private void Background_2_Click(object sender, EventArgs e)
        {

        }
    }
}
