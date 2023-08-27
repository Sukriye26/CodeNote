namespace DotNoteWithUsers
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameText = new TextBox();
            passwordText = new TextBox();
            forgotPassLabel = new LinkLabel();
            loginButton = new Button();
            userNameLabel = new Label();
            passwordLabel = new Label();
            passValidation = new Label();
            userNameValidation = new Label();
            registerLabel = new LinkLabel();
            SuspendLayout();
            // 
            // userNameText
            // 
            userNameText.BackColor = Color.Linen;
            userNameText.ForeColor = Color.Sienna;
            userNameText.Location = new Point(29, 57);
            userNameText.Margin = new Padding(3, 2, 3, 2);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(191, 23);
            userNameText.TabIndex = 1;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Linen;
            passwordText.ForeColor = Color.Sienna;
            passwordText.Location = new Point(29, 129);
            passwordText.Margin = new Padding(3, 2, 3, 2);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(191, 23);
            passwordText.TabIndex = 2;
            passwordText.UseSystemPasswordChar = true;
            // 
            // forgotPassLabel
            // 
            forgotPassLabel.ActiveLinkColor = Color.Peru;
            forgotPassLabel.AutoSize = true;
            forgotPassLabel.ForeColor = Color.Sienna;
            forgotPassLabel.LinkColor = Color.Sienna;
            forgotPassLabel.Location = new Point(125, 240);
            forgotPassLabel.Name = "forgotPassLabel";
            forgotPassLabel.Size = new Size(95, 15);
            forgotPassLabel.TabIndex = 4;
            forgotPassLabel.TabStop = true;
            forgotPassLabel.Text = "Forgot Password";
            forgotPassLabel.LinkClicked += forgotPassLabel_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.Sienna;
            loginButton.Location = new Point(29, 190);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(191, 27);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            loginButton.MouseHover += button1_MouseHover;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.ForeColor = Color.Sienna;
            userNameLabel.Location = new Point(33, 38);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(65, 15);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Sienna;
            passwordLabel.Location = new Point(33, 110);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // passValidation
            // 
            passValidation.AutoSize = true;
            passValidation.ForeColor = Color.Firebrick;
            passValidation.Location = new Point(75, 154);
            passValidation.Name = "passValidation";
            passValidation.Size = new Size(0, 15);
            passValidation.TabIndex = 18;
            // 
            // userNameValidation
            // 
            userNameValidation.AutoSize = true;
            userNameValidation.ForeColor = Color.Firebrick;
            userNameValidation.Location = new Point(75, 82);
            userNameValidation.Name = "userNameValidation";
            userNameValidation.Size = new Size(0, 15);
            userNameValidation.TabIndex = 19;
            // 
            // registerLabel
            // 
            registerLabel.ActiveLinkColor = Color.Peru;
            registerLabel.AutoSize = true;
            registerLabel.ForeColor = Color.Sienna;
            registerLabel.LinkColor = Color.Sienna;
            registerLabel.Location = new Point(29, 240);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(49, 15);
            registerLabel.TabIndex = 20;
            registerLabel.TabStop = true;
            registerLabel.Text = "Register";
            registerLabel.LinkClicked += registerLabel_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(265, 265);
            Controls.Add(registerLabel);
            Controls.Add(userNameValidation);
            Controls.Add(passValidation);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(loginButton);
            Controls.Add(forgotPassLabel);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameText;
        private TextBox passwordText;
        private LinkLabel forgotPassLabel;
        private Button loginButton;
        private Label userNameLabel;
        private Label passwordLabel;
        private Label passValidation;
        private Label userNameValidation;
        private LinkLabel registerLabel;
    }
}