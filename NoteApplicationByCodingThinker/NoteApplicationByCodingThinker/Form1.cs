using System.Data;

namespace NoteApplicationByCodingThinker

{
    public partial class Form1 : Form
    {
        // neden data table diyebiirsiniz bu not uygulamasýný yapmakta epey geç kaldým puan alamayacak olsam da yapmam gerekiyor. 
        // baþka kaynaða bakmayýn dediniz ama ben data table kullanmayý zaten biliyordum :) biz lisede c# dersi alýrken veritabanýndan önce data table kullanmýþtýk.
        // dersi tekrar izlemeden yapýyorum bu arada sizin yaptýðýnýz bazý þeyleri koymamýþ olabilirim iþlemediðiniz yerleri eklemiþ olabilirim ama kiþiselleþtirmek bizim elimizdeydi.
        // try catch bloðunu, buton click eventini ben icat etmedim ama bu kod iliðimle kemiðimle bana ait oldu, GURURLUYUM :) - ki ödevi anlamanýz lazým derken de bunu kastettiðniizi düþünüyorum.
        // Eðer vakit bulabilirsem biþeyler daha deneyeceðim ama diðer ödevi yetiþtirmem gerekiyor. Belki yaratýcýlýðýmý orda kullanabilirim. 
        // Zaten yazarken de farkettim keþke ödevi verdiðinizde 10 dakika ayýrsaymýþým :( 
        // Þuan bizim uygulamada çalýþan servis mimarisini tam anlamadýðým için biraz kötü hissediyorum. Ýnþallah kurs bittiðinde üst satýrda yazdýðým gibi hissederim bu düþüncem için de. 

        DataTable notes = new DataTable();
        bool revise = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8eaf6");
            notes.Columns.Clear();             // tamamen alýþkanlýk :)
            notes.Columns.Add("Title");        // kullanacaðým sütun isimlerini ekliyorum. 
            notes.Columns.Add("Note");

            //data table'ý yerine yerleþtirme vakti
            previousNotes.DataSource = notes;


        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            noteTextBox.Text = "";

            // titleTextBox.Clear(); ikisinin farký yok gibiydi ama bir ara bakacaðým buna
            // javada hep text="" kullandýk alýþkanlýk sanýrým bu da


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //umarým editleme hayalimdeki gibi çalýþýr
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            revise = true; // bu notu biliyorum zaten kayýtlý güncelleyeceðim demeye çalýþýyorum

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // acaba bildiðim üç beþ konuyu nasýl gösterebilirim diye düþünürken neden delete yapýp hata aldýrmayayým ki dedim ve ortaya aþaðýdaki blok çýktý

            try
            {
                //buradaki mantýðý aslýnda derste lisbox'ýn selectedItem'ýný alýrken yaptýðýnýz mantýktan yola çýkarak kurdum
                // currentCell'miþ o an seçili olan item buna dokümantasyondan baktým

                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not a valid note"); // Kullanýcýya nullPointerException göstermeyelim tabi
                Console.WriteLine(ex.Message);       // ama meraklýsýna hatayý da gösterebiliriz, neden olmasýn?
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (revise) // eðer bu notu biliyorsam
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleTextBox.Text; //  baþlýðý ve
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteTextBox.Text;   // notu data table'ýn seçili olan itemine gönder
            }
            else // notu tanýmýyorsam
            {
                notes.Rows.Add(titleTextBox.Text, noteTextBox.Text); // baþlýðý [0] ve notu [1] olan yeni bir öge ekle
            }

            // her ne olursa olsun iþ bitince temizlik 
            titleTextBox.Text = "";
            noteTextBox.Text = "";
            revise = false;  // notla iþim bitti bir sonraki notlarý bilemem
        }
    }
}