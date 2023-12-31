USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](30) NOT NULL,
 CONSTRAINT [pk_MaCV_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaDP] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](max) NULL,
	[Email] [varchar](100) NULL,
	[SDT] [varchar](10) NULL,
	[SoLuongTGoLai] [int] NULL,
	[SoLuongNg] [int] NULL,
	[ThoiGianNhanPhong] [date] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[TinhtrangDP] [nvarchar](50) NULL,
 CONSTRAINT [pk_MaDP_DatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [varchar](50) NOT NULL,
	[TenDV] [nvarchar](max) NOT NULL,
	[GiaDV] [int] NULL,
	[MotaDV] [nvarchar](max) NULL,
 CONSTRAINT [pk_MaDV_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaPH] [int] NOT NULL,
	[TenTK] [varchar](50) NULL,
	[TGDatPhong] [date] NULL,
	[TGNhanPhong] [datetime] NULL,
	[TGTraPhong] [datetime] NULL,
	[SoNgayLuuTru] [int] NULL,
	[SoLuongNguoi] [int] NULL,
	[TongTien] [int] NULL,
	[TinhTrangHD] [nvarchar](max) NULL,
 CONSTRAINT [pk_MaHD_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_DichVu]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_DichVu](
	[MaHD] [varchar](10) NOT NULL,
	[MaDV] [varchar](50) NOT NULL,
	[SoLuongDV] [int] NULL,
	[ThanhTienDV] [int] NULL,
 CONSTRAINT [pk_MaHD_MaDV_HoaDon_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_VatTu]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_VatTu](
	[MaHD] [varchar](10) NOT NULL,
	[MaVT] [varchar](50) NOT NULL,
	[SoLuongVT] [int] NULL,
	[ThanhTienVT] [int] NULL,
 CONSTRAINT [pk_MaHD_MaVT_HoaDon_VatTu] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[CCCDKH] [varchar](12) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[GioiTinhKH] [nvarchar](5) NOT NULL,
	[DiaChiKH] [nvarchar](max) NOT NULL,
	[SDTKH] [varchar](10) NOT NULL,
	[AnhKH] [nvarchar](max) NULL,
	[EmailKH] [varchar](100) NULL,
	[NgaySinhKH] [date] NOT NULL,
 CONSTRAINT [pk_MaKH_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLP] [int] IDENTITY(1,1) NOT NULL,
	[TenLP] [nvarchar](max) NOT NULL,
	[GiaPH] [int] NULL,
	[HinhLP] [nvarchar](max) NULL,
 CONSTRAINT [pk_MaLP_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](max) NOT NULL,
	[DiaChiNCC] [nvarchar](100) NOT NULL,
	[SDTNCC] [varchar](10) NOT NULL,
 CONSTRAINT [pk_MaNCC_NhaCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[MaCV] [int] NOT NULL,
	[GioiTinhNV] [nvarchar](5) NOT NULL,
	[CCCDNV] [varchar](12) NOT NULL,
	[SoDienThoaiNV] [varchar](10) NOT NULL,
	[NgaySinhNV] [date] NOT NULL,
	[DiaChiNV] [nvarchar](max) NOT NULL,
	[AnhNV] [nvarchar](max) NULL,
	[EmailNV] [varchar](100) NULL,
 CONSTRAINT [pk_MaNV_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPH] [int] IDENTITY(1,1) NOT NULL,
	[TenPH] [nvarchar](50) NOT NULL,
	[MaLP] [int] NOT NULL,
	[Tang] [int] NOT NULL,
	[TinhTrangPH] [nvarchar](50) NULL,
 CONSTRAINT [pk_MaPH_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [varchar](50) NOT NULL,
	[TenQuyen] [nvarchar](max) NOT NULL,
 CONSTRAINT [pk_MaQuyen_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTK] [varchar](50) NOT NULL,
	[MaNV] [int] NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[MaQuyen] [varchar](50) NULL,
	[AnhTK] [nvarchar](max) NULL,
 CONSTRAINT [pk_TenTK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 11/12/2023 11:40:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatTu](
	[MaVT] [varchar](50) NOT NULL,
	[TenVT] [nvarchar](max) NOT NULL,
	[ThuongHieu] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[GiaNhap] [int] NULL,
	[AnhVT] [nvarchar](max) NULL,
 CONSTRAINT [pk_MaVT_VatTu] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (5, N'Bảo vệ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (6, N'Đầu bếp')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (3, N'Lao công')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (2, N'Lễ tân')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (4, N'Phục vụ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (1, N'Quản lý')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV001', N'Chăm sóc thú cưng', 250000, N'Gồm: Tắm rửa, Cắt tỉa (lông, móng), Trông giữ thú cưng. Lưu ý: Áp dụng cho 1 thú cưng và trông giữ/1 ngày')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV002', N'Vệ sinh xe (xe 4 bánh)', 200000, N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV003', N'Vệ sinh xe (xe 2 bánh)', 100000, N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV004', N'Giặt ủi quần áo', 100000, N'Lưu ý: Áp dụng cho 1kg quần áo/1 lượt')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV005', N'Massage toàn thân', 250000, N'Lưu ý: Áp dụng cho 1 người/2 giờ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV006', N'Massage chân', 150000, N'Lưu ý: Áp dụng cho 1 người/1 giờ')
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV], [MotaDV]) VALUES (N'DV007', N'Đặt suất ăn Buffet', 150000, N'Lưu ý: Áp dụng cho 1 người/1 lượt (Thời gian 6:00 - 9:00 sáng)')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaPH], [TenTK], [TGDatPhong], [TGNhanPhong], [TGTraPhong], [SoNgayLuuTru], [SoLuongNguoi], [TongTien], [TinhTrangHD]) VALUES (N'HD1', 1, 1, N'user', CAST(N'2023-12-11' AS Date), CAST(N'2023-12-11T23:34:25.617' AS DateTime), CAST(N'2023-12-11T23:34:59.600' AS DateTime), 2, 2, 1350000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaPH], [TenTK], [TGDatPhong], [TGNhanPhong], [TGTraPhong], [SoNgayLuuTru], [SoLuongNguoi], [TongTien], [TinhTrangHD]) VALUES (N'HD2', 4, 1, N'user', CAST(N'2023-12-09' AS Date), NULL, NULL, 2, 2, 1750000, N'Hủy')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaPH], [TenTK], [TGDatPhong], [TGNhanPhong], [TGTraPhong], [SoNgayLuuTru], [SoLuongNguoi], [TongTien], [TinhTrangHD]) VALUES (N'HD3', 5, 5, N'User', CAST(N'2023-12-11' AS Date), CAST(N'2023-12-11T23:35:44.743' AS DateTime), CAST(N'2023-12-11T23:36:33.577' AS DateTime), 2, 1, 1000000, N'Đã thanh toán')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaPH], [TenTK], [TGDatPhong], [TGNhanPhong], [TGTraPhong], [SoNgayLuuTru], [SoLuongNguoi], [TongTien], [TinhTrangHD]) VALUES (N'HD4', 2, 5, N'User', CAST(N'2023-12-20' AS Date), NULL, NULL, 3, 1, 1200000, N'Hủy')
GO
INSERT [dbo].[HoaDon_DichVu] ([MaHD], [MaDV], [SoLuongDV], [ThanhTienDV]) VALUES (N'HD1', N'DV002', 2, 400000)
INSERT [dbo].[HoaDon_DichVu] ([MaHD], [MaDV], [SoLuongDV], [ThanhTienDV]) VALUES (N'HD1', N'DV004', 1, 100000)
INSERT [dbo].[HoaDon_DichVu] ([MaHD], [MaDV], [SoLuongDV], [ThanhTienDV]) VALUES (N'HD2', N'DV003', 2, 200000)
INSERT [dbo].[HoaDon_DichVu] ([MaHD], [MaDV], [SoLuongDV], [ThanhTienDV]) VALUES (N'HD2', N'DV005', 3, 750000)
INSERT [dbo].[HoaDon_DichVu] ([MaHD], [MaDV], [SoLuongDV], [ThanhTienDV]) VALUES (N'HD3', N'DV004', 1, 100000)
GO
INSERT [dbo].[HoaDon_VatTu] ([MaHD], [MaVT], [SoLuongVT], [ThanhTienVT]) VALUES (N'HD1', N'VT002', 1, 20000)
INSERT [dbo].[HoaDon_VatTu] ([MaHD], [MaVT], [SoLuongVT], [ThanhTienVT]) VALUES (N'HD1', N'VT005', 1, 30000)
INSERT [dbo].[HoaDon_VatTu] ([MaHD], [MaVT], [SoLuongVT], [ThanhTienVT]) VALUES (N'HD3', N'VT002', 1, 20000)
INSERT [dbo].[HoaDon_VatTu] ([MaHD], [MaVT], [SoLuongVT], [ThanhTienVT]) VALUES (N'HD3', N'VT003', 1, 20000)
INSERT [dbo].[HoaDon_VatTu] ([MaHD], [MaVT], [SoLuongVT], [ThanhTienVT]) VALUES (N'HD3', N'VT004', 3, 60000)
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [CCCDKH], [HoTenKH], [GioiTinhKH], [DiaChiKH], [SDTKH], [AnhKH], [EmailKH], [NgaySinhKH]) VALUES (1, N'012345678912', N'Thập Anh Hào', N'Nam', N'TPHCM', N'0366764749', NULL, NULL, CAST(N'1999-02-12' AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [CCCDKH], [HoTenKH], [GioiTinhKH], [DiaChiKH], [SDTKH], [AnhKH], [EmailKH], [NgaySinhKH]) VALUES (2, N'022135478912', N'Tài Đại Duy Hùng', N'Nam', N'TPHCM', N'0396197521', NULL, NULL, CAST(N'2000-03-12' AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [CCCDKH], [HoTenKH], [GioiTinhKH], [DiaChiKH], [SDTKH], [AnhKH], [EmailKH], [NgaySinhKH]) VALUES (3, N'034345678912', N'Nguyễn Song An', N'Nữ', N'Hà Nội', N'0366754749', NULL, NULL, CAST(N'2001-04-12' AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [CCCDKH], [HoTenKH], [GioiTinhKH], [DiaChiKH], [SDTKH], [AnhKH], [EmailKH], [NgaySinhKH]) VALUES (4, N'042535478912', N'Nguyễn Quốc Vương', N'Nam', N'TPHCM', N'0396194621', NULL, NULL, CAST(N'2002-05-12' AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [CCCDKH], [HoTenKH], [GioiTinhKH], [DiaChiKH], [SDTKH], [AnhKH], [EmailKH], [NgaySinhKH]) VALUES (5, N'052375678912', N'Trần Anh Tuấn', N'Nam', N'Đồng Nai', N'0366761569', NULL, NULL, CAST(N'2003-06-12' AS Date))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([MaLP], [TenLP], [GiaPH], [HinhLP]) VALUES (1, N'Phòng Standard (STD)', 400000, NULL)
INSERT [dbo].[LoaiPhong] ([MaLP], [TenLP], [GiaPH], [HinhLP]) VALUES (2, N'Phòng Superior (SUP)', 800000, NULL)
INSERT [dbo].[LoaiPhong] ([MaLP], [TenLP], [GiaPH], [HinhLP]) VALUES (3, N'Phòng Deluxe (DLX)', 1600000, NULL)
INSERT [dbo].[LoaiPhong] ([MaLP], [TenLP], [GiaPH], [HinhLP]) VALUES (4, N'Phòng Suite (SUT)', 3200000, NULL)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC001', N'Cty Cocacola', N'TP.HCM', N'0972727211')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC], [DiaChiNCC], [SDTNCC]) VALUES (N'NCC002', N'Cty Pepsi', N'TP.HCM', N'0982828288')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [MaCV], [GioiTinhNV], [CCCDNV], [SoDienThoaiNV], [NgaySinhNV], [DiaChiNV], [AnhNV], [EmailNV]) VALUES (1, N'Trần Đức Nhật Nam', 1, N'Nam', N'012345678963', N'0987654321', CAST(N'2002-07-27' AS Date), N'TPHCM', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [MaCV], [GioiTinhNV], [CCCDNV], [SoDienThoaiNV], [NgaySinhNV], [DiaChiNV], [AnhNV], [EmailNV]) VALUES (2, N'Nguyễn Thị Thương', 2, N'Nữ', N'013579135792', N'0213355779', CAST(N'2000-12-12' AS Date), N'TPHCM', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [MaCV], [GioiTinhNV], [CCCDNV], [SoDienThoaiNV], [NgaySinhNV], [DiaChiNV], [AnhNV], [EmailNV]) VALUES (3, N'Phan Gia Huy', 3, N'Nam', N'024682468001', N'0224466880', CAST(N'2001-09-11' AS Date), N'TPHCM', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [MaCV], [GioiTinhNV], [CCCDNV], [SoDienThoaiNV], [NgaySinhNV], [DiaChiNV], [AnhNV], [EmailNV]) VALUES (4, N'Huỳnh Thế Bảo', 4, N'Nam', N'099988877774', N'0111222333', CAST(N'1999-01-01' AS Date), N'TPHCM', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [HoTenNV], [MaCV], [GioiTinhNV], [CCCDNV], [SoDienThoaiNV], [NgaySinhNV], [DiaChiNV], [AnhNV], [EmailNV]) VALUES (5, N'Nguyễn Thanh Tâm', 4, N'Nữ', N'022244466676', N'0999777555', CAST(N'2003-06-24' AS Date), N'TPHCM', NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (1, N'101', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (2, N'102', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (3, N'103', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (4, N'104', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (5, N'105', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (6, N'106', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (7, N'107', 2, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (8, N'108', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (9, N'109', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (10, N'110', 1, 1, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (11, N'201', 2, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (12, N'202', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (13, N'203', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (14, N'204', 2, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (15, N'205', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (16, N'206', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (17, N'207', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (18, N'208', 2, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (19, N'209', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (20, N'210', 1, 2, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (21, N'301', 2, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (22, N'302', 2, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (23, N'303', 1, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (24, N'304', 2, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (25, N'305', 1, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (26, N'306', 2, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (27, N'307', 1, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (28, N'308', 2, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (29, N'309', 1, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (30, N'310', 1, 3, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (31, N'401', 3, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (32, N'402', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (33, N'403', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (34, N'404', 3, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (35, N'405', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (36, N'406', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (37, N'407', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (38, N'408', 3, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (39, N'409', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (40, N'410', 2, 4, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (41, N'501', 4, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (42, N'502', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (43, N'503', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (44, N'504', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (45, N'505', 4, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (46, N'506', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (47, N'507', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (48, N'508', 2, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (49, N'509', 3, 5, N'Trống')
INSERT [dbo].[Phong] ([MaPH], [TenPH], [MaLP], [Tang], [TinhTrangPH]) VALUES (50, N'510', 4, 5, N'Trống')
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Admin', N'Admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'Owner', N'Owner')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (N'User', N'User')
GO
INSERT [dbo].[TaiKhoan] ([TenTK], [MaNV], [MatKhau], [MaQuyen], [AnhTK]) VALUES (N'Admin', 1, N'123', N'Admin', NULL)
INSERT [dbo].[TaiKhoan] ([TenTK], [MaNV], [MatKhau], [MaQuyen], [AnhTK]) VALUES (N'Owner', NULL, N'123', N'Owner', NULL)
INSERT [dbo].[TaiKhoan] ([TenTK], [MaNV], [MatKhau], [MaQuyen], [AnhTK]) VALUES (N'User', 2, N'123', N'User', NULL)
GO
INSERT [dbo].[VatTu] ([MaVT], [TenVT], [ThuongHieu], [DonViTinh], [SoLuong], [DonGia], [GiaNhap], [AnhVT]) VALUES (N'VT001', N'Nước có ga Coca', NULL, N'Lon', 112, 20000, 5000, NULL)
INSERT [dbo].[VatTu] ([MaVT], [TenVT], [ThuongHieu], [DonViTinh], [SoLuong], [DonGia], [GiaNhap], [AnhVT]) VALUES (N'VT002', N'Nước có ga Pepsi', NULL, N'Lon', 110, 20000, 5000, NULL)
INSERT [dbo].[VatTu] ([MaVT], [TenVT], [ThuongHieu], [DonViTinh], [SoLuong], [DonGia], [GiaNhap], [AnhVT]) VALUES (N'VT003', N'Nước có ga Fanta', NULL, N'Lon', 111, 20000, 5000, NULL)
INSERT [dbo].[VatTu] ([MaVT], [TenVT], [ThuongHieu], [DonViTinh], [SoLuong], [DonGia], [GiaNhap], [AnhVT]) VALUES (N'VT004', N'Nước có ga 7 Up', NULL, N'Lon', 109, 20000, 5000, NULL)
INSERT [dbo].[VatTu] ([MaVT], [TenVT], [ThuongHieu], [DonViTinh], [SoLuong], [DonGia], [GiaNhap], [AnhVT]) VALUES (N'VT005', N'Bia SaiGon', NULL, N'Lon', 111, 30000, 10000, NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChucVu__4CF92206E1E1FBAB]    Script Date: 11/12/2023 11:40:03 CH ******/
ALTER TABLE [dbo].[ChucVu] ADD UNIQUE NONCLUSTERED 
(
	[TenCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__DAF61A703195A76A]    Script Date: 11/12/2023 11:40:03 CH ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[CCCDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__DAF660C82FD29F1F]    Script Date: 11/12/2023 11:40:03 CH ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[CCCDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Phong__4CF9C7CF70CB5461]    Script Date: 11/12/2023 11:40:03 CH ******/
ALTER TABLE [dbo].[Phong] ADD UNIQUE NONCLUSTERED 
(
	[TenPH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DatPhong] ADD  DEFAULT (N'Chưa Check') FOR [TinhtrangDP]
GO
ALTER TABLE [dbo].[DichVu] ADD  DEFAULT ((0)) FOR [GiaDV]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [SoNgayLuuTru]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [SoLuongNguoi]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (N'Chưa thanh toán') FOR [TinhTrangHD]
GO
ALTER TABLE [dbo].[LoaiPhong] ADD  DEFAULT ((0)) FOR [GiaPH]
GO
ALTER TABLE [dbo].[Phong] ADD  DEFAULT (N'Trống') FOR [TinhTrangPH]
GO
ALTER TABLE [dbo].[VatTu] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[VatTu] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[VatTu] ADD  DEFAULT ((0)) FOR [GiaNhap]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_MaKH_HoaDon] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_MaKH_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_MaPH_HoaDon] FOREIGN KEY([MaPH])
REFERENCES [dbo].[Phong] ([MaPH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_MaPH_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_TenTK_TaiKhoan] FOREIGN KEY([TenTK])
REFERENCES [dbo].[TaiKhoan] ([TenTK])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_TenTK_TaiKhoan]
GO
ALTER TABLE [dbo].[HoaDon_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_MaDV_HoaDon_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[HoaDon_DichVu] CHECK CONSTRAINT [fk_MaDV_HoaDon_DichVu]
GO
ALTER TABLE [dbo].[HoaDon_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_MaHD_HoaDon_DichVu] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[HoaDon_DichVu] CHECK CONSTRAINT [fk_MaHD_HoaDon_DichVu]
GO
ALTER TABLE [dbo].[HoaDon_VatTu]  WITH CHECK ADD  CONSTRAINT [fk_MaHD_HoaDon_VatTu] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[HoaDon_VatTu] CHECK CONSTRAINT [fk_MaHD_HoaDon_VatTu]
GO
ALTER TABLE [dbo].[HoaDon_VatTu]  WITH CHECK ADD  CONSTRAINT [fk_MaVT_HoaDon_VatTu] FOREIGN KEY([MaVT])
REFERENCES [dbo].[VatTu] ([MaVT])
GO
ALTER TABLE [dbo].[HoaDon_VatTu] CHECK CONSTRAINT [fk_MaVT_HoaDon_VatTu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_MaCV_NhanVien] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_MaCV_NhanVien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [fk_MaLP_Phong] FOREIGN KEY([MaLP])
REFERENCES [dbo].[LoaiPhong] ([MaLP])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [fk_MaLP_Phong]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_MaNV_TaiKhoan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [fk_MaNV_TaiKhoan]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_MaQuyen_TaiKhoan] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [fk_MaQuyen_TaiKhoan]
GO
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD CHECK  (([TenCV]<>''))
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD CHECK  (([TinhtrangDP]=N'Chưa Check' OR [TinhtrangDP]=N'Đã Check'))
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD CHECK  (([TenDV]<>''))
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD CHECK  (([TinhTrangHD]=N'Chưa thanh toán' OR [TinhTrangHD]=N'Đã thanh toán' OR [TinhTrangHD]=N'Hủy'))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([CCCDKH]<>''))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([DiaChiKH]<>''))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([GioiTinhKH]=N'Nam' OR [GioiTinhKH]=N'Nữ'))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([HoTenKH]<>''))
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD CHECK  (([SDTKH]<>''))
GO
ALTER TABLE [dbo].[LoaiPhong]  WITH CHECK ADD CHECK  (([TenLP]<>''))
GO
ALTER TABLE [dbo].[NhaCC]  WITH CHECK ADD CHECK  (([DiaChiNCC]<>''))
GO
ALTER TABLE [dbo].[NhaCC]  WITH CHECK ADD CHECK  (([SDTNCC]<>''))
GO
ALTER TABLE [dbo].[NhaCC]  WITH CHECK ADD CHECK  (([TenNCC]<>''))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([CCCDNV]<>''))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([DiaChiNV]<>''))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([GioiTinhNV]=N'Nam' OR [GioiTinhNV]=N'Nữ'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([HoTenNV]<>''))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (((datepart(year,getdate())-datepart(year,[NgaySinhNV]))>=(18)))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([SoDienThoaiNV]<>''))
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD CHECK  (([TenPH]<>''))
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD CHECK  (([TinhTrangPH]=N'Trống' OR [TinhTrangPH]=N'Đang sửa/dọn dẹp' OR [TinhTrangPH]=N'Đang thuê'))
GO
ALTER TABLE [dbo].[Quyen]  WITH CHECK ADD CHECK  (([TenQuyen]<>''))
GO
ALTER TABLE [dbo].[VatTu]  WITH CHECK ADD CHECK  (([TenVT]<>''))
GO
