using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreManager.Fragment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMain fr = new frmMain();
            this.Close();
        }
    }
}
