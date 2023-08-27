namespace DotNoteWithUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            againPassText = new TextBox();
            label3 = new Label();
            fullNameText = new TextBox();
            passwordLabel = new Label();
            label1 = new Label();
            saveButton = new Button();
            passwordText = new TextBox();
            userNameText = new TextBox();
            backButton = new Button();
            againPassLabel = new Label();
            fullNameValidation = new Label();
            userNameValidation = new Label();
            againPassValidation = new Label();
            passValidation = new Label();
            SuspendLayout();
            // 
            // againPassText
            // 
            againPassText.BackColor = Color.Linen;
            againPassText.ForeColor = Color.Sienna;
            againPassText.Location = new Point(239, 149);
            againPassText.Margin = new Padding(3, 2, 3, 2);
            againPassText.Name = "againPassText";
            againPassText.Size = new Size(191, 23);
            againPassText.TabIndex = 22;
            againPassText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(239, 62);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 27;
            label3.Text = "Full Name";
            // 
            // fullNameText
            // 
            fullNameText.BackColor = Color.Linen;
            fullNameText.ForeColor = Color.Sienna;
            fullNameText.Location = new Point(235, 81);
            fullNameText.Margin = new Padding(3, 2, 3, 2);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(191, 23);
            fullNameText.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.Sienna;
            passwordLabel.Location = new Point(27, 130);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(27, 62);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 25;
            label1.Text = "User Name";
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.Sienna;
            saveButton.Location = new Point(170, 226);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(95, 27);
            saveButton.TabIndex = 23;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Linen;
            passwordText.ForeColor = Color.Sienna;
            passwordText.Location = new Point(23, 149);
            passwordText.Margin = new Padding(3, 2, 3, 2);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(191, 23);
            passwordText.TabIndex = 21;
            passwordText.UseSystemPasswordChar = true;
            // 
            // userNameText
            // 
            userNameText.BackColor = Color.Linen;
            userNameText.ForeColor = Color.Sienna;
            userNameText.Location = new Point(23, 81);
            userNameText.Margin = new Padding(3, 2, 3, 2);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(191, 23);
            userNameText.TabIndex = 19;
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.Sienna;
            backButton.Location = new Point(3, 10);
            backButton.Name = "backButton";
            backButton.Size = new Size(43, 27);
            backButton.TabIndex = 24;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // againPassLabel
            // 
            againPassLabel.AutoSize = true;
            againPassLabel.ForeColor = Color.Sienna;
            againPassLabel.Location = new Point(239, 130);
            againPassLabel.Name = "againPassLabel";
            againPassLabel.Size = new Size(91, 15);
            againPassLabel.TabIndex = 28;
            againPassLabel.Text = "Password Again";
            // 
            // fullNameValidation
            // 
            fullNameValidation.AutoSize = true;
            fullNameValidation.ForeColor = Color.Firebrick;
            fullNameValidation.Location = new Point(258, 106);
            fullNameValidation.Name = "fullNameValidation";
            fullNameValidation.Size = new Size(0, 15);
            fullNameValidation.TabIndex = 30;
            // 
            // userNameValidation
            // 
            userNameValidation.AutoSize = true;
            userNameValidation.ForeColor = Color.Firebrick;
            userNameValidation.Location = new Point(46, 106);
            userNameValidation.Name = "userNameValidation";
            userNameValidation.Size = new Size(0, 15);
            userNameValidation.TabIndex = 29;
            // 
            // againPassValidation
            // 
            againPassValidation.AutoSize = true;
            againPassValidation.ForeColor = Color.Firebrick;
            againPassValidation.Location = new Point(258, 174);
            againPassValidation.Name = "againPassValidation";
            againPassValidation.Size = new Size(0, 15);
            againPassValidation.TabIndex = 32;
            // 
            // passValidation
            // 
            passValidation.AutoSize = true;
            passValidation.ForeColor = Color.Firebrick;
            passValidation.Location = new Point(46, 174);
            passValidation.Name = "passValidation";
            passValidation.Size = new Size(0, 15);
            passValidation.TabIndex = 31;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 267);
            Controls.Add(againPassValidation);
            Controls.Add(passValidation);
            Controls.Add(fullNameValidation);
            Controls.Add(userNameValidation);
            Controls.Add(againPassLabel);
            Controls.Add(againPassText);
            Controls.Add(label3);
            Controls.Add(fullNameText);
            Controls.Add(passwordLabel);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(backButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            FormClosed += RegisterForm_FormClosed;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox againPassText;
        private Label label3;
        private TextBox fullNameText;
        private Label passwordLabel;
        private Label label1;
        private Button saveButton;
        private TextBox passwordText;
        private TextBox userNameText;
        private Button backButton;
        private Label againPassLabel;
        private Label fullNameValidation;
        private Label userNameValidation;
        private Label againPassValidation;
        private Label passValidation;
    }
}