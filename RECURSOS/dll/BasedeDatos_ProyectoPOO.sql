Use master 


create database Proyecto_MAG
go

use Proyecto_MAG
go

create table Usuarios (
IdUsuario int primary key,
Nombre varchar(30) not null,
Apellido varchar(30) not null,
Contraseña varchar(30) null,
usuario varchar(30) null,
DUI varchar(10) not null,
TipoUsuario varchar(1) not null,    
 )

Create table Direcciones(
IdDireccion int primary key,
Departamento varchar(40) not null,
Municipio varchar(40) not null,
Canton varchar(40)
)    
create table Productores(
IdProductor int primary key not null,
Nombre varchar(35) not null,
Apellido varchar(35) not null,
DUI varchar(10) not null,    
)

create table DetalleDirProd(
IdDirProd int identity primary key,
IdProductor int foreign key references Productores (IdProductor)
on update cascade
on delete cascade,
IdDireccion int  foreign key references Direcciones(IdDireccion)
on update cascade
on delete cascade,
)

create table Categorias(
IdCategoria int primary key,
Clasificacion varchar(30) not null      
)

create table Productos(
IdProducto int primary key,
Nombre varchar(40) not null,    
)

Create Table ProductosCategorias(
IdProdCat int identity primary key,
IdCategoria int not null foreign key references Categorias (IdCategoria)
on update cascade
on delete cascade,
IdProducto int not null foreign key references Productos(IdProducto)
on update cascade
on delete cascade
)

create table Precios(
IdPrecio char(7) primary key not null,
IdProducto int not null foreign key references Productos(IdProducto)
on update cascade
on delete cascade,
Unidad varchar(10) not null,
Precio float not null,
Cantidad float not null
)





create table Ventas (
IdVenta int primary key not null,
Fecha varchar(30) not null, 
FechaCosecha int not null, 
IdPrecio char(7) not null foreign key references Precios(IdPrecio)
on update cascade
on delete cascade,
LugarVenta varchar(25) not null,
Canal varchar(30) null )

create table DetalleVentas (
IdDetalle_Venta int identity primary key,
IdProductor int  foreign key references Productores(IdProductor)
on update cascade
on delete cascade,
IDVenta int foreign key references Ventas(IdVenta)
on update cascade
on delete cascade    
)

create table ProduccionesUbicaciones (
IdProduccion char(7) primary key not null,    
Departamento varchar(30) not null,
Municipio varchar(30) not null,   
Canton varchar(30) not null
  )

create table DetalleExplotacion (
IdProductor int not null foreign key references Productores(IdProductor)
on update cascade
on delete cascade,
IdProduccion char(7) null foreign key references ProduccionesUbicaciones(IdProduccion)
on update cascade
on delete cascade,
DepartamentoExplotacion varchar(20) null,
MunicipioExplotacion varchar(20) null

)
--bit es un booleano 

create table Cultivos (
IdCultivo char(5) primary key not null,
NombreCultivo varchar(30) not null,
PlantillaCosecha float not null,
ProduccionCosecha float not null,
NumeroCosecha int not null,
Produccion float not null,
Rendimiento float not null,
Latitud float not null,
Longitud float not null,
)


create table DetalleCultivosProductores(
IdDetalleCultProd int identity primary key,
IdProductor int not null foreign key references Productores(IdProductor)
on update cascade
on delete cascade,
IdCultivo char(5) not null foreign key references Cultivos(IdCultivo)
on update cascade
on delete cascade
)

create table Brigadas (
IdBrigada int primary key not null,
JefeBrigada varchar(30) not null,
IdUsuario int foreign key references Usuarios(IdUsuario)
on update cascade
on delete cascade
)

create table Detalle_Brigadas(

IdBrigada int foreign key references Brigadas(IdBrigada)
on update cascade
on delete cascade,

)

create table ReporteEPPA(
IdReporte int primary key not null,
IdUsuario int foreign key references Usuarios(IdUsuario)
on update cascade
on delete cascade,
IdProductor int not null foreign key references Productores(IdProductor)
on update cascade
on delete cascade,
Observacion varchar(250) not null
)

--Cosecha,  Ventas, Usuarios, Precios, Productos, Categorias,Productores, Direcciones 5 Registros



SELECT * from usuarios 

CREATE LOGIN programador with PASSWORD = 'Progra123456'

CREATE USER programador for login programador 

use Proyecto_MAG 
Go 
GRANT ALL ON DATABASE:: Proyecto_MAG
To programador
WIth GRANT OPTION


GRANT SELECT,INSERT,UPDATE, DELETE, EXECUTE ON DATABASE :: Proyecto_MAG
To programador 
WITH GRANT OPTION 
GO

--INSERT USUARIOS
INSERT INTO Usuarios values ('1','Alfredo','Mena','12345','fredo','12345678-9','E')
INSERT INTO Usuarios values ('2','Oswaldo', 'Alberto','12345','oswaldo','12677889-2','E')
INSERT INTO Usuarios values ('3','Kevin', 'Arnold','12345','kevin','12658904-4','E')
INSERT INTO Usuarios values ('4','Kevin','Pleitez','123456','kelvis','14352562-3','A');

--CREACION DE PROCEDIMIENTO PARA CONSULTAS

CREATE PROCEDURE MostrarUsuarios
AS
SET NOCOUNT ON;
Select IdUsuario, Nombre+' '+Apellido as Nombre, usuario as Usuario, DUI, CASE WHEN TipoUsuario = 'A' then'Administrador' ELSE 'Encuestador'END  as Rol FROM Usuarios

CREATE PROCEDURE UsuariosIngresados
@identidad int,
@usuario varchar(30)
AS
SELECT * FROM Usuarios where IdUsuario= @identidad  OR usuario = @usuario 

CREATE PROCEDURE EliminarUsuario
@identidad int
AS
DELETE FROM Usuarios where IdUsuario = @identidad 

CREATE PROCEDURE ModificarUsuario
@Identificacion int,
@Nom varchar(30),
@Ape varchar(30),
@Cont varchar(30),
@Usua varchar(30),
@dui varchar(10),
@tipo varchar(1)
AS
UPDATE Usuarios 
SET Nombre  = @Nom, Apellido = @Ape, Contraseña = @Cont , usuario = @Usua , DUI = @dui , TipoUsuario= @tipo 
WHERE IdUsuario  = @Identificacion

