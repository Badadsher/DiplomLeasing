USE [master]
GO
/****** Object:  Database [Leasing]    Script Date: 16.01.2025 1:31:38 ******/
CREATE DATABASE [Leasing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Leasing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Leasing.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Leasing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Leasing_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Leasing] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Leasing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Leasing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Leasing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Leasing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Leasing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Leasing] SET ARITHABORT OFF 
GO
ALTER DATABASE [Leasing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Leasing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Leasing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Leasing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Leasing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Leasing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Leasing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Leasing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Leasing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Leasing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Leasing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Leasing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Leasing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Leasing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Leasing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Leasing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Leasing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Leasing] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Leasing] SET  MULTI_USER 
GO
ALTER DATABASE [Leasing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Leasing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Leasing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Leasing] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Leasing] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Leasing] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Leasing] SET QUERY_STORE = ON
GO
ALTER DATABASE [Leasing] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Leasing]
GO
/****** Object:  Table [dbo].[CarStatus]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarStatus](
	[ID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_CarStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeaseObjects]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaseObjects](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
	[MonthCount] [int] NOT NULL,
	[CarPrice] [int] NOT NULL,
	[Avance]  AS (([CarPrice]*(20))/(100)) PERSISTED,
	[MothlyPrice]  AS ([CarPrice]/[MonthCount]) PERSISTED,
	[AllAmount]  AS (([CarPrice]/[MonthCount])*[MonthCount]+([CarPrice]*(20))/(100)) PERSISTED,
	[Images] [varbinary](max) NOT NULL,
	[CarStatusID] [int] NOT NULL,
 CONSTRAINT [PK__LeaseObj__3214EC2775C2C7D1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leases]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leases](
	[ID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[StatusID] [int] NOT NULL,
	[CarID] [int] NOT NULL,
 CONSTRAINT [PK__Leases__3214EC278FD6E5E2] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeaseStatus]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaseStatus](
	[ID] [int] NOT NULL,
	[StatusLeaseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LeaseStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusTable]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusTable](
	[ID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersData]    Script Date: 16.01.2025 1:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersData](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Number] [bigint] NOT NULL,
	[Photo] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_UsersData] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CarStatus] ([ID], [StatusName]) VALUES (1, N'Активна')
INSERT [dbo].[CarStatus] ([ID], [StatusName]) VALUES (2, N'Удалена')
GO
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (1, N'Toyota Camry', 36, 3000000, (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\camry.jpg', SINGLE_BLOB) as image) , 2)
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (2, N'BMW X5', 23, 111111,  (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\bmwx5.jpg', SINGLE_BLOB) as image) , 1)
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (3, N'Audi A6', 24, 4500000,  (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\audia6.jpg', SINGLE_BLOB) as image) , 1)
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (4, N'Mercedes-Benz E-Class', 36, 5500000,  (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\mers.jpeg', SINGLE_BLOB) as image) , 1)
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (5, N'Hyundai Sonata', 24, 2500000,  (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\sonata.jpg', SINGLE_BLOB) as image) , 2)
INSERT [dbo].[LeaseObjects] ([ID], [Name], [MonthCount], [CarPrice], [Images], [CarStatusID]) VALUES (6, N'Kia Sportage', 36, 3200000, (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\CarPhotos\ckia.jpg', SINGLE_BLOB) as image) , 2)
GO
INSERT [dbo].[Leases] ([ID], [ClientID], [StartDate], [EndDate], [StatusID], [CarID]) VALUES (1, 1, CAST(N'2024-02-23' AS Date), CAST(N'2024-12-20' AS Date), 2, 2)
INSERT [dbo].[Leases] ([ID], [ClientID], [StartDate], [EndDate], [StatusID], [CarID]) VALUES (2, 4, CAST(N'2024-12-19' AS Date), NULL, 1, 5)
INSERT [dbo].[Leases] ([ID], [ClientID], [StartDate], [EndDate], [StatusID], [CarID]) VALUES (3, 2, CAST(N'2025-01-17' AS Date), CAST(N'2025-01-18' AS Date), 2, 2)
GO
INSERT [dbo].[LeaseStatus] ([ID], [StatusLeaseName]) VALUES (1, N'Активен')
INSERT [dbo].[LeaseStatus] ([ID], [StatusLeaseName]) VALUES (2, N'Закончен')
GO
INSERT [dbo].[Roles] ([ID], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([ID], [RoleName]) VALUES (2, N'Worker')
INSERT [dbo].[Roles] ([ID], [RoleName]) VALUES (3, N'Car Manager')
GO
INSERT [dbo].[StatusTable] ([ID], [StatusName]) VALUES (1, N'Работает')
INSERT [dbo].[StatusTable] ([ID], [StatusName]) VALUES (2, N'Уволен')
GO
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (1, N'workerLogin', N'newpassword', 2, 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (2, N'natasha228', N'natashapass1', 1, 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (3, N'pavelAdmin', N'pavelkrut221', 1, 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (4, N'valeraman', N'valera2005', 2, 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (5, N'nastyuha01', N'nas00901', 2, 2)
INSERT [dbo].[Users] ([ID], [Login], [Password], [RoleID], [StatusID]) VALUES (6, N'carmng', N'carm112', 3, 1)
GO
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (1, N'Олег', N'Петров', N'Иванович', 79172321234, (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\1.jpg', SINGLE_BLOB) as image))
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (2, N'Наталья', N'Кузнецова', N'Георгиевна', 79645432344, (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\wom1.jpg', SINGLE_BLOB) as image))
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (3, N'Павел', N'Старцев', N'Владимирович', 79156938765,(SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\2.jpg', SINGLE_BLOB) as image))
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (4, N'Валерий', N'Сериков', N'Степанович', 79992834756, (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\3.jpg', SINGLE_BLOB) as image))
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (5, N'Анастасия', N'Лапшина', N'Константиновна', 79256674563,  (SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\wom2.jpg', SINGLE_BLOB) as image))
INSERT [dbo].[UsersData] ([ID], [Name], [Surname], [Patronymic], [Number], [Photo]) VALUES (6, N'Константин', N'Малышев', N'Игоревич', 78972651234,(SELECT * FROM OPENROWSET(BULK 'C:\Users\Heisenberg\Downloads\LeasingApp\Leasing\UsersData\4.jpg', SINGLE_BLOB) as image)) )
GO
ALTER TABLE [dbo].[LeaseObjects]  WITH CHECK ADD  CONSTRAINT [FK_LeaseObjects_CarStatus] FOREIGN KEY([CarStatusID])
REFERENCES [dbo].[CarStatus] ([ID])
GO
ALTER TABLE [dbo].[LeaseObjects] CHECK CONSTRAINT [FK_LeaseObjects_CarStatus]
GO
ALTER TABLE [dbo].[Leases]  WITH CHECK ADD  CONSTRAINT [FK_Leases_LeaseObjects] FOREIGN KEY([CarID])
REFERENCES [dbo].[LeaseObjects] ([ID])
GO
ALTER TABLE [dbo].[Leases] CHECK CONSTRAINT [FK_Leases_LeaseObjects]
GO
ALTER TABLE [dbo].[Leases]  WITH CHECK ADD  CONSTRAINT [FK_Leases_LeaseStatus] FOREIGN KEY([StatusID])
REFERENCES [dbo].[LeaseStatus] ([ID])
GO
ALTER TABLE [dbo].[Leases] CHECK CONSTRAINT [FK_Leases_LeaseStatus]
GO
ALTER TABLE [dbo].[Leases]  WITH CHECK ADD  CONSTRAINT [FK_Leases_Users] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Leases] CHECK CONSTRAINT [FK_Leases_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_StatusTable] FOREIGN KEY([StatusID])
REFERENCES [dbo].[StatusTable] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_StatusTable]
GO
ALTER TABLE [dbo].[UsersData]  WITH CHECK ADD  CONSTRAINT [FK_UsersData_Users] FOREIGN KEY([ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[UsersData] CHECK CONSTRAINT [FK_UsersData_Users]
GO
USE [master]
GO
ALTER DATABASE [Leasing] SET  READ_WRITE 
GO
