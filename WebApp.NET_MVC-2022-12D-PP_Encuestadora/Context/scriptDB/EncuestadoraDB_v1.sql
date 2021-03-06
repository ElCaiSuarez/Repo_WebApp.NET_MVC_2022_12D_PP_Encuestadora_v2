USE [master]
GO
/****** Object:  Database [EncuestadoraDB_v1]    Script Date: 06/06/2022 20:01:05 ******/
CREATE DATABASE [EncuestadoraDB_v1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EncuestadoraDB_v1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EncuestadoraDB_v1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EncuestadoraDB_v1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EncuestadoraDB_v1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EncuestadoraDB_v1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EncuestadoraDB_v1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ARITHABORT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET RECOVERY FULL 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET  MULTI_USER 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EncuestadoraDB_v1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EncuestadoraDB_v1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EncuestadoraDB_v1', N'ON'
GO
ALTER DATABASE [EncuestadoraDB_v1] SET QUERY_STORE = OFF
GO
USE [EncuestadoraDB_v1]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 06/06/2022 20:01:05 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 06/06/2022 20:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [nvarchar](max) NOT NULL,
	[mailCliente] [nvarchar](max) NOT NULL,
	[passwordCliente] [nvarchar](max) NULL,
	[empresaCliente] [nvarchar](max) NULL,
	[cuitCliente] [nvarchar](max) NULL,
	[domicilioCliente] [nvarchar](max) NULL,
	[precioCliente] [int] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestas]    Script Date: 06/06/2022 20:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestas](
	[EncuestaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloEncuesta] [nvarchar](max) NOT NULL,
	[datetimeCreacionEncuesta] [datetime2](7) NOT NULL,
	[datetimeVencimientoEncuesta] [datetime2](7) NOT NULL,
	[puntosEncuesta] [int] NOT NULL,
 CONSTRAINT [PK_encuestas] PRIMARY KEY CLUSTERED 
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[opciones]    Script Date: 06/06/2022 20:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[opciones](
	[OpcionPreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloOpcion] [nvarchar](max) NOT NULL,
	[opcionSeleccionada] [bit] NOT NULL,
 CONSTRAINT [PK_opciones] PRIMARY KEY CLUSTERED 
(
	[OpcionPreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 06/06/2022 20:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preguntas](
	[PreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloPregunta] [nvarchar](max) NOT NULL,
	[tipoPregunta] [int] NOT NULL,
 CONSTRAINT [PK_preguntas] PRIMARY KEY CLUSTERED 
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 06/06/2022 20:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [nvarchar](max) NOT NULL,
	[mailUsuario] [nvarchar](max) NOT NULL,
	[passwordUsuario] [nvarchar](max) NULL,
	[dniUsuario] [nvarchar](max) NULL,
	[datetimeFechaNacimiento] [datetime2](7) NOT NULL,
	[domicilioUsuario] [nvarchar](max) NULL,
	[preferenciaUsuario] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601141923_GenerarBaseDeDatos', N'3.1.3')
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (1, N'Cliente 1', N'cliente1@dominio.com', N'password1', N'Empresa Cliente 1', N'20-22333444-4', N'Av. Rivadavia 5500', 10000)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (2, N'Cliente 2', N'cliente2@dominio.com', N'password2', N'Empresa Cliente 2', N'21-33444555-5', N'Av. Santa Fe 3300', 5000)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (3, N'Cliente 3', N'cliente3@dominio.com', N'password3', N'Empresa Cliente 3', N'22-44555666-6', N'Av. Libertador 4400', 0)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestas] ON 

INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta]) VALUES (1, N'Encuesta 1', CAST(N'2022-06-01T13:32:00.0000000' AS DateTime2), CAST(N'2022-06-08T13:32:00.0000000' AS DateTime2), 100)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta]) VALUES (2, N'Encuesta 2', CAST(N'2022-06-02T13:35:00.0000000' AS DateTime2), CAST(N'2022-06-16T13:35:00.0000000' AS DateTime2), 250)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta]) VALUES (3, N'Encuesta 3', CAST(N'2022-06-03T13:36:00.0000000' AS DateTime2), CAST(N'2022-07-01T13:36:00.0000000' AS DateTime2), 500)
SET IDENTITY_INSERT [dbo].[encuestas] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (1, N'Usuario 1', N'usuario1@dominio.com', N'password1', N'22333444', CAST(N'2003-06-10T09:00:00.0000000' AS DateTime2), N'Callao 2200', 3)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (2, N'Usuario 2', N'usuario2@dominio.com', N'password2', N'33444555', CAST(N'1995-08-20T09:00:00.0000000' AS DateTime2), N'Tucuman 1100', 5)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (3, N'Usuario3', N'usuario3@dominio.com', N'password3', N'44555666', CAST(N'1987-12-15T09:00:00.0000000' AS DateTime2), N'Esmeralda 6600', 2)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [EncuestadoraDB_v1] SET  READ_WRITE 
GO
