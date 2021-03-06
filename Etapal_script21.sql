USE [master]
GO
/****** Object:  Database [Etapal]    Script Date: 08/21/2017 01:19:59 ******/
CREATE DATABASE [Etapal] ON  PRIMARY 
( NAME = N'Etapal', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Etapal.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Etapal_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Etapal_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Etapal] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Etapal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Etapal] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Etapal] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Etapal] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Etapal] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Etapal] SET ARITHABORT OFF
GO
ALTER DATABASE [Etapal] SET AUTO_CLOSE ON
GO
ALTER DATABASE [Etapal] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Etapal] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Etapal] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Etapal] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Etapal] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Etapal] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Etapal] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Etapal] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Etapal] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Etapal] SET  ENABLE_BROKER
GO
ALTER DATABASE [Etapal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Etapal] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Etapal] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Etapal] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Etapal] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Etapal] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Etapal] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Etapal] SET  READ_WRITE
GO
ALTER DATABASE [Etapal] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Etapal] SET  MULTI_USER
GO
ALTER DATABASE [Etapal] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Etapal] SET DB_CHAINING OFF
GO
USE [Etapal]
GO
/****** Object:  Table [dbo].[tblUserMgnt]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserMgnt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CaseWorker] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubsectionManagement]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSubsectionManagement](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Section] [nvarchar](max) NULL,
	[Subsection] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubSec]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSubSec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SubSection] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSec]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Section] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbllogin]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbllogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[PassWord] [nvarchar](max) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbllogin] ON
INSERT [dbo].[tbllogin] ([Id], [Name], [UserName], [PassWord]) VALUES (1, N'VMD', N'admin', N'admin123')
SET IDENTITY_INSERT [dbo].[tbllogin] OFF
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2024_2025]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2024_2025](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2023_2024]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2023_2024](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2022_2023]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2022_2023](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2021_2022]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2021_2022](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2020_2021]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2020_2021](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2019_2020]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2019_2020](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2018_2019]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2018_2019](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2017_2018]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGovernmentLetter_IN_2017_2018](
	[DO_Letter] [nvarchar](max) NULL,
	[Right_To_Info_Letter] [nvarchar](max) NULL,
	[Government_Letter] [nvarchar](max) NULL,
	[Lokayukta_ABS_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[General_Letter] [nvarchar](max) NULL,
	[Applicant_Name] [nvarchar](max) NULL,
	[Entry_Date] [date] NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDepartment]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Department_Name] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2024_2025]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2024_2025](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2023_2024]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2023_2024](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2022_2023]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2022_2023](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2021_2022]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2021_2022](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2020_2021]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2020_2021](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2019_2020]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2019_2020](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2018_2019]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2018_2019](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2017_2018]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourtCaseLetter_IN_2017_2018](
	[Court_Case_Letter] [nvarchar](max) NULL,
	[Letter_No] [nvarchar](max) NULL,
	[FromDept] [nvarchar](max) NULL,
	[From_Other_Dept] [nvarchar](max) NULL,
	[FromOffice] [nvarchar](max) NULL,
	[ToSection] [nvarchar](max) NULL,
	[ToCaseWorker] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Signature] [nvarchar](max) NULL,
	[Inward_No] [nvarchar](max) NULL,
	[ToSubsection] [nvarchar](max) NULL,
	[Received_Date] [date] NULL,
	[Letter_Date] [date] NULL,
	[Entry_Date] [date] NULL,
	[GL_No_Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCaseSecSubsec]    Script Date: 08/21/2017 01:20:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaseSecSubsec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CaseWorker] [nvarchar](max) NULL,
	[Section] [nvarchar](max) NULL,
	[Subsection] [nvarchar](max) NULL
) ON [PRIMARY]
GO
