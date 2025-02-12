using AviaSales.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaSales.Forms
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if (CheckValidSignUp())
            {
                if (checkBox.Checked)
                {
                    var admin = new Admin(tb_name.Text, tb_surname.Text, (int)numeric_age.Value, tb_login.Text,
                        tb_password.Text);
                    Program.AviaSales.Users.Add(admin);
                }
                else
                {
                    var client = new Client(tb_name.Text, tb_surname.Text, (int)numeric_age.Value, tb_login.Text,
                        tb_password.Text);
                    Program.AviaSales.Users.Add(client);
                }
            }
        }
    }

}
