namespace RSFRecomendations.UserControles
{
    partial class MainMenuFirstLogControl
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
            pictureBox1 = new PictureBox();
            buttonMainControlGoAnketa = new Button();
            labelMainMenuFirstLog = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainMenuFirst;
            pictureBox1.Location = new Point(40, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(794, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonMainControlGoAnketa
            // 
            buttonMainControlGoAnketa.BackColor = Color.FromArgb(125, 115, 235);
            buttonMainControlGoAnketa.FlatAppearance.BorderSize = 0;
            buttonMainControlGoAnketa.FlatStyle = FlatStyle.Flat;
            buttonMainControlGoAnketa.Font = new Font("Segoe UI", 9F);
            buttonMainControlGoAnketa.ForeColor = Color.White;
            buttonMainControlGoAnketa.Location = new Point(344, 451);
            buttonMainControlGoAnketa.Name = "buttonMainControlGoAnketa";
            buttonMainControlGoAnketa.Size = new Size(198, 36);
            buttonMainControlGoAnketa.TabIndex = 1;
            buttonMainControlGoAnketa.Text = "Заполнить акнкету";
            buttonMainControlGoAnketa.UseVisualStyleBackColor = false;
            buttonMainControlGoAnketa.Click += buttonMainControlGoAnketa_Click;
            buttonMainControlGoAnketa.Paint += buttonMainControlGoAnketa_Paint;
            // 
            // labelMainMenuFirstLog
            // 
            labelMainMenuFirstLog.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelMainMenuFirstLog.Location = new Point(40, 10);
            labelMainMenuFirstLog.Name = "labelMainMenuFirstLog";
            labelMainMenuFirstLog.Size = new Size(234, 38);
            labelMainMenuFirstLog.TabIndex = 2;
            labelMainMenuFirstLog.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // MainMenuFirstLogControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMainMenuFirstLog);
            Controls.Add(buttonMainControlGoAnketa);
            Controls.Add(pictureBox1);
            Name = "MainMenuFirstLogControl";
            Size = new Size(873, 627);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMainGoAnketa;
        private Button buttonMainControlGoAnketa;
        private Label labelMainMenuFirstLog;
    }
}
