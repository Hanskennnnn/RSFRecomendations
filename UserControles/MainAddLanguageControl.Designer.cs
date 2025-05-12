using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    partial class MainAddLanguageControl
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
            labelMainProfile = new Label();
            panelMainAddLanguage = new Panel();
            clbPurposesLanguage = new CheckedListBox();
            buttonAddLanguage = new Button();
            labelLanguageDifficultyLanguage = new Label();
            textBoxDescriptionLanguage = new TextBox();
            textBoxNameLanguage = new TextBox();
            buttonAddImageLanguage = new Button();
            pictureBoxImageLanguage = new PictureBox();
            radioButtonEasy = new RadioButton();
            radioButtonMid = new RadioButton();
            radioButtonHard = new RadioButton();
            panelMainAddLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageLanguage).BeginInit();
            SuspendLayout();
            // 
            // labelMainProfile
            // 
            labelMainProfile.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainProfile.Location = new Point(3, 11);
            labelMainProfile.Name = "labelMainProfile";
            labelMainProfile.Size = new Size(556, 38);
            labelMainProfile.TabIndex = 5;
            labelMainProfile.Text = "ДОБАВЛЕНИЕ ЯЗЫКА ПРОГРАММИРОВАНИЯ";
            // 
            // panelMainAddLanguage
            // 
            panelMainAddLanguage.BackColor = Color.White;
            panelMainAddLanguage.Controls.Add(radioButtonHard);
            panelMainAddLanguage.Controls.Add(radioButtonMid);
            panelMainAddLanguage.Controls.Add(radioButtonEasy);
            panelMainAddLanguage.Controls.Add(clbPurposesLanguage);
            panelMainAddLanguage.Controls.Add(buttonAddLanguage);
            panelMainAddLanguage.Controls.Add(labelLanguageDifficultyLanguage);
            panelMainAddLanguage.Controls.Add(textBoxDescriptionLanguage);
            panelMainAddLanguage.Controls.Add(textBoxNameLanguage);
            panelMainAddLanguage.Controls.Add(buttonAddImageLanguage);
            panelMainAddLanguage.Controls.Add(pictureBoxImageLanguage);
            panelMainAddLanguage.Location = new Point(34, 60);
            panelMainAddLanguage.Name = "panelMainAddLanguage";
            panelMainAddLanguage.Size = new Size(804, 534);
            panelMainAddLanguage.TabIndex = 7;
            panelMainAddLanguage.Paint += panelMainAddLanguage_Paint;
            // 
            // clbPurposesLanguage
            // 
            clbPurposesLanguage.FormattingEnabled = true;
            clbPurposesLanguage.Location = new Point(207, 53);
            clbPurposesLanguage.Name = "clbPurposesLanguage";
            clbPurposesLanguage.Size = new Size(571, 224);
            clbPurposesLanguage.TabIndex = 30;
            // 
            // buttonAddLanguage
            // 
            buttonAddLanguage.Location = new Point(290, 473);
            buttonAddLanguage.Name = "buttonAddLanguage";
            buttonAddLanguage.Size = new Size(202, 44);
            buttonAddLanguage.TabIndex = 29;
            buttonAddLanguage.Text = "Добавить язык";
            buttonAddLanguage.UseVisualStyleBackColor = true;
            buttonAddLanguage.Click += buttonAddLanguage_Click;
            // 
            // labelLanguageDifficultyLanguage
            // 
            labelLanguageDifficultyLanguage.AutoSize = true;
            labelLanguageDifficultyLanguage.Location = new Point(207, 287);
            labelLanguageDifficultyLanguage.Name = "labelLanguageDifficultyLanguage";
            labelLanguageDifficultyLanguage.Size = new Size(133, 20);
            labelLanguageDifficultyLanguage.TabIndex = 25;
            labelLanguageDifficultyLanguage.Text = "Сложность языка:";
            // 
            // textBoxDescriptionLanguage
            // 
            textBoxDescriptionLanguage.BackColor = SystemColors.Window;
            textBoxDescriptionLanguage.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescriptionLanguage.Location = new Point(21, 317);
            textBoxDescriptionLanguage.Multiline = true;
            textBoxDescriptionLanguage.Name = "textBoxDescriptionLanguage";
            textBoxDescriptionLanguage.Size = new Size(757, 134);
            textBoxDescriptionLanguage.TabIndex = 3;
            textBoxDescriptionLanguage.Enter += textBoxDescriptionLanguage_Enter;
            textBoxDescriptionLanguage.Leave += textBoxDescriptionLanguage_Leave;
            // 
            // textBoxNameLanguage
            // 
            textBoxNameLanguage.BackColor = SystemColors.Window;
            textBoxNameLanguage.BorderStyle = BorderStyle.FixedSingle;
            textBoxNameLanguage.Location = new Point(207, 20);
            textBoxNameLanguage.Name = "textBoxNameLanguage";
            textBoxNameLanguage.Size = new Size(342, 27);
            textBoxNameLanguage.TabIndex = 2;
            textBoxNameLanguage.Enter += textBoxNameLanguage_Enter;
            textBoxNameLanguage.Leave += textBoxNameLanguage_Leave;
            // 
            // buttonAddImageLanguage
            // 
            buttonAddImageLanguage.Location = new Point(21, 232);
            buttonAddImageLanguage.Name = "buttonAddImageLanguage";
            buttonAddImageLanguage.Size = new Size(168, 45);
            buttonAddImageLanguage.TabIndex = 1;
            buttonAddImageLanguage.Text = "Добавить картинку";
            buttonAddImageLanguage.UseVisualStyleBackColor = true;
            buttonAddImageLanguage.Click += buttonAddImageLanguage_Click;
            // 
            // pictureBoxImageLanguage
            // 
            pictureBoxImageLanguage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImageLanguage.Location = new Point(21, 20);
            pictureBoxImageLanguage.Name = "pictureBoxImageLanguage";
            pictureBoxImageLanguage.Size = new Size(168, 165);
            pictureBoxImageLanguage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImageLanguage.TabIndex = 0;
            pictureBoxImageLanguage.TabStop = false;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Location = new Point(346, 287);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(79, 24);
            radioButtonEasy.TabIndex = 31;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Tag = Difficulty.Easy;
            radioButtonEasy.Text = "Легкий";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMid
            // 
            radioButtonMid.AutoSize = true;
            radioButtonMid.Location = new Point(446, 287);
            radioButtonMid.Name = "radioButtonMid";
            radioButtonMid.Size = new Size(91, 24);
            radioButtonMid.TabIndex = 32;
            radioButtonMid.TabStop = true;
            radioButtonMid.Tag = Difficulty.Medium;
            radioButtonMid.Text = "Средний";
            radioButtonMid.UseVisualStyleBackColor = true;
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Location = new Point(562, 287);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(96, 24);
            radioButtonHard.TabIndex = 33;
            radioButtonHard.TabStop = true;
            radioButtonHard.Tag = Difficulty.Difficult;
            radioButtonHard.Text = "Сложный";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // MainAddLanguageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainAddLanguage);
            Controls.Add(labelMainProfile);
            Name = "MainAddLanguageControl";
            Size = new Size(873, 627);
            panelMainAddLanguage.ResumeLayout(false);
            panelMainAddLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageLanguage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMainProfile;
        private Panel panelMainAddLanguage;
        private Button buttonAddImageLanguage;
        private PictureBox pictureBoxImageLanguage;
        private TextBox textBoxDescriptionLanguage;
        private TextBox textBoxNameLanguage;
        private Label labelLanguageDifficultyLanguage;
        private Button buttonAddLanguage;
        private CheckedListBox clbPurposesLanguage;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMid;
        private RadioButton radioButtonEasy;
    }
}
