namespace BookingHotel_App
{
    partial class UC_DatPhongOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DatPhongOnline));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Check = new System.Windows.Forms.ToolStripButton();
            this.dgv_DatPhongOnl = new System.Windows.Forms.DataGridView();
            this.MaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTGoLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhtrangDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLbl_TongCong = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatPhongOnl)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Check,
            this.tsBtn_Reset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_Check
            // 
            this.tsBtn_Check.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Check.Image")));
            this.tsBtn_Check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Check.Name = "tsBtn_Check";
            this.tsBtn_Check.Size = new System.Drawing.Size(70, 24);
            this.tsBtn_Check.Text = "Check";
            this.tsBtn_Check.Click += new System.EventHandler(this.tsBtn_Check_Click);
            // 
            // dgv_DatPhongOnl
            // 
            this.dgv_DatPhongOnl.AllowUserToAddRows = false;
            this.dgv_DatPhongOnl.AllowUserToDeleteRows = false;
            this.dgv_DatPhongOnl.AllowUserToResizeColumns = false;
            this.dgv_DatPhongOnl.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_DatPhongOnl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DatPhongOnl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DatPhongOnl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_DatPhongOnl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DatPhongOnl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DatPhongOnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DatPhongOnl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDP,
            this.Hoten,
            this.Email,
            this.SoLuongTGoLai,
            this.SoLuongNg,
            this.ThoiGianNhanPhong,
            this.TinhtrangDP});
            this.dgv_DatPhongOnl.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DatPhongOnl.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DatPhongOnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DatPhongOnl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_DatPhongOnl.Location = new System.Drawing.Point(0, 27);
            this.dgv_DatPhongOnl.Name = "dgv_DatPhongOnl";
            this.dgv_DatPhongOnl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DatPhongOnl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DatPhongOnl.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_DatPhongOnl.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DatPhongOnl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DatPhongOnl.Size = new System.Drawing.Size(763, 462);
            this.dgv_DatPhongOnl.TabIndex = 17;
            // 
            // MaDP
            // 
            this.MaDP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaDP.DataPropertyName = "MaDP";
            this.MaDP.HeaderText = "Mã";
            this.MaDP.Name = "MaDP";
            this.MaDP.ReadOnly = true;
            this.MaDP.Width = 52;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Khách hàng";
            this.Hoten.Name = "Hoten";
            this.Hoten.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // SoLuongTGoLai
            // 
            this.SoLuongTGoLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuongTGoLai.DataPropertyName = "SoLuongTGoLai";
            this.SoLuongTGoLai.HeaderText = "Số ngày lưu trú";
            this.SoLuongTGoLai.Name = "SoLuongTGoLai";
            this.SoLuongTGoLai.ReadOnly = true;
            this.SoLuongTGoLai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuongTGoLai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoLuongTGoLai.Width = 83;
            // 
            // SoLuongNg
            // 
            this.SoLuongNg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuongNg.DataPropertyName = "SoLuongNg";
            this.SoLuongNg.HeaderText = "Số lượng người";
            this.SoLuongNg.Name = "SoLuongNg";
            this.SoLuongNg.ReadOnly = true;
            this.SoLuongNg.Width = 118;
            // 
            // ThoiGianNhanPhong
            // 
            this.ThoiGianNhanPhong.DataPropertyName = "ThoiGianNhanPhong";
            this.ThoiGianNhanPhong.HeaderText = "Thời gian tới nhận";
            this.ThoiGianNhanPhong.Name = "ThoiGianNhanPhong";
            this.ThoiGianNhanPhong.ReadOnly = true;
            // 
            // TinhtrangDP
            // 
            this.TinhtrangDP.DataPropertyName = "TinhtrangDP";
            this.TinhtrangDP.HeaderText = "Tình trạng";
            this.TinhtrangDP.Name = "TinhtrangDP";
            this.TinhtrangDP.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssLbl_TongCong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(763, 22);
            this.statusStrip1.TabIndex = 16;
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
            // tsBtn_Reset
            // 
            this.tsBtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Reset.Image")));
            this.tsBtn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Reset.Name = "tsBtn_Reset";
            this.tsBtn_Reset.Size = new System.Drawing.Size(68, 24);
            this.tsBtn_Reset.Text = "Reset";
            this.tsBtn_Reset.Click += new System.EventHandler(this.tsBtn_Reset_Click);
            // 
            // UC_DatPhongOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.dgv_DatPhongOnl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_DatPhongOnline";
            this.Size = new System.Drawing.Size(763, 511);
            this.Load += new System.EventHandler(this.UC_DatPhongOnline_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatPhongOnl)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Check;
        private System.Windows.Forms.DataGridView dgv_DatPhongOnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTGoLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhtrangDP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssLbl_TongCong;
        private System.Windows.Forms.ToolStripButton tsBtn_Reset;
    }
}
