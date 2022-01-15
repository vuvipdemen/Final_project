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
    class SQL_Supplier
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrancc(string IdSupplier)
        {
            return cn.kiemtra("select count(*) from [db_Supplier] where IdSupplier=N'" + IdSupplier + "'");
        }
        public void addncc(EC_Supplier ncc)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_Supplier
                      (IdSupplier, NameSupplier, Address,MobilePhone) VALUES   (N'" + ncc.IDSUPPLIER + "',N'" + ncc.NAMESUPPLIER + "',N'" + ncc.ADDRESS + "',N'" + ncc.MOBILEPHONE + "')");
        }
        public void xoancc(EC_Supplier ncc)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_Supplier] WHERE IdSupplier=N'" + ncc.IDSUPPLIER + "'");
        }

        public void suancc(EC_Supplier ncc)
        {
            string sql = (@"UPDATE    db_Supplier
            SET NameSupplier =N'" + ncc.NAMESUPPLIER + "', Address =N'" + ncc.ADDRESS + "', MobilePhone =N'" + ncc.MOBILEPHONE + "' where IdSupplier=N'" + ncc.IDSUPPLIER + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
