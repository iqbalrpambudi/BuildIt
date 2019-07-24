using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Build_it.Model
{
    class CompareModel
    {
        private MySqlConnection sqlConn;

        private string query;
        public string hasil;
        public string hasil1;
        public string hasil2;
        public string hasil3;
        public string hasil4;

        public CompareModel()
        {
            sqlConn = Connection.MySQLConnection.GetConn();
        }

        public string Compare(string kolom,string tabel,string id)
        {
            query = "SELECT "+kolom+" from "+tabel+" where id = '"+id+"'";
            //query = "SELECT url from case where id = '01'";
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

        //ambil data dari database
        public string GetDataCpu(string id)
        {
            query = "SELECT nama,vendor,soket,harga from cpu where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
                hasil4 = reader.GetString(3);
            }
            sqlConn.Close();
            return hasil;
        }
        public string GetDataRam(string id)
        {
            query = "SELECT kapasitas,vendor,tipe,harga from ram where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
                hasil4 = reader.GetString(3);
            }
            sqlConn.Close();
            return hasil;
        }
        public string GetDataGpu(string id)
        {
            query = "SELECT nama,vendor,tipe,harga from gpu where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
                hasil4 = reader.GetString(3);
            }
            sqlConn.Close();
            return hasil;
        }
        public string GetDataMobo(string id)
        {
            query = "SELECT soket,vendor,slot,harga from mobo where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
                hasil4 = reader.GetString(3);
            }
            sqlConn.Close();
            return hasil;
        }
        public string GetDataHdd(string id)
        {
            query = "SELECT nama,vendor,kapasitas,harga from hdd where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
            }
            sqlConn.Close();
            return hasil;
        }
        public string GetDataCases(string id)
        {
            query = "SELECT nama,vendor,harga from cases where id = '" + id + "'";
            //query = "SELECT url from case where id = '01'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hasil1 = reader.GetString(0);
                hasil2 = reader.GetString(1);
                hasil3 = reader.GetString(2);
            }
            sqlConn.Close();
            return hasil;
        }
    }
}
