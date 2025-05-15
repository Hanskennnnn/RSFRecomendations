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
            listBoxFilteredLanguagesInfo = new ListBox();
            labelMainProfile = new Label();
            panelMainAddLanguage = new Panel();
            textBoxDescriptionLanguageInfo = new TextBox();
            pictureBoxImageLanguageInfo = new PictureBox();
            panelMainAddLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageLanguageInfo).BeginInit();
            SuspendLayout();
            // 
            // listBoxFilteredLanguagesInfo
            // 
            listBoxFilteredLanguagesInfo.FormattingEnabled = true;
            listBoxFilteredLanguagesInfo.Location = new Point(207, 20);
            listBoxFilteredLanguagesInfo.Name = "listBoxFilteredLanguagesInfo";
            listBoxFilteredLanguagesInfo.Size = new Size(571, 164);
            listBoxFilteredLanguagesInfo.TabIndex = 10;
            listBoxFilteredLanguagesInfo.SelectedIndexChanged += listBoxFilteredLanguages_SelectedIndexChanged;
            // 
            // labelMainProfile
            // 
            labelMainProfile.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainProfile.Location = new Point(3, 12);
            labelMainProfile.Name = "labelMainProfile";
            labelMainProfile.Size = new Size(556, 38);
            labelMainProfile.TabIndex = 14;
            labelMainProfile.Text = "ИНФОРМАЦИЯ О ЯЗЫКАХ ПРОГРАММИРОВАНИЯ";
            // 
            // panelMainAddLanguage
            // 
            panelMainAddLanguage.BackColor = Color.White;
            panelMainAddLanguage.Controls.Add(listBoxFilteredLanguagesInfo);
            panelMainAddLanguage.Controls.Add(textBoxDescriptionLanguageInfo);
            panelMainAddLanguage.Controls.Add(pictureBoxImageLanguageInfo);
            panelMainAddLanguage.Location = new Point(34, 46);
            panelMainAddLanguage.Name = "panelMainAddLanguage";
            panelMainAddLanguage.Size = new Size(804, 534);
            panelMainAddLanguage.TabIndex = 16;
            panelMainAddLanguage.Paint += panelMainAddLanguage_Paint;
            // 
            // textBoxDescriptionLanguageInfo
            // 
            textBoxDescriptionLanguageInfo.BackColor = SystemColors.Window;
            textBoxDescriptionLanguageInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescriptionLanguageInfo.Location = new Point(21, 209);
            textBoxDescriptionLanguageInfo.Multiline = true;
            textBoxDescriptionLanguageInfo.Name = "textBoxDescriptionLanguageInfo";
            textBoxDescriptionLanguageInfo.Size = new Size(757, 304);
            textBoxDescriptionLanguageInfo.TabIndex = 3;
            textBoxDescriptionLanguageInfo.ReadOnly = true;
            // 
            // pictureBoxImageLanguageInfo
            // 
            pictureBoxImageLanguageInfo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImageLanguageInfo.Location = new Point(21, 20);
            pictureBoxImageLanguageInfo.Name = "pictureBoxImageLanguageInfo";
            pictureBoxImageLanguageInfo.Size = new Size(168, 165);
            pictureBoxImageLanguageInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImageLanguageInfo.TabIndex = 0;
            pictureBoxImageLanguageInfo.TabStop = false;
            // 
            // MainFormProgLangControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainAddLanguage);
            Controls.Add(labelMainProfile);
            Name = "MainFormProgLangControl";
            Size = new Size(873, 627);
            panelMainAddLanguage.ResumeLayout(false);
            panelMainAddLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageLanguageInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbLanguageInfo;
        private Label lbFilteredLanguages;
        private ListBox listBoxFilteredLanguagesInfo;
        private Label labelMainProfile;
        private Panel panelMainAddLanguage;
        private TextBox textBoxDescriptionLanguageInfo;
        private PictureBox pictureBoxImageLanguageInfo;
    }
}
