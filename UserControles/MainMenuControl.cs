using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма главного меню после заполнения анкеты
    /// </summary>
    public partial class MainMenuControl : UserControl
    {
        /// <summary>
        /// Пользватель
        /// </summary>
        public UserModel User { get; set; }
        private AdditionalMethodsClass additionalMethods { get; set; }

        private Logger Log;

        public MainMenuControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();
            User = user;
            additionalMethods = new AdditionalMethodsClass();

            Log.Info("Переход к форме главного меню");
        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainMenu);
        }

        private void labelLang2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLikeLang1_Click(object sender, EventArgs e)
        {

        }
    }
}
