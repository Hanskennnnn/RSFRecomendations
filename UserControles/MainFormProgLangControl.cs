using System.Collections.ObjectModel;
using System.Windows.Forms;
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

        private Logger Log;
        public UserModel User { get; set; }
        public MainFormProgLangControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();

            db = new MyDBContext();

            User = user;

            Log.Info("Переход к форме языков программирования");
        }

        private void listBoxFilteredLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilteredLanguages.SelectedItem is ProgrammingLanguageModel selectedItem)
            {
                tbDescriptionLanguage.Text = selectedItem.Description;
            }
        }
    }
}
