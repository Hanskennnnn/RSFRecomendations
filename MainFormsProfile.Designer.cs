namespace RSFRecomendations
{
    partial class MainFormsProfile
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
            pictureBox1 = new PictureBox();
            btnMainMenuMainMenuProfile = new Button();
            btnAnketaMainMenuProfile = new Button();
            btnProfileMainMenuProfile = new Button();
            bInfoMainMenuProfile = new Button();
            btnLogoutMainMenuProfile = new Button();
            lbUserInfo = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(btnMainMenuMainMenuProfile);
            splitContainer1.Panel1.Controls.Add(btnAnketaMainMenuProfile);
            splitContainer1.Panel1.Controls.Add(btnProfileMainMenuProfile);
            splitContainer1.Panel1.Controls.Add(bInfoMainMenuProfile);
            splitContainer1.Panel1.Controls.Add(btnLogoutMainMenuProfile);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbUserInfo);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1182, 628);
            splitContainer1.SplitterDistance = 303;
            splitContainer1.TabIndex = 1;
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
            // btnMainMenuMainMenuProfile
            // 
            btnMainMenuMainMenuProfile.FlatStyle = FlatStyle.Flat;
            btnMainMenuMainMenuProfile.Location = new Point(0, 248);
            btnMainMenuMainMenuProfile.Name = "btnMainMenuMainMenuProfile";
            btnMainMenuMainMenuProfile.Size = new Size(300, 62);
            btnMainMenuMainMenuProfile.TabIndex = 3;
            btnMainMenuMainMenuProfile.Text = "Главное меню";
            btnMainMenuMainMenuProfile.UseVisualStyleBackColor = true;
            // 
            // btnAnketaMainMenuProfile
            // 
            btnAnketaMainMenuProfile.FlatStyle = FlatStyle.Flat;
            btnAnketaMainMenuProfile.Location = new Point(0, 305);
            btnAnketaMainMenuProfile.Name = "btnAnketaMainMenuProfile";
            btnAnketaMainMenuProfile.Size = new Size(300, 68);
            btnAnketaMainMenuProfile.TabIndex = 1;
            btnAnketaMainMenuProfile.Text = "Анкета";
            btnAnketaMainMenuProfile.UseVisualStyleBackColor = true;
            // 
            // btnProfileMainMenuProfile
            // 
            btnProfileMainMenuProfile.FlatStyle = FlatStyle.Flat;
            btnProfileMainMenuProfile.Location = new Point(0, 431);
            btnProfileMainMenuProfile.Name = "btnProfileMainMenuProfile";
            btnProfileMainMenuProfile.Size = new Size(300, 68);
            btnProfileMainMenuProfile.TabIndex = 2;
            btnProfileMainMenuProfile.Text = "Профиль";
            btnProfileMainMenuProfile.UseVisualStyleBackColor = true;
            // 
            // bInfoMainMenuProfile
            // 
            bInfoMainMenuProfile.FlatStyle = FlatStyle.Flat;
            bInfoMainMenuProfile.Location = new Point(0, 369);
            bInfoMainMenuProfile.Name = "bInfoMainMenuProfile";
            bInfoMainMenuProfile.Size = new Size(300, 68);
            bInfoMainMenuProfile.TabIndex = 1;
            bInfoMainMenuProfile.Text = "Информация о языках программирования";
            bInfoMainMenuProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogoutMainMenuProfile
            // 
            btnLogoutMainMenuProfile.FlatStyle = FlatStyle.Flat;
            btnLogoutMainMenuProfile.Location = new Point(0, 560);
            btnLogoutMainMenuProfile.Name = "btnLogoutMainMenuProfile";
            btnLogoutMainMenuProfile.Size = new Size(300, 68);
            btnLogoutMainMenuProfile.TabIndex = 0;
            btnLogoutMainMenuProfile.Text = "Выйти из аккаунта";
            btnLogoutMainMenuProfile.UseVisualStyleBackColor = true;
            // 
            // lbUserInfo
            // 
            lbUserInfo.AutoSize = true;
            lbUserInfo.Location = new Point(332, 26);
            lbUserInfo.Name = "lbUserInfo";
            lbUserInfo.Size = new Size(188, 20);
            lbUserInfo.TabIndex = 0;
            lbUserInfo.Text = "Информация об аккаунте";
            lbUserInfo.Click += lbUserInfo_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(125, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 505);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 139);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(364, 30);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 108);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "E-mail:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 30);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 30);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя пользователя:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(25, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 150);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MainFormsProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(splitContainer1);
            Name = "MainFormsProfile";
            Text = "MainFormsProfile";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btnMainMenuMainMenuProfile;
        private Button btnAnketaMainMenuProfile;
        private Button btnProfileMainMenuProfile;
        private Button bInfoMainMenuProfile;
        private Button btnLogoutMainMenuProfile;
        private Label lbUserInfo;
        private Panel panel1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}