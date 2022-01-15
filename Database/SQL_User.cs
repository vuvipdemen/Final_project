using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.EC;
using StoreManager.StoreStructor.Strutor;

namespace StoreManager.DataBase
{
    class SQL_User
    {
        ConnectDB cn = new ConnectDB();

        public bool Kiemtrauser(EC_User user)
        {
            string sql = "select count(*) from tb_User where Username ='" + user.USERNAME + "' and Password = '" + user.PASSWORD + "'";
            return cn.KiemtraUsername(sql);
        }
    }
}
