namespace BookingHotel_App
{
    partial class UC_TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TaiKhoan));
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.btn_UpImage = new System.Windows.Forms.Button();
            this.lbl_TenTK = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_ShowPass = new System.Windows.Forms.Button();
            this.btn_Change = new DesignControl.ButtonHover();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Image
            // 
            this.pic_Image.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pic_Image.ErrorImage")));
            this.pic_Image.Image = ((System.Drawing.Image)(resources.GetObject("pic_Image.Image")));
            this.pic_Image.Location = new System.Drawing.Point(338, 192);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(70, 78);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 29;
            this.pic_Image.TabStop = false;
            // 
            // btn_UpImage
            // 
            this.btn_UpImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_UpImage.FlatAppearance.BorderSize = 2;
            this.btn_UpImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpImage.Location = new System.Drawing.Point(326, 176);
            this.btn_UpImage.Name = "btn_UpImage";
            this.btn_UpImage.Size = new System.Drawing.Size(96, 109);
            this.btn_UpImage.TabIndex = 28;
            this.btn_UpImage.UseVisualStyleBackColor = true;
            this.btn_UpImage.Click += new System.EventHandler(this.btn_UpImage_Click);
            // 
            // lbl_TenTK
            // 
            this.lbl_TenTK.AutoSize = true;
            this.lbl_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTK.ForeColor = System.Drawing.Color.White;
            this.lbl_TenTK.Location = new System.Drawing.Point(264, 305);
            this.lbl_TenTK.Name = "lbl_TenTK";
            this.lbl_TenTK.Size = new System.Drawing.Size(103, 20);
            this.lbl_TenTK.TabIndex = 27;
            this.lbl_TenTK.Text = "TÀI KHOẢN";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.txt_Password);
            this.panel4.Location = new System.Drawing.Point(268, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 34);
            this.panel4.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 1);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 3);
            this.panel6.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.Location = new System.Drawing.Point(0, 0);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(230, 16);
            this.txt_Password.TabIndex = 0;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass.FlatAppearance.BorderSize = 0;
            this.btn_ShowPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPass.Image = global::BookingHotel_App.Properties.Resources.icons8_eye_50__2_;
            this.btn_ShowPass.Location = new System.Drawing.Point(469, 374);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Size = new System.Drawing.Size(29, 28);
            this.btn_ShowPass.TabIndex = 25;
            this.btn_ShowPass.UseVisualStyleBackColor = true;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Change.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Change.FlatAppearance.BorderSize = 2;
            this.btn_Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Change.ForeColor = System.Drawing.Color.Lime;
            this.btn_Change.Location = new System.Drawing.Point(297, 404);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(142, 43);
            this.btn_Change.TabIndex = 24;
            this.btn_Change.Text = "Change";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookingHotel_App.Properties.Resources.icons8_password_64;
            this.pictureBox2.Location = new System.Drawing.Point(220, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookingHotel_App.Properties.Resources.icons8_account_48;
            this.pictureBox1.Location = new System.Drawing.Point(220, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "ACCOUNT";
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pic_Image);
            this.Controls.Add(this.btn_UpImage);
            this.Controls.Add(this.lbl_TenTK);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_ShowPass);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(703, 547);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Button btn_UpImage;
        private System.Windows.Forms.Label lbl_TenTK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_ShowPass;
        private DesignControl.ButtonHover btn_Change;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
