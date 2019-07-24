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
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;

namespace Build_it.View.Login
{
    /// <summary>
    /// Interaction logic for MainLoginPage.xaml
    /// </summary>
    public partial class MainLoginPage : Window
    {

        private Controller.LoginController control;
        private MySqlConnection koneksi;
        public MainLoginPage()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            //cek koneksi
            koneksi = Connection.MySQLConnection.GetConn();
            try
            {
              koneksi.Open();
                MessageBox.Show("Koneksi Database Sukses!");
            }
            catch (MySqlException ex)
            {
               MessageBox.Show("Koneksi Database Gagal :(");
                this.Close();
            }
            control = new Controller.LoginController(this);
            txtUsername.Focus();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            frmRegister.Navigate(new View.Login.RegisterPage());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool hasil = control.LoginUser();
            if (hasil==true)
            {
                ItemMode mObj = new ItemMode();
                mObj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ID/Password salah");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
