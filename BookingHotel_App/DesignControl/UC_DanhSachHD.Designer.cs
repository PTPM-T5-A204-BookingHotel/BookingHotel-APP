namespace DesignControl
{
    partial class UC_DanhSachHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhSachHD));
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_LoaiTK = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiTK = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLbl_TongCong = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Them = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Sua = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_SapXep = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_TimKiem = new System.Windows.Forms.ToolStripButton();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_Phong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsBtn_ThongKe = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.HoTenKH,
            this.HoTenNV,
            this.TenPH,
            this.TongTien,
            this.GiamGia,
            this.ThanhTienHD});
            this.dgv_NhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 123);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NhanVien.RowHeadersVisible = false;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(736, 386);
            this.dgv_NhanVien.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_Phong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_LoaiTK);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 96);
            this.panel1.TabIndex = 10;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.txt_TimKiem.Location = new System.Drawing.Point(94, 59);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(202, 22);
            this.txt_TimKiem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(119, 18);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(177, 24);
            this.cbo_LoaiTK.TabIndex = 1;
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(15, 21);
            this.lbl_LoaiTK.Name = "lbl_LoaiTK";
            this.lbl_LoaiTK.Size = new System.Drawing.Size(98, 16);
            this.lbl_LoaiTK.TabIndex = 0;
            this.lbl_LoaiTK.Text = "Loại tìm kiếm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLbl_TongCong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Tổng cộng :";
            // 
            // tssLbl_TongCong
            // 
            this.tssLbl_TongCong.Name = "tssLbl_TongCong";
            this.tssLbl_TongCong.Size = new System.Drawing.Size(16, 17);
            this.tssLbl_TongCong.Text = "0";
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
            this.tsBtn_ThongKe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
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
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 52;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Khách hàng";
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.ReadOnly = true;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Nhân viên";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.ReadOnly = true;
            // 
            // TenPH
            // 
            this.TenPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Phòng";
            this.TenPH.Name = "TenPH";
            this.TenPH.ReadOnly = true;
            this.TenPH.Width = 73;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TongTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TongTien.Width = 73;
            // 
            // GiamGia
            // 
            this.GiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.ReadOnly = true;
            this.GiamGia.Width = 90;
            // 
            // ThanhTienHD
            // 
            this.ThanhTienHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThanhTienHD.DataPropertyName = "ThanhTienHD";
            this.ThanhTienHD.HeaderText = "Thành tiền";
            this.ThanhTienHD.Name = "ThanhTienHD";
            this.ThanhTienHD.ReadOnly = true;
            // 
            // cbo_Phong
            // 
            this.cbo_Phong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Phong.ForeColor = System.Drawing.Color.White;
            this.cbo_Phong.FormattingEnabled = true;
            this.cbo_Phong.Location = new System.Drawing.Point(456, 13);
            this.cbo_Phong.Name = "cbo_Phong";
            this.cbo_Phong.Size = new System.Drawing.Size(153, 24);
            this.cbo_Phong.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phòng";
            // 
            // tsBtn_ThongKe
            // 
            this.tsBtn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_ThongKe.Image")));
            this.tsBtn_ThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_ThongKe.Name = "tsBtn_ThongKe";
            this.tsBtn_ThongKe.Size = new System.Drawing.Size(94, 24);
            this.tsBtn_ThongKe.Text = "Thống kê";
            // 
            // UC_DanhSachHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_DanhSachHD";
            this.Size = new System.Drawing.Size(736, 531);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_LoaiTK;
        private System.Windows.Forms.Label lbl_LoaiTK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssLbl_TongCong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Them;
        private System.Windows.Forms.ToolStripButton tsBtn_Sua;
        private System.Windows.Forms.ToolStripButton tsBtn_Xoa;
        private System.Windows.Forms.ToolStripButton tsBtn_SapXep;
        private System.Windows.Forms.ToolStripButton tsBtn_TimKiem;
        private System.Windows.Forms.ComboBox cbo_Phong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsBtn_ThongKe;
    }
}
