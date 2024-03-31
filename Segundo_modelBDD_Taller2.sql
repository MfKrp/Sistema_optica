USE MASTER;
GO

DROP DATABASE OpticaMaribel;
GO

CREATE DATABASE OpticaMaribel;

USE OpticaMaribel;

CREATE TABLE Marca
(
  IdMarca INT IDENTITY(1,1) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  CONSTRAINT PK_IdMarca_Marca PRIMARY KEY (IdMarca)
);

GO

CREATE TABLE Estilo
(
  IdEstilo INT IDENTITY(1,1) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  CONSTRAINT PK_IdEstilo_Estilo PRIMARY KEY (IdEstilo)
);

GO

CREATE TABLE Forma
(
  IdForma INT IDENTITY(1,1) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  CONSTRAINT PK_IdForma_Forma PRIMARY KEY (IdForma)
);

GO

CREATE TABLE Cristal
(
  IdCristal INT IDENTITY(1,1) NOT NULL,
  Material VARCHAR(100) NOT NULL,
  Stock INT NOT NULL,
  CONSTRAINT PK_IdCristal_Cristal PRIMARY KEY (IdCristal)
);

GO

CREATE TABLE Forma_pago
(
  IdFormaPago INT IDENTITY(1,1) NOT NULL,
  Descripcion VARCHAR(100) NOT NULL,
  Interes FLOAT NOT NULL,
  CONSTRAINT PK_IdFormaPagp_FormaPago PRIMARY KEY (IdFormaPago)
);

GO

CREATE TABLE PerfilEmpleado
(
	IdPerfilEmpleado INT IDENTITY(1,1) NOT NULL,
	Descripcion VARCHAR(100) NOT NULL
	CONSTRAINT PK_PerfilEmpleado_IdPerfilEmpleado PRIMARY KEY (IdPerfilEmpleado),
);

GO

CREATE TABLE Empleado
(
  IdEmpleado INT NOT NULL, --El empleado no tiene autoincremento
  NombreEmp VARCHAR(100) NOT NULL,
  ApellidoEmp VARCHAR(100) NOT NULL,
  TelefonoEmp VARCHAR(100) NOT NULL,
  EmailEmp VARCHAR(100) NOT NULL,
  FechaNacimientoEmp DATE NOT NULL,
  DniEmp VARCHAR(100) NOT NULL,
  DireccionEmp VARCHAR(100) NOT NULL,
  EstadoEmp BIT NOT NULL,
  Contrasena VARCHAR(100) NOT NULL,
  IdPerfilEmpleado INT NOT NULL,
  CONSTRAINT PK_IdEmpleado_Empleado PRIMARY KEY (IdEmpleado),
  CONSTRAINT FK_Empleado_PerfilEmpleado_IdPerfilEmpleado FOREIGN KEY (IdPerfilEmpleado) REFERENCES PerfilEmpleado(IdPerfilEmpleado)
);

GO

CREATE TABLE Obra_social
(
  IdObraSocial INT IDENTITY(1,1) NOT NULL,
  NombreObraSocial VARCHAR(100) NOT NULL,
  EstadoObraSocial bit NOT NULL,
  CoberturaMarco FLOAT NOT NULL,
  CoberturaCristal FLOAT NOT NULL,
  CONSTRAINT PK_IdObraSocial_ObraSocial PRIMARY KEY (IdObraSocial)
);

GO

CREATE TABLE Anteojo
(
  IdAnteojo INT IDENTITY(1,1) NOT NULL, --el produco tiene autoincremento
  IdTipoAnteojo INT NOT NULL,
  Genero INT NOT NULL,
  Color INT NOT NULL,
  GraduacionIzq INT,
  GraduacionDer INT,
  PrecioUnitario FLOAT NOT NULL,
  EstadoAnteojo BIT NOT NULL,
  StockAnteojo INT NOT NULL,
  IdForm INT NOT NULL,
  IdMarca INT NOT NULL,
  IdEstilo INT NOT NULL,
  IdCristal INT,
  CONSTRAINT PK_IdAnteojo_Anteojo PRIMARY KEY (IdAnteojo),
  CONSTRAINT FK_Anteojo_Forma_IdForma FOREIGN KEY (IdForm) REFERENCES Forma(IdForma),
  CONSTRAINT FK_Anteojo_Marca_IdMarca FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca),
  CONSTRAINT FK_Anteojo_Estilo_IdEstilo FOREIGN KEY (IdEstilo) REFERENCES Estilo(IdEstilo),
  CONSTRAINT FK_Anteojo_Cristal_IdCristal FOREIGN KEY (IdCristal) REFERENCES Cristal(IdCristal)
);

