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
            panelLang1 = new Panel();
            panelLang2 = new Panel();
            panelLang3 = new Panel();
            pictureBoxLang1 = new PictureBox();
            pictureBoxLang2 = new PictureBox();
            pictureBoxLang3 = new PictureBox();
            labelLang1 = new Label();
            labelLang2 = new Label();
            labelLang3 = new Label();
            pictureBoxLikeLang1 = new PictureBox();
            pictureBoxLikeLang2 = new PictureBox();
            pictureBoxDislikeLang2 = new PictureBox();
            pictureBoxDislikeLang1 = new PictureBox();
            pictureBoxLikeLang3 = new PictureBox();
            pictureBoxDislikeLang3 = new PictureBox();
            panelMainMenu.SuspendLayout();
            panelLang1.SuspendLayout();
            panelLang2.SuspendLayout();
            panelLang3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang3).BeginInit();
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
            // panelLang1
            // 
            panelLang1.Controls.Add(pictureBoxDislikeLang1);
            panelLang1.Controls.Add(pictureBoxLikeLang1);
            panelLang1.Controls.Add(labelLang1);
            panelLang1.Controls.Add(pictureBoxLang1);
            panelLang1.Location = new Point(20, 60);
            panelLang1.Name = "panelLang1";
            panelLang1.Size = new Size(236, 382);
            panelLang1.TabIndex = 0;
            panelLang1.BorderStyle = BorderStyle.FixedSingle;
            // 
            // panelLang2
            // 
            panelLang2.Controls.Add(pictureBoxDislikeLang2);
            panelLang2.Controls.Add(pictureBoxLikeLang2);
            panelLang2.Controls.Add(labelLang2);
            panelLang2.Controls.Add(pictureBoxLang2);
            panelLang2.Location = new Point(282, 60);
            panelLang2.Name = "panelLang2";
            panelLang2.Size = new Size(236, 382);
            panelLang2.TabIndex = 1;
            panelLang2.BorderStyle = BorderStyle.FixedSingle;
            // 
            // panelLang3
            // 
            panelLang3.Controls.Add(pictureBoxDislikeLang3);
            panelLang3.Controls.Add(pictureBoxLikeLang3);
            panelLang3.Controls.Add(labelLang3);
            panelLang3.Controls.Add(pictureBoxLang3);
            panelLang3.Location = new Point(545, 60);
            panelLang3.Name = "panelLang3";
            panelLang3.Size = new Size(236, 382);
            panelLang3.TabIndex = 2;
            panelLang3.BorderStyle = BorderStyle.FixedSingle;
            // 
            // pictureBoxLang1
            // 
            pictureBoxLang1.Location = new Point(31, 18);
            pictureBoxLang1.Name = "pictureBoxLang1";
            pictureBoxLang1.Size = new Size(176, 140);
            pictureBoxLang1.TabIndex = 0;
            pictureBoxLang1.TabStop = false;
            // 
            // pictureBoxLang2
            // 
            pictureBoxLang2.Location = new Point(30, 18);
            pictureBoxLang2.Name = "pictureBoxLang2";
            pictureBoxLang2.Size = new Size(176, 140);
            pictureBoxLang2.TabIndex = 1;
            pictureBoxLang2.TabStop = false;
            // 
            // pictureBoxLang3
            // 
            pictureBoxLang3.Location = new Point(33, 18);
            pictureBoxLang3.Name = "pictureBoxLang3";
            pictureBoxLang3.Size = new Size(176, 140);
            pictureBoxLang3.TabIndex = 1;
            pictureBoxLang3.TabStop = false;
            // 
            // labelLang1
            // 
            labelLang1.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang1.Location = new Point(31, 214);
            labelLang1.Name = "labelLang1";
            labelLang1.Size = new Size(176, 58);
            labelLang1.TabIndex = 7;
            labelLang1.Text = "ОПИСАНИЕ ЯЗЫКА";
            // 
            // labelLang2
            // 
            labelLang2.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang2.Location = new Point(30, 214);
            labelLang2.Name = "labelLang2";
            labelLang2.Size = new Size(176, 58);
            labelLang2.TabIndex = 8;
            labelLang2.Text = "ОПИСАНИЕ ЯЗЫКА";
            // 
            // labelLang3
            // 
            labelLang3.Font = new Font("Microsoft Sans Serif", 13F);
            labelLang3.Location = new Point(33, 214);
            labelLang3.Name = "labelLang3";
            labelLang3.Size = new Size(176, 58);
            labelLang3.TabIndex = 8;
            labelLang3.Text = "ОПИСАНИЕ ЯЗЫКА";
            // 
            // pictureBoxLikeLang1
            // 
            pictureBoxLikeLang1.Image = Properties.Resources.Like;
            pictureBoxLikeLang1.Location = new Point(3, 342);
            pictureBoxLikeLang1.Name = "pictureBoxLikeLang1";
            pictureBoxLikeLang1.Size = new Size(39, 37);
            pictureBoxLikeLang1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLikeLang1.TabIndex = 9;
            pictureBoxLikeLang1.TabStop = false;
            // 
            // pictureBoxLikeLang2
            // 
            pictureBoxLikeLang2.Image = Properties.Resources.Like;
            pictureBoxLikeLang2.Location = new Point(3, 342);
            pictureBoxLikeLang2.Name = "pictureBoxLikeLang2";
            pictureBoxLikeLang2.Size = new Size(39, 37);
            pictureBoxLikeLang2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLikeLang2.TabIndex = 10;
            pictureBoxLikeLang2.TabStop = false;
            // 
            // pictureBoxDislikeLang2
            // 
            pictureBoxDislikeLang2.Image = Properties.Resources.Dislike;
            pictureBoxDislikeLang2.Location = new Point(194, 342);
            pictureBoxDislikeLang2.Name = "pictureBoxDislikeLang2";
            pictureBoxDislikeLang2.Size = new Size(39, 37);
            pictureBoxDislikeLang2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDislikeLang2.TabIndex = 11;
            pictureBoxDislikeLang2.TabStop = false;
            // 
            // pictureBoxDislikeLang1
            // 
            pictureBoxDislikeLang1.Image = Properties.Resources.Dislike;
            pictureBoxDislikeLang1.Location = new Point(194, 342);
            pictureBoxDislikeLang1.Name = "pictureBoxDislikeLang1";
            pictureBoxDislikeLang1.Size = new Size(39, 37);
            pictureBoxDislikeLang1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDislikeLang1.TabIndex = 10;
            pictureBoxDislikeLang1.TabStop = false;
            // 
            // pictureBoxLikeLang3
            // 
            pictureBoxLikeLang3.Image = Properties.Resources.Like;
            pictureBoxLikeLang3.Location = new Point(3, 342);
            pictureBoxLikeLang3.Name = "pictureBoxLikeLang3";
            pictureBoxLikeLang3.Size = new Size(39, 37);
            pictureBoxLikeLang3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLikeLang3.TabIndex = 10;
            pictureBoxLikeLang3.TabStop = false;
            // 
            // pictureBoxDislikeLang3
            // 
            pictureBoxDislikeLang3.Image = Properties.Resources.Dislike;
            pictureBoxDislikeLang3.Location = new Point(194, 342);
            pictureBoxDislikeLang3.Name = "pictureBoxDislikeLang3";
            pictureBoxDislikeLang3.Size = new Size(39, 37);
            pictureBoxDislikeLang3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDislikeLang3.TabIndex = 11;
            pictureBoxDislikeLang3.TabStop = false;
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
            panelLang1.ResumeLayout(false);
            panelLang2.ResumeLayout(false);
            panelLang3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLang3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLikeLang3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDislikeLang3).EndInit();
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
        private PictureBox pictureBoxDislikeLang3;
        private PictureBox pictureBoxLikeLang3;
        private PictureBox pictureBoxDislikeLang2;
        private PictureBox pictureBoxLikeLang2;
        private PictureBox pictureBoxDislikeLang1;
        private PictureBox pictureBoxLikeLang1;
    }
}
