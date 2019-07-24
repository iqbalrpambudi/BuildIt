using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_it.Controller
{
    class BuildController
    {
        private Model.BuildModel modelBuild;
        private View.BuildPage viewBuild;

        private static string selecttipe;
        private static string selectid;

        public string save;

        private static int idbuild = 0;

        public BuildController(View.BuildPage view)
        {
            viewBuild = view;
            modelBuild = new Model.BuildModel();
        }
//setter id=======================================================================
        public string Attrib(string tipe,string id)
        {
            if (tipe == "cpu")
            {
               modelBuild.GetAtrCpu(id);
               modelBuild.SetCpuInsertId(id);
            }
            else if (tipe == "ram")
            {
                modelBuild.GetAtrRam(id);
                modelBuild.SetRamInsertId(id);
            }
            else if (tipe == "gpu")
            {
                modelBuild.GetAtrGpu(id);
                modelBuild.SetGpuInsertId(id);
            }
            else if (tipe == "hdd")
            {
                modelBuild.GetAtrHdd(id);
                modelBuild.SetHddInsertId(id);
            }
            else if (tipe == "mobo")
            {
                modelBuild.SetMoboSocket(modelBuild.GetAtrMoboSocket(id));
                modelBuild.SetMoboSlot(modelBuild.GetAtrMoboSlot(id));
                modelBuild.SetMoboPci(modelBuild.GetAtrMoboPci(id));
                modelBuild.SetMoboSata(modelBuild.GetAtrMoboSata(id));
                modelBuild.SetMoboInsertId(id);
            }
            else if (tipe == "cases")
            {
                modelBuild.SetCasesInsertId(id);
            }

            return modelBuild.hasil;
        }

        public void Check()
        {
            modelBuild.MatchCpu();
            modelBuild.MatchRam();
            modelBuild.MatchGpu();
            modelBuild.MatchHdd();
            viewBuild.StatusCPU.Text = modelBuild.GetCpuResult();
            viewBuild.StatusRAM.Text = modelBuild.GetRamResult();
            viewBuild.StatusGPU.Text = modelBuild.GetGpuResult();
            viewBuild.StatusHDD.Text = modelBuild.GetHddResult();
            viewBuild.StatusCASES.Text = "Compatible";
            viewBuild.StatusHARGA.Text ="Rp. " +modelBuild.Harga();
        }
     

//navigasi item===================================================================================
        public string NavigateItem(string item, string id)
        {
            modelBuild.SelectItem("url", item, id);
            return modelBuild.hasil;
        }

//getHarga========================================================================================
        public string PriceItem(string item, string id)
        {
            modelBuild.SelectItem("harga", item, id);

            return modelBuild.hasil;
        }
//total harga=====================================================================================

//set get harga
        public void SetPrice(string tipe,string price)
        {
            if (tipe == "cpu")
            {
                modelBuild.SetCpuPrice(price);
            }
            else if (tipe == "ram")
            {
                modelBuild.SetRamPrice(price);
            }
            else if (tipe == "gpu")
            {
                modelBuild.SetGpuPrice(price);
            }
            else if (tipe == "mobo")
            {
                modelBuild.SetMoboPrice(price);
            }
            else if (tipe == "hdd")
            {
                modelBuild.SetHddPrice(price);
            }
            else if (tipe == "cases")
            {
                modelBuild.SetCasesPrice(price);
            }
        }

//fungsi untuk menampung variabel sementara=======================================================
        public static void SetTipe(String selecttipe)
        {
            BuildController.selecttipe = selecttipe;
        }
        public static String GetTipe()
        {
            return selecttipe;
        }

        public static void SetId(String selectid)
        {
            BuildController.selectid = selectid;
        }
        public static String GetId()
        {
            return selectid;
        }

//menginsertkan data build ke database
        public void InsertBuild(string usr)
        {
            if (modelBuild.GetCpuResult() == "Compatible" && modelBuild.GetRamResult() == "Compatible" && modelBuild.GetHddResult() == "Compatible" && modelBuild.GetGpuResult() == "Compatible")
            {
                modelBuild.InsertBuild(usr);
                save = "Berhasil di simpan";
            }
            else
            {
                save = "Maaf Item tidak kompatibel";
            }
        }
    }
}
