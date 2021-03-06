USE [master]
GO
/****** Object:  Database [EncuestadoraDB_v3]    Script Date: 07/06/2022 09:34:30 ******/
CREATE DATABASE [EncuestadoraDB_v3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EncuestadoraDB_v3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EncuestadoraDB_v3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EncuestadoraDB_v3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EncuestadoraDB_v3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EncuestadoraDB_v3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EncuestadoraDB_v3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ARITHABORT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET RECOVERY FULL 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET  MULTI_USER 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EncuestadoraDB_v3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EncuestadoraDB_v3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EncuestadoraDB_v3', N'ON'
GO
ALTER DATABASE [EncuestadoraDB_v3] SET QUERY_STORE = OFF
GO
USE [EncuestadoraDB_v3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/06/2022 09:34:30 ******/
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
/****** Object:  Table [dbo].[clientes]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [nvarchar](80) NOT NULL,
	[mailCliente] [nvarchar](40) NOT NULL,
	[passwordCliente] [nvarchar](10) NOT NULL,
	[empresaCliente] [nvarchar](40) NULL,
	[cuitCliente] [nvarchar](11) NULL,
	[domicilioCliente] [nvarchar](40) NULL,
	[precioCliente] [int] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestas]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestas](
	[EncuestaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloEncuesta] [nvarchar](40) NOT NULL,
	[datetimeCreacionEncuesta] [datetime2](7) NOT NULL,
	[datetimeVencimientoEncuesta] [datetime2](7) NOT NULL,
	[puntosEncuesta] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK_encuestas] PRIMARY KEY CLUSTERED 
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestasUsuarios]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestasUsuarios](
	[EncuestaId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_encuestasUsuarios] PRIMARY KEY CLUSTERED 
(
	[EncuestaId] ASC,
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[opciones]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[opciones](
	[OpcionPreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloOpcion] [nvarchar](40) NOT NULL,
	[opcionSeleccionada] [bit] NOT NULL,
	[PreguntaId] [int] NOT NULL,
 CONSTRAINT [PK_opciones] PRIMARY KEY CLUSTERED 
(
	[OpcionPreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preguntas](
	[PreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloPregunta] [nvarchar](40) NOT NULL,
	[tipoPregunta] [int] NOT NULL,
	[EncuestaId] [int] NOT NULL,
 CONSTRAINT [PK_preguntas] PRIMARY KEY CLUSTERED 
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/06/2022 09:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [nvarchar](80) NOT NULL,
	[mailUsuario] [nvarchar](40) NOT NULL,
	[passwordUsuario] [nvarchar](10) NOT NULL,
	[dniUsuario] [nvarchar](8) NOT NULL,
	[datetimeFechaNacimiento] [datetime2](7) NOT NULL,
	[domicilioUsuario] [nvarchar](40) NULL,
	[preferenciaUsuario] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220607011858_CrearBaseDeDatos_v1', N'3.1.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220607023308_CrearBaseDeDatos_v3', N'3.1.25')
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (1, N'Cliente 1', N'cliente1@dominio.com', N'password1', N'Empresa Cliente 1', N'20-22333444', N'Av. Rivadavia 5500', 0)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (2, N'Cliente 2', N'cliente2@dominio.com', N'password2', N'Empresa Cliente 2', N'21-33444555', N'Av. Santa Fe 3300', 5000)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (3, N'Cliente 3', N'cliente3@dominio.com', N'password3', N'Empresa Cliente 3', N'22-44555666', N'Av. Libertador 4400', 10000)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestas] ON 

INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (1, N'Encuesta 1', CAST(N'2022-06-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-13T00:00:00.0000000' AS DateTime2), 100, 1)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (2, N'Encuesta 2', CAST(N'2022-06-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-21T00:00:00.0000000' AS DateTime2), 250, 2)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (3, N'Encuesta 3', CAST(N'2022-06-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-28T00:00:00.0000000' AS DateTime2), 500, 3)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (4, N'Encuesta Vencida', CAST(N'2022-05-31T00:00:00.0000000' AS DateTime2), CAST(N'2022-06-06T00:00:00.0000000' AS DateTime2), 100, 1)
SET IDENTITY_INSERT [dbo].[encuestas] OFF
GO
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (1, 1)
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (2, 1)
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (3, 1)
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (1, 2)
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (2, 2)
INSERT [dbo].[encuestasUsuarios] ([EncuestaId], [UsuarioId]) VALUES (1, 3)
GO
SET IDENTITY_INSERT [dbo].[opciones] ON 

INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (1, N'Opcion 1', 0, 1)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (2, N'Opcion 2', 0, 1)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (3, N'Opcion 1', 0, 2)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (4, N'Opcion 2', 0, 2)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (5, N'Opcion 1', 0, 3)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (6, N'Opcion 2', 0, 3)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (7, N'Opcion 3', 0, 3)
SET IDENTITY_INSERT [dbo].[opciones] OFF
GO
SET IDENTITY_INSERT [dbo].[preguntas] ON 

INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (1, N'Encuesta 1 Pregunta 1 ', 0, 1)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (2, N'Encuesta 1 Pregunta 2', 1, 1)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (3, N'Encuesta 2 Pregunta 1', 0, 2)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (4, N'Encuesta 2 Pregunta 2', 2, 2)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (5, N'Encuesta 2 Pregunta 3', 0, 2)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (6, N'Encuesta 3 Pregunta 1', 0, 3)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (7, N'Encuesta 3 Pregunta 2', 0, 3)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (8, N'Encuesta 3 Pregunta 3', 1, 3)
SET IDENTITY_INSERT [dbo].[preguntas] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (1, N'Usuario 1', N'usuario1@dominio.com', N'password1', N'22333444', CAST(N'2017-02-08T00:00:00.0000000' AS DateTime2), N'Callao 2200', 1)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (2, N'Usuario 2', N'usuario2@dominio.com', N'password2', N'33444555', CAST(N'2022-06-01T00:00:00.0000000' AS DateTime2), N'Tucuman 1100', 2)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [preferenciaUsuario]) VALUES (3, N'Usuario3', N'usuario3@dominio.com', N'password3', N'44555666', CAST(N'2022-06-03T00:00:00.0000000' AS DateTime2), N'Esmeralda 6600', 3)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
/****** Object:  Index [IX_encuestas_ClienteId]    Script Date: 07/06/2022 09:34:30 ******/
CREATE NONCLUSTERED INDEX [IX_encuestas_ClienteId] ON [dbo].[encuestas]
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_encuestasUsuarios_UsuarioId]    Script Date: 07/06/2022 09:34:30 ******/
CREATE NONCLUSTERED INDEX [IX_encuestasUsuarios_UsuarioId] ON [dbo].[encuestasUsuarios]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_opciones_PreguntaId]    Script Date: 07/06/2022 09:34:30 ******/
CREATE NONCLUSTERED INDEX [IX_opciones_PreguntaId] ON [dbo].[opciones]
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_preguntas_EncuestaId]    Script Date: 07/06/2022 09:34:30 ******/
CREATE NONCLUSTERED INDEX [IX_preguntas_EncuestaId] ON [dbo].[preguntas]
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[encuestas] ADD  DEFAULT ((0)) FOR [ClienteId]
GO
ALTER TABLE [dbo].[encuestas]  WITH CHECK ADD  CONSTRAINT [FK_encuestas_clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[clientes] ([ClienteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestas] CHECK CONSTRAINT [FK_encuestas_clientes_ClienteId]
GO
ALTER TABLE [dbo].[encuestasUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_encuestasUsuarios_encuestas_EncuestaId] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[encuestas] ([EncuestaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestasUsuarios] CHECK CONSTRAINT [FK_encuestasUsuarios_encuestas_EncuestaId]
GO
ALTER TABLE [dbo].[encuestasUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_encuestasUsuarios_usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestasUsuarios] CHECK CONSTRAINT [FK_encuestasUsuarios_usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[opciones]  WITH CHECK ADD  CONSTRAINT [FK_opciones_preguntas_PreguntaId] FOREIGN KEY([PreguntaId])
REFERENCES [dbo].[preguntas] ([PreguntaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[opciones] CHECK CONSTRAINT [FK_opciones_preguntas_PreguntaId]
GO
ALTER TABLE [dbo].[preguntas]  WITH CHECK ADD  CONSTRAINT [FK_preguntas_encuestas_EncuestaId] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[encuestas] ([EncuestaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[preguntas] CHECK CONSTRAINT [FK_preguntas_encuestas_EncuestaId]
GO
USE [master]
GO
ALTER DATABASE [EncuestadoraDB_v3] SET  READ_WRITE 
GO
