namespace RSFRecomendations
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            buttonAddLanguage = new Button();
            panelRSFLogo = new Panel();
            labelLogo = new Label();
            btnGoMainMenu = new Button();
            btnGoForm = new Button();
            btnGoProfile = new Button();
            btnGoProgLang = new Button();
            btnLogoutMainMenu = new Button();
            panelMainMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelRSFLogo.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonAddLanguage);
            splitContainer1.Panel1.Controls.Add(panelRSFLogo);
            splitContainer1.Panel1.Controls.Add(btnGoMainMenu);
            splitContainer1.Panel1.Controls.Add(btnGoForm);
            splitContainer1.Panel1.Controls.Add(btnGoProfile);
            splitContainer1.Panel1.Controls.Add(btnGoProgLang);
            splitContainer1.Panel1.Controls.Add(btnLogoutMainMenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelMainMenu);
            splitContainer1.Size = new Size(1182, 628);
            splitContainer1.SplitterDistance = 303;
            splitContainer1.TabIndex = 0;
            // 
            // buttonAddLanguage
            // 
            buttonAddLanguage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddLanguage.BackColor = Color.White;
            buttonAddLanguage.FlatAppearance.BorderColor = Color.LightGray;
            buttonAddLanguage.FlatAppearance.BorderSize = 0;
            buttonAddLanguage.FlatStyle = FlatStyle.Flat;
            buttonAddLanguage.Font = new Font("Segoe UI", 9F);
            buttonAddLanguage.ForeColor = Color.Black;
            buttonAddLanguage.Location = new Point(0, 340);
            buttonAddLanguage.Name = "buttonAddLanguage";
            buttonAddLanguage.Size = new Size(303, 69);
            buttonAddLanguage.TabIndex = 4;
            buttonAddLanguage.Text = "Добавление языка";
            buttonAddLanguage.UseVisualStyleBackColor = false;
            buttonAddLanguage.Click += buttonAddLanguage_Click;
            buttonAddLanguage.Paint += buttonAddLanguage_Paint;
            buttonAddLanguage.MouseEnter += buttonAddLanguage_MouseEnter;
            buttonAddLanguage.MouseLeave += buttonAddLanguage_MouseLeave;
            // 
            // panelRSFLogo
            // 
            panelRSFLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelRSFLogo.BackColor = Color.White;
            panelRSFLogo.Controls.Add(labelLogo);
            panelRSFLogo.Location = new Point(0, 1);
            panelRSFLogo.Name = "panelRSFLogo";
            panelRSFLogo.Size = new Size(303, 73);
            panelRSFLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelLogo.ForeColor = Color.MediumSlateBlue;
            labelLogo.Location = new Point(116, 17);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(71, 41);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "RSF";
            // 
            // btnGoMainMenu
            // 
            btnGoMainMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoMainMenu.BackColor = Color.White;
            btnGoMainMenu.FlatAppearance.BorderColor = Color.LightGray;
            btnGoMainMenu.FlatAppearance.BorderSize = 0;
            btnGoMainMenu.FlatStyle = FlatStyle.Flat;
            btnGoMainMenu.Font = new Font("Segoe UI", 9F);
            btnGoMainMenu.ForeColor = Color.Black;
            btnGoMainMenu.Location = new Point(0, 71);
            btnGoMainMenu.Name = "btnGoMainMenu";
            btnGoMainMenu.Size = new Size(303, 68);
            btnGoMainMenu.TabIndex = 3;
            btnGoMainMenu.Text = "Главное меню";
            btnGoMainMenu.UseVisualStyleBackColor = false;
            btnGoMainMenu.Click += btnGoMainMenu_Click;
            btnGoMainMenu.Paint += Btn_PaintBotton;
            btnGoMainMenu.MouseEnter += btnGoMainMenu_MouseEnter;
            btnGoMainMenu.MouseLeave += btnGoMainMenu_MouseLeave;
            // 
            // btnGoForm
            // 
            btnGoForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoForm.BackColor = Color.White;
            btnGoForm.FlatAppearance.BorderColor = Color.LightGray;
            btnGoForm.FlatAppearance.BorderSize = 0;
            btnGoForm.FlatStyle = FlatStyle.Flat;
            btnGoForm.Font = new Font("Segoe UI", 9F);
            btnGoForm.ForeColor = Color.Black;
            btnGoForm.Location = new Point(0, 136);
            btnGoForm.Name = "btnGoForm";
            btnGoForm.Size = new Size(303, 68);
            btnGoForm.TabIndex = 1;
            btnGoForm.Text = "Анкета";
            btnGoForm.UseVisualStyleBackColor = false;
            btnGoForm.Click += btnGoForm_Click;
            btnGoForm.Paint += Btn_PaintBotton;
            btnGoForm.MouseEnter += btnGoForm_MouseEnter;
            btnGoForm.MouseLeave += btnGoForm_MouseLeave;
            // 
            // btnGoProfile
            // 
            btnGoProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoProfile.BackColor = Color.White;
            btnGoProfile.FlatAppearance.BorderColor = Color.LightGray;
            btnGoProfile.FlatAppearance.BorderSize = 0;
            btnGoProfile.FlatStyle = FlatStyle.Flat;
            btnGoProfile.Font = new Font("Segoe UI", 9F);
            btnGoProfile.ForeColor = Color.Black;
            btnGoProfile.Location = new Point(0, 271);
            btnGoProfile.Name = "btnGoProfile";
            btnGoProfile.Size = new Size(303, 69);
            btnGoProfile.TabIndex = 2;
            btnGoProfile.Text = "Профиль";
            btnGoProfile.UseVisualStyleBackColor = false;
            btnGoProfile.Click += btnGoProfile_Click;
            btnGoProfile.Paint += Btn_PaintBotton;
            btnGoProfile.MouseEnter += btnGoProfile_MouseEnter;
            btnGoProfile.MouseLeave += btnGoProfile_MouseLeave;
            // 
            // btnGoProgLang
            // 
            btnGoProgLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGoProgLang.BackColor = Color.White;
            btnGoProgLang.FlatAppearance.BorderColor = Color.LightGray;
            btnGoProgLang.FlatAppearance.BorderSize = 0;
            btnGoProgLang.FlatStyle = FlatStyle.Flat;
            btnGoProgLang.Font = new Font("Segoe UI", 9F);
            btnGoProgLang.ForeColor = Color.Black;
            btnGoProgLang.Location = new Point(0, 201);
            btnGoProgLang.Name = "btnGoProgLang";
            btnGoProgLang.Size = new Size(303, 69);
            btnGoProgLang.TabIndex = 1;
            btnGoProgLang.Text = "Информация о языках программирования";
            btnGoProgLang.UseVisualStyleBackColor = false;
            btnGoProgLang.Click += btnGoProgLang_Click;
            btnGoProgLang.Paint += Btn_PaintBotton;
            btnGoProgLang.MouseEnter += btnGoProgLang_MouseEnter;
            btnGoProgLang.MouseLeave += btnGoProgLang_MouseLeave;
            // 
            // btnLogoutMainMenu
            // 
            btnLogoutMainMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogoutMainMenu.BackColor = Color.White;
            btnLogoutMainMenu.FlatAppearance.BorderColor = Color.LightGray;
            btnLogoutMainMenu.FlatAppearance.BorderSize = 0;
            btnLogoutMainMenu.FlatStyle = FlatStyle.Flat;
            btnLogoutMainMenu.Font = new Font("Segoe UI", 9F);
            btnLogoutMainMenu.ForeColor = Color.Black;
            btnLogoutMainMenu.Location = new Point(3, 548);
            btnLogoutMainMenu.Name = "btnLogoutMainMenu";
            btnLogoutMainMenu.Size = new Size(300, 68);
            btnLogoutMainMenu.TabIndex = 0;
            btnLogoutMainMenu.Text = "Выйти из аккаунта";
            btnLogoutMainMenu.UseVisualStyleBackColor = false;
            btnLogoutMainMenu.Click += btnLogoutMainMenu_Click;
            btnLogoutMainMenu.Paint += Btn_PaintTop;
            btnLogoutMainMenu.MouseEnter += btnLogoutMainMenu_MouseEnter;
            btnLogoutMainMenu.MouseLeave += btnLogoutMainMenu_MouseLeave;
            // 
            // panelMainMenu
            // 
            panelMainMenu.BackColor = Color.FromArgb(240, 241, 246);
            panelMainMenu.Location = new Point(2, 1);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(873, 627);
            panelMainMenu.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(splitContainer1);
            MinimizeBox = false;
            Name = "MainMenu";
            Text = "Главное меню";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelRSFLogo.ResumeLayout(false);
            panelRSFLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnGoMainMenu;
        public Button btnGoForm;
        private Button btnGoProfile;
        private Button btnGoProgLang;
        private Button btnLogoutMainMenu;
        private Panel panelMainMenu;
        private Panel panelRSFLogo;
        private Label labelLogo;
        private Button buttonAddLanguage;
    }
}