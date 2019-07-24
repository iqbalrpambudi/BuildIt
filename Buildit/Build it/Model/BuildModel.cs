using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Build_it.Model
{
    class BuildModel
    {
        //koneksi ke database
        private MySqlConnection sqlConn;
        public BuildModel()
        {
            sqlConn = Connection.MySQLConnection.GetConn();
        }

        private string query;
        public string hasil;
        private static string maxid;

        //variabel untuk mencocokan barang
        private string cpu_atr;
        private string ram_atr;
        private string gpu_atr;
        private string hdd_atr;
        private string cases_atr;


        private string mobo_socket_cpu;
        private string mobo_slot_ram;
        private string mobo_pci_gpu;
        private string mobo_sata_hdd;

    
        //variable untuk menampung hasil pencocokan
        private string cpu_result;
        private string ram_result;
        private string gpu_result;
        private string hdd_result;
        private string cases_result;


        //menampung id yang akan di insert ke database
        private string cpu_ins_id;
        private string ram_ins_id;
        private string gpu_ins_id;
        private string hdd_ins_id;
        private string mobo_ins_id;
        private string cases_ins_id;


        //menampung harga barang====================================================================================
        private string cpu_price;
        private string ram_price;
        private string gpu_price;
        private string hdd_price;
        private string mobo_price;
        private string cases_price;
        private int cpu_harga;
        private int ram_harga;
        private int gpu_harga;
        private int hdd_harga;
        private int mobo_harga;
        private int cases_harga;
        private int total;

        //setter getter harga barang
        public void SetCpuPrice(string cpu_price)
        {
            this.cpu_price = cpu_price;
        }
        public string GetCpuPrice()
        {
            return cpu_price;
        }
        //ram
        public void SetRamPrice(string ram_price)
        {
            this.ram_price = ram_price;
        }
        public string GetRamPrice()
        {
            return ram_price;
        }
        //gpu
        public void SetGpuPrice(string gpu_price)
        {
            this.gpu_price = gpu_price;
        }
        public string GetGpuPrice()
        {
            return gpu_price;
        }
        //mobo
        public void SetMoboPrice(string mobo_price)
        {
            this.mobo_price = mobo_price;
        }
        public string GetMoboPrice()
        {
            return mobo_price;
        }
        //hdd
        public void SetHddPrice(string hdd_price)
        {
            this.hdd_price = hdd_price;
        }
        public string GetHddPrice()
        {
            return hdd_price;
        }
        //cases
        public void SetCasesPrice(string cases_price)
        {
            this.cases_price = cases_price;
        }
        public string GetCasesPrice()
        {
            return cases_price;
        }

        public string Harga()
        {
            cpu_harga = int.Parse(cpu_price);
            ram_harga = int.Parse(ram_price);
            gpu_harga = int.Parse(gpu_price);
            hdd_harga = int.Parse(hdd_price);
            mobo_harga = int.Parse(mobo_price);
            cases_harga = int.Parse(cases_price);
            total = cpu_harga + ram_harga + gpu_harga + hdd_harga + cases_harga + mobo_harga;
            return total.ToString();
        }

        //Setter Getter  id===========================================================================
        //cpu id
        public void SetCpuInsertId(string cpu_ins_id)
        {
            this.cpu_ins_id = cpu_ins_id;
        }
        public string GetCpuInsertId()
        {
            return cpu_ins_id;
        }
        //ram id
        public void SetRamInsertId(string ram_id)
        {
            this.ram_ins_id = ram_id;
        }
        public string GetRamInsertId()
        {
            return ram_ins_id;
        }
        //gpu id
        public void SetGpuInsertId(string gpu_ins_id)
        {
            this.gpu_ins_id = gpu_ins_id;
        }
        public string GetGpuInsertId()
        {
            return gpu_ins_id;
        }
        //hdd id
        public void SetHddInsertId(string hdd_ins_id)
        {
            this.hdd_ins_id = hdd_ins_id;
        }
        public string GetHddInsertId()
        {
            return hdd_ins_id;
        }
        //mobo id
        public void SetMoboInsertId(string mobo_ins_id)
        {
            this.mobo_ins_id = mobo_ins_id;
        }
        public string GetMoboInsertId()
        {
            return mobo_ins_id;
        }

        //case id
        public void SetCasesInsertId(string cases_ins_id)
        {
            this.cases_ins_id = cases_ins_id;
        }
        public string GetCasesInsertId()
        {
            return cases_ins_id;
        }

//setter getter attribut=======================================================================================
        //
        public void SetCpuAtr(string cpu_atr)
        {
            this.cpu_atr = cpu_atr;
        }
        public string GetCpuAtr()
        {
            return cpu_atr;
        }
        //ram atr
        public void SetRamAtr(string ram_atr)
        {
            this.ram_atr = ram_atr;
        }
        public string GetRamAtr()
        {
            return ram_atr;
        }
        //gpu atr
        public void SetGpuAtr(string gpu_atr)
        {
            this.gpu_atr = gpu_atr;
        }
        public string GetGpuAtr()
        {
            return gpu_atr;
        }
        //hdd atr
        public void SetHddAtr(string hdd_atr)
        {
            this.hdd_atr = hdd_atr;
        }
        public string GetHddAtr()
        {
            return hdd_atr;
        }

        //case atr
        public void SetCasesAtr(string cases_atr)
        {
            this.cases_atr = cases_atr;
        }
        public string GetCasesAtr()
        {
            return cases_atr;
        }

//Setter Getter Mobo===============================================================================
        //cpu
        public void SetMoboSocket(string mobo_socket_cpu)
        {
            this.mobo_socket_cpu = mobo_socket_cpu;
        }
        public string GetMoboSocket()
        {
            return mobo_socket_cpu;
        }
        //ram
        public void SetMoboSlot(string mobo_slot_ram)
        {
            this.mobo_slot_ram = mobo_slot_ram;
        }
        public string GetMoboSlot()
        {
            return mobo_slot_ram;
        }
        //gpu
        public void SetMoboPci(string mobo_pci_gpu)
        {
            this.mobo_pci_gpu = mobo_pci_gpu;
        }
        public string GetMoboPci()
        {
            return mobo_pci_gpu;
        }

        //hdd
        public void SetMoboSata(string mobo_sata_hdd)
        {
            this.mobo_sata_hdd = mobo_sata_hdd;
        }
        public string GetMoboSata()
        {
            return mobo_sata_hdd;
        }
//Setter getter result=============================================================================
        public void SetCpuResult(string cpu_result)
        {
            this.cpu_result = cpu_result;
        }
        public string GetCpuResult()
        {
            return cpu_result;
        }
        //ram id
        public void SetRamResult(string ram_result)
        {
            this.ram_result = ram_result;
        }
        public string GetRamResult()
        {
            return ram_result;
        }
        //gpu id
        public void SetGpuResult(string gpu_result)
        {
            this.gpu_result = gpu_result;
        }
        public string GetGpuResult()
        {
            return gpu_result;
        }
        //hdd id
        public void SetHddResult(string hdd_result)
        {
            this.hdd_result = hdd_result;
        }
        public string GetHddResult()
        {
            return hdd_result;
        }

        //case id
        public void SetCasesResult(string cases_result)
        {
            this.cases_result = cases_result;
        }
        public string GetCasesResult()
        {
            return cases_result;
        }      

//query============================================================================================
        public string SelectItem(string kolom, string tabel, string id)
        {
            query = "SELECT " + kolom + " from " + tabel + " where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil = reader.GetString(0);
            }
            sqlConn.Close();
            return hasil;
        }
        public string WriteItem(string idbuild, string idcpu, string idram, string idgpu, string idhdd, string idcases, string idpsu, string idmobo, string username)
        {
            query = "INSERT INTO build VALUES ('" + idbuild + "','" + idcpu + "','" + idmobo + "','" + idram + "','" + idgpu + "','" + idhdd + "','" + idcases + "','" + idpsu + "','" + username + "')";
            sqlConn.Open();
            sqlConn.Open();
            MySqlCommand Cmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader regread;
            regread = Cmd.ExecuteReader();
            return hasil;
        }

//Ambil atribut dari database untuk dicocokan==================================================
        public string GetAtrCpu(string id)
        {
            query = "SELECT soket from cpu where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cpu_atr = reader.GetString(0);
            }
            sqlConn.Close();
            return cpu_atr;
        }

        public string GetAtrRam(string id)
        {
            query = "SELECT tipe from ram where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ram_atr = reader.GetString(0);
            }
            sqlConn.Close();
            return ram_atr;
        }

        public string GetAtrGpu(string id)
        {
            query = "SELECT tipe from gpu where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                gpu_atr = reader.GetString(0);
            }
            sqlConn.Close();
            return gpu_atr;
        }

        public string GetAtrHdd(string id)
        {
            query = "SELECT tipe from hdd where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hdd_atr = reader.GetString(0);
            }
            sqlConn.Close();
            return hdd_atr;
        }

    


