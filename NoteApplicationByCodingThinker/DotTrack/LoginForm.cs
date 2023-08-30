using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;
using System.Data.SqlClient;



namespace DotTrack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbdef1");
        }

        private void forgotPassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string eMail = Interaction.InputBox("Please write your e-mail.");

            switch (MessageBox.Show("Password reset instruction has been sent  to " + eMail + " address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information))
            {
                case DialogResult.OK:
                    ClearInputs();
                    break;
            }
        }

        private void GoToDotTrack()
        {
            StockForm form = new StockForm();
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


        private AppUser LogIn(string userName, string password)
        {
            var appUser = new AppUser();
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= ProductDb; integrated security = true;");
            SqlCommand command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;

            command.CommandText = "Select * from Users where UserName=@username and Password=@password";
            command.Parameters.AddWithValue("@username", userName);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                appUser.Id = Convert.ToInt32(reader[0]);
                appUser.UserName = Convert.ToString(reader[1]);
            }
            reader.Close();
            command.Parameters.Clear();
            connection.Close();

            return appUser;
        }

        public void ClearInputs()
        {
            passwordText.Text = string.Empty;
            userNameText.Text = string.Empty;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            clearLabels();
            if (!string.IsNullOrEmpty(userNameText.Text) && !string.IsNullOrEmpty(passwordText.Text))
            {

                AppUser appUser = LogIn(userNameText.Text, passwordText.Text);


                if (!string.IsNullOrEmpty(appUser.UserName))
                {
                    GoToDotTrack();
                    ClearInputs();
                }
                else
                {
                    switch (MessageBox.Show("Wrong User Name or Password!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
