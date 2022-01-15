using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
    class SQL_IB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtraHDN(string mahdn)
        {
            return cn.kiemtra("select count(*) from [db_IB] where IdIB=N'" + mahdn + "'");
        }
        public void addHDN(EC_IB hdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_IB
                      (IdIB, IdStaff,DateAdd,IdSupplier,tongtien) VALUES   (N'" + hdn.IDIB + "',N'" + hdn.IDStaff + "',N'" + hdn.NGAYNHAN + "',N'" + hdn.IDSupplier + "',N'" + hdn.TONGTIEN + "')");
        }
        public void xoaHDN(EC_IB hdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_IB] WHERE [IdIB] = N'" + hdn.IDIB + "'");
        }

        public void suaHDN(EC_IB hdn)
        {
            string sql = (@"UPDATE db_IB
            SET IdStaff =N'" + hdn.IDStaff + "',DateAdd =N'" + hdn.NGAYNHAN + "',IdSupplier =N'" + hdn.IDSupplier + "' where  IdIB =N'" + hdn.IDIB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void loadIdStaff(ComboBox IdStaff)
        {
            cn.LoadLenCombobox(IdStaff, "SELECT IdStaff FROM db_Staff", 0);
        }
        public string LoadNameStaff(string NameStaff, string IdStaff)
        {
            NameStaff = cn.LoadLable("SELECT [NameStaff] From [db_Staff] where IdStaff= N'" + IdStaff + "'");
            return NameStaff;
        }
        //load mã nhà cung cấp
        public void loadIdSupplier(ComboBox macc)
        {
            cn.LoadLenCombobox(macc, "SELECT     IdSupplier FROM db_Supplier", 0);
        }
        public string LoadNameSupplier(string tencc, string macc)
        {
            tencc = cn.LoadLable("SELECT [NameSupplier] From [db_Supplier] where IdSupplier= N'" + macc + "'");
            return tencc;
        }
    }
}
