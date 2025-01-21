--tạo database 
create database StoreGUMAC


-- Tạo bảng Danh mục nhóm sản phẩm
CREATE TABLE NhomSP (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    tennhom NVARCHAR(150) NOT NULL,
    mota NVARCHAR(650)
)

-- Tạo bảng Danh mục nhà sản xuất
CREATE TABLE DMNSX (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    tennsx NVARCHAR(255) NOT NULL,
    quocgia NVARCHAR(100),
    mota NVARCHAR(MAX)
)

-- Tạo bảng Danh mục kho
CREATE TABLE DMKho (
	ID INT IDENTITY(1,1) PRIMARY KEY, 
    tenkho NVARCHAR(255) NOT NULL,
    dc NVARCHAR(255) NOT NULL,
    sodt NVARCHAR(15),
    succhua INT,  
    controng INT 
)
-- Tạo bảng Danh mục quần áo
CREATE TABLE DMQuanAo (
    ID INT IDENTITY(1,1) PRIMARY KEY, 
	msnhom int NOT NULL,
	mansx int NOT NULL,
    tensp NVARCHAR(100),
    giavon FLOAT,
    chatlieu NVARCHAR(100),
    kichthuoc NVARCHAR(50),
    mausac NVARCHAR(50),
    phongcach NVARCHAR(255),
    mota NVARCHAR(MAX),
    ngaysx DATE,
    hinh NVARCHAR(255),
    consp BIT,
    CONSTRAINT FK_NhomSp_msnhom FOREIGN KEY (msnhom) REFERENCES NhomSP(ID),
	CONSTRAINT FK_DMSX_mansx FOREIGN KEY (mansx) REFERENCES DMNSX(ID)
)

-- Tạo bảng Tồn kho
CREATE TABLE TONKHO (
   ID INT IDENTITY(1,1) PRIMARY KEY,
    msquanao  int NOT NULL,
	mskho int NOT NULL,
    slton FLOAT,
    CONSTRAINT FK_DMKho_mskho FOREIGN KEY (mskho) REFERENCES DMKho(ID),
    CONSTRAINT FK_DMQuanAo_msquanao FOREIGN KEY (msquanao) REFERENCES DMQuanAo(ID)
)

-- Tạo bảng Danh mục nhân viên
CREATE TABLE DMNV (
	ID INT IDENTITY(1,1) PRIMARY KEY,
    hoten NVARCHAR(255) NOT NULL,
    sodt NVARCHAR(15),
	taikhoan nvarchar(max),
	matkhau nvarchar(max)
)

-- Tạo bảng Danh mục nhà cung cấp
CREATE TABLE DMNCC (
	ID INT IDENTITY(1,1) PRIMARY KEY,
    tenncc NVARCHAR(255) NOT NULL,
    dc NVARCHAR(255) NOT NULL,
    sodt NVARCHAR(15)
)

-- Tạo bảng Danh mục cơ sở bán hàng
CREATE TABLE DMCSBH (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    tencsdh NVARCHAR(255) NOT NULL,
    dc NVARCHAR(255) NOT NULL,
    sodt NVARCHAR(15)
)

-- Tạo bảng Phiếu xuất kho
CREATE TABLE PhieuXK (
   ID INT IDENTITY(1,1) PRIMARY KEY,
    ngaylap DATE,
    mscsbh int,
    msnv int,
    ghichu NVARCHAR(MAX),
    CONSTRAINT FK_DMCSBH_mscsbh FOREIGN KEY (mscsbh) REFERENCES DMCSBH(ID),
    CONSTRAINT FK_DMNV_msnv  FOREIGN KEY (msnv) REFERENCES DMNV(ID)
)

-- Tạo bảng Phiếu nhập kho
CREATE TABLE PhieuNK (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    ngaylap DATE,
    mscsbh int,
    msnv int,
    mskho int,
	msncc int,
    ghichu NVARCHAR(MAX),
    FOREIGN KEY (mscsbh) REFERENCES DMCSBH(ID),
    FOREIGN KEY (msnv) REFERENCES DMNV(ID),
    FOREIGN KEY (mskho) REFERENCES DMKho(ID),
	FOREIGN KEY (msncc) REFERENCES DMNCC(ID)
)

