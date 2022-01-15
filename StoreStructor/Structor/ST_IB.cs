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
    class ST_IB
    {
        SQL_IB hdnsql = new SQL_IB();
        public void themoihdn(EC_IB hdn)
        {
            if (!hdnsql.kiemtraHDN(hdn.IDIB))
            {
                hdnsql.addHDN(hdn);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdn(EC_IB hdn)
        {
            hdnsql.suaHDN(hdn);
        }
        public void xoahdn(EC_IB hdn)
        {
            hdnsql.xoaHDN(hdn);
        }
        //load nv
        public void loadIdStaff(ComboBox cbnv)
        {
            hdnsql.loadIdStaff(cbnv);
        }
        public string loadtenl(string NameStaff, string IdStaff)
        {
            NameStaff = hdnsql.LoadNameStaff(NameStaff, IdStaff);
            return NameStaff;
        }
        //load khách
        public void loadIdSupplier(ComboBox cbncc)
        {
            hdnsql.loadIdSupplier(cbncc);
        }
        public string loadNameSupplier(string NameSupplier, string IdSupplier)
        {
            NameSupplier = hdnsql.LoadNameSupplier(NameSupplier, IdSupplier);
            return NameSupplier;
        }
    }
}
