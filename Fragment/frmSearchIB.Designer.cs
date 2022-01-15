namespace StoreManager.Presentation
{
    partial class fr_TKHDN
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.txtthongtin = new System.Windows.Forms.TextBox();
            this.msds = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 62);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(264, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH IMPORT BILL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.op3);
            this.panel3.Controls.Add(this.op1);
            this.panel3.Controls.Add(this.op2);
            this.panel3.Controls.Add(this.txtthongtin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 81);
            this.panel3.TabIndex = 17;
            // 
            // op3
            // 
            this.op3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op3.AutoSize = true;
            this.op3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.Location = new System.Drawing.Point(543, 48);
            this.op3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(135, 29);
            this.op3.TabIndex = 3;
            this.op3.TabStop = true;
            this.op3.Text = "ID Supplier";
            this.op3.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            this.op1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.Location = new System.Drawing.Point(183, 48);
            this.op1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(129, 29);
            this.op1.TabIndex = 3;
            this.op1.TabStop = true;
            this.op1.Text = "ID Product";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            this.op2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.Location = new System.Drawing.Point(347, 48);
            this.op2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(118, 29);
            this.op2.TabIndex = 3;
            this.op2.TabStop = true;
            this.op2.Text = "Date Add";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // txtthongtin
            // 
            this.txtthongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtthongtin.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtin.Location = new System.Drawing.Point(164, 7);
            this.txtthongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtthongtin.Name = "txtthongtin";
            this.txtthongtin.Size = new System.Drawing.Size(593, 32);
            this.txtthongtin.TabIndex = 2;
            this.txtthongtin.TextChanged += new System.EventHandler(this.txtthongtin_TextChanged);
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(0, 143);
            this.msds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msds.Name = "msds";
            this.msds.RowHeadersWidth = 51;
            this.msds.Size = new System.Drawing.Size(923, 411);
            this.msds.TabIndex = 20;
            // 
            // fr_TKHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 554);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fr_TKHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fr_TKHDN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.TextBox txtthongtin;
        private System.Windows.Forms.DataGridView msds;
    }
}