using DotNoteWithUsers.Entities;
using System.Data.SqlClient;

namespace DotNoteWithUsers
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void GoToDotNote(AppUser appuser)
        {
            NoteForm form = new NoteForm(appuser);
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        public void ClearInputs()
        {
            passwordText.Text = string.Empty;
            userNameText.Text = string.Empty;
        }

        private void GoToRegister()
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void GoToForgotPassword()
        {
            //forgotPassLabel.ActiveLinkColor = System.Drawing.ColorTranslator.FromHtml("#e0c2b1");
            ForgotPasswordForm form = new ForgotPasswordForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void giveValidation()
        {
            string validation = "cannot be blank.";

            if (string.IsNullOrEmpty(userNameText.Text))
                userNameValidation.Text = "User Name " + validation;
            if (string.IsNullOrEmpty(passwordText.Text))
                passValidation.Text = "Password " + validation;
        }


        private void clearLabels()
        {
            userNameValidation.Text = String.Empty;
            passValidation.Text = String.Empty;
        }

        /// <summary>
        /// girilen username ve password bilgisine sahip user fullname'ini döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private AppUser GetUserFullName(string userName, string password)
        {
            var appUser = new AppUser();
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= TutorialDb; integrated security = true;");
            SqlCommand command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;

            command.CommandText = "Select * from Users where UserName=@username and Password=@password";
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue ("@password", password);

            connection.Open();
            var reader = command.ExecuteReader();
            string fullName = "";
            while (reader.Read())
            {
                appUser.Id = Convert.ToInt32(reader[0]);
                appUser.FullName = Convert.ToString(reader[3]);
            }
            reader.Close();
            command.Parameters.Clear ();
            connection.Close();

            return appUser;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8d0c3");
            //userNameText.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdfbfa");
            //passwordText.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdfbfa");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0c2b1");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void forgotPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToForgotPassword();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToRegister();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            clearLabels();
            if (!string.IsNullOrEmpty(userNameText.Text) && !string.IsNullOrEmpty(passwordText.Text))
            {
                AppUser appUser = GetUserFullName(userNameText.Text, passwordText.Text);
                

                if (!string.IsNullOrEmpty(appUser.FullName))
                {
                    GoToDotNote(appUser);
                    ClearInputs();
                }
                else
                {
                   switch( MessageBox.Show("Wrong User Name or Password!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
                    {
                        case DialogResult.Cancel:
                            ClearInputs();
                            break;
                        case DialogResult.Retry:
                            passwordText.Text = string.Empty;
                            break;
                    }
                }
                
                
            }
            else
            {
                giveValidation();
            }

        }

    }
}