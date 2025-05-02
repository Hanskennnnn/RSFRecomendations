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

namespace RSFRecomendations
{
    public partial class MainMenuControl : UserControl
    {
        public UserModel User { get; set; }
        public MainMenuControl(UserModel user)
        {
            InitializeComponent();

            User = user;

            listBoxMainMenu.Items.Add("Вы еще не заполнили анкету. Заполните анкету чтобы получить свою первую рекомендацию");
            listBoxMainMenu.ForeColor = Color.Gray;
        }

        private void btnGoFormInMainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
