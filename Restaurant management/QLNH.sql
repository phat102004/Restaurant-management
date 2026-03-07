use DoAn
CREATE TABLE NhanVien(
	ID_NhanVien char(10) not null primary key,
	HoTenNV nvarchar(50),
	SoDienThoai char(20),
	DiaChi nvarchar(100),
	ID_ChucVu char(10) not null,
	constraint fk_NV_CV foreign key (ID_ChucVu) references ChucVu(ID_ChucVu)
)

alter table NhanVien add CaLam nvarchar(20);


CREATE TABLE ChucVu(
	ID_ChucVu char(10) not null primary key, 
	TenChucVu nvarchar(50),
)

ALTER TABLE HoaDonTam
ADD CONSTRAINT FK_HoaDonTam_ThucDon
FOREIGN KEY (ID_MonAn) 
REFERENCES ThucDon(ID_MonAn)
ON DELETE CASCADE 
ON UPDATE CASCADE;

CREATE TABLE QuanLyLuong(
	ID_Luong char(10) not null, 
	ID_NhanVien char(10) not null, 
	Luong int,
	constraint PK_Luong primary key (ID_Luong),
	constraint FK_QLL_IDNV foreign key (ID_NhanVien) references NhanVien(ID_NhanVien)
)

CREATE TABLE ChamCong(
	ID_ChamCong char(10) not null, 
	ID_NhanVien char(10) not null, 
	ThoiGianVao datetime, 
	ThoiGianRa datetime,
	constraint PK_ChamCong primary key (ID_ChamCong),
	constraint FK_CC_IDNV foreign key (ID_NhanVien) references NhanVien(ID_NhanVien)
)

CREATE TABLE Admin(
	ID_Admin char(10) not null,
	HoTenAD nvarchar(50),
	Email char(50),
	MatKhau char(20),
	constraint PK_NhanVien primary key (ID_Admin)
)


select * from QuanLyQuyen
select * from ChucVu
CREATE TABLE QuanLyQuyen(
	ID_Role int identity(1,1 )not null,
	TenNguoiDN nvarchar(50),
	TenDangNhap nvarchar(50),
	MatKhau char(20),
	ID_ChucVu char(10),
	constraint fk_QLQ_CV foreign key (ID_ChucVu) references ChucVu(ID_ChucVu),
	constraint PK_Role primary key (ID_Role)
)
ALTER TABLE QuanLyQuyen
ADD ID_NhanVien CHAR(10);

ALTER TABLE QuanLyQuyen
ADD CONSTRAINT FK_QLQ_NV
FOREIGN KEY (ID_NhanVien) REFERENCES NhanVien(ID_NhanVien);


Select * from QuanLyQuyen
SELECT * 
FROM QuanLyQuyen
WHERE TenDangNhap LIKE 'nguyenvanb' 
  AND MatKhau LIKE '654321';
CREATE TABLE ThucDon(
	ID_MonAn char(10) not null,
	TenMon nvarchar(50), 
	Gia DECIMAL(18,2), 
	MoTa nvarchar(100),
	SoLuong int,
	ThanhTien decimal(18,2)
	constraint PK_ID_MonAn primary key (ID_MonAn)
)

ALTER TABLE ThucDon
ADD ID_LoaiMonAn CHAR(10);

ALTER TABLE ThucDon
ADD CONSTRAINT FK_ThucDon_LoaiMonAn
FOREIGN KEY (ID_LoaiMonAn) REFERENCES LoaiMonAn(ID_LoaiMonAn);

ALTER TABLE ThucDon DROP CONSTRAINT PK_ID_MonAn;
ALTER TABLE ThucDon DROP CONSTRAINT ID_LoaiMonAn;
ALTER TABLE ThucDon DROP CONSTRAINT FK_HoaDonTam_LoaiMonAn;

TRUNCATE TABLE HoaDonTam;

ALTER TABLE ThucDon ADD CONSTRAINT fk_HDT_TD FOREIGN KEY (ID_MonAn) REFERENCES ThucDon(ID_MonAn);
ALTER TABLE ThucDon ADD CONSTRAINT fk_HDT_Ban FOREIGN KEY (ID_Ban) REFERENCES Ban(ID_Ban);
ALTER TABLE ThucDon ADD CONSTRAINT FK_HoaDonTam_LoaiMonAn FOREIGN KEY (ID_LoaiMonAn) REFERENCES LoaiMonAn(ID_LoaiMonAn);

CREATE TABLE LoaiMonAn (
    ID_LoaiMonAn CHAR(10) PRIMARY KEY, -- Khóa chính
    TenLoai NVARCHAR(50) NOT NULL -- Tên loại món ăn
);

