using System.Data.SqlClient;
using WinFormNotePad.Entities;

namespace WinFormNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //if(password.Text!="" && password.Text!= null && username.Text!="" && username.Text != null ) { 


            //} 
            //yerine

            //if (!string.IsNullOrEmpty(usernameTxt.Text) && !string.IsNullOrEmpty(password.Text))
            //{
            //    if (DataStore.AppUser.UserName != usernameTxt.Text || DataStore.AppUser.Password != password.Text)
            //    {
            //        MessageBox.Show("Kullanýcý Adý ya da Parola Hatalý");
            //        password.Text = "";
            //    }
            //    else
            //    {
            //        Form2 form2 = new Form2(appuser);
            //        usernameTxt.Text = "";
            //        password.Text = "";
            //        form2.ShowDialog();
            //        this.Hide();

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Alanlarý boþ býrakmayýnýz");
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var notes = DataStore.Notes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTxt.Text) && !string.IsNullOrEmpty(password.Text))
            {
                AppUserFromDB appUser = null;


                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=NoteDb; integrated security= true");
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;

                command.CommandText = "select * from Users where Username=@username and Password=@password";

                command.Parameters.AddWithValue("@username", usernameTxt.Text);
                command.Parameters.AddWithValue("@password", password.Text);


                command.Connection = connection;


                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    appUser = new AppUserFromDB();
                    //appUser.Id = Convert.ToInt32(reader["id"]);
                    appUser.Id = Convert.ToInt32(reader[0]);
                    appUser.Username = reader[1].ToString();
                    appUser.Password = reader[2].ToString();
                }

                reader.Close();


                connection.Close();


                usernameTxt.Text = string.Empty;
                password.Text = string.Empty;

                if (appUser != null)
                {
                    Form2 form2 = new Form2(appUser);
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý ya da Parola hatalý!");
                }
                

            }
            else
            {
                MessageBox.Show("Alanlarý boþ býrakmayýnýz");
            }
        }
    }
}
