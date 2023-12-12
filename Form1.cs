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
    public partial class Form1 : Form
    {
        public int test = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labTest.Text = "Test" + test.ToString();
            test++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
