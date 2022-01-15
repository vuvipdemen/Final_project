using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
    class SQL_Sector
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [db_Sector] where IdSector=N'" + loai + "'");
        }
        public void addl(EC_Sector l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_Sector
                      (IdSector, NameSector) VALUES   (N'" + l.IDSECTOR + "',N'" + l.NAMESECTOR + "')");
        }
        public void xoal(EC_Sector l)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_Sector] WHERE [IdSector] = N'" + l.IDSECTOR + "'");
        }

        public void sual(EC_Sector l)
        {
            string sql = (@"UPDATE db_Sector
            SET NameSector =N'" + l.NAMESECTOR + "'' where  IdSector =N'" + l.IDSECTOR + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
