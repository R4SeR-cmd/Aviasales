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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_visiblePassword_Click(object sender, EventArgs e)
        {
            
            if (btn_visiblePassword.Tag?.ToString() == "Unvisible")
            {
                btn_visiblePassword.Image = Properties.Resources.visible1;
                btn_visiblePassword.Tag = "Visible";
                tb_password.UseSystemPasswordChar = true;
            }
            else
            {
                btn_visiblePassword.Image = Properties.Resources.Unvisible;
                btn_visiblePassword.Tag = "Unvisible";
                tb_password.UseSystemPasswordChar = false;
            }


        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            var user = Program.AviaSales.Users
                .FirstOrDefault(u => u.Login == tb_login.Text && u.Password == tb_password.Text);

            if (user == null)
            {
                MessageBox.Show("Not valid password or login");
            }

            if (user is Client)
            {
                var clientProfile = new ClientProfile(user);
                clientProfile.ShowDialog();
            }
            else if (user is Admin)
            {
                var adminProfile = new AdminProfile(user);
                adminProfile.ShowDialog();
            }
        }

        private void linkLabel_notHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
 