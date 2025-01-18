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

        }
    }
}
