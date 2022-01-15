using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoreManager.DataBase;
using System.Data.SqlClient;

namespace StoreManager.Presentation
{
    public partial class fr_TKHDN : Form
    {
        public fr_TKHDN()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     db_IB.IdIB, db_IB.IdStaff, db_IB.DateAdd, db_IB.IdSupplier, db_IB.tongtien
FROM         db_IB INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     db_IB.IdIB, db_IB.IdStaff, db_IB.DateAdd, db_IB.IdSupplier, db_IB.tongtien
FROM         db_IB INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB WHERE db_rp_IB.IdProduct= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     db_IB.IdIB, db_IB.IdStaff, db_IB.DateAdd, db_IB.IdSupplier, db_IB.tongtien
FROM         db_IB INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB WHERE db_IB.DateAdd  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     db_IB.IdIB, db_IB.IdStaff, db_IB.DateAdd, db_IB.IdSupplier, db_IB.tongtien
FROM         db_IB INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB WHERE db_IB.IdSupplier= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "ID BIll";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Staff";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Date Add";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Supplier";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Total Money";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = @"SELECT     db_IB.IdIB, db_IB.IdStaff, db_IB.DateAdd, db_IB.IdSupplier, db_IB.tongtien
FROM         db_IB INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void fr_TKHDN_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
