using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    public partial class MainMenuControl : UserControl
    {
        public UserModel User { get; set; }
        public AdditionalMethodsClass am { get; set; }

        private Logger Log;
        public MainMenuControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();

            User = user;
            am = new AdditionalMethodsClass();

            Log.Info("Переход к форме главного меню");
        }


        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            am.Panel_Paint(panelMainMenu);
        }
    }
}
