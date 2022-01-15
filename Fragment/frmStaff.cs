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
    public partial class fr_Nhanvien : Form
    {
        public fr_Nhanvien()
        {
            InitializeComponent();
        }
        ST_Staff thucthi = new ST_Staff();
        ConnectDB cn = new ConnectDB();
        EC_Staff ck = new EC_Staff();
        bool add;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbgt.Text = "Nam";
            txtDoB.Text = DateTime.Now.ToShortTimeString();
            txtdt.Text = "";
            txtdc.Text = "";

        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbgt.Enabled = false;
            txtDoB.Enabled = false;
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
            cbgt.Enabled = true;
            txtDoB.Enabled = true;
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
            msds.Columns[0].HeaderText = "ID Staff";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;
            msds.Columns[1].HeaderText = "Name Staff";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Gender ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Date Of Birth";
            msds.Columns[3].Width = 200;
            msds.Columns[4].HeaderText = "Mobile Phone";
            msds.Columns[4].Width = 200;
            msds.Columns[5].HeaderText = "Address";
            msds.Columns[5].Width = 200;


        }
        public void hienthi()
        {
            string sql = "SELECT     IdStaff, NameStaff, Gender, DoB, MobilePhone, Address FROM db_Staff";
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
                            ck.IDSTAFF = txtma.Text;
                            ck.NAMESTAFF = txtten.Text;
                            ck.GENDER = cbgt.Text;
                            ck.DOB = txtDoB.Text;
                            ck.MOBILEPHONE = txtdt.Text;
                            ck.ADDRESS = txtdc.Text;
       
                            
                            thucthi.themoinv(ck);
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
                            ck.IDSTAFF = txtma.Text;
                            ck.NAMESTAFF = txtten.Text;
                            ck.GENDER = cbgt.Text;
                            ck.DOB = txtDoB.Text;
                            ck.MOBILEPHONE = txtdt.Text;
                            ck.ADDRESS = txtdc.Text;
              

                            thucthi.suanv(ck);
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
                    ck.IDSTAFF = txtma.Text;

                    thucthi.xoanv(ck);
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
        private void fr_Nhanvien_Load(object sender, EventArgs e)
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
            cbgt.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtDoB.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtdt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtdc.Text = msds.Rows[dong].Cells[5].Value.ToString();

            locktext();
        }


    }
}
