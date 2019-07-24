using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_it.Controller
{
    class RegisterController
    {
        //deklarasi objek dari view dan model
        private Model.UserModel user;
        private View.Login.RegisterPage viewLogin;

        //instance
        public RegisterController(View.Login.RegisterPage view)
        {
            viewLogin = view;
            user = new Model.UserModel();
        }

        public string Register()
        {
            string register = user.Register(viewLogin.regUsername.Text, viewLogin.regPassword.Text, viewLogin.regName.Text, viewLogin.regEmail.Text);
            return register;
        }
    }
}
