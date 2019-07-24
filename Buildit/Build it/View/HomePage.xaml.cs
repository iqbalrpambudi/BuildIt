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

namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private Controller.ComponentController ComponentController;
        public HomePage()
        {
            InitializeComponent();
            Controller.ComponentController.SetTipe("cpu");
            Controller.ComponentController.SetId("01");
        }

        public void CloseWindow()
        {
            var parentWindow = this.Parent as ItemMode;
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        private void Item1_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("gpu");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item2_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("hdd");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item3_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("mobo");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item4_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("cpu");
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item5_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("ram");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        //-===================================================
        private void Item6_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("gpu");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item7_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("cpu");
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item8_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("mobo");
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item9_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("cases");
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item10_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("hdd");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item11_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe("ram");
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }
    }
}
