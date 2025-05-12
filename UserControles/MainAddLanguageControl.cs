using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    public partial class MainAddLanguageControl : UserControl
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private Logger Log;
        UserModel User { get; set; }
        public MainAddLanguageControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            additionalMethods = new AdditionalMethodsClass();

            User = user;
            Log = LogManager.GetCurrentClassLogger();

            textBoxNameLanguage.Text = Properties.Resources.NameLanguageText;
            textBoxNameLanguage.ForeColor = Color.Gray;
            textBoxNameLanguage.Tag = "Mask";
            textBoxDescriptionLanguage.Text = Properties.Resources.DescriptionLanguageText;
            textBoxDescriptionLanguage.ForeColor = Color.Gray;
            textBoxDescriptionLanguage.Tag = "Mask";

            // C#, Python, Go, Java, JavaScript
            clbPurposesLanguage.Items.Add("Веб-программирование");

            // C#, C++
            clbPurposesLanguage.Items.Add("Игры");

            // C#, Go
            clbPurposesLanguage.Items.Add("Микросервисы");

            // C++, Go, Java
            clbPurposesLanguage.Items.Add("Приложения");

            // Go, Java, JavaScript
            clbPurposesLanguage.Items.Add("Серверная разработка");

            // Python, Java
            clbPurposesLanguage.Items.Add("Образование и быстрое прототипирование");

            // C#
            clbPurposesLanguage.Items.Add("Разработка приложений под Windows (WPF, WinForms)");
            clbPurposesLanguage.Items.Add("Обработка данных и автоматизация на платформе .NET");

            // C++
            clbPurposesLanguage.Items.Add("Системное программирование (драйверы, ОС)");
            clbPurposesLanguage.Items.Add("Встроенные системы (Embedded)");
            clbPurposesLanguage.Items.Add("Финансовое ПО и торговые системы");

            // Python
            clbPurposesLanguage.Items.Add("Data Science и анализ данных");
            clbPurposesLanguage.Items.Add("Машинное обучение / ИИ");
            clbPurposesLanguage.Items.Add("Скрипты и автоматизация");

            // Go
            clbPurposesLanguage.Items.Add("Разработка CLI-инструментов");

            // Java
            clbPurposesLanguage.Items.Add("Мобильная разработка (Android)");

            // JavaScript
            clbPurposesLanguage.Items.Add("Разработка PWA и SPA");
            clbPurposesLanguage.Items.Add("Интерактивность в браузере");
            clbPurposesLanguage.Items.Add("Полный стек (Full Stack) с MongoDB, Express и пр.");

            Log.Info("Переход к форме добавления языка");
        }

        private async void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            var difficultyLanguage = GetDifficulty();

            if (string.IsNullOrWhiteSpace(textBoxNameLanguage.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyNameLang);
                Log.Warn(Properties.Resources.EmptyNameLangLog);
                return;
            }
            if (textBoxNameLanguage.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceNameLang);
                Log.Warn(Properties.Resources.NoContainsSpaceNameLangLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDescriptionLanguage.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyDescriptionLang);
                Log.Warn(Properties.Resources.EmptyDescriptionLangLog);
                return;
            }
            if (difficultyLanguage == null)
            {
                MessageBox.Show(Properties.Resources.EmptyDifficultyLang);
                Log.Warn(Properties.Resources.EmptyDifficultyLangLog);
                return;
            }
            if (pictureBoxImageLanguage.Image == null)
            {
                MessageBox.Show(Properties.Resources.EmptyImageLang);
                Log.Warn(Properties.Resources.EmptyImageLangLog);
                return;
            }
            if (clbPurposesLanguage.SelectedIndex == -1)
            {
                MessageBox.Show(Properties.Resources.EmptyPurposeLang);
                Log.Warn(Properties.Resources.EmptyPurposeLangLog);
                return; 
            }

            var usLogin = await db.ProgrammingLanguages.FirstOrDefaultAsync(c => c.Name == textBoxNameLanguage.Text);
            if (usLogin != null)
            {
                MessageBox.Show(Properties.Resources.TheLanguageAlreadyExists);
                Log.Warn(Properties.Resources.TheLanguageAlreadyExistsLog);
                return;
            }

            var language = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = textBoxNameLanguage.Text,
                Description = textBoxDescriptionLanguage.Text,
                Purposes = new List<ProgrammingLanguagePurposeModel>(),
                DifficultyLanguage = difficultyLanguage,
                Image = additionalMethods.ImageToBytes(pictureBoxImageLanguage.Image),
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };

            await db.ProgrammingLanguages.AddAsync(language);
            await db.SaveChangesAsync();

            var purposeList = additionalMethods.GetPurposes(clbPurposesLanguage, language.Id, language.Purposes);

            await db.ProgrammingLanguagePurpose.AddRangeAsync(purposeList);
            await db.SaveChangesAsync();

            MessageBox.Show(Properties.Resources.SuccessfullyAddedLanguage);

            Log.Info("Успешное добавление языка");

            textBoxNameLanguage.Text = string.Empty;
            textBoxDescriptionLanguage.Text = string.Empty;
            pictureBoxImageLanguage.Image = null;
            clbPurposesLanguage.ClearSelected();
        }

        private Difficulty? GetDifficulty()
        {
            var radioButtons = new List<RadioButton> { radioButtonEasy, radioButtonMid, radioButtonHard };
            foreach (var radio in radioButtons)
            {
                if (radio.Checked)
                {
                    return (Difficulty)radio.Tag;
                }
            }
            return null;
        }

        private void buttonAddImageLanguage_Click(object sender, EventArgs e)
        {
            additionalMethods.AddOrEditImage(pictureBoxImageLanguage);
        }

        private void textBoxNameLanguage_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxNameLanguage, Properties.Resources.NameLanguageText);
        }

        private void textBoxNameLanguage_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxNameLanguage, Properties.Resources.NameLanguageText);
        }

        private void textBoxDescriptionLanguage_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxDescriptionLanguage, Properties.Resources.DescriptionLanguageText);
        }

        private void textBoxDescriptionLanguage_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxDescriptionLanguage, Properties.Resources.DescriptionLanguageText);
        }

        private void panelMainAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainAddLanguage);
        }
    }
}
