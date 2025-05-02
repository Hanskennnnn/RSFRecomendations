using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSFRecomendations.Models;
using RSFRecomendations.UserControles;

namespace RSFRecomendations
{
    public partial class MainMenu : Form
    {
        public static UserModel User { get; set; }

        public MainMenu(UserModel user)
        {
            InitializeComponent();

            User = user;

            ShowControl(new MainMenuControl(User));

        }

        private void btnGoForm_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormAnketaControl(User));
        }

        private void btnGoProgLang_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormProgLangControl(User));
        }

        private void btnGoProfile_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormProfileControl(User));
        }

        private void btnLogoutMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnGoMainMenu_Click(object sender, EventArgs e)
        {
            ShowControl(new MainMenuControl(User));
        }

        private void ShowControl(UserControl control)
        {
            panelMainMenu.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(control);
        }

    }
}
