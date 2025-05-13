using System.Collections.ObjectModel;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Форма информации об языках
    /// </summary>
    public partial class MainFormProgLangControl : UserControl
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private Logger Log;
        /// <summary>
        /// Пользователь
        /// </summary>
        public UserModel User { get; set; }
        public MainFormProgLangControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();

            db = new MyDBContext();
            additionalMethods = new AdditionalMethodsClass();

            User = user;

            LoadLanguages();

            textBoxDescriptionLanguageInfo.Text = Properties.Resources.LanguageDescriptionInfo;
            textBoxDescriptionLanguageInfo.ForeColor = Color.Gray;

            Log.Info("Переход к форме языков программирования");
        }

        /// <summary>
        /// Метод для вывода всех языков 
        /// </summary>
        private async void LoadLanguages()
        {
            var languages = await additionalMethods.GetLanguages();
            foreach (var language in languages)
            {
                listBoxFilteredLanguagesInfo.Items.Add(language);
            }
        }

        private void listBoxFilteredLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDescriptionLanguageInfo.Text = string.Empty;
            textBoxDescriptionLanguageInfo.ForeColor = Color.Black;

            if (listBoxFilteredLanguagesInfo.SelectedItem is ProgrammingLanguageModel selectedItem)
            {
                textBoxDescriptionLanguageInfo.Text = selectedItem.Description;
                pictureBoxImageLanguageInfo.Image = additionalMethods.ByteToImage(selectedItem.Image);
            }
        }

        private void panelMainAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainAddLanguage);
        }
    }
}
