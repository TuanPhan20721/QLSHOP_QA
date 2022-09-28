create database QlShop_QA
go
use QlShop_QA
go

create table chatLieu
(
	maChatLieu nvarchar(10) not null primary key,
	tenChatLieu nvarchar(30)
)
create table khach
(
	makhach nvarchar(10) not null primary key,
	tenkhach nvarchar(30),
	diachi nvarchar(30),
	dienthoai nvarchar(15)
)
create table hang
(
	maHang nvarchar(10) not null primary key,
	tenHang nvarchar(30),
	maChatLieu nvarchar(10),
	soLuong float,
	donGiaNhap float,
	donGiaBan float,
	anh nvarchar(200),
	ghiChu nvarchar(200),
	constraint fk_maCL foreign key(maChatLieu) references chatLieu(maChatLieu)
)
create table nhanVien
(
	maNhanVien nvarchar(10) not null primary key,
	tenNhanVien nvarchar(30),
	gioiTinh nvarchar(10),
	diaChi nvarchar(30),
	dienThoai nvarchar(15),
	ngaySinh datetime
)
create table HDBan
(
	maHDBan nvarchar(10) not null primary key,
	maNhanVien nvarchar(10),
	ngayBan datetime,
	maKhach nvarchar(10),
	tongTien float,
	constraint fk_maKhach foreign key(maKhach) references khach(maKhach),
	constraint fk_maNV foreign key(maNhanVien) references nhanVien(maNhanVien)
)
create table chiTietHDBan
(
	maHDBan nvarchar(10) not null,
	maHang nvarchar(10) not null,
	soLuong float,
	donGia float,
	giamGia float,
	thanhTien float,
	primary key(maHDBan,maHang),
	constraint fk_maHDB foreign key(maHDBan) references HDBan(maHDBan),
	constraint fk_maH foreign key(maHang) references hang(maHang)
)