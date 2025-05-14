using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Юзер контроллер для добавления языка
    /// </summary>
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

            clbPurposesLanguage.Items.Add("Веб-программирование");
            clbPurposesLanguage.Items.Add("Игры");
            clbPurposesLanguage.Items.Add("Микросервисы");
            clbPurposesLanguage.Items.Add("Приложения");
            clbPurposesLanguage.Items.Add("Серверная разработка");
            clbPurposesLanguage.Items.Add("Образование и быстрое прототипирование");
            clbPurposesLanguage.Items.Add("Разработка приложений под Windows (WPF, WinForms)");
            clbPurposesLanguage.Items.Add("Обработка данных и автоматизация на платформе .NET");
            clbPurposesLanguage.Items.Add("Системное программирование (драйверы, ОС)");
            clbPurposesLanguage.Items.Add("Встроенные системы (Embedded)");
            clbPurposesLanguage.Items.Add("Финансовое ПО и торговые системы");
            clbPurposesLanguage.Items.Add("Data Science и анализ данных");
            clbPurposesLanguage.Items.Add("Машинное обучение / ИИ");
            clbPurposesLanguage.Items.Add("Скрипты и автоматизация");
            clbPurposesLanguage.Items.Add("Разработка CLI-инструментов");
            clbPurposesLanguage.Items.Add("Мобильная разработка (Android)");
            clbPurposesLanguage.Items.Add("Разработка PWA и SPA");
            clbPurposesLanguage.Items.Add("Интерактивность в браузере");
            clbPurposesLanguage.Items.Add("Полный стек (Full Stack) с MongoDB, Express и пр.");

            Log.Info("Переход к форме добавления языка");
        }

        private async void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            var valuesDifficultyLanguage = new List<RadioButton> { radioButtonEasy, radioButtonMid, radioButtonHard };
            var difficultyLanguage = additionalMethods.GetDifficulty(valuesDifficultyLanguage);

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
            if (textBoxDescriptionLanguage.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceDescriptionLang);
                Log.Warn(Properties.Resources.NoContainsSpaceDescriptionLangLog);
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

            language.Purposes = await additionalMethods.GetPurposesAsync(clbPurposesLanguage,
                language.Id);

            await db.ProgrammingLanguages.AddAsync(language);
            await db.SaveChangesAsync();

            MessageBox.Show(Properties.Resources.SuccessfullyAddedLanguage);

            Log.Info("Успешное добавление языка");

            textBoxNameLanguage.Text = string.Empty;
            textBoxDescriptionLanguage.Text = string.Empty;
            pictureBoxImageLanguage.Image = null;

            var radioButtons = new List<RadioButton> { radioButtonEasy, radioButtonMid, radioButtonHard };
            additionalMethods.ClearRadioButtons(radioButtons);

            for (var i = 0; i < clbPurposesLanguage.Items.Count; i++)
            {
                clbPurposesLanguage.SetItemChecked(i, false);
            }
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

        private void buttonAddImageLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e, 40);
        }

        private void buttonAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e, 40);
        }
    }
}
q