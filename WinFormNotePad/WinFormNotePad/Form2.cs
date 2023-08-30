using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormNotePad.Entities;

namespace WinFormNotePad
{
    public partial class Form2 : Form
    {
        private Note selectedNote = null;

        private Notes selectedNoteDb = null;

        private AppUserFromDB appuser = null;
        public Form2(AppUserFromDB appuser)
        {
            this.appuser = appuser;
            InitializeComponent();
            Refresh();
            loginOlanUser.Text = appuser.Username;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetNotes();
        }
        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Notes;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        public void GetNotes()
        {
            List<Notes> notesFromDb = new List<Notes>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=NoteDb; integrated security = true;");
            connection.Open();
            connectionStatus.Text = connection.State.ToString();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from Notes";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var notes = new Notes();

                notes.Id = Convert.ToInt32(dataReader[0]);
                notes.Description = Convert.ToString(dataReader["Description"]);
                notesFromDb.Add(notes);
            }
            //MessageBox.Show("");
            connection.Close();
            listBox2.DataSource = null;
            listBox2.DataSource = notesFromDb;
            listBox2.DisplayMember = "Description";
            listBox2.ValueMember = "Id";
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(notTxt.Text))
            {
                //işleri nesne ile yürütmek için note nesnesi oluşturdum
                var addedNote = new Note();

                addedNote.Description = notTxt.Text;    //yeni notun açıklaması tamam ama id de vermemiz lazım 
                                                        //yeni notun id sini bulmak için son nota ulaşmamız gerek
                                                        //böylece son notun idsine 1 ekleyip yeni id yi bulabiliriz
                var lastNote = DataStore.Notes[DataStore.Notes.Count - 1];
                addedNote.Id = lastNote.Id + 1;

                //listBox1.Items.Add(addedNote);   //böyle yazarsak hata verecek
                //bunun yerine datasource içine ekleyip yeniden listboxa listeleyebiliriz.

                DataStore.Notes.Add(addedNote);
                Refresh();
                notTxt.Text = string.Empty;




            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedNote = (Note)listBox1.SelectedItem;
                notTxt.Text = selectedNote.Description;


            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DataStore.Notes.Remove(selectedNote);
            selectedNote = null;
            notTxt.Text = string.Empty;
            Refresh();
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            selectedNote.Description = notTxt.Text;
            Refresh();
        }

        private void dbConnectBtn_Click(object sender, EventArgs e)
        {

            //GetNotes();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                selectedNoteDb = (Notes)listBox2.SelectedItem;
                richTextBox1.Text = selectedNoteDb.Description;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {

                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=NoteDb; integrated security = true");
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "insert into Notes (Description) values(@note)";
                command.Parameters.AddWithValue("@note", richTextBox1.Text);


                //command.CommandText = "insert into Notes values ('" + richTextBox1.Text + "')";

                command.Connection = connection;

                command.ExecuteNonQuery();
                connection.Close();
                command.Parameters.Clear();

                GetNotes();
                richTextBox1.Text = string.Empty;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=NoteDb; integrated security = true");

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                // update Notes set Description ='19' where Id = 7

                command.CommandText = "update Notes set Description=@note where Id= @id)";
                command.Parameters.AddWithValue("@note", richTextBox1.Text);
                command.Parameters.AddWithValue("@id", selectedNoteDb.Id);

                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
                command.Parameters.Clear();

                selectedNoteDb.Description = richTextBox1.Text;
                GetNotes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection("server = .\\SQLExpress; database=NoteDb; integrated security= true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Notes where Id = @id";
            command.Parameters.AddWithValue("@id", selectedNoteDb.Id);

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            selectedNoteDb = null;
            richTextBox1.Text = string.Empty;
            GetNotes();
        }
    }
}
