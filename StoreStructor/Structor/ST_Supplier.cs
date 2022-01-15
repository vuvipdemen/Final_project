using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.DataBase;
using System.Windows.Forms;
using StoreManager.StoreStructor.EC;

namespace StoreManager.StoreStructor.Strutor
{
    class ST_Supplier
    {
        SQL_Supplier nccsql = new SQL_Supplier();
        public void themoincc(EC_Supplier ncc)
        {
            if (!nccsql.kiemtrancc(ncc.IDSUPPLIER))
            {
                nccsql.addncc(ncc);
            }
            else
            {
                MessageBox.Show("This code already exists, please choose another code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suancc(EC_Supplier ncc)
        {
            nccsql.suancc(ncc);
        }
        public void xoancc(EC_Supplier ncc)
        {
            nccsql.xoancc(ncc);
        }
    }
}
