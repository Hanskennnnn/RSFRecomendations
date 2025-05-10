namespace RSFRecomendations.UserControles
{
    partial class MainFormProgLangControl
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
            tbDescriptionLanguage = new TextBox();
            lbFilteredLanguages = new Label();
            listBoxFilteredLanguages = new ListBox();
            SuspendLayout();
            // 
            // lbLanguageInfo
            // 
            lbLanguageInfo.AutoSize = true;
            lbLanguageInfo.Location = new Point(372, 285);
            lbLanguageInfo.Name = "lbLanguageInfo";
            lbLanguageInfo.Size = new Size(124, 20);
            lbLanguageInfo.TabIndex = 13;
            lbLanguageInfo.Text = "Описание языка";
            // 
            // tbDescriptionLanguage
            // 
            tbDescriptionLanguage.Location = new Point(52, 321);
            tbDescriptionLanguage.Multiline = true;
            tbDescriptionLanguage.Name = "tbDescriptionLanguage";
            tbDescriptionLanguage.Size = new Size(769, 290);
            tbDescriptionLanguage.TabIndex = 12;
            tbDescriptionLanguage.TextChanged += tbDescriptionLanguage_TextChanged;
            // 
            // lbFilteredLanguages
            // 
            lbFilteredLanguages.AutoSize = true;
            lbFilteredLanguages.Location = new Point(333, 15);
            lbFilteredLanguages.Name = "lbFilteredLanguages";
            lbFilteredLanguages.Size = new Size(197, 20);
            lbFilteredLanguages.TabIndex = 11;
            lbFilteredLanguages.Text = "Языки программирования";
            // 
            // listBoxFilteredLanguages
            // 
            listBoxFilteredLanguages.FormattingEnabled = true;
            listBoxFilteredLanguages.Location = new Point(90, 38);
            listBoxFilteredLanguages.Name = "listBoxFilteredLanguages";
            listBoxFilteredLanguages.Size = new Size(678, 224);
            listBoxFilteredLanguages.TabIndex = 10;
            listBoxFilteredLanguages.SelectedIndexChanged += listBoxFilteredLanguages_SelectedIndexChanged;
            // 
            // MainFormProgLangControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbLanguageInfo);
            Controls.Add(tbDescriptionLanguage);
            Controls.Add(lbFilteredLanguages);
            Controls.Add(listBoxFilteredLanguages);
            Name = "MainFormProgLangControl";
            Size = new Size(873, 627);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLanguageInfo;
        private TextBox tbDescriptionLanguage;
        private Label lbFilteredLanguages;
        private ListBox listBoxFilteredLanguages;
    }
}
