using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using StoreManager.DataBase;
using StoreManager.StoreStructor.Strutor;
using System.Security.Cryptography;
using System.IO;
using StoreManager.StoreStructor.EC;

namespace StoreManager.Presentation
{
    public partial class fr_Dangnhap : Form
    {
        public fr_Dangnhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        ST_User thucthi = new ST_User();
        EC_User ck = new EC_User();

        private void cmddn_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            try
            {
                ck.USERNAME = user;
                ck.PASSWORD = pass;
                if (!thucthi.kiemtrauser(user, pass))
                {
                    MessageBox.Show("Login Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fr_Main fr = new fr_Main();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("The login account is not correct. Please check again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmddn.Enabled = false;
                cmddn_Click(sender, e);
            }
        }

        private void fr_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
