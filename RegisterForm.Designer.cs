using System.Security.Policy;

namespace RSFRecomendations
{
    partial class RegisterForm
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
            panelRegistration = new Panel();
            labelVisitPassword2 = new Label();
            labelVisitPassword = new Label();
            labelHidePassword2 = new Label();
            labelHidePassword = new Label();
            linkLabelToLogin = new LinkLabel();
            buttonRegister = new Button();
            textBoxRegPassword2 = new TextBox();
            textBoxRegEmail = new TextBox();
            textBoxRegPassword = new TextBox();
            textBoxRegLogin = new TextBox();
            label1 = new Label();
            panelRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistration
            // 
            panelRegistration.BackColor = Color.White;
            panelRegistration.Controls.Add(labelVisitPassword2);
            panelRegistration.Controls.Add(labelVisitPassword);
            panelRegistration.Controls.Add(labelHidePassword2);
            panelRegistration.Controls.Add(labelHidePassword);
            panelRegistration.Controls.Add(linkLabelToLogin);
            panelRegistration.Controls.Add(buttonRegister);
            panelRegistration.Controls.Add(textBoxRegPassword2);
            panelRegistration.Controls.Add(textBoxRegEmail);
            panelRegistration.Controls.Add(textBoxRegPassword);
            panelRegistration.Controls.Add(textBoxRegLogin);
            panelRegistration.Controls.Add(label1);
            panelRegistration.Location = new Point(3, 2);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(515, 502);
            panelRegistration.TabIndex = 1;
            // 
            // labelVisitPassword2
            // 
            labelVisitPassword2.BackColor = Color.White;
            labelVisitPassword2.Font = new Font("Segoe UI", 17F);
            labelVisitPassword2.Location = new Point(405, 287);
            labelVisitPassword2.Name = "labelVisitPassword2";
            labelVisitPassword2.Size = new Size(48, 37);
            labelVisitPassword2.TabIndex = 16;
            labelVisitPassword2.Text = "🔒";
            labelVisitPassword2.Click += labelVisitPassword2_Click;
            // 
            // labelVisitPassword
            // 
            labelVisitPassword.BackColor = Color.White;
            labelVisitPassword.Font = new Font("Segoe UI", 17F);
            labelVisitPassword.Location = new Point(405, 224);
            labelVisitPassword.Name = "labelVisitPassword";
            labelVisitPassword.Size = new Size(48, 37);
            labelVisitPassword.TabIndex = 15;
            labelVisitPassword.Text = "🔒";
            labelVisitPassword.Click += labelVisitPassword_Click;
            // 
            // labelHidePassword2
            // 
            labelHidePassword2.BackColor = Color.White;
            labelHidePassword2.Font = new Font("Segoe UI", 17F);
            labelHidePassword2.Location = new Point(405, 287);
            labelHidePassword2.Name = "labelHidePassword2";
            labelHidePassword2.Size = new Size(48, 37);
            labelHidePassword2.TabIndex = 14;
            labelHidePassword2.Text = "👁";
            labelHidePassword2.Click += labelHidePassword2_Click;
            // 
            // labelHidePassword
            // 
            labelHidePassword.BackColor = Color.White;
            labelHidePassword.Font = new Font("Segoe UI", 17F);
            labelHidePassword.Location = new Point(405, 224);
            labelHidePassword.Name = "labelHidePassword";
            labelHidePassword.Size = new Size(48, 37);
            labelHidePassword.TabIndex = 13;
            labelHidePassword.Text = "👁";
            labelHidePassword.Click += labelHidePassword_Click;
            // 
            // linkLabelToLogin
            // 
            linkLabelToLogin.AutoSize = true;
            linkLabelToLogin.Location = new Point(194, 410);
            linkLabelToLogin.Name = "linkLabelToLogin";
            linkLabelToLogin.Size = new Size(133, 20);
            linkLabelToLogin.TabIndex = 11;
            linkLabelToLogin.TabStop = true;
            linkLabelToLogin.Text = "Уже есть аккаунт?";
            linkLabelToLogin.LinkClicked += linkLabelToLogin_LinkClicked;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(125, 115, 235);
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(132, 347);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 60);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            buttonRegister.Paint += buttonRegister_Paint;
            // 
            // textBoxRegPassword2
            // 
            textBoxRegPassword2.BackColor = SystemColors.Window;
            textBoxRegPassword2.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegPassword2.Font = new Font("Segoe UI", 16F);
            textBoxRegPassword2.Location = new Point(65, 285);
            textBoxRegPassword2.Name = "textBoxRegPassword2";
            textBoxRegPassword2.Size = new Size(390, 43);
            textBoxRegPassword2.TabIndex = 9;
            textBoxRegPassword2.Enter += textBoxRegPassword2_Enter;
            textBoxRegPassword2.Leave += textBoxRegPassword2_Leave;
            // 
            // textBoxRegEmail
            // 
            textBoxRegEmail.BackColor = SystemColors.Window;
            textBoxRegEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegEmail.Font = new Font("Segoe UI", 16F);
            textBoxRegEmail.Location = new Point(65, 165);
            textBoxRegEmail.Name = "textBoxRegEmail";
            textBoxRegEmail.Size = new Size(390, 43);
            textBoxRegEmail.TabIndex = 8;
            textBoxRegEmail.Enter += textBoxRegEmail_Enter;
            textBoxRegEmail.Leave += textBoxRegEmail_Leave;
            // 
            // textBoxRegPassword
            // 
            textBoxRegPassword.BackColor = SystemColors.Window;
            textBoxRegPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegPassword.Font = new Font("Segoe UI", 16F);
            textBoxRegPassword.Location = new Point(65, 223);
            textBoxRegPassword.Name = "textBoxRegPassword";
            textBoxRegPassword.Size = new Size(390, 43);
            textBoxRegPassword.TabIndex = 7;
            textBoxRegPassword.Enter += textBoxRegPassword_Enter;
            textBoxRegPassword.Leave += textBoxRegPassword_Leave;
            // 
            // textBoxRegLogin
            // 
            textBoxRegLogin.BackColor = SystemColors.Window;
            textBoxRegLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegLogin.Font = new Font("Segoe UI", 16F);
            textBoxRegLogin.Location = new Point(65, 104);
            textBoxRegLogin.Name = "textBoxRegLogin";
            textBoxRegLogin.Size = new Size(390, 43);
            textBoxRegLogin.TabIndex = 6;
            textBoxRegLogin.Enter += textBoxRegName_Enter;
            textBoxRegLogin.Leave += textBoxRegName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label1.Location = new Point(159, 53);
            label1.Name = "label1";
            label1.Size = new Size(187, 26);
            label1.TabIndex = 0;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 505);
            Controls.Add(panelRegistration);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            panelRegistration.ResumeLayout(false);
            panelRegistration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistration;
        private LinkLabel linkLabelToLogin;
        private Button buttonRegister;
        private TextBox textBoxRegPassword2;
        private TextBox textBoxRegEmail;
        private TextBox textBoxRegPassword;
        private TextBox textBoxRegLogin;
        private Label label1;
        private Label labelHidePassword;
        private Label labelHidePassword2;
        private Label labelVisitPassword;
        private Label labelVisitPassword2;
    }
}