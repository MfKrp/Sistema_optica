CREATE DATABASE OpticaMaribel;

USE OpticaMaribel;

CREATE TABLE Estilo
(
  Id_estilo INT NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  CONSTRAINT PK_Estilo_Id_estilo PRIMARY KEY (Id_estilo)
);

GO

CREATE TABLE Marca
(
  Id_marca INT NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  CONSTRAINT PK_Marca_Id_marca PRIMARY KEY (Id_marca)
);

GO

CREATE TABLE Tipo_producto
(
  ID_Tipo INT NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  CONSTRAINT PK_Tipo_producto_Id_tipo PRIMARY KEY (ID_Tipo)
);

GO

CREATE TABLE Forma_pago
(
  Id_tipo_pago INT NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  CONSTRAINT PK_Forma_pago_Id_tipo_pago PRIMARY KEY (Id_tipo_pago)
);

GO

CREATE TABLE Tipo_perfil
(
  ID_perfil INT NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  CONSTRAINT PK_Tipo_perfil_ID_perfil PRIMARY KEY (ID_perfil)
);

GO

CREATE TABLE Cliente
(
  DNI INT NOT NULL,
  Nombre VARCHAR(200) NOT NULL,
  Apellido VARCHAR(200) NOT NULL,
  Telefono VARCHAR(100) NOT NULL,
  Direccion VARCHAR(200) NOT NULL,
  Email VARCHAR(200) NOT NULL,
  Estado_cliente BIT NOT NULL,
  CONSTRAINT PK_Cliente_DNI PRIMARY KEY (DNI),
);

GO

CREATE TABLE Producto
(
  Id_producto INT NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Precio_unitario FLOAT NOT NULL,
  Descripcion VARCHAR(200) NOT NULL,
  Genero CHAR NOT NULL,
  Color VARCHAR(50) NOT NULL,
  Estado VARCHAR NOT NULL,
  Stock INT NOT NULL,
  Estilo INT NOT NULL,
  Marca INT NOT NULL,
  Tipo INT NOT NULL,
  Estado_producto BIT NOT NULL,
  CONSTRAINT PK_Producto_Id_producto PRIMARY KEY (Id_producto),
  CONSTRAINT FK_Producto_Estilo_Id_estilo FOREIGN KEY (Estilo) REFERENCES Estilo(Id_estilo),
  CONSTRAINT FK_Producto_Marca_Id_marca FOREIGN KEY (Marca) REFERENCES Marca(Id_marca),
  CONSTRAINT FK_Producto_Tipo_Tipo_Id_tipo FOREIGN KEY (Tipo) REFERENCES Tipo_producto(ID_Tipo)
);

GO

CREATE TABLE UsuarioEmpleado
(
  ID_empleado INT NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  Telefono VARCHAR(100) NOT NULL,
  Email VARCHAR(200) NOT NULL,
  Fecha_nacimiento DATE NOT NULL,
  DNI INT NOT NULL,
  Direccion VARCHAR(200) NOT NULL,
  ID_perfil INT NOT NULL,
  Estado_empleado BIT NOT NULL,
  CONSTRAINT PK_UsuarioEmpleado_ID_empleado PRIMARY KEY (ID_empleado),
  CONSTRAINT FK_UsuarioEmpleado_Tipo_perfil_ID_perfil FOREIGN KEY (ID_perfil) REFERENCES Tipo_perfil(ID_perfil)
);

GO

CREATE TABLE Factura
(
  Nro_factura INT NOT NULL,
  Fecha_factura DATE NOT NULL,
  Vendedor INT NOT NULL,
  Cliente INT NOT NULL,
  Tipo_pago INT NOT NULL,
  CONSTRAINT PK_Factura_Nro_factura PRIMARY KEY (Nro_factura),
  CONSTRAINT FK_Factura_UsuarioEmpleado_ID_empleado FOREIGN KEY (Vendedor) REFERENCES UsuarioEmpleado(ID_empleado),
  CONSTRAINT FK_Factura_Cliente_DNI FOREIGN KEY (Cliente) REFERENCES Cliente(DNI),
  CONSTRAINT FK_Factura_Forma_pago_Id_tipo_pago FOREIGN KEY (Tipo_pago) REFERENCES Forma_pago(Id_tipo_pago)
);

GO

CREATE TABLE Detalle
(
  Id_detalle INT NOT NULL,
  Precio_total FLOAT NOT NULL,
  Cantidad INT NOT NULL,
  ID_producto INT NOT NULL,
  Nro_factura INT NOT NULL,
  CONSTRAINT PK_Detalle_Id_detalle PRIMARY KEY (Id_detalle),
  CONSTRAINT FK_Detalle_Producto_ID_producto FOREIGN KEY (ID_producto) REFERENCES Producto(Id_producto),
  CONSTRAINT FK_Detalle_Factura_Nro_factura FOREIGN KEY (Nro_factura) REFERENCES Factura(Nro_factura)
);

GO

INSERT INTO [dbo].[Tipo_perfil] (ID_perfil, Descripcion) VALUES (1, 'Secretaria'), (2, 'Superadmin'), (3, 'Vendedor');