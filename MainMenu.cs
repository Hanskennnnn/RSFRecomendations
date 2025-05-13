using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;
using RSFRecomendations.UserControles;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма главного меню
    /// </summary>
    public partial class MainMenu : Form
    {
        /// <summary>
        /// Пользователь 
        /// </summary>
        public static UserModel User { get; set; }

        private AdditionalMethodsClass additionalMethods;

        private readonly MyDBContext db; 

        private Logger Log;

        public MainMenu(UserModel user)
        {
            InitializeComponent();

            User = user;
            additionalMethods = new AdditionalMethodsClass();

            Log = LogManager.GetCurrentClassLogger();

            db = new MyDBContext();

            ShowControl(new MainFormProfileControl(User));
            Log.Info(Properties.Resources.GoMainMenuLog);
           

            if (User.Login == "Admin")
            {
                buttonAddLanguage.Visible = true;
                buttonAddLanguage.Enabled = true;
            }
            else
            {
                buttonAddLanguage.Visible = false;
                buttonAddLanguage.Enabled = false;
            }

        }

        private void btnGoForm_Click(object sender, EventArgs e)
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

        private void buttonAddLanguage_Click(object sender, EventArgs e)
        {
            ShowControl(new MainAddLanguageControl(User));
            Log.Info(Properties.Resources.GoAddLanguageLog);
        }

        private void btnLogoutMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();

            Log.Info("Пользователь нажал на кнопку выход из аккаунта");
        }

        private async void btnGoMainMenu_Click(object sender, EventArgs e)
        {
            var dbUser = await db.Users
            .Include(u => u.FormModel)
            .FirstOrDefaultAsync(u => u.Id == User.Id);

            if (dbUser.FormModel != null)
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
            additionalMethods.BtnMouseEnter(btnGoMainMenu);
        }

        private void btnGoMainMenu_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(btnGoMainMenu);
        }

        private void btnGoForm_MouseEnter(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseEnter(btnGoForm);
        }

        private void btnGoForm_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(btnGoForm);
        }

        private void btnGoProgLang_MouseEnter(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseEnter(btnGoProgLang);
        }

        private void btnGoProgLang_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(btnGoProgLang);
        }

        private void btnGoProfile_MouseEnter(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseEnter(btnGoProfile);
        }

        private void btnGoProfile_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(btnGoProfile);
        }

        private void btnLogoutMainMenu_MouseEnter(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseEnter(btnLogoutMainMenu);
        }

        private void btnLogoutMainMenu_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(btnLogoutMainMenu);
        }

        // Прорисoвка углов
        private void Btn_PaintBotton(object sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                var borderColor = Color.LightGray;

                using (var pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawLine(pen, 0, btn.Height - 1, btn.Width, btn.Height - 1);
                }
            }
        }

        private void Btn_PaintTop(object sender, PaintEventArgs e)
        {
            if (sender is Button btn)
            {
                var borderColor = Color.LightGray;

                using (var pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawLine(pen, 0, 0, btn.Width, 0);
                }
            }
        }

        private void buttonAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            Btn_PaintBotton(sender, e);
        }

        private void buttonAddLanguage_MouseEnter(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseEnter(buttonAddLanguage);
        }

        private void buttonAddLanguage_MouseLeave(object sender, EventArgs e)
        {
            additionalMethods.BtnMouseLeave(buttonAddLanguage);
        }
    }
}
