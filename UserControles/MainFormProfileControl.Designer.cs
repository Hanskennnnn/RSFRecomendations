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
            panelToUserInfo = new Panel();
            btnEditProfile = new Button();
            pbImageUser = new PictureBox();
            tbUserEmailProfile = new TextBox();
            tbUserLoginProfile = new TextBox();
            labelMainProfile = new Label();
            panelToUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageUser).BeginInit();
            SuspendLayout();
            // 
            // panelToUserInfo
            // 
            panelToUserInfo.BackColor = Color.White;
            panelToUserInfo.Controls.Add(btnEditProfile);
            panelToUserInfo.Controls.Add(pbImageUser);
            panelToUserInfo.Controls.Add(tbUserEmailProfile);
            panelToUserInfo.Controls.Add(tbUserLoginProfile);
            panelToUserInfo.Location = new Point(41, 51);
            panelToUserInfo.Name = "panelToUserInfo";
            panelToUserInfo.Size = new Size(795, 449);
            panelToUserInfo.TabIndex = 3;
            panelToUserInfo.Paint += panelToUserInfo_Paint;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(125, 115, 235);
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(286, 312);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(228, 61);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "Редактировать";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            btnEditProfile.Paint += btnEditProfile_Paint;
            // 
            // pbImageUser
            // 
            pbImageUser.Image = Properties.Resources.Без;
            pbImageUser.Location = new Point(331, 18);
            pbImageUser.Name = "pbImageUser";
            pbImageUser.Size = new Size(148, 150);
            pbImageUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbImageUser.TabIndex = 0;
            pbImageUser.TabStop = false;
            // 
            // tbUserEmailProfile
            // 
            tbUserEmailProfile.BackColor = SystemColors.Window;
            tbUserEmailProfile.BorderStyle = BorderStyle.FixedSingle;
            tbUserEmailProfile.Location = new Point(231, 250);
            tbUserEmailProfile.Multiline = true;
            tbUserEmailProfile.Name = "tbUserEmailProfile";
            tbUserEmailProfile.Size = new Size(364, 30);
            tbUserEmailProfile.TabIndex = 4;
            // 
            // tbUserLoginProfile
            // 
            tbUserLoginProfile.BackColor = SystemColors.Window;
            tbUserLoginProfile.BorderStyle = BorderStyle.FixedSingle;
            tbUserLoginProfile.Location = new Point(231, 200);
            tbUserLoginProfile.Multiline = true;
            tbUserLoginProfile.Name = "tbUserLoginProfile";
            tbUserLoginProfile.Size = new Size(364, 30);
            tbUserLoginProfile.TabIndex = 2;
            // 
            // labelMainProfile
            // 
            labelMainProfile.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainProfile.Location = new Point(12, 10);
            labelMainProfile.Name = "labelMainProfile";
            labelMainProfile.Size = new Size(362, 38);
            labelMainProfile.TabIndex = 4;
            labelMainProfile.Text = "ИНФОРМАЦИЯ ОБ АККАУНТЕ";
            // 
            // MainFormProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMainProfile);
            Controls.Add(panelToUserInfo);
            Name = "MainFormProfileControl";
            Size = new Size(873, 627);
            panelToUserInfo.ResumeLayout(false);
            panelToUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImageUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelToUserInfo;
        private Button btnEditProfile;
        private TextBox tbUserEmailProfile;
        private TextBox tbUserLoginProfile;
        private PictureBox pbImageUser;
        private Label labelMainProfile;
    }
}
