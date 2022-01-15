using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
    class SQL_SB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [db_SB] where IdSB=N'" + mahdb + "'");
        }
        public void addHDB(EC_SB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_SB
                      (IdSB, IdStaff, DateSale, IdCustomer, tongtien) VALUES   (N'" + hdb.IDSB + "',N'" + hdb.IDSTAFF + "',N'" + hdb.DATESALE + "',N'" + hdb.IDCUSTOMER + "',N'" + hdb.TONGTIEN + "')");
        }
        public void xoaHDB(EC_SB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_SB] WHERE [IdSB] = N'" + hdb.IDSB + "'");
        }

        public void suaHDB(EC_SB hdb)
        {
            string sql = (@"UPDATE db_SB
            SET IdSB =N'" + hdb.IDSTAFF + "',DateSale =N'" + hdb.DATESALE + "',tongtien =N'" + hdb.TONGTIEN + "',IdCustomer =N'" + hdb.IDCUSTOMER + "' where  mahdb =N'" + hdb.IDSB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadIdStaff(ComboBox IdStaff)
        {
            cn.LoadLenCombobox(IdStaff, "SELECT     IdStaff FROM db_Staff", 0);
        }
        public string LoadNameStaff(string NameStaff, string IdStaff)
        {
            NameStaff = cn.LoadLable("SELECT [NameStaff] From [db_Staff] where IdStaff= N'" + IdStaff + "'");
            return NameStaff;
        }
        //load mã khách hàng
        public void loadIdCustomerach(ComboBox mak)
        {
            cn.LoadLenCombobox(mak, "SELECT  IdCustomer FROM db_Customer", 0);
        }
        public string LoadNameCustomerach(string tenk, string mak)
        {
            tenk = cn.LoadLable("SELECT [NameCustomer] From [db_Customer] where IdCustomer= N'" + mak + "'");
            return tenk;
        }
    }
}
