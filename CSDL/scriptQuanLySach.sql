USE [master]
GO
/****** Object:  Database [QuanLySach]    Script Date: 9/29/2016 10:01:57 PM ******/
CREATE DATABASE [QuanLySach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySach', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLySach.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLySach_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLySach_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
ALTER DATABASE [QuanLySach] SET AUTO_CREATE_STATISTICS ON 
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
USE [QuanLySach]
GO
/****** Object:  Table [dbo].[tblDauSach]    Script Date: 9/29/2016 10:01:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDauSach](
	[IDSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[TheLoaiSach] [nvarchar](20) NOT NULL,
	[NgonNgu] [nchar](10) NOT NULL,
	[Gia] [int] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoLuongConLai] [int] NOT NULL,
	[IDThe] [int] NULL,
 CONSTRAINT [PK_tblDauSach] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 9/29/2016 10:01:57 PM ******/
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
	[IDSach] [int] NOT NULL,
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
/****** Object:  Table [dbo].[tblTaikhoan]    Script Date: 9/29/2016 10:01:57 PM ******/
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
/****** Object:  Table [dbo].[tblThongTinMuonTra]    Script Date: 9/29/2016 10:01:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThongTinMuonTra](
	[IDSach] [int] NOT NULL,
	[IDThe] [int] NOT NULL,
	[TinhTrang] [nvarchar](20) NOT NULL,
	[TienDatCoc] [int] NOT NULL,
	[NgayHenTra] [datetime] NULL,
 CONSTRAINT [PK_tblThongTinMuonTra] PRIMARY KEY CLUSTERED 
(
	[IDSach] ASC,
	[IDThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblDauSach]  WITH CHECK ADD  CONSTRAINT [FK_tblDauSach_tblDocGia] FOREIGN KEY([IDThe])
REFERENCES [dbo].[tblDocGia] ([IDThe])
GO
ALTER TABLE [dbo].[tblDauSach] CHECK CONSTRAINT [FK_tblDauSach_tblDocGia]
GO
ALTER TABLE [dbo].[tblThongTinMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_tblThongTinMuonTra_tblDauSach] FOREIGN KEY([IDThe])
REFERENCES [dbo].[tblDauSach] ([IDSach])
GO
ALTER TABLE [dbo].[tblThongTinMuonTra] CHECK CONSTRAINT [FK_tblThongTinMuonTra_tblDauSach]
GO
ALTER TABLE [dbo].[tblThongTinMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_tblThongTinMuonTra_tblDocGia] FOREIGN KEY([IDThe])
REFERENCES [dbo].[tblDocGia] ([IDThe])
GO
ALTER TABLE [dbo].[tblThongTinMuonTra] CHECK CONSTRAINT [FK_tblThongTinMuonTra_tblDocGia]
GO
USE [master]
GO
ALTER DATABASE [QuanLySach] SET  READ_WRITE 
GO
