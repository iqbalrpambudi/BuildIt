using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_it.Controller
{
    class ComponentController
    {
        private Model.ComponentModel modelComponent;
        private View.ComponentPage viewComponent;
        private MainWindow mainWindow;
        private View.ProductPage viewProduct;

        //untuk menampung variabel item
        private static string selecttipe;
        private static string selectid;


        public ComponentController(View.ComponentPage viewComponent)
        {
            this.viewComponent = viewComponent;
            modelComponent = new Model.ComponentModel();
        }

        public ComponentController(MainWindow mainWindow)
        {
            // TODO: Complete member initialization
            this.mainWindow = mainWindow;
            modelComponent = new Model.ComponentModel();
        }
        public ComponentController(View.ProductPage viewProduct)
        {
            // TODO: Complete member initialization
            this.viewProduct = viewProduct;
            modelComponent = new Model.ComponentModel();
        }


//detail menu==================================================================================
        public void Deskripsi(string tipe, string id)
        {
            viewComponent.txtTextBox.Text = modelComponent.Component("deskripsi",tipe,id);
        }

        public void Harga(string tipe, string id)
        {
            viewComponent.txtTextBox.Text ="Rp. " + modelComponent.Component("harga", tipe, id);
        }

        public void Spesifikasi(string tipe ,string id)
        {
            viewComponent.txtTextBox.Text = modelComponent.Component("nama", tipe, id);
        }

        public void NamaItem(string tipe,string id)
        {
            viewComponent.itemName.Content = modelComponent.Component("nama", tipe, id);
        }

        //menamai product di halaman product
        public void NamaProduct(string tipe)
        {
            viewProduct.lblItem1.Content = viewProduct.lblItem4.Content = viewProduct.lblItem6.Content = viewProduct.lblItem9.Content = modelComponent.Component("nama", tipe,"01");
            viewProduct.lblItem2.Content = viewProduct.lblItem5.Content = viewProduct.lblItem7.Content = viewProduct.lblItem10.Content = modelComponent.Component("nama", tipe,"02");
            viewProduct.lblItem3.Content = viewProduct.lblItem8.Content = modelComponent.Component("nama", tipe,"03");
        }

//navigasi item===================================================================================
        public string NavigateItem(string item,string id)
        {
            modelComponent.Component("url", item, id);
            return modelComponent.hasil;
        }


//fungsi untuk menampung variabel sementara=========================================================
        //set tipe
        public static void SetTipe(String selecttipe)
        {
            ComponentController.selecttipe = selecttipe;
        }
        public static String GetTipe()
        {
            return selecttipe;
        }

        //set id
        public static void SetId(String selectid)
        {
            ComponentController.selectid = selectid;
        }
        public static String GetId()
        {
            return selectid;
        }

        //setter tipe
        public void SetterTipe()
        {
            SetTipe("cpu");
        }

        public void SetterId()
        {
            SetId("01");
        }
    }
}
