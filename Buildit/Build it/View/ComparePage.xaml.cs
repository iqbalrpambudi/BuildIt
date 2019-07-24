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
using System.Data;
namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for ComparePage.xaml
    /// </summary>
    public partial class ComparePage : Page
    {
        private Controller.CompareController control;
        private MySqlConnection koneksi;

        public ComparePage()
        {
            InitializeComponent();
            koneksi = Connection.MySQLConnection.GetConn();
            control = new Controller.CompareController(this);
            Controller.CompareController.SetTipe("cpu");
            Controller.CompareController.SetId("01");
        }

        private void btnCpu_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("cpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Nama";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Soket";
            Spec4.Content = Spec4_2.Content = "Harga";
        }

        private void btnRam_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("ram");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Kapasitas";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Tipe";
            Spec4.Content = Spec4_2.Content = "Harga";
        }

        private void btnGpu_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("gpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Nama";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Tipe";
            Spec4.Content = Spec4_2.Content = "Harga";
        }

        private void btnHdd_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("hdd");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Tipe";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Kapasitas";
            Spec4.Content = Spec4_2.Content = "Harga";
        }

        private void btnMobo_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("mobo");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Soket";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Slot";
            Spec4.Content = Spec4_2.Content = "Harga";
        }

        private void btnCase_Clicked(object sender, RoutedEventArgs e)
        {
            Controller.CompareController.SetTipe("cases");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            Item1_1.Source = Item1_2.Source = src1;
            Item2_1.Source = Item2_2.Source = src2;
            Item3_1.Source = Item3_2.Source = src3;
            Spec1.Content = Spec1_2.Content = "Nama";
            Spec2.Content = Spec2_2.Content = "Vendor";
            Spec3.Content = Spec3_2.Content = "Harga";
            Spec4.Content = Spec4_2.Content = "";
        }

        private void btnPsu_Clicked(object sender, RoutedEventArgs e)
        {

        }

        //button item1
        private void Item1_1_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            DisplayItem1.Source = src;
            Controller.CompareController.SetId("01");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData1("01");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData1("01");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData1("01");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData1("01");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData1("01");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData1("01");
            }
        }
        private void Item2_1_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            DisplayItem1.Source = src;
            Controller.CompareController.SetId("02");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData1("02");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData1("02");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData1("02");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData1("02");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData1("02");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData1("02");
            }
        }
        private void Item3_1_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            DisplayItem1.Source = src;
            Controller.CompareController.SetId("03");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData1("03");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData1("03");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData1("03");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData1("03");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData1("03");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData1("03");
            }
        }

        //button item2
        private void Item1_2_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "01")));
            DisplayItem2.Source = src;
            Controller.CompareController.SetId("01");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData2("01");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData2("01");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData2("01");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData2("01");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData2("01");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData2("01");
            }
        }
        private void Item2_2_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "02")));
            DisplayItem2.Source = src;
            Controller.CompareController.SetId("02");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData2("02");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData2("02");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData2("02");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData2("02");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData2("02");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData2("02");
            }
        }
        private void Item3_2_Click(object sender, MouseEventArgs e)
        {
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.CompareController.GetTipe(), "03")));
            DisplayItem2.Source = src;
            Controller.CompareController.SetId("03");
            if (Controller.CompareController.GetTipe() == "cpu")
            {
                control.GetCpuData2("03");
            }
            else if (Controller.CompareController.GetTipe() == "ram")
            {
                control.GetRamData2("03");
            }
            else if (Controller.CompareController.GetTipe() == "gpu")
            {
                control.GetGpuData2("03");
            }
            else if (Controller.CompareController.GetTipe() == "hdd")
            {
                control.GetHddData2("03");
            }
            else if (Controller.CompareController.GetTipe() == "mobo")
            {
                control.GetMoboData2("03");
            }
            else if (Controller.CompareController.GetTipe() == "cases")
            {
                control.GetCaseData2("03");
            }
        }


    }
}
