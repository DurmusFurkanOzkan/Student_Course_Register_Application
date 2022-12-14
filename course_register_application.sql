USE [master]
GO
/****** Object:  Database [Course_Register_Application]    Script Date: 22.10.2022 14:08:34 ******/
CREATE DATABASE [Course_Register_Application]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Course_Register_Application', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Course_Register_Application.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Course_Register_Application_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Course_Register_Application_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Course_Register_Application] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Course_Register_Application].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Course_Register_Application] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Course_Register_Application] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Course_Register_Application] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Course_Register_Application] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Course_Register_Application] SET ARITHABORT OFF 
GO
ALTER DATABASE [Course_Register_Application] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Course_Register_Application] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Course_Register_Application] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Course_Register_Application] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Course_Register_Application] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Course_Register_Application] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Course_Register_Application] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Course_Register_Application] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Course_Register_Application] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Course_Register_Application] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Course_Register_Application] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Course_Register_Application] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Course_Register_Application] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Course_Register_Application] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Course_Register_Application] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Course_Register_Application] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Course_Register_Application] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Course_Register_Application] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Course_Register_Application] SET  MULTI_USER 
GO
ALTER DATABASE [Course_Register_Application] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Course_Register_Application] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Course_Register_Application] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Course_Register_Application] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Course_Register_Application] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Course_Register_Application] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Course_Register_Application] SET QUERY_STORE = OFF
GO
USE [Course_Register_Application]
GO
/****** Object:  Table [dbo].[Contact_Us]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_Us](
	[ID] [tinyint] NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[Mail_Address] [varchar](50) NULL,
	[Telephone_Number] [varchar](20) NULL,
	[Subject] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Number] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[Class] [varchar](20) NULL,
	[Mail_address] [varchar](20) NULL,
	[Telephone_number] [varchar](20) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Study]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Study](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Course] [tinyint] NULL,
	[Teacher] [tinyint] NULL,
	[Student] [tinyint] NULL,
	[Date] [varchar](20) NULL,
	[Time] [varchar](5) NULL,
 CONSTRAINT [PK_Study] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Number] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Surname] [varchar](20) NULL,
	[Branch] [varchar](20) NULL,
	[Mail_address] [varchar](20) NULL,
	[Telephone_Number] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Study]  WITH CHECK ADD  CONSTRAINT [FK_Study_Course] FOREIGN KEY([Course])
REFERENCES [dbo].[Course] ([ID])
GO
ALTER TABLE [dbo].[Study] CHECK CONSTRAINT [FK_Study_Course]
GO
ALTER TABLE [dbo].[Study]  WITH CHECK ADD  CONSTRAINT [FK_Study_Student] FOREIGN KEY([Student])
REFERENCES [dbo].[Student] ([Number])
GO
ALTER TABLE [dbo].[Study] CHECK CONSTRAINT [FK_Study_Student]
GO
ALTER TABLE [dbo].[Study]  WITH CHECK ADD  CONSTRAINT [FK_Study_Teacher] FOREIGN KEY([Teacher])
REFERENCES [dbo].[Teacher] ([Number])
GO
ALTER TABLE [dbo].[Study] CHECK CONSTRAINT [FK_Study_Teacher]
GO
/****** Object:  StoredProcedure [dbo].[Study_procedure]    Script Date: 22.10.2022 14:08:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Study_procedure]
AS
Select Study.ID,Course.Name,Teacher.Name+' '+Teacher.Surname as Teacher,Student ,Study.Date,Study.Time
from Study inner join Course
on Study.Course=Course.ID inner join Teacher
on Teacher.Number=Study.Teacher 
GO
USE [master]
GO
ALTER DATABASE [Course_Register_Application] SET  READ_WRITE 
GO
