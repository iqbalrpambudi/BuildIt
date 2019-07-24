using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Build_it.Model
{
    class ComponentModel
    {
        private MySqlConnection sqlConn;

        private string query;
        public string hasil;
        public string selectitem;

        public string GetSelectedItem()
        {
            return selectitem;
        }

        public void SetSelectItem(string selectitem)
        {
            this.selectitem = selectitem;
        }

        //koneksi ke database
        public ComponentModel()
        {
            sqlConn = Connection.MySQLConnection.GetConn();
        }

        public string Component(string kolom,string tabel,string id)
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


    }
}
