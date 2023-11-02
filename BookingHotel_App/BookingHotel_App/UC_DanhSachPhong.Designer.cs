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
            this.pnl_Phong = new System.Windows.Forms.Panel();
            this.cbo_LoaiPH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsBtn_Them = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Sua = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_SapXep = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_TimKiem = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_LoaiPH);
            this.panel1.Controls.Add(this.label1);
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
            this.cbo_Tầng.Size = new System.Drawing.Size(153, 24);
            this.cbo_Tầng.TabIndex = 1;
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
            this.tsBtn_Them,
            this.tsBtn_Sua,
            this.tsBtn_Xoa,
            this.tsBtn_SapXep,
            this.tsBtn_TimKiem,
            this.tsBtn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnl_Phong
            // 
            this.pnl_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Phong.Location = new System.Drawing.Point(0, 97);
            this.pnl_Phong.Name = "pnl_Phong";
            this.pnl_Phong.Size = new System.Drawing.Size(652, 347);
            this.pnl_Phong.TabIndex = 13;
            // 
            // cbo_LoaiPH
            // 
            this.cbo_LoaiPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiPH.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiPH.FormattingEnabled = true;
            this.cbo_LoaiPH.Location = new System.Drawing.Point(336, 21);
            this.cbo_LoaiPH.Name = "cbo_LoaiPH";
            this.cbo_LoaiPH.Size = new System.Drawing.Size(281, 24);
            this.cbo_LoaiPH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại Phòng";
            // 
            // tsBtn_Them
            // 
            this.tsBtn_Them.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Them.Image")));
            this.tsBtn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Them.Name = "tsBtn_Them";
            this.tsBtn_Them.Size = new System.Drawing.Size(69, 24);
            this.tsBtn_Them.Text = "Thêm";
            // 
            // tsBtn_Sua
            // 
            this.tsBtn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Sua.Image")));
            this.tsBtn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Sua.Name = "tsBtn_Sua";
            this.tsBtn_Sua.Size = new System.Drawing.Size(55, 24);
            this.tsBtn_Sua.Text = "Sửa";
            // 
            // tsBtn_Xoa
            // 
            this.tsBtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Xoa.Image")));
            this.tsBtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Xoa.Name = "tsBtn_Xoa";
            this.tsBtn_Xoa.Size = new System.Drawing.Size(56, 24);
            this.tsBtn_Xoa.Text = "Xóa";
            // 
            // tsBtn_SapXep
            // 
            this.tsBtn_SapXep.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_SapXep.Image")));
            this.tsBtn_SapXep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_SapXep.Name = "tsBtn_SapXep";
            this.tsBtn_SapXep.Size = new System.Drawing.Size(83, 24);
            this.tsBtn_SapXep.Text = "Sắp xếp";
            // 
            // tsBtn_TimKiem
            // 
            this.tsBtn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_TimKiem.Image")));
            this.tsBtn_TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_TimKiem.Name = "tsBtn_TimKiem";
            this.tsBtn_TimKiem.Size = new System.Drawing.Size(94, 24);
            this.tsBtn_TimKiem.Text = "Tìm kiếm";
            // 
            // tsBtn_Reset
            // 
            this.tsBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Reset.Image")));
            this.tsBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Reset.Name = "tsBtn_Reset";
            this.tsBtn_Reset.Size = new System.Drawing.Size(68, 24);
            this.tsBtn_Reset.Text = "Reset";
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
        private System.Windows.Forms.ToolStripButton tsBtn_Them;
        private System.Windows.Forms.ToolStripButton tsBtn_Sua;
        private System.Windows.Forms.ToolStripButton tsBtn_Xoa;
        private System.Windows.Forms.ToolStripButton tsBtn_SapXep;
        private System.Windows.Forms.ToolStripButton tsBtn_TimKiem;
        private System.Windows.Forms.ToolStripButton tsBtn_Reset;
        private System.Windows.Forms.Panel pnl_Phong;
        private System.Windows.Forms.ComboBox cbo_LoaiPH;
        private System.Windows.Forms.Label label1;
    }
}
