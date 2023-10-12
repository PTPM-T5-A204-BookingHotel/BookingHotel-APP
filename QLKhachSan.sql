use master
go
if DB_ID('QLKhachSan') is not null
   drop database QLKhachSan
create database QLKhachSan
go
use QLKhachSan
go

set dateformat dmy

create table ChucVu 
(
	MaCV			int  identity,
	TenCV			nvarchar(20) unique not null check(TenCV<>''),
	constraint pk_MaCV_ChucVu primary key(MaCV)
);

insert into ChucVu values (N'Quản lý'), (N'Lễ tân'), (N'Lao công'), (N'Phục vụ')

create table NhanVien 
(
	MaNV            int identity,
	HoTenNV         nvarchar(50)	not null check (HoTenNV <> ''),
	MaCV			int				not null,
	GioiTinhNV		nvarchar(5)		not null check (GioiTinhNV = N'Nam' or GioiTinhNV = N'Nữ'),
	CCCDNV			varchar(12)		not null check (CCCDNV <> '') unique,
	SoDienThoaiNV   varchar(10)		not null check (SoDienThoaiNV <> ''),
	NgaySinhNV      date			not null check (YEAR(GETDATE()) - YEAR(NgaySinhNV) >= 18),
	DiaChiNV		nvarchar(100)	not null check (DiaChiNV <> ''),
	AnhNV			nvarchar(max),
	TGNhanViec		date not null,
	TGThoiViec		date,
	EmailNV			varchar(100),
	constraint pk_MaNV_NhanVien primary key (MaNV),
	constraint fk_MaCV_NhanVien foreign key (MaCV) references ChucVu(MaCV),
);

insert into NhanVien(HoTenNV,MaCV,GioiTinhNV,CCCDNV,SoDienThoaiNV,NgaySinhNV,DiaChiNV,TGNhanViec) values 
(N'Trần Đức Nhật Nam',	1,	N'Nam',	'01234567896',	'0987654321', '27/07/2002', N'TPHCM',	'20/10/2022'),
(N'Nguyễn Thị Thương',	2,	N'Nữ',	'01357913579',	'0213355779', '12/12/2000',	N'TPHCM',	'10/10/2021'),
(N'Phan Gia Huy',		3,	N'Nam',	'02468246800',	'0224466880', '11/09/2001',	N'TPHCM',	'20/02/2022'),
(N'Huỳnh Thế Bảo',		4,	N'Nam',	'09998887777',	'0111222333', '01/01/1999', N'TPHCM',	'19/02/2022'),
(N'Nguyễn Thanh Tâm',	4,	N'Nữ',	'02224446667',	'0999777555', '24/06/2003',	N'TPHCM',	'30/12/2021')

create table KhachHang 
(
	MaKH		int identity,
	CCCDKH		varchar(12)		not null check (CCCDKH<>''),
	HoTenKH		nvarchar(30)	not null check (HoTenKH<>''),
	GioiTinhKH	nvarchar(5)		not null check (GioiTinhKH = N'Nam' or GioiTinhKH = N'Nữ'),
	DiaChiKH	nvarchar(50)	not null check (DiaChiKH<>''),
	SDTKH		varchar(10)		not null check (SDTKH<>''),
	AnhKH		nvarchar(max),
	EmailKH		varchar(100),
	constraint pk_MaKH_KhachHang primary key (MaKH)
);

insert into KhachHang(CCCDKH,HoTenKH,GioiTinhKH,DiaChiKH,SDTKH) values 
('012345678912', N'Thập Anh Hào',		N'Nam', N'TPHCM',	'0366764749'),
('022135478912', N'Tài Đại Duy Hùng',	N'Nam', N'TPHCM',	'0396197521'),
('034345678912', N'Nguyễn Song An',		N'Nam', N'Hà Nội',	'0366754749'),
('042535478912', N'Nguyễn Quốc Vương',  N'Nam', N'TPHCM',	'0396194621'),
('052375678912', N'Trần Anh Tuán',		N'Nam', N'Đồng Nai','0366761569')

create table LoaiPhong
(
	MaLP	int identity,
	TenLP	nvarchar(30),
	GiaPH	int default 0,
	constraint pk_MaLP_LoaiPhong primary key (MaLP)
);

insert into LoaiPhong values
(N'Phòng Standard (STD)',	400000),
(N'Phòng Superior (SUP)',	800000),
(N'Phòng Deluxe (DLX)',		1500000),
(N'Phòng Superior (SUP)',	3000000)

create table Phong 
(
	MaPH	int identity,	
	TenPH	nvarchar(10) not null check(TenPH<>''),
	MaLP	int not null,
	Tang	int not null,
	TinhTrangPH	nvarchar(50) default N'Trống' check (TinhTrangPH = N'Trống' or TinhTrangPH = N'Đã đặt' or TinhTrangPH = N'Đang sửa/dọn' or TinhTrangPH = N'Đang thuê'),
	constraint pk_MaPH_Phong primary key (MaPH),
	constraint fk_MaLP_Phong foreign key (MaLP) references LoaiPhong(MaLP)
);

