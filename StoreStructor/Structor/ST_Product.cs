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
    class ST_Product
    {
        SQL_Product spsql = new SQL_Product();
        public void themoisp(EC_Product sp)
        {
            if (!spsql.kiemtrasp(sp.IDPRODUCT))
            {
                spsql.addsp(sp);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suasp(EC_Product sp)
        {
            spsql.suasp(sp);
        }
        public void xoasp(EC_Product sp)
        {
            spsql.xoasp(sp);
        }

        //load loại
        public void loadmal(ComboBox cbl)
        {
            spsql.loadmal(cbl);
        }
        public string loadtenl(string Tenl, string Mal)
        {
            Tenl = spsql.LoadNameSector(Tenl, Mal);
            return Tenl;
        }
        //load dvt
        public void loadmadv(ComboBox cbdv)
        {
            spsql.loadmadv(cbdv);
        }
        public string loadtendv(string Tendv, string Madv)
        {
            Tendv = spsql.Loadtendv(Tendv, Madv);
            return Tendv;
        }

    }
}
