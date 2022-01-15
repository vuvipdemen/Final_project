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
    public partial class fr_Donvitinh : Form
    {
        public fr_Donvitinh()
        {
            InitializeComponent();
        }
        ST_Unit thucthi = new ST_Unit();
        ConnectDB cn = new ConnectDB();
        EC_Unit ck = new EC_Unit();
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
            msds.Columns[0].HeaderText = "ID Unit";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Name Unit";
            msds.Columns[1].Width = 200;

        }
        public void hienthi()
        {
            string sql = "SELECT IdUnit, NameUnit FROM db_Unit";
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
                if (add == true)
                {
                    try
                    {
                        ck.IDUNIT = txtma.Text;
                        ck.NAMEUNIT = txtten.Text;
                        thucthi.themoil(ck);
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
                        ck.IDUNIT = txtma.Text;
                        ck.NAMEUNIT = txtten.Text;
                        thucthi.sual(ck);
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
                    ck.IDUNIT = txtma.Text;

                    thucthi.xoal(ck);
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
        private void fr_Nhanhieu_Load(object sender, EventArgs e)
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
    }
}
