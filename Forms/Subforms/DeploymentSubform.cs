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

namespace LBN_Competitive_System_Simulation.Forms.Subforms
{
    public partial class DeploymentSubform : Form
    {
        private ID userID;
        private double[] arguments = new double[2] { 0, 0 };
        private bool updated = false, isDeployed = false;
        private object[] image = new object[]  { null, null };
        private double total;

        public bool IsDeployed
        {
            get { return isDeployed; }
        }
        public double Total
        {
            get { return total; }
        }
        public object[] Image
        {
            get { return image; }
        }

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
            UploadIndicator.Hide();
            Tick.Start();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg",
                FilterIndex = 1
            };

            UploadIndicator.Show();

            if (of.ShowDialog() == DialogResult.OK) 
            {
                image[0] = new Bitmap(of.FileName); 
                AdPreview.Image = (Bitmap)image[0];
                UploadIndicator.Text = "上傳成功!";
                UploadIndicator.ForeColor = Color.LimeGreen;
            }
            else
            {
                MessageBox.Show("圖片檔案出現錯誤，請重新嘗試.", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UploadIndicator.Text = "上傳失敗!";
                UploadIndicator.ForeColor = Color.Firebrick;
            } 
        }

        private void ChooseLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            image[1] = ChooseLocation.SelectedItem;

            if (image[1] == null) Warning_1.Show();
            else
            {
                arguments[0] = prices[image[1].ToString()];
            }
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.MinDate = StartDate.Value;
            if (updated) arguments[1] = EndDate.Value.Subtract(StartDate.Value).TotalDays * 0.75;
        }
        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            if(!updated) updated = true;
            arguments[1] = EndDate.Value.Subtract(StartDate.Value).TotalDays * 0.75;
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            total = arguments[0]*1.2*arguments[1];
            Cost.Text = $"{(int)total} 元 (美金)";
        }

        private void btn_deploy_Click(object sender, EventArgs e)
        {
            if (isDeployed) { MessageBox.Show("你已經有一個正在部屬的廣告!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipDeployment; }
            if (image == null) { MessageBox.Show("你尚未上傳任何廣告圖片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipDeployment; };
            if (total == 0 || !updated) { MessageBox.Show("你尚未填寫所有必要的資訊", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); goto SkipDeployment; }

            DialogResult result = MessageBox.Show($"這樣總共是{(int)total}元，確認刊登?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) { isDeployed = true; MessageBox.Show($"已成功刊登廣告!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            SkipDeployment:
            ;
        }
        #region UnitTest
        public DialogResult setAd(Bitmap ad)
        {
            image[0] = ad;
            ChooseLocation.SelectedIndex = 2;
            AdPreview.Image = (Bitmap)image[0];
            arguments[0] = prices[image[1].ToString()];
            EndDate.Value = StartDate.Value.AddDays(5);
            total = arguments[0] * 1.2 * arguments[1];
            btn_deploy.PerformClick();
            return DialogResult.OK;
        }
        #endregion
    }
}
