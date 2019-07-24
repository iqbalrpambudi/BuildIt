using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Build_it.Controller
{
    class UserDataController
    {
        private View.UserWindow viewUser;
        private Model.UserPageModel modelUser;

        public UserDataController(View.UserWindow viewUser)
        {
            this.viewUser = viewUser;
            modelUser = new Model.UserPageModel();
        }

        public void ShowItem(string username)
        {
            DataSet data = modelUser.ShowItem(username);
            //viewUser.dgItem.ItemsSource = data.Tables[0].DefaultView;
            viewUser.dgvItem.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
