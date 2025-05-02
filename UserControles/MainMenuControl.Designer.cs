namespace RSFRecomendations
{
    partial class MainMenuControl
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
            lbLanguageInfo = new Label();
            tbDescriptionLanguageInfo = new TextBox();
            btnGoFormInMainMenu = new Button();
            lbFilteredLanguages = new Label();
            listBoxMainMenu = new ListBox();
            SuspendLayout();
            // 
            // lbLanguageInfo
            // 
            lbLanguageInfo.AutoSize = true;
            lbLanguageInfo.Location = new Point(378, 345);
            lbLanguageInfo.Name = "lbLanguageInfo";
            lbLanguageInfo.Size = new Size(124, 20);
            lbLanguageInfo.TabIndex = 9;
            lbLanguageInfo.Text = "Описание языка";
            // 
            // tbDescriptionLanguageInfo
            // 
            tbDescriptionLanguageInfo.Location = new Point(52, 368);
            tbDescriptionLanguageInfo.Multiline = true;
            tbDescriptionLanguageInfo.Name = "tbDescriptionLanguageInfo";
            tbDescriptionLanguageInfo.Size = new Size(769, 240);
            tbDescriptionLanguageInfo.TabIndex = 8;
            // 
            // btnGoFormInMainMenu
            // 
            btnGoFormInMainMenu.Location = new Point(336, 272);
            btnGoFormInMainMenu.Name = "btnGoFormInMainMenu";
            btnGoFormInMainMenu.Size = new Size(212, 63);
            btnGoFormInMainMenu.TabIndex = 7;
            btnGoFormInMainMenu.Text = "Заполнить анкету";
            btnGoFormInMainMenu.UseVisualStyleBackColor = true;
            btnGoFormInMainMenu.Click += btnGoFormInMainMenu_Click;
            // 
            // lbFilteredLanguages
            // 
            lbFilteredLanguages.AutoSize = true;
            lbFilteredLanguages.Location = new Point(287, 19);
            lbFilteredLanguages.Name = "lbFilteredLanguages";
            lbFilteredLanguages.Size = new Size(300, 20);
            lbFilteredLanguages.TabIndex = 6;
            lbFilteredLanguages.Text = "Подобранные языки программирования";
            // 
            // listBoxMainMenu
            // 
            listBoxMainMenu.FormattingEnabled = true;
            listBoxMainMenu.Location = new Point(101, 42);
            listBoxMainMenu.Name = "listBoxMainMenu";
            listBoxMainMenu.Size = new Size(678, 224);
            listBoxMainMenu.TabIndex = 5;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbLanguageInfo);
            Controls.Add(tbDescriptionLanguageInfo);
            Controls.Add(btnGoFormInMainMenu);
            Controls.Add(lbFilteredLanguages);
            Controls.Add(listBoxMainMenu);
            Name = "MainMenuControl";
            Size = new Size(873, 627);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLanguageInfo;
        private TextBox tbDescriptionLanguageInfo;
        private Button btnGoFormInMainMenu;
        private Label lbFilteredLanguages;
        private ListBox listBoxMainMenu;
    }
}
