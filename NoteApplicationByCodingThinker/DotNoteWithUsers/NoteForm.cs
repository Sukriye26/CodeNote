using DotNoteWithUsers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNoteWithUsers
{
    public partial class NoteForm : Form
    {
        AppUser appuser;
        Notes selectedNote;
        public NoteForm(AppUser appUser)
        {
            InitializeComponent();
            this.appuser = appUser;
            RefreshNotesList();

        }

        public void ClearInputs()
        {
            titleTextBox.Text = string.Empty;
            noteTextBox.Text = string.Empty;
        }

        public void RefreshNotesList()
        {
            var notes = GetNotes();
            previousNotesListBox.DataSource = null;
            previousNotesListBox.DataSource = notes;
            //previousNotesListBox.Items.Clear();
            //previousNotesListBox.Items.AddRange(notes.ToArray())
            //
            previousNotesListBox.DisplayMember = "Title";
            previousNotesListBox.ValueMember = "Id";

        }

        private void logOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8d0c3");

            loggedUser.Text = appuser.FullName + "'s";
        }

        private void NoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private List<Notes> GetNotes()
        {
            var noteList = new List<Notes>();
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= TutorialDb; integrated security = true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * From Notes where UserId = @userid";
            command.Parameters.AddWithValue("@userid",appuser.Id);

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var note = new Notes();
                note.Id = Convert.ToInt32(reader[0]);
                note.Title = Convert.ToString(reader[1]);
                note.Note = Convert.ToString(reader[2]);
                note.UserId = Convert.ToInt32(reader[3]);
                noteList.Add(note);
            }


            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return noteList;

        }

        private int UpdateNote(Notes selectednote)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Notes set Title= @title, note= @note where Id=@noteid";
            command.Parameters.AddWithValue("@title", selectednote.Title);
            command.Parameters.AddWithValue("@note", selectednote.Note);
            command.Parameters.AddWithValue("@noteid", selectednote.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;
        }

        private int InsertNote(String title, string note, AppUser appuser)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Notes (Title, Note,UserId) values (@title, @note,@userid)";
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@note", note);
            command.Parameters.AddWithValue("@userid", appuser.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;

        }

        private void DeleteNote(Notes selectednote) 
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Notes where Id=@noteid";
            command.Parameters.AddWithValue("@noteid", selectednote.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            selectedNote = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(noteTextBox.Text) && !string.IsNullOrEmpty(titleTextBox.Text))
            {
                int affectedRows = InsertNote(titleTextBox.Text, noteTextBox.Text,appuser);
                ClearInputs();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshNotesList();
                }
                
            }
            else
            {
                MessageBox.Show("Title and Note fields cannot be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedNote != null)
            {
                DeleteNote(selectedNote);
                ClearInputs();
                RefreshNotesList();
            }
            else
            {
                MessageBox.Show("Please select the note you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(selectedNote != null)
            {
                if (!string.IsNullOrEmpty(noteTextBox.Text) && !string.IsNullOrEmpty(titleTextBox.Text))
                {
                    int affectedRows = UpdateNote(new Notes { Note = noteTextBox.Text, Title = titleTextBox.Text, Id = selectedNote.Id });
                    ClearInputs();  
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshNotesList();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select the note you want to update!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void previousNotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(previousNotesListBox.SelectedItem != null)
            {
                selectedNote = previousNotesListBox.SelectedItem as Notes;
                titleTextBox.Text = selectedNote.Title + "";
                noteTextBox.Text = selectedNote.Note + "";
            }
            
        }
    }
}
