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
    class ST_Sector
    {
        SQL_Sector khsql = new SQL_Sector();
        public void themoikh(EC_Sector kh)
        {
            if (!khsql.kiemtral(kh.IDSECTOR))
            {
                khsql.addl(kh);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakh(EC_Sector kh)
        {
            khsql.sual(kh);
        }
        public void xoakh(EC_Sector kh)
        {
            khsql.xoal(kh);
        }
    }
}
