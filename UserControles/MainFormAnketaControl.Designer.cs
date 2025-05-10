namespace RSFRecomendations.UserControles
{
    partial class MainFormAnketaControl
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
            panel1 = new Panel();
            tbPersonalPreferences = new TextBox();
            labelPersonalPreferences = new Label();
            btnChoose = new Button();
            checkBoxHard = new CheckBox();
            checkBoxMid = new CheckBox();
            checkBoxEasy = new CheckBox();
            checkBoxSenior = new CheckBox();
            checkBoxMiddle = new CheckBox();
            checkBoxJunior = new CheckBox();
            clbPurposes = new CheckedListBox();
            labelLanguageDifficulty = new Label();
            labelSkills = new Label();
            labelPurposes = new Label();
            labelAnketa = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbPersonalPreferences);
            panel1.Controls.Add(labelPersonalPreferences);
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(checkBoxHard);
            panel1.Controls.Add(checkBoxMid);
            panel1.Controls.Add(checkBoxEasy);
            panel1.Controls.Add(checkBoxSenior);
            panel1.Controls.Add(checkBoxMiddle);
            panel1.Controls.Add(checkBoxJunior);
            panel1.Controls.Add(clbPurposes);
            panel1.Controls.Add(labelLanguageDifficulty);
            panel1.Controls.Add(labelSkills);
            panel1.Controls.Add(labelPurposes);
            panel1.Location = new Point(99, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 580);
            panel1.TabIndex = 28;
            // 
            // tbPersonalPreferences
            // 
            tbPersonalPreferences.Location = new Point(24, 353);
            tbPersonalPreferences.Multiline = true;
            tbPersonalPreferences.Name = "tbPersonalPreferences";
            tbPersonalPreferences.Size = new Size(631, 156);
            tbPersonalPreferences.TabIndex = 26;
            // 
            // labelPersonalPreferences
            // 
            labelPersonalPreferences.AutoSize = true;
            labelPersonalPreferences.Location = new Point(272, 313);
            labelPersonalPreferences.Name = "labelPersonalPreferences";
            labelPersonalPreferences.Size = new Size(168, 20);
            labelPersonalPreferences.TabIndex = 25;
            labelPersonalPreferences.Text = "Личные предпочтения";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(143, 515);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(430, 50);
            btnChoose.TabIndex = 24;
            btnChoose.Text = "Подобрать";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // checkBoxHard
            // 
            checkBoxHard.AutoSize = true;
            checkBoxHard.Location = new Point(489, 289);
            checkBoxHard.Name = "checkBoxHard";
            checkBoxHard.Size = new Size(97, 24);
            checkBoxHard.TabIndex = 23;
            checkBoxHard.Text = "Сложный";
            checkBoxHard.UseVisualStyleBackColor = true;
            // 
            // checkBoxMid
            // 
            checkBoxMid.AutoSize = true;
            checkBoxMid.Location = new Point(382, 286);
            checkBoxMid.Name = "checkBoxMid";
            checkBoxMid.Size = new Size(92, 24);
            checkBoxMid.TabIndex = 22;
            checkBoxMid.Text = "Средний";
            checkBoxMid.UseVisualStyleBackColor = true;
            // 
            // checkBoxEasy
            // 
            checkBoxEasy.AutoSize = true;
            checkBoxEasy.Location = new Point(250, 286);
            checkBoxEasy.Name = "checkBoxEasy";
            checkBoxEasy.Size = new Size(80, 24);
            checkBoxEasy.TabIndex = 21;
            checkBoxEasy.Text = "Легкий";
            checkBoxEasy.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenior
            // 
            checkBoxSenior.AutoSize = true;
            checkBoxSenior.Location = new Point(489, 246);
            checkBoxSenior.Name = "checkBoxSenior";
            checkBoxSenior.Size = new Size(127, 24);
            checkBoxSenior.TabIndex = 20;
            checkBoxSenior.Text = "Продвинутый";
            checkBoxSenior.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiddle
            // 
            checkBoxMiddle.AutoSize = true;
            checkBoxMiddle.Location = new Point(382, 246);
            checkBoxMiddle.Name = "checkBoxMiddle";
            checkBoxMiddle.Size = new Size(92, 24);
            checkBoxMiddle.TabIndex = 19;
            checkBoxMiddle.Text = "Средний";
            checkBoxMiddle.UseVisualStyleBackColor = true;
            // 
            // checkBoxJunior
            // 
            checkBoxJunior.AutoSize = true;
            checkBoxJunior.Location = new Point(250, 246);
            checkBoxJunior.Name = "checkBoxJunior";
            checkBoxJunior.Size = new Size(126, 24);
            checkBoxJunior.TabIndex = 18;
            checkBoxJunior.Text = "Начинающий";
            checkBoxJunior.UseVisualStyleBackColor = true;
            // 
            // clbPurposes
            // 
            clbPurposes.FormattingEnabled = true;
            clbPurposes.Location = new Point(24, 41);
            clbPurposes.Name = "clbPurposes";
            clbPurposes.Size = new Size(631, 180);
            clbPurposes.TabIndex = 17;
            // 
            // labelLanguageDifficulty
            // 
            labelLanguageDifficulty.AutoSize = true;
            labelLanguageDifficulty.Location = new Point(45, 290);
            labelLanguageDifficulty.Name = "labelLanguageDifficulty";
            labelLanguageDifficulty.Size = new Size(133, 20);
            labelLanguageDifficulty.TabIndex = 16;
            labelLanguageDifficulty.Text = "Сложность языка:";
            // 
            // labelSkills
            // 
            labelSkills.AutoSize = true;
            labelSkills.Location = new Point(45, 246);
            labelSkills.Name = "labelSkills";
            labelSkills.Size = new Size(199, 20);
            labelSkills.TabIndex = 15;
            labelSkills.Text = "Умения программировать:";
            // 
            // labelPurposes
            // 
            labelPurposes.AutoSize = true;
            labelPurposes.Location = new Point(310, 9);
            labelPurposes.Name = "labelPurposes";
            labelPurposes.Size = new Size(45, 20);
            labelPurposes.TabIndex = 14;
            labelPurposes.Text = "Цели";
            // 
            // labelAnketa
            // 
            labelAnketa.AutoSize = true;
            labelAnketa.Font = new Font("Segoe UI", 14F);
            labelAnketa.Location = new Point(319, 9);
            labelAnketa.Name = "labelAnketa";
            labelAnketa.Size = new Size(233, 32);
            labelAnketa.TabIndex = 27;
            labelAnketa.Text = "Заполнение анкеты";
            // 
            // MainFormAnketaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(labelAnketa);
            Name = "MainFormAnketaControl";
            Size = new Size(873, 627);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tbPersonalPreferences;
        private Label labelPersonalPreferences;
        private Button btnChoose;
        private CheckBox checkBoxHard;
        private CheckBox checkBoxMid;
        private CheckBox checkBoxEasy;
        private CheckBox checkBoxSenior;
        private CheckBox checkBoxMiddle;
        private CheckBox checkBoxJunior;
        private CheckedListBox clbPurposes;
        private Label labelLanguageDifficulty;
        private Label labelSkills;
        private Label labelPurposes;
        private Label labelAnketa;
    }
}
