using System;
using System.Windows.Forms;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {

            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (CheckValidSignUp())
            {
                Client client = new Models.Users.Client(tb_name.Text, tb_surname.Text, (int) numeric_age.Value, tb_login.Text,
                    tb_password.Text);

                Program.AviaSales.Users.Add(client);
                Close();
            }
        }

        private bool CheckValidSignUp()
        {
            if (string.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("Not valid name");
                return false;
            }

            if (string.IsNullOrEmpty(tb_surname.Text))
            {
                MessageBox.Show("Not valid surname");
                return false;
            }

            if (numeric_age.Value <= 0)
            {
                MessageBox.Show("Not valid age");
                return false;
            }

            if (string.IsNullOrEmpty(tb_login.Text))
            {
                MessageBox.Show("Not valid login");
                return false;
            }

            if (string.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("Not valid password");
                return false;
            }

            for (int i = 0; i < Program.AviaSales.Users.Count; i++)
            {
                if (Program.AviaSales.Users[i].Login == tb_login.Text)
                {
                    MessageBox.Show("Login  exist!");
                    return false;
                }

            }
            return true;
        }
    }
}

