namespace RSFRecomendations
{
    partial class LoginForm
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
            panel2 = new Panel();
            linkLabelToRegistration = new LinkLabel();
            buttonLogin = new Button();
            textBoxLogPassword = new TextBox();
            textBoxLogLogin = new TextBox();
            labelLogin = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabelToRegistration);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(textBoxLogPassword);
            panel2.Controls.Add(textBoxLogLogin);
            panel2.Controls.Add(labelLogin);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(503, 502);
            panel2.TabIndex = 13;
            panel2.BackColor = Color.White;
            // 
            // linkLabelToRegistration
            // 
            linkLabelToRegistration.AutoSize = true;
            linkLabelToRegistration.Location = new Point(169, 351);
            linkLabelToRegistration.Name = "linkLabelToRegistration";
            linkLabelToRegistration.Size = new Size(143, 20);
            linkLabelToRegistration.TabIndex = 11;
            linkLabelToRegistration.TabStop = true;
            linkLabelToRegistration.Text = "У вас нет аккаунта?";
            linkLabelToRegistration.LinkClicked += linkLabelToRegistration_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(125, 115, 235);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(119, 279);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(250, 60);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.Paint += buttonLogin_Paint;
            // 
            // textBoxLogPassword
            // 
            textBoxLogPassword.Font = new Font("Segoe UI", 16F);
            textBoxLogPassword.Location = new Point(73, 217);
            textBoxLogPassword.Name = "textBoxLogPassword";
            textBoxLogPassword.Size = new Size(342, 43);
            textBoxLogPassword.TabIndex = 7;
            textBoxLogPassword.Enter += textBoxLogPassword_Enter;
            textBoxLogPassword.Leave += textBoxLogPassword_Leave;
            textBoxLogPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogPassword.BackColor = SystemColors.Window; 
            // 
            // textBoxLogLogin
            // 
            textBoxLogLogin.Font = new Font("Segoe UI", 16F);
            textBoxLogLogin.Location = new Point(73, 157);
            textBoxLogLogin.Name = "textBoxLogLogin";
            textBoxLogLogin.Size = new Size(342, 43);
            textBoxLogLogin.TabIndex = 6;
            textBoxLogLogin.Enter += textBoxLogLogin_Enter;
            textBoxLogLogin.Leave += textBoxLogLogin_Leave;
            textBoxLogLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogLogin.BackColor = SystemColors.Window; 
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelLogin.Location = new Point(210, 86);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(75, 30);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "ВХОД";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 502);
            Controls.Add(panel2);
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Вход";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private LinkLabel linkLabelToRegistration;
        private Button buttonLogin;
        private TextBox textBoxLogPassword;
        private TextBox textBoxLogLogin;
        private Label labelLogin;
    }
}