using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.DataBase;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.StoreStructor.Strutor
{
    class ST_Customer
    {
        SQL_Customer khsql = new SQL_Customer();
        public void themoikh(EC_Customer kh)
        {
            if (!khsql.kiemtrakh(kh.IDCustomer))
            {
                khsql.addkh(kh);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakh(EC_Customer kh)
        {
            khsql.suakh(kh);
        }
        public void xoakh(EC_Customer kh)
        {
            khsql.xoakh(kh);
        }
    }
}
