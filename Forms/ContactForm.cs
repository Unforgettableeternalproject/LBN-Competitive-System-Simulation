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

namespace LBN_Competitive_System_Simulation
{
    public partial class ContactForm : Form
    {
        private string captchaCode;
        Random random = new Random();
        private ID userID;
        private bool[] entries = new bool[3] {false, false, false};

        private bool Send(string title, string message)
        {
            var identity = userID.Username;
            if (identity == "Anonymous") identity = "匿名訪客";

            DialogResult confimation = MessageBox.Show($"將以{identity}的身分發送訊息, 確認發送嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confimation == DialogResult.Yes)
            {
                Console.WriteLine($"{identity} 以主旨: {title} 寄送了以下訊息:\n{message}");
                Title.Text = "輸入訊息主旨...";
                Message.Text = "輸入訊息內容...";
                CaptchaBox.Text = "輸入驗證碼...";
                Title.ForeColor = SystemColors.ScrollBar;
                Message.ForeColor = SystemColors.ScrollBar;
                CaptchaBox.ForeColor = SystemColors.ScrollBar;
                entries = new bool[3] { false, false, false };
                return true;
            }
            else { MessageBox.Show("已取消!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
        }
        private void GenerateCaptcha()
        {
            // Simulate captcha generation (replace with actual captcha logic)
            captchaCode = GenerateRandomString(6);
            CaptchaImg.Image = GenerateCaptchaImage(captchaCode);
        }
        private string GenerateRandomString(int length)
        {
            // Simulate captcha code generation (replace with actual logic)
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private Bitmap GenerateCaptchaImage(string code)
        {
            int width = 200;
            int height = 54;

            // Create a new blank image
            Bitmap captchaImage = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(captchaImage))
            {
                // Draw a background (optional)
                graphics.Clear(Color.Cornsilk);

                // Draw the captcha code
                using (Font font = new Font("腾祥睿黑GB18030-W3", 20, FontStyle.Italic))
                {
                    using (Brush brush = new SolidBrush(Color.Black))
                    {
                        graphics.DrawString(code, font, brush, 10, 10);
                    }
                }

                // Add some noise to make it harder for bots (optional)
                captchaImage = AddNoise(captchaImage, 50);
            }

            return captchaImage;
        }

        private Bitmap AddNoise(Bitmap image, int noiseAmount)
        {
            Graphics graphics = Graphics.FromImage(image);
            for (int i = 0; i < noiseAmount; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);

                image.SetPixel(x, y, Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            }
            for(int i = 0; i < noiseAmount; i++)
            {
                int x1 = random.Next(Math.Abs(image.Width - noiseAmount)), x2 = random.Next(1, noiseAmount), x3 = random.Next(0, 45);
                int y1 = random.Next(Math.Abs(image.Height - noiseAmount)), y2 = random.Next(1, noiseAmount), y3 = random.Next(-270, 270);
                graphics.DrawArc(new Pen(Brushes.AliceBlue), x1, y1, x2, y2, x3, y3);
            }
            return image;
        }
        public ContactForm(ID userID)
        {
            InitializeComponent();
            GenerateCaptcha();
            this.userID = userID;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            Title.ForeColor = SystemColors.ScrollBar;
            Message.ForeColor = SystemColors.ScrollBar;
            CaptchaBox.ForeColor = SystemColors.ScrollBar; 
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string title = Title.Text.Trim();
            string message = Message.Text.Trim();
            string captcha = CaptchaBox.Text.Trim();
            bool isSendable = true;

            if(CaptchaBox.Text != captchaCode)
            if ((string.IsNullOrEmpty(title) || !entries[0]) && (string.IsNullOrEmpty(message) || !entries[1]))
            {
                isSendable = false;
                MessageBox.Show("您並沒有填寫任何訊息或主旨!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (string.IsNullOrEmpty(message) || !entries[1])
            {
                isSendable = false;
                MessageBox.Show("您填寫了主旨，卻沒有填寫任何訊息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(string.IsNullOrEmpty(captcha) || !entries[2])
            {
                isSendable = false;
                MessageBox.Show("您並沒有填寫驗證碼!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (captcha != captchaCode)
            {
                isSendable = false;
                MessageBox.Show("驗證碼錯誤! 請重新嘗試", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CaptchaBox.Text = string.Empty;
            }
            
            if ((string.IsNullOrEmpty(title) || !entries[0]) && isSendable)
            {
                Console.WriteLine("Debug");
                DialogResult ask = MessageBox.Show("您並沒有填寫任何主旨，確定要送出嗎?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ask == DialogResult.Yes) title = "沒有主旨";
                else isSendable = false;
            }

            if (isSendable) if(Send(title, message)) MessageBox.Show("已經成功寄出回饋!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GenerateCaptcha();
        }

        private void Pressed_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the Enter key
                btn_submit.PerformClick(); // Simulate a click on the Send Message button
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(Title.Text) && entries[0]) || (!string.IsNullOrEmpty(Message.Text) && entries[1]))
            {
                DialogResult result = MessageBox.Show("您還有未完成的訊息，確定要離開嗎?", "訊息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) Close();
            }
            else Close();
        }

        private void Advertise_Click(object sender, EventArgs e)
        {
            MessageBox.Show("廣告商後臺介面待添加", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Title_Enter(object sender, EventArgs e)
        {
            string prompt = "輸入訊息主旨...";
            // Clear the placeholder text when the TextBox gets focus
            if (Title.Text == prompt)
            {
                entries[0] = true;
                Title.Text = string.Empty;
                Title.ForeColor = SystemColors.ControlText;
            }
        }

        private void Title_Leave(object sender, EventArgs e)
        {
            string prompt = "輸入訊息主旨...";
            if (string.IsNullOrEmpty(Title.Text.Trim()))
            {
                entries[0] = false;
                Title.Text = prompt;
                Title.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void Message_Enter(object sender, EventArgs e)
        {
            string prompt = "輸入訊息內容...";
            // Clear the placeholder text when the TextBox gets focus
            if (Message.Text == prompt)
            {
                entries[1] = true;
                Message.Text = string.Empty;
                Message.ForeColor = SystemColors.ControlText;
            }
        }

        private void Message_Leave(object sender, EventArgs e)
        {
            string prompt = "輸入訊息內容...";
            if (string.IsNullOrEmpty(Message.Text.Trim()))
            {
                entries[1] = false;
                Message.Text = prompt;
                Message.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void CaptchaBox_Enter(object sender, EventArgs e)
        {
            string prompt = "輸入驗證碼...";
            // Clear the placeholder text when the TextBox gets focus
            if (CaptchaBox.Text == prompt)
            {
                entries[2] = true;
                CaptchaBox.Text = string.Empty;
                CaptchaBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void CaptchaBox_Leave(object sender, EventArgs e)
        {
            string prompt = "輸入驗證碼...";
            if (string.IsNullOrEmpty(CaptchaBox.Text.Trim()))
            {
                entries[2] = false;
                CaptchaBox.Text = prompt;
                CaptchaBox.ForeColor = SystemColors.ScrollBar;
            }
        }
    }
}