insert into Phong(TenPH,MaLP,Tang) values 
(N'101', 1, 1), (N'102', 1, 1), (N'103', 1, 1), (N'104', 1, 1), (N'105', 1, 1), (N'106', 1, 1),
(N'201', 2, 2), (N'202', 1, 2), (N'203', 1, 2), (N'204', 2, 2), (N'205', 1, 2), (N'206', 1, 2),
(N'301', 2, 3), (N'302', 2, 3), (N'303', 1, 3), (N'304', 2, 3), (N'305', 1, 3), (N'306', 1, 3),
(N'401', 3, 4), (N'402', 2, 4), (N'403', 2, 4), (N'404', 3, 4), (N'405', 2, 4), (N'406', 2, 4),
(N'501', 4, 5), (N'502', 3, 5), (N'503', 4, 5), (N'504', 3, 5), (N'505', 4, 5), (N'506', 3, 5)

create table DichVu 
(
	MaDV	int identity,
	TenDV	nvarchar(100) not null check(TenDV<>''),
	GiaDV	int	default 0,
	MotaDV	nvarchar(100),
	constraint pk_MaDV_DichVu primary key (MaDV)
);

insert into DichVu values
(N'Chăm sóc thú cưng',		250000, N'Gồm: Tắm rửa, Cắt tỉa (lông, móng), Trông giữ thú cưng. Lưu ý: Áp dụng cho 1 thú cưng'),
(N'Vệ sinh xe (xe 4 bánh)',	200000,	N'Lưu ý: Áp dụng cho 1 chiếc xe'),
(N'Vệ sinh xe (xe 2 bánh)',	100000,	N'Lưu ý: Áp dụng cho 1 chiếc xe'),
(N'Giặt ủi quần áo',		100000,	N'Lưu ý: Áp dụng cho 1kg quần áo'),
(N'Massage toàn thân',		250000,	N'Lưu ý: Áp dụng cho 1 người trong 2 giờ'),
(N'Massage chân',			150000,	N'Lưu ý: Áp dụng cho 1 người trong 1 giờ'),
(N'Đặt suất ăn Buffet',		150000,	N'Lưu ý: Áp dụng cho 1 người (Thời gian 6:00 - 9:00 sáng)')

create table HoaDon 
(
	MaHD			int identity,
	MaKH			int	not null,
	MaPH			int	not null,
	TGNhanPhong		datetime not null,
	TGTraPhong		datetime not null,
	SoNgayLuuTru	int default 0,
	TongTien		int	default 0,
	TienPhat		int default 0,
	GiamGia			int default 0,
	ThanhTienHD		int	default 0,
	constraint pk_MaHD_HoaDon primary key (MaHD),
	constraint fk_MaKH_HoaDon foreign key (MaKH) references KhachHang(MaKH),
	constraint fk_MaPH_HoaDon foreign key (MaPH) references Phong(MaPH)
);

create table ChiTietHD
(
	MaHD		int,
	MaDV		int,
	SoLuongDV	int,
	ThanhTienDV int,
	constraint pk_MaHD_MaDV_ChiTietHD primary key (MaHD,MaDV),
	constraint fk_MaHD_ChiTietHD foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_MaDV_ChiTietHD foreign key (MaDV) references DichVu(MaDV)
);

create table NhaCC
(
	MaNCC		int identity,
	TenNCC		nvarchar(100) not null,
	DiaChiNCC	nvarchar(100) not null,
	SDTNCC		varchar(10) not null,
	constraint pk_MaNCC_NhaCC primary key(MaNCC)
)

create table VatTu 
(
	MaVT		int identity,
	TenVT		nvarchar(100) not null,
	ThuongHieu	nvarchar(100),
	DonViTinh	nvarchar(10),
	SoLuong		int	default 0,
	DonGia		int default 0,
	constraint pk_MaVT_VatTu primary key (MaVT)
);

create table NhapKho 
(
	MaNV			int,
	MaNCC			int,
	MaVT			int,
	ThoiGianNhap	datetime		not null,
	SoLuong			int	default 0	not null,
	DonGiaNhap		int	default 0	not null,
	constraint pk_MaNV_MaNCC_MaVT_NhapKho primary key (MaNV,MaNCC,MaVT),   
	constraint fk_MaNV_NhapKho foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_MaNCC_NhapKho foreign key (MaNCC) references NhaCC(MaNCC),
	constraint fk_MaVT_NhapKho foreign key (MaVT) references VatTu(MaVT)
);

create table Quyen
(
	MaQuyen int identity,
	TenQuyen nvarchar(100),
	constraint pk_MaQuyen_Quyen primary key(MaQuyen)
)

create table TaiKhoan 
(
	TenTK	varchar(50),
	MaNV	int,
	MatKhau varchar(30) not null,
	MaQuyen int,
	constraint pk_TenTK_TaiKhoan primary key (MaNV),
	constraint fk_MaNV_TaiKhoan foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_MaQuyen_TaiKhoan foreign key (MaQuyen) references Quyen(MaQuyen)
);