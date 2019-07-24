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

namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for ItemMode.xaml
    /// </summary>
    public partial class ItemMode : Window
    {
        public ItemMode()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            lblUsername.Content = Controller.LoginController.GetNama();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new View.HomePage());
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new View.ProductPage());
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
        private void UserImage_Click(object sender, MouseEventArgs e)
        {
            View.UserWindow UsrP = new View.UserWindow();
            UsrP.Show();
        }

        public void Closing()
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login.MainLoginPage Login = new Login.MainLoginPage();
            Login.Show();
            this.Close();
        }
    }
}
