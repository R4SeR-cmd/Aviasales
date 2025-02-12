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
    public partial class AdminProfile : Form
    {
        private Admin _admin;
        public AdminProfile(User user)
        {
            InitializeComponent();
           _admin = (Admin) user;
           lb_name.Text = _admin.Name;
           lb_surname.Text = _admin.Surname;
           lb_age.Text = _admin.Age.ToString();
           

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            var infoForm = new Information();
            infoForm.ShowDialog();
        }
        
        private void btn_setting_Click(object sender, EventArgs e)
        {
            var setting = new Settings(_admin);
            setting.ShowDialog();
            RefreshDataAdmin();


        }

        private void RefreshDataAdmin()
        {
            lb_name.Text = _admin.Name;
            lb_surname.Text = _admin.Surname;
            lb_age.Text = _admin.Age.ToString();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_functional_Click(object sender, EventArgs e)
        {

            var functionHome = new AdminFunction();
            functionHome.ShowDialog();
        }
    }
}
