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
            labelMainMenu = new Label();
            panelMainMenu = new Panel();
            panelLang3 = new Panel();
            labelTop3 = new Label();
            labelLang3 = new Label();
            pictureBoxLang3 = new PictureBox();
            panelLang2 = new Panel();
            labelTop2 = new Label();
            labelLang2 = new Label();
            pictureBoxLang2 = new PictureBox();
            panelLang1 = new Panel();
            labelTop1 = new Label();
            labelLang1 = new Label();
            pictureBoxLang1 = new PictureBox();
            panelMainMenu.SuspendLayout();
            panelLang3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang3).BeginInit();
            panelLang2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang2).BeginInit();
            panelLang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang1).BeginInit();
            SuspendLayout();
            // 
            // labelMainMenu
            // 
            labelMainMenu.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainMenu.Location = new Point(3, 21);
            labelMainMenu.Name = "labelMainMenu";
            labelMainMenu.Size = new Size(451, 38);
            labelMainMenu.TabIndex = 5;
            labelMainMenu.Text = "ТОП-3 ЯЗЫКА ПРОГРАММИРОВАНИЯ";
            // 
            // panelMainMenu
            // 
            panelMainMenu.BackColor = Color.White;
            panelMainMenu.Controls.Add(panelLang3);
            panelMainMenu.Controls.Add(panelLang2);
            panelMainMenu.Controls.Add(panelLang1);
            panelMainMenu.Location = new Point(37, 73);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(804, 507);
            panelMainMenu.TabIndex = 6;
            panelMainMenu.Paint += panelMainMenu_Paint;
            // 
            // panelLang3
            // 
            panelLang3.BorderStyle = BorderStyle.FixedSingle;
            panelLang3.Controls.Add(labelTop3);
            panelLang3.Controls.Add(labelLang3);
            panelLang3.Controls.Add(pictureBoxLang3);
            panelLang3.Location = new Point(545, 60);
            panelLang3.Name = "panelLang3";
            panelLang3.Size = new Size(236, 382);
            panelLang3.TabIndex = 2;
            // 
            // labelTop3
            // 
            labelTop3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelTop3.Location = new Point(77, 342);
            labelTop3.Name = "labelTop3";
            labelTop3.Size = new Size(84, 38);
            labelTop3.TabIndex = 9;
            labelTop3.Text = "ТОП-3";
            // 
            // labelLang3
            // 
            labelLang3.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang3.Location = new Point(77, 214);
            labelLang3.Name = "labelLang3";
            labelLang3.Size = new Size(132, 29);
            labelLang3.TabIndex = 8;
            // 
            // pictureBoxLang3
            // 
            pictureBoxLang3.Location = new Point(33, 18);
            pictureBoxLang3.Name = "pictureBoxLang3";
            pictureBoxLang3.Size = new Size(176, 140);
            pictureBoxLang3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLang3.TabIndex = 1;
            pictureBoxLang3.TabStop = false;
            // 
            // panelLang2
            // 
            panelLang2.BorderStyle = BorderStyle.FixedSingle;
            panelLang2.Controls.Add(labelTop2);
            panelLang2.Controls.Add(labelLang2);
            panelLang2.Controls.Add(pictureBoxLang2);
            panelLang2.Location = new Point(282, 60);
            panelLang2.Name = "panelLang2";
            panelLang2.Size = new Size(236, 382);
            panelLang2.TabIndex = 1;
            // 
            // labelTop2
            // 
            labelTop2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelTop2.Location = new Point(76, 342);
            labelTop2.Name = "labelTop2";
            labelTop2.Size = new Size(84, 38);
            labelTop2.TabIndex = 9;
            labelTop2.Text = "ТОП-2";
            // 
            // labelLang2
            // 
            labelLang2.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang2.Location = new Point(76, 214);
            labelLang2.Name = "labelLang2";
            labelLang2.Size = new Size(130, 29);
            labelLang2.TabIndex = 8;
            // 
            // pictureBoxLang2
            // 
            pictureBoxLang2.Location = new Point(30, 18);
            pictureBoxLang2.Name = "pictureBoxLang2";
            pictureBoxLang2.Size = new Size(176, 140);
            pictureBoxLang2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLang2.TabIndex = 1;
            pictureBoxLang2.TabStop = false;
            // 
            // panelLang1
            // 
            panelLang1.BorderStyle = BorderStyle.FixedSingle;
            panelLang1.Controls.Add(labelTop1);
            panelLang1.Controls.Add(labelLang1);
            panelLang1.Controls.Add(pictureBoxLang1);
            panelLang1.Location = new Point(20, 60);
            panelLang1.Name = "panelLang1";
            panelLang1.Size = new Size(236, 382);
            panelLang1.TabIndex = 0;
            // 
            // labelTop1
            // 
            labelTop1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelTop1.Location = new Point(82, 343);
            labelTop1.Name = "labelTop1";
            labelTop1.Size = new Size(84, 38);
            labelTop1.TabIndex = 7;
            labelTop1.Text = "ТОП-1";
            // 
            // labelLang1
            // 
            labelLang1.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang1.Location = new Point(82, 214);
            labelLang1.Name = "labelLang1";
            labelLang1.Size = new Size(125, 29);
            labelLang1.TabIndex = 7;
            // 
            // pictureBoxLang1
            // 
            pictureBoxLang1.Location = new Point(31, 18);
            pictureBoxLang1.Name = "pictureBoxLang1";
            pictureBoxLang1.Size = new Size(176, 140);
            pictureBoxLang1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLang1.TabIndex = 0;
            pictureBoxLang1.TabStop = false;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMainMenu);
            Controls.Add(labelMainMenu);
            Name = "MainMenuControl";
            Size = new Size(873, 627);
            panelMainMenu.ResumeLayout(false);
            panelLang3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang3).EndInit();
            panelLang2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang2).EndInit();
            panelLang1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMainMenu;
        private Panel panelMainMenu;
        private Panel panelLang1;
        private Panel panelLang3;
        private Panel panelLang2;
        private Label labelLang3;
        private PictureBox pictureBoxLang3;
        private Label labelLang2;
        private PictureBox pictureBoxLang2;
        private Label labelLang1;
        private PictureBox pictureBoxLang1;
        private Label labelTop3;
        private Label labelTop2;
        private Label labelTop1;
    }
}
