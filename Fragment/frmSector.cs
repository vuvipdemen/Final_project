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
using StoreManager.StoreStructor.Strutor;
using StoreManager.StoreStructor.EC;

namespace StoreManager.Presentation
{
    public partial class fr_Loaihang : Form
    {
        public fr_Loaihang()
        {
            InitializeComponent();
        }
        ST_Sector thucthi = new ST_Sector();
        ConnectDB cn = new ConnectDB();
        EC_Sector ck = new EC_Sector();
        bool add;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "ID Sector";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Name Sector";
            msds.Columns[1].Width = 300;

        }
        public void hienthi()
        {
            string sql = "SELECT   IdSector, NameSector  FROM db_Sector";
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

                    thucthi.xoakh(ck);
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
        private void fr_Khachhang_Load(object sender, EventArgs e)
        {
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            locktext();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (add == true)
                {
                    try
                    {
                        ck.IDSECTOR = txtma.Text;
                        ck.NAMESECTOR = txtten.Text;

                        thucthi.themoikh(ck);
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
                        ck.IDSECTOR = txtma.Text;
                        ck.NAMESECTOR = txtten.Text;

                        thucthi.suakh(ck);
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
                txtma.Focus();
            }
        }

    }
}
