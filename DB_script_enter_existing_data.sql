USE [master]
GO
/****** Object:  Database [assetsdatabase]    Script Date: 3/29/2021 12:41:42 AM ******/
CREATE DATABASE [assetsdatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'assetsdatabase', FILENAME = N'C:\Users\b_lav\assetsdatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'assetsdatabase_log', FILENAME = N'C:\Users\b_lav\assetsdatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [assetsdatabase] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [assetsdatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [assetsdatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [assetsdatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [assetsdatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [assetsdatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [assetsdatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [assetsdatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [assetsdatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [assetsdatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [assetsdatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [assetsdatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [assetsdatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [assetsdatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [assetsdatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [assetsdatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [assetsdatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [assetsdatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [assetsdatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [assetsdatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [assetsdatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [assetsdatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [assetsdatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [assetsdatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [assetsdatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [assetsdatabase] SET  MULTI_USER 
GO
ALTER DATABASE [assetsdatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [assetsdatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [assetsdatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [assetsdatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [assetsdatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [assetsdatabase] SET QUERY_STORE = OFF
GO
USE [assetsdatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [assetsdatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/29/2021 12:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CellPhones]    Script Date: 3/29/2021 12:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CellPhones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ResourceType] [nvarchar](max) NULL,
	[OfficeId] [int] NULL,
	[Model] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Purchased] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CellPhones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Computers]    Script Date: 3/29/2021 12:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ResourceType] [nvarchar](max) NULL,
	[OfficeId] [int] NULL,
	[Model] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Purchased] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Computers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiverseAssets]    Script Date: 3/29/2021 12:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiverseAssets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ResourceType] [nvarchar](max) NULL,
	[OfficeId] [int] NULL,
	[Model] [nvarchar](max) NULL,
	[Brand] [nvarchar](max) NULL,
	[Purchased] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_DiverseAssets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Offices]    Script Date: 3/29/2021 12:41:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Offices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_CellPhones_OfficeId]    Script Date: 3/29/2021 12:41:43 AM ******/
CREATE NONCLUSTERED INDEX [IX_CellPhones_OfficeId] ON [dbo].[CellPhones]
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Computers_OfficeId]    Script Date: 3/29/2021 12:41:43 AM ******/
CREATE NONCLUSTERED INDEX [IX_Computers_OfficeId] ON [dbo].[Computers]
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DiverseAssets_OfficeId]    Script Date: 3/29/2021 12:41:43 AM ******/
CREATE NONCLUSTERED INDEX [IX_DiverseAssets_OfficeId] ON [dbo].[DiverseAssets]
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CellPhones]  WITH CHECK ADD  CONSTRAINT [FK_CellPhones_Offices_OfficeId] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([Id])
GO
ALTER TABLE [dbo].[CellPhones] CHECK CONSTRAINT [FK_CellPhones_Offices_OfficeId]
GO
ALTER TABLE [dbo].[Computers]  WITH CHECK ADD  CONSTRAINT [FK_Computers_Offices_OfficeId] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([Id])
GO
ALTER TABLE [dbo].[Computers] CHECK CONSTRAINT [FK_Computers_Offices_OfficeId]
GO
ALTER TABLE [dbo].[DiverseAssets]  WITH CHECK ADD  CONSTRAINT [FK_DiverseAssets_Offices_OfficeId] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Offices] ([Id])
GO
ALTER TABLE [dbo].[DiverseAssets] CHECK CONSTRAINT [FK_DiverseAssets_Offices_OfficeId]
GO
USE [master]
GO
ALTER DATABASE [assetsdatabase] SET  READ_WRITE 
GO
