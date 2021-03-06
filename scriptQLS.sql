USE [master]
GO
/****** Object:  Database [QuanLySach]    Script Date: 11/23/2016 9:24:09 AM ******/
CREATE DATABASE [QuanLySach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySach', FILENAME = N'D:\QuanLySach.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLySach_log', FILENAME = N'D:\QuanLySach_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLySach] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySach] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLySach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySach] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLySach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySach] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySach] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLySach] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLySach]
GO
/****** Object:  Table [dbo].[tblAnBan]    Script Date: 11/23/2016 9:24:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAnBan](
	[IDAnBan] [int] IDENTITY(1,1) NOT NULL,
	[IDSach] [int] NULL,
	[TrangThai] [int] NULL,
	[IDPhieuMuon] [int] NULL,
 CONSTRAINT [PK_tblAnBan] PRIMARY KEY CLUSTERED 
(
	[IDAnBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDauSach]    Script Date: 11/23/2016 9:24:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDauSach](
	[IDSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[TheLoaiSach] [nvarchar](20) NULL,
	[NgonNgu] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoLuongConLai] [int] NULL,
 CONSTRAINT [PK_tblDauSach] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 11/23/2016 9:24:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[IDThe] [int] NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[Email] [varchar](30) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[LoaiThe] [nvarchar](20) NOT NULL,
	[TrangThai] [varchar](20) NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[IDThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuMuon]    Script Date: 11/23/2016 9:24:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuMuon](
	[IDPhieuMuon] [int] NOT NULL,
	[IDThe] [int] NOT NULL,
	[NgayMuon] [date] NULL,
 CONSTRAINT [PK_tblPhieuMuon_1] PRIMARY KEY CLUSTERED 
(
	[IDPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTaikhoan]    Script Date: 11/23/2016 9:24:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTaikhoan](
	[NguoiDung] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[QuyenHan] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblAnBan] ON 

INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (1, 1, 0, 5)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (2, 1, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (3, 1, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (4, 1, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (5, 1, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (6, 1, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (7, 2, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (8, 3, 0, 5)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (9, 2, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (10, 3, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (11, 4, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (12, 5, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (13, 5, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (14, 5, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (15, 4, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (16, 2, 1, NULL)
INSERT [dbo].[tblAnBan] ([IDAnBan], [IDSach], [TrangThai], [IDPhieuMuon]) VALUES (17, 3, 1, NULL)
SET IDENTITY_INSERT [dbo].[tblAnBan] OFF
INSERT [dbo].[tblDauSach] ([IDSach], [TenSach], [TenTacGia], [TheLoaiSach], [NgonNgu], [Gia], [GhiChu], [SoLuongConLai]) VALUES (1, N'Ngày hôm qua', N'Trần Văn An', N'Khoa Học', N'Tiếng Việt', 150000, NULL, 1)
INSERT [dbo].[tblDauSach] ([IDSach], [TenSach], [TenTacGia], [TheLoaiSach], [NgonNgu], [Gia], [GhiChu], [SoLuongConLai]) VALUES (2, N'Trời đã sáng', N'Dạ Minh', N'Văn Học ', N'Tiếng Việt', 140000, NULL, 1)
INSERT [dbo].[tblDauSach] ([IDSach], [TenSach], [TenTacGia], [TheLoaiSach], [NgonNgu], [Gia], [GhiChu], [SoLuongConLai]) VALUES (3, N'Người đi tìm hình của nước', N'Tấn ', N'Văn Học', N'Tiếng Việt', 100000, NULL, 1)
INSERT [dbo].[tblDauSach] ([IDSach], [TenSach], [TenTacGia], [TheLoaiSach], [NgonNgu], [Gia], [GhiChu], [SoLuongConLai]) VALUES (4, N'Harmlet', N'Searpheak', N'Văn Học', N'Tiếng Anh', 200000, NULL, 4)
INSERT [dbo].[tblDauSach] ([IDSach], [TenSach], [TenTacGia], [TheLoaiSach], [NgonNgu], [Gia], [GhiChu], [SoLuongConLai]) VALUES (5, N'Ngôn ngữ lập trình 2', N'Ngô Thừa Ân', N'Sử học', N'Trung', 50000, NULL, 5)
INSERT [dbo].[tblDocGia] ([IDThe], [SDT], [HoTen], [Email], [DiaChi], [LoaiThe], [TrangThai]) VALUES (1, N'0168987564', N'Lê Hải Sơn', N'lehaisonmath6@gmail.com', N'Hưng Yên', N'1', N'1')
INSERT [dbo].[tblDocGia] ([IDThe], [SDT], [HoTen], [Email], [DiaChi], [LoaiThe], [TrangThai]) VALUES (2, N'0182183124', N'Trần Văn Nhật', N'tranvannhat@gmail.com', N'Đồng Tháp', N'1', N'1')
INSERT [dbo].[tblPhieuMuon] ([IDPhieuMuon], [IDThe], [NgayMuon]) VALUES (1, 1, CAST(N'2016-11-17' AS Date))
INSERT [dbo].[tblPhieuMuon] ([IDPhieuMuon], [IDThe], [NgayMuon]) VALUES (2, 1, CAST(N'2016-11-17' AS Date))
INSERT [dbo].[tblPhieuMuon] ([IDPhieuMuon], [IDThe], [NgayMuon]) VALUES (3, 1, CAST(N'2016-11-17' AS Date))
INSERT [dbo].[tblPhieuMuon] ([IDPhieuMuon], [IDThe], [NgayMuon]) VALUES (4, 1, CAST(N'2016-11-17' AS Date))
INSERT [dbo].[tblPhieuMuon] ([IDPhieuMuon], [IDThe], [NgayMuon]) VALUES (5, 1, CAST(N'2016-11-22' AS Date))
ALTER TABLE [dbo].[tblAnBan]  WITH CHECK ADD  CONSTRAINT [FK_tblAnBan_tblDauSach] FOREIGN KEY([IDSach])
REFERENCES [dbo].[tblDauSach] ([IDSach])
GO
ALTER TABLE [dbo].[tblAnBan] CHECK CONSTRAINT [FK_tblAnBan_tblDauSach]
GO
ALTER TABLE [dbo].[tblAnBan]  WITH CHECK ADD  CONSTRAINT [FK_tblAnBan_tblPhieuMuon1] FOREIGN KEY([IDPhieuMuon])
REFERENCES [dbo].[tblPhieuMuon] ([IDPhieuMuon])
GO
ALTER TABLE [dbo].[tblAnBan] CHECK CONSTRAINT [FK_tblAnBan_tblPhieuMuon1]
GO
ALTER TABLE [dbo].[tblPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuon_tblDocGia] FOREIGN KEY([IDThe])
REFERENCES [dbo].[tblDocGia] ([IDThe])
GO
ALTER TABLE [dbo].[tblPhieuMuon] CHECK CONSTRAINT [FK_tblPhieuMuon_tblDocGia]
GO
USE [master]
GO
ALTER DATABASE [QuanLySach] SET  READ_WRITE 
GO
