USE GD1C2017;
GO

/* Eliminacion de preexistentes*/

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Factura','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Viaje','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Vehiculo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rendicion','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Turno','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Turno;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Contacto','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Login_Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario;

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

CREATE SCHEMA LOS_MODERADAMENTE_ADECUADOS;
GO


/* Creación de las tablas */

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol(
    rol_id TINYINT IDENTITY PRIMARY KEY,
    rol_nombre NVARCHAR(200) NOT NULL,
	rol_detalle NVARCHAR(200),
    rol_habilitado BIT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(
    func_id TINYINT IDENTITY PRIMARY KEY,
    func_descripcion NVARCHAR(200));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol(
	cod_func TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(func_id),
    cod_rol TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
    PRIMARY KEY (cod_func, cod_rol));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(
    logi_id INT IDENTITY PRIMARY KEY,
    logi_user NVARCHAR(20) UNIQUE NOT NULL,
    logi_pass VARBINARY(200) NOT NULL,
	logi_habilitado BIT NOT NULL,
    logi_intentos TINYINT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario(
    usua_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id),
    usua_dni NUMERIC(18,0) UNIQUE NOT NULL,
    usua_nombre VARCHAR(255) NOT NULL,
	usua_apellido VARCHAR(255) NOT NULL,
	usua_fecha_nacimiento DATETIME NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto(
    cont_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	cont_mail NVARCHAR(255),
	cont_telefono NUMERIC(18,0) UNIQUE NOT NULL,
	cont_domicilio NVARCHAR(255) NOT NULL,
	cont_codigo_postal NUMERIC(18,0) NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario(
    cod_rol TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
    cod_login INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id),
    PRIMARY KEY (cod_rol, cod_login));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Turno(
    turn_id TINYINT IDENTITY PRIMARY KEY,
	turn_hora_inicio NUMERIC(18,0) NOT NULL,
	turn_hora_fin NUMERIC(18,0) NOT NULL,
	turn_descripcion NVARCHAR(255) NOT NULL,
	turn_valor_kilometro NUMERIC(10,2) NOT NULL,
	turn_precio_base NUMERIC(10,2) NOT NULL,
	turn_habilitado BIT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion(
	rend_numero INT PRIMARY KEY,
    rend_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	rend_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	rend_fecha DATETIME NOT NULL,
	rend_importe_total NUMERIC(10,2) NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo(
    vehi_id INT IDENTITY PRIMARY KEY,
    vehi_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	vehi_patente VARCHAR(10) UNIQUE NOT NULL,
	vehi_licencia VARCHAR(26), --PREGUNTAR
	vehi_rodado VARCHAR(10), --PREGUNTAR
	vehi_marca VARCHAR(255) NOT NULL,
	vehi_modelo VARCHAR(255) NOT NULL,
	vehi_habilitado BIT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje(
    viaj_id INT IDENTITY PRIMARY KEY,
    viaj_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    viaj_vehiculo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
	viaj_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	viaj_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	viaj_kms NUMERIC(18,0) NOT NULL CHECK (viaj_kms>0),
    viaj_inicio DATETIME NOT NULL,
    viaj_fin DATETIME NOT NULL);
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo(
	cod_turno TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
    cod_vehiculo INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
    PRIMARY KEY (cod_turno, cod_vehiculo));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Factura(
    fact_numero INT PRIMARY KEY,
    fact_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    fact_fecha_inicio DATETIME NOT NULL,
    fact_fecha_fin DATETIME NOT NULL,
    fact_importe_total NUMERIC(18,2) NOT NULL);
	
/* Migración */

--Rol

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol (rol_nombre, rol_detalle, rol_habilitado)
VALUES	('Administrador', 'Rol de administrador', 1),
		('Cliente', 'Rol de cliente', 1), 
		('Chofer', 'Rol de chofer', 1) 
		
--Funcionalidad

INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad (func_descripcion)
VALUES	('ABM de Rol'),
		('ABM de Cliente'),
		('ABM de Automovil'),
		('ABM de Turno'),
		('ABM de Chofer'),
		('Registro de Viaje'),
		('Facturacion de Clientes'),
		('Listado Estadistico')

--Funcionalidad_X_Rol

INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol (cod_func, cod_rol)
	VALUES (1, 3), (2, 3), (3, 3), (4, 3), (5, 3), (6, 3), (7, 3), (8, 3)

--Login_Usuario

INSERT LOS_MODERADAMENTE_ADECUADOS.Login_Usuario (logi_user, logi_pass, logi_habilitado, logi_intentos)
	VALUES ('admin', HASHBYTES('SHA2_256', 'w23e'), 1, 0)

INSERT LOS_MODERADAMENTE_ADECUADOS.Login_Usuario (logi_user, logi_pass, logi_habilitado, logi_intentos)
	SELECT DISTINCT CONVERT(varchar(20), Chofer_Dni), HASHBYTES('SHA2_256', CONVERT(varchar(20), Chofer_Dni)), 1, 0
	FROM gd_esquema.Maestra
	ORDER BY CONVERT(varchar(20), Chofer_Dni)

INSERT LOS_MODERADAMENTE_ADECUADOS.Login_Usuario (logi_user, logi_pass, logi_habilitado, logi_intentos)
	SELECT DISTINCT CONVERT(varchar(20), Cliente_Dni), HASHBYTES('SHA2_256', CONVERT(varchar(20), Cliente_Dni)), 1, 0
	FROM gd_esquema.Maestra
	ORDER BY CONVERT(varchar(20), Cliente_Dni)

--Usuario

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
	SELECT DISTINCT Chofer_Dni, Chofer_Nombre, Chofer_Apellido, Chofer_Fecha_Nac
	FROM gd_esquema.Maestra
	ORDER BY Chofer_Dni

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
	SELECT DISTINCT Cliente_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Fecha_Nac
	FROM gd_esquema.Maestra
	ORDER BY Cliente_Dni

--Contacto

INSERT LOS_MODERADAMENTE_ADECUADOS.Contacto (cont_mail, cont_telefono, cont_domicilio, cont_codigo_postal)
	SELECT a.Chofer_Mail, a.Chofer_Telefono, a.Chofer_Direccion, ROUND(10000*RAND(), 0)
	FROM (SELECT DISTINCT Chofer_Dni, Chofer_Mail, Chofer_Telefono, Chofer_Direccion
		  FROM gd_esquema.Maestra) a
	ORDER BY a.Chofer_Dni

INSERT LOS_MODERADAMENTE_ADECUADOS.Contacto (cont_mail, cont_telefono, cont_domicilio, cont_codigo_postal)
	SELECT a.Cliente_Mail, a.Cliente_Telefono, a.Cliente_Direccion, ROUND(10000*RAND(), 0)
	FROM (SELECT DISTINCT Cliente_Dni, Cliente_Mail, Cliente_Telefono, Cliente_Direccion
		  FROM gd_esquema.Maestra) a
	ORDER BY a.Cliente_Dni

--Rol_X_Login_Usuario

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
VALUES (1,1)

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
	SELECT 2,logi_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario lu
	JOIN (SELECT DISTINCT Cliente_Dni FROM gd_esquema.Maestra) m
	ON lu.logi_user=CONVERT(varchar(20), m.Cliente_Dni)

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
	SELECT 3,logi_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario lu
	JOIN (SELECT DISTINCT Chofer_Dni FROM gd_esquema.Maestra) m
	ON lu.logi_user=CONVERT(varchar(20), m.Chofer_Dni)
	
--Turno

INSERT LOS_MODERADAMENTE_ADECUADOS.Turno (turn_descripcion, turn_hora_inicio, turn_hora_fin, turn_valor_kilometro, turn_precio_base, turn_habilitado)
	SELECT DISTINCT Turno_Descripcion, Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Valor_Kilometro, Turno_Precio_Base, 1
	FROM gd_esquema.Maestra
	
--Rendicion

INSERT LOS_MODERADAMENTE_ADECUADOS.Rendicion (rend_numero, rend_turno, rend_chofer, rend_fecha, rend_importe_total)
	SELECT Rendicion_Nro, t.turn_id, c.usua_id, Rendicion_Fecha, sum(Rendicion_Importe) 
	FROM gd_esquema.Maestra m 
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario c ON m.Chofer_Dni = c.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Turno t ON m.Turno_Descripcion = t.turn_descripcion
	WHERE Rendicion_Nro IS NOT NULL
	GROUP BY Rendicion_Nro, t.turn_id, c.usua_id, Rendicion_Fecha

--Vehiculo

INSERT LOS_MODERADAMENTE_ADECUADOS.Vehiculo (vehi_chofer, vehi_patente, vehi_licencia, vehi_rodado, vehi_marca, vehi_modelo, vehi_habilitado) 
	SELECT DISTINCT c.usua_id, Auto_Patente, Auto_Licencia, Auto_Rodado, Auto_Marca, Auto_Modelo, 1
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario c ON m.Chofer_Dni = c.usua_dni
		
--Turno_X_Vehiculo

INSERT LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo (cod_turno, cod_vehiculo)
	SELECT DISTINCT turn_id, vehi_id
	FROM gd_esquema.Maestra 
		JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON Turno_Descripcion = turn_descripcion
		JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON Auto_Patente = vehi_patente

--Viaje

INSERT LOS_MODERADAMENTE_ADECUADOS.Viaje (viaj_chofer, viaj_vehiculo, viaj_cliente, viaj_turno, viaj_kms, viaj_inicio, viaj_fin)
	SELECT DISTINCT chofer.usua_id, v.vehi_id, cliente.usua_id, t.turn_id, Viaje_Cant_Kilometros, Viaje_Fecha, Viaje_Fecha
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario chofer ON m.Chofer_Dni = chofer.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON m.Cliente_Dni = cliente.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo v ON chofer.usua_id = v.vehi_chofer
		JOIN LOS_MODERADAMENTE_ADECUADOS.Turno t ON t.turn_descripcion = m.Turno_Descripcion

--Factura

INSERT LOS_MODERADAMENTE_ADECUADOS.Factura (fact_numero, fact_cliente, fact_fecha_inicio, fact_fecha_fin, fact_importe_total) 
	SELECT DISTINCT Factura_Nro, cliente.usua_id, Factura_Fecha_Inicio, Factura_Fecha_Fin, sum(Viaje_Cant_Kilometros*Turno_Valor_Kilometro+Turno_Precio_Base)
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON m.Cliente_Dni = cliente.usua_dni
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro, cliente.usua_id, Factura_Fecha_Inicio, Factura_Fecha_Fin
