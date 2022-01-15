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
    public partial class fr_NCC : Form
    {
        public fr_NCC()
        {
            InitializeComponent();
        }
        ST_Supplier thucthi = new ST_Supplier();
        ConnectDB cn = new ConnectDB();
        EC_Supplier ck = new EC_Supplier();
        bool add;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdt.Text = "";
            txtdc.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "ID Supplier";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Name Supplier";
            msds.Columns[1].Width = 300;
            msds.Columns[2].HeaderText = "Address";
            msds.Columns[2].Width = 300;
            msds.Columns[3].HeaderText = "Mobile Phone";
            msds.Columns[3].Width = 300;

        }
        public void hienthi()
        {
            string sql = "SELECT     IdSupplier, NameSupplier, Address, MobilePhone FROM db_Supplier";
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
                        ck.IDSUPPLIER = txtma.Text;
                        ck.NAMESUPPLIER = txtten.Text;
                        ck.ADDRESS = txtdc.Text;
                        ck.MOBILEPHONE = txtdt.Text;

                        thucthi.themoincc(ck);
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
                        ck.IDSUPPLIER = txtma.Text;
                        ck.NAMESUPPLIER = txtten.Text;
                        ck.ADDRESS = txtdc.Text;
                        ck.MOBILEPHONE = txtdt.Text;

                        thucthi.suancc(ck);
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
                    ck.IDSUPPLIER = txtma.Text;

                    thucthi.xoancc(ck);
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
        private void fr_NCC_Load(object sender, EventArgs e)
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
            txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtdt.Text = msds.Rows[dong].Cells[3].Value.ToString();
            locktext();
        }
    }
}
