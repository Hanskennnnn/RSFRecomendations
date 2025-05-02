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
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    public partial class RegisterForm : Form
    {
        private readonly MyDBContext db;
        public RegisterForm()
        {
            InitializeComponent();

            db = new MyDBContext();

            textBoxRegName.Text = Properties.Resources.EnterName;
            textBoxRegName.ForeColor = Color.Gray;
            textBoxRegEmail.Text = Properties.Resources.EnterEmail;
            textBoxRegEmail.ForeColor = Color.Gray;
            textBoxRegPassword.Text = Properties.Resources.EnterPassword;
            textBoxRegPassword.ForeColor = Color.Gray;
            textBoxRegPassword2.Text = Properties.Resources.EnterRepeatPassword;
            textBoxRegPassword2.ForeColor = Color.Gray;
        }

        private void linkLabelToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRegName.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyName);
                return;
            }
            if (textBoxRegName.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceName);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegEmail.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyEmail);
                return;
            }
            if (!textBoxRegEmail.Text.Contains('@'))
            {
                MessageBox.Show(Properties.Resources.NotSobachkaInEmail);
                return;
            }
            if (textBoxRegEmail.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpaceEmail);
                return;
            }
            if (!IsValidEmail(textBoxRegEmail.Text))
            {
                MessageBox.Show(Properties.Resources.IncorrectMail);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegPassword.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyPassword);
                return;
            }
            if (textBoxRegPassword.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpacePassword);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRegPassword2.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyRepeatPassword);
                return;
            }
            if (textBoxRegPassword.Text != textBoxRegPassword2.Text)
            {
                MessageBox.Show(Properties.Resources.PasswordsDontMatch);
                return;
            }
            if (textBoxRegPassword2.Text.Contains(" "))
            {
                MessageBox.Show(Properties.Resources.NoContainsSpacePassword);
                return;
            }

            var us = db.Users.FirstOrDefault(c => c.Name == textBoxRegName.Text);

            if (us != null)
            {
                MessageBox.Show(Properties.Resources.UserExists);
                return;
            }

            var user = new UserModel
            {
                Name = textBoxRegName.Text,
                Email = textBoxRegEmail.Text,
                Password = textBoxRegPassword.Text
            };

            db.Add(user);
            db.SaveChanges();

            MessageBox.Show("Регистрация прошла успешно!!!");


            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[a-zA-Z]+\.[a-zA-Z]+$";
            return Regex.IsMatch(email, pattern);
        }

        public void EnterText(TextBox textBox, string res, bool pass = false)
        {
            if (textBox.Text == res)
            {
                textBox.Text = String.Empty;
                textBox.ForeColor = Color.Black;
                textBox.UseSystemPasswordChar = pass;
            }
        }

        public void LeaveText(TextBox textBox, string res, bool pass = false)
        {
            if (textBox.Text == String.Empty)
            {
                textBox.Text = res;
                textBox.ForeColor = Color.Gray;
                textBox.UseSystemPasswordChar = pass;
            }
        }

        private void textBoxRegName_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxRegName, Properties.Resources.EnterName);
        }

        private void textBoxRegName_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxRegName, Properties.Resources.EnterName);
        }

        private void textBoxRegEmail_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxRegEmail, Properties.Resources.EnterEmail);
        }

        private void textBoxRegEmail_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxRegEmail, Properties.Resources.EnterEmail);
        }

        private void textBoxRegPassword_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxRegPassword, Properties.Resources.EnterPassword, true);
        }

        private void textBoxRegPassword_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxRegPassword, Properties.Resources.EnterPassword);
        }

        private void textBoxRegPassword2_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxRegPassword2, Properties.Resources.EnterRepeatPassword, true);
        }

        private void textBoxRegPassword2_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxRegPassword2, Properties.Resources.EnterRepeatPassword);
        }
    }
}
