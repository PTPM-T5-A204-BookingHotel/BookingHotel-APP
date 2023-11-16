namespace BookingHotel_App
{
    partial class UC_DanhSachPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhSachPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_Tầng = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiTK = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_TuyChinh = new System.Windows.Forms.ToolStripButton();
            this.pnl_Phong = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_Tầng);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 70);
            this.panel1.TabIndex = 12;
            // 
            // cbo_Tầng
            // 
            this.cbo_Tầng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_Tầng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Tầng.ForeColor = System.Drawing.Color.White;
            this.cbo_Tầng.FormattingEnabled = true;
            this.cbo_Tầng.Location = new System.Drawing.Point(64, 18);
            this.cbo_Tầng.Name = "cbo_Tầng";
            this.cbo_Tầng.Size = new System.Drawing.Size(100, 24);
            this.cbo_Tầng.TabIndex = 1;
            this.cbo_Tầng.SelectedIndexChanged += new System.EventHandler(this.cbo_Tầng_SelectedIndexChanged);
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(15, 21);
            this.lbl_LoaiTK.Name = "lbl_LoaiTK";
            this.lbl_LoaiTK.Size = new System.Drawing.Size(43, 16);
            this.lbl_LoaiTK.TabIndex = 0;
            this.lbl_LoaiTK.Text = "Tầng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_TuyChinh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_TuyChinh
            // 
            this.tsBtn_TuyChinh.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_TuyChinh.Image")));
            this.tsBtn_TuyChinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_TuyChinh.Name = "tsBtn_TuyChinh";
            this.tsBtn_TuyChinh.Size = new System.Drawing.Size(96, 24);
            this.tsBtn_TuyChinh.Text = "Tùy chỉnh";
            this.tsBtn_TuyChinh.Click += new System.EventHandler(this.tsBtn_TuyChinh_Click);
            // 
            // pnl_Phong
            // 
            this.pnl_Phong.AutoScroll = true;
            this.pnl_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Phong.Location = new System.Drawing.Point(0, 97);
            this.pnl_Phong.Name = "pnl_Phong";
            this.pnl_Phong.Size = new System.Drawing.Size(652, 347);
            this.pnl_Phong.TabIndex = 13;
            // 
            // UC_DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pnl_Phong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_DanhSachPhong";
            this.Size = new System.Drawing.Size(652, 444);
            this.Load += new System.EventHandler(this.UC_DanhSachPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_Tầng;
        private System.Windows.Forms.Label lbl_LoaiTK;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_TuyChinh;
        private System.Windows.Forms.Panel pnl_Phong;
    }
}
