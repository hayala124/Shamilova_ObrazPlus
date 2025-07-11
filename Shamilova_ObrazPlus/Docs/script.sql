USE [master]
GO
/****** Object:  Database [Shamilova_ObrazPlus]    Script Date: 19.03.2025 14:15:46 ******/
CREATE DATABASE [Shamilova_ObrazPlus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shamilova_ObrazPlus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shamilova_ObrazPlus.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shamilova_ObrazPlus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shamilova_ObrazPlus_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shamilova_ObrazPlus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET RECOVERY FULL 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET  MULTI_USER 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shamilova_ObrazPlus', N'ON'
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET QUERY_STORE = ON
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Shamilova_ObrazPlus]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[IdAddress] [int] IDENTITY(1,1) NOT NULL,
	[StreetId] [int] NOT NULL,
	[Apartment] [int] NOT NULL,
	[PostalCodeId] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[IdAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[IdCity] [int] IDENTITY(1,1) NOT NULL,
	[NameCity] [nvarchar](255) NOT NULL,
	[RegionId] [int] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[IdCity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[ClientTypeId] [int] NOT NULL,
	[NameClient] [nvarchar](255) NOT NULL,
	[DirectorId] [int] NULL,
	[EmailClient] [nvarchar](255) NOT NULL,
	[PhoneClient] [nvarchar](255) NOT NULL,
	[AddressId] [int] NOT NULL,
	[INN] [float] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_Client_1] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientDirector]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientDirector](
	[IdDirector] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](100) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Patronymic] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ClientDirector] PRIMARY KEY CLUSTERED 
(
	[IdDirector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientType]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientType](
	[IdClientType] [int] IDENTITY(1,1) NOT NULL,
	[NameClientType] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_ClientType] PRIMARY KEY CLUSTERED 
(
	[IdClientType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[IdEmployee] [int] IDENTITY(1,1) NOT NULL,
	[CodeEmployee] [float] NOT NULL,
	[JobTitleId] [int] NOT NULL,
	[Surname] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Patronymic] [nvarchar](255) NOT NULL,
	[Login] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[TimeLastEntrance] [nvarchar](255) NOT NULL,
	[EntranceTypeId] [int] NOT NULL,
	[EmployeeImagePath] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[IdEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntranceType]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntranceType](
	[IdEntranceType] [int] IDENTITY(1,1) NOT NULL,
	[NameEntranceType] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_EntranceType] PRIMARY KEY CLUSTERED 
(
	[IdEntranceType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobTitle]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobTitle](
	[IdJobTitle] [int] IDENTITY(1,1) NOT NULL,
	[NameJobTitle] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_JobTitle] PRIMARY KEY CLUSTERED 
