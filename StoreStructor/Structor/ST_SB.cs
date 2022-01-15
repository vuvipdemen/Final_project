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
    class ST_SB
    {
        SQL_SB hdbsql = new SQL_SB();
        public void themoihdb(EC_SB hdb)
        {
            if (!hdbsql.kiemtraHDB(hdb.IDSB))
            {
                hdbsql.addHDB(hdb);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suahdb(EC_SB hdb)
        {
            hdbsql.suaHDB(hdb);
        }
        public void xoahdb(EC_SB hdb)
        {
            hdbsql.xoaHDB(hdb);
        }
        //load nv
        public void loadIdStaff(ComboBox cbnv)
        {
            hdbsql.loadIdStaff(cbnv);
        }
        public string loadNameStaff(string NameStaff, string IdStaff)
        {
            NameStaff = hdbsql.LoadNameStaff(NameStaff, IdStaff);
            return NameStaff;
        }
        //load khách
        public void loadIdCustomer(ComboBox cbkh)
        {
            hdbsql.loadIdCustomerach(cbkh);
        }
        public string loadNameCustomer(string Tenk, string Mak)
        {
            Tenk = hdbsql.LoadNameCustomerach(Tenk, Mak);
            return Tenk;
        }
    }
}
