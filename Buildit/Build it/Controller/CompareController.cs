using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_it.Controller
{
    class CompareController
    {
        private Model.CompareModel modelCompare;
        private View.ComparePage viewCompare;

        private static string selecttipe;
        private static string selectid;

        public CompareController(View.ComparePage viewCompare)
        {
            this.viewCompare = viewCompare;
            modelCompare = new Model.CompareModel();
        }

        //Navigasi Item
        public string NavigateItem(string item, string id)
        {
            modelCompare.Compare("url", item, id);
            return modelCompare.hasil;
        }

        //fungsi untuk menampung variabel sementara=========================================================
        //set tipe
        public static void SetTipe(String selecttipe)
        {
            CompareController.selecttipe = selecttipe;
        }
        public static String GetTipe()
        {
            return selecttipe;
        }

        //set id
        public static void SetId(String selectid)
        {
            CompareController.selectid = selectid;
        }
        public static String GetId()
        {
            return selectid;
        }

        //fungsi ambil quey
        public void GetCpuData1(string id)
        {
            modelCompare.GetDataCpu(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = modelCompare.hasil3;
            viewCompare.Data4.Content = "Rp. "+ modelCompare.hasil4;
        }
        public void GetCpuData2(string id)
        {
            modelCompare.GetDataCpu(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = modelCompare.hasil3;
            viewCompare.Data4_2.Content = "Rp. " + modelCompare.hasil4;
        }

        public void GetRamData1(string id)
        {
            modelCompare.GetDataRam(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = modelCompare.hasil3;
            viewCompare.Data4.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetRamData2(string id)
        {
            modelCompare.GetDataRam(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = modelCompare.hasil3;
            viewCompare.Data4_2.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetGpuData1(string id)
        {
            modelCompare.GetDataGpu(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = modelCompare.hasil3;
            viewCompare.Data4.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetGpuData2(string id)
        {
            modelCompare.GetDataGpu(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = modelCompare.hasil3;
            viewCompare.Data4_2.Content = "Rp. " + modelCompare.hasil4;
        } 
        public void GetMoboData1(string id)
        {
            modelCompare.GetDataMobo(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = modelCompare.hasil3;
            viewCompare.Data4.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetMoboData2(string id)
        {
            modelCompare.GetDataMobo(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = modelCompare.hasil3;
            viewCompare.Data4_2.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetHddData1(string id)
        {
            modelCompare.GetDataHdd(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = modelCompare.hasil3;
            viewCompare.Data4.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetHddData2(string id)
        {
            modelCompare.GetDataCases(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = modelCompare.hasil3;
            viewCompare.Data4_2.Content = "Rp. " + modelCompare.hasil4;
        }
        public void GetCaseData1(string id)
        {
            modelCompare.GetDataCases(id);
            viewCompare.Data1.Content = modelCompare.hasil1;
            viewCompare.Data2.Content = modelCompare.hasil2;
            viewCompare.Data3.Content = "Rp. " + modelCompare.hasil3;
            viewCompare.Data4.Content = "";
        }
        public void GetCaseData2(string id)
        {
            modelCompare.GetDataCases(id);
            viewCompare.Data1_2.Content = modelCompare.hasil1;
            viewCompare.Data2_2.Content = modelCompare.hasil2;
            viewCompare.Data3_2.Content = "Rp. " + modelCompare.hasil3;
            viewCompare.Data4_2.Content = "";
        }
    }
}
