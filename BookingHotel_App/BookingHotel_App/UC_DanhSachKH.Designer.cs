﻿namespace BookingHotel_App
{
    partial class UC_DanhSachKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DanhSachKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tsBtn_InExcel = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.CCCDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdo_Nu);
            this.panel1.Controls.Add(this.rdo_Nam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_LoaiTK);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 129);
            this.panel1.TabIndex = 10;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.txt_TimKiem.Location = new System.Drawing.Point(568, 74);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(361, 30);
            this.txt_TimKiem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nu.ForeColor = System.Drawing.Color.White;
            this.rdo_Nu.Location = new System.Drawing.Point(663, 29);
            this.rdo_Nu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(64, 29);
            this.rdo_Nu.TabIndex = 4;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nam.ForeColor = System.Drawing.Color.White;
            this.rdo_Nam.Location = new System.Drawing.Point(568, 29);
            this.rdo_Nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(81, 29);
            this.rdo_Nam.TabIndex = 3;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(178, 28);
            this.cbo_LoaiTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(228, 33);
            this.cbo_LoaiTK.TabIndex = 1;
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(22, 32);
            this.lbl_LoaiTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiTK.Name = "lbl_LoaiTK";
            this.lbl_LoaiTK.Size = new System.Drawing.Size(138, 25);
            this.lbl_LoaiTK.TabIndex = 0;
            this.lbl_LoaiTK.Text = "Loại tìm kiếm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLbl_TongCong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 811);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1113, 35);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 28);
            this.toolStripStatusLabel1.Text = "Tổng cộng :";
            // 
            // tssLbl_TongCong
            // 
            this.tssLbl_TongCong.Name = "tssLbl_TongCong";
            this.tssLbl_TongCong.Size = new System.Drawing.Size(24, 28);
            this.tssLbl_TongCong.Text = "0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Them,
            this.tsBtn_Sua,
            this.tsBtn_Xoa,
            this.tsBtn_SapXep,
            this.tsBtn_TimKiem,
            this.tsBtn_InExcel,
            this.tsBtn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1113, 40);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Them
            // 
            this.tsBtn_Them.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Them.Image")));
            this.tsBtn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Them.Name = "tsBtn_Them";
            this.tsBtn_Them.Size = new System.Drawing.Size(102, 35);
            this.tsBtn_Them.Text = "Thêm";
            this.tsBtn_Them.Click += new System.EventHandler(this.tsBtn_Them_Click);
            // 
            // tsBtn_Sua
            // 
            this.tsBtn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Sua.Image")));
            this.tsBtn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Sua.Name = "tsBtn_Sua";
            this.tsBtn_Sua.Size = new System.Drawing.Size(82, 35);
            this.tsBtn_Sua.Text = "Sửa";
            this.tsBtn_Sua.Click += new System.EventHandler(this.tsBtn_Sua_Click);
            // 
            // tsBtn_Xoa
            // 
            this.tsBtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Xoa.Image")));
            this.tsBtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Xoa.Name = "tsBtn_Xoa";
            this.tsBtn_Xoa.Size = new System.Drawing.Size(83, 35);
            this.tsBtn_Xoa.Text = "Xóa";
            this.tsBtn_Xoa.Click += new System.EventHandler(this.tsBtn_Xoa_Click);
            // 
            // tsBtn_SapXep
            // 
            this.tsBtn_SapXep.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_SapXep.Image")));
            this.tsBtn_SapXep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_SapXep.Name = "tsBtn_SapXep";
            this.tsBtn_SapXep.Size = new System.Drawing.Size(126, 35);
            this.tsBtn_SapXep.Text = "Sắp xếp";
            this.tsBtn_SapXep.Click += new System.EventHandler(this.tsBtn_SapXep_Click);
            // 
            // tsBtn_TimKiem
            // 
            this.tsBtn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_TimKiem.Image")));
            this.tsBtn_TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_TimKiem.Name = "tsBtn_TimKiem";
            this.tsBtn_TimKiem.Size = new System.Drawing.Size(142, 35);
            this.tsBtn_TimKiem.Text = "Tìm kiếm";
            this.tsBtn_TimKiem.Click += new System.EventHandler(this.tsBtn_TimKiem_Click);
            // 
            // tsBtn_InExcel
            // 
            this.tsBtn_InExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_InExcel.Image")));
            this.tsBtn_InExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_InExcel.Name = "tsBtn_InExcel";
            this.tsBtn_InExcel.Size = new System.Drawing.Size(114, 35);
            this.tsBtn_InExcel.Text = "Export";
            this.tsBtn_InExcel.Click += new System.EventHandler(this.tsBtn_InExcel_Click);
            // 
            // tsBtn_Reset
            // 
            this.tsBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Reset.Image")));
            this.tsBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Reset.Name = "tsBtn_Reset";
            this.tsBtn_Reset.Size = new System.Drawing.Size(99, 35);
            this.tsBtn_Reset.Text = "Reset";
            this.tsBtn_Reset.Click += new System.EventHandler(this.tsBtn_Reset_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AllowUserToResizeColumns = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCCDKH,
            this.HoTenKH,
            this.GioiTinhKH,
            this.SDTKH,
            this.NgaySinhKH,
            this.EmailKH,
            this.DiaChiKH});
            this.dgv_KhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhachHang.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 169);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.RowHeadersWidth = 62;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_KhachHang.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1113, 642);
            this.dgv_KhachHang.TabIndex = 12;
            // 
            // CCCDKH
            // 
            this.CCCDKH.DataPropertyName = "CCCDKH";
            this.CCCDKH.HeaderText = "CCCD";
            this.CCCDKH.MinimumWidth = 8;
            this.CCCDKH.Name = "CCCDKH";
            this.CCCDKH.ReadOnly = true;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "HoTenKH";
            this.HoTenKH.HeaderText = "Họ tên";
            this.HoTenKH.MinimumWidth = 8;
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.ReadOnly = true;
            // 
            // GioiTinhKH
            // 
            this.GioiTinhKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GioiTinhKH.DataPropertyName = "GioiTinhKH";
            this.GioiTinhKH.HeaderText = "Giới tính";
            this.GioiTinhKH.MinimumWidth = 8;
            this.GioiTinhKH.Name = "GioiTinhKH";
            this.GioiTinhKH.ReadOnly = true;
            this.GioiTinhKH.Width = 121;
            // 
            // SDTKH
            // 
            this.SDTKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SDTKH.DataPropertyName = "SDTKH";
            this.SDTKH.HeaderText = "Số điện thoại";
            this.SDTKH.MinimumWidth = 8;
            this.SDTKH.Name = "SDTKH";
            this.SDTKH.ReadOnly = true;
            this.SDTKH.Width = 151;
            // 
            // NgaySinhKH
            // 
            this.NgaySinhKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NgaySinhKH.DataPropertyName = "NgaySinhKH";
            this.NgaySinhKH.HeaderText = "Ngày sinh";
            this.NgaySinhKH.MinimumWidth = 8;
            this.NgaySinhKH.Name = "NgaySinhKH";
            this.NgaySinhKH.ReadOnly = true;
            this.NgaySinhKH.Width = 125;
            // 
            // EmailKH
            // 
            this.EmailKH.DataPropertyName = "EmailKH";
            this.EmailKH.HeaderText = "Email";
            this.EmailKH.MinimumWidth = 8;
            this.EmailKH.Name = "EmailKH";
            this.EmailKH.ReadOnly = true;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.MinimumWidth = 8;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.ReadOnly = true;
            this.DiaChiKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DiaChiKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UC_DanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_DanhSachKH";
            this.Size = new System.Drawing.Size(1113, 846);
            this.Load += new System.EventHandler(this.UC_DanhSachKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripButton tsBtn_InExcel;
        private System.Windows.Forms.ToolStripButton tsBtn_Reset;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
    }
}
