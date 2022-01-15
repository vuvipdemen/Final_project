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
    public partial class fr_HDB : Form
    {
        public fr_HDB()
        {
            InitializeComponent();
        }
        ST_SB thucthi = new ST_SB();
        ConnectDB cn = new ConnectDB();
        EC_SB ck = new EC_SB();
        bool add;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtngay.Text = DateTime.Now.ToShortTimeString();
            cbncc.Text = "";
            cbnv.Text = "";
            txttt.Text = "0";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtngay.Enabled = false;
            cbncc.Enabled = false;
            cbnv.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtngay.Enabled = true;
            cbncc.Enabled = true;
            cbnv.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "ID Bill";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Staff";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Date Sale";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Customer";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Total Money";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT     IdSB, IdStaff, DateSale, IdCustomer, tongtien FROM db_SB";
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
                if (cbnv.Text != "")
                {
                    if (cbncc.Text != "")
                    {
                        if (add == true)
                        {
                            try
                            {
                                ck.IDSB = txtma.Text;
                                ck.IDSTAFF = cbnv.Text;
                                ck.DATESALE = txtngay.Text;
                                ck.IDCUSTOMER = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.themoihdb(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Save Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDB fr = new fr_CTHDB();
                                fr.IDSB = txtma.Text;
                                this.Close();
                                fr.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                ck.IDSB = txtma.Text;
                                ck.IDSTAFF = cbnv.Text;
                                ck.DATESALE = txtngay.Text;
                                ck.IDCUSTOMER = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.suahdb(ck);
                                MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDB fr = new fr_CTHDB();
                                fr.IDSB = txtma.Text;
                                this.Close();
                                fr.Show();
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
                        cbncc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Code Can't be blank", "Warning", MessageBoxButtons.OK);
                    cbnv.Focus();
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
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.IDSB = txtma.Text;

                    thucthi.xoahdb(ck);
                    MessageBox.Show("Delete Successful ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
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
            cbnv.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbncc.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void fr_HDB_Load(object sender, EventArgs e)
        {
            thucthi.loadIdCustomer(cbncc);
            thucthi.loadIdStaff(cbnv);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnv.Text = thucthi.loadNameStaff(lbnv.Text, cbnv.Text);
        }

        private void cbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbncc.Text = thucthi.loadNameCustomer(lbnv.Text, cbnv.Text);
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            fr_CTHDB fr = new fr_CTHDB();
            fr.IDSB = msds.Rows[dong].Cells[0].Value.ToString();
            this.Close();
            fr.Show();
        }
    }
}
