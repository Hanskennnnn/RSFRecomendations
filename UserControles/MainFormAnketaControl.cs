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

namespace RSFRecomendations.UserControles
{
    public partial class MainFormAnketaControl : UserControl
    {
        private readonly MyDBContext db;
        public UserModel User { get; set; }

        public FormModel model { get; set; }
        public MainFormAnketaControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            model = new FormModel();

            User = user;

            clbPurposes.Items.Add("Веб-разработка");
            clbPurposes.Items.Add("ML/AI");
            clbPurposes.Items.Add("Windows-приложения");
            clbPurposes.Items.Add("Игры");
            clbPurposes.Items.Add("Базы данных");
            clbPurposes.Items.Add("Мобильные и десктопные приложения");
            clbPurposes.Items.Add("Системное ПО");
            clbPurposes.Items.Add("Серверы");
            clbPurposes.Items.Add("Веб-разработка");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }

        private void clbPurposes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
