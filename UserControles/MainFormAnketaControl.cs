using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    public partial class MainFormAnketaControl : UserControl
    {
        private readonly MyDBContext db;
        public UserModel User { get; set; }

        private Logger Log;

        public FormModel model { get; set; }
        public MainFormAnketaControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            model = new FormModel();

            Log = LogManager.GetCurrentClassLogger();

            User = user;

            clbPurposes.Items.Add("Веб-разработка");
            clbPurposes.Items.Add("ML/AI");
            clbPurposes.Items.Add("Windows-приложения");
            clbPurposes.Items.Add("Игры");
            clbPurposes.Items.Add("Базы данных");
            clbPurposes.Items.Add("Мобильные и десктопные приложения");
            clbPurposes.Items.Add("Системное ПО");
            clbPurposes.Items.Add("Серверы");
            clbPurposes.Items.Add("Веб-разработка");


            Log.Info("Переход к форме анкеты");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

    }
}
