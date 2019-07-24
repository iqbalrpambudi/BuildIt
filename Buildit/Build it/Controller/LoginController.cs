using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_it.Controller
{
    class LoginController
    {

        //variable static untuk menyimpan username
        private static String nama;
        private static String email;

        public static void SetNama(String nama)
        {
            LoginController.nama = nama;
        }
        public static String GetNama()
        {
            return nama;
        }
        public static void SetEmail(String email)
        {
            LoginController.email = email;
        }

        public static String GetEmail()
        {
            return email;
        }

        //deklarasi objek dari view dan model
        private Model.UserModel user;
        private View.Login.MainLoginPage viewLogin;

        //instance
        public LoginController(View.Login.MainLoginPage view)
        {
            viewLogin = view;
            user = new Model.UserModel();

        }

        public bool LoginUser()
        {
            bool hasil = user.Login(viewLogin.txtUsername.Text, viewLogin.txtPassword.Text);
            return hasil;
        }
    }
}
