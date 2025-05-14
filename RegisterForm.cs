using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма регистрации
    /// </summary>
    public partial class RegisterForm : Form
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private Logger Log;
        public RegisterForm()
        {
            InitializeComponent();

            db = new MyDBContext();
            additionalMethods = new AdditionalMethodsClass();
            Log = LogManager.GetCurrentClassLogger();

            textBoxRegLogin.Text = Properties.Resources.EnterLogin;
            textBoxRegLogin.ForeColor = Color.Gray;
            textBoxRegLogin.Tag = "Mask";
            textBoxRegEmail.Text = Properties.Resources.EnterEmail;
            textBoxRegEmail.ForeColor = Color.Gray;
            textBoxRegEmail.Tag = "Mask";
            textBoxRegPassword.Text = Properties.Resources.EnterPassword;
            textBoxRegPassword.ForeColor = Color.Gray;
            textBoxRegPassword.Tag = "Mask";
            textBoxRegPassword2.Text = Properties.Resources.EnterRepeatPassword;
            textBoxRegPassword2.ForeColor = Color.Gray;
            textBoxRegPassword2.Tag = "Mask";

            textBoxRegLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegPassword2.BorderStyle = BorderStyle.FixedSingle;

            Log.Info("Переход к форме регистрации");
        }

        private void linkLabelToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();

            Log.Info("Переход к форме входа по ссылке 'Уже есть аккаунт?'");
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            //  Проверка полей
            if (string.IsNullOrWhiteSpace(textBoxRegLogin.Text) || textBoxRegLogin.Tag?.ToString() == "Mask")
            {
                MessageBox.Show(Properties.Resources.EmptyLogin);
                Log.Warn(Properties.Resources.EmptyLoginRegLog);
                return;
            }
            if (Regex.IsMatch(textBoxRegLogin.Text, "[a-zA-Z]"))
            {
                MessageBox.Show(Properties.Resources.IncorrectLoginNum);
                Log.Warn(Properties.Resources.IncorrectLoginNumLog);
                return;
            }
            if (!additionalMethods.IsValidLogin(textBoxRegLogin.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectLogin);
                Log.Warn(Properties.Resources.IncorrectLoginLog);
                return;
            }
            if (textBoxRegLogin.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceLogin);
                Log.Warn(Properties.Resources.NoContainsSpaceLoginRegLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegEmail.Text) || textBoxRegEmail.Tag?.ToString() == "Mask")
            {
                MessageBox.Show(Properties.Resources.EmptyEmail);
                Log.Warn(Properties.Resources.EmptyEmailRegLog);
                return;
            }
            if (!additionalMethods.IsValidEmail(textBoxRegEmail.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectMail);
                Log.Warn(Properties.Resources.IncorrectMailLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegPassword.Text) || textBoxRegPassword.Tag?.ToString() == "Mask")
            {
                MessageBox.Show(Properties.Resources.EmptyPassword);
                Log.Warn(Properties.Resources.EmptyPasswordRegLog);
                return;
            }
            if (textBoxRegPassword.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpacePassword);
                Log.Warn(Properties.Resources.NoContainsSpacePasswordRegLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegPassword2.Text) || textBoxRegPassword2.Tag?.ToString() == "Mask")
            {
                MessageBox.Show(Properties.Resources.EmptyRepeatPassword);
                Log.Warn(Properties.Resources.EmptyRepeatPasswordRegLog);
                return;
            }
            if (textBoxRegPassword2.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpacePassword2);
                Log.Warn(Properties.Resources.NoContainsSpacePassword2RegLog);
                return;
            }
            if (textBoxRegPassword.Text != textBoxRegPassword2.Text)
            {
                MessageBox.Show(Properties.Resources.PasswordsDontMatch);
                Log.Warn(Properties.Resources.PasswordsDontMatchRegLog);
                return;
            }
            if (textBoxRegPassword.TextLength < 8)
            {
                MessageBox.Show(Properties.Resources.LengthPassword);
                Log.Warn(Properties.Resources.LengthPasswordRegLog);
                return;
            }

            // Проверка на сущ логина
            var usLogin = await db.Users.FirstOrDefaultAsync(c => c.Login == textBoxRegLogin.Text);
            if (usLogin != null)
            {
                MessageBox.Show(Properties.Resources.UserExistsRegLogin);
                Log.Warn(Properties.Resources.UserExistsRegLoginLog);
                return;
            }

            // Проверка на сущ почты
            var usEmail = await db.Users.FirstOrDefaultAsync(c => c.Email == textBoxRegEmail.Text);
            if (usEmail != null)
            {
                MessageBox.Show(Properties.Resources.UserExistsRegEmail);
                Log.Warn(Properties.Resources.UserExistsRegEmailLog);
                return;
            }

            // Создание случ соли для хэш пароля
            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            // хэш пароля
            var saltedPassword = additionalMethods.HashPassword(textBoxRegPassword.Text, salt);

            // Созд и сохр пользователя
            var user = new UserModel
            {
                Id = Guid.NewGuid(),
                Login = textBoxRegLogin.Text,
                Email = textBoxRegEmail.Text,
                Image = additionalMethods.ImageToBytes(Properties.Resources.Аватарка),
                Password = saltedPassword,
                Salt = salt
            };

            await db.AddAsync(user);
            await db.SaveChangesAsync();

            MessageBox.Show(Properties.Resources.SuccessfulRegistration);


            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();

            Log.Info("Успешная регистрация");
        }

        private void textBoxRegName_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxRegLogin, Properties.Resources.EnterLogin);
        }

        private void textBoxRegName_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxRegLogin, Properties.Resources.EnterLogin);
        }

        private void textBoxRegEmail_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxRegEmail, Properties.Resources.EnterEmail);
        }

        private void textBoxRegEmail_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxRegEmail, Properties.Resources.EnterEmail);
        }

        private void textBoxRegPassword_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxRegPassword, Properties.Resources.EnterPassword, true);
        }

        private void textBoxRegPassword_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxRegPassword, Properties.Resources.EnterPassword);
        }

        private void textBoxRegPassword2_Enter(object sender, EventArgs e)
        {
            additionalMethods.EnterText(textBoxRegPassword2, Properties.Resources.EnterRepeatPassword, true);
        }

        private void textBoxRegPassword2_Leave(object sender, EventArgs e)
        {
            additionalMethods.LeaveText(textBoxRegPassword2, Properties.Resources.EnterRepeatPassword);
        }

        private void labelVisitPassword_Click(object sender, EventArgs e)
        {
            additionalMethods.VisitPassword(labelVisitPassword,textBoxRegPassword);
        }

        private void labelHidePassword_Click(object sender, EventArgs e)
        {
            additionalMethods.HidePassword(labelVisitPassword, textBoxRegPassword);
        }

        private void labelVisitPassword2_Click(object sender, EventArgs e)
        {
            additionalMethods.VisitPassword(labelVisitPassword2, textBoxRegPassword2);
        }

        private void labelHidePassword2_Click(object sender, EventArgs e)
        {
            additionalMethods.HidePassword(labelVisitPassword2, textBoxRegPassword2);
        }

        private void buttonRegister_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }
    }
}
