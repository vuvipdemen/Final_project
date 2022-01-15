using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreManager.StoreStructor.Strutor;
using StoreManager.DataBase;
using StoreManager.StoreStructor.EC;

namespace StoreManager.Presentation
{
    public partial class fr_HDN : Form
    {
        public fr_HDN()
        {
            InitializeComponent();
        }
        ST_IB thucthi = new ST_IB();
        ConnectDB cn = new ConnectDB();
        EC_IB ck = new EC_IB();
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
            msds.Columns[2].HeaderText = "Date add";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Supplier";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Total Money";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT     IdIB, IdStaff, DateAdd, IdSupplier, tongtien FROM db_IB";
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
                                ck.IDIB = txtma.Text;
                                ck.IDStaff = cbnv.Text;
                                ck.NGAYNHAN = txtngay.Text;
                                ck.IDSupplier = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.themoihdn(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Save Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDN fr = new fr_CTHDN();
                                fr.IDIB = txtma.Text;
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
                                ck.IDIB = txtma.Text;
                                ck.IDStaff = cbnv.Text;
                                ck.NGAYNHAN = txtngay.Text;
                                ck.IDSupplier = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.suahdn(ck);
                                MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_CTHDN fr = new fr_CTHDN();
                                fr.IDIB = txtma.Text;
                                this.Hide();
                                fr.ShowDialog();
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
                    ck.IDIB = txtma.Text;

                    thucthi.xoahdn(ck);
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

        private void fr_HDN_Load(object sender, EventArgs e)
        {
            
            thucthi.loadIdStaff(cbnv);
            thucthi.loadIdSupplier(cbncc);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnv.Text = thucthi.loadtenl(lbnv.Text, cbnv.Text);
        }

        private void cbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbncc.Text = thucthi.loadNameSupplier(lbncc.Text, cbncc.Text);
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fr_CTHDN fr = new fr_CTHDN();
            fr.IDIB = txtma.Text;
            this.Close();
            fr.Show();
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
