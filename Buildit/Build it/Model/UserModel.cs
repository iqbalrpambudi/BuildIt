using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Build_it.Model
{
    class UserModel
    {
        //deklarasi objek koneksi
        private MySqlConnection sqlConn;

        //deklarasi variabel
        private string query;
        private bool hasil;
        private string register;
       
        //koneksi ke database
        public UserModel()
        {
            sqlConn = Connection.MySQLConnection.GetConn();
        }

        //enkapsulasi
        private string username;
        private string password;
        private string nama;
        private string email;

        //get &set
        public string GetUsername()                  { return username;           }
        public void SetUsername(string username)     { this.username = username;  }

        public string GetPassword()                  { return password;           }
        public void SetPassword(string password)     { this.password = password;  }

        public string GetNama()                      { return nama;               }
        public void SetNama(string nama)             { this.nama = nama;          }

        public string GetEmail()                     { return email;              }
        public void SetEmail(string email)           { this.email = email;        }

        //validasi login
        public bool Login(string id,string pwd)
        {
            query = "SELECT username,password,email from login where username = '"+id+"' AND password = '"+pwd+"'";
            sqlConn.Open();
            MySqlCommand command = sqlConn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                if ((reader.GetString(0) == id) && (reader.GetString(1) == pwd))
                {
                    hasil = true;
                    Controller.LoginController.SetNama(reader.GetString(0).ToString());
                    Controller.LoginController.SetEmail(reader.GetString(2).ToString());
                }
                else
                {
                    hasil = false;
                }
            }            
            sqlConn.Close();
            return hasil;
        }

        //register user baru
        public string Register(string id, string pwd,string nm,string em)
        {
            string regQuery = "INSERT INTO login (username,password,nama,email) values ('"+id+ "','" +pwd+ "','" +nm+ "','" +em+ "');";
            sqlConn.Open();
            MySqlCommand Cmd = new MySqlCommand(regQuery, sqlConn);
           MySqlDataReader regread;
            regread = Cmd.ExecuteReader();
            sqlConn.Close();
            return register;
       }
    }
}
