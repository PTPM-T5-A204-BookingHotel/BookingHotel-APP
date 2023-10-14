namespace DesignControl
{
    partial class UC_DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DichVu));
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_GiaKT = new DesignControl.TextForNumber();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_GiaBD = new DesignControl.TextForNumber();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaDV = new DesignControl.TextForNumber();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
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
            this.MaDV,
            this.TenDV,
            this.GiaDV,
            this.MotaDV});
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
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 178);
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
            this.dgv_NhanVien.Size = new System.Drawing.Size(737, 293);
            this.dgv_NhanVien.TabIndex = 11;
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
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên";
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // GiaDV
            // 
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Giá";
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.ReadOnly = true;
            // 
            // MotaDV
            // 
            this.MotaDV.DataPropertyName = "MotaDV";
            this.MotaDV.HeaderText = "Mô tả";
            this.MotaDV.Name = "MotaDV";
            this.MotaDV.ReadOnly = true;
            this.MotaDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MotaDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_GiaKT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_GiaBD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_GiaDV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rtxt_MoTa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_TenDV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_LoaiTK);
            this.panel1.Controls.Add(this.lbl_LoaiTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 151);
            this.panel1.TabIndex = 10;
            // 
            // txt_GiaKT
            // 
            this.txt_GiaKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_GiaKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaKT.ForeColor = System.Drawing.Color.White;
            this.txt_GiaKT.Location = new System.Drawing.Point(549, 107);
            this.txt_GiaKT.Name = "txt_GiaKT";
            this.txt_GiaKT.Size = new System.Drawing.Size(161, 22);
            this.txt_GiaKT.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(456, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giá kết thúc";
            // 
            // txt_GiaBD
            // 
            this.txt_GiaBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_GiaBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaBD.ForeColor = System.Drawing.Color.White;
            this.txt_GiaBD.Location = new System.Drawing.Point(549, 61);
            this.txt_GiaBD.Name = "txt_GiaBD";
            this.txt_GiaBD.Size = new System.Drawing.Size(161, 22);
            this.txt_GiaBD.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(456, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá bắt đầu";
            // 
            // txt_GiaDV
            // 
            this.txt_GiaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_GiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaDV.ForeColor = System.Drawing.Color.White;
            this.txt_GiaDV.Location = new System.Drawing.Point(20, 104);
            this.txt_GiaDV.Name = "txt_GiaDV";
            this.txt_GiaDV.Size = new System.Drawing.Size(177, 22);
            this.txt_GiaDV.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá";
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.rtxt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_MoTa.ForeColor = System.Drawing.Color.White;
            this.rtxt_MoTa.Location = new System.Drawing.Point(260, 11);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxt_MoTa.Size = new System.Drawing.Size(187, 118);
            this.rtxt_MoTa.TabIndex = 10;
            this.rtxt_MoTa.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mô tả";
            // 
            // txt_TenDV
            // 
            this.txt_TenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_TenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDV.ForeColor = System.Drawing.Color.White;
            this.txt_TenDV.Location = new System.Drawing.Point(20, 30);
            this.txt_TenDV.Name = "txt_TenDV";
            this.txt_TenDV.Size = new System.Drawing.Size(177, 22);
            this.txt_TenDV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(557, 11);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(153, 24);
            this.cbo_LoaiTK.TabIndex = 1;
            // 
            // lbl_LoaiTK
            // 
            this.lbl_LoaiTK.AutoSize = true;
            this.lbl_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoaiTK.ForeColor = System.Drawing.Color.White;
            this.lbl_LoaiTK.Location = new System.Drawing.Point(453, 14);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
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
            this.tsBtn_InExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 27);
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
            // tsBtn_InExcel
            // 
            this.tsBtn_InExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_InExcel.Image")));
            this.tsBtn_InExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_InExcel.Name = "tsBtn_InExcel";
            this.tsBtn_InExcel.Size = new System.Drawing.Size(82, 24);
            this.tsBtn_InExcel.Text = "In Excel";
            // 
            // UC_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_DichVu";
            this.Size = new System.Drawing.Size(737, 493);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotaDV;
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
        private TextForNumber txt_GiaDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.Label label3;
        private TextForLetter txt_TenDV;
        private System.Windows.Forms.Label label1;
        private TextForNumber txt_GiaKT;
        private System.Windows.Forms.Label label6;
        private TextForNumber txt_GiaBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsBtn_InExcel;
    }
}
