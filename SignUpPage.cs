using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryMaker
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (UsernameInTextBox.Text.Equals(string.Empty) || PasswordInTextBox.Text.Equals(string.Empty) || ConfirmPasswordInTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show("There can not be any Empty Box");
            }
            else
            {
             if (PasswordInTextBox.Text != ConfirmPasswordInTextBox.Text)
                {
                    MessageBox.Show("Password did not match");
                }
             else if(PasswordInTextBox.Text.Length<4 && ConfirmPasswordInTextBox.Text.Length<4)
                {
                    MessageBox.Show("Password must be at least 4 characters");
                }
             else
                {
                    string UserName, Password;
                    UserName = UsernameInTextBox.Text;
                    Password = PasswordInTextBox.Text;

                    DataAccess db = new DataAccess();
                    int i=db.AddUser(UserName, Password);
                    if(i==1)
                    {
                        this.Hide();
                        MessageBox.Show("Successfully signed up");
                    }
                    

                }
            }
        }

        private void BackSiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }
      

    }
}
