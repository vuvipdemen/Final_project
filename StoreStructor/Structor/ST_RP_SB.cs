using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using StoreManager.DataBase;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.StoreStructor.Strutor
{
    class ST_RP_SB
    {
        SQL_RP_SB cthdbsql = new SQL_RP_SB();
        public void themoicthdb(EC_RP_SB cthdb)
        {
            if (!cthdbsql.kiemtracthdb(cthdb.IDSB, cthdb.IDPRODUCT))
            {
                cthdbsql.addcthdb(cthdb);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdb(EC_RP_SB cthdb)
        {
            cthdbsql.suacthdb(cthdb);
        }
        public void xoacthdb(EC_RP_SB cthdb)
        {
            cthdbsql.xoacthdb(cthdb);
        }
        //load hóa đơn
        public void loadmahd(ComboBox cbhd)
        {
            cthdbsql.loadmahd(cbhd);
        }
        //load hóa đơn
        public void loadmasp(ComboBox cbsp)
        {
            cthdbsql.loadmasp(cbsp);
        }
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdbsql.LoadNameProduct(Tensp, Masp);
            return Tensp;
        }

        public string loaddg(string dg, string Masp)
        {
            dg = cthdbsql.Loaddgb(dg, Masp);
            return dg;
        }
    }
}
