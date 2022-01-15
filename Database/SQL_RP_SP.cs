using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
    class SQL_RP_SB
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtracthdb(string shdb, string masp)
        {
            return cn.kiemtra("select count(*) from [db_rp_SB] where IdSB=N'" + shdb + "' and IdProduct=N'" + masp + "' ");
        }
        public void addcthdb(EC_RP_SB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO db_rp_SB
                      (IdSB, IdProduct, Quantity, TotalMoney) VALUES   (N'" + cthdb.IDSB + "',N'" + cthdb.IDPRODUCT + "',N'" + cthdb.QUANTITY + "',N'" + cthdb.TOTALMONEY + "')");
        }
        public void xoacthdb(EC_RP_SB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [db_rp_SB] WHERE  IdSB=N'" + cthdb.IDSB + "' and IdProduct=N'" + cthdb.IDPRODUCT + "' ");
        }

        public void suacthdb(EC_RP_SB cthdb)
        {
            string sql = (@"UPDATE db_rp_SB
            SET Quantity =N'" + cthdb.QUANTITY + "', TotalMoney = N'" + cthdb.TOTALMONEY + "' where  IdSB=N'" + cthdb.IDSB + "' and masp=N'" + cthdb.IDPRODUCT + "'");
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
        public void loadmahd(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT     IdSB FROM db_SB", 0);
        }
        //load đơn giá bán
        public string Loaddgb(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [PriceS] From [db_Product] where IdProduct= N'" + masp + "'");
            return dg;
        }
    }
}
