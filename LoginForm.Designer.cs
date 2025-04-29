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
            textBoxLogName = new TextBox();
            labelLogin = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabelToRegistration);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(textBoxLogPassword);
            panel2.Controls.Add(textBoxLogName);
            panel2.Controls.Add(labelLogin);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 502);
            panel2.TabIndex = 13;
            // 
            // linkLabelToRegistration
            // 
            linkLabelToRegistration.AutoSize = true;
            linkLabelToRegistration.Location = new Point(364, 473);
            linkLabelToRegistration.Name = "linkLabelToRegistration";
            linkLabelToRegistration.Size = new Size(135, 20);
            linkLabelToRegistration.TabIndex = 11;
            linkLabelToRegistration.TabStop = true;
            linkLabelToRegistration.Text = "Еще нет аккаунта?";
            linkLabelToRegistration.LinkClicked += linkLabelToRegistration_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 13F);
            buttonLogin.Location = new Point(123, 306);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(254, 60);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLogPassword
            // 
            textBoxLogPassword.Font = new Font("Segoe UI", 16F);
            textBoxLogPassword.Location = new Point(33, 204);
            textBoxLogPassword.Name = "textBoxLogPassword";
            textBoxLogPassword.Size = new Size(448, 43);
            textBoxLogPassword.TabIndex = 7;
            textBoxLogPassword.Enter += textBoxLogPassword_Enter;
            textBoxLogPassword.Leave += textBoxLogPassword_Leave;
            // 
            // textBoxLogName
            // 
            textBoxLogName.Font = new Font("Segoe UI", 16F);
            textBoxLogName.Location = new Point(33, 144);
            textBoxLogName.Name = "textBoxLogName";
            textBoxLogName.Size = new Size(448, 43);
            textBoxLogName.TabIndex = 6;
            textBoxLogName.Enter += textBoxLogName_Enter;
            textBoxLogName.Leave += textBoxLogName_Leave;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 13F);
            labelLogin.Location = new Point(217, 66);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(71, 30);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "ВХОД";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 502);
            Controls.Add(panel2);
            Name = "LoginForm";
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private LinkLabel linkLabelToRegistration;
        private Button buttonLogin;
        private TextBox textBoxLogPassword;
        private TextBox textBoxLogName;
        private Label labelLogin;
    }
}