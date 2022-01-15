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
    class ST_Staff
    {
        SQL_Staff nvsql = new SQL_Staff();
        public void themoinv(EC_Staff nv)
        {
            if (!nvsql.kiemtranv(nv.IDSTAFF))
            {
                nvsql.addnv(nv);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_Staff nv)
        {
            nvsql.suanv(nv);
        }
        public void xoanv(EC_Staff nv)
        {
            nvsql.xoanv(nv);
        }
    }
}
