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
    class SQL_Customer
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtrakh(string idcustomer)
        {
            return cn.kiemtra("select count(*) from [db_Customer] where Idcustomer=N'" + idcustomer + "'");
        }
        public void addkh(EC_Customer kh)
        {
            string str=(@"INSERT INTO db_Customer ( IdCustomer, NameCustomer, Address, MobilePhone) VALUES   (N'" + kh.IDCustomer + "',N'" + kh.NAMECUSTOMER + "',N'" + kh.ADDRESS + "',N'" + kh.MOBILEPHONE + "')");
            cn.ExcuteNonQuery(str);

        }
        public void xoakh(EC_Customer ct)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_Customer] WHERE  Idcustomer=N'" + ct.IDCustomer + "'");
        }

        public void suakh(EC_Customer ct)
        {
            string sql = (@"UPDATE    db_Customer
                    SET NameCustomer =N'" + ct.NAMECUSTOMER + "', Address =N'" + ct.ADDRESS + "', MobilePhone =N'" + ct.MOBILEPHONE + "' where Idcustomer=N'" + ct.IDCustomer + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
