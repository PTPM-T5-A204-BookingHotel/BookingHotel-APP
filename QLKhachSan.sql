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
	TenCV			nvarchar(30) unique not null check(TenCV<>''),
	constraint pk_MaCV_ChucVu primary key(MaCV)
)

insert into ChucVu values 
(N'Quản lý'), (N'Lễ tân'), (N'Lao công'), (N'Phục vụ'), (N'Bảo vệ'), (N'Đầu bếp')

create table NhanVien 
(
	MaNV            int identity,
	HoTenNV         nvarchar(50)	not null check (HoTenNV <> ''),
	MaCV			int				not null,
	GioiTinhNV		nvarchar(5)		not null check (GioiTinhNV = N'Nam' or GioiTinhNV = N'Nữ'),
	CCCDNV			varchar(12)		not null check (CCCDNV <> '') unique,
	SoDienThoaiNV   varchar(10)		not null check (SoDienThoaiNV <> ''),
	NgaySinhNV      date			not null check (YEAR(GETDATE()) - YEAR(NgaySinhNV) >= 18),
	DiaChiNV		nvarchar(max)	not null check (DiaChiNV <> ''),
	AnhNV			nvarchar(max),
	EmailNV			varchar(100),
	constraint pk_MaNV_NhanVien primary key (MaNV),
	constraint fk_MaCV_NhanVien foreign key (MaCV) references ChucVu(MaCV),
)

insert into NhanVien(HoTenNV,MaCV,GioiTinhNV,CCCDNV,SoDienThoaiNV,NgaySinhNV,DiaChiNV) values 
(N'Trần Đức Nhật Nam',	1,	N'Nam',	'012345678963',	'0987654321', '27/07/2002', N'TPHCM'),
(N'Nguyễn Thị Thương',	2,	N'Nữ',	'013579135792',	'0213355779', '12/12/2000',	N'TPHCM'),
(N'Phan Gia Huy',		3,	N'Nam',	'024682468001',	'0224466880', '11/09/2001',	N'TPHCM'),
(N'Huỳnh Thế Bảo',		4,	N'Nam',	'099988877774',	'0111222333', '01/01/1999', N'TPHCM'),
(N'Nguyễn Thanh Tâm',	4,	N'Nữ',	'022244466676',	'0999777555', '24/06/2003',	N'TPHCM')


create table KhachHang 
(
	MaKH		int identity,
	CCCDKH		varchar(12)		not null check (CCCDKH<>'') unique,
	HoTenKH		nvarchar(50)	not null check (HoTenKH<>''),
	GioiTinhKH	nvarchar(5)		not null check (GioiTinhKH = N'Nam' or GioiTinhKH = N'Nữ'),
	DiaChiKH	nvarchar(max)	not null check (DiaChiKH<>''),
	SDTKH		varchar(10)		not null check (SDTKH<>''),
	AnhKH		nvarchar(max),
	EmailKH		varchar(100),
	NgaySinhKH	date			not null,
	constraint pk_MaKH_KhachHang primary key (MaKH)
)

--insert into KhachHang(CCCDKH,HoTenKH,GioiTinhKH,DiaChiKH,SDTKH,NgaySinhKH) values 
--('012345678912', N'Thập Anh Hào',		N'Nam', N'TPHCM',	'0366764749','12/02/1999'),
--('022135478912', N'Tài Đại Duy Hùng',	N'Nam', N'TPHCM',	'0396197521','12/03/2000'),
--('034345678912', N'Nguyễn Song An',	N'Nữ',	N'Hà Nội',	'0366754749','12/04/2001'),
--('042535478912', N'Nguyễn Quốc Vương',N'Nam', N'TPHCM',	'0396194621','12/05/2002'),
--('052375678912', N'Trần Anh Tuán',	N'Nam', N'Đồng Nai','0366761569','12/06/2003')

create table VatTu 
(
	MaVT		varchar(50),
	TenVT		nvarchar(max) not null check(TenVT<>''),
	ThuongHieu	nvarchar(100),
	DonViTinh	nvarchar(10),
	SoLuong		int	default 0,
	DonGia		int default 0,
	GiaNhap		int default 0,
	AnhVT		nvarchar(max),
	constraint pk_MaVT_VatTu primary key (MaVT)
)

