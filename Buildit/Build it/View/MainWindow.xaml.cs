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

namespace Build_it
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller.ComponentController controlStart;
        private Controller.LoginController controlLogin;
        private MySqlConnection koneksi;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            controlStart = new Controller.ComponentController(this);
            lblUsername.Content = Controller.LoginController.GetNama();           
        }

        private void btnBuild_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new View.BuildPage());
            MessageBox.Show("Please select Motherboard first");
        }

        private void btnComponent_Click(object sender, RoutedEventArgs e)
        {            
            frmMain.Navigate(new View.ComponentPage());
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new View.ComparePage());
        }

        public void UserImage_Click(object sender, MouseEventArgs e)
        {
            View.UserWindow UsrP = new View.UserWindow();
            UsrP.Show();
        }

        private void btnItemMode_Click(object sender, RoutedEventArgs e)
        {
            View.ItemMode Im = new View.ItemMode();
            Im.Show();
            this.Close();
        }

        private void btnBuildMode_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            View.Login.MainLoginPage Login = new View.Login.MainLoginPage();
            Login.Show();
            this.Close();
        }
    }
}
