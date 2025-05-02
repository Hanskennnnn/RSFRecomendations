using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    public partial class MainFormProfileControl : UserControl
    {
        private readonly MyDBContext db;
        UserModel User { get; set; }
        public MainFormProfileControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();

            User = user;

            tbUserNameProfile.Text = User.Name;
            tbUserEmailProfile.Text = User.Email;
        }

        private void btAddPictureProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserNameProfile.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyName);
                return;
            }
            if (tbUserNameProfile.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceName);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbUserEmailProfile.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyEmail);
                return;
            }
            if (!tbUserEmailProfile.Text.Contains('@'))
            {
                MessageBox.Show(Properties.Resources.NotSobachkaInEmail);
                return;
            }
            if (tbUserEmailProfile.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceEmail);
                return;
            }
            if (!IsValidEmail(tbUserEmailProfile.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectMail);
                return;
            }
            if (User.Name == tbUserNameProfile.Text && User.Email == tbUserEmailProfile.Text)
            {
                MessageBox.Show(Properties.Resources.NoEditAnything);
                return;
            }

            db.Users.
                Where(c => c.Name == User.Name)
                .ExecuteUpdate(s =>
                s.SetProperty(c => c.Name, tbUserNameProfile.Text)
                .SetProperty(c => c.Email, tbUserEmailProfile.Text));


            MainMenu.User = db.Users.FirstOrDefault(c => c.Name == tbUserNameProfile.Text);

            db.SaveChanges();

            MessageBox.Show("Изменения успешно сохранены!");
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
