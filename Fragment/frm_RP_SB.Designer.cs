namespace StoreManager.Presentation
{
    partial class fr_CTHDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbhd = new System.Windows.Forms.ComboBox();
            this.cbhang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbhang = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btquaylai = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.msds = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 62);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELL INVOICE DETAILS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbhd);
            this.panel4.Controls.Add(this.cbhang);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lbhang);
            this.panel4.Controls.Add(this.txttt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtdg);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtsl);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(974, 140);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Bill";
            // 
            // cbhd
            // 
            this.cbhd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbhd.Enabled = false;
            this.cbhd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhd.FormattingEnabled = true;
            this.cbhd.Location = new System.Drawing.Point(194, 11);
            this.cbhd.Margin = new System.Windows.Forms.Padding(4);
            this.cbhd.Name = "cbhd";
            this.cbhd.Size = new System.Drawing.Size(229, 31);
            this.cbhd.TabIndex = 14;
            this.cbhd.SelectedIndexChanged += new System.EventHandler(this.cbhd_SelectedIndexChanged);
            // 
            // cbhang
            // 
            this.cbhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbhang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhang.FormattingEnabled = true;
            this.cbhang.Location = new System.Drawing.Point(588, 7);
            this.cbhang.Margin = new System.Windows.Forms.Padding(4);
            this.cbhang.Name = "cbhang";
            this.cbhang.Size = new System.Drawing.Size(143, 31);
            this.cbhang.TabIndex = 14;
            this.cbhang.SelectedIndexChanged += new System.EventHandler(this.cbhang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Product";
            // 
            // lbhang
            // 
            this.lbhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhang.AutoSize = true;
            this.lbhang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhang.Location = new System.Drawing.Point(740, 11);
            this.lbhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhang.Name = "lbhang";
            this.lbhang.Size = new System.Drawing.Size(33, 25);
            this.lbhang.TabIndex = 10;
            this.lbhang.Text = "---";
            // 
            // txttt
            // 
            this.txttt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttt.Enabled = false;
            this.txttt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(588, 89);
            this.txttt.Margin = new System.Windows.Forms.Padding(4);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(321, 32);
            this.txttt.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(470, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total Money";
            // 
            // txtdg
            // 
            this.txtdg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdg.Enabled = false;
            this.txtdg.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdg.Location = new System.Drawing.Point(588, 48);
            this.txtdg.Margin = new System.Windows.Forms.Padding(4);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(321, 32);
            this.txtdg.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Unit Price";
            // 
            // txtsl
            // 
            this.txtsl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(194, 52);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(229, 32);
            this.txtsl.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quanlity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btquaylai);
            this.panel2.Controls.Add(this.btxoa);
            this.panel2.Controls.Add(this.btsua);
            this.panel2.Controls.Add(this.btluu);
            this.panel2.Controls.Add(this.btmoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 539);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 68);
            this.panel2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(612, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export Report";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btquaylai
            // 
            this.btquaylai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btquaylai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btquaylai.Location = new System.Drawing.Point(416, 0);
            this.btquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btquaylai.Name = "btquaylai";
            this.btquaylai.Size = new System.Drawing.Size(196, 68);
            this.btquaylai.TabIndex = 4;
            this.btquaylai.Text = "Back To Interface";
            this.btquaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btquaylai.UseVisualStyleBackColor = true;
            this.btquaylai.Click += new System.EventHandler(this.btquaylai_Click);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(296, 0);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(120, 68);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Delete";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(180, 0);
            this.btsua.Margin = new System.Windows.Forms.Padding(4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(116, 68);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Update";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(85, 0);
            this.btluu.Margin = new System.Windows.Forms.Padding(4);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(95, 68);
            this.btluu.TabIndex = 1;
            this.btluu.Text = "Save";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btmoi
            // 
            this.btmoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(0, 0);
            this.btmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(85, 68);
            this.btmoi.TabIndex = 0;
            this.btmoi.Text = "Add";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click);
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(0, 202);
            this.msds.Margin = new System.Windows.Forms.Padding(4);
            this.msds.Name = "msds";
            this.msds.RowHeadersWidth = 51;
            this.msds.Size = new System.Drawing.Size(974, 337);
            this.msds.TabIndex = 25;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(803, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Payment";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fr_CTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 607);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fr_CTHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fr_CTHDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbhd;
        private System.Windows.Forms.ComboBox cbhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbhang;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btquaylai;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button button2;
    }
}