CREATE TABLE Ban(
	ID_Ban char(10) primary key,
	TenBan NVARCHAR(50) not null
);

ALTER TABLE Ban ADD TrangThai INT DEFAULT 0;

create table NguyenLieu(
ID_NL char(10) primary key,
TenNL nvarchar(40),
DonVi nvarchar(30),
SoLuong int,
Gia decimal(10,0)
)

alter table NguyenLieu add NgayHetHan date


use DoAn
select * from NguyenLieu

create table NhaCungCap(
ID_NCC char(10) primary key,
TenNCC nvarchar(50)
)

SELECT 
    name AS ConstraintName,
    OBJECT_NAME(parent_object_id) AS TableName,
    type_desc AS ConstraintType
FROM 
    sys.objects
WHERE 
    type_desc LIKE '%CONSTRAINT%' 
    AND OBJECT_NAME(parent_object_id) = 'DoanhThu';
CREATE TABLE HoaDonTam(
    ID_HDT INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(255),
    Gia DECIMAL(18,2),
    SoLuong INT,
    ThanhTien DECIMAL(18,2),
    TenBan NVARCHAR(255),
	ID_MonAn char(10),
	ID_Ban char(10),
	ID_LoaiMonAn CHAR(10),
	constraint fk_HDT_TD foreign key (ID_MonAn) references ThucDon(ID_MonAn),
	constraint fk_HDT_Ban foreign key (ID_Ban) references Ban(ID_Ban),
	FOREIGN KEY (ID_LoaiMonAn) REFERENCES LoaiMonAn(ID_LoaiMonAn)
);
alter table HoaDonTam add NgayTao date; 

ALTER TABLE HoaDon
ADD ID_NhanVien char(10);

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_NhanVien
FOREIGN KEY (ID_NhanVien) REFERENCES NhanVien(ID_NhanVien);

ALTER TABLE HoaDonTam
ADD ID_LoaiMonAn CHAR(10);

ALTER TABLE HoaDonTam
ADD CONSTRAINT FK_HoaDonTam_LoaiMonAn
FOREIGN KEY (ID_LoaiMonAn) REFERENCES LoaiMonAn(ID_LoaiMonAn);

CREATE PROCEDURE sp_GetCurrentDateTime
AS
BEGIN
    SELECT GETDATE() AS NgayTao;
END;
GO

CREATE TABLE HoaDon(
    ID_HD INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(255),
    Gia DECIMAL(18,2),
    SoLuong INT,
    ThanhTien DECIMAL(18,2),
    TenBan NVARCHAR(255),
	ID_MonAn char(10),
	ID_Ban char(10),
	ID_HDT INT, 
	ID_LoaiMonAn CHAR(10),
	constraint fk_HD_HDT foreign key (ID_HDT) references HoaDonTam(ID_HDT),
	constraint fk_HD_TD foreign key (ID_MonAn) references ThucDon(ID_MonAn),
	constraint fk_HD_Ban foreign key (ID_Ban) references Ban(ID_Ban),
	constraint fk_HD_LMA foreign key (ID_LoaiMonAn) references LoaiMonAn(ID_LoaiMonAn)
);
alter table HoaDon add NgayTao date; 

CREATE TABLE DoanhThu(
ID_DT INT IDENTITY(1,1) PRIMARY KEY,
TenMon NVARCHAR(255),
Gia DECIMAL(18,2),
SoLuong INT,
ThanhTien DECIMAL(18,2),
TenBan NVARCHAR(255),
NgayTao date,
ID_MonAn char(10),
ID_Ban char(10),
ID_HD INT, 
ID_LoaiMonAn CHAR(10),
constraint fk_DT_HD foreign key (ID_HD) references HoaDon(ID_HD),
constraint fk_DT_TD foreign key (ID_MonAn) references ThucDon(ID_MonAn),
constraint fk_DT_Ban foreign key (ID_Ban) references Ban(ID_Ban),
constraint fk_DT_LMA foreign key (ID_LoaiMonAn) references LoaiMonAn(ID_LoaiMonAn)
)

select * from DoanhThu
INSERT INTO DoanhThu (TenMon, Gia, SoLuong, TenBan, ThanhTien)
                                 SELECT TenMon, Gia, SoLuong, TenBan, SoLuong * Gia
                                 FROM HoaDonTam;
select * from HoaDonTam
select * from HoaDonTam CREATE TRIGGER trg_CalculateThanhTien
ON HoaDon
	AFTER INSERT, UPDATE
	AS
	BEGIN
    UPDATE HoaDon
    SET ThanhTien = i.Gia * i.SoLuong
    FROM HoaDon h
    INNER JOIN inserted i ON h.ID_HD = i.ID_HD
