namespace StoreManager.Presentation
{
    partial class fr_BC_NV
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.lbnv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 58);
            this.button1.TabIndex = 22;
            this.button1.Text = "Export Report";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbnv
            // 
            this.cbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(16, 15);
            this.cbnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(143, 31);
            this.cbnv.TabIndex = 24;
            this.cbnv.SelectedIndexChanged += new System.EventHandler(this.cbnv_SelectedIndexChanged);
            // 
            // lbnv
            // 
            this.lbnv.AutoSize = true;
            this.lbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnv.Location = new System.Drawing.Point(168, 18);
            this.lbnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnv.Name = "lbnv";
            this.lbnv.Size = new System.Drawing.Size(33, 25);
            this.lbnv.TabIndex = 23;
            this.lbnv.Text = "---";
            // 
            // fr_BC_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 121);
            this.Controls.Add(this.cbnv);
            this.Controls.Add(this.lbnv);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fr_BC_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fr_BC_NV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label lbnv;
    }
}