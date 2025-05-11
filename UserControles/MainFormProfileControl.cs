using System.Data;
using NLog;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    public partial class MainFormProfileControl : UserControl
    {
        private readonly MyDBContext db;

        private AdditionalMethodsClass am;

        private Logger Log;
        UserModel User { get; set; }
        public MainFormProfileControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            am = new AdditionalMethodsClass();

            User = user;
            Log = LogManager.GetCurrentClassLogger();

            tbUserLoginProfile.Text = User.Login;
            tbUserEmailProfile.Text = User.Email;
            pbImageUser.Image = am.ByteToImage(User.Image);


            Log.Info("Переход к форме профиля");
        }

        private void btAddPictureProfile_Click(object sender, EventArgs e)
        {

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
            if (!am.IsValidEmail(tbUserEmailProfile.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectMail);
                Log.Warn(Properties.Resources.ChangeIncorrectMailLog);
                return;
            }

            byte[] imageByte = am.ImageToBytes(pbImageUser.Image);
            if (User.Login == tbUserLoginProfile.Text && User.Email == tbUserEmailProfile.Text && am.GetImageHash(pbImageUser.Image) == am.GetImageHash(am.ByteToImage(User.Image)))
            {
                MessageBox.Show(Properties.Resources.NoEditAnything);
                Log.Warn(Properties.Resources.ChangeNoEditAnythingLog);
                return;
            }

            // Проверка на сущ логин
            var usLogin = await db.Users.FirstOrDefaultAsync(c => c.Login == tbUserLoginProfile.Text);

            if (usLogin != null && usLogin.Id != User.Id)
            {
                MessageBox.Show(Properties.Resources.UserExistsRegLogin);
                Log.Warn(Properties.Resources.UserExistsLoginToEdit);
                tbUserLoginProfile.Text = User.Login;
                return;
            }

            // Проверка на сущ почту
            var usEmail = await db.Users.FirstOrDefaultAsync(c => c.Email == tbUserEmailProfile.Text);

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
                .SetProperty(c => c.Image, am.ImageToBytes(pbImageUser.Image)));

            User.Login = tbUserLoginProfile.Text;
            User.Email = tbUserEmailProfile.Text;
            User.Image = am.ImageToBytes(pbImageUser.Image);

            MainMenu.User = User;

            await db.SaveChangesAsync();

            MessageBox.Show("Изменения успешно сохранены!");

            Log.Info("Успешное изменение данных пользователя");
        }

        private void btnEditProfile_Paint(object sender, PaintEventArgs e)
        {
            am.ButtonPaint(sender, e);
        }

        private void panelToUserInfo_Paint(object sender, PaintEventArgs e)
        {
            am.Panel_Paint(panelToUserInfo);
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImageUser.Image = Image.FromFile(ofd.FileName);
                    pbImageUser.Tag = ofd.FileName;
                }
            }
        }

        private void buttonAddImage_Paint(object sender, PaintEventArgs e)
        {
            am.ButtonPaint(sender, e);
        }
    }
}