//ambil atribut motherboard======================================================
        public string GetAtrMoboSocket(string id)
        {
            query = "SELECT soket from mobo where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mobo_socket_cpu = reader.GetString(0);
            }
            sqlConn.Close();
            return mobo_socket_cpu;
        }

        public string GetAtrMoboSlot(string id)
        {
            query = "SELECT slot from mobo where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mobo_slot_ram = reader.GetString(0);
            }
            sqlConn.Close();
            return mobo_slot_ram;
        }

        public string GetAtrMoboPci(string id)
        {
            query = "SELECT pci from mobo where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mobo_pci_gpu = reader.GetString(0);
            }
            sqlConn.Close();
            return mobo_pci_gpu;
        }

        public string GetAtrMoboSata(string id)
        {
            query = "SELECT storage from mobo where id = '" + id + "'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mobo_sata_hdd = reader.GetString(0);
            }
            sqlConn.Close();
            return mobo_sata_hdd;
        }
//

//mencocokan data==================================================================================
        public string MatchCpu()
        {
            if (cpu_atr == mobo_socket_cpu)
            {
                SetCpuResult("Compatible");
            }
            else
            {
                SetCpuResult("Not Compatible");
            }
            return cpu_result;
        }
        public string MatchRam()
        {
            if (ram_atr == mobo_slot_ram)
            {
                SetRamResult("Compatible");
            }
            else
            {
                SetRamResult("Not Compatible");
            }
            return ram_result;
        }

        public string MatchGpu()
        {
            if (gpu_atr == mobo_pci_gpu)
            {
                SetGpuResult("Compatible");
            }
            else
            {
                SetGpuResult("Not Compatible");
            }
            return gpu_result;
        }

        public string MatchHdd()
        {
            if (hdd_atr == mobo_sata_hdd)
            {
                SetHddResult("Compatible");
            }
            else
            {
                SetHddResult("Not Compatible");
            }
            return hdd_result;
        } 

        //insert data ke database
        public string InsertBuild(string usr)
        {
            GetMaxId();
            int intmaxid;
            bool res = int.TryParse(maxid, out intmaxid);
            intmaxid++;
            query = "INSERT INTO build VALUES ('"+intmaxid+"','"+cpu_ins_id+"','"+mobo_ins_id+"','"+ram_ins_id+"','"+gpu_ins_id+"','"+hdd_ins_id+"','"+cases_ins_id+"','"+usr+"','"+total+"')";
            sqlConn.Open();
            MySqlCommand Cmd = new MySqlCommand(query, sqlConn);
            MySqlDataReader regread;
            regread = Cmd.ExecuteReader();
            sqlConn.Close();
            return hasil;
        }
        public string GetMaxId()
        {
            query = "SELECT MAX(id_build) FROM build";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                maxid = reader.GetString(0);
            }
            sqlConn.Close();
            return maxid;
        }

    }
}
