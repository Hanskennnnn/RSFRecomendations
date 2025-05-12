using RSFRecomendations.Models;

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
            panelMainAddForm = new Panel();
            groupQuestion4 = new GroupBox();
            radioButtonQuestion4Answer3 = new RadioButton();
            radioButtonQuestion4Answer2 = new RadioButton();
            radioButtonQuestion4Answer1 = new RadioButton();
            groupQuestion3 = new GroupBox();
            radioButtonQuestion3Answer5 = new RadioButton();
            radioButtonQuestion3Answer4 = new RadioButton();
            radioButtonQuestion3Answer3 = new RadioButton();
            radioButtonQuestion3Answer2 = new RadioButton();
            radioButtonQuestion3Answer1 = new RadioButton();
            groupBoxQuestion2 = new GroupBox();
            radioButtonQuestion2Answer3 = new RadioButton();
            radioButtonQuestion2Answer2 = new RadioButton();
            radioButtonQuestion2Answer1 = new RadioButton();
            groupBoxQuestion1 = new GroupBox();
            radioButtonQuestion1Answer6 = new RadioButton();
            radioButtonQuestion1Answer5 = new RadioButton();
            radioButtonQuestion1Answer4 = new RadioButton();
            radioButtonQuestion1Answer3 = new RadioButton();
            radioButtonQuestion1Answer2 = new RadioButton();
            radioButtonQuestion1Answer1 = new RadioButton();
            buttonAddForm = new Button();
            labelMainAddLanguage = new Label();
            panelMainAddForm.SuspendLayout();
            groupQuestion4.SuspendLayout();
            groupQuestion3.SuspendLayout();
            groupBoxQuestion2.SuspendLayout();
            groupBoxQuestion1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMainAddForm
            // 
            panelMainAddForm.BackColor = Color.White;
            panelMainAddForm.Controls.Add(groupQuestion4);
            panelMainAddForm.Controls.Add(groupQuestion3);
            panelMainAddForm.Controls.Add(groupBoxQuestion2);
            panelMainAddForm.Controls.Add(groupBoxQuestion1);
            panelMainAddForm.Controls.Add(buttonAddForm);
            panelMainAddForm.Location = new Point(34, 46);
            panelMainAddForm.Name = "panelMainAddForm";
            panelMainAddForm.Size = new Size(804, 565);
            panelMainAddForm.TabIndex = 8;
            panelMainAddForm.Paint += panelMainAddLanguage_Paint;
            // 
            // groupQuestion4
            // 
            groupQuestion4.Controls.Add(radioButtonQuestion4Answer3);
            groupQuestion4.Controls.Add(radioButtonQuestion4Answer2);
            groupQuestion4.Controls.Add(radioButtonQuestion4Answer1);
            groupQuestion4.Font = new Font("Segoe UI", 13F);
            groupQuestion4.Location = new Point(17, 372);
            groupQuestion4.Name = "groupQuestion4";
            groupQuestion4.Size = new Size(771, 124);
            groupQuestion4.TabIndex = 30;
            groupQuestion4.TabStop = false;
            groupQuestion4.Text = "4. Сколько времени готовы уделять обучению в неделю?";
            // 
            // radioButtonQuestion4Answer3
            // 
            radioButtonQuestion4Answer3.AutoSize = true;
            radioButtonQuestion4Answer3.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion4Answer3.Location = new Point(14, 95);
            radioButtonQuestion4Answer3.Name = "radioButtonQuestion4Answer3";
            radioButtonQuestion4Answer3.Size = new Size(116, 24);
            radioButtonQuestion4Answer3.TabIndex = 27;
            radioButtonQuestion4Answer3.TabStop = true;
            radioButtonQuestion4Answer1.Tag = TimeToEducation.SixToTenPlusHours;
            radioButtonQuestion4Answer3.Text = "6–10+ часов";
            radioButtonQuestion4Answer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion4Answer2
            // 
            radioButtonQuestion4Answer2.AutoSize = true;
            radioButtonQuestion4Answer2.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion4Answer2.Location = new Point(14, 65);
            radioButtonQuestion4Answer2.Name = "radioButtonQuestion4Answer2";
            radioButtonQuestion4Answer2.Size = new Size(98, 24);
            radioButtonQuestion4Answer2.TabIndex = 26;
            radioButtonQuestion4Answer2.TabStop = true;
            radioButtonQuestion4Answer1.Tag = TimeToEducation.ThreeToFiveHours;
            radioButtonQuestion4Answer2.Text = "3–5 часов";
            radioButtonQuestion4Answer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion4Answer1
            // 
            radioButtonQuestion4Answer1.AutoSize = true;
            radioButtonQuestion4Answer1.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion4Answer1.Location = new Point(14, 35);
            radioButtonQuestion4Answer1.Name = "radioButtonQuestion4Answer1";
            radioButtonQuestion4Answer1.Size = new Size(96, 24);
            radioButtonQuestion4Answer1.TabIndex = 25;
            radioButtonQuestion4Answer1.TabStop = true;
            radioButtonQuestion4Answer1.Tag = TimeToEducation.LessThanThreeHours;
            radioButtonQuestion4Answer1.Text = "< 3 часов";
            radioButtonQuestion4Answer1.UseVisualStyleBackColor = true;
            // 
            // groupQuestion3
            // 
            groupQuestion3.Controls.Add(radioButtonQuestion3Answer5);
            groupQuestion3.Controls.Add(radioButtonQuestion3Answer4);
            groupQuestion3.Controls.Add(radioButtonQuestion3Answer3);
            groupQuestion3.Controls.Add(radioButtonQuestion3Answer2);
            groupQuestion3.Controls.Add(radioButtonQuestion3Answer1);
            groupQuestion3.Font = new Font("Segoe UI", 13F);
            groupQuestion3.Location = new Point(17, 241);
            groupQuestion3.Name = "groupQuestion3";
            groupQuestion3.Size = new Size(771, 125);
            groupQuestion3.TabIndex = 25;
            groupQuestion3.TabStop = false;
            groupQuestion3.Text = "3. Что тебе важнее в языке программирования?";
            // 
            // radioButtonQuestion3Answer5
            // 
            radioButtonQuestion3Answer5.AutoSize = true;
            radioButtonQuestion3Answer5.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion3Answer5.Location = new Point(218, 65);
            radioButtonQuestion3Answer5.Name = "radioButtonQuestion3Answer5";
            radioButtonQuestion3Answer5.Size = new Size(227, 24);
            radioButtonQuestion3Answer5.TabIndex = 29;
            radioButtonQuestion3Answer5.TabStop = true;
            radioButtonQuestion3Answer5.Text = "Много учебных материалов";
            radioButtonQuestion3Answer5.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion3Answer4
            // 
            radioButtonQuestion3Answer4.AutoSize = true;
            radioButtonQuestion3Answer4.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion3Answer4.Location = new Point(218, 35);
            radioButtonQuestion3Answer4.Name = "radioButtonQuestion3Answer4";
            radioButtonQuestion3Answer4.Size = new Size(222, 24);
            radioButtonQuestion3Answer4.TabIndex = 28;
            radioButtonQuestion3Answer4.TabStop = true;
            radioButtonQuestion3Answer4.Text = "Возможность найти работу";
            radioButtonQuestion3Answer4.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion3Answer3
            // 
            radioButtonQuestion3Answer3.AutoSize = true;
            radioButtonQuestion3Answer3.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion3Answer3.Location = new Point(14, 95);
            radioButtonQuestion3Answer3.Name = "radioButtonQuestion3Answer3";
            radioButtonQuestion3Answer3.Size = new Size(144, 24);
            radioButtonQuestion3Answer3.TabIndex = 27;
            radioButtonQuestion3Answer3.TabStop = true;
            radioButtonQuestion3Answer3.Text = "Быстродействие";
            radioButtonQuestion3Answer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion3Answer2
            // 
            radioButtonQuestion3Answer2.AutoSize = true;
            radioButtonQuestion3Answer2.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion3Answer2.Location = new Point(14, 65);
            radioButtonQuestion3Answer2.Name = "radioButtonQuestion3Answer2";
            radioButtonQuestion3Answer2.Size = new Size(152, 24);
            radioButtonQuestion3Answer2.TabIndex = 26;
            radioButtonQuestion3Answer2.TabStop = true;
            radioButtonQuestion3Answer2.Text = "Универсальность";
            radioButtonQuestion3Answer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion3Answer1
            // 
            radioButtonQuestion3Answer1.AutoSize = true;
            radioButtonQuestion3Answer1.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion3Answer1.Location = new Point(14, 35);
            radioButtonQuestion3Answer1.Name = "radioButtonQuestion3Answer1";
            radioButtonQuestion3Answer1.Size = new Size(192, 24);
            radioButtonQuestion3Answer1.TabIndex = 25;
            radioButtonQuestion3Answer1.TabStop = true;
            radioButtonQuestion3Answer1.Text = "Простота и понятность";
            radioButtonQuestion3Answer1.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuestion2
            // 
            groupBoxQuestion2.Controls.Add(radioButtonQuestion2Answer3);
            groupBoxQuestion2.Controls.Add(radioButtonQuestion2Answer2);
            groupBoxQuestion2.Controls.Add(radioButtonQuestion2Answer1);
            groupBoxQuestion2.Font = new Font("Segoe UI", 13F);
            groupBoxQuestion2.Location = new Point(17, 114);
            groupBoxQuestion2.Name = "groupBoxQuestion2";
            groupBoxQuestion2.Size = new Size(771, 121);
            groupBoxQuestion2.TabIndex = 16;
            groupBoxQuestion2.TabStop = false;
            groupBoxQuestion2.Text = "2. Какой у вас уровень подготовки?";
            // 
            // radioButtonQuestion2Answer3
            // 
            radioButtonQuestion2Answer3.AutoSize = true;
            radioButtonQuestion2Answer3.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion2Answer3.Location = new Point(14, 91);
            radioButtonQuestion2Answer3.Name = "radioButtonQuestion2Answer3";
            radioButtonQuestion2Answer3.Size = new Size(343, 24);
            radioButtonQuestion2Answer3.TabIndex = 2;
            radioButtonQuestion2Answer3.TabStop = true;
            radioButtonQuestion2Answer3.Text = "Продвинутый (уже решал задачи, писал код)";
            radioButtonQuestion2Answer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion2Answer2
            // 
            radioButtonQuestion2Answer2.AutoSize = true;
            radioButtonQuestion2Answer2.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion2Answer2.Location = new Point(14, 65);
            radioButtonQuestion2Answer2.Name = "radioButtonQuestion2Answer2";
            radioButtonQuestion2Answer2.Size = new Size(334, 24);
            radioButtonQuestion2Answer2.TabIndex = 1;
            radioButtonQuestion2Answer2.TabStop = true;
            radioButtonQuestion2Answer2.Text = "Базовый (знаю основы, немного практики)";
            radioButtonQuestion2Answer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion2Answer1
            // 
            radioButtonQuestion2Answer1.AutoSize = true;
            radioButtonQuestion2Answer1.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion2Answer1.Location = new Point(14, 35);
            radioButtonQuestion2Answer1.Name = "radioButtonQuestion2Answer1";
            radioButtonQuestion2Answer1.Size = new Size(247, 24);
            radioButtonQuestion2Answer1.TabIndex = 0;
            radioButtonQuestion2Answer1.TabStop = true;
            radioButtonQuestion2Answer1.Tag = ProgrammingSkill.Advanced;
            radioButtonQuestion2Answer1.Text = "Новичок (ещё ничего не знаю)";
            radioButtonQuestion2Answer1.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuestion1
            // 
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer6);
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer5);
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer4);
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer3);
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer2);
            groupBoxQuestion1.Controls.Add(radioButtonQuestion1Answer1);
            groupBoxQuestion1.Font = new Font("Segoe UI", 13F);
            groupBoxQuestion1.Location = new Point(17, 3);
            groupBoxQuestion1.Name = "groupBoxQuestion1";
            groupBoxQuestion1.Size = new Size(771, 105);
            groupBoxQuestion1.TabIndex = 23;
            groupBoxQuestion1.TabStop = false;
            groupBoxQuestion1.Text = "1. Какая ваша основная цель в изучении программирования?";
            // 
            // radioButtonQuestion1Answer6
            // 
            radioButtonQuestion1Answer6.AutoSize = true;
            radioButtonQuestion1Answer6.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer6.Location = new Point(421, 65);
            radioButtonQuestion1Answer6.Name = "radioButtonQuestion1Answer6";
            radioButtonQuestion1Answer6.Size = new Size(238, 24);
            radioButtonQuestion1Answer6.TabIndex = 15;
            radioButtonQuestion1Answer6.TabStop = true;
            radioButtonQuestion1Answer6.Tag = Purpose.DataScienceAndDataAnalysis;
            radioButtonQuestion1Answer6.Text = "Data Science и анализ данных";
            radioButtonQuestion1Answer6.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion1Answer5
            // 
            radioButtonQuestion1Answer5.AutoSize = true;
            radioButtonQuestion1Answer5.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer5.Location = new Point(421, 35);
            radioButtonQuestion1Answer5.Name = "radioButtonQuestion1Answer5";
            radioButtonQuestion1Answer5.Size = new Size(190, 24);
            radioButtonQuestion1Answer5.TabIndex = 14;
            radioButtonQuestion1Answer5.TabStop = true;
            radioButtonQuestion1Answer5.Tag = Purpose.ServerSideDevelopment;
            radioButtonQuestion1Answer5.Text = "Серверная разработка";
            radioButtonQuestion1Answer5.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion1Answer4
            // 
            radioButtonQuestion1Answer4.AutoSize = true;
            radioButtonQuestion1Answer4.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer4.Location = new Point(218, 65);
            radioButtonQuestion1Answer4.Name = "radioButtonQuestion1Answer4";
            radioButtonQuestion1Answer4.Size = new Size(136, 24);
            radioButtonQuestion1Answer4.TabIndex = 13;
            radioButtonQuestion1Answer4.TabStop = true;
            radioButtonQuestion1Answer4.Tag = Purpose.Microservices;
            radioButtonQuestion1Answer4.Text = "Микросервисы";
            radioButtonQuestion1Answer4.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion1Answer3
            // 
            radioButtonQuestion1Answer3.AutoSize = true;
            radioButtonQuestion1Answer3.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer3.Location = new Point(218, 35);
            radioButtonQuestion1Answer3.Name = "radioButtonQuestion1Answer3";
            radioButtonQuestion1Answer3.Size = new Size(121, 24);
            radioButtonQuestion1Answer3.TabIndex = 12;
            radioButtonQuestion1Answer3.TabStop = true;
            radioButtonQuestion1Answer3.Tag = Purpose.ApplicationDevelopment;
            radioButtonQuestion1Answer3.Text = "Приложения";
            radioButtonQuestion1Answer3.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion1Answer2
            // 
            radioButtonQuestion1Answer2.AutoSize = true;
            radioButtonQuestion1Answer2.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer2.Location = new Point(14, 65);
            radioButtonQuestion1Answer2.Name = "radioButtonQuestion1Answer2";
            radioButtonQuestion1Answer2.Size = new Size(67, 24);
            radioButtonQuestion1Answer2.TabIndex = 11;
            radioButtonQuestion1Answer2.TabStop = true;
            radioButtonQuestion1Answer2.Tag = Purpose.GameDevelopment;
            radioButtonQuestion1Answer2.Text = "Игры";
            radioButtonQuestion1Answer2.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestion1Answer1
            // 
            radioButtonQuestion1Answer1.AutoSize = true;
            radioButtonQuestion1Answer1.Font = new Font("Segoe UI", 9F);
            radioButtonQuestion1Answer1.Location = new Point(14, 35);
            radioButtonQuestion1Answer1.Name = "radioButtonQuestion1Answer1";
            radioButtonQuestion1Answer1.Size = new Size(203, 24);
            radioButtonQuestion1Answer1.TabIndex = 10;
            radioButtonQuestion1Answer1.TabStop = true;
            radioButtonQuestion1Answer1.Tag = Purpose.WebDevelopment;
            radioButtonQuestion1Answer1.Text = "Веб-программирование";
            radioButtonQuestion1Answer1.UseVisualStyleBackColor = true;
            // 
            // buttonAddForm
            // 
            buttonAddForm.BackColor = Color.FromArgb(125, 115, 235);
            buttonAddForm.FlatAppearance.BorderSize = 0;
            buttonAddForm.FlatStyle = FlatStyle.Flat;
            buttonAddForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAddForm.ForeColor = Color.White;
            buttonAddForm.Location = new Point(297, 502);
            buttonAddForm.Name = "buttonAddForm";
            buttonAddForm.Size = new Size(215, 60);
            buttonAddForm.TabIndex = 22;
            buttonAddForm.Text = "Подобрать";
            buttonAddForm.UseVisualStyleBackColor = false;
            buttonAddForm.Click += buttonAddForm_Click;
            buttonAddForm.Paint += buttonAddForm_Paint;
            // 
            // labelMainAddLanguage
            // 
            labelMainAddLanguage.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainAddLanguage.Location = new Point(3, 5);
            labelMainAddLanguage.Name = "labelMainAddLanguage";
            labelMainAddLanguage.Size = new Size(317, 38);
            labelMainAddLanguage.TabIndex = 9;
            labelMainAddLanguage.Text = "ЗАПОЛНЕНИЕ АНКЕТЫ";
            labelMainAddLanguage.UseMnemonic = false;
            // 
            // MainFormAnketaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMainAddLanguage);
            Controls.Add(panelMainAddForm);
            Name = "MainFormAnketaControl";
            Size = new Size(873, 627);
            panelMainAddForm.ResumeLayout(false);
            groupQuestion4.ResumeLayout(false);
            groupQuestion4.PerformLayout();
            groupQuestion3.ResumeLayout(false);
            groupQuestion3.PerformLayout();
            groupBoxQuestion2.ResumeLayout(false);
            groupBoxQuestion2.PerformLayout();
            groupBoxQuestion1.ResumeLayout(false);
            groupBoxQuestion1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMainAddForm;
        private Label labelMainAddLanguage;
        private Label label2;
        private Button buttonAddForm;
        private GroupBox groupBoxQuestion1;
        private RadioButton radioButtonQuestion1Answer6;
        private RadioButton radioButtonQuestion1Answer5;
        private RadioButton radioButtonQuestion1Answer4;
        private RadioButton radioButtonQuestion1Answer3;
        private RadioButton radioButtonQuestion1Answer2;
        private RadioButton radioButtonQuestion1Answer1;
        private GroupBox groupBoxQuestion2;
        private RadioButton radioButtonQuestion2Answer3;
        private RadioButton radioButtonQuestion2Answer2;
        private RadioButton radioButtonQuestion2Answer1;
        private GroupBox groupQuestion3;
        private RadioButton radioButtonQuestion3Answer5;
        private RadioButton radioButtonQuestion3Answer4;
        private RadioButton radioButtonQuestion3Answer3;
        private RadioButton radioButtonQuestion3Answer2;
        private RadioButton radioButtonQuestion3Answer1;
        private GroupBox groupQuestion4;
        private RadioButton radioButtonQuestion4Answer3;
        private RadioButton radioButtonQuestion4Answer2;
        private RadioButton radioButtonQuestion4Answer1;
    }
}
