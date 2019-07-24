using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;

namespace Build_it.View.Login
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private MySqlConnection koneksi;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            koneksi = Connection.MySQLConnection.GetConn();
            string regQuery = "insert into login (username,password,nama,email) values ('" + this.regUsername.Text + "','" + this.regPassword.Text + "','" + this.regName.Text + "','"+ this.regEmail.Text + "');";
            try
            {
                koneksi.Open();
                MySqlCommand Cmd = new MySqlCommand(regQuery, koneksi);
                MySqlDataReader Read;
                Read = Cmd.ExecuteReader();

                MessageBox.Show("Data tersimpan di Database");

                regUsername.Text = "";
                regPassword.Text = "";
                regName.Text = "";
                regEmail.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Koneksi Database Gagal :(");
                this.NavigationService.GoBack();
            }
         
        }

        private void regName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
