CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

CREATE TABLE NhanVien(
	maNhanVien INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	hoLot NVARCHAR(100),
	ten NVARCHAR(50) NOT NULL,
	soCMND varchar(20) NOT NULL UNIQUE,
	sdt VARCHAR(20),
	diaChi NVARCHAR(100),
	gioiTinh NVARCHAR(10) NOT NULL CHECK(gioiTinh in ('Nam',N'Nữ')),
	chucVu NVARCHAR(30) NOT NULL,
	ngayLam DATE NOT NULL,
)
GO

CREATE TABLE TaiKhoan(
	maTaiKhoan INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	maNhanVien INT NOT NULL CONSTRAINT fk_TK_NV FOREIGN KEY(maNhanVien) REFERENCES NhanVien(maNhanVien),
	tenTaiKhoan nvarchar(100),
	matKhau varchar(50)
)
GO

CREATE TABLE KhuVuc(
	maKhuVuc INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	tenKhuVuc NVARCHAR(100) NOT NULL,
	trangThai NVARCHAR(100) NOT NULL,
	soLuongBan INT
)
GO

CREATE TABLE Ban(
	maBan INT IDENTITY(1, 1) NOT NULL UNIQUE,
	maKhuVuc INT NOT NULL,
	tenBan NVARCHAR(20) NOT NULL,
	trangThai NVARCHAR(100) NOT NULL,
	PRIMARY KEY(maBan, maKhuVuc),
	CONSTRAINT fk_Ban_KV FOREIGN KEY(maKhuVuc) REFERENCES KhuVuc(maKhuVuc)
)
GO

CREATE TABLE LoaiThucPham(
	maLoaiTP INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	tenLoaiTP NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE ThucPham(
	maTP INT IDENTITY(1,1) NOT NULL UNIQUE,
	maLoaiTP INT NOT NULL,
	tenTP NVARCHAR(100),
	dvt NVARCHAR(50),
	donGia DECIMAL ,
	PRIMARY KEY(maTP, maLoaiTP),
	CONSTRAINT fk_TP_LoaiTP FOREIGN KEY(maLoaiTP) REFERENCES LoaiThucPham(maLoaiTP)
)
GO

CREATE TABLE KhachHang(
	maKH INT IDENTITY NOT NULL,
	tenKH NVARCHAR(100),
	diemTichLuy INT,
	PRIMARY KEY(maKH)
)
GO

CREATE TABLE HoaDon(
	maHD INT IDENTITY(1, 1) NOT NULL,
	maNhanVien INT NOT NULL CONSTRAINT fk_HD_NV FOREIGN KEY(maNhanVien) REFERENCES NhanVien(maNhanVien),
	maBan INT NOT NULL CONSTRAINT fk_HD_Ban FOREIGN KEY(maBan) REFERENCES Ban(maBan),
	ngayLap DATE NOT NULL,
	phuThu DECIMAL,
	giamGia NVARCHAR(4),
	maKH INT CONSTRAINT fk_HD_KH FOREIGN KEY(maKH) REFERENCES KhachHang(maKH),
	tongTien DECIMAL  NOT NULL,
	checkout BIT,--kiểm tra hóa đơn đã được thanh toán chưa
	PRIMARY KEY(maHD, maNhanVien, maBan),
)
GO

CREATE TABLE ChiTietHoaDon(
	maCTHD INT IDENTITY(1, 1) NOT NULL,
	maBan INT NOT NULL,
	maTP INT NOT NULL,
	donGia DECIMAL,
	soLuong INT,
	thanhTien DECIMAL,
	PRIMARY KEY(maCTHD, maBan, maTP),
	CONSTRAINT fk_CTHD_Ban FOREIGN KEY(maBan) REFERENCES Ban(maBan),
	CONSTRAINT fk_CTHD_TP FOREIGN KEY(maTP) REFERENCES ThucPham(maTP)
)
GO

--CREATE TABLE NhaCungCap(
--	maNCC INT IDENTITY NOT NULL,
--	tenNCC nvarchar(100),
--	sdt varchar(20),
--	diaChi INT,
--	PRIMARY KEY(maNCC)
--)
--GO

--CREATE TABLE HoaDonNhapHang(
--	maHD INT IDENTITY(1, 1) NOT NULL,
--	maTaiKhoan INT NOT NULL CONSTRAINT fk_HD_TK FOREIGN KEY(maTaiKhoan) REFERENCES TaiKhoan(maTaiKhoan),
--	maNCC INT NOT NULL CONSTRAINT fk_HD_NCC FOREIGN KEY(maNCC) REFERENCES NhaCungCap(maNCC),
--	ngayLap DATE NOT NULL,
--	tongTien DECIMAL  NOT NULL,
--	checkout BIT,--kiểm tra hóa đơn đã được thanh toán chưa
--	PRIMARY KEY(maHD, maTaiKhoan),
--)
--GO

--insert admin---

INSERT INTO dbo.NhanVien VALUES(N'', N'admin', 'null', 'null', 'error', 'Nam', N'admin', GETDATE())
INSERT INTO dbo.TaiKhoan VALUES(1,'admin','123')

--insert khu vực bàn
INSERT INTO dbo.KhuVuc VALUES(N'Khu vực 1', N'Sử dụng', 50)
INSERT INTO dbo.KhuVuc VALUES(N'Khu vực 2', N'Sử dụng', 50)
INSERT INTO dbo.KhuVuc VALUES(N'Khu vực 3', N'Sử dụng', 50)

---- insert 50 bàn ăn


DECLARE @i INT = 1
WHILE @i <= 50
BEGIN
	INSERT INTO dbo.Ban VALUES(1, N'Bàn '+CAST(@i AS nvarchar(10)), N'Trống')
	SET @i = @i + 1
END

-- insert Loại thực phẩm
INSERT INTO dbo.LoaiThucPham VALUES(N'Thức ăn')	
INSERT INTO dbo.LoaiThucPham VALUES(N'Thức uống')
GO
--insert thực đơn
INSERT INTO dbo.ThucPham VALUES(1, N'Hủ tiếu',null,20000)
INSERT INTO dbo.ThucPham VALUES(1, N'Khoai tây chiên',null,18000)
INSERT INTO dbo.ThucPham VALUES(1, N'Mì xào bò',null,20000)
INSERT INTO dbo.ThucPham VALUES(1, N'Mì xào trứng',null,18000)

INSERT INTO dbo.ThucPham VALUES(2, N'Cafe truyền thống',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Cafe cappochino',null,22000)
INSERT INTO dbo.ThucPham VALUES(2, N'Cafe espreso',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà đào',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà sữa kiwi',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà sữa bạc hà',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà xanh táo',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà xanh kiwi',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Trà xanh chanh dây',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố chuối',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố đu đủ',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố táo',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố sapoche',null,18000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố bơ',null,25000)
INSERT INTO dbo.ThucPham VALUES(2, N'Sinh tố cam',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Rau má sữa',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Nước ép cam',null,20000)
INSERT INTO dbo.ThucPham VALUES(2, N'Rau má',null,15000)
INSERT INTO dbo.ThucPham VALUES(2, N'Kem khoai môn',null,22000)
INSERT INTO dbo.ThucPham VALUES(2, N'Kem sầu riêng',null,22000)
INSERT INTO dbo.ThucPham VALUES(2, N'Kem dừa',null,22000)