USE [master]
GO
/****** Object:  Database [RADON]    Script Date: 08/01/2024 19:38:37 ******/
CREATE DATABASE [RADON]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RADON', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RADON.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RADON_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RADON_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RADON] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RADON].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RADON] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RADON] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RADON] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RADON] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RADON] SET ARITHABORT OFF 
GO
ALTER DATABASE [RADON] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RADON] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RADON] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RADON] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RADON] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RADON] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RADON] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RADON] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RADON] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RADON] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RADON] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RADON] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RADON] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RADON] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RADON] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RADON] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RADON] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RADON] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RADON] SET  MULTI_USER 
GO
ALTER DATABASE [RADON] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RADON] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RADON] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RADON] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RADON] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RADON] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [RADON] SET QUERY_STORE = OFF
GO
USE [RADON]
GO
/****** Object:  Table [dbo].[conformite]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conformite](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [varchar](max) NOT NULL,
 CONSTRAINT [PK_conformite] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detecteur]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detecteur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[datePose] [date] NOT NULL,
	[valeurReleve] [decimal](18, 2) NULL,
	[nomPiece] [varchar](max) NOT NULL,
	[dateRetrait] [date] NULL,
	[idEtablissement] [int] NOT NULL,
 CONSTRAINT [PK_detecteur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[etablissement]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[etablissement](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[raisonSociale] [varchar](max) NOT NULL,
	[formeJuridique] [varchar](max) NOT NULL,
	[siret] [varchar](max) NOT NULL,
	[adresse] [varchar](max) NOT NULL,
	[mail] [varchar](max) NOT NULL,
	[telephone] [varchar](max) NOT NULL,
	[idConformite] [int] NULL,
	[idTechnicien] [int] NOT NULL,
 CONSTRAINT [PK_etablissement] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](max) NOT NULL,
	[nom] [varchar](max) NOT NULL,
	[prenom] [varchar](max) NOT NULL,
	[password] [varchar](max) NOT NULL,
	[estTechnicien] [bit] NOT NULL,
 CONSTRAINT [PK_utilisateur] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[conformite] ON 

INSERT [dbo].[conformite] ([id], [libelle]) VALUES (1, N'Conforme')
INSERT [dbo].[conformite] ([id], [libelle]) VALUES (2, N'Non-conformité mineure')
INSERT [dbo].[conformite] ([id], [libelle]) VALUES (3, N'Non-conformité majeure')
SET IDENTITY_INSERT [dbo].[conformite] OFF
GO
SET IDENTITY_INSERT [dbo].[detecteur] ON 

INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (41, CAST(N'2023-04-03' AS Date), CAST(108.00 AS Decimal(18, 2)), N'E09B7EB', CAST(N'2023-07-02' AS Date), 21)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (42, CAST(N'2020-06-21' AS Date), CAST(2053.00 AS Decimal(18, 2)), N'5B080A8', CAST(N'2020-09-19' AS Date), 29)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (43, CAST(N'2001-08-28' AS Date), CAST(719.00 AS Decimal(18, 2)), N'BC9A38A', CAST(N'2001-11-26' AS Date), 23)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (44, CAST(N'2023-11-13' AS Date), NULL, N'244E208', NULL, 34)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (45, CAST(N'2022-12-11' AS Date), CAST(436.00 AS Decimal(18, 2)), N'6C90CD1', CAST(N'2023-03-11' AS Date), 36)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (46, CAST(N'2004-07-04' AS Date), CAST(1362.00 AS Decimal(18, 2)), N'47B3D69', CAST(N'2004-10-02' AS Date), 37)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (47, CAST(N'2007-12-31' AS Date), NULL, N'E76A217', NULL, 25)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (48, CAST(N'2023-03-22' AS Date), NULL, N'A6BAA3C', NULL, 36)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (49, CAST(N'2007-10-27' AS Date), CAST(2746.00 AS Decimal(18, 2)), N'832F440', CAST(N'2008-01-25' AS Date), 28)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (50, CAST(N'2013-03-15' AS Date), CAST(2316.00 AS Decimal(18, 2)), N'9ED11B8', CAST(N'2013-06-13' AS Date), 29)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (51, CAST(N'2019-02-04' AS Date), CAST(944.00 AS Decimal(18, 2)), N'9CB4ABE', CAST(N'2019-05-05' AS Date), 27)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (52, CAST(N'2001-03-14' AS Date), NULL, N'AF6B1E8', NULL, 32)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (53, CAST(N'2009-05-29' AS Date), NULL, N'864AE03', NULL, 28)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (54, CAST(N'2017-05-30' AS Date), NULL, N'B1D6822', NULL, 29)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (55, CAST(N'2000-12-10' AS Date), NULL, N'3F53153', NULL, 27)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (56, CAST(N'2023-08-11' AS Date), CAST(200.00 AS Decimal(18, 2)), N'Hall entrée', CAST(N'2023-11-11' AS Date), 47)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (57, CAST(N'2023-08-11' AS Date), CAST(3.00 AS Decimal(18, 2)), N'Hall entrée', CAST(N'2023-11-11' AS Date), 46)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (58, CAST(N'2023-08-11' AS Date), CAST(3.00 AS Decimal(18, 2)), N'Salle 1', CAST(N'2023-11-11' AS Date), 46)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (59, CAST(N'2023-08-11' AS Date), CAST(5.00 AS Decimal(18, 2)), N'Salle 2', CAST(N'2023-11-11' AS Date), 46)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (60, CAST(N'2023-08-11' AS Date), CAST(5.00 AS Decimal(18, 2)), N'Hall entrée', CAST(N'2023-11-11' AS Date), 45)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (61, CAST(N'2023-08-11' AS Date), CAST(6.00 AS Decimal(18, 2)), N'Salle 1', CAST(N'2023-11-11' AS Date), 45)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (62, CAST(N'2023-08-11' AS Date), CAST(7.00 AS Decimal(18, 2)), N'Salle 2', CAST(N'2023-11-11' AS Date), 45)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (65, CAST(N'2023-08-11' AS Date), CAST(200.00 AS Decimal(18, 2)), N'Hall entrée', CAST(N'2023-11-11' AS Date), 44)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (66, CAST(N'2023-08-11' AS Date), CAST(100.00 AS Decimal(18, 2)), N'Salle 1', CAST(N'2023-11-11' AS Date), 44)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (67, CAST(N'2023-08-11' AS Date), CAST(210.00 AS Decimal(18, 2)), N'Salle 2', CAST(N'2023-11-11' AS Date), 44)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (68, CAST(N'2023-08-11' AS Date), CAST(3.00 AS Decimal(18, 2)), N'Hall entrée', CAST(N'2023-11-11' AS Date), 43)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (69, CAST(N'2023-08-11' AS Date), CAST(5.00 AS Decimal(18, 2)), N'Salle 1', CAST(N'2023-11-11' AS Date), 43)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (70, CAST(N'2023-08-11' AS Date), CAST(3.70 AS Decimal(18, 2)), N'Salle 2', CAST(N'2023-11-11' AS Date), 43)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (71, CAST(N'2023-12-27' AS Date), NULL, N'classe 1', NULL, 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (72, CAST(N'2023-12-27' AS Date), NULL, N'classe 2', NULL, 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (73, CAST(N'2023-12-27' AS Date), NULL, N'classe 3', CAST(N'2024-03-17' AS Date), 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (74, CAST(N'2023-12-27' AS Date), NULL, N'classe 4', CAST(N'2024-03-18' AS Date), 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (75, CAST(N'2023-12-27' AS Date), NULL, N'classe 5', CAST(N'2024-03-18' AS Date), 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (76, CAST(N'2023-12-27' AS Date), NULL, N'classe 6', NULL, 42)
INSERT [dbo].[detecteur] ([id], [datePose], [valeurReleve], [nomPiece], [dateRetrait], [idEtablissement]) VALUES (77, CAST(N'2023-12-27' AS Date), NULL, N'classe 7', NULL, 42)
SET IDENTITY_INSERT [dbo].[detecteur] OFF
GO
SET IDENTITY_INSERT [dbo].[etablissement] ON 

INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (21, N'E3EE0BFD-', N'4BBFC4E', N'BFF2B94D-E230', N'E26D5E51-5A', N'EFFA5D18-', N'0408014223', 1, 24)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (22, N'3D0A7E1A-', N'9A970CA', N'00B91D65-1E16', N'E7F9BA0F-C9', N'B7B65002-', N'0408134407', NULL, 15)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (23, N'5E5A2CE4-', N'D268377', N'8836F793-CE3F', N'2D388043-7A', N'A6A84B96-', N'0405072432', 2, 8)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (24, N'27612593-', N'7C087BB', N'C8DDDC37-7864', N'C8E66DC4-1B', N'B04760EC-', N'0408678924', NULL, 28)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (25, N'9A3573F7-', N'13A23DC', N'92AFE03D-3823', N'28F886A6-2F', N'C04D692F-', N'0403258234', NULL, 5)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (26, N'62435F5A-', N'DC3FCB9', N'D321551C-1C47', N'C7B27A72-95', N'25C5BC6E-', N'0403116107', NULL, 24)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (27, N'29DE03CC-', N'108E329', N'1CEDD014-94B5', N'D3E33A31-0C', N'7AF9A563-', N'0401902165', 2, 27)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (28, N'61AB914F-', N'180C4CF', N'F558C16B-973C', N'EF99A5B7-47', N'23AB944B-', N'0407699095', 3, 8)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (29, N'F402994B-', N'A2DA21C', N'4570C762-ADF2', N'B2BA1B2F-B3', N'9C16E3B9-', N'0409533275', 3, 8)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (30, N'202AE82C-', N'317CE9B', N'781FADD6-E5A0', N'A013B94C-40', N'5E247E7C-', N'0408182300', NULL, 8)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (31, N'5D91051A-', N'33DF221', N'B5F79C64-5F47', N'D3A33FF2-C8', N'1658E34A-', N'0408867795', NULL, 29)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (32, N'E1D6C8C5-', N'C2BCAB2', N'2020DD50-32BB', N'74EA434F-C2', N'A5D93A6F-', N'0400983962', NULL, 16)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (33, N'B3290CEA-', N'137B7FE', N'F2EAF62D-7BAB', N'0BB4ADD5-79', N'45C65549-', N'0400055277', NULL, 10)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (34, N'9298B41E-', N'4C2FB01', N'A2BF39E7-ACA9', N'770F7FE5-5F', N'FB88EC6C-', N'0403209148', NULL, 22)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (35, N'275E8D0D-', N'5774664', N'A99842F6-B75A', N'D38195D9-89', N'7F47DC95-', N'0408613092', NULL, 4)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (36, N'8792391A-', N'154EDA1', N'E72ADADF-4D27', N'6DD42BDE-13', N'DD4B3870-', N'0405803538', 2, 24)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (37, N'09250A00-', N'7F5445B', N'6EE70CE9-2483', N'2EBDCD4D-26', N'C5E30B8D-', N'0409191581', 3, 15)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (38, N'0B1A9493-', N'E0823F6', N'853AB1FA-6396', N'3BDF69DB-A4', N'3E22D4F2-', N'0400006483', NULL, 30)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (39, N'BDFBD963-', N'522711A', N'3997570E-F86E', N'6C60A577-1D', N'D0DBAB7D-', N'0405454891', NULL, 7)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (40, N'DF6B7F6C-', N'9F2E080', N'313FF936-E6CA', N'6705C4A8-70', N'EA07ED6A-', N'0401850921', NULL, 5)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (41, N'RaisonSociale', N'SARL', N'A1Z2E3R4T5Y6U7', N'2 rue paslinspi 42000 Saint Etienne', N'mail@mail.com', N'0123456789', NULL, 4)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (42, N'Test', N'SARL', N'A1Z2E3R4T5Y6U7', N'2 rue random 42000 Saint Etienne', N'mail@mail.fr', N'1234567890', NULL, 5)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (43, N'Raison Sociale', N'SAS', N'1234567AZERTYU', N'2 rue de la vie 69320 Feyzin', N'mail@mail.fr', N'0123456789', 1, 7)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (44, N'Radon test', N'SAS', N'1234567AZERTYU', N'14 boulevard Cpasla 42100 Saint Etienne', N'mail@mail.fr', N'1234567890', 1, 8)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (45, N'Super Experts', N'SARL', N'AZERTQSDFG1234', N'14 rue Radon 42000 Saint Etienne', N'radon@mail.com', N'1234567890', 1, 14)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (46, N'ProRadon', N'SAS', N'AETUOQDGJL1357', N'2 rue Michel 42700 Firminy', N'mail@mail.fr', N'1234567890', NULL, 15)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (47, N'RemoveRadon', N'SARL', N'D9F8R7E6S5Z4Q4', N'56 avenue du radon 42700 Firminy', N'mail@mail.com', N'1234567890', NULL, 20)
INSERT [dbo].[etablissement] ([id], [raisonSociale], [formeJuridique], [siret], [adresse], [mail], [telephone], [idConformite], [idTechnicien]) VALUES (48, N'AntiRadon', N'SARL', N'WVSTR26D478H56', N'6 boulevard du chat 42700 Firminy', N'mail@mail.com', N'1234567890', NULL, 20)
SET IDENTITY_INSERT [dbo].[etablissement] OFF
GO
SET IDENTITY_INSERT [dbo].[utilisateur] ON 

INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (1, N'D7FE0F4', N'B8903E4', N'72704D7', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (2, N'20D506D', N'C51086E', N'80B14DB', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (3, N'8CB170C', N'8DC134B', N'59DA10F', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (4, N'DC5D405', N'7407DD9', N'33B6C63', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (5, N'E2D8ECD', N'7136894', N'831F6CC', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (6, N'555E67A', N'B1D5353', N'1CCFCBB', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (7, N'AEEE2EB', N'B076027', N'D832AD3', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (8, N'3250F39', N'8C4C3B1', N'627CFD7', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (9, N'D78CB2D', N'948D6DB', N'F7A8B16', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (10, N'9D7458E', N'816FE48', N'F381904', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (11, N'20EF737', N'20B20A0', N'FB03958', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (12, N'2BF631B', N'8813957', N'17D0AFF', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (13, N'0C92AB5', N'F91BC87', N'5ECED4C', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (14, N'8366132', N'8E6CFA4', N'00F3572', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (15, N'FFEB6DF', N'F829D6A', N'B7B7A78', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (16, N'5863C15', N'24A0E1B', N'1A2E5FE', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (17, N'EE812B7', N'541EC52', N'1D4A35A', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (18, N'54247C1', N'D224834', N'3A6080F', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (19, N'30BDBE5', N'B7113F5', N'2970610', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 0)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (20, N'8920672', N'47A3068', N'6779D0C', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (21, N'B179233', N'0D58E63', N'13FB3FC', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (22, N'1CFE2C5', N'EF961DC', N'FC5AD70', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (23, N'BB14978', N'DC53FA9', N'0A40D0B', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (24, N'2047308', N'E108440', N'58FF54A', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (25, N'CC03460', N'E4166B2', N'30F99C4', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (26, N'C9AF169', N'CFB7767', N'6000057', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (27, N'57239DC', N'DA21E0C', N'086BB62', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (28, N'F2F2D23', N'069F622', N'44B4663', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (29, N'852562A', N'FEDA531', N'B4A7F11', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
INSERT [dbo].[utilisateur] ([id], [login], [nom], [prenom], [password], [estTechnicien]) VALUES (30, N'16DC338', N'4539DD9', N'7D2E1E1', N'10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611', 1)
SET IDENTITY_INSERT [dbo].[utilisateur] OFF
GO
ALTER TABLE [dbo].[detecteur]  WITH CHECK ADD  CONSTRAINT [FK_detecteur_etablissement] FOREIGN KEY([idEtablissement])
REFERENCES [dbo].[etablissement] ([id])
GO
ALTER TABLE [dbo].[detecteur] CHECK CONSTRAINT [FK_detecteur_etablissement]
GO
ALTER TABLE [dbo].[etablissement]  WITH CHECK ADD  CONSTRAINT [FK_etablissement_conformite] FOREIGN KEY([idConformite])
REFERENCES [dbo].[conformite] ([id])
GO
ALTER TABLE [dbo].[etablissement] CHECK CONSTRAINT [FK_etablissement_conformite]
GO
ALTER TABLE [dbo].[etablissement]  WITH CHECK ADD  CONSTRAINT [FK_etablissement_utilisateur] FOREIGN KEY([idTechnicien])
REFERENCES [dbo].[utilisateur] ([id])
GO
ALTER TABLE [dbo].[etablissement] CHECK CONSTRAINT [FK_etablissement_utilisateur]
GO
/****** Object:  StoredProcedure [dbo].[AddConformite]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[AddConformite]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
	UPDATE etablissement 
	SET idConformite = 1 
	WHERE id in 
	(
		SELECT DISTINCT etablissement.id
		FROM 
		etablissement
		JOIN detecteur 
		ON detecteur.idEtablissement = etablissement.id	
		WHERE detecteur.valeurReleve < 300
	);

	UPDATE etablissement 
	SET idConformite = 2 
	WHERE id in 
	(
		SELECT DISTINCT etablissement.id
		FROM 
		etablissement
		JOIN detecteur 
		ON detecteur.idEtablissement = etablissement.id	
		WHERE detecteur.valeurReleve BETWEEN 300 AND 1000
		);

	UPDATE etablissement 
	SET idConformite = 3 
	WHERE id in 
	(
		SELECT DISTINCT etablissement.id
		FROM 
		etablissement
		JOIN detecteur 
		ON detecteur.idEtablissement = etablissement.id	
		WHERE detecteur.valeurReleve > 1000
	);
END

GO
/****** Object:  StoredProcedure [dbo].[AddDetecteur]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[AddDetecteur]
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    DECLARE @max AS INT = 40 ; -- Génére 40 détecteurs
    DECLARE @i AS INT = 0;

    WHILE @i < @max
    BEGIN

		DECLARE @nbJourMax AS INT = DATEDIFF(DAY, GETDATE(), '2000-01-01'); -- Nb de jour entre auj et 2000
		DECLARE @nbJour AS INT = RAND() * @nbJourMax; -- Nb jour randomisé
		DECLARE @datePose AS DATE = DATEADD(DAY, @nbJour, GETDATE()); -- Définition d'une date aléatoire
		DECLARE @nomPiece AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 8); -- chaine aléatoire
		DECLARE @idEtablissement AS INT = (SELECT TOP 1 id FROM etablissement ORDER BY NEWID()); -- Clé étrangère aléatoire
		DECLARE @valeurReleve AS DECIMAL
		DECLARE @dateRetrait AS DATE

		        -- Génération aléatoire de la date de retrait et de la valeur dans 50% des cas
        IF RAND() < 0.5
        BEGIN
			SET @valeurReleve = 2.5+RAND()*3000;
            SET @dateRetrait = DATEADD(DAY, 90, @datePose); -- La date de retrait est jusqu'à 90 jours après la pose
        END
		ELSE
		BEGIN
			SET @valeurReleve = NULL;
			SET @dateRetrait = NULL;
		END


        INSERT INTO detecteur(datePose, valeurReleve, nomPiece, dateRetrait, idEtablissement)
        VALUES (@datePose, @valeurReleve, @nomPiece, @dateRetrait, @idEtablissement);

        SET @i = @i + 1; -- Incrémentation de @i

    END

    SELECT CONCAT(@i, ' detecteurs ajoutés') AS Resultat;

END
GO
/****** Object:  StoredProcedure [dbo].[Addetablissement]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[Addetablissement] 
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    DECLARE @max AS INT = 20 ; -- Génére 20 établissements
    DECLARE @i AS INT = 0;

    WHILE @i < @max
    BEGIN

        DECLARE @raisonSociale AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 10); -- Chaine aléatoire
		DECLARE @formeJuridique AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 8); -- Chaine aléatoire
        DECLARE @siret AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 14); -- Chaine aléatoire
		DECLARE @adresse AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 12); -- Chaine aléatoire
		DECLARE @mail AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 10); -- Chaine aléatoire
        DECLARE @telephone AS VARCHAR(MAX) = CONCAT('04', RIGHT('0000000' + CAST(ABS(CHECKSUM(NEWID())) % 10000000 AS VARCHAR(8)), 8));
		DECLARE @idTechnicien AS INT = (SELECT TOP 1 id FROM utilisateur WHERE estTechnicien=1 ORDER BY NEWID()); -- Clé étrangère aléatoire


        INSERT INTO etablissement(raisonSociale, formeJuridique, siret, adresse, mail, telephone, idTechnicien)
        VALUES (@raisonSociale, @formeJuridique, @siret, @adresse, @mail, @telephone, @idTechnicien);

        SET @i = @i + 1; -- Incrémentation de @i

    END

    SELECT CONCAT(@i, ' établissement ajoutées') AS Resultat;

END

GO
/****** Object:  StoredProcedure [dbo].[AddUtilisateur]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[AddUtilisateur] 
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    DECLARE @max AS INT = 30 ; -- Génére 30 utilisateurs
    DECLARE @i AS INT = 0;

    WHILE @i < @max
    BEGIN

        DECLARE @loginTemp AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 8); -- Chaine aléatoire
		DECLARE @nomTemp AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 8); -- Chaine aléatoire
        DECLARE @prenomTemp AS VARCHAR(MAX) = SUBSTRING(CONVERT(VARCHAR(MAX), NEWID()), 0, 8); -- Chaine aléatoire
		DECLARE @passwordTemp AS VARCHAR(MAX) = '10e06b990d44de0091a2113fd95c92fc905166af147aa7632639c41aa7f26b1620c47443813c605b924c05591c161ecc35944fc69c4433a49d10fc6b04a33611' ; -- Hash du mdp toto
		DECLARE @estTechnicienTemp AS BIT = IIF(RAND() < 0.7, 1, 0); -- Technicien dans 70 % des cas


        INSERT INTO utilisateur(login, nom, prenom, password, estTechnicien)
        VALUES (@loginTemp, @nomTemp, @prenomTemp, @passwordTemp, @estTechnicienTemp);

        SET @i = @i + 1; -- Incrémentation de @i

    END

    SELECT CONCAT(@i, ' utilisateurs ajoutées') AS Resultat;

END

GO
/****** Object:  StoredProcedure [dbo].[CalculConformite]    Script Date: 08/01/2024 19:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[CalculConformite]
@idEtablissement INT, -- id de l'établissement pour qui on fait le calcul
@resultat VARCHAR(MAX) OUTPUT
AS
BEGIN
    --DECLARE @Erreur VARCHAR(MAX) = '';

    IF NOT EXISTS (SELECT * FROM Detecteur WHERE IdEtablissement = @IdEtablissement)
    BEGIN
        -- Si la liste des détecteurs est vide
        SET @resultat = 'La liste des détecteurs est vide';
    END
    ELSE IF EXISTS (SELECT * FROM Detecteur WHERE IdEtablissement = @IdEtablissement AND valeurReleve IS NULL)
    BEGIN
        -- Si certains détecteurs n'ont pas de valeur renseignée
        SET @resultat = 'Certains détecteurs ne connaissent pas de valeur';
    END
    ELSE
    BEGIN
        -- Calcul de la moyenne des valeurs des détecteurs
        DECLARE @Moyenne DECIMAL;
        SELECT @Moyenne = AVG(CAST(valeurReleve AS DECIMAL))
        FROM Detecteur
        WHERE IdEtablissement = @IdEtablissement;

        -- Détermination de la conformité en fonction de la moyenne
        IF @Moyenne < 300
            UPDATE etablissement SET idConformite = 1 WHERE id = @IdEtablissement;
        ELSE IF @Moyenne BETWEEN 300 AND 1000
            UPDATE etablissement SET idConformite = 2 WHERE id = @IdEtablissement;
        ELSE
            UPDATE etablissement SET idConformite = 3 WHERE id = @IdEtablissement;

		SET @resultat = 'Conformité enregistrée';
    END

    -- Renvoi du code d'erreur par la sortie de la procédure stockée
    SELECT @resultat AS Resultat;

END
GO
USE [master]
GO
ALTER DATABASE [RADON] SET  READ_WRITE 
GO
