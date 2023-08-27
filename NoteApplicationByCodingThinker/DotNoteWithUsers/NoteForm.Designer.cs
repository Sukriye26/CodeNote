namespace DotNoteWithUsers
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            logOutLabel = new LinkLabel();
            previousNotesLabel = new Label();
            noteLabel = new Label();
            titleLabel = new Label();
            noteTextBox = new TextBox();
            titleTextBox = new TextBox();
            saveButton = new Button();
            newNoteButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            loggedUser = new Label();
            previousNotesListBox = new ListBox();
            SuspendLayout();
            // 
            // logOutLabel
            // 
            logOutLabel.ActiveLinkColor = Color.Peru;
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logOutLabel.ForeColor = Color.Sienna;
            logOutLabel.LinkColor = Color.Sienna;
            logOutLabel.Location = new Point(321, 371);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(65, 20);
            logOutLabel.TabIndex = 8;
            logOutLabel.TabStop = true;
            logOutLabel.Text = "Log Out";
            logOutLabel.LinkClicked += logOutLabel_LinkClicked;
            // 
            // previousNotesLabel
            // 
            previousNotesLabel.AutoSize = true;
            previousNotesLabel.ForeColor = Color.Sienna;
            previousNotesLabel.Location = new Point(12, 37);
            previousNotesLabel.Name = "previousNotesLabel";
            previousNotesLabel.Size = new Size(89, 15);
            previousNotesLabel.TabIndex = 19;
            previousNotesLabel.Text = "Previous Notes:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.ForeColor = Color.Sienna;
            noteLabel.Location = new Point(376, 87);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(36, 15);
            noteLabel.TabIndex = 18;
            noteLabel.Text = "Note:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = Color.Sienna;
            titleLabel.Location = new Point(376, 37);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Title:";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(376, 105);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.PlaceholderText = "Please write the note here";
            noteTextBox.Size = new Size(305, 223);
            noteTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(376, 55);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Please write the title here";
            titleTextBox.Size = new Size(305, 23);
            titleTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.Sienna;
            saveButton.Location = new Point(408, 334);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(95, 27);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.FlatStyle = FlatStyle.Flat;
            newNoteButton.ForeColor = Color.Sienna;
            newNoteButton.Location = new Point(554, 334);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(95, 27);
            newNoteButton.TabIndex = 4;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.Sienna;
            deleteButton.Location = new Point(205, 336);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(95, 27);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.Sienna;
            editButton.Location = new Point(55, 338);
            editButton.Name = "editButton";
            editButton.Size = new Size(95, 27);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // loggedUser
            // 
            loggedUser.AutoSize = true;
            loggedUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            loggedUser.ForeColor = Color.Sienna;
            loggedUser.Location = new Point(12, 9);
            loggedUser.Name = "loggedUser";
            loggedUser.Size = new Size(103, 20);
            loggedUser.TabIndex = 20;
            loggedUser.Text = "Administrator";
            // 
            // previousNotesListBox
            // 
            previousNotesListBox.FormattingEnabled = true;
            previousNotesListBox.ItemHeight = 15;
            previousNotesListBox.Location = new Point(12, 54);
            previousNotesListBox.Name = "previousNotesListBox";
            previousNotesListBox.Size = new Size(331, 274);
            previousNotesListBox.TabIndex = 21;
            previousNotesListBox.SelectedIndexChanged += previousNotesListBox_SelectedIndexChanged;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 397);
            Controls.Add(previousNotesListBox);
            Controls.Add(loggedUser);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(previousNotesLabel);
            Controls.Add(noteLabel);
            Controls.Add(titleLabel);
            Controls.Add(noteTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(logOutLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DotNote";
            FormClosed += NoteForm_FormClosed;
            Load += NoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel logOutLabel;
        private Label previousNotesLabel;
        private Label noteLabel;
        private Label titleLabel;
        private TextBox noteTextBox;
        private TextBox titleTextBox;
        private Button saveButton;
        private Button newNoteButton;
        private Button deleteButton;
        private Button editButton;
        private Label loggedUser;
        private ListBox previousNotesListBox;
    }
}