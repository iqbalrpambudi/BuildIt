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
using MySql.Data.MySqlClient;
using System.Data;

namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private Controller.UserDataController control;
        private MySqlConnection sqlConn;
        string CMDString;
        public UserWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
            control = new Controller.UserDataController(this);
            lblUser.Content = Controller.LoginController.GetNama();
            lblEmail.Content = Controller.LoginController.GetEmail();
            sqlConn = Connection.MySQLConnection.GetConn();
            control.ShowItem(Controller.LoginController.GetNama());
        }

    }
}