GO

CREATE TABLE Cliente
(
  IdCliente INT IDENTITY(1,1) NOT NULL, --Este campo es el de ID de cliente y tiene autoincremento
  DniCliente VARCHAR(100) NOT NULL,
  NombreCliente VARCHAR(100) NOT NULL,
  ApellidoCliente VARCHAR(100) NOT NULL,
  TelefonoCliente VARCHAR(100) NOT NULL,
  DireccionCliente VARCHAR(100) NOT NULL,
  EmailCliente VARCHAR(100) NOT NULL,
  EstadoCliente BIT NOT NULL,
  NroTarjetaCliente VARCHAR(100) NOT NULL,
  IdObraSocial INT NOT NULL,
  CONSTRAINT PK_Cliente_IdCliente PRIMARY KEY (IdCliente),
  CONSTRAINT FK_Cliente_Obra_social_IdObraSocial FOREIGN KEY (IdObraSocial) REFERENCES Obra_social(IdObraSocial)
);

GO

CREATE TABLE Cabecera
(
  IdCabecera INT IDENTITY(1,1) NOT NULL,
  Fecha_factura DATE NOT NULL,
  Estado_factura BIT NOT NULL,
  IdFormaPago INT NOT NULL,
  IdEmpleado INT NOT NULL,
  IdCliente INT NOT NULL,
  CONSTRAINT PK_Cabecera_IdCabecera PRIMARY KEY (IdCabecera),
  CONSTRAINT FK_Cabecera_Forma_pago_IdFormaPago FOREIGN KEY (IdFormaPago) REFERENCES Forma_pago(IdFormaPago),
  CONSTRAINT FK_Cabecera_Empleado_IdEmpleado FOREIGN KEY (IdEmpleado) REFERENCES Empleado(IdEmpleado),
  CONSTRAINT FK_Cabecera_Cliente_IdCliente FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente)
);

GO

CREATE TABLE Detalle
(
  IdDetalle INT IDENTITY(1,1) NOT NULL,
  Precio_total FLOAT NOT NULL,
  Cantidad INT NOT NULL,
  FechaEntrega DATE,
  IdCabecera INT NOT NULL,
  IdAnteojo INT NOT NULL,
  CONSTRAINT PK_Detalle_IdDetalle PRIMARY KEY (IdDetalle),
  CONSTRAINT FK_Detalle_Cabecera_IdCabecera FOREIGN KEY (IdCabecera) REFERENCES Cabecera(IdCabecera),
  CONSTRAINT FK_Detalle_anteojo_IdAnteojo FOREIGN KEY (IdAnteojo) REFERENCES Anteojo(IdAnteojo)
);

GO

USE OpticaMaribel;

DROP TABLE Detalle;

DROP TABLE Anteojo;

DROP TABLE Cabecera;

DROP TABLE Cliente;

DROP TABLE Empleado;

DROP TABLE Cristal;

DROP TABLE Estilo;

DROP TABLE Forma;

DROP TABLE Forma_pago;

DROP TABLE Marca;

DROP TABLE Obra_social;

DROP TABLE PerfilEmpleado;

INSERT INTO PerfilEmpleado (Descripcion)
VALUES ('Secretaria'), ('SuperAdmin'), ('Secretaria');

INSERT INTO Empleado (IdEmpleado, NombreEmp, ApellidoEmp, TelefonoEmp, EmailEmp, FechaNacimientoEmp, DniEmp, DireccionEmp, EstadoEmp, Contrasena, IdPerfilEmpleado)
VALUES (5412, 'Juan', 'Rodriguez', '3794544312', 'Juan@gmail.com', '06/04/2002', '43822531', 'Chiclana 432', 1, 'Juan123', 1),
(6542, 'Pedro', 'Albornoz', '3794658732', 'Pedro@gmail.com', '03/11/1993', '37431333', 'Santa Fe 123', 1, 'Pedro123', 2),
(8462, 'Roberto', 'Diaz', '3794971254', 'Roberto@gmail.com', '12/03/1987', '30431864', 'Brasil 765', 1, 'Roberto123', 3);

SELECT * FROM PerfilEmpleado;

DELETE FROM PerfilEmpleado;

USE OpticaMaribel;

ALTER TABLE Anteojo
DROP COLUMN IdTipoAnteojo;

ALTER TABLE Anteojo
ADD DescTipoAnteojo VARCHAR(100) NOT NULL;

DELETE PerfilEmpleado WHERE IdPerfilEmpleado >= 4;

DELETE FROM Empleado;

SELECT * FROM Empleado;