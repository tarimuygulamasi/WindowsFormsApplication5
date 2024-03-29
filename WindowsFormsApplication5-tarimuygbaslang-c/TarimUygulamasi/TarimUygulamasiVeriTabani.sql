USE [master]
GO
/****** Object:  Database [TarimUygulamasi]    Script Date: 21.11.2019 00:10:58 ******/
CREATE DATABASE [TarimUygulamasi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TarimUygulamasi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TarimUygulamasi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TarimUygulamasi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TarimUygulamasi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TarimUygulamasi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TarimUygulamasi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TarimUygulamasi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET ARITHABORT OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TarimUygulamasi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TarimUygulamasi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TarimUygulamasi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TarimUygulamasi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TarimUygulamasi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TarimUygulamasi] SET  MULTI_USER 
GO
ALTER DATABASE [TarimUygulamasi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TarimUygulamasi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TarimUygulamasi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TarimUygulamasi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TarimUygulamasi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TarimUygulamasi] SET QUERY_STORE = OFF
GO
USE [TarimUygulamasi]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[k_ID] [smallint] IDENTITY(1,1) NOT NULL,
	[k_adi] [varchar](20) NOT NULL,
	[k_sifre] [varchar](20) NOT NULL,
	[k_tel] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[k_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunCesidi]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunCesidi](
	[Meyve] [varchar](50) NULL,
	[Sebze] [varchar](50) NULL,
	[YemBitkilleri] [varchar](50) NULL,
	[SüsBitkileri] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunEkimArazisi]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunEkimArazisi](
	[DuzArazi] [varchar](50) NULL,
	[DağlıkArazi] [varchar](50) NULL,
	[SulakArazi] [varchar](50) NULL,
	[KurakArazi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunEkimZamani]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunEkimZamani](
	[ID] [int] NOT NULL,
	[OnerilenEkimZamani] [varchar](50) NULL,
	[UygulananEkimZamani] [varbinary](50) NULL,
 CONSTRAINT [PK_UrunEkimZamani] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunGubrelemeZamani]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunGubrelemeZamani](
	[UrunKodu] [smallint] NULL,
	[OnerilenGubrelemeZamani] [datetime] NULL,
	[UygulananGubrelemeZamani] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunHasatTarihi]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunHasatTarihi](
	[UrunKod] [smallint] NULL,
	[TahminiHasatTarihi] [datetime] NULL,
	[HasatEdilenTarih] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunIlaclamaZamani]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunIlaclamaZamani](
	[UrunKod] [smallint] NULL,
	[OnerilenIlaclama] [datetime] NULL,
	[UygulananIlaclamaZamanı] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunAdi] [varchar](50) NOT NULL,
	[UrunKodu] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunSulamaZamani]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunSulamaZamani](
	[UrunKodu] [smallint] NULL,
	[OnerilenSulamaZamani] [datetime] NULL,
	[UygulananSulamaZamani] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunuAlanKisi]    Script Date: 21.11.2019 00:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunuAlanKisi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Telefon] [char](10) NULL,
	[Adres] [text] NULL,
	[AlınanMiktar] [varchar](50) NULL,
 CONSTRAINT [PK_UrunuAlanKisi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([k_ID], [k_adi], [k_sifre], [k_tel]) VALUES (1, N'Ali', N'A1l2i3.', N'05483988675')
INSERT [dbo].[Kullanicilar] ([k_ID], [k_adi], [k_sifre], [k_tel]) VALUES (2, N'Aslı', N'as12lı34', N'05312861436')
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
ALTER TABLE [dbo].[UrunuAlanKisi]  WITH CHECK ADD  CONSTRAINT [FK_UrunuAlanKisi_UrunuAlanKisi] FOREIGN KEY([ID])
REFERENCES [dbo].[UrunuAlanKisi] ([ID])
GO
ALTER TABLE [dbo].[UrunuAlanKisi] CHECK CONSTRAINT [FK_UrunuAlanKisi_UrunuAlanKisi]
GO
USE [master]
GO
ALTER DATABASE [TarimUygulamasi] SET  READ_WRITE 
GO
