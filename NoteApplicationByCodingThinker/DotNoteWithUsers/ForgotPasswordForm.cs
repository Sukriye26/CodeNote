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
    public partial class ForgotPasswordForm : Form
    {
        AppUser appuser;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void GoToForm1()
        {
            LoginForm form = new LoginForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void clearLabels()
        {
            userNameValidation.Text = String.Empty;
            fullNameValidation.Text = String.Empty;
            passValidation.Text = String.Empty;
            againPassValidation.Text = String.Empty;
        }

        private void giveValidation()
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

        private bool checkPassword()
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

        private void ClearInputs()
        {
            passwordText.Text = string.Empty;
            againPassText.Text = string.Empty;
            userNameText.Text = string.Empty;
            fullNameText.Text = string.Empty;
        }



        private AppUser GetUserIdViaUserNameAndFullName(String userName, string fullName)
        {
  
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= TutorialDb; integrated security = true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select Id, UserName, FullName From Users where UserName=@username and FullName=@fullname";
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@fullname", fullName);

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                appuser = new AppUser();
                appuser.Id = Convert.ToInt32(reader[0]);
            }


            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return appuser;

        }

        private int UpdateUserPassword(string password, AppUser appuser)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Uptade Users set Password=@password where Id=@userid";
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@userid", appuser.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;

        }





        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8d0c3");
        }

        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_MouseHover(object sender, EventArgs e)
        {

            backButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0c2b1");
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {

            backButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0c2b1");
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            clearLabels();

            if (!string.IsNullOrEmpty(userNameText.Text) && !string.IsNullOrEmpty(fullNameText.Text)
                 && !string.IsNullOrEmpty(passwordText.Text) && !string.IsNullOrEmpty(againPassText.Text))
            {
                if (checkPassword())
                {
                    var appuser = GetUserIdViaUserNameAndFullName(userNameText.Text, fullNameText.Text);

                    if (appuser != null)
                    {
                        int affectedRows =UpdateUserPassword(passwordText.Text, appuser);
                        if (affectedRows > 0)
                        {
                            switch (MessageBox.Show("User password is updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information))
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
                        switch (MessageBox.Show("Wrong User Name or Full Name!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
                        {
                            case DialogResult.Cancel:
                                ClearInputs();
                                GoToForm1();
                                break;
                            case DialogResult.Retry:
                                passwordText.Text = string.Empty;
                                againPassText.Text = string.Empty;

                                break;
                        }
                    }
                }

            }
            else
            {
                giveValidation();
            }


        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            GoToForm1();
        }


    }
}
