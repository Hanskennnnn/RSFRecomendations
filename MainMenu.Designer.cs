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
            pictureBox1 = new PictureBox();
            btn = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnLogoutMainMenu = new Button();
            listBoxFilteredLanguages = new ListBox();
            lbFilteredLanguages = new Label();
            button5 = new Button();
            textBox1 = new TextBox();
            lbLanguageInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(btn);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(btnLogoutMainMenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lbLanguageInfo);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(lbFilteredLanguages);
            splitContainer1.Panel2.Controls.Add(listBoxFilteredLanguages);
            splitContainer1.Size = new Size(1182, 628);
            splitContainer1.SplitterDistance = 303;
            splitContainer1.TabIndex = 0;
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
            // btn
            // 
            btn.FlatStyle = FlatStyle.Flat;
            btn.Location = new Point(0, 242);
            btn.Name = "btn";
            btn.Size = new Size(300, 68);
            btn.TabIndex = 3;
            btn.Text = "Главное меню";
            btn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 305);
            button4.Name = "button4";
            button4.Size = new Size(300, 68);
            button4.TabIndex = 1;
            button4.Text = "Анкета";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 431);
            button3.Name = "button3";
            button3.Size = new Size(300, 68);
            button3.TabIndex = 2;
            button3.Text = "Профиль";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 369);
            button2.Name = "button2";
            button2.Size = new Size(300, 68);
            button2.TabIndex = 1;
            button2.Text = "Информация о языках программирования";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnLogoutMainMenu
            // 
            btnLogoutMainMenu.FlatStyle = FlatStyle.Flat;
            btnLogoutMainMenu.Location = new Point(0, 560);
            btnLogoutMainMenu.Name = "btnLogoutMainMenu";
            btnLogoutMainMenu.Size = new Size(300, 68);
            btnLogoutMainMenu.TabIndex = 0;
            btnLogoutMainMenu.Text = "Выйти из аккаунта";
            btnLogoutMainMenu.UseVisualStyleBackColor = true;
            // 
            // listBoxFilteredLanguages
            // 
            listBoxFilteredLanguages.FormattingEnabled = true;
            listBoxFilteredLanguages.Location = new Point(110, 50);
            listBoxFilteredLanguages.Name = "listBoxFilteredLanguages";
            listBoxFilteredLanguages.Size = new Size(678, 224);
            listBoxFilteredLanguages.TabIndex = 0;
            // 
            // lbFilteredLanguages
            // 
            lbFilteredLanguages.AutoSize = true;
            lbFilteredLanguages.Location = new Point(296, 27);
            lbFilteredLanguages.Name = "lbFilteredLanguages";
            lbFilteredLanguages.Size = new Size(300, 20);
            lbFilteredLanguages.TabIndex = 1;
            lbFilteredLanguages.Text = "Подобранные языки программирования";
            // 
            // button5
            // 
            button5.Location = new Point(345, 280);
            button5.Name = "button5";
            button5.Size = new Size(212, 63);
            button5.TabIndex = 2;
            button5.Text = "Заполнить анкету";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 376);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(769, 240);
            textBox1.TabIndex = 3;
            // 
            // lbLanguageInfo
            // 
            lbLanguageInfo.AutoSize = true;
            lbLanguageInfo.Location = new Point(387, 353);
            lbLanguageInfo.Name = "lbLanguageInfo";
            lbLanguageInfo.Size = new Size(124, 20);
            lbLanguageInfo.TabIndex = 4;
            lbLanguageInfo.Text = "Описание языка";
            lbLanguageInfo.Click += lbLanguageInfo_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 628);
            Controls.Add(splitContainer1);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btn;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnLogoutMainMenu;
        private ListBox listBoxFilteredLanguages;
        private Button button5;
        private Label lbFilteredLanguages;
        private Label lbLanguageInfo;
        private TextBox textBox1;
    }
}