(
	[IdJobTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[IdMaterial] [int] IDENTITY(1,1) NOT NULL,
	[NameMaterial] [nvarchar](255) NOT NULL,
	[MaterialTypeId] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[CountInStock] [int] NOT NULL,
	[MinimumCount] [int] NOT NULL,
	[CountPerPackage] [int] NOT NULL,
	[UnitOfMeasurement] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[IdMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialProduct]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialProduct](
	[IdMaterialProduct] [int] IDENTITY(1,1) NOT NULL,
	[MateriaId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[RequiredCountOfMaterial] [int] NOT NULL,
 CONSTRAINT [PK_MaterialProduct] PRIMARY KEY CLUSTERED 
(
	[IdMaterialProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialType]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialType](
	[IdMaterialType] [int] IDENTITY(1,1) NOT NULL,
	[NameMaterialType] [nvarchar](255) NOT NULL,
	[PercentageOfRawMaterialLosses] [float] NOT NULL,
 CONSTRAINT [PK_MaterialType] PRIMARY KEY CLUSTERED 
(
	[IdMaterialType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostalCode]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostalCode](
	[IdPostalCode] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
 CONSTRAINT [PK_PostalCode] PRIMARY KEY CLUSTERED 
(
	[IdPostalCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[NameProduct] [nvarchar](255) NOT NULL,
	[ArticleNumber] [int] NOT NULL,
	[MinimumCostForPartner] [float] NOT NULL,
	[PathImage] [nvarchar](255) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[IdProductType] [int] IDENTITY(1,1) NOT NULL,
	[NameProductType] [nvarchar](255) NOT NULL,
	[ProductTypeCoefficient] [float] NOT NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[IdProductType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Region]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[IdRegion] [int] IDENTITY(1,1) NOT NULL,
	[NameRegion] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[IdRegion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Street]    Script Date: 19.03.2025 14:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Street](
	[IdStreet] [int] IDENTITY(1,1) NOT NULL,
	[NameStreet] [nvarchar](255) NOT NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_Street] PRIMARY KEY CLUSTERED 
(
	[IdStreet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (1, 1, 15, 1)
INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (2, 2, 18, 2)
INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (3, 3, 21, 3)
INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (4, 4, 51, 4)
INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (5, 5, 122, 5)
INSERT [dbo].[Address] ([IdAddress], [StreetId], [Apartment], [PostalCodeId]) VALUES (6, 6, 2, 6)
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (1, N'Юрга', 1)
INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (2, N'Северодвинск', 2)
INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (3, N'Приморск', 3)
INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (4, N'Реутов', 4)
INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (5, N'Старый Оскол', 5)
INSERT [dbo].[City] ([IdCity], [NameCity], [RegionId]) VALUES (6, N'Гатчина', 3)
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (1, 1, N'База Строитель', 1, N'aleksandraivanova@ml.ru', N'493 123 45 67', 1, 2222455179, 7)
INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (2, 2, N'Паркет 29', 2, N'vppetrov@vl.ru', N'987 123 56 78', 2, 3333888520, 7)
INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (3, 3, N'Стройсервис', 3, N'ansolovev@st.ru', N'812 223 32 00', 3, 4440391035, 7)
INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (4, 4, N'Ремонт и отделка', 4, N'ekaterina.vorobeva@ml.ru', N'444 222 33 11', 4, 1111520857, 5)
INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (5, 1, N'МонтажПро', 5, N'stepanov@stepan.ru', N'912 888 33 33', 5, 5552431140, 10)
INSERT [dbo].[Client] ([IdClient], [ClientTypeId], [NameClient], [DirectorId], [EmailClient], [PhoneClient], [AddressId], [INN], [Rating]) VALUES (6, 5, N'Степанова Анна Сергеевна', NULL, N'stepa@smail.ru', N'598 412 66 47', 6, 4701152545, 1)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientDirector] ON 

INSERT [dbo].[ClientDirector] ([IdDirector], [Surname], [Name], [Patronymic]) VALUES (1, N'Иванова', N'Александра', N'Ивановна')
INSERT [dbo].[ClientDirector] ([IdDirector], [Surname], [Name], [Patronymic]) VALUES (2, N'Петров', N'Василий', N'Петрович')
INSERT [dbo].[ClientDirector] ([IdDirector], [Surname], [Name], [Patronymic]) VALUES (3, N'Соловьев', N'Андрей', N'Николаевич')
INSERT [dbo].[ClientDirector] ([IdDirector], [Surname], [Name], [Patronymic]) VALUES (4, N'Воробьева', N'Екатерина', N'Валерьевна')
INSERT [dbo].[ClientDirector] ([IdDirector], [Surname], [Name], [Patronymic]) VALUES (5, N'Степанов', N'Степан', N'Сергеевич')
SET IDENTITY_INSERT [dbo].[ClientDirector] OFF
GO
SET IDENTITY_INSERT [dbo].[ClientType] ON 

INSERT [dbo].[ClientType] ([IdClientType], [NameClientType]) VALUES (1, N'ЗАО')
INSERT [dbo].[ClientType] ([IdClientType], [NameClientType]) VALUES (2, N'ООО')
INSERT [dbo].[ClientType] ([IdClientType], [NameClientType]) VALUES (3, N'ПАО')
INSERT [dbo].[ClientType] ([IdClientType], [NameClientType]) VALUES (4, N'ОАО')
INSERT [dbo].[ClientType] ([IdClientType], [NameClientType]) VALUES (5, N'ФизЛицо')
SET IDENTITY_INSERT [dbo].[ClientType] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (1, 101, 1, N'Иванов', N'Иван', N'Иванович', N'Ivanov@namecomp.ru', N'2L6KZG', N'19.03.2025 14:03:09', 1, N'Иванов.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (2, 102, 1, N'Петров', N'Петр', N'Петрович', N'petrov@namecomp.ru', N'uzWC67', N'15:05:2022 13:13:00', 1, N'Петров.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (3, 103, 2, N'Федоров', N'Федор', N'Федорович', N'fedorov@namecomp.ru', N'8ntwUp', N'17.03.2025 23:45:49', 1, N'Федоров.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (4, 104, 3, N'Миронов', N'Вениамин', N'Куприянович', N'mironov@namecomp.ru', N'YOyhfR', N'10.03.2025 21:31:45', 1, N'Миронов.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (5, 105, 3, N'Ширяев', N'Ермолай', N'Вениаминович', N'shiryev@namecomp.ru', N'RSbvHv', N'15:05:2022 13:13:00', 2, N'Ширяев.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (6, 106, 3, N'Игнатов', N'Кассиан', N'Васильевич', N'ignatov@namecomp.ru', N'rwVDh9', N'15:05:2022 13:13:00', 1, N'Игнатов.jpg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (7, 107, 4, N'Хохлов', N'Владимир', N'Мэлсович', N'hohlov@namecomp.ru', N'LdNyos', N'15:05:2022 13:13:00', 1, N'Хохлов.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (8, 108, 4, N'Стрелков', N'Мстислав', N'Георгьевич', N'strelkov@namecomp.ru', N'gynQMT', N'15:05:2022 13:13:00', 2, N'Стрелков.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (9, 109, 4, N'Беляева', N'Лилия', N'Наумовна', N'belyeva@@namecomp.ru', N'AtnDjr', N'15:05:2022 13:13:00', 1, N'Беляева.jpeg')
INSERT [dbo].[Employee] ([IdEmployee], [CodeEmployee], [JobTitleId], [Surname], [Name], [Patronymic], [Login], [Password], [TimeLastEntrance], [EntranceTypeId], [EmployeeImagePath]) VALUES (10, 110, 4, N'Смирнова', N'Ульяна', N'Гордеевна', N'smirnova@@namecomp.ru', N'JlFRCZ', N'15:05:2022 13:13:00', 1, N'Смирнова.jpeg')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[EntranceType] ON 

INSERT [dbo].[EntranceType] ([IdEntranceType], [NameEntranceType]) VALUES (1, N'Успешно')
INSERT [dbo].[EntranceType] ([IdEntranceType], [NameEntranceType]) VALUES (2, N'Неуспешно')
SET IDENTITY_INSERT [dbo].[EntranceType] OFF
GO
SET IDENTITY_INSERT [dbo].[JobTitle] ON 

INSERT [dbo].[JobTitle] ([IdJobTitle], [NameJobTitle]) VALUES (1, N'Кладовщик')
INSERT [dbo].[JobTitle] ([IdJobTitle], [NameJobTitle]) VALUES (2, N'Администратор')
INSERT [dbo].[JobTitle] ([IdJobTitle], [NameJobTitle]) VALUES (3, N'Менеджер')
INSERT [dbo].[JobTitle] ([IdJobTitle], [NameJobTitle]) VALUES (4, N'Продавец')
SET IDENTITY_INSERT [dbo].[JobTitle] OFF
GO
SET IDENTITY_INSERT [dbo].[Material] ON 

INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (1, N'Цельный массив дерева Дуб 1000х600 мм', 1, 7450, 1501, 500, 8, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (2, N'Клееный массив дерева Дуб 1000х600 мм', 1, 4520, 300, 500, 7, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (3, N'Шпон облицовочный Дуб натуральный 2750х480 мм', 1, 2500, 2000, 1500, 20, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (4, N'Фанера 2200х1000 мм', 2, 2245, 450, 1000, 53, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (5, N'ДСП 2750х1830 мм', 2, 529.6, 1010, 1200, 181, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (6, N'МДФ 2070х1400 мм', 2, 417.24, 1550, 1000, 87, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (7, N'ДВП 2440х2050 мм', 2, 187, 1310, 1000, 190, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (8, N'ХДФ 2800x2070 мм', 2, 370.96, 1400, 1200, 90, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (9, N'Экокожа 140 см', 3, 1600, 1200, 1500, 100, N'пог.м')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (10, N'Велюр 140 см', 3, 1300, 1300, 1500, 100, N'пог.м')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (11, N'Шенилл 140 см', 3, 620, 950, 1500, 100, N'пог.м')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (12, N'Рогожка 140 см', 3, 720, 960, 1500, 100, N'пог.м')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (13, N'Закаленное стекло 2600х1800 мм', 4, 1148, 1000, 500, 197, N'м²')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (14, N'Металлокаркас для стула', 5, 1100, 300, 250, 5, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (15, N'Металлокаркас каркас из профиля с траверсами для стола', 5, 6700, 100, 100, 1, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (16, N'Колесо для мебели поворотное', 6, 10.59, 1500, 1000, 500, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (17, N'Газ-лифт', 5, 730, 500, 250, 5, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (18, N'Металлическая крестовина для офисных кресел', 5, 2700, 500, 250, 5, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (19, N'Пластиковый комплект для стула', 6, 900, 300, 250, 100, N'шт')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (20, N'Кромка ПВХ', 6, 35.8, 1500, 1000, 100, N'м')
INSERT [dbo].[Material] ([IdMaterial], [NameMaterial], [MaterialTypeId], [UnitPrice], [CountInStock], [MinimumCount], [CountPerPackage], [UnitOfMeasurement]) VALUES (24, N'new3', 1, 33, 50, 30, 0, N'шт')
SET IDENTITY_INSERT [dbo].[Material] OFF
GO
SET IDENTITY_INSERT [dbo].[MaterialProduct] ON 

INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (1, 4, 1, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (2, 10, 1, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (3, 11, 1, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (4, 12, 1, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (5, 14, 1, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (6, 16, 1, 5)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (7, 17, 1, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (8, 18, 1, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (9, 19, 1, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (10, 4, 2, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (11, 9, 2, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (12, 11, 2, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (13, 12, 2, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (14, 14, 2, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (15, 16, 2, 5)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (16, 17, 2, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (17, 18, 2, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (18, 19, 2, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (19, 4, 3, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (20, 9, 3, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (21, 10, 3, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (22, 14, 3, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (23, 16, 3, 5)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (24, 17, 3, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (25, 18, 3, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (26, 19, 3, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (27, 5, 4, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (28, 20, 4, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (29, 2, 5, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (30, 3, 5, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (31, 6, 5, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (32, 8, 5, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (33, 2, 6, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (34, 3, 6, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (35, 8, 6, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (36, 5, 7, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (37, 7, 7, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (38, 20, 7, 7)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (39, 6, 8, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (40, 15, 8, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (41, 5, 9, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (42, 20, 9, 9)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (43, 6, 10, 8)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (44, 8, 10, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (45, 15, 10, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (46, 5, 11, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (47, 20, 11, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (48, 4, 12, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (49, 5, 12, 5)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (50, 5, 12, 5)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (51, 7, 12, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (52, 20, 12, 9)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (53, 1, 13, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (54, 3, 13, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (55, 8, 13, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (56, 13, 13, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (57, 1, 14, 8)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (58, 3, 14, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (59, 5, 14, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (60, 6, 14, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (61, 8, 14, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (62, 9, 14, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (63, 5, 15, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (64, 7, 15, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (65, 16, 15, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (66, 20, 15, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (67, 2, 16, 0)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (68, 16, 16, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (69, 3, 17, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (70, 5, 17, 8)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (71, 7, 17, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (72, 20, 17, 6)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (73, 3, 18, 3)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (74, 4, 18, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (75, 7, 18, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (76, 13, 18, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (77, 3, 19, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (78, 5, 19, 8)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (79, 8, 19, 1)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (80, 1, 20, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (81, 3, 20, 4)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (82, 8, 20, 2)
INSERT [dbo].[MaterialProduct] ([IdMaterialProduct], [MateriaId], [ProductId], [RequiredCountOfMaterial]) VALUES (83, 13, 20, 2)
SET IDENTITY_INSERT [dbo].[MaterialProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[MaterialType] ON 

INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (1, N'Дерево', 0.0055)
INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (2, N'Древесная плита', 0.003)
INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (3, N'Текстиль', 0.0015)
INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (4, N'Стекло', 0.0045)
INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (5, N'Металл', 0.001)
INSERT [dbo].[MaterialType] ([IdMaterialType], [NameMaterialType], [PercentageOfRawMaterialLosses]) VALUES (6, N'Пластик', 0.0005)
SET IDENTITY_INSERT [dbo].[MaterialType] OFF
GO
SET IDENTITY_INSERT [dbo].[PostalCode] ON 

INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (1, 652050)
INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (2, 164500)
INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (3, 188910)
INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (4, 143960)
INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (5, 309500)
INSERT [dbo].[PostalCode] ([IdPostalCode], [Number]) VALUES (6, 197910)
SET IDENTITY_INSERT [dbo].[PostalCode] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (1, 1, N'Кресло детское цвет Белый и Розовый', 3028272, 15324.99, N'Кресло детское.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (2, 1, N'Кресло офисное цвет Черный', 3018556, 21443.99, N'Кресло офисное.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (3, 1, N'Кресло эргономичное цвет Темно-коричневый  ', 3549922, 24760, N'Кресло офисное.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (4, 2, N'Полка настольная', 7028048, 2670.89, N'Полка настольная.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (5, 3, N'Стеллаж для документов цвет Дуб светлый 854х445х2105 мм', 5759324, 24899, N'Стеллаж.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (6, 3, N'Стеллаж цвет Белый с ящиками 854х445х2105 мм', 5259474, 16150, N'Стеллаж.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (7, 3, N'Стеллаж цвет Орех 400х370х2000 мм', 5118827, 2860, N'Стеллаж.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (8, 4, N'Стол для ноутбука на металлокаркасе 800х600х123 мм', 1029784, 14690, N'Стол для ноутбука.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (9, 4, N'Стол компьютерный 700х600х500 мм', 1028248, 4105.89, N'Стол компьютерный.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (10, 4, N'Стол компьютерный на металлокаркасе 1400х600х750 мм', 1130981, 13899, N'Стол компьютерныйМеталл.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (11, 4, N'Стол письменный 1100x750x600 мм', 1188827, 5148, N'Стол письменный.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (12, 4, N'Стол письменный с тумбочкой 4 ящика 1100x750x600 мм', 1029272, 15325, N'Стол письменный.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (13, 4, N'Стол руководителя письменный цвет Венге 1600x800x764 мм', 1016662, 43500.9, N'Стол руководителя.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (14, 4, N'Стол руководителя письменный цвет Орех темный 2300x1000x750 мм', 1658953, 132500, N'Стол руководителя.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (15, 5, N'Тумба выкатная 3 ящика', 6033136, 3750, N'Тумба выкатная.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (16, 5, N'Тумба офисная для оргтехники', 6115947, 2450, N'Тумба выкатная.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (17, 3, N'Узкий пенал стеллаж 5 полок цвет Орех 364х326x2000 мм ', 5559898, 8348, N'Стеллаж.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (18, 6, N'Шкаф для книг 800x420x2000 мм', 4159043, 23390.99, N'Шкаф для книг2м.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (19, 6, N'Шкаф для одежды цвет Венге 602x420x2000 мм', 4758375, 12035, N'Шкаф для одежды.jpg')
INSERT [dbo].[Product] ([IdProduct], [ProductTypeId], [NameProduct], [ArticleNumber], [MinimumCostForPartner], [PathImage]) VALUES (20, 6, N'Шкаф-витрина 2 ящика 800x420x2000 мм', 4588376, 31991, N'Шкаф-витрина.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductType] ON 

INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (1, N'Кресла', 1.95)
INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (2, N'Полки', 2.5)
INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (3, N'Стеллажи', 4.35)
INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (4, N'Столы', 5.5)
INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (5, N'Тумбы', 7.6)
INSERT [dbo].[ProductType] ([IdProductType], [NameProductType], [ProductTypeCoefficient]) VALUES (6, N'Шкафы', 6.72)
SET IDENTITY_INSERT [dbo].[ProductType] OFF
GO
SET IDENTITY_INSERT [dbo].[Region] ON 

INSERT [dbo].[Region] ([IdRegion], [NameRegion]) VALUES (1, N'Кемеровская')
INSERT [dbo].[Region] ([IdRegion], [NameRegion]) VALUES (2, N'Архангельская')
INSERT [dbo].[Region] ([IdRegion], [NameRegion]) VALUES (3, N'Ленинградская')
INSERT [dbo].[Region] ([IdRegion], [NameRegion]) VALUES (4, N'Московская')
INSERT [dbo].[Region] ([IdRegion], [NameRegion]) VALUES (5, N'Белгородская')
SET IDENTITY_INSERT [dbo].[Region] OFF
GO
SET IDENTITY_INSERT [dbo].[Street] ON 

INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (1, N'Лесная', 1)
INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (2, N'Строителей', 2)
INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (3, N'Парковая', 3)
INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (4, N'Свободы', 4)
INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (5, N'Рабочая', 5)
INSERT [dbo].[Street] ([IdStreet], [NameStreet], [CityId]) VALUES (6, N'Ленина', 6)
SET IDENTITY_INSERT [dbo].[Street] OFF
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_PostalCode] FOREIGN KEY([PostalCodeId])
REFERENCES [dbo].[PostalCode] ([IdPostalCode])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_PostalCode]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Street] FOREIGN KEY([StreetId])
REFERENCES [dbo].[Street] ([IdStreet])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Street]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_Region] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Region] ([IdRegion])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_Region]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([IdAddress])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Address]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientDirector] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[ClientDirector] ([IdDirector])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientDirector]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientType] FOREIGN KEY([ClientTypeId])
REFERENCES [dbo].[ClientType] ([IdClientType])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EntranceType] FOREIGN KEY([EntranceTypeId])
REFERENCES [dbo].[EntranceType] ([IdEntranceType])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_EntranceType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_JobTitle] FOREIGN KEY([JobTitleId])
REFERENCES [dbo].[JobTitle] ([IdJobTitle])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_JobTitle]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_MaterialType] FOREIGN KEY([MaterialTypeId])
REFERENCES [dbo].[MaterialType] ([IdMaterialType])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_MaterialType]
GO
ALTER TABLE [dbo].[MaterialProduct]  WITH CHECK ADD  CONSTRAINT [FK_MaterialProduct_Material] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Material] ([IdMaterial])
GO
ALTER TABLE [dbo].[MaterialProduct] CHECK CONSTRAINT [FK_MaterialProduct_Material]
GO
ALTER TABLE [dbo].[MaterialProduct]  WITH CHECK ADD  CONSTRAINT [FK_MaterialProduct_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([IdProduct])
GO
ALTER TABLE [dbo].[MaterialProduct] CHECK CONSTRAINT [FK_MaterialProduct_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductType] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[ProductType] ([IdProductType])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductType]
GO
ALTER TABLE [dbo].[Street]  WITH CHECK ADD  CONSTRAINT [FK_Street_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([IdCity])
GO
ALTER TABLE [dbo].[Street] CHECK CONSTRAINT [FK_Street_City]
GO
USE [master]
GO
ALTER DATABASE [Shamilova_ObrazPlus] SET  READ_WRITE 
GO
