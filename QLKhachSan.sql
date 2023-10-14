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
)

insert into ChucVu values (N'Quản lý'), (N'Lễ tân'), (N'Lao công'), (N'Phục vụ'), (N'Bảo vệ'), (N'Đầu bếp')

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
	AnhNV			image,
	TGNhanViec		date not null,
	TGThoiViec		date,
	EmailNV			varchar(100),
	constraint pk_MaNV_NhanVien primary key (MaNV),
	constraint fk_MaCV_NhanVien foreign key (MaCV) references ChucVu(MaCV),
)

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
	DiaChiKH	nvarchar(max)	not null check (DiaChiKH<>''),
	SDTKH		varchar(10)		not null check (SDTKH<>''),
	AnhKH		image,
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
	MaVT		int identity,
	TenVT		nvarchar(max) not null check(TenVT<>''),
	ThuongHieu	nvarchar(100),
	DonViTinh	nvarchar(10),
	SoLuong		int	default 0,
	DonGia		int default 0,
	constraint pk_MaVT_VatTu primary key (MaVT)
)

create table LoaiPhong
(
	MaLP	int identity,
	TenLP	nvarchar(max) not null check(TenLP<>''),
	GiaPH	int default 0,
	constraint pk_MaLP_LoaiPhong primary key (MaLP)
)

insert into LoaiPhong values
(N'Phòng Standard (STD)',	400000),
(N'Phòng Superior (SUP)',	800000),
(N'Phòng Deluxe (DLX)',		1500000),
(N'Phòng Superior (SUP)',	3000000)

create table Phong 
(
	MaPH	int identity,	
	TenPH	nvarchar(50) unique not null check(TenPH<>''),
	MaLP	int not null,
	Tang	int not null,
	TinhTrangPH	nvarchar(50) default N'Trống' check (TinhTrangPH = N'Trống' or TinhTrangPH = N'Đã đặt' or TinhTrangPH = N'Đang sửa/dọn' or TinhTrangPH = N'Đang thuê'),
	constraint pk_MaPH_Phong primary key (MaPH),
	constraint fk_MaLP_Phong foreign key (MaLP) references LoaiPhong(MaLP)
)

insert into Phong(TenPH,MaLP,Tang) values 
(N'101', 1, 1), (N'102', 1, 1), (N'103', 1, 1), (N'104', 1, 1), (N'105', 1, 1), (N'106', 1, 1), (N'107', 2, 1), (N'108', 1, 1), (N'109', 1, 1), (N'110', 1, 1),
(N'201', 2, 2), (N'202', 1, 2), (N'203', 1, 2), (N'204', 2, 2), (N'205', 1, 2), (N'206', 1, 2), (N'207', 1, 2), (N'208', 2, 2), (N'209', 1, 2), (N'210', 1, 2),
(N'301', 2, 3), (N'302', 2, 3), (N'303', 1, 3), (N'304', 2, 3), (N'305', 1, 3), (N'306', 2, 3), (N'307', 1, 3), (N'308', 2, 3), (N'309', 1, 3), (N'310', 1, 3),
(N'401', 3, 4), (N'402', 2, 4), (N'403', 2, 4), (N'404', 3, 4), (N'405', 2, 4), (N'406', 2, 4), (N'407', 2, 4), (N'408', 3, 4), (N'409', 2, 4), (N'410', 2, 4),
(N'501', 4, 5), (N'502', 3, 5), (N'503', 3, 5), (N'504', 3, 5), (N'505', 4, 5), (N'506', 3, 5), (N'507', 3, 5), (N'508', 2, 5), (N'509', 3, 5), (N'510', 4, 5)

create table DichVu 
(
	MaDV	int identity,
	TenDV	nvarchar(max) not null check(TenDV<>''),
	GiaDV	int	default 0,
	MotaDV	nvarchar(max),
	constraint pk_MaDV_DichVu primary key (MaDV)
)

