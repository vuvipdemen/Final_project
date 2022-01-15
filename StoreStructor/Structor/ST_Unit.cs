using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.DataBase;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.StoreStructor.Strutor
{
    class ST_Unit
    {
        SQL_Unit Lsql = new SQL_Unit();
        public void themoil(EC_Unit l)
        {
            if (!Lsql.kiemtral(l.IDUNIT))
            {
                Lsql.addl(l);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_Unit l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_Unit l)
        {
            Lsql.xoal(l);
        }
    }
}
