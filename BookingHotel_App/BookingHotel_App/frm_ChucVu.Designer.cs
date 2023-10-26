namespace BookingHotel_App
{
    partial class frm_ChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChucVu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_Them = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.txt_ChucVu = new DesignControl.TextForLetter();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_Them,
            this.tsBtn_Xoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 142);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(325, 27);
            this.toolStrip1.TabIndex = 9;
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
            // tsBtn_Xoa
            // 
            this.tsBtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Xoa.Image")));
            this.tsBtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Xoa.Name = "tsBtn_Xoa";
            this.tsBtn_Xoa.Size = new System.Drawing.Size(56, 24);
            this.tsBtn_Xoa.Text = "Xóa";
            this.tsBtn_Xoa.Click += new System.EventHandler(this.tsBtn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Chức vụ :";
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_ChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cbo_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ChucVu.ForeColor = System.Drawing.Color.White;
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Location = new System.Drawing.Point(61, 88);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(238, 24);
            this.cbo_ChucVu.TabIndex = 30;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChucVu.ForeColor = System.Drawing.Color.White;
            this.txt_ChucVu.Location = new System.Drawing.Point(12, 42);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(287, 22);
            this.txt_ChucVu.TabIndex = 31;
            // 
            // frm_ChucVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 169);
            this.Controls.Add(this.txt_ChucVu);
            this.Controls.Add(this.cbo_ChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.frm_ChucVu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_Them;
        private System.Windows.Forms.ToolStripButton tsBtn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private DesignControl.TextForLetter txt_ChucVu;
    }
}