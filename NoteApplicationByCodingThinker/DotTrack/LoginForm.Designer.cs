namespace DotTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameValidation = new Label();
            passValidation = new Label();
            passwordLabel = new Label();
            userNameLabel = new Label();
            loginButton = new Button();
            forgotPassLabel = new LinkLabel();
            passwordText = new TextBox();
            userNameText = new TextBox();
            produtctNameLabel = new Label();
            SuspendLayout();
            // 
            // userNameValidation
            // 
            userNameValidation.AutoSize = true;
            userNameValidation.ForeColor = Color.Firebrick;
            userNameValidation.Location = new Point(75, 130);
            userNameValidation.Name = "userNameValidation";
            userNameValidation.Size = new Size(0, 20);
            userNameValidation.TabIndex = 28;
            // 
            // passValidation
            // 
            passValidation.AutoSize = true;
            passValidation.ForeColor = Color.Firebrick;
            passValidation.Location = new Point(75, 226);
            passValidation.Name = "passValidation";
            passValidation.Size = new Size(0, 20);
            passValidation.TabIndex = 27;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.DarkBlue;
            passwordLabel.Location = new Point(27, 167);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = Color.DarkBlue;
            userNameLabel.Location = new Point(27, 71);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(82, 20);
            userNameLabel.TabIndex = 24;
            userNameLabel.Text = "User Name";
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.DarkBlue;
            loginButton.Location = new Point(23, 274);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(218, 36);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // forgotPassLabel
            // 
            forgotPassLabel.ActiveLinkColor = Color.RoyalBlue;
            forgotPassLabel.AutoSize = true;
            forgotPassLabel.ForeColor = SystemColors.ControlText;
            forgotPassLabel.LinkColor = Color.MidnightBlue;
            forgotPassLabel.Location = new Point(132, 341);
            forgotPassLabel.Name = "forgotPassLabel";
            forgotPassLabel.Size = new Size(118, 20);
            forgotPassLabel.TabIndex = 4;
            forgotPassLabel.TabStop = true;
            forgotPassLabel.Text = "Forgot Password";
            forgotPassLabel.VisitedLinkColor = Color.Navy;
            forgotPassLabel.LinkClicked += forgotPassLabel_LinkClicked;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Linen;
            passwordText.ForeColor = SystemColors.ControlText;
            passwordText.Location = new Point(23, 193);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(218, 27);
            passwordText.TabIndex = 2;
            passwordText.UseSystemPasswordChar = true;
            // 
            // userNameText
            // 
            userNameText.BackColor = Color.Linen;
            userNameText.ForeColor = SystemColors.ControlText;
            userNameText.Location = new Point(23, 97);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(218, 27);
            userNameText.TabIndex = 1;
            // 
            // produtctNameLabel
            // 
            produtctNameLabel.AutoSize = true;
            produtctNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            produtctNameLabel.ForeColor = Color.DarkBlue;
            produtctNameLabel.Location = new Point(75, 22);
            produtctNameLabel.Name = "produtctNameLabel";
            produtctNameLabel.Size = new Size(100, 20);
            produtctNameLabel.TabIndex = 30;
            produtctNameLabel.Text = "DotTrack ERP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 385);
            Controls.Add(produtctNameLabel);
            Controls.Add(userNameValidation);
            Controls.Add(passValidation);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(loginButton);
            Controls.Add(forgotPassLabel);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameValidation;
        private Label passValidation;
        private Label passwordLabel;
        private Label userNameLabel;
        private Button loginButton;
        private LinkLabel forgotPassLabel;
        private TextBox passwordText;
        private TextBox userNameText;
        private Label produtctNameLabel;
    }
}