-- Tạo bảng Chi tiết phiếu xuất kho
CREATE TABLE CTPhieuXK (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    msquanao int,
    sl FLOAT,
	msphieuxk int,
    FOREIGN KEY (msphieuxk) REFERENCES PhieuXK(ID),
    FOREIGN KEY (msquanao) REFERENCES DMQuanAo(ID)
)

-- Tạo bảng Chi tiết phiếu nhập kho
CREATE TABLE CTPhieuNK (
	ID INT IDENTITY(1,1) PRIMARY KEY,
    msquanao int,
    sl FLOAT,
	msphieunk int,
    FOREIGN KEY (msphieunk) REFERENCES PhieuNK(ID),
    FOREIGN KEY (msquanao) REFERENCES DMQuanAo(ID)
)


INSERT INTO NhomSP (tennhom, mota) VALUES 
(N'Áo Thun', N'Nhóm sản phẩm áo thun đa dạng màu sắc và chất liệu'),
(N'Áo Sơ Mi', N'Nhóm sản phẩm áo sơ mi thanh lịch cho công sở'),
(N'Quần Jean', N'Nhóm sản phẩm quần jean thời trang và năng động'),
(N'Quần Tây', N'Nhóm sản phẩm quần tây lịch sự và chuyên nghiệp'),
(N'Váy Đầm', N'Nhóm sản phẩm váy đầm phong cách và nữ tính'),
(N'Đồ Thể Thao', N'Nhóm sản phẩm dành cho vận động và thể thao'),
(N'Đồ Bộ', N'Nhóm sản phẩm bộ đồ mặc nhà tiện lợi'),
(N'Áo Khoác', N'Nhóm sản phẩm áo khoác bảo vệ khỏi thời tiết'),
(N'Phụ Kiện', N'Nhóm sản phẩm phụ kiện thời trang'),
(N'Giày Dép', N'Nhóm sản phẩm giày dép đa dạng kiểu dáng');

INSERT INTO DMNSX (tennsx, quocgia, mota) VALUES 
('Nike', N'Mỹ', N'Thương hiệu thời trang và thể thao hàng đầu thế giới'),
('Adidas', N'Đức', N'Nhà sản xuất đồ thể thao nổi tiếng toàn cầu'),
('Uniqlo', N'Nhật Bản', N'Thương hiệu thời trang đơn giản và tinh tế'),
('Puma', N'Đức', N'Thương hiệu thời trang và giày thể thao'),
('Zara', N'Tây Ban Nha', N'Nhà sản xuất thời trang hiện đại và phong cách'),
('H&M', N'Thụy Điển', N'Thời trang giá rẻ, phong cách trẻ trung'),
('Gucci', N'Ý', N'Thương hiệu thời trang cao cấp nổi tiếng'),
('Levi', N'Mỹ', N'Thương hiệu quần jean hàng đầu'),
('Chanel', N'Pháp', N'Thương hiệu cao cấp với phong cách thanh lịch'),
('Supreme', N'Mỹ', N'Thương hiệu thời trang streetwear nổi tiếng');


INSERT INTO DMKho (tenkho, dc, sodt, succhua, controng) VALUES 
(N'Kho Hà Nội', N'Số 1 Hoàng Quốc Việt, Hà Nội', '0241234567', 500, 200),
(N'Kho Đà Nẵng', N'Số 10 Nguyễn Văn Linh, Đà Nẵng', '02361234567', 300, 100),
(N'Kho TP.HCM', N'Số 5 Nguyễn Thị Minh Khai, TP.HCM', '0281234567', 700, 400),
(N'Kho Cần Thơ', N'Số 20 Lê Lợi, Cần Thơ', '02921234567', 400, 250),
(N'Kho Hải Phòng', N'Số 15 Trần Phú, Hải Phòng', '0312345678', 600, 300),
(N'Kho Nha Trang', N'Số 8 Hùng Vương, Nha Trang', '02581234567', 500, 350),
(N'Kho Vũng Tàu', N'Số 3 Lê Hồng Phong, Vũng Tàu', '02543211234', 450, 150),
(N'Kho Huế', N'Số 12 Nguyễn Huệ, Huế', '02341234567', 350, 150),
(N'Kho Bình Dương', N'Số 25 Đại lộ Bình Dương, Bình Dương', '02742345678', 400, 200),
(N'Kho Biên Hòa', N'Số 7 Đồng Khởi, Biên Hòa', '02511234567', 300, 150);

