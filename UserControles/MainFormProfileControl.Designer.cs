namespace RSFRecomendations.UserControles
{
    partial class MainFormProfileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lbUserInfo = new Label();
            panelToUserInfo = new Panel();
            btnEditProfile = new Button();
            btAddPictureProfile = new Button();
            tbUserEmailProfile = new TextBox();
            labelUserEmail = new Label();
            tbUserNameProfile = new TextBox();
            labelUserName = new Label();
            pbImageUser = new PictureBox();
            panelToUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageUser).BeginInit();
            SuspendLayout();
            // 
            // lbUserInfo
            // 
            lbUserInfo.AutoSize = true;
            lbUserInfo.Location = new Point(321, 35);
            lbUserInfo.Name = "lbUserInfo";
            lbUserInfo.Size = new Size(188, 20);
            lbUserInfo.TabIndex = 2;
            lbUserInfo.Text = "Информация об аккаунте";
            // 
            // panelToUserInfo
            // 
            panelToUserInfo.BorderStyle = BorderStyle.FixedSingle;
            panelToUserInfo.Controls.Add(btnEditProfile);
            panelToUserInfo.Controls.Add(btAddPictureProfile);
            panelToUserInfo.Controls.Add(tbUserEmailProfile);
            panelToUserInfo.Controls.Add(labelUserEmail);
            panelToUserInfo.Controls.Add(tbUserNameProfile);
            panelToUserInfo.Controls.Add(labelUserName);
            panelToUserInfo.Controls.Add(pbImageUser);
            panelToUserInfo.Location = new Point(114, 87);
            panelToUserInfo.Name = "panelToUserInfo";
            panelToUserInfo.Size = new Size(645, 505);
            panelToUserInfo.TabIndex = 3;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(383, 226);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(228, 61);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "Редактировать";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btAddPictureProfile
            // 
            btAddPictureProfile.Location = new Point(25, 226);
            btAddPictureProfile.Name = "btAddPictureProfile";
            btAddPictureProfile.Size = new Size(228, 61);
            btAddPictureProfile.TabIndex = 5;
            btAddPictureProfile.Text = "Загрузить картинку";
            btAddPictureProfile.UseVisualStyleBackColor = true;
            btAddPictureProfile.Click += btAddPictureProfile_Click;
            // 
            // tbUserEmailProfile
            // 
            tbUserEmailProfile.Location = new Point(259, 139);
            tbUserEmailProfile.Multiline = true;
            tbUserEmailProfile.Name = "tbUserEmailProfile";
            tbUserEmailProfile.Size = new Size(364, 30);
            tbUserEmailProfile.TabIndex = 4;
            // 
            // labelUserEmail
            // 
            labelUserEmail.AutoSize = true;
            labelUserEmail.Location = new Point(260, 108);
            labelUserEmail.Name = "labelUserEmail";
            labelUserEmail.Size = new Size(55, 20);
            labelUserEmail.TabIndex = 3;
            labelUserEmail.Text = "E-mail:";
            // 
            // tbUserNameProfile
            // 
            tbUserNameProfile.Location = new Point(260, 63);
            tbUserNameProfile.Multiline = true;
            tbUserNameProfile.Name = "tbUserNameProfile";
            tbUserNameProfile.Size = new Size(364, 30);
            tbUserNameProfile.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(259, 30);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(142, 20);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Имя пользователя:";
            // 
            // pbImageUser
            // 
            pbImageUser.BorderStyle = BorderStyle.FixedSingle;
            pbImageUser.Image = Properties.Resources.Без;
            pbImageUser.Location = new Point(64, 30);
            pbImageUser.Name = "pbImageUser";
            pbImageUser.Size = new Size(148, 150);
            pbImageUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbImageUser.TabIndex = 0;
            pbImageUser.TabStop = false;
            // 
            // MainFormProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbUserInfo);
            Controls.Add(panelToUserInfo);
            Name = "MainFormProfileControl";
            Size = new Size(873, 627);
            panelToUserInfo.ResumeLayout(false);
            panelToUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserInfo;
        private Panel panelToUserInfo;
        private Button btnEditProfile;
        private Button btAddPictureProfile;
        private TextBox tbUserEmailProfile;
        private Label labelUserEmail;
        private TextBox tbUserNameProfile;
        private Label labelUserName;
        private PictureBox pbImageUser;
    }
}
