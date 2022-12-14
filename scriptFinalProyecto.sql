USE [DB_PAV4]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[idCargo] [int] NOT NULL,
	[nombreCargo] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[idCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[nroDocumento] [int] NOT NULL,
	[tipoDocumento] [nvarchar](50) NOT NULL,
	[nombreCliente] [nvarchar](50) NULL,
	[apellidoCliente] [nvarchar](50) NULL,
	[edad] [int] NULL,
	[telefono] [nvarchar](50) NULL,
	[idObraSocial] [int] NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[nroDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Cobro]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Cobro](
	[idDetalleCobro] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[idFDP] [int] NULL,
	[cuotas] [int] NULL,
	[importe] [int] NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Detalles_Cobro] PRIMARY KEY CLUSTERED 
(
	[idDetalleCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesFactura]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesFactura](
	[idProducto] [int] NULL,
	[numeroFactura] [int] NULL,
	[nombreProducto] [nvarchar](50) NULL,
	[cantidad] [int] NULL,
	[importe] [nchar](10) NULL,
	[descripcionProducto] [nvarchar](50) NULL,
	[borrado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[nroFactura] [int] NOT NULL,
	[nroDocumento] [int] NOT NULL,
	[subtotal] [int] NULL,
	[total] [int] NOT NULL,
	[descuento] [float] NULL,
	[recargo] [float] NULL,
	[fechaEmision] [date] NULL,
	[borrado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formas_de_Pago]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formas_de_Pago](
	[idFDP] [int] IDENTITY(1,1) NOT NULL,
	[nombreFDP] [nvarchar](50) NOT NULL,
	[descripcionFDP] [nvarchar](50) NOT NULL,
	[descuentoFDP] [float] NULL,
	[recargoFDP] [float] NULL,
	[cuotasFDP] [int] NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Formas_de_Pago] PRIMARY KEY CLUSTERED 
(
	[idFDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obras_Sociales]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obras_Sociales](
	[idOS] [int] IDENTITY(1,1) NOT NULL,
	[nombreOS] [char](10) NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[borrado] [int] NULL,
	[CUIT] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[descuento] [int] NULL,
 CONSTRAINT [PK_Obras_Sociales] PRIMARY KEY CLUSTERED 
(
	[idOS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Obras_Sociales] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [nvarchar](50) NOT NULL,
	[tipoProducto] [nvarchar](50) NOT NULL,
	[precioProducto] [int] NOT NULL,
	[stockActual] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Productos] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[idTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[idTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[idTipoProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](20) NULL,
	[descripcionTipoProducto] [nvarchar](50) NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[idTipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/11/2022 19:25:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsu] [char](10) NOT NULL,
	[apellidoUsu] [char](10) NOT NULL,
	[claveUsu] [nvarchar](50) NOT NULL,
	[legajoUsu] [int] NULL,
	[emailUsu] [nvarchar](50) NOT NULL,
	[idCargoUsu] [int] NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuarios] SET (LOCK_ESCALATION = AUTO)
GO
INSERT [dbo].[Cargos] ([idCargo], [nombreCargo], [descripcion], [borrado]) VALUES (1, N'Administrador', N'Encargado de administrar el sistema', 0)
INSERT [dbo].[Cargos] ([idCargo], [nombreCargo], [descripcion], [borrado]) VALUES (2, N'Vendedor', N'Encargado de ventas', 0)
INSERT [dbo].[Cargos] ([idCargo], [nombreCargo], [descripcion], [borrado]) VALUES (3, N'Medico', N'Encargado de medicamentos', 0)
INSERT [dbo].[Cargos] ([idCargo], [nombreCargo], [descripcion], [borrado]) VALUES (4, N'Farmaceutico', N'Encargado de farmacia', 0)
GO
INSERT [dbo].[Clientes] ([nroDocumento], [tipoDocumento], [nombreCliente], [apellidoCliente], [edad], [telefono], [idObraSocial], [borrado]) VALUES (42926880, N'1', N'Agustin Santiago', N'Filippi', 21, N'3491506777', 5, 0)
INSERT [dbo].[Clientes] ([nroDocumento], [tipoDocumento], [nombreCliente], [apellidoCliente], [edad], [telefono], [idObraSocial], [borrado]) VALUES (432821820, N'1', N'Gaspar', N'Iglesias', 22, N'35254125', 3, 0)
INSERT [dbo].[Clientes] ([nroDocumento], [tipoDocumento], [nombreCliente], [apellidoCliente], [edad], [telefono], [idObraSocial], [borrado]) VALUES (439284820, N'1', N'Tiago', N'Rodriguez', 20, N'357252931', 6, 0)
GO
SET IDENTITY_INSERT [dbo].[Detalles_Cobro] ON 

INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (19, 1, 2, 3, 6303, 0)
INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (21, 2, 3, 1, 26136, 0)
INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (22, 3, 1, 1, 21580, 0)
INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (23, 4, 3, 1, 226, 0)
INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (24, 5, 2, 12, 7560, 0)
INSERT [dbo].[Detalles_Cobro] ([idDetalleCobro], [idFactura], [idFDP], [cuotas], [importe], [borrado]) VALUES (25, 6, 1, 1, 930, 0)
SET IDENTITY_INSERT [dbo].[Detalles_Cobro] OFF
GO
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (1, 1, N'Tafirol', 12, N'1200      ', N'Tafirol plus rapida accion', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (5, 1, N'Vick 44', 12, N'4800      ', N'Jarabe para la tos', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (2, 1, N'Actron', 1, N'120       ', N'Ibuptofeno 400mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (1, 2, N'Tafirol', 12, N'1200      ', N'Tafirol plus rapida accion', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (5, 2, N'Vick 44', 12, N'4800      ', N'Jarabe para la tos', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (2, 2, N'Actron', 1, N'120       ', N'Ibuptofeno 400mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (3, 2, N'Jeringa', 5, N'2500      ', N'Jeringa 10ml', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (5, 2, N'Vick 44', 30, N'12000     ', N'Jarabe para la tos', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (6, 2, N'Clonazepam', 20, N'14000     ', N'Clonazepam tabletas 2mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (1, 3, N'Tafirol', 10, N'1000      ', N'Tafirol plus rapida accion', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (3, 3, N'Jeringa', 50, N'25000     ', N'Jeringa 10ml', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (2, 4, N'Actron', 1, N'120       ', N'Ibuptofeno 400mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (1, 4, N'Tafirol', 1, N'100       ', N'Tafirol plus rapida accion', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (4, 5, N'Bisolvon', 12, N'6000      ', N'Bisolvon antitusivo 2mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (2, 5, N'Actron', 10, N'1200      ', N'Ibuptofeno 400mg', 0)
INSERT [dbo].[DetallesFactura] ([idProducto], [numeroFactura], [nombreProducto], [cantidad], [importe], [descripcionProducto], [borrado]) VALUES (1, 6, N'Tafirol', 10, N'1000      ', N'Tafirol plus rapida accion', 0)
GO
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (1, 432821820, 6120, 6303, 2, 5, CAST(N'2022-11-15' AS Date), 0)
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (3, 439284820, 26000, 21580, 17, 0, CAST(N'2022-11-15' AS Date), 0)
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (4, 432821820, 220, 226, -3, 0, CAST(N'2022-11-15' AS Date), 0)
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (5, 41112112, 7200, 7560, 10, 15, CAST(N'2022-11-15' AS Date), 0)
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (6, 432821820, 1000, 930, 7, 0, CAST(N'2022-11-15' AS Date), 0)
INSERT [dbo].[Facturas] ([nroFactura], [nroDocumento], [subtotal], [total], [descuento], [recargo], [fechaEmision], [borrado]) VALUES (2, 439284820, 29700, 26136, 12, 0, CAST(N'2022-11-15' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[Formas_de_Pago] ON 

INSERT [dbo].[Formas_de_Pago] ([idFDP], [nombreFDP], [descripcionFDP], [descuentoFDP], [recargoFDP], [cuotasFDP], [borrado]) VALUES (1, N'Efectivo', N'Se paga en 1 pago en efectivo', 0, 0, 0, 0)
INSERT [dbo].[Formas_de_Pago] ([idFDP], [nombreFDP], [descripcionFDP], [descuentoFDP], [recargoFDP], [cuotasFDP], [borrado]) VALUES (2, N'Tarjeta de credito', N'Se paga con tarjeta de credito', 0, 0, 12, 0)
INSERT [dbo].[Formas_de_Pago] ([idFDP], [nombreFDP], [descripcionFDP], [descuentoFDP], [recargoFDP], [cuotasFDP], [borrado]) VALUES (3, N'Debito', N'Se paga con tarjeta de debito', 0.1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Formas_de_Pago] OFF
GO
SET IDENTITY_INSERT [dbo].[Obras_Sociales] ON 

INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (1, N'OSPRERA   ', N'3516500952', 0, N'2042368521', N'os.personal.rural@gmail.com', 5)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (2, N'ANDAR     ', N'3519768458', 0, N'9234825782', N'os.viajantes.vendedores@gmail.com', 3)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (3, N'BANCARIOS ', N'3516376869', 0, N'4734588293', N'os.personal.bancario@gmail.com', 2)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (4, N'OSFE      ', N'3514745892', 0, N'4348538465', N'os.ferroviaria@gmial.com', 7)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (5, N'OSDE      ', N'3513458833', 0, N'3475488689', N'os.osde@gmail.com', 10)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (6, N'MEDIFE    ', N'3518496034', 0, N'7345892901', N'os.medife@gmail.con', 12)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (7, N'OSECAC    ', N'3543492830', 0, N'7435892923', N'os.personal.comercio@gmail.com', 4)
INSERT [dbo].[Obras_Sociales] ([idOS], [nombreOS], [Telefono], [borrado], [CUIT], [email], [descuento]) VALUES (8, N'ELEVAR    ', N'3542684773', 0, N'1111', N'os.panaderos@gmail.com', 8)
SET IDENTITY_INSERT [dbo].[Obras_Sociales] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (1, N'Tafirol', N'1', 100, 18, N'Tafirol plus rapida accion', 0)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (2, N'Actron', N'1', 120, 50, N'Ibuptofeno 400mg', 0)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (3, N'Jeringa', N'4', 500, 12, N'Jeringa 10ml', 0)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (4, N'Bisolvon', N'2', 500, 16, N'Bisolvon antitusivo 2mg', 0)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (5, N'Vick 44', N'2', 400, 4, N'Jarabe para la tos', 0)
INSERT [dbo].[Productos] ([idProducto], [nombreProducto], [tipoProducto], [precioProducto], [stockActual], [descripcion], [borrado]) VALUES (6, N'Clonazepam', N'1', 700, 40, N'Clonazepam tabletas 2mg', 0)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDocumento] ON 

INSERT [dbo].[TipoDocumento] ([idTipoDocumento], [nombre], [descripcion], [borrado]) VALUES (1, N'DNI', N'Documento de identificacion', 0)
INSERT [dbo].[TipoDocumento] ([idTipoDocumento], [nombre], [descripcion], [borrado]) VALUES (3, N'Librea Civica', N'Libreta Civica', 0)
INSERT [dbo].[TipoDocumento] ([idTipoDocumento], [nombre], [descripcion], [borrado]) VALUES (4, N'C.I', N'Cedula de identificacion', 0)
SET IDENTITY_INSERT [dbo].[TipoDocumento] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProducto] ON 

INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [descripcionTipoProducto], [borrado]) VALUES (1, N'Medicamento         ', N'Blister de pastillas', 0)
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [descripcionTipoProducto], [borrado]) VALUES (2, N'Jarabe              ', N'Jarabe ingerible', 0)
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [descripcionTipoProducto], [borrado]) VALUES (3, N'Crema               ', N'Crema', 0)
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [descripcionTipoProducto], [borrado]) VALUES (4, N'Inyectiable         ', N'Jeringas inyectables', 0)
INSERT [dbo].[TipoProducto] ([idTipoProducto], [nombre], [descripcionTipoProducto], [borrado]) VALUES (5, N'Producto general    ', N'Producto general de la farmacia', 0)
SET IDENTITY_INSERT [dbo].[TipoProducto] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [nombreUsu], [apellidoUsu], [claveUsu], [legajoUsu], [emailUsu], [idCargoUsu], [borrado]) VALUES (26, N'Admin     ', N'Sistema   ', N'123', 1, N'admin.sistema@gmail.com', 1, 0)
INSERT [dbo].[Usuarios] ([idUsuario], [nombreUsu], [apellidoUsu], [claveUsu], [legajoUsu], [emailUsu], [idCargoUsu], [borrado]) VALUES (27, N'Juan      ', N'Colazo    ', N'123', 84758, N'juan.colazo@gmail.com', 3, 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