INSERT INTO DMQuanAo (msnhom, mansx, tensp, giavon, chatlieu, kichthuoc, mausac, phongcach, mota, ngaysx, hinh, consp) VALUES 
(1, 1, N'Áo Thun Basic', 150000, 'Cotton', 'M', N'Trắng', 'Casual', N'Áo thun chất liệu thoáng mát', '2023-12-01', 'basic_tshirt.jpg', 1),
(2, 2, N'Áo Sơ Mi Văn Phòng', 300000, 'Polyester', 'L', N'Xanh', 'Formal', N'Áo sơ mi lịch sự cho công sở', '2023-11-15', 'office_shirt.jpg', 1),
(3, 3, N'Quần Jean Rách', 500000, 'Denim', '32', N'Xanh', 'Street', N'Quần jean phong cách', '2023-10-10', 'ripped_jeans.jpg', 1),
(4, 4, N'Quần Tây Công Sở', 400000, 'Polyester', '34', N'Đen', 'Formal', N'Quần tây cao cấp cho công sở', '2023-09-05', 'office_pants.jpg', 1),
(5, 5, N'Váy Dạ Hội', 1200000, 'Satin', 'S', N'Đỏ', 'Elegant', N'Váy dành cho các sự kiện đặc biệt', '2023-11-01', 'gala_dress.jpg', 1),
(6, 6, N'Bộ Đồ Thể Thao', 700000, 'Nỉ', 'XL', N'Xám', 'Sport', N'Bộ đồ thể thao năng động', '2023-10-20', 'sports_wear.jpg', 1),
(7, 7, N'Đồ Bộ Mặc Nhà', 200000, 'Cotton', 'L', N'Hồng', 'Casual', N'Bộ đồ tiện lợi mặc ở nhà', '2023-08-01', 'home_wear.jpg', 1),
(8, 8, N'Áo Khoác Da', 2000000, 'Leather', 'M', N'Đen', 'Cool', N'Áo khoác phong cách mạnh mẽ', '2023-11-10', 'leather_jacket.jpg', 1),
(9, 9, N'Mũ Lưỡi Trai', 150000, 'Cotton', 'Free Size', N'Xanh', 'Casual', N'Phụ kiện thời trang', '2023-07-01', 'cap.jpg', 1),
(10, 10, N'Giày Sneaker', 800000, 'Vải Canvas', '42', N'Trắng', 'Sport', N'Giày sneaker thoải mái', '2023-10-25', 'sneakers.jpg', 1);

INSERT INTO DMNV (hoten, sodt, taikhoan, matkhau) VALUES 
(N'Nguyễn Văn A', '0123456789', 'nguyenvana', 'password123'),
(N'Trần Thị B', '0987654321', 'tranthib', 'password123'),
(N'Lê Văn C', '0912345678', 'levanc', 'password123'),
(N'Phạm Thị D', '0934567890', 'phamthid', 'password123'),
(N'Hoàng Văn E', '0923456789', 'hoangvane', 'password123'),
(N'Ngô Thị F', '0945678901', 'ngothif', 'password123'),
(N'Đỗ Văn G', '0956789012', 'dovang', 'password123'),
(N'Lý Thị H', '0967890123', 'lythih', 'password123'),
(N'Trương Văn I', '0978901234', 'truongvani', 'password123'),
(N'Vũ Thị J', '0989012345', 'vuthij', 'password123');

INSERT INTO DMNCC (tenncc, dc, sodt) VALUES 
(N'Công ty A', N'Hà Nội', '0123456789'),
(N'Công ty B', N'Đà Nẵng', '0987654321'),
(N'Công ty C', N'TP.HCM', '0912345678'),
(N'Công ty D', N'Cần Thơ', '0934567890'),
(N'Công ty E', N'Hải Phòng', '0923456789'),
(N'Công ty F', N'Nha Trang', '0945678901'),
(N'Công ty G', N'Vũng Tàu', '0956789012'),
(N'Công ty H', N'Huế', '0967890123'),
(N'Công ty I', N'Bình Dương', '0978901234'),
(N'Công ty J', N'Biên Hòa', '0989012345');

