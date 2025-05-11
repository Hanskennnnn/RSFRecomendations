using NLog;
using RSFRecomendations.Models;
using RSFRecomendations.UserControles;

namespace RSFRecomendations
{
    public partial class MainMenu : Form
    {
        public static UserModel User { get; set; }
        private AdditionalMethodsClass am;

        private Logger Log; 

        public MainMenu(UserModel user)
        {
            InitializeComponent();

            User = user;
            am = new AdditionalMethodsClass();

            Log = LogManager.GetCurrentClassLogger();

            ShowControl(new MainMenuFirstLogControl(User));
        }

        public void btnGoForm_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormAnketaControl(User));
            Log.Info(Properties.Resources.GoAnketaLog);
        }

        private void btnGoProgLang_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormProgLangControl(User));
            Log.Info(Properties.Resources.GoProgLangLog);
        }

        private void btnGoProfile_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormProfileControl(User));
            Log.Info(Properties.Resources.GoProfileLog);
        }

        private void btnLogoutMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();

            Log.Info("Пользователь нажал на кнопку выход из аккаунта");
        }

        private void btnGoMainMenu_Click(object sender, EventArgs e)
        {
            if (User.FormModel != null)
            {
                ShowControl(new MainMenuControl(User));
                Log.Info(Properties.Resources.GoMainMenuLog);
            }
            else
            {
                ShowControl(new MainMenuFirstLogControl(User));
                Log.Info(Properties.Resources.GoFirstMainMenuLog);
            }
        }

        // Переход между контроллерами
        public void ShowControl(UserControl control)
        {
            panelMainMenu.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(control);
        }

        private void btnGoMainMenu_MouseEnter(object sender, EventArgs e)
        {
            am.BtnMouseEnter(btnGoMainMenu);
        }

        private void btnGoMainMenu_MouseLeave(object sender, EventArgs e)
        {
            am.BtnMouseLeave(btnGoMainMenu);
        }

        private void btnGoForm_MouseEnter(object sender, EventArgs e)
        {
            am.BtnMouseEnter(btnGoForm);
        }

        private void btnGoForm_MouseLeave(object sender, EventArgs e)
        {
            am.BtnMouseLeave(btnGoForm);
        }

        private void btnGoProgLang_MouseEnter(object sender, EventArgs e)
        {
            am.BtnMouseEnter(btnGoProgLang);
        }

        private void btnGoProgLang_MouseLeave(object sender, EventArgs e)
        {
            am.BtnMouseLeave(btnGoProgLang);
        }

        private void btnGoProfile_MouseEnter(object sender, EventArgs e)
        {
            am.BtnMouseEnter(btnGoProfile);
        }

        private void btnGoProfile_MouseLeave(object sender, EventArgs e)
        {
            am.BtnMouseLeave(btnGoProfile);
        }

        private void btnLogoutMainMenu_MouseEnter(object sender, EventArgs e)
        {
            am.BtnMouseEnter(btnLogoutMainMenu);
        }

        private void btnLogoutMainMenu_MouseLeave(object sender, EventArgs e)
        {
            am.BtnMouseLeave(btnLogoutMainMenu);
        }

        // Прорисвка углов
        private void Btn_PaintBotton(object sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                Color borderColor = Color.LightGray;

                using (Pen pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawLine(pen, 0, btn.Height - 1, btn.Width, btn.Height - 1);
                }
            }
        }

        private void Btn_PaintTop(object sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                Color borderColor = Color.LightGray;

                using (Pen pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawLine(pen, 0, 0, btn.Width, 0);
                }
            }
        }

    }
}
