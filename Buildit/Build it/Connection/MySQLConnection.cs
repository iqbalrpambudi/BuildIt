using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Build_it.Connection
{
    class MySQLConnection
    {

        public static MySqlConnection GetConn()
        {
            string strKoneksi = "SERVER = 127.0.0.1; PORT = 3306; UID = root; PWD = ; DATABASE = build_it";
            return new MySqlConnection(strKoneksi);
        }
    }
}
