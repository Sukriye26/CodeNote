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
using System.Security.Cryptography;

namespace DotNoteWithUsers
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void ClearInputs()
        {
            userNameText.Text = String.Empty;
            fullNameText.Text = String.Empty;
            passwordText.Text = String.Empty;
            againPassText.Text = String.Empty;
        }
        private void GoToForm1()
        {
            LoginForm form = new LoginForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void ClearLabels()
        {
            userNameValidation.Text = String.Empty;
            fullNameValidation.Text = String.Empty;
            passValidation.Text = String.Empty;
            againPassValidation.Text = String.Empty;
        }

        private string ChipherPasswordWithSHA256(string password)
        {
            string source = password;
            using (SHA256 sha1Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }

        private void GiveValidation()
        {
            string validation = "cannot be blank.";

            if (string.IsNullOrEmpty(userNameText.Text))
                userNameValidation.Text = "User Name " + validation;
            if (string.IsNullOrEmpty(fullNameText.Text))
                fullNameValidation.Text = "Full Name " + validation;
            if (string.IsNullOrEmpty(passwordText.Text))
                passValidation.Text = "Password " + validation;
            if (string.IsNullOrEmpty(againPassText.Text))
                againPassValidation.Text = "Password Again " + validation;
        }

        private bool CheckPassword()
        {
            if (passwordText.Text == againPassText.Text)
            {
                return true;
            }
            else
            {
                passwordText.Text = String.Empty;
                againPassText.Text = String.Empty;
                passValidation.Text = "Passwords do not match";
                againPassValidation.Text = "Passwords do not match";
                return false;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoToForm1();
        }
        private List<AppUser> GetUsers()
        {
            var usersList = new List<AppUser>();
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= TutorialDb; integrated security = true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select UserName From Users";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var appuser = new AppUser();
                appuser.UserName = Convert.ToString(reader[0]);
                usersList.Add(appuser);
            }


            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return usersList;

        }

        private int InsertUser(string userName, string password, string fullName)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Users (UserName, Password,FullName) values (@userName, @password, @fullName)";
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@fullName", fullName);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;

        }

        private bool CheckIsUserNameExist(string userName)
        {
            var usersList = GetUsers();

            return usersList.Any(x => x.UserName == userName);
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            ClearLabels();

            if (!string.IsNullOrEmpty(userNameText.Text) && !string.IsNullOrEmpty(fullNameText.Text)
                 && !string.IsNullOrEmpty(passwordText.Text) && !string.IsNullOrEmpty(againPassText.Text))
            {

                if (CheckPassword())
                {
                    if (!CheckIsUserNameExist(userNameText.Text))
                    {
                        int affectedRows = InsertUser(userNameText.Text, passwordText.Text, fullNameText.Text);
                        if (affectedRows > 0)
                        {
                            switch (MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information))
                            {
                                case DialogResult.OK:
                                    ClearInputs();
                                    GoToForm1();
                                    break;
                            }

                        }
                       
                    }
                    else
                    {
                        ClearInputs();
                        ClearLabels();
                        userNameValidation.Text = "This user name already taken.";

                    }
                    //dbde username var mı kontrol et


                    //GoToForm1();
                }

            }
            else
            {
                GiveValidation();
            }


        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8d0c3");
        }
    }
}
    
