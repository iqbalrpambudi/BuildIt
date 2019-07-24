using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Build_it.Model
{
    class UserPageModel
    {
        private MySqlConnection sqlConn;
        private MySqlCommand command;
        //private MySqlCommand command;
        string CMDString;

        public UserPageModel()
        {
            sqlConn = Connection.MySQLConnection.GetConn();
        }

        public DataSet ShowItem(string username)
        {
            DataSet ds = new DataSet();
            try
            {
                sqlConn.Open();
                command = new MySqlCommand();
                command.Connection = sqlConn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT build.id_build, cpu.nama as CPU,ram.nama as RAM,gpu.nama as GPU,mobo.nama as MOTHERBOARD,hdd.nama as HDD,cases.nama as CASES, build.harga as HARGA from build join cpu on build.id_cpu=cpu.id join ram on build.id_ram=ram.id join gpu on build.id_gpu=gpu.id join mobo on build.id_mobo=mobo.id join hdd on build.id_hdd=hdd.id join cases on build.id_cases=cases.id where build.username='" + username + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(command);
                sda.Fill(ds,"staff");
                sqlConn.Close();
            }
            catch (MySqlException)
            {
        
            }
            return ds;
        }
    }
}
