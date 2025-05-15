using System.Drawing.Drawing2D;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using NLog;
using RSFRecomendations.Models;
using Microsoft.EntityFrameworkCore;

namespace RSFRecomendations
{
    /// <summary>
    /// Класс для общих методов
    /// </summary>
    public class AdditionalMethodsClass
    {
        private readonly MyDBContext db;

        private Logger Log;

        private readonly Dictionary<string, Purpose> purposeMapping = new()
        {
            { Properties.Resources.ApplicationDevelopment, Purpose.ApplicationDevelopment },
            { Properties.Resources.BrowserInteractivity, Purpose.BrowserInteractivity },
            { Properties.Resources.CLIToolDevelopment, Purpose.CLIToolDevelopment},
            { Properties.Resources.DataScienceAndDataAnalysis, Purpose.DataScienceAndDataAnalysis },
            { Properties.Resources.EducationAndRapidPrototyping, Purpose.EducationAndRapidPrototyping },
            { Properties.Resources.EmbeddedSystems, Purpose.EmbeddedSystems},
            { Properties.Resources.FinancialAndTradingSoftware, Purpose.FinancialAndTradingSoftware },
            { Properties.Resources.FullStackDevelopment, Purpose.FullStackDevelopment },
            { Properties.Resources.GameDevelopment, Purpose.GameDevelopment},
            { Properties.Resources.MachineLearningAndAI, Purpose.MachineLearningAndAI},
            { Properties.Resources.Microservices, Purpose.Microservices},
            { Properties.Resources.MobileDevelopmentInAndroid, Purpose.MobileDevelopmentInAndroid },
            { Properties.Resources.NETDataProcessingAndAutomation, Purpose.NETDataProcessingAndAutomation},
            { Properties.Resources.PWAAndSPADevelopment, Purpose.PWAAndSPADevelopment },
            { Properties.Resources.ScriptingAndAutomation, Purpose.ScriptingAndAutomation},
            { Properties.Resources.ServerSideDevelopment, Purpose.ServerSideDevelopment},
            { Properties.Resources.SystemsProgramming, Purpose.SystemsProgramming },
            { Properties.Resources.WebDevelopment, Purpose.WebDevelopment},
            { Properties.Resources.WindowsApplicationDevelopment, Purpose.WindowsApplicationDevelopment }
        };

        public AdditionalMethodsClass()
        {
            Log = LogManager.GetCurrentClassLogger();
            db = new MyDBContext();
        }

        /// <summary>
        /// Метод для очистки выбора кнопок
        /// </summary>
        /// <param name="radioButtons"></param>
        public void ClearRadioButtons(ICollection<RadioButton> radioButtons)
        {
            foreach (var radio in radioButtons)
            {
                radio.Checked = false;
            }
        }

        /// <summary>
        /// Метод для добавления целей языка из лист бокса
        /// </summary>
        /// <param name="clbPurposesLanguage"></param>
        /// <param name="languageId"></param>
        public async Task<List<ProgrammingLanguagePurposeModel>> GetPurposesAsync(CheckedListBox clbPurposesLanguage,
            Guid languageId)
        {
            var purposes = new List<ProgrammingLanguagePurposeModel>();

            foreach (var item in clbPurposesLanguage.CheckedItems)
            {
                if (purposeMapping.TryGetValue(item.ToString(), out var parsedPurpose))
                {
                    purposes.Add(new ProgrammingLanguagePurposeModel
                    {
                        Id = Guid.NewGuid(),
                        ProgrammingLanguageId = languageId,
                        SelectedPurpose = parsedPurpose
                    });
                }
            }

            return purposes;
        }



        /// <summary>
        /// Метод для получения уровня подготовки
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public ProgrammingSkill? GetProgSkill(ICollection<RadioButton> values)
        {
            var radioButtons = values;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (ProgrammingSkill)radio.Tag;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод для вытаскивания всех языков из базы данных 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProgrammingLanguageModel>> GetLanguages()
        {
            return await db.ProgrammingLanguages.ToListAsync();
        }

        /// <summary>
        /// Метод для получения времени обучения анкеты
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public TimeToEducation? GetTimeToEducation(ICollection<RadioButton> values)
        {
            var radioButtons = values;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (TimeToEducation)radio.Tag;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод для получения приоритетов анкеты
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public ProgrammingLanguagePriority? GetPriority(ICollection<RadioButton> values)
        {
            var radioButtons = values;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (ProgrammingLanguagePriority)radio.Tag;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод для получения целей анкеты
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Purpose? GetPurposeForm(ICollection<RadioButton> values)
        {
            var radioButtons = values;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (Purpose)radio.Tag;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод для получения сложности языка
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Difficulty? GetDifficulty(ICollection<RadioButton> values)
        {
            var radioButtons = values;
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (Difficulty)radio.Tag;
                }
            }
            return null;
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

            var saltedPassword = new byte[salt.Length + passwordByte.Length];
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
            var imageBytes = byteToImage;
            using (var ms = new MemoryStream(imageBytes))
            {
                var image = Image.FromStream(ms);

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
        public void ButtonPaint(object sender, PaintEventArgs e, int cornerRadius = 50)
        {
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
                textBox.Text = string.Empty;
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
            if (textBox.Text == string.Empty)
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
            var pattern = @"^[a-zA-Z0-9]{4,}@[a-zA-Z]{3,}\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Маска для логина
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool IsValidLogin(string login)
        {
            var pattern = @"^[a-zA-Z0-9]{3,}$";
            return Regex.IsMatch(login, pattern);
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
