using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
    class SQL_RP_IB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdn(string shdn, string masp)
        {
            return cn.kiemtra("select count(*) from [db_rp_IB] where IdIB=N'" + shdn + "' and IdProduct=N'" + masp + "' ");
        }
        public void addcthdn(EC_RP_IB cthdn)
        {
            string sql = (@"INSERT INTO db_rp_IB
                      (IdIB, IdProduct, Quantity, UnitPrice, TotalMoney) VALUES   (N'" + cthdn.IDIB + "',N'" + cthdn.IDPRODUCT + "',N'" + cthdn.QUANTITY + "',N'" + cthdn.UNITPRICE + "',N'" + cthdn.TOTALMONEY + "')");
            cn.ExcuteNonQuery(sql);
        }
        public void xoacthdn(EC_RP_IB cthdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_rp_IB] WHERE IdIB=N'" + cthdn.IDIB + "' and IdProduct=N'" + cthdn.IDPRODUCT + "' ");
        }

        public void suacthdn(EC_RP_IB cthdn)
        {
            string sql = (@"UPDATE db_rp_IB
            SET Quantity =N'" + cthdn.QUANTITY + "', UnitPrice = N'" + cthdn.UNITPRICE + "', TotalMoney = N'" + cthdn.TOTALMONEY + "' where IdIB=N'" + cthdn.IDIB + "' and IdProduct=N'" + cthdn.IDPRODUCT + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void loadmasp(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT     IdProduct FROM db_Product", 0);
        }
        public string LoadNameProduct(string tensp, string masp)
        {
            tensp = cn.LoadLable("SELECT [NameProduct] From [db_Product] where IdProduct= N'" + masp + "'");
            return tensp;
        }
        //load THD
        public void loadmahdn(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     IdIB FROM db_IB", 0);
        }
    }
}
