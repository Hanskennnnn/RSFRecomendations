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
            linkLabelToLogin = new LinkLabel();
            buttonRegister = new Button();
            textBoxRegPassword2 = new TextBox();
            textBoxRegEmail = new TextBox();
            textBoxRegPassword = new TextBox();
            textBoxRegName = new TextBox();
            label1 = new Label();
            panelRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistration
            // 
            panelRegistration.Controls.Add(linkLabelToLogin);
            panelRegistration.Controls.Add(buttonRegister);
            panelRegistration.Controls.Add(textBoxRegPassword2);
            panelRegistration.Controls.Add(textBoxRegEmail);
            panelRegistration.Controls.Add(textBoxRegPassword);
            panelRegistration.Controls.Add(textBoxRegName);
            panelRegistration.Controls.Add(label1);
            panelRegistration.Location = new Point(3, 2);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(515, 502);
            panelRegistration.TabIndex = 1;
            // 
            // linkLabelToLogin
            // 
            linkLabelToLogin.AutoSize = true;
            linkLabelToLogin.Location = new Point(366, 474);
            linkLabelToLogin.Name = "linkLabelToLogin";
            linkLabelToLogin.Size = new Size(133, 20);
            linkLabelToLogin.TabIndex = 11;
            linkLabelToLogin.TabStop = true;
            linkLabelToLogin.Text = "Уже есть аккаунт?";
            linkLabelToLogin.LinkClicked += linkLabelToLogin_LinkClicked;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Segoe UI", 13F);
            buttonRegister.Location = new Point(125, 372);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(254, 60);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxRegPassword2
            // 
            textBoxRegPassword2.Font = new Font("Segoe UI", 16F);
            textBoxRegPassword2.Location = new Point(26, 285);
            textBoxRegPassword2.Name = "textBoxRegPassword2";
            textBoxRegPassword2.Size = new Size(458, 43);
            textBoxRegPassword2.TabIndex = 9;
            textBoxRegPassword2.Enter += textBoxRegPassword2_Enter;
            textBoxRegPassword2.Leave += textBoxRegPassword2_Leave;
            // 
            // textBoxRegEmail
            // 
            textBoxRegEmail.Font = new Font("Segoe UI", 16F);
            textBoxRegEmail.Location = new Point(26, 165);
            textBoxRegEmail.Name = "textBoxRegEmail";
            textBoxRegEmail.Size = new Size(458, 43);
            textBoxRegEmail.TabIndex = 8;
            textBoxRegEmail.Enter += textBoxRegEmail_Enter;
            textBoxRegEmail.Leave += textBoxRegEmail_Leave;
            // 
            // textBoxRegPassword
            // 
            textBoxRegPassword.Font = new Font("Segoe UI", 16F);
            textBoxRegPassword.Location = new Point(26, 223);
            textBoxRegPassword.Name = "textBoxRegPassword";
            textBoxRegPassword.Size = new Size(458, 43);
            textBoxRegPassword.TabIndex = 7;
            textBoxRegPassword.Enter += textBoxRegPassword_Enter;
            textBoxRegPassword.Leave += textBoxRegPassword_Leave;
            // 
            // textBoxRegName
            // 
            textBoxRegName.Font = new Font("Segoe UI", 16F);
            textBoxRegName.Location = new Point(26, 104);
            textBoxRegName.Name = "textBoxRegName";
            textBoxRegName.Size = new Size(458, 43);
            textBoxRegName.TabIndex = 6;
            textBoxRegName.Enter += textBoxRegName_Enter;
            textBoxRegName.Leave += textBoxRegName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(171, 45);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 0;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 505);
            Controls.Add(panelRegistration);
            Name = "RegisterForm";
            Text = "RegisterForm";
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
        private TextBox textBoxRegName;
        private Label label1;
    }
}