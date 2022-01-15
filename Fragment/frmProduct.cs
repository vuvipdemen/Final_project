using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreManager.DataBase;
using System.IO;
using StoreManager.StoreStructor.Strutor;
using StoreManager.StoreStructor.EC;

namespace StoreManager.Presentation
{
    public partial class fr_Hanghoa : Form
    {
        public fr_Hanghoa()
        {
            InitializeComponent();
        }
        ST_Product thucthi = new ST_Product();
        ConnectDB cn = new ConnectDB();
        EC_Product ck = new EC_Product();
        bool add;
        int dong = 0;


        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtsl.Text = "0";

            cbdvt.Text = "";
            cbl.Text = "";

        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbdvt.Enabled = false;
            cbl.Enabled = false;
  

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbdvt.Enabled = true;
            cbl.Enabled = true;


            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
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

            msds.Columns[4].HeaderText = "Quantity";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Import Unit Price";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Sale Unit Price";
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
        private void btmoi_Click(object sender, EventArgs e)
        {
            add = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                
                    if (cbl.Text != "")
                    {
                    if (cbdvt.Text != "")
                    {
                        if (add == true)
                        {
                            try
                            {
                                ck.IDPRODUCT = txtma.Text;
                                ck.NAMEPRODUCT = txtten.Text;
                                ck.IDSECTOR = cbl.Text;
                                ck.IDUNIT = cbdvt.Text;
                                ck.QUANTITY = txtsl.Text;
                                ck.PRICEI = txtdgn.Text;
                                ck.PRICEs = txtdgb.Text;
                                ck.THOAIGIANBH = txtngay.Text;

                                thucthi.themoisp(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Save Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                ck.IDPRODUCT = txtma.Text;
                                ck.NAMEPRODUCT = txtten.Text;
                                ck.IDSECTOR = cbl.Text;
                                ck.IDUNIT = cbdvt.Text;
                                ck.QUANTITY = txtsl.Text;
                                ck.PRICEI = txtdgn.Text;
                                ck.PRICEs = txtdgb.Text;
                                ck.THOAIGIANBH = txtngay.Text;

                                thucthi.suasp(ck);
                                MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        txtma.Enabled = true;
                        locktext();
                        hienthi();
                    }
                    
                    
                    else
                    {
                        MessageBox.Show("Code Can't be blank", "Warning", MessageBoxButtons.OK);
                        cbl.Focus();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Code Can't be blank", "Warning", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            add = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.IDPRODUCT = txtma.Text;

                    thucthi.xoasp(ck);
                    MessageBox.Show("Delete Successful ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbl.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbdvt.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[6].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[7].Value.ToString();
            locktext();
        }



        private void fr_Hanghoa_Load(object sender, EventArgs e)
        {
           
            thucthi.loadmadv(cbdvt);
            thucthi.loadmal(cbl);
            locktext();
            hienthi();
            khoitaoluoi();
        }

  
        private void cbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = thucthi.loadtenl(lbl.Text, cbl.Text);
        }

        private void cbdvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbdvt.Text = thucthi.loadtendv(lbdvt.Text, cbdvt.Text);
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
