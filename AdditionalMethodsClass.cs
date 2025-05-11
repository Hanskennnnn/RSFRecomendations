using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Threading.Tasks;
using NLog.Time;
using System.Runtime.Intrinsics.Arm;

namespace RSFRecomendations
{
    public class AdditionalMethodsClass
    {
        public byte[] HashPassword(string password, byte[] salt)
        {
            var passwordByte = Encoding.UTF8.GetBytes(password);
            var sha256 = SHA256.Create();

            byte[] saltedPassword = new byte[salt.Length + passwordByte.Length];
            Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
            Buffer.BlockCopy(passwordByte, 0, saltedPassword, salt.Length, passwordByte.Length);

            return sha256.ComputeHash(saltedPassword);
        }

        public byte[] ImageToBytes(Image imageToBytes)
        {
            var image = imageToBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ByteToImage(byte[] byteToImage)
        {
            byte[] imageBytes = byteToImage;

            // Преобразование byte[] в Image
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);

                return image;
            }
        }

        public string GetImageHash(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                using (var sha = SHA256.Create())
                {
                    var hashBytes = sha.ComputeHash(ms.ToArray());
                    return Convert.ToBase64String(hashBytes);
                }
            }
        }


        public void ButtonPaint(object sender, PaintEventArgs e)
        {
            var cornerRadius = 50;
            var button = (Button)sender;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);

            using (var pen = new Pen(Color.Gray, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void Panel_Paint(Panel panel)
        {
            var radius = 30;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        public void EnterText(TextBox textBox, string res, bool pass = false)
        {
            if (textBox.Text == res)
            {
                textBox.Text = String.Empty;
                textBox.ForeColor = Color.Black;
                textBox.Tag = null;
                textBox.UseSystemPasswordChar = pass;
            }
        }

        public void LeaveText(TextBox textBox, string res, bool pass = false)
        {
            if (textBox.Text == String.Empty)
            {
                textBox.Text = res;
                textBox.ForeColor = Color.Gray;
                textBox.Tag = "Mask";
                textBox.UseSystemPasswordChar = pass;
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            return Regex.IsMatch(email, pattern);
        }

        public void VisitPassword(Label lb, TextBox tb)
        {
            tb.UseSystemPasswordChar = false;
            lb.Visible = false;
        }

        public void HidePassword(Label lb, TextBox tb)
        {
            tb.UseSystemPasswordChar = true;
            lb.Visible = true;
        }

        public void BtnMouseEnter(Button btn)
        {
            btn.BackColor = Color.FromArgb(125, 115, 235);
            btn.ForeColor = Color.White;
        }

        public void BtnMouseLeave(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}