INSERT INTO DMCSBH (tencsdh, dc, sodt) VALUES 
(N'Cơ sở Hà Nội', N'Số 1 Hoàng Quốc Việt, Hà Nội', '0241234567'),
(N'Cơ sở Đà Nẵng', N'Số 10 Nguyễn Văn Linh, Đà Nẵng', '02361234567'),
(N'Cơ sở TP.HCM', N'Số 5 Nguyễn Thị Minh Khai, TP.HCM', '0281234567'),
(N'Cơ sở Cần Thơ', N'Số 20 Lê Lợi, Cần Thơ', '02921234567'),
(N'Cơ sở Hải Phòng', N'Số 15 Trần Phú, Hải Phòng', '0312345678'),
(N'Cơ sở Nha Trang', N'Số 8 Hùng Vương, Nha Trang', '02581234567'),
(N'Cơ sở Vũng Tàu', N'Số 3 Lê Hồng Phong, Vũng Tàu', '02543211234'),
(N'Cơ sở Huế', N'Số 12 Nguyễn Huệ, Huế', '02341234567'),
(N'Cơ sở Bình Dương', N'Số 25 Đại lộ Bình Dương, Bình Dương', '02742345678'),
(N'Cơ sở Biên Hòa', N'Số 7 Đồng Khởi, Biên Hòa', '02511234567');

INSERT INTO PhieuXK (ngaylap, mscsbh, msnv, ghichu) VALUES 
('2024-01-01', 1, 1, N'Xuất kho cho cơ sở Hà Nội'),
('2024-01-02', 2, 2, N'Xuất kho cho cơ sở Đà Nẵng'),
('2024-01-03', 3, 3, N'Xuất kho cho cơ sở TP.HCM'),
('2024-01-04', 4, 4, N'Xuất kho cho cơ sở Cần Thơ'),
('2024-01-05', 5, 5, N'Xuất kho cho cơ sở Hải Phòng'),
('2024-01-06', 6, 6, N'Xuất kho cho cơ sở Nha Trang'),
('2024-01-07', 7, 7, N'Xuất kho cho cơ sở Vũng Tàu'),
('2024-01-08', 8, 8, N'Xuất kho cho cơ sở Huế'),
('2024-01-09', 9, 9, N'Xuất kho cho cơ sở Bình Dương'),
('2024-01-10', 10, 10, N'Xuất kho cho cơ sở Biên Hòa');

INSERT INTO PhieuNK (ngaylap, mscsbh, msnv, mskho, msncc, ghichu) VALUES 
('2024-01-01', 1, 1, 1, 1, N'Nhập hàng từ nhà cung cấp A'),
('2024-01-02', 2, 2, 2, 2, N'Nhập hàng từ nhà cung cấp B'),
('2024-01-03', 3, 3, 3, 3, N'Nhập hàng từ nhà cung cấp C'),
('2024-01-04', 4, 4, 4, 4, N'Nhập hàng từ nhà cung cấp D'),
('2024-01-05', 5, 5, 5, 5, N'Nhập hàng từ nhà cung cấp E'),
('2024-01-06', 6, 6, 6, 6, N'Nhập hàng từ nhà cung cấp F'),
('2024-01-07', 7, 7, 7, 7, N'Nhập hàng từ nhà cung cấp G'),
('2024-01-08', 8, 8, 8, 8, N'Nhập hàng từ nhà cung cấp H'),
('2024-01-09', 9, 9, 9, 9, N'Nhập hàng từ nhà cung cấp I'),
('2024-01-10', 10, 10, 10, 10, N'Nhập hàng từ nhà cung cấp J');

INSERT INTO TONKHO (msquanao, mskho, slton) VALUES 
(1, 1, 50),
(2, 2, 40),
(3, 3, 30),
(4, 4, 60),
(5, 5, 70),
(6, 6, 80),
(7, 7, 90),
(8, 8, 100),
(9, 9, 110),
(10, 10, 120);

INSERT INTO CTPhieuXK (msquanao, sl, msphieuxk) VALUES 
(1, 10, 1),
(2, 15, 2),
(3, 20, 3),
(4, 25, 4),
(5, 30, 5),
(6, 35, 6),
(7, 40, 7),
(8, 45, 8),
(9, 50, 9),
(10, 55, 10);


INSERT INTO CTPhieuNK (msquanao, sl, msphieunk) VALUES 
(1, 100, 1),
(2, 90, 2),
(3, 80, 3),
(4, 70, 4),
(5, 60, 5),
(6, 50, 6),
(7, 40, 7),
(8, 30, 8),
(9, 20, 9),
(10, 10, 10);