insert into VatTu(MaVT,TenVT,DonViTinh,SoLuong,DonGia,GiaNhap) values
('VT001',N'Nước có ga Coca','Lon',112,20000,5000),
('VT002',N'Nước có ga Pepsi','Lon',112,20000,5000),
('VT003',N'Nước có ga Fanta','Lon',112,20000,5000),
('VT004',N'Nước có ga 7 Up','Lon',112,20000,5000),
('VT005',N'Bia SaiGon','Lon',112,30000,10000)

--select * from VatTu

create table LoaiPhong
(
	MaLP	int identity,
	TenLP	nvarchar(max) not null check(TenLP<>''),
	GiaPH	int default 0,
	HinhLP	nvarchar(max),
	constraint pk_MaLP_LoaiPhong primary key (MaLP)
)

insert into LoaiPhong(TenLP,GiaPH) values
(N'Phòng Standard (STD)',	400000),
(N'Phòng Superior (SUP)',	800000),
(N'Phòng Deluxe (DLX)',		1600000),
(N'Phòng Suite (SUT)',		3200000)

--select * from LoaiPhong

create table Phong 
(
	MaPH	int identity,	
	TenPH	nvarchar(50) unique not null check(TenPH<>''),
	MaLP	int not null,
	Tang	int not null,
	TinhTrangPH	nvarchar(50) default N'Trống' check (TinhTrangPH = N'Trống' or TinhTrangPH = N'Đang sửa/dọn dẹp' or TinhTrangPH = N'Đang thuê'),
	constraint pk_MaPH_Phong primary key (MaPH),
	constraint fk_MaLP_Phong foreign key (MaLP) references LoaiPhong(MaLP)
)

insert into Phong(TenPH,MaLP,Tang) values 
(N'101', 1, 1), (N'102', 1, 1), (N'103', 1, 1), (N'104', 1, 1), (N'105', 1, 1), (N'106', 1, 1), (N'107', 2, 1), (N'108', 1, 1), (N'109', 1, 1), (N'110', 1, 1),
(N'201', 2, 2), (N'202', 1, 2), (N'203', 1, 2), (N'204', 2, 2), (N'205', 1, 2), (N'206', 1, 2), (N'207', 1, 2), (N'208', 2, 2), (N'209', 1, 2), (N'210', 1, 2),
(N'301', 2, 3), (N'302', 2, 3), (N'303', 1, 3), (N'304', 2, 3), (N'305', 1, 3), (N'306', 2, 3), (N'307', 1, 3), (N'308', 2, 3), (N'309', 1, 3), (N'310', 1, 3),
(N'401', 3, 4), (N'402', 2, 4), (N'403', 2, 4), (N'404', 3, 4), (N'405', 2, 4), (N'406', 2, 4), (N'407', 2, 4), (N'408', 3, 4), (N'409', 2, 4), (N'410', 2, 4),
(N'501', 4, 5), (N'502', 3, 5), (N'503', 3, 5), (N'504', 3, 5), (N'505', 4, 5), (N'506', 3, 5), (N'507', 3, 5), (N'508', 2, 5), (N'509', 3, 5), (N'510', 4, 5)

--select * from Phong

create table DichVu 
(
	MaDV	varchar(50),
	TenDV	nvarchar(max) not null check(TenDV<>''),
	GiaDV	int	default 0,
	MotaDV	nvarchar(max),
	constraint pk_MaDV_DichVu primary key (MaDV)
)

