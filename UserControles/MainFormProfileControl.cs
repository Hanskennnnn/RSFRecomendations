using System.Data;
using NLog;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Форма профиля
    /// </summary>
    public partial class MainFormProfileControl : UserControl
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass additionalMethods;

        private VideoCaptureDevice videoSource;

        private Logger Log;

        /// <summary>
        /// Пользователь
        /// </summary>
        public UserModel User { get; set; }

        public MainFormProfileControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            additionalMethods = new AdditionalMethodsClass();
            User = user;
            Log = LogManager.GetCurrentClassLogger();

            tbUserLoginProfile.Text = User.Login;
            tbUserEmailProfile.Text = User.Email;
            pbImageUser.Image = additionalMethods.ByteToImage(User.Image);

            Log.Info("Переход к форме профиля");
        }

        private async void btnEditProfile_Click(object sender, EventArgs e)
        {
            // Проверка полей
            if (string.IsNullOrWhiteSpace(tbUserLoginProfile.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyLogin);
                Log.Warn(Properties.Resources.ChangeEmptyLoginLog);
                return;
            }
            if (!additionalMethods.IsValidLogin(tbUserLoginProfile.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectLogin);
                Log.Warn(Properties.Resources.IncorrectEditLoginLog);
                return;
            }
            if (!Regex.IsMatch(tbUserLoginProfile.Text, @"^[a-zA-Z][a-zA-Z0-9]*$"))
            {
                MessageBox.Show(Properties.Resources.IncorrectLoginNum);
                Log.Warn(Properties.Resources.IncorrectLoginNumEditLog);
                return;
            }
            if (tbUserLoginProfile.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceLogin);
                Log.Warn(Properties.Resources.ChangeNoContainsSpaceLoginLog);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbUserEmailProfile.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyEmail);
                Log.Warn(Properties.Resources.ChangeEmptyEmailLog);
                return;
            }
            if (!additionalMethods.IsValidEmail(tbUserEmailProfile.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectMail);
                Log.Warn(Properties.Resources.ChangeIncorrectMailLog);
                return;
            }

            var imageByte = additionalMethods.ImageToBytes(pbImageUser.Image);
            if (User.Login == tbUserLoginProfile.Text && User.Email == tbUserEmailProfile.Text
                && additionalMethods.GetImageHash(pbImageUser.Image) == 
                additionalMethods.GetImageHash(additionalMethods.ByteToImage(User.Image)))
            {
                MessageBox.Show(Properties.Resources.NoEditAnything);
                Log.Warn(Properties.Resources.ChangeNoEditAnythingLog);
                return;
            }

            // Проверка на сущ логин
            var usLogin = await db.Users.
                FirstOrDefaultAsync(c => c.Login == tbUserLoginProfile.Text);

            if (usLogin != null && usLogin.Id != User.Id)
            {
                MessageBox.Show(Properties.Resources.UserExistsRegLogin);
                Log.Warn(Properties.Resources.UserExistsLoginToEdit);
                tbUserLoginProfile.Text = User.Login;
                return;
            }

            // Проверка на сущ почту
            var usEmail = await db.Users.
                FirstOrDefaultAsync(c => c.Email == tbUserEmailProfile.Text);

            if (usEmail != null && usEmail.Id != User.Id)
            {
                MessageBox.Show(Properties.Resources.UserExistsRegEmail);
                tbUserEmailProfile.Text = User.Email;
                Log.Warn(Properties.Resources.UserExistsEmailToEdit);
                return;
            }

            // Изм данных
            await db.Users.
                Where(c => c.Login == User.Login)
                .ExecuteUpdateAsync(s =>
                s.SetProperty(c => c.Login, tbUserLoginProfile.Text)
                .SetProperty(c => c.Email, tbUserEmailProfile.Text)
                .SetProperty(c => c.Image, additionalMethods.ImageToBytes(pbImageUser.Image)));

            User.Login = tbUserLoginProfile.Text;
            User.Email = tbUserEmailProfile.Text;
            User.Image = additionalMethods.ImageToBytes(pbImageUser.Image);

            MainMenu.User = User;

            await db.SaveChangesAsync();

            MessageBox.Show(Properties.Resources.SuccessfulEditProfile);

            Log.Info("Успешное изменение данных пользователя");
        }

        private void btnEditProfile_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }

        private void panelToUserInfo_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelToUserInfo);
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            additionalMethods.AddOrEditImage(pbImageUser);
        }

        private void buttonAddImage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }

        private void labelAddPhotoCamera_MouseEnter(object sender, EventArgs e)
        {
            labelAddPhotoCamera.ForeColor = Color.FromArgb(125, 115, 235);
        }

        private void labelAddPhotoCamera_MouseLeave(object sender, EventArgs e)
        {

            labelAddPhotoCamera.ForeColor = Color.Black;
        }

        private async void labelAddPhotoCamera_Click(object sender, EventArgs e)
        {
            var cameraForm = new CameraForm(User);
            cameraForm.FormClosed += async (s, args) =>
            {
                var us = await db.Users.FirstOrDefaultAsync(c => c.Login == User.Login);
                if (us.Image != null)
                {
                    pbImageUser.Image = additionalMethods.ByteToImage(us.Image);
                }
            };
            cameraForm.Show();
        }
    }
}
