namespace BookingHotel_App
{
    partial class frm_TuyChinhPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TuyChinhPhong));
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EditLoaiPh = new DesignControl.ButtonHover();
            this.cbo_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Phong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tang = new DesignControl.TextForNumber();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.AllowUserToAddRows = false;
            this.dgv_Phong.AllowUserToDeleteRows = false;
            this.dgv_Phong.AllowUserToResizeColumns = false;
            this.dgv_Phong.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgv_Phong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Phong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_Phong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Phong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH,
            this.TenPH,
            this.MaLP,
            this.Tang,
            this.TinhTrangPH});
            this.dgv_Phong.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Phong.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Phong.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Phong.Location = new System.Drawing.Point(0, 203);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phong.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Phong.RowHeadersVisible = false;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.dgv_Phong.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phong.Size = new System.Drawing.Size(717, 211);
            this.dgv_Phong.TabIndex = 15;
            this.dgv_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Phong_CellClick);
            // 
            // MaPH
            // 
            this.MaPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaPH.DataPropertyName = "MaPH";
            this.MaPH.HeaderText = "Mã phòng";
            this.MaPH.Name = "MaPH";
            this.MaPH.ReadOnly = true;
            this.MaPH.Width = 79;
            // 
            // TenPH
            // 
            this.TenPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Phòng";
            this.TenPH.Name = "TenPH";
            this.TenPH.ReadOnly = true;
            this.TenPH.Width = 62;
            // 
            // MaLP
            // 
            this.MaLP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaLP.DataPropertyName = "MaLP";
            this.MaLP.HeaderText = "Mã loại phòng";
            this.MaLP.Name = "MaLP";
            this.MaLP.ReadOnly = true;
            this.MaLP.Width = 98;
            // 
            // Tang
            // 
            this.Tang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tang.DataPropertyName = "Tang";
            this.Tang.HeaderText = "Tầng";
            this.Tang.Name = "Tang";
            this.Tang.ReadOnly = true;
            this.Tang.Width = 56;
            // 
            // TinhTrangPH
            // 
            this.TinhTrangPH.DataPropertyName = "TinhTrangPH";
            this.TinhTrangPH.HeaderText = "Tình trạng";
            this.TinhTrangPH.Name = "TinhTrangPH";
            this.TinhTrangPH.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_EditLoaiPh);
            this.panel1.Controls.Add(this.cbo_LoaiPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbo_TinhTrang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Phong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Tang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo_LoaiTK);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 176);
            this.panel1.TabIndex = 14;
            // 
            // btn_EditLoaiPh
            // 
            this.btn_EditLoaiPh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_EditLoaiPh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditLoaiPh.FlatAppearance.BorderSize = 0;
            this.btn_EditLoaiPh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btn_EditLoaiPh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditLoaiPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EditLoaiPh.ForeColor = System.Drawing.Color.Lime;
            this.btn_EditLoaiPh.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditLoaiPh.Image")));
            this.btn_EditLoaiPh.Location = new System.Drawing.Point(614, 27);
            this.btn_EditLoaiPh.Name = "btn_EditLoaiPh";
            this.btn_EditLoaiPh.Size = new System.Drawing.Size(27, 25);
            this.btn_EditLoaiPh.TabIndex = 41;
            this.btn_EditLoaiPh.UseVisualStyleBackColor = false;
            this.btn_EditLoaiPh.Click += new System.EventHandler(this.btn_EditLoaiPh_Click);
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiPhong.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiPhong.FormattingEnabled = true;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(298, 27);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(310, 24);
            this.cbo_LoaiPhong.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(295, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại phòng";
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TinhTrang.ForeColor = System.Drawing.Color.White;
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(23, 128);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(229, 24);
            this.cbo_TinhTrang.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tình trạng";
            // 
            // txt_Phong
            // 
            this.txt_Phong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phong.ForeColor = System.Drawing.Color.White;
            this.txt_Phong.Location = new System.Drawing.Point(23, 27);
            this.txt_Phong.Name = "txt_Phong";
            this.txt_Phong.Size = new System.Drawing.Size(229, 22);
            this.txt_Phong.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phòng";
            // 
            // txt_Tang
            // 
            this.txt_Tang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_Tang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tang.ForeColor = System.Drawing.Color.White;
            this.txt_Tang.Location = new System.Drawing.Point(23, 74);
            this.txt_Tang.Name = "txt_Tang";
            this.txt_Tang.Size = new System.Drawing.Size(229, 22);
            this.txt_Tang.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tầng";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(399, 71);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(242, 24);
            this.cbo_LoaiTK.TabIndex = 1;
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(295, 74);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 13;
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
            this.tsBtn_InExcel,
            this.tsBtn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(717, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Them
            // 
            this.tsBtn_Them.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Them.Image")));
            this.tsBtn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Them.Name = "tsBtn_Them";
            this.tsBtn_Them.Size = new System.Drawing.Size(69, 24);
            this.tsBtn_Them.Text = "Thêm";
            this.tsBtn_Them.Click += new System.EventHandler(this.tsBtn_Them_Click);
            // 
            // tsBtn_Sua
            // 
            this.tsBtn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Sua.Image")));
            this.tsBtn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Sua.Name = "tsBtn_Sua";
            this.tsBtn_Sua.Size = new System.Drawing.Size(55, 24);
            this.tsBtn_Sua.Text = "Sửa";
            this.tsBtn_Sua.Click += new System.EventHandler(this.tsBtn_Sua_Click);
            // 
            // tsBtn_Xoa
            // 
            this.tsBtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Xoa.Image")));
            this.tsBtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Xoa.Name = "tsBtn_Xoa";
            this.tsBtn_Xoa.Size = new System.Drawing.Size(56, 24);
            this.tsBtn_Xoa.Text = "Xóa";
            this.tsBtn_Xoa.Click += new System.EventHandler(this.tsBtn_Xoa_Click);
            // 
            // tsBtn_SapXep
            // 
            this.tsBtn_SapXep.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_SapXep.Image")));
            this.tsBtn_SapXep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_SapXep.Name = "tsBtn_SapXep";
            this.tsBtn_SapXep.Size = new System.Drawing.Size(83, 24);
            this.tsBtn_SapXep.Text = "Sắp xếp";
            this.tsBtn_SapXep.Click += new System.EventHandler(this.tsBtn_SapXep_Click);
            // 
            // tsBtn_TimKiem
            // 
            this.tsBtn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_TimKiem.Image")));
            this.tsBtn_TimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_TimKiem.Name = "tsBtn_TimKiem";
            this.tsBtn_TimKiem.Size = new System.Drawing.Size(94, 24);
            this.tsBtn_TimKiem.Text = "Tìm kiếm";
            this.tsBtn_TimKiem.Click += new System.EventHandler(this.tsBtn_TimKiem_Click);
            // 
            // tsBtn_InExcel
            // 
            this.tsBtn_InExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_InExcel.Image")));
            this.tsBtn_InExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_InExcel.Name = "tsBtn_InExcel";
            this.tsBtn_InExcel.Size = new System.Drawing.Size(94, 24);
            this.tsBtn_InExcel.Text = "Thống kê";
            this.tsBtn_InExcel.Click += new System.EventHandler(this.tsBtn_InExcel_Click);
            // 
            // tsBtn_Reset
            // 
            this.tsBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Reset.Image")));
            this.tsBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Reset.Name = "tsBtn_Reset";
            this.tsBtn_Reset.Size = new System.Drawing.Size(68, 24);
            this.tsBtn_Reset.Text = "Reset";
            this.tsBtn_Reset.Click += new System.EventHandler(this.tsBtn_Reset_Click);
            // 
            // frm_TuyChinhPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.dgv_Phong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_TuyChinhPhong.IconOptions.Image")));
            this.Name = "frm_TuyChinhPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chỉnh phòng";
            this.Load += new System.EventHandler(this.frm_TuyChinhPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
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

        private System.Windows.Forms.DataGridView dgv_Phong;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox txt_Phong;
        private System.Windows.Forms.Label label1;
        private DesignControl.TextForNumber txt_Tang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_LoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private System.Windows.Forms.Label label3;
        private DesignControl.ButtonHover btn_EditLoaiPh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPH;
    }
}