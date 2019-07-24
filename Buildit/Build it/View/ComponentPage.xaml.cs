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
using MySql.Data.MySqlClient;

namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for ComponentPage.xaml
    /// </summary>
    public partial class ComponentPage : Page
    {
        private Controller.ComponentController control;
        private MySqlConnection koneksi;
        public ComponentPage()
        {
            InitializeComponent();
            koneksi = Connection.MySQLConnection.GetConn();
            control = new Controller.ComponentController(this);
            Controller.ComponentController.GetTipe();
            Controller.ComponentController.GetId();
            DisplayImage();
            control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }
        private void btnHarga(object sender, RoutedEventArgs e)
        {
            control.Harga(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }

        private void btnSpesifikasi(object sender, RoutedEventArgs e)
        {
            control.Spesifikasi(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }

        private void btnDeskripsi(object sender, RoutedEventArgs e)
        {
            control.Deskripsi(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }


        public void DisplayImage()
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId())));
            displayImage.Source = src;
        }

        private void item1_Click(object sender,MouseEventArgs e)
        {

            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            displayImage.Source = src;
            Controller.ComponentController.SetId("01");
            control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }

        private void item2_Click(object sender,MouseEventArgs e)
        {

            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            displayImage.Source = src;
            Controller.ComponentController.SetId("02");
            control.NamaItem(Controller.ComponentController.GetTipe(), Controller.ComponentController.GetId());
        }

          private void item3_Click(object sender,MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            displayImage.Source = src;
            Controller.ComponentController.SetId("03");
            control.NamaItem(Controller.ComponentController.GetTipe(),Controller.ComponentController.GetId());
        }

        private void btnCpu(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("cpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnRam(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("ram");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
            
        }

        private void btnGpu(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("gpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
            
        }

        private void btnHdd(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("hdd");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
            
        }

        private void btnMobo(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("mobo");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
            
        }

        private void btnPsu(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("psu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
            
        }

        private void btnCase(object sender, RoutedEventArgs e)
        {
            Controller.ComponentController.SetTipe("cases");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.ComponentController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }
    }
    }

    

