namespace BookingHotel_App
{
    partial class UC_NhaCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhaCC));
            this.dgv_DichVu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GiaDV = new DesignControl.TextForNumber();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDV = new DesignControl.TextForLetter();
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
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DichVu
            // 
            this.dgv_DichVu.AllowUserToAddRows = false;
            this.dgv_DichVu.AllowUserToDeleteRows = false;
            this.dgv_DichVu.AllowUserToResizeColumns = false;
            this.dgv_DichVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_DichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_DichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenNCC,
            this.GioiTinhNCC,
            this.SDTNCC,
            this.DiaChiNCC});
            this.dgv_DichVu.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_DichVu.Location = new System.Drawing.Point(0, 236);
            this.dgv_DichVu.Name = "dgv_DichVu";
            this.dgv_DichVu.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DichVu.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_DichVu.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DichVu.Size = new System.Drawing.Size(796, 289);
            this.dgv_DichVu.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_Nu);
            this.panel1.Controls.Add(this.rdo_Nam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_Ma);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_GiaDV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_TenDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_LoaiTK);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 209);
            this.panel1.TabIndex = 18;
            // 
            // txt_Ma
            // 
            this.txt_Ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.ForeColor = System.Drawing.Color.White;
            this.txt_Ma.Location = new System.Drawing.Point(18, 30);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(177, 22);
            this.txt_Ma.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã";
            // 
            // txt_GiaDV
            // 
            this.txt_GiaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_GiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaDV.ForeColor = System.Drawing.Color.White;
            this.txt_GiaDV.Location = new System.Drawing.Point(18, 122);
            this.txt_GiaDV.Name = "txt_GiaDV";
            this.txt_GiaDV.Size = new System.Drawing.Size(177, 22);
            this.txt_GiaDV.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_TenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDV.ForeColor = System.Drawing.Color.White;
            this.txt_TenDV.Location = new System.Drawing.Point(18, 76);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(177, 22);
            this.txt_TenDV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(555, 29);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(181, 24);
            this.cbo_LoaiTK.TabIndex = 1;
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(451, 32);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 17;
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
            this.toolStrip1.Size = new System.Drawing.Size(796, 27);
            this.toolStrip1.TabIndex = 16;
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
            // tsBtn_InExcel
            // 
            this.tsBtn_InExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_InExcel.Image")));
            this.tsBtn_InExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_InExcel.Name = "tsBtn_InExcel";
            this.tsBtn_InExcel.Size = new System.Drawing.Size(82, 24);
            this.tsBtn_InExcel.Text = "In Excel";
            // 
            // tsBtn_Reset
            // 
            this.tsBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Reset.Image")));
            this.tsBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Reset.Name = "tsBtn_Reset";
            this.tsBtn_Reset.Size = new System.Drawing.Size(68, 24);
            this.tsBtn_Reset.Text = "Reset";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.White;
            this.txt_DiaChi.Location = new System.Drawing.Point(236, 32);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(177, 22);
            this.txt_DiaChi.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(454, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(451, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tim kiếm";
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nu.ForeColor = System.Drawing.Color.White;
            this.rdo_Nu.Location = new System.Drawing.Point(346, 102);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(44, 20);
            this.rdo_Nu.TabIndex = 24;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Nam.ForeColor = System.Drawing.Color.White;
            this.rdo_Nam.Location = new System.Drawing.Point(236, 103);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(57, 20);
            this.rdo_Nam.TabIndex = 23;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Giới tính :";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã";
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            this.MaDV.Width = 52;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Họ tên";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // GioiTinhNCC
            // 
            this.GioiTinhNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GioiTinhNCC.DataPropertyName = "GioiTinhNCC";
            this.GioiTinhNCC.HeaderText = "Giới tính";
            this.GioiTinhNCC.Name = "GioiTinhNCC";
            this.GioiTinhNCC.ReadOnly = true;
            this.GioiTinhNCC.Width = 86;
            // 
            // SDTNCC
            // 
            this.SDTNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SDTNCC.DataPropertyName = "SDTNCC";
            this.SDTNCC.HeaderText = "Số điện thoại";
            this.SDTNCC.Name = "SDTNCC";
            this.SDTNCC.ReadOnly = true;
            this.SDTNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SDTNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SDTNCC.Width = 98;
            // 
            // DiaChiNCC
            // 
            this.DiaChiNCC.DataPropertyName = "DiaChiNCC";
            this.DiaChiNCC.HeaderText = "Địa chỉ";
            this.DiaChiNCC.Name = "DiaChiNCC";
            this.DiaChiNCC.ReadOnly = true;
            // 
            // UC_NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgv_DichVu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_NhaCC";
            this.Size = new System.Drawing.Size(796, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).EndInit();
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

        private System.Windows.Forms.DataGridView dgv_DichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label2;
        private DesignControl.TextForNumber txt_GiaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DesignControl.TextForLetter txt_TenDV;
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
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNCC;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.Label label6;
    }
}
