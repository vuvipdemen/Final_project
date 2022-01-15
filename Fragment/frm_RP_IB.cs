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
using COMExcel = Microsoft.Office.Interop.Excel;
using StoreManager.StoreStructor.Strutor;
using StoreManager.StoreStructor.EC;
using StoreManager.Fragment;

namespace StoreManager.Presentation
{
    public partial class fr_CTHDN : Form
    {
        public fr_CTHDN()
        {
            InitializeComponent();
        }
        ST_RP_IB thucthi = new ST_RP_IB();
        ConnectDB cn = new ConnectDB();
        EC_RP_IB ck = new EC_RP_IB();
        bool add;
        int dong = 0;

        private string IdIB;
        public string IDIB
        {
            get
            {
                return IdIB;
            }
            set
            {
                IdIB = value;
            }
        }

        public void setnull()
        {
            txtsl.Text = "0";
            txtdg.Text = "0";
            txttt.Text = "0";
            cbhang.Text = "";
        }
        public void locktext()
        {
            txtsl.Enabled = false;
            txtdg.Enabled = false;
            cbhang.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtsl.Enabled = true;
            txtdg.Enabled = true;
            cbhang.Enabled = true;

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
            msds.Columns[1].HeaderText = "ID Product";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Quantity";
            msds.Columns[2].Width = 80;
            msds.Columns[3].HeaderText = "Unit Price";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Total Money";
            msds.Columns[4].Width = 80;
        }
        public void hienthi()
        {
            string sql = "SELECT IdIB, IdProduct, Quantity, UnitPrice, TotalMoney FROM db_rp_IB";
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
            string sql = "SELECT IdIB, IdProduct, Quantity, UnitPrice, TotalMoney FROM db_rp_IB where IdIB='" + IdIB + "'";
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

        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbhang.Text != "")
            {
                if (add == true)
                {
                    try
                    {
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text));

                        ck.IDIB = cbhd.Text;
                        ck.IDPRODUCT = cbhang.Text;
                        ck.QUANTITY = txtsl.Text;
                        ck.UNITPRICE = txtdg.Text;
                        ck.TOTALMONEY = tt.ToString();

                        thucthi.themoicthdn(ck);
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
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text));
                        ck.IDIB = cbhd.Text;
                        ck.IDPRODUCT = cbhang.Text;
                        ck.QUANTITY = txtsl.Text;
                        ck.UNITPRICE = txtdg.Text;
                        ck.TOTALMONEY = tt.ToString();

                        thucthi.suacthdn(ck);
                        MessageBox.Show("Update Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                float gn = float.Parse(txtdg.Text);
                float gb = (gn * 110) / 100;

                string upsl = "UPDATE db_Product SET Quantity =Quantity + '" + txtsl.Text + "' where IdProduct='" + cbhang.Text + "'";
                string upsl1 = "UPDATE db_Product SET PriceI ='" + txtdg.Text + "' where IdProduct ='" + cbhang.Text + "'";
                string upsl2 = "UPDATE db_Product SET PriceS ='" + gb + "'where IdProduct='" + cbhang.Text + "'";
                string uptt = "update db_IB set tongtien=(SELECT sum(TotalMoney) FROM db_rp_IB) where IdIB='" + cbhd.Text + "'";
                cn.ExcuteNonQuery(uptt);
                cn.ExcuteNonQuery(upsl);
                cn.ExcuteNonQuery(upsl1);
                cn.ExcuteNonQuery(upsl2);
                locktext();
                hienthi();
                float t1 = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text));
                txttt.Text = t1.ToString();
            }
            else
            {
                MessageBox.Show("Code Can't be blank", "Warning", MessageBoxButtons.OK);
                cbhang.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            add = false;
            un_locktext();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.IDIB = cbhd.Text;
                    ck.IDPRODUCT = cbhang.Text;

                    thucthi.xoacthdn(ck);
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
            cbhd.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbhang.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtdg.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void fr_CTHDN_Load(object sender, EventArgs e)
        {
            cbhd.Text = IdIB;
            thucthi.loadmahd(cbhd);
            thucthi.loadmasp(cbhang);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            fr_HDN fr = new fr_HDN();
            this.Close();
            fr.Show();
        }
        private void cbhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.loadtensp(lbhang.Text, cbhang.Text);
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable dbInforBill, dbInforProduct;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "StoreManger";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "TDT University";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0964351175";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "IMPORT BILL";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = @"SELECT     db_rp_IB.IdIB, db_Supplier.NameSupplier, db_Supplier.Address, db_Supplier.MobilePhone, db_Staff.NameStaff,db_IB.DateAdd
                        FROM         db_IB INNER JOIN
                      db_Supplier ON db_IB.IdSupplier = db_Supplier.IdSupplier INNER JOIN
                      db_rp_IB ON db_IB.IdIB = db_rp_IB.IdIB INNER JOIN
                      db_Staff ON db_IB.IdStaff = db_Staff.IdStaff where db_IB.IdIB='" + cbhd.Text + "'";
            dbInforBill = cn.taobang(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "ID Bill:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = dbInforBill.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Supplier:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = dbInforBill.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Address:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = dbInforBill.Rows[0][2].ToString();
            exRange.Range["B9:B9"].Value = "Mobile Phone:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = dbInforBill.Rows[0][3].ToString();
            //Lấy thông tin các mặt hàng
            sql = @"SELECT    db_Product.NameProduct , db_rp_IB.Quantity, db_rp_IB.UnitPrice, db_rp_IB.TotalMoney
FROM         db_rp_IB INNER JOIN
                      db_Product ON db_rp_IB.IdProduct = db_Product.IdProduct where db_rp_IB.IdIB='" + cbhd.Text + "'";
            dbInforProduct = cn.taobang(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Name Product";
            exRange.Range["C11:C11"].Value = "Quantity";
            exRange.Range["D11:D11"].Value = "UnitPrice";
            exRange.Range["F11:F11"].Value = "Money";
            for (hang = 0; hang <= dbInforProduct.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= dbInforProduct.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = dbInforProduct.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(dbInforBill.Rows[0][5]);
            exRange.Range["A1:C1"].Value = "Gia Lai, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Import staff";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = dbInforBill.Rows[0][4];
            exSheet.Name = "Import Bill";
            exApp.Visible = true;
        }

        private void cbhang_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lbhang_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPayment fr = new frmPayment();
            this.Close();
            fr.Show();
        }
    }
}
