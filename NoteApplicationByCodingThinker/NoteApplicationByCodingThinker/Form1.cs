using System.Data;

namespace NoteApplicationByCodingThinker

{
    public partial class Form1 : Form
    {
        // neden data table diyebiirsiniz bu not uygulamas�n� yapmakta epey ge� kald�m puan alamayacak olsam da yapmam gerekiyor. 
        // ba�ka kayna�a bakmay�n dediniz ama ben data table kullanmay� zaten biliyordum :) biz lisede c# dersi al�rken veritaban�ndan �nce data table kullanm��t�k.
        // dersi tekrar izlemeden yap�yorum bu arada sizin yapt���n�z baz� �eyleri koymam�� olabilirim i�lemedi�iniz yerleri eklemi� olabilirim ama ki�iselle�tirmek bizim elimizdeydi.
        // try catch blo�unu, buton click eventini ben icat etmedim ama bu kod ili�imle kemi�imle bana ait oldu, GURURLUYUM :) - ki �devi anlaman�z laz�m derken de bunu kastetti�niizi d���n�yorum.
        // E�er vakit bulabilirsem bi�eyler daha deneyece�im ama di�er �devi yeti�tirmem gerekiyor. Belki yarat�c�l���m� orda kullanabilirim. 
        // Zaten yazarken de farkettim ke�ke �devi verdi�inizde 10 dakika ay�rsaym���m :( 
        // �uan bizim uygulamada �al��an servis mimarisini tam anlamad���m i�in biraz k�t� hissediyorum. �n�allah kurs bitti�inde �st sat�rda yazd���m gibi hissederim bu d���ncem i�in de. 

        DataTable notes = new DataTable();
        bool revise = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8eaf6");
            notes.Columns.Clear();             // tamamen al��kanl�k :)
            notes.Columns.Add("Title");        // kullanaca��m s�tun isimlerini ekliyorum. 
            notes.Columns.Add("Note");

            //data table'� yerine yerle�tirme vakti
            previousNotes.DataSource = notes;


        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            noteTextBox.Text = "";

            // titleTextBox.Clear(); ikisinin fark� yok gibiydi ama bir ara bakaca��m buna
            // javada hep text="" kulland�k al��kanl�k san�r�m bu da


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //umar�m editleme hayalimdeki gibi �al���r
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            revise = true; // bu notu biliyorum zaten kay�tl� g�ncelleyece�im demeye �al���yorum

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // acaba bildi�im �� be� konuyu nas�l g�sterebilirim diye d���n�rken neden delete yap�p hata ald�rmayay�m ki dedim ve ortaya a�a��daki blok ��kt�

            try
            {
                //buradaki mant��� asl�nda derste lisbox'�n selectedItem'�n� al�rken yapt���n�z mant�ktan yola ��karak kurdum
                // currentCell'mi� o an se�ili olan item buna dok�mantasyondan bakt�m

                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not a valid note"); // Kullan�c�ya nullPointerException g�stermeyelim tabi
                Console.WriteLine(ex.Message);       // ama merakl�s�na hatay� da g�sterebiliriz, neden olmas�n?
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (revise) // e�er bu notu biliyorsam
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleTextBox.Text; //  ba�l��� ve
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteTextBox.Text;   // notu data table'�n se�ili olan itemine g�nder
            }
            else // notu tan�m�yorsam
            {
                notes.Rows.Add(titleTextBox.Text, noteTextBox.Text); // ba�l��� [0] ve notu [1] olan yeni bir �ge ekle
            }

            // her ne olursa olsun i� bitince temizlik 
            titleTextBox.Text = "";
            noteTextBox.Text = "";
            revise = false;  // notla i�im bitti bir sonraki notlar� bilemem
        }
    }
}