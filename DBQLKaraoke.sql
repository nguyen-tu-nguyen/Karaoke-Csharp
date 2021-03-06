-- Lưu ý, Execute create database trước rồi mới use DB để create table
create database QuanLyQuanKaraoke
USE [QuanLyQuanKaraoke]
go
CREATE TABLE [dbo].[chitietdichvu](
	[maphong] [nchar](10) NOT NULL,
	[madv] [nchar](10) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [money] NULL,
 CONSTRAINT [PK_CTDV] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC,
	[madv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[MaHD] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[MaPhong] [nchar](10) NOT NULL,
	[GioBD] [time](7) NULL,
	[GioKT] [time](7) NULL,
	[TienPhong] [money] NULL,
	[TienDV] [money] NULL,
	[TongTien] [money] NULL,
	[NhanVienTT] [nvarchar](100) NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaKH] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaLoaiDV] [nchar](10) NOT NULL,
	[TenLoaiDV] [nvarchar](50) NULL,
	[GiaTien] [money] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Loai] [nchar](10) NOT NULL,
	[Tien] [money] NULL,
 CONSTRAINT [PK_DoanhThu] PRIMARY KEY CLUSTERED 
(
	[Loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dttheonv]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE TABLE [dbo].[hoadon](
	[MaHD] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[MaPhong] [nchar](10) NULL,
	[GioBD] [time](7) NULL,
	[TinhTrang] [nchar](10) NULL,
 CONSTRAINT [PK_HD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[SoDienThoai] [nchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](100) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[MatKhau] [nchar](100) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 25-Nov-19 5:33:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nchar](10) NOT NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[chitiethoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [GioKT], [TienPhong], [TienDV], [TongTien], [NhanVienTT]) VALUES (N'HD1       ', N'KH21      ', N'P002      ', CAST(0x07007EB32A2B0000 AS Time), CAST(0x07007EB32A2B0000 AS Time), 0.0000, 50000.0000, 50000.0000, N'Nguyễn Tú Nguyên')
INSERT [dbo].[chitiethoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [GioKT], [TienPhong], [TienDV], [TongTien], [NhanVienTT]) VALUES (N'HD2       ', N'KH11      ', N'P006      ', CAST(0x0700B81E16220000 AS Time), CAST(0x07007EB32A2B0000 AS Time), 0.0000, 195000.0000, 195000.0000, N'Nguyễn Tú Nguyên')
INSERT [dbo].[chitiethoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [GioKT], [TienPhong], [TienDV], [TongTien], [NhanVienTT]) VALUES (N'HD3       ', N'KH21      ', N'P001      ', CAST(0x070096C0B92B0000 AS Time), CAST(0x0700AECD482C0000 AS Time), 0.0000, 100000.0000, 100000.0000, N'Trang Tấn Nhựt')
INSERT [dbo].[chitiethoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [GioKT], [TienPhong], [TienDV], [TongTien], [NhanVienTT]) VALUES (N'HD4       ', N'KH21      ', N'P003      ', CAST(0x070096C0B92B0000 AS Time), CAST(0x0700F4906C2C0000 AS Time), 0.0000, 100000.0000, 100000.0000, N'Lê Thanh Bình')
INSERT [dbo].[chitiethoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [GioKT], [TienPhong], [TienDV], [TongTien], [NhanVienTT]) VALUES (N'HD5       ', N'KH21      ', N'P006      ', CAST(0x0700AECD482C0000 AS Time), CAST(0x0700F4906C2C0000 AS Time), 0.0000, 50000.0000, 50000.0000, N'Lê Thanh Bình')
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV001     ', N'Bia', 50000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV002     ', N'Rượu', 85000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV003     ', N'Khăn lạnh', 5000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV004     ', N'Trái cây', 60000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV005     ', N'Khô mực', 45000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV006     ', N'Khô bò', 45000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV0069    ', N'Một phút vui sướng', 500000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV007     ', N'Bánh snack', 10000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV008     ', N'Nước ngọt', 20000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV009     ', N'Nước suối', 15000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV010     ', N'Tẩy', 5000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV011     ', N'Mát xa', 55000.0000)
INSERT [dbo].[DichVu] ([MaLoaiDV], [TenLoaiDV], [GiaTien]) VALUES (N'DV012     ', N'Con mực', 120000.0000)
INSERT [dbo].[DoanhThu] ([Loai], [Tien]) VALUES (N'1         ', 495000.0000)
INSERT [dbo].[hoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [TinhTrang]) VALUES (N'HD1       ', N'KH21      ', N'P002      ', CAST(0x07007EB32A2B0000 AS Time), N'Returned  ')
INSERT [dbo].[hoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [TinhTrang]) VALUES (N'HD2       ', N'KH11      ', N'P006      ', CAST(0x0700B81E16220000 AS Time), N'Returned  ')
INSERT [dbo].[hoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [TinhTrang]) VALUES (N'HD3       ', N'KH21      ', N'P001      ', CAST(0x070096C0B92B0000 AS Time), N'Returned  ')
INSERT [dbo].[hoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [TinhTrang]) VALUES (N'HD4       ', N'KH21      ', N'P003      ', CAST(0x070096C0B92B0000 AS Time), N'Returned  ')
INSERT [dbo].[hoadon] ([MaHD], [MaKH], [MaPhong], [GioBD], [TinhTrang]) VALUES (N'HD5       ', N'KH21      ', N'P006      ', CAST(0x0700AECD482C0000 AS Time), N'Returned  ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH1       ', N'Nguyễn Thị Quỳnh Thoa', N'0168282939          ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH10      ', N'Nguyễn Đức Cường', N'01234675            ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH11      ', N'Ngọc', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH12      ', N'Ngọc Trân', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH13      ', N'Trân', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH14      ', N'Ngọc Hân', N'01234566            ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH15      ', N'KH1', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH16      ', N'Nguyễn Thị Diệu Hiền', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH17      ', N'NA', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH18      ', N'Thầy yêu', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH19      ', N'abc', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH2       ', N'Trang Tấn Nhựt', N'0988827328          ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH21      ', N'Nguyên', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH3       ', N'Nguyễn Tú Nguyên', N'0123456788          ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH4       ', N'Đinh Thị Hồng Ngọc', N'0123456             ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH5       ', N'Lê Thanh Bình', N'01273864232         ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH6       ', N'Hải Nam', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH7       ', N'Đào Trần Thanh Đông', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH8       ', N'Nguyễn Ngọc Hiền', N'                    ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SoDienThoai]) VALUES (N'KH9       ', N'Võ Ngọc Lan Trinh', N'                    ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [MatKhau]) VALUES (N'NV001     ', N'Nguyễn Tú Nguyên', N'QL', N'12345                                                                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [MatKhau]) VALUES (N'NV002     ', N'Trang Tấn Nhựt', N'QL', N'12345                                                                                               ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [ChucVu], [MatKhau]) VALUES (N'NV003     ', N'Lê Thanh Bình', N'NV', N'12345                                                                                               ')
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P001      ', N'Standard15', 4000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P002      ', N'Standard', 3000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P003      ', N'Standard15', 4000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P004      ', N'VIP15', 6000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P005      ', N'VIP', 5000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P006      ', N'Standard', 3000)
INSERT [dbo].[Phong] ([MaPhong], [LoaiPhong], [dongia]) VALUES (N'P007      ', N'VIP', 5000)
ALTER TABLE [dbo].[chitietdichvu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDichVu_DichVu] FOREIGN KEY([madv])
REFERENCES [dbo].[DichVu] ([MaLoaiDV])
GO
ALTER TABLE [dbo].[chitietdichvu] CHECK CONSTRAINT [FK_ChiTietDichVu_DichVu]
GO
ALTER TABLE [dbo].[chitietdichvu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDichVu_Phong] FOREIGN KEY([maphong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[chitietdichvu] CHECK CONSTRAINT [FK_ChiTietDichVu_Phong]
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_chitiethoadon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[chitiethoadon] CHECK CONSTRAINT [FK_chitiethoadon_KhachHang]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_Phong]
GO
