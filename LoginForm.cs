using NLog;
using Microsoft.EntityFrameworkCore;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма входа
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private Logger Log;

        public LoginForm()
        {
            InitializeComponent();

            textBoxLogLogin.Text = Properties.Resources.EnterLogin;
            textBoxLogLogin.ForeColor = Color.Gray;
            textBoxLogPassword.Text = Properties.Resources.EnterPassword;
            textBoxLogPassword.ForeColor = Color.Gray;

            Log = LogManager.GetCurrentClassLogger();
            db = new MyDBContext();
            additionalMethods = new AdditionalMethodsClass();

            Log.Info("Переход к форме входа");
        }

        private void linkLabelToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var register = new RegisterForm();
            register.Show();
            Log.Info("Переход к форме регистрации по ссылке 'У вас нет аккаунта?'");
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            // Проверка полей
            if (string.IsNullOrWhiteSpace(textBoxLogLogin.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyLogin);
                Log.Warn(Properties.Resources.EmptyLoginLog);
                return;
            }
            if (textBoxLogLogin.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceLogin);
                Log.Warn(Properties.Resources.NoContainsSpaceLoginLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxLogPassword.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyPassword);
                Log.Warn(Properties.Resources.EmptyPasswordLog);
                return;
            }
            if (textBoxLogPassword.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpacePassword);
                Log.Warn(Properties.Resources.NoContainsSpacePasswordLog);
                return;
            }

            // Проверка на сущ логина
            var us = await db.Users.FirstOrDefaultAsync(c => c.Login == textBoxLogLogin.Text);
            if (us == null)
            {
                MessageBox.Show(Properties.Resources.NoUser);
                Log.Warn(Properties.Resources.NoUserLog + $"{textBoxLogLogin.Text}");
                return;
            }

            // Проверка пароля
            var checkPassword = additionalMethods.HashPassword(textBoxLogPassword.Text, us.Salt);

            if (!checkPassword.SequenceEqual(us.Password))
            {
                MessageBox.Show(Properties.Resources.WrongPassword);
                Log.Warn(Properties.Resources.WrongPasswordLog);
                return;
            }

            this.Hide();
            var main = new MainMenu(us);
            main.Show();

            Log.Info("Пользователь нажал кнопку входа.");
        }

        private void textBoxLogLogin_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxLogLogin, Properties.Resources.EnterLogin);
        }

        private void textBoxLogLogin_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxLogLogin, Properties.Resources.EnterLogin);
        }

        private void textBoxLogPassword_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxLogPassword, Properties.Resources.EnterPassword, true);
        }

        private void textBoxLogPassword_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxLogPassword, Properties.Resources.EnterPassword);
        }

        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }
    }
}
