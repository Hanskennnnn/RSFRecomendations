using System.Drawing.Drawing2D;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Форма главного меню до заполнения анкеты
    /// </summary>
    public partial class MainMenuFirstLogControl : UserControl
    {
        private readonly MyDBContext db;
        /// <summary>
        /// Пользователь
        /// </summary>
        public UserModel User { get; set; }

        private MainMenu mainMenuForm;

        private Logger Log;
        /// <summary>
        /// Кнопка для перехода в анкету
        /// </summary>
        public Button BtnGoForm { get; set; }
        public MainMenuFirstLogControl(UserModel user)
        {
            InitializeComponent();

            this.ParentChanged += MainMenuFirstLogControl_ParentChanged;

            Log = LogManager.GetCurrentClassLogger();

            db = new MyDBContext(); 
            User = user;

            Log.Info("Переход к форме главного меню, до заполнения анкеты");
        }

        private void MainMenuFirstLogControl_ParentChanged(object sender, EventArgs e)
        {
            mainMenuForm = this.FindForm() as MainMenu;
        }

        private void buttonMainControlGoAnketa_Click(object sender, EventArgs e)
        {
            mainMenuForm.ShowControl(new MainFormAnketaControl(User));
            Log.Info(Properties.Resources.GoAnketaLog);
        }
        
        private void buttonMainControlGoAnketa_Paint(object sender, EventArgs e)
        {
            var cornerRadius = 40; 
            var button = (Button)sender;

            var path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Левый верхний
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Правый верхний
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Правый нижний
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Левый нижний
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
