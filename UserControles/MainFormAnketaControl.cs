using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Форма анкеты
    /// </summary>
    public partial class MainFormAnketaControl : UserControl
    {
        private readonly MyDBContext db;
        /// <summary>
        /// Пользователь
        /// </summary>
        public UserModel User { get; set; }

        private Logger Log;

        private AdditionalMethodsClass additionalMethods;

        public FormModel model { get; set; }
        public MainFormAnketaControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            model = new FormModel();
            additionalMethods = new AdditionalMethodsClass();

            Log = LogManager.GetCurrentClassLogger();

            User = user;

            Log.Info("Переход к форме анкеты");
        }

        private void buttonAddForm_Click(object sender, EventArgs e)
        {
            // if (checkBoxPerformance.Checked)
            // {
            //     var selectedPriority = (ProgrammingLanguagePriority)checkBoxPerformance.Tag;
            // }

        }

        private void buttonAddForm_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }

        private void panelMainAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainAddForm);
        }
    }
}