insert into DichVu values
('DV001',N'Chăm sóc thú cưng',		250000, N'Gồm: Tắm rửa, Cắt tỉa (lông, móng), Trông giữ thú cưng. Lưu ý: Áp dụng cho 1 thú cưng và trông giữ/1 ngày'),
('DV002',N'Vệ sinh xe (xe 4 bánh)',	200000,	N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt'),
('DV003',N'Vệ sinh xe (xe 2 bánh)',	100000,	N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt'),
('DV004',N'Giặt ủi quần áo',		100000,	N'Lưu ý: Áp dụng cho 1kg quần áo/1 lượt'),
('DV005',N'Massage toàn thân',		250000,	N'Lưu ý: Áp dụng cho 1 người/2 giờ'),
('DV006',N'Massage chân',			150000,	N'Lưu ý: Áp dụng cho 1 người/1 giờ'),
('DV007',N'Đặt suất ăn Buffet',		150000,	N'Lưu ý: Áp dụng cho 1 người/1 lượt (Thời gian 6:00 - 9:00 sáng)')

create table Quyen
(
	MaQuyen varchar(50),
	TenQuyen nvarchar(max) not null check(TenQuyen<>''),
	constraint pk_MaQuyen_Quyen primary key(MaQuyen)
)

insert into Quyen values
('Admin',N'Admin'),
('User',N'User'),
('Owner',N'Owner')

create table TaiKhoan 
(
	TenTK	varchar(50),
	MaNV	int,
	MatKhau varchar(30) not null,
	MaQuyen varchar(50),
	AnhTK	nvarchar(max),
	constraint pk_TenTK_TaiKhoan primary key (TenTK),
	constraint fk_MaNV_TaiKhoan foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_MaQuyen_TaiKhoan foreign key (MaQuyen) references Quyen(MaQuyen)
)

insert into TaiKhoan(TenTK,MaNV,MatKhau,MaQuyen) values
('Admin',1,'123','Admin'),
('User',2,'123','User')

insert into TaiKhoan(TenTK,MatKhau,MaQuyen) values
('Owner','123','Owner')

--select * from TaiKhoan

create table HoaDon 
(
	MaHD			varchar(10),
	MaKH			int	not null,
	MaPH			int	not null,
	TenTK			varchar(50),
	TGDatPhong		date,
	TGNhanPhong		datetime,
	TGTraPhong		datetime,
	SoNgayLuuTru	int default 0,
	SoLuongNguoi	int default 0,
	TongTien		int	default 0,
	TinhTrangHD		nvarchar(max) default N'Chưa thanh toán' check(TinhTrangHD = N'Chưa thanh toán' or TinhTrangHD = N'Đã thanh toán'),
	constraint pk_MaHD_HoaDon primary key (MaHD),
	constraint fk_MaKH_HoaDon foreign key (MaKH) references KhachHang(MaKH),
	constraint fk_MaPH_HoaDon foreign key (MaPH) references Phong(MaPH),
	constraint fk_TenTK_TaiKhoan foreign key (TenTK) references TaiKhoan(TenTK)
)

select * from HoaDon

delete from HoaDon_DichVu where MaHD = 'HD1'

delete from HoaDon_VatTu where MaHD = 'HD1'

delete from HoaDon where MaHD = 'HD1'


create table HoaDon_DichVu
(
	MaHD		varchar(10),
	MaDV		varchar(50),
	SoLuongDV	int,
	ThanhTienDV int,
	constraint pk_MaHD_MaDV_HoaDon_DichVu primary key (MaHD,MaDV),
	constraint fk_MaHD_HoaDon_DichVu foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_MaDV_HoaDon_DichVu foreign key (MaDV) references DichVu(MaDV)
)

select * from HoaDon_DichVu

create table HoaDon_VatTu
(
	MaHD		varchar(10),
	MaVT		varchar(50),
	SoLuongVT	int,
	ThanhTienVT int,
	constraint pk_MaHD_MaVT_HoaDon_VatTu primary key (MaHD,MaVT),
	constraint fk_MaHD_HoaDon_VatTu foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_MaVT_HoaDon_VatTu foreign key (MaVT) references VatTu(MaVT)
)

select * from HoaDon_VatTu

create table NhaCC
(
	MaNCC		varchar(50),
	TenNCC		nvarchar(max) not null check(TenNCC<>''),
	DiaChiNCC	nvarchar(100) not null check(DiaChiNCC<>''),
	SDTNCC		varchar(10)	not null check(SDTNCC<>''),
	constraint pk_MaNCC_NhaCC primary key(MaNCC)
)

insert into NhaCC values
('NCC001',N'Cty Cocacola','TP.HCM','0972727211'),
('NCC002',N'Cty Pepsi','TP.HCM','0982828288')

create table DatPhong
(
	MaDP int identity,
	Hoten nvarchar(max),
	Email varchar(100),
	SDT varchar(10),
	SoLuongTGoLai int,
	SoLuongNg int,
	ThoiGianNhanPhong date,
	HinhAnh nvarchar(max),
	TinhtrangDP nvarchar(50) default N'Chưa Check' check(TinhtrangDP=N'Chưa Check' or TinhtrangDP=N'Đã Check'),
	constraint pk_MaDP_DatPhong primary key(MaDP)
)