END;

select * from HoaDonTam CREATE TRIGGER trg_CalculateThanhTie
ON HoaDon
	AFTER INSERT, UPDATE
	AS
	BEGIN
    UPDATE HoaDon
    SET ThanhTien = i.Gia * i.SoLuong
    FROM HoaDon h
    INNER JOIN inserted i ON h.ID_HD = i.ID_HD
END;

create table NguyenLieu(
Id_NL int identity(1,1) primary key,
TenNL nvarchar(50),
SoLuong int,
DonVi nvarchar(20),
ID_NCC int,
constraint fk_NL_NCC foreign key (ID_NCC) references NhaCungCap(ID_NCC)
)
select * from NhaCungCap
create table NhaCungCap(
ID_NCC int identity(1,1) primary key,
TenNCC nvarchar(50)
)

use DoAn
DELETE FROM HoaDon;

select * from Ban
CREATE TABLE TrangThai (
    MaTrangThai INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,            
    SoLuong INT NOT NULL,                     
    TenBan NVARCHAR(50) NOT NULL,              
    TinhTrang nvarchar(30) NOT NULL DEFAULT 'Chưa hoàn thành',    
    ID_Ban char(10),
	ID_HDT int,

    CONSTRAINT FK_TrangThai_Ban 
    FOREIGN KEY (ID_Ban) REFERENCES Ban(ID_Ban),

    CONSTRAINT FK_TrangThai_HoaDonTam 
    FOREIGN KEY (ID_HDT) REFERENCES HoaDonTam(ID_HDT)
);


/*========================================================================*/
INSERT INTO NhanVien (ID_NhanVien, HoTenNV, SoDienThoai, DiaChi, ID_ChucVu)
VALUES
('NV001', N'Nguyễn Văn A', '0123456789', N'Cần Thơ','CV001'),
('NV002', N'Nguyễn Văn B', '0123456789', N'Vĩnh Long','CV002'),
('NV003', N'Nguyễn Văn C', '0123456789', N'TP.HCM','CV003'),
('NV004', N'Nguyễn Văn D', '0123456789', N'Hậu Giang','CV003');

insert into NguyenLieu values
(N'Thịt heo 3 chỉ',100,'Kg',1),
(N'Nước tương Nam Ngư Tam Thái Tử',50,'Chai',2),
(N'Đường',30,N'Bịch',3),
(N'Bột ngọt',50,N'Bịch',2)

insert into NhaCungCap values
(N'Công ty cung cấp thịt'),
(N'Công ty thực phẩm'),
(N'Tập đoàn gia vị')

INSERT INTO ChucVu (ID_ChucVu, TenChucVu)
VALUES 
('CV001', N'Bếp trưởng'),
('CV002', N'Quản lý'),
('CV003', N'Order');

insert into QuanLyQuyen values
('Admin',N'trần Tiến Phát', 'Admin','12345'),
('user',N'ngyễn văn a', 'User','12345')

