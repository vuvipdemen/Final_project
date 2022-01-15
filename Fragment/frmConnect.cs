using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using StoreManager.DataBase;

namespace StoreManager.Presentation
{
    public partial class fr_Ketnoi : Form
    {
        public fr_Ketnoi()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void cmddn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (File.Exists("Sinfo"))
                {
                    File.Delete("Sinfo");
                    StreamWriter write = new StreamWriter("Sinfo");
                    write.WriteLine("SV=:" + txtserver.Text);
                    write.WriteLine("DB=:" + txtdb.Text);
                    write.Close();
                    MessageBox.Show("Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    StreamWriter write = new StreamWriter("Sinfo");
                    write.WriteLine("SV=:" + txtserver.Text);
                    write.Close();
                    MessageBox.Show("Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

                MessageBox.Show("Server is connection" + txtserver.Text + ". Restart the project, database will be add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Unable to set up", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fr_Ketnoi_Load(object sender, EventArgs e)
        {

        }
    }
}
