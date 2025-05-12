using System.Drawing.Drawing2D;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Класс для общих методов
    /// </summary>
    public class AdditionalMethodsClass
    {
        private Logger Log;
        public AdditionalMethodsClass()
        {
            Log = LogManager.GetCurrentClassLogger();
        }


        /// <summary>
        /// Метод для добавления целей языка из лист бокса
        /// </summary>
        /// <param name="clbPurposesLanguage"></param>
        /// <param name="languageId"></param>
        public ICollection<ProgrammingLanguagePurposeModel> GetPurposes(CheckedListBox clbPurposesLanguage,
            Guid languageId, ICollection<ProgrammingLanguagePurposeModel> purposeList)
        {
            foreach (var item in clbPurposesLanguage.CheckedItems)
            {
                Purpose parsedPurpose;

                switch (item.ToString())
                {
                    case "Веб-программирование":
                        parsedPurpose = Purpose.WebDevelopment;
                        break;
                    case "Игры":
                        parsedPurpose = Purpose.GameDevelopment;
                        break;
                    case "Микросервисы":
                        parsedPurpose = Purpose.Microservices;
                        break;
                    case "Приложения":
                        parsedPurpose = Purpose.ApplicationDevelopment;
                        break;
                    case "Образование и быстрое прототипирование":
                        parsedPurpose = Purpose.EducationAndRapidPrototyping;
                        break;
                    case "Серверная разработка":
                        parsedPurpose = Purpose.ServerSideDevelopment;
                        break;
                    case "Разработка приложений под Windows (WPF, WinForms)":
                        parsedPurpose = Purpose.WindowsApplicationDevelopment;
                        break;
                    case "Обработка данных и автоматизация на платформе .NET":
                        parsedPurpose = Purpose.NETDataProcessingAndAutomation;
                        break;
                    case "Системное программирование (драйверы, ОС)":
                        parsedPurpose = Purpose.SystemsProgramming;
                        break;
                    case "Встроенные системы (Embedded)":
                        parsedPurpose = Purpose.EmbeddedSystems;
                        break;
                    case "Финансовое ПО и торговые системы":
                        parsedPurpose = Purpose.FinancialAndTradingSoftware;
                        break;
                    case "Data Science и анализ данных":
                        parsedPurpose = Purpose.DataScienceAndDataAnalysis;
                        break;
                    case "Машинное обучение / ИИ":
                        parsedPurpose = Purpose.MachineLearningAndAI;
                        break;
                    case "Скрипты и автоматизация":
                        parsedPurpose = Purpose.ScriptingAndAutomation;
                        break;
                    case "Разработка CLI-инструментов":
                        parsedPurpose = Purpose.CLIToolDevelopment;
                        break;
                    case "Мобильная разработка (Android)":
                        parsedPurpose = Purpose.MobileDevelopmentInAndroid;
                        break;
                    case "Разработка PWA и SPA":
                        parsedPurpose = Purpose.PWAAndSPADevelopment;
                        break;
                    case "Интерактивность в браузере":
                        parsedPurpose = Purpose.BrowserInteractivity;
                        break;
                    case "Полный стек (Full Stack) с MongoDB, Express и пр.":
                        parsedPurpose = Purpose.FullStackDevelopment;
                        break;
                    default:
                        continue; 
                }

                purposeList.Add(new ProgrammingLanguagePurposeModel
                {
                    ProgrammingLanguageId = languageId,
                    Purpose = parsedPurpose
                });
            }

            return purposeList;
        }

        /// <summary>
        /// Метод для добавления/изменения изображения
        /// </summary>
        /// <param name="pictureBox"></param>
        public void AddOrEditImage(PictureBox pictureBox)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    pictureBox.Tag = ofd.FileName;
                }
            }

            if (pictureBox.Image == null)
            {
                MessageBox.Show(Properties.Resources.EmptyImageLang);
                Log.Warn(Properties.Resources.EmptyImageLangLog);
                return;
            }
        }

        /// <summary>
        /// Метод для хэширования пароля
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public byte[] HashPassword(string password, byte[] salt)
        {
            var passwordByte = Encoding.UTF8.GetBytes(password);
            var sha256 = SHA256.Create();

            byte[] saltedPassword = new byte[salt.Length + passwordByte.Length];
            Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
            Buffer.BlockCopy(passwordByte, 0, saltedPassword, salt.Length, passwordByte.Length);

            return sha256.ComputeHash(saltedPassword);
        }

        /// <summary>
        /// Метод для преобразования изображения в массив байтов
        /// </summary>
        /// <param name="imageToBytes"></param>
        /// <returns></returns>
        public byte[] ImageToBytes(Image imageToBytes)
        {
            var image = imageToBytes;
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Метод для преобразования массива байтов в изображение
        /// </summary>
        /// <param name="byteToImage"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод преобразования изображения в хэш
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод прорисовки углов кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод прорисовки углов панеля
        /// </summary>
        /// <param name="panel"></param>
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

        /// <summary>
        /// Метод для вывода маски поля
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="res"></param>
        /// <param name="pass"></param>
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

        /// <summary>
        /// Метод для очистки маски поля
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="res"></param>
        /// <param name="pass"></param>
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

        /// <summary>
        /// Метод проверки почты
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Метод для показа пароля
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="tb"></param>
        public void VisitPassword(Label lb, TextBox tb)
        {
            tb.UseSystemPasswordChar = false;
            lb.Visible = false;
        }

        /// <summary>
        /// Метод для скрытия пароля
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="tb"></param>
        public void HidePassword(Label lb, TextBox tb)
        {
            tb.UseSystemPasswordChar = true;
            lb.Visible = true;
        }

        /// <summary>
        /// Метод для прорисовки кнопки при наведении мышки
        /// </summary>
        /// <param name="btn"></param>
        public void BtnMouseEnter(Button btn)
        {
            btn.BackColor = Color.FromArgb(125, 115, 235);
            btn.ForeColor = Color.White;
        }

        /// <summary>
        /// Метод для очистки прорисовки кнопки без наведения мышки
        /// </summary>
        /// <param name="btn"></param>
        public void BtnMouseLeave(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}
