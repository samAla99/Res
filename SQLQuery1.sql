
create database DBRestaurante
Go

USE DBRestaurante
Go

CREATE TABLE CATEGORIA(
IdCategoria int primary Key identity,
Descripcion varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
go



CREATE TABLE TIPO(
IdTipo int primary Key identity,
Descripcion varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
go

CREATE TABLE PRODUCTO(
IdProducto int primary Key identity,
Nombre varchar (500),
Descripcion varchar(500),
IdTipo int references Tipo(IdTipo),
IdCategoria int references Categoria(IdCategoria),
Precio decimal(10,2) default 0,
Stock int,
RutaImagen varchar(100),
NombreImagen varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
go

CREATE TABLE CLIENTE(
IdCliente int primary Key identity,
Nombre varchar(100),
Apellido varchar(100),
Correo varchar(100),
Clave varchar(150),
Reestrablecer bit default 0,
FechaRegistro datetime default getdate()
)
go

 CREATE TABLE COMPRA(
IdCompra int primary Key identity,
IdCliente int references CLIENTE(IdCliente),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int
)
go
CREATE TABLE VENTA(
IdVenta int primary Key identity,
IdCliente int references CLIENTE(IdCliente),
TotalProducto int,
Montototal decimal(10,2),
Contacto varchar(100),
IdDistrito varchar(100),
Telefono varchar(100),
Direcion varchar(150),
IdTransferencia varchar(50),
FechaVenta datetime default getdate()
)
go

CREATE TABLE DETALLES_VENTA(
IdDetalleVenta int primary Key identity,
IdVenta int references Venta(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int,
total decimal(10,2)
)
go

CREATE TABLE USUARIO(
IdUsuario int primary Key identity,
Nombre varchar(100),
Apellido varchar(100),
Correo varchar(100),
Clave varchar(150),
Restablecer bit default 1,
Activo bit default 1,
FechaRegistro datetime default getdate()
)
go


