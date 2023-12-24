using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LBN_Competitive_System_Simulation.Forms
{
    public partial class DeploymentSubform : Form
    {
        private ID userID;
        private double[] arguments = new double[2] {0,0};
        private bool updated = false;

        private Dictionary<string, int> prices = new Dictionary<string, int>(3)
        {
            { "主要瀏覽頁面中右側", 15 },
            { "實況頁面下方", 18 },
            { "左側工作欄下方", 25 }
        };
       
        public DeploymentSubform(ID _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void DeploymentSubform_Load(object sender, EventArgs e)
        {
            ChooseLocation.SelectedItem = null;
            ChooseLocation.SelectedText = "選擇位置";
            Warning_1.Hide();
            UserTag.Text = userID.Username;
            EndDate.MinDate = StartDate.Value;
            Tick.Start();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            Bitmap image;

            OpenFileDialog of = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg",
                FilterIndex = 1
            };

            if (of.ShowDialog() == DialogResult.OK) { image = new Bitmap(of.FileName); AdPreview.Image = image; }
            else MessageBox.Show("圖片檔案出現錯誤，請重新嘗試.", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ChooseLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPos = ChooseLocation.SelectedItem;

            if (currentPos == null) Warning_1.Show();
            else
            {
                arguments[0] = prices[currentPos.ToString()];
            }
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.MinDate = StartDate.Value;
            if (updated) arguments[1] = EndDate.Value.Subtract(StartDate.Value).TotalDays*0.1;
        }
        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            if(!updated) updated = true;
            arguments[1] = EndDate.Value.Subtract(StartDate.Value).TotalDays* 0.35;
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            double total = arguments[0]*1.2*arguments[1];
            Console.WriteLine($"{arguments[0]}, {arguments[1]}");
            Cost.Text = $"{(int)total} 元 (美金)";
        }
    }
}