insert into DichVu values
(N'Chăm sóc thú cưng',		250000, N'Gồm: Tắm rửa, Cắt tỉa (lông, móng), Trông giữ thú cưng. Lưu ý: Áp dụng cho 1 thú cưng và trông giữ/1 ngày'),
(N'Vệ sinh xe (xe 4 bánh)',	200000,	N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt'),
(N'Vệ sinh xe (xe 2 bánh)',	100000,	N'Lưu ý: Áp dụng cho 1 chiếc xe/1 lượt'),
(N'Giặt ủi quần áo',		100000,	N'Lưu ý: Áp dụng cho 1kg quần áo/1 lượt'),
(N'Massage toàn thân',		250000,	N'Lưu ý: Áp dụng cho 1 người/2 giờ'),
(N'Massage chân',			150000,	N'Lưu ý: Áp dụng cho 1 người/1 giờ'),
(N'Đặt suất ăn Buffet',		150000,	N'Lưu ý: Áp dụng cho 1 người/1 lượt (Thời gian 6:00 - 9:00 sáng)')

create table PhieuPhat
(
	MaPhieuPhat int identity,
	MaPH		int,
	MaKH		int,
	TieuDe		nvarchar(max) not null check(TieuDe<>''),
	NoiDung		nvarchar(max) not null check(NoiDung<>''),
	TienPhat	int default 0,
	TGLapPhieu	datetime not null,
	constraint pk_MaPhieuPhat_PhieuPhat primary key (MaPhieuPhat),
	constraint fk_MaKH_PhieuPhat foreign key (MaKH) references KhachHang(MaKH),
	constraint fk_MaPH_PhieuPhat foreign key (MaPH) references Phong(MaPH)
)

create table HoaDon 
(
	MaHD			int identity,
	MaKH			int	not null,
	MaPH			int	not null,
	TGNhanPhong		datetime not null,
	TGTraPhong		datetime not null,
	SoNgayLuuTru	int default 0,
	TongTien		int	default 0,
	MaPhieuPhat		int,
	GiamGia			int default 0,
	ThanhTienHD		int	default 0,
	constraint pk_MaHD_HoaDon primary key (MaHD),
	constraint fk_MaKH_HoaDon foreign key (MaKH) references KhachHang(MaKH),
	constraint fk_MaPH_HoaDon foreign key (MaPH) references Phong(MaPH),
	constraint fk_MaPhieuPhat_HoaDon foreign key (MaPhieuPhat) references PhieuPhat(MaPhieuPhat),
)

create table HoaDon_DichVu
(
	MaHD		int,
	MaDV		int,
	SoLuongDV	int,
	ThanhTienDV int,
	constraint pk_MaHD_MaDV_HoaDon_DichVu primary key (MaHD,MaDV),
	constraint fk_MaHD_HoaDon_DichVu foreign key (MaHD) references HoaDon(MaHD),
	constraint fk_MaDV_HoaDon_DichVu foreign key (MaDV) references DichVu(MaDV)
)

create table NhaCC
(
	MaNCC		int identity,
	TenNCC		nvarchar(max) not null check(TenNCC<>''),
	DiaChiNCC	nvarchar(100) not null check(DiaChiNCC<>''),
	SDTNCC		varchar(10)	not null check(SDTNCC<>''),
	constraint pk_MaNCC_NhaCC primary key(MaNCC)
)


create table NhapKho 
(
	MaNK			int identity,
	MaNV			int,
	MaNCC			int,
	MaVT			int,
	ThoiGianNhap	datetime not null,
	SoLuong			int	default 0 not null,
	DonGiaNhap		int	default 0 not null,
	constraint pk_MaNK_NhapKho primary key (MaNK),   
	constraint fk_MaNV_NhapKho foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_MaNCC_NhapKho foreign key (MaNCC) references NhaCC(MaNCC),
	constraint fk_MaVT_NhapKho foreign key (MaVT) references VatTu(MaVT)
)

create table Quyen
(
	MaQuyen int identity,
	TenQuyen nvarchar(max) not null check(TenQuyen<>''),
	constraint pk_MaQuyen_Quyen primary key(MaQuyen)
)

create table TaiKhoan 
(
	TenTK	varchar(50),
	MaNV	int,
	MatKhau varchar(30) not null,
	MaQuyen int,
	AnhTK	image,
	constraint pk_TenTK_TaiKhoan primary key (TenTK),
	constraint fk_MaNV_TaiKhoan foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_MaQuyen_TaiKhoan foreign key (MaQuyen) references Quyen(MaQuyen)
)

create table ManHinh
(
	MaMH varchar(50),
	TenMH nvarchar(max) not null check(TenMH<>''),
	constraint pk_MaMH_ManHinh primary key (MaMH)
)

create table TaiKhoan_ManHinh
(
	MaMH varchar(50),
	TenTK varchar(50),
	constraint pk_MaMH_TenTK_TaiKhoan_ManHinh primary key(MaMH,TenTK),
	constraint fk_MaMH_TaiKhoan_ManHinh foreign key(MaMH) references ManHinh(MaMH),
	constraint fk_TenTK_TaiKhoan_ManHinh foreign key(TenTK) references TaiKhoan(TenTK)
)