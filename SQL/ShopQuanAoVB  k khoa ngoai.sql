USE [master]
GO
/****** Object:  Database [ShopQuanAo]    Script Date: 06/10/2021 3:20:04 PM ******/
CREATE DATABASE [ShopQuanAo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopQuanAo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ShopQuanAo.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShopQuanAo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ShopQuanAo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopQuanAo] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopQuanAo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopQuanAo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopQuanAo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopQuanAo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopQuanAo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopQuanAo] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopQuanAo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopQuanAo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopQuanAo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopQuanAo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopQuanAo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopQuanAo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopQuanAo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopQuanAo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopQuanAo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopQuanAo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopQuanAo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopQuanAo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopQuanAo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopQuanAo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopQuanAo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopQuanAo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopQuanAo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopQuanAo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopQuanAo] SET  MULTI_USER 
GO
ALTER DATABASE [ShopQuanAo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopQuanAo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopQuanAo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopQuanAo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ShopQuanAo] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ShopQuanAo]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaCC] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaCH] [nvarchar](50) NULL,
	[Ngay] [nvarchar](50) NULL,
	[SoGioLam] [nvarchar](50) NULL,
	[TangCa] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nvarchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[MaDDH] [nvarchar](50) NULL,
	[MaHD] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[MaKM] [nvarchar](50) NULL,
	[GiaBan] [int] NULL,
	[SoLuong] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTKhuyenMai]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTKhuyenMai](
	[MaCTKM] [int] IDENTITY(1,1) NOT NULL,
	[MaKM] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[GiamGia] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaCTPN] [int] IDENTITY(1,1) NOT NULL,
	[MaPN] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPhieuXuat]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuXuat](
	[MaCTPX] [int] IDENTITY(1,1) NOT NULL,
	[MaPX] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTSanPham]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSanPham](
	[MaCTSP] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [nvarchar](50) NULL,
	[MaSize] [nvarchar](50) NULL,
	[MaMau] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[MaCH] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CuaHang]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuaHang](
	[MaCH] [nvarchar](50) NOT NULL,
	[TenCH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDDH] [nvarchar](50) NOT NULL,
	[NgayDat] [nvarchar](50) NULL,
	[TrangThaiGiaoHang] [nvarchar](50) NULL,
	[DaThanhToan] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[DaHuy] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayLap] [nvarchar](50) NULL,
	[MaCH] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[TongTien] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[LoaiKH] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [nvarchar](50) NOT NULL,
	[TenKM] [nvarchar](50) NULL,
	[NgayBatDau] [nvarchar](50) NULL,
	[NgayKetThuc] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[MaLoaiKH] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[UuDai] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MauSac]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauSac](
	[MaMau] [nvarchar](50) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenMCC] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[tenNV] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[NgayVaoLam] [nvarchar](50) NULL,
	[MaCV] [nvarchar](50) NULL,
	[MaCH] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[Ngay] [nvarchar](50) NULL,
	[ThanhToan] [int] NULL,
	[MaNV] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [nvarchar](50) NOT NULL,
	[Ngay] [nvarchar](50) NULL,
	[ThanhToan] [int] NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaCH] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[Maloai] [nvarchar](50) NULL,
	[GiaNhap] [int] NULL,
	[MoTa] [nvarchar](max) NULL,
	[ThongTin] [nvarchar](max) NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[HinhAnh1] [nvarchar](max) NULL,
	[HinhAnh2] [nvarchar](max) NULL,
	[HinhAnh3] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[moi] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Size]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[MaSize] [nvarchar](50) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
	[CanNang] [nvarchar](50) NULL,
	[KichThuoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 06/10/2021 3:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](max) NULL,
	[MaNV] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_ChamCong_NhanVien]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_DonDatHang] FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonDatHang] ([MaDDH])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_DonDatHang]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_SanPham]
GO
ALTER TABLE [dbo].[CTKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_CTKhuyenMai_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[CTKhuyenMai] CHECK CONSTRAINT [FK_CTKhuyenMai_KhuyenMai]
GO
ALTER TABLE [dbo].[CTKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_CTKhuyenMai_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTKhuyenMai] CHECK CONSTRAINT [FK_CTKhuyenMai_SanPham]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuXuat_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[CTPhieuXuat] CHECK CONSTRAINT [FK_CTPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD  CONSTRAINT [FK_CTSanPham_MauSac] FOREIGN KEY([MaMau])
REFERENCES [dbo].[MauSac] ([MaMau])
GO
ALTER TABLE [dbo].[CTSanPham] CHECK CONSTRAINT [FK_CTSanPham_MauSac]
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD  CONSTRAINT [FK_CTSanPham_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTSanPham] CHECK CONSTRAINT [FK_CTSanPham_SanPham]
GO
ALTER TABLE [dbo].[CTSanPham]  WITH CHECK ADD  CONSTRAINT [FK_CTSanPham_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTSanPham] CHECK CONSTRAINT [FK_CTSanPham_Size]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([LoaiKH])
REFERENCES [dbo].[LoaiKH] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_CuaHang] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CuaHang] ([MaCH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_CuaHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([Maloai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [ShopQuanAo] SET  READ_WRITE 
GO
