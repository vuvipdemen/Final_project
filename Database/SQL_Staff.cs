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
    class SQL_Staff
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtranv(string IdStaff)
        {
            return cn.kiemtra("select count(*) from [db_Staff] where IdStaff=N'" + IdStaff + "'");
        }
        public void addnv(EC_Staff nv)
        {
            string sql = @"INSERT INTO db_Staff
                      (IdStaff, NameStaff, Gender, DoB, MobilePhone, Address)
                        VALUES   (N'" + nv.IDSTAFF + "',N'" + nv.NAMESTAFF + "',N'" + nv.GENDER + "',N'" + nv.DOB + "',N'" + nv.MOBILEPHONE + "',N'" + nv.ADDRESS + "')";
            cn.ExcuteNonQuery(sql);
        }
        public void xoanv(EC_Staff nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_Staff] WHERE IdStaff=N'" + nv.IDSTAFF + "'");
        }

        public void suanv(EC_Staff nv)
        {
            string sql = (@"UPDATE    db_Staff
                    SET NameStaff =N'" + nv.NAMESTAFF + "', Gender =N'" + nv.GENDER + "', DoB =N'" + nv.DOB + "', MobilePhone =N'" + nv.MOBILEPHONE + "', Address =N'" + nv.ADDRESS + "'");
            cn.ExcuteNonQuery(sql);
        }

    }
}
