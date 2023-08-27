namespace DotNoteWithUsers
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            backButton = new Button();
            label2 = new Label();
            label1 = new Label();
            saveButton = new Button();
            passwordText = new TextBox();
            userNameText = new TextBox();
            label3 = new Label();
            fullNameText = new TextBox();
            label4 = new Label();
            againPassText = new TextBox();
            userNameValidation = new Label();
            fullNameValidation = new Label();
            passValidation = new Label();
            againPassValidation = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.Sienna;
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(43, 27);
            backButton.TabIndex = 6;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click_1;
            backButton.MouseHover += backButton_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(36, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 9;
            label1.Text = "User Name";
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.Sienna;
            saveButton.Location = new Point(179, 228);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(95, 27);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // passwordText
            // 
            passwordText.BackColor = Color.Linen;
            passwordText.ForeColor = Color.Sienna;
            passwordText.Location = new Point(32, 151);
            passwordText.Margin = new Padding(3, 2, 3, 2);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(191, 23);
            passwordText.TabIndex = 3;
            passwordText.UseSystemPasswordChar = true;
            // 
            // userNameText
            // 
            userNameText.BackColor = Color.Linen;
            userNameText.ForeColor = Color.Sienna;
            userNameText.Location = new Point(32, 83);
            userNameText.Margin = new Padding(3, 2, 3, 2);
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(191, 23);
            userNameText.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(248, 64);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 12;
            label3.Text = "Full Name";
            // 
            // fullNameText
            // 
            fullNameText.BackColor = Color.Linen;
            fullNameText.ForeColor = Color.Sienna;
            fullNameText.Location = new Point(244, 83);
            fullNameText.Margin = new Padding(3, 2, 3, 2);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(191, 23);
            fullNameText.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Sienna;
            label4.Location = new Point(252, 132);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 14;
            label4.Text = "Password Again ";
            // 
            // againPassText
            // 
            againPassText.BackColor = Color.Linen;
            againPassText.ForeColor = Color.Sienna;
            againPassText.Location = new Point(248, 151);
            againPassText.Margin = new Padding(3, 2, 3, 2);
            againPassText.Name = "againPassText";
            againPassText.Size = new Size(191, 23);
            againPassText.TabIndex = 4;
            againPassText.UseSystemPasswordChar = true;
            // 
            // userNameValidation
            // 
            userNameValidation.AutoSize = true;
            userNameValidation.ForeColor = Color.Firebrick;
            userNameValidation.Location = new Point(69, 108);
            userNameValidation.Name = "userNameValidation";
            userNameValidation.Size = new Size(0, 15);
            userNameValidation.TabIndex = 15;
            // 
            // fullNameValidation
            // 
            fullNameValidation.AutoSize = true;
            fullNameValidation.ForeColor = Color.Firebrick;
            fullNameValidation.Location = new Point(281, 108);
            fullNameValidation.Name = "fullNameValidation";
            fullNameValidation.Size = new Size(0, 15);
            fullNameValidation.TabIndex = 16;
            // 
            // passValidation
            // 
            passValidation.AutoSize = true;
            passValidation.ForeColor = Color.Firebrick;
            passValidation.Location = new Point(75, 176);
            passValidation.Name = "passValidation";
            passValidation.Size = new Size(0, 15);
            passValidation.TabIndex = 17;
            // 
            // againPassValidation
            // 
            againPassValidation.AutoSize = true;
            againPassValidation.ForeColor = Color.Firebrick;
            againPassValidation.Location = new Point(259, 176);
            againPassValidation.Name = "againPassValidation";
            againPassValidation.Size = new Size(0, 15);
            againPassValidation.TabIndex = 18;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 267);
            Controls.Add(againPassValidation);
            Controls.Add(passValidation);
            Controls.Add(fullNameValidation);
            Controls.Add(userNameValidation);
            Controls.Add(label4);
            Controls.Add(againPassText);
            Controls.Add(label3);
            Controls.Add(fullNameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(backButton);
            ForeColor = Color.Firebrick;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            FormClosed += ForgotPasswordForm_FormClosed;
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label label2;
        private Label label1;
        private Button saveButton;
        private TextBox passwordText;
        private TextBox userNameText;
        private Label label3;
        private TextBox fullNameText;
        private Label label4;
        private TextBox againPassText;
        private Label userNameValidation;
        private Label fullNameValidation;
        private Label passValidation;
        private Label againPassValidation;
    }
}