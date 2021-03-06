USE [master]
GO
/****** Object:  Database [EtapalReq]    Script Date: 04/05/2017 11:45:24 ******/
CREATE DATABASE [EtapalReq] ON  PRIMARY 
( NAME = N'EtapalReq', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\EtapalReq.mdf' , SIZE = 4352KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EtapalReq_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\EtapalReq_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EtapalReq] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EtapalReq].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EtapalReq] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [EtapalReq] SET ANSI_NULLS OFF
GO
ALTER DATABASE [EtapalReq] SET ANSI_PADDING OFF
GO
ALTER DATABASE [EtapalReq] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [EtapalReq] SET ARITHABORT OFF
GO
ALTER DATABASE [EtapalReq] SET AUTO_CLOSE ON
GO
ALTER DATABASE [EtapalReq] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [EtapalReq] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [EtapalReq] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [EtapalReq] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [EtapalReq] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [EtapalReq] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [EtapalReq] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [EtapalReq] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [EtapalReq] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [EtapalReq] SET  ENABLE_BROKER
GO
ALTER DATABASE [EtapalReq] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [EtapalReq] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [EtapalReq] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [EtapalReq] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [EtapalReq] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [EtapalReq] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [EtapalReq] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [EtapalReq] SET  READ_WRITE
GO
ALTER DATABASE [EtapalReq] SET RECOVERY SIMPLE
GO
ALTER DATABASE [EtapalReq] SET  MULTI_USER
GO
ALTER DATABASE [EtapalReq] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [EtapalReq] SET DB_CHAINING OFF
GO
USE [EtapalReq]
GO
/****** Object:  Table [dbo].[tblUserMgnt]    Script Date: 04/05/2017 11:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserMgnt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CaseWorker] [nvarchar](max) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblUserMgnt] ON
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (1, N'ಮಮತಾ ದೇವಿ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (2, N'ಗೋವಿಂದ ಸ್ವಾಮಿ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (3, N'ಲಕ್ಷ್ಮಿ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (4, N'ಲಕ್ಷ್ಮಿ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (5, N'ಹೆರ್ಮನ್ಥ್ ಗೌಡ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (6, N'ಹೆರ್ಮನ್ಥ್ ಗೌಡ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (7, N'ತಿಪ್ಪೆ ಸ್ವಾಮಿ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (8, N'ಶಂಕರ್  ಕುಮಾರ್ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (9, N'ಗುಂಡು ರಾವ್ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (10, N'ರಶ್ಮಿ ಶೆಟ್ಟಿ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (11, N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ')
INSERT [dbo].[tblUserMgnt] ([id], [CaseWorker]) VALUES (12, N'ದೀಪ ಶೇಖರ್ ')
SET IDENTITY_INSERT [dbo].[tblUserMgnt] OFF
/****** Object:  Table [dbo].[tblSubsectionManagement]    Script Date: 04/05/2017 11:45:25 ******/
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
SET IDENTITY_INSERT [dbo].[tblSubsectionManagement] ON
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (1, N'ಸೆಕ್ಷನ್1', N'ಸಬ್ ಸೆಕ್ಷನ್1')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (2, N'ಸೆಕ್ಷನ್2', N'ಸಬ್ ಸೆಕ್ಷನ್2')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (3, N'ಸೆಕ್ಷನ್3', N'ಸಬ್ ಸೆಕ್ಷನ್3')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (4, N'ಸೆಕ್ಷನ್4', N'ಸಬ್ ಸೆಕ್ಷನ್4')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (15, N'94', N'94A')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (6, N'Section6', N'Sub Section6')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (7, N'Section6', N'Sub Section6')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (8, N'Section7', N'Sub Section7')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (9, N'ಸೆಕ್ಷನ್5', N'ಸಬ್ ಸೆಕ್ಷನ್5')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (10, N'ಸೆಕ್ಷನ್6', N'ಸಬ್ ಸೆಕ್ಷನ್6')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (11, N'ಸೆಕ್ಷನ್7', N'ಸಬ್ ಸೆಕ್ಷನ್7')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (12, N'ಸೆಕ್ಷನ್8', N'ಸಬ್ ಸೆಕ್ಷನ್8')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (13, N'ಸೆಕ್ಷನ್9', N'ಸಬ್ ಸೆಕ್ಷನ್9')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (14, N'ಸೆಕ್ಷನ್10', N'ಸಬ್ ಸೆಕ್ಷನ್10')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (16, N'94', N'94B')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (17, N'94', N'94C')
INSERT [dbo].[tblSubsectionManagement] ([id], [Section], [Subsection]) VALUES (18, N'94', N'94D')
SET IDENTITY_INSERT [dbo].[tblSubsectionManagement] OFF
/****** Object:  Table [dbo].[tblSubSec]    Script Date: 04/05/2017 11:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSubSec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SubSection] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSec]    Script Date: 04/05/2017 11:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSec](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Section] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbllogin]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2024_2025]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2023_2024]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2022_2023]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2021_2022]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2020_2021]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2019_2020]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2018_2019]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblGovernmentLetter_IN_2017_2018]    Script Date: 04/05/2017 11:45:25 ******/
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
SET IDENTITY_INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ON
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (N'DOLetter', NULL, NULL, NULL, N'ಕರ್ನಾಟಕ1/1', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'Section6', N'ಗುಂಡು ರಾವ್ ', N'ಕರ್ನಾಟಕ ', NULL, N'ಕರ್ನಾಟಕ1/1', N'Sub Section6', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), NULL, N'ಕರ್ನಾಟಕ', CAST(0xA83C0B00 AS Date), 1)
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (NULL, NULL, NULL, NULL, N'ಕರ್ನಾಟಕ1/2', N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ', N'', N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ', N'ಸೆಕ್ಷನ್1', N'ಲಕ್ಷ್ಮಿ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟ ಕಕರ್ನಾಟಕಕ ರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾ ಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕಕ ರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ1/2', N'ಸಬ್ ಸೆಕ್ಷನ್1', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), N'GeneralLetter', N'ಕರ್ನಾಟಕ', CAST(0xA83C0B00 AS Date), 2)
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (NULL, N'RightToInfoLetter', NULL, NULL, N'ಕರ್ನಾಟಕ1/3', N'ಆರ್ಥಿಕ ಇಲಾಖೆ', N'', N'ಆಹಾರ ಸಂಸ್ಕರಣೆ', N'ಸೆಕ್ಷನ್1', N'ದೀಪ ಶೇಖರ್ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ', NULL, N'ಕರ್ನಾಟಕ1/3', N'ಸಬ್ ಸೆಕ್ಷನ್1', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), NULL, N'ಕರ್ನಾಟಕ', CAST(0xA83C0B00 AS Date), 3)
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (NULL, NULL, N'GovernmentLetter', NULL, N'ಕರ್ನಾಟಕ1/4', N'ಆರೋಗ್ಯ ಮತ್ತು ಕುಟುಂಬ ಕಲ್ಯಾಣ', N'', N'ಗೃಹ ಇಲಾಖೆ', N'ಸೆಕ್ಷನ್10', N'ದೀಪ ಶೇಖರ್ ', N'ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನ ಟಕಕರ್ನಾಟಕಕರ್ನಾ ಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕಕ ರ್ನಾಟಕಕರ್ನಾಟಕಕ ರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾ ಟಕಕರ್ನಾಟಕಕರ್ನ ಟಕಕರ್ನಾ ಟಕಕರ್ನಾ ಟಕಕರ್ನಾಟಕಕರ್ನಾ ಟಕಕರ್ನಾಟಕಕ ಟಕಕರ್ನಾಟಕಕ ರ್ನಾಟಕಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ1/4', N'ಸಬ್ ಸೆಕ್ಷನ್10', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), NULL, N'ಕರ್ನಾಟಕ', CAST(0xA83C0B00 AS Date), 4)
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (NULL, NULL, NULL, N'LokayuktaLetter', N'ಕರ್ನಾಟಕ1/5', N'ಆರೋಗ್ಯ ಮತ್ತು ಕುಟುಂಬ ಕಲ್ಯಾಣ', N'', N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್  ಆ  ಹೊರ್ಟಿಚುಲ್ಟುರೆ ', N'ಸೆಕ್ಷನ್2', N'ರಶ್ಮಿ ಶೆಟ್ಟಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ ಕರ್ನಾಟಕಕರ್ನಾಟಕಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ1/5', N'ಸಬ್ ಸೆಕ್ಷನ್10', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), NULL, N'ಕರ್ನಾಟಕ', CAST(0xA83C0B00 AS Date), 5)
INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] ([DO_Letter], [Right_To_Info_Letter], [Government_Letter], [Lokayukta_ABS_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [General_Letter], [Applicant_Name], [Entry_Date], [GL_No_Id]) VALUES (N'DOLetter', NULL, NULL, NULL, N'karn', N'dept1', N'', N'offic1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'karn', NULL, N'karn', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), NULL, N'karn', CAST(0xA63C0B00 AS Date), 6)
SET IDENTITY_INSERT [dbo].[tblGovernmentLetter_IN_2017_2018] OFF
/****** Object:  Table [dbo].[tblDepartment]    Script Date: 04/05/2017 11:45:25 ******/
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
SET IDENTITY_INSERT [dbo].[tblDepartment] ON
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (1, N'ಹಿಂದುಳಿದ ವರ್ಗಗಳ ಹಾಗೂ ಕಲ್ಯಾಣ ಇಲಾಖೆ', N'ವಾಣಿಜ್ಯ ಮತ್ತು ಕೈಗಾರಿಕೆ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (2, N'ಆರ್ಥಿಕ ಇಲಾಖೆ', N'ಆಹಾರ ಸಂಸ್ಕರಣೆ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (3, N'ಆರ್ಥಿಕ ಇಲಾಖೆ', N'ಆಹಾರ ಸಂಸ್ಕರಣೆ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (4, N'ಆರೋಗ್ಯ ಮತ್ತು ಕುಟುಂಬ ಕಲ್ಯಾಣ', N'ಗೃಹ ಇಲಾಖೆ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (6, N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (7, N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (8, N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ', N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (9, N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ', N'ಆಡಿಟ್  ಮಣಿತೋರಿಂಗ್  ಸಿಸ್ಟಮ್ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (10, N'ಸೆಂಟ್ರಲ್ ಎಸ್ಚಿಸೆ ಮೈಸೂರು', N'ಸೆಂಟ್ರಲ್ ಎಸ್ಚಿಸೆ ಮೈಸೂರು')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (11, N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ಆ ಕೋಆಪರೇಶನ್ 	', N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ಆ ಕೋಆಪರೇಶನ್ 	')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (12, N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್  ಆ  ಹೊರ್ಟಿಚುಲ್ಟುರೆ ', N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್  ಆ  ಹೊರ್ಟಿಚುಲ್ಟುರೆ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (13, N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್  ಆ  ಹೊರ್ಟಿಚುಲ್ಟುರೆ ', N'ಡಿಪಾರ್ಟ್ಮೆಂಟ್  ಆ  ಹೊರ್ಟಿಚುಲ್ಟುರೆ ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (14, N'ಡೈರೆಕ್ಟೊರೇಟ್ ಆ ಎಕನಾಮಿಕ್ಸ್ ಸ್ಟ್ಯಾಟಿಸ್ಟಿಕ್ಸ್  ', N'ಡೈರೆಕ್ಟೊರೇಟ್ ಆ ಎಕನಾಮಿಕ್ಸ್ ಸ್ಟ್ಯಾಟಿಸ್ಟಿಕ್ಸ್  ')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (15, N'dept1', N'offic1')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (16, N'dept2', N'off2')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (17, N'dept3', N'off3')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (18, N'dept4', N'off4')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (19, N'dept5', N'off5')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (20, N'dept6', N'off6')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (21, N'ಹಿಂದುಳಿದ ', N'ಹಿಂದುಳಿದ1')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (22, N'ಹಿಂದುಳಿದ', N'ಹಿಂದುಳಿದ2')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (23, N'ಹಿಂದುಳಿದ ', N'ಹಿಂದುಳಿದ3')
INSERT [dbo].[tblDepartment] ([id], [Department_Name], [FromOffice]) VALUES (24, N'ಹಿಂದುಳಿದ ', N'ಹಿಂದುಳಿದ4')
SET IDENTITY_INSERT [dbo].[tblDepartment] OFF
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2024_2025]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2023_2024]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2022_2023]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2021_2022]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2020_2021]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2019_2020]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2018_2019]    Script Date: 04/05/2017 11:45:25 ******/
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
/****** Object:  Table [dbo].[tblCourtCaseLetter_IN_2017_2018]    Script Date: 04/05/2017 11:45:25 ******/
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
SET IDENTITY_INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ON
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ1/1', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'Section5', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ1/1', N'Sub Section5', CAST(0xA73C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA83C0B00 AS Date), 1)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'dept1', N'', N'offic1', N'Section6', N'ಗುಂಡು ರಾವ್ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 2)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'dept1', N'', N'offic1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 3)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'dept1', N'', N'offic1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 4)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'dept3', N'', N'off3', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 5)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'', N'ಅಗ್ರಿಕಲ್ಚರಲ್  ಡಿಪಾರ್ಟ್ಮೆಂಟ್ ', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 6)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'ಹಿಂದುಳಿದ ', N'', N'ಹಿಂದುಳಿದ1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 7)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'ಕರ್ನಾಟಕ', N'ಹಿಂದುಳಿದ ', N'', N'ಹಿಂದುಳಿದ1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ ಕರ್ನಾಟಕ', NULL, N'ಕರ್ನಾಟಕ', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 8)
INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] ([Court_Case_Letter], [Letter_No], [FromDept], [From_Other_Dept], [FromOffice], [ToSection], [ToCaseWorker], [Subject], [Signature], [Inward_No], [ToSubsection], [Received_Date], [Letter_Date], [Entry_Date], [GL_No_Id]) VALUES (N'CourtCaseLetter', N'karn', N'dept1', N'', N'offic1', N'Section6', N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'karn', NULL, N'karn', N'Sub Section6', CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), CAST(0xA63C0B00 AS Date), 9)
SET IDENTITY_INSERT [dbo].[tblCourtCaseLetter_IN_2017_2018] OFF
/****** Object:  Table [dbo].[tblCaseSecSubsec]    Script Date: 04/05/2017 11:45:25 ******/
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
SET IDENTITY_INSERT [dbo].[tblCaseSecSubsec] ON
INSERT [dbo].[tblCaseSecSubsec] ([id], [CaseWorker], [Section], [Subsection]) VALUES (15, N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'Section6', N'Sub Section6')
INSERT [dbo].[tblCaseSecSubsec] ([id], [CaseWorker], [Section], [Subsection]) VALUES (16, N'ಅಶ್ವಿನ್ ನೀಲೇಕಣಿ ', N'Section7', N'Sub Section7')
INSERT [dbo].[tblCaseSecSubsec] ([id], [CaseWorker], [Section], [Subsection]) VALUES (17, N'ಗುಂಡು ರಾವ್ ', N'Section7', N'Sub Section7')
SET IDENTITY_INSERT [dbo].[tblCaseSecSubsec] OFF
