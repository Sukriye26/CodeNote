namespace NoteApplicationByCodingThinker
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
            titleTextBox = new TextBox();
            noteTextBox = new TextBox();
            editButton = new Button();
            previousNotes = new DataGridView();
            deleteButton = new Button();
            newNoteButton = new Button();
            saveButton = new Button();
            titleLabel = new Label();
            noteLabel = new Label();
            previousNotesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(374, 41);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Please write the title here";
            titleTextBox.Size = new Size(305, 23);
            titleTextBox.TabIndex = 1;
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(374, 91);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.PlaceholderText = "Please write the note here";
            noteTextBox.Size = new Size(305, 223);
            noteTextBox.TabIndex = 2;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LavenderBlush;
            editButton.FlatStyle = FlatStyle.System;
            editButton.Location = new Point(39, 324);
            editButton.Name = "editButton";
            editButton.Size = new Size(122, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = SystemColors.Window;
            previousNotes.BorderStyle = BorderStyle.Fixed3D;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.GridColor = Color.PeachPuff;
            previousNotes.Location = new Point(10, 41);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(331, 273);
            previousNotes.TabIndex = 4;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LavenderBlush;
            deleteButton.FlatStyle = FlatStyle.System;
            deleteButton.Location = new Point(188, 324);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(122, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.LavenderBlush;
            newNoteButton.FlatStyle = FlatStyle.System;
            newNoteButton.Location = new Point(538, 324);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(122, 23);
            newNoteButton.TabIndex = 6;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LavenderBlush;
            saveButton.FlatStyle = FlatStyle.System;
            saveButton.Location = new Point(394, 324);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(122, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(374, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(374, 73);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(36, 15);
            noteLabel.TabIndex = 8;
            noteLabel.Text = "Note:";
            // 
            // previousNotesLabel
            // 
            previousNotesLabel.AutoSize = true;
            previousNotesLabel.Location = new Point(10, 23);
            previousNotesLabel.Name = "previousNotesLabel";
            previousNotesLabel.Size = new Size(89, 15);
            previousNotesLabel.TabIndex = 9;
            previousNotesLabel.Text = "Previous Notes:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 381);
            Controls.Add(previousNotesLabel);
            Controls.Add(noteLabel);
            Controls.Add(titleLabel);
            Controls.Add(newNoteButton);
            Controls.Add(saveButton);
            Controls.Add(previousNotes);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(noteTextBox);
            Controls.Add(titleTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DotNote";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox noteTextBox;
        private Button editButton;
        private DataGridView previousNotes;
        private Button deleteButton;
        private Button newNoteButton;
        private Button saveButton;
        private Label titleLabel;
        private Label noteLabel;
        private Label previousNotesLabel;
    }
}