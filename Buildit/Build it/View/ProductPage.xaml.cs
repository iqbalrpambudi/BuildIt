using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private Controller.ComponentController control;
        public ProductPage()
        {
            InitializeComponent();
            Controller.ComponentController.SetTipe("cpu");
            control = new Controller.ComponentController(this);
        }

        private void Item1_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("01");
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item2_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("02");
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item3_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("03");
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item4_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("01");
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item5_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("02");
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        //===================================================================


        private void Item6_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            //control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item7_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("02");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item8_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item9_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("01");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Item10_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("02");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }
        private void Item11_Click(object sender, MouseEventArgs e)
        {
            Controller.ComponentController.SetTipe(Controller.ComponentController.GetTipe());
            Controller.ComponentController.SetId("03");
            MainWindow Mw = new MainWindow();
            Mw.Show();
            Mw.frmMain.Navigate(new View.ComponentPage());
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void btnCpu_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("cpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            //itemname
            control.NamaProduct("cpu");          
        }

        private void btnRam_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("ram");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            control.NamaProduct("ram");
        }

        private void btnGpu_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("gpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            control.NamaProduct("gpu");
        }

        private void btnHdd_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("hdd");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            control.NamaProduct("hdd");
        }

        private void btnMobo_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("mobo");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            control.NamaProduct("mobo");
        }

        private void btnCase_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("cases");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
            control.NamaProduct("cases");
        }

        private void btnPsu_Clicked(object sender, RoutedEventArgs e)
        {
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            Item1.Source = Item4.Source = Item6.Source = Item9.Source = src1;
            Item2.Source = Item5.Source = Item7.Source = Item10.Source = src2;
            Item3.Source = Item8.Source = src3;
        }

    }
}
