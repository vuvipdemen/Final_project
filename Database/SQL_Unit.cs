using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.EC;
using StoreManager.StoreStructor.Strutor;

namespace StoreManager.DataBase
{
    class SQL_Unit
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [db_Unit] where IdUnit=N'" + loai + "'");
        }
        public void addl(EC_Unit l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_Unit
                      (IdUnit, NameUnit) VALUES   (N'" + l.IDUNIT + "',N'" + l.NAMEUNIT + "')");
        }
        public void xoal(EC_Unit l)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_Unit] WHERE [IdUnit] = N'" + l.IDUNIT + "'");
        }

        public void sual(EC_Unit l)
        {
            string sql = (@"UPDATE db_Unit
            SET NameUnit =N'" + l.NAMEUNIT + "' where  IdUnit =N'" + l.IDUNIT + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
