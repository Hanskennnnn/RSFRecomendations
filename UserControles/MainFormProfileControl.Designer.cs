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
            labelAddPhotoCamera = new Label();
            buttonAddImage = new Button();
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
            panelToUserInfo.Controls.Add(labelAddPhotoCamera);
            panelToUserInfo.Controls.Add(buttonAddImage);
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
            // labelAddPhotoCamera
            // 
            labelAddPhotoCamera.Location = new Point(293, 166);
            labelAddPhotoCamera.Name = "labelAddPhotoCamera";
            labelAddPhotoCamera.Size = new Size(260, 31);
            labelAddPhotoCamera.TabIndex = 7;
            labelAddPhotoCamera.Text = "Добавить изображение с  камеры";
            labelAddPhotoCamera.Click += labelAddPhotoCamera_Click;
            labelAddPhotoCamera.MouseEnter += labelAddPhotoCamera_MouseEnter;
            labelAddPhotoCamera.MouseLeave += labelAddPhotoCamera_MouseLeave;
            // 
            // buttonAddImage
            // 
            buttonAddImage.BackColor = Color.FromArgb(125, 115, 235);
            buttonAddImage.FlatAppearance.BorderSize = 0;
            buttonAddImage.FlatStyle = FlatStyle.Flat;
            buttonAddImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAddImage.ForeColor = Color.White;
            buttonAddImage.Location = new Point(275, 375);
            buttonAddImage.Name = "buttonAddImage";
            buttonAddImage.Size = new Size(278, 61);
            buttonAddImage.TabIndex = 6;
            buttonAddImage.Text = "Изменить фото профиля";
            buttonAddImage.UseVisualStyleBackColor = false;
            buttonAddImage.Click += buttonAddImage_Click;
            buttonAddImage.Paint += buttonAddImage_Paint;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(125, 115, 235);
            btnEditProfile.FlatAppearance.BorderSize = 0;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(275, 297);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(278, 61);
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Text = "Редактировать";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            btnEditProfile.Paint += btnEditProfile_Paint;
            // 
            // pbImageUser
            // 
            pbImageUser.BorderStyle = BorderStyle.FixedSingle;
            pbImageUser.Location = new Point(293, 11);
            pbImageUser.Name = "pbImageUser";
            pbImageUser.Size = new Size(248, 140);
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
        private Button buttonAddImage;
        private Label labelAddPhotoCamera;
    }
}
