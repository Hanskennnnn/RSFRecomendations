
using Microsoft.VisualBasic.Logging;
using NLog;

namespace RSFRecomendations
{
    

    public partial class LoginForm : Form
    {

        private readonly MyDBContext db;

        public LoginForm()
        {

            InitializeComponent();

            textBoxLogName.Text = Properties.Resources.EnterName;
            textBoxLogName.ForeColor = Color.Gray;
            textBoxLogPassword.Text = Properties.Resources.EnterPassword;
            textBoxLogPassword.ForeColor = Color.Gray;

            db = new MyDBContext();
        }

        private void linkLabelToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var register = new RegisterForm();
            register.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxLogName.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyName);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxLogPassword.Text))
            {
                MessageBox.Show(Properties.Resources.EmptyPassword);
                return;
            }

            var us = db.Users.FirstOrDefault(c => c.Name == textBoxLogName.Text);

            if (us == null)
            {
                MessageBox.Show(Properties.Resources.NoUser);
                return;
            }

            if (textBoxLogPassword.Text != us.Password)
            {
                MessageBox.Show(Properties.Resources.WrongPassword);
                return;
            }

            MessageBox.Show("Успешный вход!");

            this.Hide();
            var main = new MainMenu();
            main.Show();
        }

        private void textBoxLogName_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxLogName, Properties.Resources.EnterName);
        }

        private void textBoxLogName_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxLogName, Properties.Resources.EnterName);
        }

        private void textBoxLogPassword_Enter(object sender, EventArgs e)
        {
            EnterText(textBoxLogPassword, Properties.Resources.EnterPassword, true);
        }

        private void textBoxLogPassword_Leave(object sender, EventArgs e)
        {
            LeaveText(textBoxLogPassword, Properties.Resources.EnterPassword);
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
    }
}
