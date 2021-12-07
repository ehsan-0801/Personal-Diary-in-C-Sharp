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

namespace DiaryMaker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (UsernameTextBox.Text.Equals(string.Empty) || PasswordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("There can not be any empty field");
            }
            else
            {
                string userName = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;



                DataAccess db = new DataAccess();
                SqlDataReader sd = db.Search("Select * from WRITERS");
                bool userExists = false;
                while (sd.Read())
                {
                    string _userName = (String)sd.GetValue(sd.GetOrdinal("UserName"));
                    string _password = (String)sd.GetValue(sd.GetOrdinal("Password"));



                    if (userName == _userName && password == _password)
                    {
                        userExists = true;
                        Program.User_Id = (int)sd.GetValue(sd.GetOrdinal("UserId"));
                        break;
                    }
                }



                if (userExists)
                {
                    new AllDocuments().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong User-Name & Password");
                }
            }
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            new SignUpPage().Show();
        }

        private void LoginGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewOneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
