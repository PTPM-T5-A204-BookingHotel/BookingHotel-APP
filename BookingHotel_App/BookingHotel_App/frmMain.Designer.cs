namespace BookingHotel_App
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_Phong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_DichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_NhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_HoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_VatTu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_KhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_Kho = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_NhaCC = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_TaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_ThongTinTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_DanhSachTK = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_DangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemConditionalType1 = new DevExpress.XtraRichEdit.Design.RepositoryItemConditionalType();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem_TenTK = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem_TenTK = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemConditionalType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.MainContainer.Appearance.Options.UseBackColor = true;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(211, 31);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(935, 529);
            this.MainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement4});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(211, 529);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_Phong,
            this.ace_DichVu,
            this.ace_NhanVien,
            this.ace_HoaDon,
            this.ace_VatTu,
            this.ace_KhachHang,
            this.ace_Kho,
            this.ace_NhaCC,
            this.ace_TaiKhoan});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "DANH MỤC";
            // 
            // ace_Phong
            // 
            this.ace_Phong.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_bed_30__1_;
            this.ace_Phong.Name = "ace_Phong";
            this.ace_Phong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_Phong.Text = "Phòng";
            this.ace_Phong.Click += new System.EventHandler(this.ace_Phong_Click);
            // 
            // ace_DichVu
            // 
            this.ace_DichVu.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_service_bell_50__1_;
            this.ace_DichVu.Name = "ace_DichVu";
            this.ace_DichVu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_DichVu.Text = "Dịch vụ";
            this.ace_DichVu.Click += new System.EventHandler(this.ace_DichVu_Click);
            // 
            // ace_NhanVien
            // 
            this.ace_NhanVien.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_employee_24;
            this.ace_NhanVien.Name = "ace_NhanVien";
            this.ace_NhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_NhanVien.Text = "Nhân viên";
            this.ace_NhanVien.Click += new System.EventHandler(this.ace_NhanVien_Click);
            // 
            // ace_HoaDon
            // 
            this.ace_HoaDon.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_bill_50__1_;
            this.ace_HoaDon.Name = "ace_HoaDon";
            this.ace_HoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_HoaDon.Text = "Hóa đơn";
            this.ace_HoaDon.Click += new System.EventHandler(this.ace_HoaDon_Click);
            // 
            // ace_VatTu
            // 
            this.ace_VatTu.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_supplies_50__1_;
            this.ace_VatTu.Name = "ace_VatTu";
            this.ace_VatTu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_VatTu.Text = "Vật tư";
            this.ace_VatTu.Click += new System.EventHandler(this.ace_VatTu_Click);
            // 
            // ace_KhachHang
            // 
            this.ace_KhachHang.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_customer_64__1_;
            this.ace_KhachHang.Name = "ace_KhachHang";
            this.ace_KhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_KhachHang.Text = "Khách hàng";
            this.ace_KhachHang.Click += new System.EventHandler(this.ace_KhachHang_Click);
            // 
            // ace_Kho
            // 
            this.ace_Kho.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_warehouse_64__1_;
            this.ace_Kho.Name = "ace_Kho";
            this.ace_Kho.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_Kho.Text = "Kho";
            // 
            // ace_NhaCC
            // 
            this.ace_NhaCC.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_supplier_64__1_;
            this.ace_NhaCC.Name = "ace_NhaCC";
            this.ace_NhaCC.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_NhaCC.Text = "Nhà cung cấp";
            this.ace_NhaCC.Click += new System.EventHandler(this.ace_NhaCC_Click);
            // 
            // ace_TaiKhoan
            // 
            this.ace_TaiKhoan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_ThongTinTK,
            this.ace_DanhSachTK});
            this.ace_TaiKhoan.Expanded = true;
            this.ace_TaiKhoan.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_account_48__2_;
            this.ace_TaiKhoan.Name = "ace_TaiKhoan";
            this.ace_TaiKhoan.Text = "Tài khoản";
            // 
            // ace_ThongTinTK
            // 
            this.ace_ThongTinTK.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_information_64__1_;
            this.ace_ThongTinTK.Name = "ace_ThongTinTK";
            this.ace_ThongTinTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_ThongTinTK.Text = "Thông tin";
            this.ace_ThongTinTK.Click += new System.EventHandler(this.ace_ThongTinTK_Click);
            // 
            // ace_DanhSachTK
            // 
            this.ace_DanhSachTK.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_list_view_50__1_;
            this.ace_DanhSachTK.Name = "ace_DanhSachTK";
            this.ace_DanhSachTK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_DanhSachTK.Text = "Danh sách tài khoản";
            this.ace_DanhSachTK.Click += new System.EventHandler(this.ace_DanhSachTK_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_DangXuat});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "HỆ THỐNG";
            // 
            // ace_DangXuat
            // 
            this.ace_DangXuat.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_log_out_64__1_;
            this.ace_DangXuat.Name = "ace_DangXuat";
            this.ace_DangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_DangXuat.Text = "Đăng xuất";
            this.ace_DangXuat.Click += new System.EventHandler(this.ace_DangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1,
            this.barStaticItem2,
            this.barEditItem1,
            this.barEditItem2,
            this.barButtonItem2,
            this.barHeaderItem1,
            this.barHeaderItem_TenTK,
            this.barStaticItem,
            this.barStaticItem_TenTK});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemConditionalType1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1146, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem_TenTK);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Tài Khoản";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_account_48__2_;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Tài khoản";
            this.barStaticItem2.Id = 3;
            this.barStaticItem2.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_account_48__2_;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemConditionalType1;
            this.barEditItem2.Id = 5;
            this.barEditItem2.ImageOptions.Image = global::BookingHotel_App.Properties.Resources.icons8_account_48;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // repositoryItemConditionalType1
            // 
            this.repositoryItemConditionalType1.AutoHeight = false;
            this.repositoryItemConditionalType1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemConditionalType1.Name = "repositoryItemConditionalType1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Tài khoản:";
            this.barHeaderItem1.Id = 7;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem_TenTK
            // 
            this.barHeaderItem_TenTK.Caption = "barHeaderItem2";
            this.barHeaderItem_TenTK.Id = 8;
            this.barHeaderItem_TenTK.Name = "barHeaderItem_TenTK";
            // 
            // barStaticItem
            // 
            this.barStaticItem.Caption = "Tài khoản :";
            this.barStaticItem.Id = 9;
            this.barStaticItem.Name = "barStaticItem";
            // 
            // barStaticItem_TenTK
            // 
            this.barStaticItem_TenTK.Caption = "barStaticItem3";
            this.barStaticItem_TenTK.Id = 10;
            this.barStaticItem_TenTK.Name = "barStaticItem_TenTK";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barButtonItem1,
            this.barStaticItem2,
            this.barEditItem1,
            this.barEditItem2,
            this.barButtonItem2,
            this.barHeaderItem1,
            this.barHeaderItem_TenTK,
            this.barStaticItem,
            this.barStaticItem_TenTK});
            this.fluentFormDefaultManager1.MaxItemId = 11;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemConditionalType1});
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 560);
            this.ControlContainer = this.MainContainer;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemConditionalType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_Phong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_DangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_DichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_NhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_HoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_VatTu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_KhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_Kho;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraRichEdit.Design.RepositoryItemConditionalType repositoryItemConditionalType1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_TaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_ThongTinTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_DanhSachTK;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_NhaCC;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem_TenTK;
        private DevExpress.XtraBars.BarStaticItem barStaticItem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem_TenTK;
    }
}