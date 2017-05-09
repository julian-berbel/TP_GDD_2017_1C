USE GD1C2017;
GO

/* Eliminacion de preexistentes*/

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Item_Factura','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Factura','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Viaje','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Vehiculo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rendicion','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Turno','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Turno;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rol_X_Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Contacto','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Cliente','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Cliente;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Funcionalidad','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rol','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rol;
	
IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'LOS_MODERADAMENTE_ADECUADOS')
    DROP SCHEMA LOS_MODERADAMENTE_ADECUADOS
GO

/* Creación del esquema */

CREATE SCHEMA LOS_MODERADAMENTE_ADECUADOS AUTHORIZATION gd;
GO


/* Creación de las tablas */

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol(
    rol_id TINYINT IDENTITY PRIMARY KEY,
    rol_nombre NVARCHAR(200),
	rol_detalle NVARCHAR(200),
    rol_habilitado BIT);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(
    func_id TINYINT IDENTITY PRIMARY KEY,
    func_descripcion NVARCHAR(200));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol(
	cod_func TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(func_id),
    cod_rol TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
    PRIMARY KEY (cod_func, cod_rol));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario(
    usua_id INT IDENTITY PRIMARY KEY,
    usua_user NVARCHAR(200) UNIQUE,
    usua_pass VARBINARY(200),
	usua_habilitado BIT,
    usua_intentos TINYINT);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Cliente(
    clie_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    clie_dni NVARCHAR(200),
    clie_nombre NVARCHAR(200),
	clie_apellido NVARCHAR(200),
	clie_fecha_nacimiento DATETIME);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto(
    cont_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id),
	cont_mail NVARCHAR(200),
	cont_telefono NVARCHAR(200),
	cont_domicilio NVARCHAR(200),
	cont_codigo_postal NVARCHAR(20));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Usuario(
    cod_rol TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
    cod_usua INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    PRIMARY KEY (cod_rol, cod_usua));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Turno(
    turn_id TINYINT IDENTITY PRIMARY KEY,
	turn_hora_inicio Time(0),
	turn_hora_fin Time(0),
	turn_descripcion NVARCHAR(200),
	turn_valor_kilometro NUMERIC(10,2),
	turn_precio_base NUMERIC(10,2),
	turn_habilitado BIT);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion(
    rend_id INT IDENTITY PRIMARY KEY,
    rend_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	rend_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	rend_fecha DATETIME,
	rend_importe_total NUMERIC(10,2));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo(
    vehi_id INT IDENTITY PRIMARY KEY,
    vehi_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	vehi_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	vehi_patente NVARCHAR(7),
	vehi_marca NVARCHAR(50),
	vehi_modelo NVARCHAR(50),
	vehi_habilitado BIT);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje(
    viaj_id INT PRIMARY KEY,
    viaj_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    viaj_vehiculo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
	viaj_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	viaj_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	viaj_kms NUMERIC(10,2),
    viaj_inicio DATETIME,
    viaj_fin DATETIME);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Factura(
    fact_id INT PRIMARY KEY,
    fact_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    fact_fecha_inicio DATETIME,
    fact_fecha_fin DATETIME,
    fact_importe_total NUMERIC(10,2));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura(
    item_id INT IDENTITY PRIMARY KEY,
    item_factura INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Factura(fact_id),
    item_viaje INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Viaje(viaj_id));
	
/* Migración */

--Rol

INSERT [LOS_MODERADAMENTE_ADECUADOS].Rol (rol_nombre, rol_detalle, rol_habilitado)
VALUES	('Cliente', 'Rol de cliente', 1), 
		('Chofer', 'Rol de chofer', 1), 
		('Administrador', 'Rol de administrador', 1)

--Funcionalidad

INSERT [LOS_MODERADAMENTE_ADECUADOS].Funcionalidad (func_descripcion)
VALUES	('ABM de Rol'),
		('Registro de Usuario'),
		('ABM de Clientes'),
		('ABM de Automovil'),
		('ABM de Turno'),
		('ABM de Chofer'),
		('Registro de Viaje'),
		('Facturacion de Clientes'),
		('Listado Estadistico')

--Funcionalidad_X_Rol

INSERT [LOS_MODERADAMENTE_ADECUADOS].Funcionalidad_X_Rol (cod_func, cod_rol)
VALUES (1, 3), (2, 3), (3, 3), (4, 3), (5, 3), (6, 3), (7, 3), (8, 3), (9, 3)

--Usuario

INSERT [LOS_MODERADAMENTE_ADECUADOS].Usuario (usua_user, usua_pass, usua_habilitado, usua_intentos)
VALUES ('admin', HASHBYTES('SHA256', 'w23e'), 1, 0)

/*INSERT [LOS_MODERADAMENTE_ADECUADOS].Usuario (usua_user, usua_pass, usua_habilitado, usua_intentos)
select [Chofer_Nombre], [Chofer_Apellido], 1, 0
from [gd_esquema].Maestra*/

--Cliente

--Contacto

--Rol_X_Usuario

--Turno

--Rendicion

--Vehiculo

/*INSERT [LOS_MODERADAMENTE_ADECUADOS].Vehiculo (vehi_patente, vehi_marca, vehi_modelo, vehi_chofer) 
select distinct [Auto_Patente],[Auto_Marca],[Auto_Modelo], (select top 1 usua_id from LOS_MODERADAMENTE_ADECUADOS.Usuario where usua_dni = Chofer_Dni)
from [gd_esquema].Maestra*/

--Viaje

--Factura

--Item_Factura
