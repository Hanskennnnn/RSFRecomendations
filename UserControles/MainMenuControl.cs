using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    public partial class MainMenuControl : UserControl
    {
        public UserModel User { get; set; }

        private Logger Log;
        public MainMenuControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();

            User = user;

            listBoxMainMenu.Items.Add("Вы еще не заполнили анкету. Заполните анкету чтобы получить свою первую рекомендацию");
            listBoxMainMenu.ForeColor = Color.Gray;


            Log.Info("Переход к форме главного меню");
        }

        private void btnGoFormInMainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
