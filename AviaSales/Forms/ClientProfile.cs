using System.Windows.Forms;
using AviaSales.Models.Users;

namespace AviaSales.Forms
{
    public partial class ClientProfile : Form
    {
        
        private Client _client;
        public ClientProfile(User user)
        {
            InitializeComponent();
            _client = (Client) user;
            lb_name.Text = _client.Name;
            lb_surname.Text = _client.Surname;
            lb_age.Text = _client.Age.ToString();
            lb_cash.Text = _client.Balance.ToString();
        }

        private void btn_info_Click(object sender, System.EventArgs e)
        {
            var infoForm = new Information();
            infoForm.ShowDialog();
        }

        private void btn_setting_Click(object sender, System.EventArgs e)
        {
           
            var setting = new Settings(_client);
            setting.ShowDialog();
            RefreshDataClient();
        }

        private void btn_logout_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void RefreshDataClient()
        {
            lb_name.Text = _client.Name;
            lb_surname.Text = _client.Surname;
            lb_age.Text = _client.Age.ToString();
            lb_cash.Text = _client.Balance.ToString();
        }
    }
}
