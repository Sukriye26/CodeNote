namespace WinFormNotePad
{
    partial class Form1
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
            usernameTxt = new TextBox();
            password = new TextBox();
            login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(31, 49);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.PlaceholderText = "username";
            usernameTxt.Size = new Size(125, 27);
            usernameTxt.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(33, 89);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // login
            // 
            login.Location = new Point(228, 142);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 3;
            login.Text = "Giriş";
            login.UseVisualStyleBackColor = true;
            login.Visible = false;
            login.Click += login_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 142);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 248);
            Controls.Add(button1);
            Controls.Add(login);
            Controls.Add(password);
            Controls.Add(usernameTxt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox password;
        private Button login;
        private Button button1;
    }
}