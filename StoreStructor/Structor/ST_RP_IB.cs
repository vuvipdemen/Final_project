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
    class ST_RP_IB
    {
        SQL_RP_IB cthdnsql = new SQL_RP_IB();
        public void themoicthdn(EC_RP_IB cthdn)
        {
            if (!cthdnsql.kiemtracthdn(cthdn.IDIB, cthdn.IDPRODUCT))
            {
                cthdnsql.addcthdn(cthdn);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suacthdn(EC_RP_IB cthdn)
        {
            cthdnsql.suacthdn(cthdn);
        }
        public void xoacthdn(EC_RP_IB cthdn)
        {
            cthdnsql.xoacthdn(cthdn);
        }
        //load hóa đơn
        public void loadmahd(ComboBox cbhd)
        {
            cthdnsql.loadmahdn(cbhd);
        }
        //load hóa đơn
        public void loadmasp(ComboBox cbsp)
        {
            cthdnsql.loadmasp(cbsp);
        }
        public string loadtensp(string Tensp, string Masp)
        {
            Tensp = cthdnsql.LoadNameProduct(Tensp, Masp);
            return Tensp;
        }
    }
}
