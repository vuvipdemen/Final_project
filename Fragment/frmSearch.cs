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
    public partial class fr_TK : Form
    {
        public fr_TK()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();  
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT IdProduct, NameProduct, IdSector, IdUnit, Quantity, PriceI, PriceS, Warranty FROM db_Product";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
          
            if (op2.Checked)
            {
                string sql = @"SELECT IdProduct, NameProduct, IdSector, IdUnit, Quantity, PriceI, PriceS, Warranty FROM db_Product WHERE IdSector= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT IdProduct, NameProduct, IdSector, IdUnit, Quantity, PriceI, PriceS,Warranty  FROM db_Product where Warranty like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }

        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "ID Product";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Name Product";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "ID Sector";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "ID Unit";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "ID Quantily";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Import Unit Price";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Sell Unit Price";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Warranty period";
            msds.Columns[7].Width = 100;
        }
        public void hienthi()
        {
            string sql = "SELECT IdProduct, NameProduct, IdSector, IdUnit, Quantity, PriceI, PriceS, Warranty FROM db_Product";
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

        private void fr_TK_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
