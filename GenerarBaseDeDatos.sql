USE [master]
GO
/****** Object:  Database [ChessDB]    Script Date: 27/8/2021 7:26:18 p. m. ******/
CREATE DATABASE [ChessDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChessDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChessDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChessDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChessDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ChessDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChessDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChessDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChessDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChessDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChessDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChessDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChessDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ChessDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChessDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChessDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChessDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChessDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChessDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChessDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChessDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChessDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ChessDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChessDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChessDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChessDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChessDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChessDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChessDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChessDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChessDB] SET  MULTI_USER 
GO
ALTER DATABASE [ChessDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChessDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChessDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChessDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChessDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChessDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ChessDB] SET QUERY_STORE = OFF
GO
USE [ChessDB]
GO
/****** Object:  User [EUDY]    Script Date: 27/8/2021 7:26:19 p. m. ******/
CREATE USER [EUDY] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](40) NULL,
	[direccion] [nvarchar](70) NULL,
	[Idsexo] [int] NULL,
	[IdPuesto] [int] NULL,
	[Departamento] [nvarchar](60) NULL,
	[Apellido] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntradaDeLeche]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaDeLeche](
	[IdEntrada] [int] IDENTITY(1,1) NOT NULL,
	[IdSuplidor] [int] NULL,
	[IdRecolector] [int] NULL,
	[CantidadBotellas] [decimal](10, 2) NULL,
	[PrecioPorBotella] [decimal](10, 2) NOT NULL,
	[IdEstado] [int] NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoDeLeche]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoDeLeche](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[FechaOrden] [date] NULL,
	[SubTotal] [decimal](10, 4) NULL,
	[Descuento] [decimal](10, 5) NULL,
	[TotalAlpago] [decimal](10, 5) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenesElemetos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenesElemetos](
	[OredenElemetoId] [int] IDENTITY(1,1) NOT NULL,
	[ProductoId] [int] NOT NULL,
	[OrdenId] [int] NULL,
	[Cantidad] [int] NULL,
	[Codigo]  AS ('FAC'+right(CONVERT([varchar],[OredenElemetoId]),(2))),
PRIMARY KEY CLUSTERED 
(
	[OredenElemetoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[ProductoNombre] [nvarchar](70) NULL,
	[Descripcion] [nvarchar](75) NULL,
	[Precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[IdPuestos] [int] IDENTITY(1,1) NOT NULL,
	[nombrePuesto] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPuestos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[Idsexo] [int] IDENTITY(1,1) NOT NULL,
	[sexDescripcion] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Idsexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suplidor]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suplidor](
	[IdSuplidor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](40) NULL,
	[Direccion] [nvarchar](60) NULL,
	[NumeroTel] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSuplidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [varchar](80) NOT NULL,
	[PASSWORD] [varchar](80) NOT NULL,
	[RoleId] [int] NULL,
	[FirstName] [varchar](80) NOT NULL,
	[LastName] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([IdPuesto])
REFERENCES [dbo].[Puestos] ([IdPuestos])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Idsexo])
REFERENCES [dbo].[Sexo] ([Idsexo])
GO
ALTER TABLE [dbo].[EntradaDeLeche]  WITH CHECK ADD FOREIGN KEY([IdEstado])
REFERENCES [dbo].[EstadoDeLeche] ([IdEstado])
GO
ALTER TABLE [dbo].[EntradaDeLeche]  WITH CHECK ADD FOREIGN KEY([IdRecolector])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[EntradaDeLeche]  WITH CHECK ADD FOREIGN KEY([IdSuplidor])
REFERENCES [dbo].[suplidor] ([IdSuplidor])
GO
ALTER TABLE [dbo].[OrdenesElemetos]  WITH CHECK ADD FOREIGN KEY([OrdenId])
REFERENCES [dbo].[Ordenes] ([IdOrden])
GO
ALTER TABLE [dbo].[OrdenesElemetos]  WITH CHECK ADD FOREIGN KEY([OrdenId])
REFERENCES [dbo].[Ordenes] ([IdOrden])
GO
ALTER TABLE [dbo].[OrdenesElemetos]  WITH CHECK ADD FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[OrdenesElemetos]  WITH CHECK ADD FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
/****** Object:  StoredProcedure [dbo].[ActualizarSuplidor]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarSuplidor]
    @IdSuplidor INT,
    @Nombre VARCHAR(50),
    @Apellidos VARCHAR(40),
    @Direccion VARCHAR(50),
    @NumeroTel VARCHAR(19)
AS
BEGIN
    UPDATE dbo.suplidor SET Nombre = @Nombre, Apellidos = @Apellidos, Direccion = @Direccion, NumeroTel = @NumeroTel 
WHERE IdSuplidor = @IdSuplidor
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarSuplidor]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarSuplidor]
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(60),
    @Direccion VARCHAR(50),
    @NumeroTel VARCHAR(50)
AS
BEGIN
    -- body of the stored procedure
    INSERT INTO  dbo.suplidor VALUES(@Nombre, @Apellido, @Direccion, @NumeroTel)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertEmpleado]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[InsertEmpleado]
    @Nombre VARCHAR(50),
	@Apellido varchar(50),
    @Direccion VARCHAR(60),
    @Sexo INT,
    @Puesto INT,
    @Departmento VARCHAR(50)
AS
BEGIN
    -- body of the stored procedure
    INSERT INTO  Empleados VALUES(@Nombre, @Direccion, @Sexo, @Puesto, @Departmento, @Apellido)
END
GO
/****** Object:  StoredProcedure [dbo].[ListaEstadosDeLeche]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListaEstadosDeLeche]
AS
BEGIN
select * FROM dbo.EstadoDeLeche
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarEmpleados]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarEmpleados]
    @IdEmpleado INT,
    @Nombre VARCHAR(50),
	@Apellido varchar(50),
    @Direccion VARCHAR(60),
    @Sexo INT,
    @Puesto INT,
    @Departmento VARCHAR(50)
AS
BEGIN
UPDATE dbo.Empleados SET nombre = @Nombre, Apellido = @Apellido, direccion = @Direccion, Idsexo = @Sexo,IdPuesto = @Puesto, Departamento = @Departmento
WHERE IdEmpleado = @IdEmpleado
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarUsuario]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarUsuario]
    @IdUsuario INT,
    @NombreUsuario VARCHAR(80),
    @Contrasena VARCHAR(80),
    @RoleId INT,
    @Nombre VARCHAR(80),
    @Apellido VARCHAR(80)
AS
BEGIN
    UPDATE dbo.Usuarios SET 
    LoginName = @NombreUsuario, 
    [PASSWORD] = @Contrasena, 
    RoleId = @RoleId, 
    FirstName = @Nombre, 
    LastName = @Apellido

    WHERE  UserId = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarEntradasDeLechebySuplidor]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarEntradasDeLechebySuplidor]
@Suplidor VARCHAR(40)
AS
BEGIN
    SELECT 
    e.IdEntrada
    , CONCAT(s.Nombre,' ', s.Apellidos) as NombreSuplidor
    , CONCAT(empe.nombre,' ', empe.Apellido) AS NombreRecolector 
    , e.CantidadBotellas
    , e.PrecioPorBotella AS PrecioPorBotella
    , esta.Descripcion as EstadoDeLeche
    , e.Fecha
    FROM dbo.EntradaDeLeche e
       INNER JOIN suplidor s ON s.IdSuplidor = e.IdSuplidor
       INNER JOIN Empleados empe ON empe.IdEmpleado = e.IdRecolector
       INNER JOIN EstadoDeLeche esta ON esta.IdEstado = e.IdEstado

       WHERE s.Nombre LIKE @Suplidor + '%' OR s.Apellidos LIKE @Suplidor + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarSuplidoresByNombre]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarSuplidoresByNombre]
@Nombre VARCHAR(40)
AS
BEGIN
    SELECT 
    s.IdSuplidor
    , Nombre AS Nombre
    , s.Apellidos
    , s.Direccion
    , s.NumeroTel
    FROM dbo.suplidor s

    WHERE s.Nombre LIKE @Nombre + '%' OR s.Apellidos like @Nombre + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarVentas]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarVentas]
@Codigo VARCHAR(20)
AS
BEGIN
    SELECT
        oi11.OredenElemetoId
, O.FechaOrden
, Productos = STUFF((SELECT ' - '+ 'x'+CONVERT(varchar(10), oi2.Cantidad)+' '+ Productos.ProductoNombre
        FROM OrdenesElemetos oi2
            INNER JOIN Productos ON Productos.IdProducto = oi2.ProductoId
        where  oi11.OrdenId = oi2.OrdenId
        FOR XML PATH('')), 1, 2,'')
, O.SubTotal
, O.Descuento
, O.TotalAlpago
    FROM dbo.Ordenes O
        INNER JOIN dbo.OrdenesElemetos oi11 ON oi11.OrdenId = O.IdOrden
    WHERE oi11.OredenElemetoId LIKE @Codigo + '%'

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteProductById]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[SP_DeleteProductById]
    @IdProducto INT
AS
BEGIN
    -- body of the stored procedure
    DELETE dbo.Productos
    WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EditarEntrada]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarEntrada]
    @IdEntrada int,
    @IdSuplidor INT,
    @IdRcolector INT,
    @CantidadEnBotellas INT,
    @PrecioBotella decimal(10,3),
    @IdEstado INT,
    @Fecha DATE
AS
BEGIN
UPDATE dbo.EntradaDeLeche 
SET 
  IdSuplidor = @IdSuplidor
, IdRecolector = @IdRcolector
, CantidadBotellas = @CantidadEnBotellas
, PrecioPorBotella = @PrecioBotella
, IdEstado = @IdEstado
, Fecha = @Fecha 
WHERE IdEntrada = @IdEntrada
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarEmpleado]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarEmpleado]
    @IdEmpleado INT
AS
BEGIN
    delete dbo.Empleados
    WHERE IdEmpleado = @IdEmpleado
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarEntrada]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarEntrada]
@IdEntrada INT
AS
BEGIN
DELETE dbo.EntradaDeLeche
WHERE IdEntrada = @IdEntrada
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarSuplidor]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarSuplidor]
    @IdSuplidor INT
AS
BEGIN
    delete dbo.suplidor
WHERE IdSuplidor = @IdSuplidor
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarUsuario]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarUsuario]
    @IdUsuario INT 
AS
BEGIN
    delete dbo.Usuarios
    WHERE @IdUsuario = UserId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetALLEntradas]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_GetALLEntradas]
AS
BEGIN
    SELECT
        EntradaDeLeche.IdEntrada
, CONCAT(suplidor.Nombre,' ',suplidor.Apellidos) AS NombreSuplidor
, CONCAT(Empleados.nombre,' ',Empleados.Apellido) AS Recolector
, EntradaDeLeche.CantidadBotellas
, EntradaDeLeche.PrecioPorBotella
, EstadoDeLeche.Descripcion
, EntradaDeLeche.Fecha

    FROM dbo.EntradaDeLeche
        INNER JOIN dbo.suplidor on suplidor.IdSuplidor = EntradaDeLeche.IdSuplidor
        INNER JOIN dbo.Empleados on Empleados.IdEmpleado = EntradaDeLeche.IdRecolector
        INNER JOIN dbo.EstadoDeLeche on EstadoDeLeche.IdEstado = EntradaDeLeche.IdEstado

    ORDER BY EntradaDeLeche.Fecha ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEmpleadosByName]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetEmpleadosByName]
@Nombre VARCHAR(40)
AS
BEGIN
    SELECT 
    e.IdEmpleado
    , e.Nombre
    , e.Apellido
    , e.Direccion
    , s.sexDescripcion as Sexo
    , p.nombrePuesto AS Puesto 
    , e.Departamento
    FROM dbo.Empleados e
        INNER JOIN Sexo s ON s.Idsexo = e.Idsexo
        INNER JOIN Puestos p on p.IdPuestos = e.IdPuesto

        WHERE e.nombre LIKE @Nombre + '%' OR e.Apellido LIKE @Nombre + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEntradasByFecha]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetEntradasByFecha]
@Desde DATE,
@Hasta DATE
AS
BEGIN
    SELECT
        EntradaDeLeche.IdEntrada
, CONCAT(suplidor.Nombre,' ',suplidor.Apellidos) AS NombreSuplidor
, CONCAT(Empleados.nombre,' ',Empleados.Apellido) AS Recolector
, EntradaDeLeche.CantidadBotellas
, EntradaDeLeche.PrecioPorBotella
, EstadoDeLeche.Descripcion
, EntradaDeLeche.Fecha

    FROM dbo.EntradaDeLeche
        INNER JOIN dbo.suplidor on suplidor.IdSuplidor = EntradaDeLeche.IdSuplidor
        INNER JOIN dbo.Empleados on Empleados.IdEmpleado = EntradaDeLeche.IdRecolector
        INNER JOIN dbo.EstadoDeLeche on EstadoDeLeche.IdEstado = EntradaDeLeche.IdEstado

    WHERE EntradaDeLeche.Fecha BETWEEN @Desde and @Hasta
    ORDER BY EntradaDeLeche.Fecha ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetILastdOrden]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetILastdOrden]
@IdOrden INT OUTPUT
AS
BEGIN
  set @IdOrden = (SELECT MAX(IdOrden) AS Id FROM dbo.Ordenes)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetLastIdOrdenElementos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetLastIdOrdenElementos]
@IdOrdenElemento int OUTPUT
AS
BEGIN
    SET @IdOrdenElemento = (SELECT OredenElemetoId FROM dbo.OrdenesElemetos WHERE OredenElemetoId = (select MAX(OredenElemetoId) FROM OrdenesElemetos ))
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetProductoByName]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[SP_GetProductoByName]
@Buscar VARCHAR(30)
AS
BEGIN
    -- body of the stored procedure
    SELECT
        p.IdProducto AS IDProducto
    , p.ProductoNombre AS Nombre_Producto
    , p.Descripcion
    , Precio
    FROM dbo.Productos p
    WHERE p.ProductoNombre LIKE @Buscar + '%' OR p.ProductoNombre LIKE '%%' + @Buscar
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetVentasADetalle]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetVentasADetalle]
AS
BEGIN
    SELECT
        oi11.OredenElemetoId,
         O.FechaOrden
, Productos = STUFF((SELECT ' - '+ 'x'+CONVERT(varchar(10), oi2.Cantidad)+' '+ Productos.ProductoNombre
        FROM OrdenesElemetos oi2
            INNER JOIN Productos ON Productos.IdProducto = oi2.ProductoId
        where  oi11.OrdenId = oi2.OrdenId
        FOR XML PATH('')), 1, 2,'')
, O.SubTotal
, O.Descuento
, O.TotalAlpago
    FROM dbo.Ordenes O
        INNER JOIN dbo.OrdenesElemetos oi11 ON oi11.OrdenId = O.IdOrden
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarEntrada]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarEntrada]
    @IdSuplidor INT,
    @IdRecolector INT,
    @PrecioBotella decimal(10, 2),
    @Cantidad decimal(10,3),
    @IdEstado INT,
    @fecha DATE
AS
BEGIN

    INSERT into dbo.EntradaDeLeche VALUES 
    (
      @IdSuplidor
    , @IdRecolector
    , @Cantidad
    , @PrecioBotella
    , @IdEstado
    , @fecha)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertNewUsuario]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertNewUsuario]
    @NombreUsuario VARCHAR(80),
    @Contrasena VARCHAR(80),
    @RoleId INT,
    @Nombre VARCHAR(80),
    @Apellido VARCHAR(80)
AS
BEGIN
    insert into dbo.Usuarios values(@NombreUsuario, @Contrasena, @RoleId, @Nombre, @Apellido)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertOrdendate]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[SP_InsertOrdendate]
    @Fecha DATE,
    @SubTotal DECIMAL(10,4),
    @Descuento DECIMAL(10,5),
    @TotalAlpago DECIMAL(10,5)
AS
BEGIN
    INSERT INTO dbo.Ordenes
    VALUES
        (@Fecha, @SubTotal, @Descuento, @TotalAlpago)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertOrdenElemetos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertOrdenElemetos]
    @ProductoId INT,
    @IdOrden INT,
    @Cantidad INT
   
AS
BEGIN
    INSERT into dbo.OrdenesElemetos
    VALUES
        (@ProductoId,@IdOrden,  @Cantidad)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProductos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[SP_InsertProductos]
    @NombreProducto NVARCHAR(70),
    @Descripcion VARCHAR(75),
    @Precio MONEY
AS
BEGIN
    INSERT INTO dbo.Productos VALUES(@NombreProducto, @Descripcion, @Precio)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ListaEstados]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListaEstados]

AS
BEGIN
    -- body of the stored procedure
    SELECT * FROM dbo.EstadoDeLeche
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ListaPuestos]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListaPuestos]
AS
BEGIN
    -- body of the stored procedure
    SELECT * FROM dbo.Puestos
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUsuarioyCOntrasena]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ObtenerUsuarioyCOntrasena]
    @LoginName VARCHAR(80),
    @Password VARCHAR(80)
AS
BEGIN
    SELECT * FROM dbo.Usuarios usr
    WHERE usr.LoginName = @LoginName AND usr.[PASSWORD] = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarAllEntradas]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeleccionarAllEntradas]

AS
BEGIN
    SELECT 
    e.IdEntrada
    , CONCAT(s.Nombre,' ', s.Apellidos) as NombreSuplidor
    , CONCAT(empe.nombre,' ', empe.Apellido) AS NombreRecolector 
    , e.CantidadBotellas
    , e.PrecioPorBotella AS PrecioPorBotella
    , esta.Descripcion as EstadoDeLeche
    , e.Fecha
    FROM dbo.EntradaDeLeche e
       INNER JOIN suplidor s ON s.IdSuplidor = e.IdSuplidor
       INNER JOIN Empleados empe ON empe.IdEmpleado = e.IdRecolector
       INNER JOIN EstadoDeLeche esta ON esta.IdEstado = e.IdEstado
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarTodosLosEmpleados]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeleccionarTodosLosEmpleados]
AS
BEGIN
    SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.Direccion, s.sexDescripcion as Sexo, p.nombrePuesto AS Puesto , e.Departamento
    FROM dbo.Empleados e
        INNER JOIN Sexo s ON s.Idsexo = e.Idsexo
        INNER JOIN Puestos p on p.IdPuestos = e.IdPuesto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarTodosLosSuplidores]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeleccionarTodosLosSuplidores]
AS
BEGIN
    SELECT s.IdSuplidor, Nombre AS Nombre, s.Apellidos, s.Direccion, s.NumeroTel
    FROM dbo.suplidor s
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllProducts]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[SP_SelectAllProducts]
-- add more stored procedure parameters here
AS
BEGIN
    -- body of the stored procedure
    SELECT p.IdProducto AS IDProducto, p.ProductoNombre AS Nombre_Producto, p.Descripcion, Precio  FROM dbo.Productos p
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectALLUsers]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[SP_SelectALLUsers]
AS
BEGIN
    SELECT usr.UserId 
    , usr.LoginName AS NombreUsuario
    , usr.[PASSWORD] AS Contraseña
    , CONCAT(usr.FirstName, +' '+ usr.LastName) AS Nombres
    , r.RoleName AS RolDeAcceso 
    
    from dbo.Usuarios usr
    INNER JOIN Roles r on r.RoleId = usr.RoleId 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateProduct]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateProduct]
    @IdProducto INT,
    @NombrePorducto VARCHAR(70),
    @Descripcion VARCHAR(75),
    @Precio MONEY
AS
BEGIN
    UPDATE dbo.Productos SET ProductoNombre = @NombrePorducto, Descripcion = @Descripcion, Precio = @Precio
    WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ValoreMienbrosComoSuplidores]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ValoreMienbrosComoSuplidores]
as
SELECT IdSuplidor,  Nombre +' '+ Apellidos as Nombres from dbo.suplidor
GO
/****** Object:  StoredProcedure [dbo].[SP_ValoresComboRecolectoresEmpleados]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ValoresComboRecolectoresEmpleados]
AS
BEGIN
    SELECT em.IdEmpleado, em.nombre +' '+em.Apellido AS Nombre  FROM dbo.Empleados em
END
GO
/****** Object:  StoredProcedure [dbo].[ValuesComboRolesUsuario]    Script Date: 27/8/2021 7:26:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValuesComboRolesUsuario]
AS
BEGIN
    SELECT * from dbo.Roles
END
GO
USE [master]
GO
ALTER DATABASE [ChessDB] SET  READ_WRITE 
GO
