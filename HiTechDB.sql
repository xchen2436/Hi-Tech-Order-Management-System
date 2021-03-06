USE [master]
GO
/****** Object:  Database [HiTechDB]    Script Date: 2020-12-15 5:32:11 AM ******/
CREATE DATABASE [HiTechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\HiTechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HiTechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HiTechDB] SET QUERY_STORE = OFF
GO
USE [HiTechDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] NOT NULL,
	[AuthorName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [int] NOT NULL,
	[BookTitle] [nvarchar](50) NOT NULL,
	[QOH] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
	[YearPublished] [int] NOT NULL,
	[Edition] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[StreetName] [nvarchar](50) NOT NULL,
	[Province] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[OrderId] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
	[QuantityOrdered] [int] NOT NULL,
 CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [int] NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2020-12-15 5:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_UserAccounts] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Authors] ([AuthorId], [AuthorName]) VALUES (1, N'Patricia Brennan')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName]) VALUES (2, N'Amanda Ziller')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName]) VALUES (3, N'G.Michael Schneider')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName]) VALUES (4, N'William Shakespeare')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName]) VALUES (5, N'testname')
GO
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [Price], [CategoryId], [PublisherId], [AuthorId], [YearPublished], [Edition]) VALUES (1111111111, N'testbook', 100, 10.99, 2, 2, 4, 2020, N'test')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [Price], [CategoryId], [PublisherId], [AuthorId], [YearPublished], [Edition]) VALUES (1115478569, N'Who is Bill Gates', 250, 30.99, 2, 1, 2, 2013, N'Hardcover')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [Price], [CategoryId], [PublisherId], [AuthorId], [YearPublished], [Edition]) VALUES (1161964360, N'Pride and Prejudice', 250, 19.99, 2, 1, 4, 2009, N'Softcover')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [Price], [CategoryId], [PublisherId], [AuthorId], [YearPublished], [Edition]) VALUES (1586638459, N'Romeo and Juliet', 250, 15.51, 2, 1, 4, 2003, N'Softcover')
INSERT [dbo].[Books] ([ISBN], [BookTitle], [QOH], [Price], [CategoryId], [PublisherId], [AuthorId], [YearPublished], [Edition]) VALUES (1952875963, N'Invitation to Computer Science', 300, 79.99, 2, 1, 1, 2018, N'Hardcover')
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'ComputerScience')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'English')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'test')
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [StreetName], [Province], [City], [PostalCode]) VALUES (1111, N'Vanier College', N'821 Avenue Sainte-Croix', N'QC', N'Saint-Laurent', N'H4L 3X9')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [StreetName], [Province], [City], [PostalCode]) VALUES (2222, N'Lasalle College', N'1109 sherbrooke', N'QC', N'Montreal', N'H9R 1K1')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [StreetName], [Province], [City], [PostalCode]) VALUES (3333, N'Dawson College', N'2000 sherbrooke', N'QC', N'Montreal', N'H8Z 2U8')
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [StreetName], [Province], [City], [PostalCode]) VALUES (4444, N'testupdate', N'testupdate', N'testupdate', N'testupdate', N'testupdate')
GO
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (1111, N'Henry', N'Brown', N'5141111111', N'Henry@gmail.com', 1)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (2222, N'Thomas', N'Moore', N'5142222222', N'Thomas@gmail.com', 2)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (3333, N'Peter', N'Wang', N'5143333333', N'Peter@yahoo.ca', 3)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (4444, N'Mary', N'Brown', N'5144444444', N'Mary@gmail.com', 4)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (5555, N'Jennifer', N'Bouchard', N'5145555555', N'Jennifer@gmail.com', 4)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [PhoneNumber], [Email], [JobId]) VALUES (6666, N'testname', N'testname', N'5144444444', N'testname@gmail.com', 2)
GO
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (1, N'MIS Manager')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (3, N'Inventory Controller')
INSERT [dbo].[Job] ([JobId], [JobTitle]) VALUES (4, N'Order Clerks')
GO
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId]) VALUES (1, CAST(N'2020-05-05' AS Date), 1111, 2222)
INSERT [dbo].[Orders] ([OrderId], [OrderDate], [CustomerId], [EmployeeId]) VALUES (2, CAST(N'2020-03-03' AS Date), 2222, 2222)
GO
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (1, N'HarperTeen')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (2, N'House of Anansi')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (3, N'test')
GO
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (1111, N'henrybrown', 1111)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (2222, N'thomasmoore', 2222)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (3333, N'peterwang', 3333)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (4444, N'marybrown', 4444)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (5555, N'jenniferbouchard', 5555)
INSERT [dbo].[Users] ([UserId], [Password], [EmployeeId]) VALUES (6666, N'test', 6666)
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([PublisherId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Job] FOREIGN KEY([JobId])
REFERENCES [dbo].[Job] ([JobId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Job]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Books]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_UserAccounts_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_UserAccounts_Employees]
GO
USE [master]
GO
ALTER DATABASE [HiTechDB] SET  READ_WRITE 
GO
