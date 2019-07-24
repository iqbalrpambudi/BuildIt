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
using MySql.Data.MySqlClient;
namespace Build_it.View
{
    /// <summary>
    /// Interaction logic for BuildPage.xaml
    /// </summary>
    public partial class BuildPage : Page
    {
        private Controller.BuildController control;
        private MySqlConnection koneksi;

        

        public BuildPage()
        {
            InitializeComponent();
            koneksi = Connection.MySQLConnection.GetConn();
            control = new Controller.BuildController(this);
            //set id sementara
            Controller.BuildController.SetId("01");
            //set tipe produk
            Controller.BuildController.SetTipe("cpu");
            //notif
           
        }

        private void btnCpu_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("cpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnRam_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("ram");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnGpu_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("gpu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnHdd_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("hdd");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnMobo_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("mobo");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("cases");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void btnPsu_Click(object sender, RoutedEventArgs e)
        {
            Controller.BuildController.SetTipe("psu");
            ImageSource src1 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            ImageSource src2 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            ImageSource src3 = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            item1.Source = src1;
            item2.Source = src2;
            item3.Source = src3;
        }

        private void item1_Click(object sender, MouseEventArgs e)
        {
            Controller.BuildController.SetId("01");
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "01")));
            if (Controller.BuildController.GetTipe() == "cpu")
            {
                CPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CPU_Price.Content ="Rp. "+ control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "ram")
            {
                RAM_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                RAM_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "gpu")
            {
                GPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                GPU_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "hdd")
            {
                HDD_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                HDD_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "mobo")
            {
                MOBO_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                MOBO_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "cases")
            {
                CASE_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CASES_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }        
         
        }
        private void item2_Click(object sender, MouseEventArgs e)
        {
            Controller.BuildController.SetId("02");
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "02")));
            if (Controller.BuildController.GetTipe() == "cpu")
            {
                CPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CPU_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));           
            }
            else if (Controller.BuildController.GetTipe() == "ram")
            {
                RAM_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                RAM_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "gpu")
            {
                GPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                GPU_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "hdd")
            {
                HDD_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                HDD_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "mobo")
            {
                MOBO_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                MOBO_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "cases")
            {
                CASE_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CASES_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }       
            
        }
        private void item3_Click(object sender, MouseEventArgs e)
        {
            Controller.BuildController.SetId("03");
            ImageSource src = new BitmapImage(new Uri(control.NavigateItem(Controller.BuildController.GetTipe(), "03")));
            if (Controller.BuildController.GetTipe() == "cpu")
            {
                CPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CPU_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "ram")
            {
                RAM_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                RAM_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "gpu")
            {
                GPU_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                GPU_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "hdd")
            {
                HDD_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                HDD_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "mobo")
            {
                MOBO_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                MOBO_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }
            else if (Controller.BuildController.GetTipe() == "cases")
            {
                CASE_Image.Source = src;
                control.Attrib(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                CASES_Price.Content = "Rp. " + control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId());
                control.SetPrice(Controller.BuildController.GetTipe(), control.PriceItem(Controller.BuildController.GetTipe(), Controller.BuildController.GetId()));
            }        
           
        }

        private void btnCek_Click(object sender, RoutedEventArgs e)
        {
            control.Check();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            control.InsertBuild(Controller.LoginController.GetNama());
            MessageBox.Show(control.save);
        }
    }
}