--Khai vị cao cấp (ID_LoaiMonAn = 'L01')
INSERT INTO ThucDon (ID_MonAn, TenMon, Gia, MoTa,SoLuong, ID_LoaiMonAn) VALUES
('MA001', N'Súp tôm hùm Alaska', 1200000, N'Súp tôm hùm Alaska tươi ngon, đậm vị',1, 'L01'),
('MA002', N'Súp vi cá mập hầm bào ngư', 2500000, N'Vi cá mập và bào ngư hầm theo phong cách hoàng gia',1, 'L01'),
('MA003', N'Gan ngỗng áp chảo sốt rượu vang đỏ', 1800000, N'Gan ngỗng mềm mịn áp chảo, ăn kèm sốt rượu vang đỏ',1, 'L01'),
('MA004', N'Sashimi cá ngừ đại dương', 1500000, N'Cá ngừ đại dương tươi sống, cắt lát mỏng',1, 'L01');
--Món chính cao cấp (ID_LoaiMonAn = 'L02')
INSERT INTO ThucDon (ID_MonAn, TenMon, Gia, MoTa,SoLuong, ID_LoaiMonAn) VALUES
('MA005', N'Bò Wagyu A5 nướng sốt nấm truffle', 3200000, N'Thịt bò Wagyu A5 thượng hạng, sốt nấm truffle',1, 'L02'),
('MA006', N'Tôm hùm Canada hấp bơ tỏi', 2800000, N'Tôm hùm Canada tươi, hấp bơ tỏi',1, 'L02'),
('MA007', N'Cá tuyết nướng sốt bơ chanh', 2200000, N'Cá tuyết nướng mềm thơm, sốt bơ chanh',1, 'L02'),
('MA008', N'Sườn cừu nướng sốt rượu vang đỏ', 2700000, N'Sườn cừu nướng, ăn kèm sốt rượu vang đỏ',1, 'L02');
--Tráng miệng cao cấp (ID_LoaiMonAn = 'L03')
INSERT INTO ThucDon (ID_MonAn, TenMon, Gia, MoTa,SoLuong, ID_LoaiMonAn) VALUES
('MA009', N'Bánh mousse sô cô la đen 85%', 350000, N'Bánh mousse sô cô la đen nguyên chất 85%',1, 'L03'),
('MA010', N'Kem matcha Nhật Bản phủ đậu đỏ', 400000, N'Kem matcha Nhật Bản ăn kèm đậu đỏ ngọt bùi',1, 'L03'),
('MA011', N'Bánh tiramisu rượu rum', 450000, N'Tiramisu đậm vị rượu rum',1, 'L03'),
('MA012', N'Bánh flan trứng cá muối', 500000, N'Bánh flan mềm mịn, phủ trứng cá muối', 1,'L03');
-- Món nước cao cấp (ID_LoaiMonAn = 'L04')
INSERT INTO ThucDon (ID_MonAn, TenMon, Gia, MoTa,SoLuong, ID_LoaiMonAn) VALUES
('MA013', N'Rượu vang đỏ Pháp Château Margaux', 5000000, N'Rượu vang đỏ Pháp hảo hạng',1, 'L04'),
('MA014', N'Champagne Dom Pérignon Vintage', 8500000, N'Champagne hảo hạng', 1,'L04'),
('MA015', N'Trà ô long Đài Loan hảo hạng', 600000, N'Trà ô long Đài Loan thơm ngon', 1,'L04'),
('MA016', N'Cà phê Arabica Ethiopia pha máy', 400000, N'Cà phê Arabica nguyên chất từ Ethiopia', 1,'L04');

INSERT INTO LoaiMonAn(ID_LoaiMonAn, TenLoai) VALUES 
('L01', N'Khai vị'),
('L02', N'Món chính'), 
('L03', N'Tráng miệng'),
('L04', N'Món nước');

INSERT INTO Ban VALUES
('B001', N'Bàn 2 người'),
('B002', N'Bàn 3 người'),
('B003', N'Bàn vip'),
('B004', N'Bàn Svip'),
('B005', N'Bàn 4 người')

INSERT INTO QuanLyQuyen (TenNguoiDN, TenDangNhap, MatKhau, ID_ChucVu, ID_NhanVien)
VALUES 
( N'Nguyễn Văn A', 'nguyenvana', '123456', 'CV001', 'NV001'),
(N'Nguyễn Văn B', 'nguyenvanb', '654321', 'CV002', 'NV002'),
( N'Nguyễn Văn D', 'nguyenvand', 'abcdef', 'CV003', 'NV003');

/*========================================================================*/

Select ID_NhanVien, nv.HoTenNV, nv.SoDienThoai, nv.DiaChi, cv.TenChucVu
from NhanVien nv
join ChucVu cv on cv.ID_ChucVu = nv.ID_ChucVu

insert into HoaDon(TenMon, Gia, SoLuong, TenBan, ThanhTien)
select HDT.TenBan,HDT.Gia, HDT.SoLuong, HDT.TenBan, HDT.ThanhTien
from HoaDonTam HDT

insert into NhanVien(ID_NhanVien, HoTenNV, SoDienThoai,DiaChi, TenChucVu) values ('2',N'4','5',N'6',N'7')

INSERT INTO HoaDonTam (TenMon, SoLuong, TenBan)
SELECT TD.TenMon, TD.SoLuong, B.TenBan
FROM ThucDon TD
JOIN LoaiMonAn LMA ON LMA.ID_LoaiMonAn = TD.ID_LoaiMonAn
JOIN Ban B ON B.ID_Ban = HDT.ID_Ban
JOIN HoaDonTam HDT ON HDT.ID_Ban = B.ID_Ban;

SELECT TenMon, SoLuong, Gia, ThanhTien FROM HoaDon WHERE TenBan = N'Bàn 2 người';

SELECT QLQ.ID_Role, QLQ.TenNguoiDN, QLQ.TenDangNhap, QLQ.MatKhau, 
                            NV.ID_NhanVien, CV.TenChucVu
                            FROM QuanLyQuyen QLQ
                            INNER JOIN NhanVien NV ON QLQ.ID_NhanVien = NV.ID_NhanVien
                            INNER JOIN ChucVu CV ON QLQ.ID_ChucVu = CV.ID_ChucVu
							
							select * from Ban