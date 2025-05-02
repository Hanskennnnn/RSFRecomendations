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
            pbTeamRSF = new PictureBox();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pbTeamRSF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pbTeamRSF);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
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
            // pbTeamRSF
            // 
            pbTeamRSF.Image = Properties.Resources.TeamRSF;
            pbTeamRSF.Location = new Point(3, 3);
            pbTeamRSF.Name = "pbTeamRSF";
            pbTeamRSF.Size = new Size(297, 244);
            pbTeamRSF.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTeamRSF.TabIndex = 5;
            pbTeamRSF.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnGoMainMenu
            // 
            btnGoMainMenu.FlatStyle = FlatStyle.Flat;
            btnGoMainMenu.Location = new Point(0, 242);
            btnGoMainMenu.Name = "btnGoMainMenu";
            btnGoMainMenu.Size = new Size(300, 68);
            btnGoMainMenu.TabIndex = 3;
            btnGoMainMenu.Text = "Главное меню";
            btnGoMainMenu.UseVisualStyleBackColor = true;
            btnGoMainMenu.Click += btnGoMainMenu_Click;
            // 
            // btnGoForm
            // 
            btnGoForm.FlatStyle = FlatStyle.Flat;
            btnGoForm.Location = new Point(0, 305);
            btnGoForm.Name = "btnGoForm";
            btnGoForm.Size = new Size(300, 68);
            btnGoForm.TabIndex = 1;
            btnGoForm.Text = "Анкета";
            btnGoForm.UseVisualStyleBackColor = true;
            btnGoForm.Click += btnGoForm_Click;
            // 
            // btnGoProfile
            // 
            btnGoProfile.FlatStyle = FlatStyle.Flat;
            btnGoProfile.Location = new Point(0, 431);
            btnGoProfile.Name = "btnGoProfile";
            btnGoProfile.Size = new Size(300, 68);
            btnGoProfile.TabIndex = 2;
            btnGoProfile.Text = "Профиль";
            btnGoProfile.UseVisualStyleBackColor = true;
            btnGoProfile.Click += btnGoProfile_Click;
            // 
            // btnGoProgLang
            // 
            btnGoProgLang.FlatStyle = FlatStyle.Flat;
            btnGoProgLang.Location = new Point(0, 369);
            btnGoProgLang.Name = "btnGoProgLang";
            btnGoProgLang.Size = new Size(300, 68);
            btnGoProgLang.TabIndex = 1;
            btnGoProgLang.Text = "Информация о языках программирования";
            btnGoProgLang.UseVisualStyleBackColor = true;
            btnGoProgLang.Click += btnGoProgLang_Click;
            // 
            // btnLogoutMainMenu
            // 
            btnLogoutMainMenu.FlatStyle = FlatStyle.Flat;
            btnLogoutMainMenu.Location = new Point(3, 548);
            btnLogoutMainMenu.Name = "btnLogoutMainMenu";
            btnLogoutMainMenu.Size = new Size(300, 68);
            btnLogoutMainMenu.TabIndex = 0;
            btnLogoutMainMenu.Text = "Выйти из аккаунта";
            btnLogoutMainMenu.UseVisualStyleBackColor = true;
            btnLogoutMainMenu.Click += btnLogoutMainMenu_Click;
            // 
            // panelMainMenu
            // 
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
            Name = "MainMenu";
            Text = "MainMenu";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTeamRSF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btnGoMainMenu;
        private Button btnGoForm;
        private Button btnGoProfile;
        private Button btnGoProgLang;
        private Button btnLogoutMainMenu;
        private PictureBox pbTeamRSF;
        private Panel panelMainMenu;
    }
}