using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.DataBase;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.StoreStructor.Strutor
{
    class ST_User
    {
        EC_User ck = new EC_User();
        SQL_User sql = new SQL_User();
        public bool kiemtrauser(string user, string pass)
        {
            ck.USERNAME = user;
            ck.PASSWORD = pass;
            return sql.Kiemtrauser(ck);
        }
    }
}
