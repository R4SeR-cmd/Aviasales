using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    public partial class Settings : Form
    {
        private User _user;
        public Settings(User user)
        {
            InitializeComponent();
            _user = user;
            tb_name.Text = _user.Name;
            tb_surname.Text = _user.Surname;
            numeric_age.Value = _user.Age;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
               _user.Name = tb_name.Text;
               
            }

            if (!string.IsNullOrEmpty(tb_surname.Text))
            {
                
                _user.Surname = tb_surname.Text;
            }

            if (numeric_age.Value > 0)
            {
                _user.Age = (int)numeric_age.Value;

            }


            if (!string.IsNullOrEmpty(tb_new_password.Text))
            {
                if (tb_password.Text != _user.Password)
                {
                    MessageBox.Show("Re-try , enter your password");
                     return;
                }

                _user.Password = tb_new_password.Text;
            }

            MessageBox.Show("Changes saved");
            Close();
           

        }
    }
}
