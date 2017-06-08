USE GD1C2017;
GO

/* Eliminacion de preexistentes*/

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Item_Factura','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Factura','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Viaje','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Vehiculo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Modelo','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Modelo;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Marca','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Marca;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rendicion','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Turno','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Turno;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Contacto','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Cliente','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Cliente;
	
IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Chofer','U') IS NOT NULL
    DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Chofer;
	
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

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.SPLOGIN') IS NOT NULL
    DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.SPLOGIN;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_INHABILITAR') IS NOT NULL
    DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_INHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_REHABILITAR') IS NOT NULL
    DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_REHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_AGREGAR_FUNCIONALIDAD') IS NOT NULL
    DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_AGREGAR_FUNCIONALIDAD;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_QUITAR_FUNCIONALIDAD') IS NOT NULL
    DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_QUITAR_FUNCIONALIDAD;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_ID_USUARIO') IS NOT NULL
    DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_ID_USUARIO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_CANTIDAD_DE_ROLES') IS NOT NULL
    DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_CANTIDAD_DE_ROLES;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES') IS NOT NULL
    DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES;
	
	
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
	rol_detalle NVARCHAR(200) NOT NULL,
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
    logi_pass VARBINARY(256) NOT NULL,
	logi_habilitado BIT NOT NULL,
    logi_intentos TINYINT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario(
    usua_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id),
    usua_dni NUMERIC(18,0) UNIQUE NOT NULL,
    usua_nombre VARCHAR(255) NOT NULL,
	usua_apellido VARCHAR(255) NOT NULL,
	usua_fecha_nacimiento DATETIME NOT NULL);
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Cliente(
    clie_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    clie_codigo_postal NUMERIC(18,0) NOT NULL,
    clie_habilitado BIT NOT NULL);
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Chofer(
    chof_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
    chof_habilitado BIT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto(
    cont_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
	cont_mail NVARCHAR(255),
	cont_telefono NUMERIC(18,0) UNIQUE NOT NULL,
	cont_domicilio NVARCHAR(255) NOT NULL);

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
	rend_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
	rend_fecha DATETIME NOT NULL,
	rend_importe_total NUMERIC(10,2) NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Marca(
    marc_id TINYINT IDENTITY PRIMARY KEY,
    marc_nombre VARCHAR(255) NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Modelo(
    mode_id INT IDENTITY PRIMARY KEY,
    mode_codigo VARCHAR(255) NOT NULL,
	mode_marca TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Marca(marc_id));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo(
    vehi_id INT IDENTITY PRIMARY KEY,
    vehi_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
	vehi_patente VARCHAR(10) UNIQUE NOT NULL,
	vehi_licencia VARCHAR(26),
	vehi_rodado VARCHAR(10),
	vehi_modelo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Modelo(mode_id),
	vehi_habilitado BIT NOT NULL);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje(
    viaj_id INT IDENTITY PRIMARY KEY,
    viaj_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
    viaj_vehiculo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
	viaj_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id),
	viaj_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
	viaj_kms NUMERIC(18,0) NOT NULL CHECK (viaj_kms>0),
    viaj_inicio DATETIME NOT NULL,
    viaj_fin DATETIME NOT NULL);
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion(
    cod_rend INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rendicion(rend_numero),
    cod_viaje INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Viaje(viaj_id),
    PRIMARY KEY (cod_rend, cod_viaje));
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo(
	cod_turno TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
    cod_vehiculo INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
    PRIMARY KEY (cod_turno, cod_vehiculo));

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Factura(
    fact_numero INT PRIMARY KEY,
    fact_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id),
    fact_fecha_inicio DATETIME NOT NULL,
    fact_fecha_fin DATETIME NOT NULL,
    fact_importe_total NUMERIC(18,2) NOT NULL);
	
CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura(
    cod_factura INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Factura(fact_numero),
    cod_viaje INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Viaje(viaj_id),
    PRIMARY KEY (cod_factura, cod_viaje));
	
/* Migracion */

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
	VALUES (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1)

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

--Usuario - Chofer

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
	SELECT DISTINCT Chofer_Dni, Chofer_Nombre, Chofer_Apellido, Chofer_Fecha_Nac
	FROM gd_esquema.Maestra
	ORDER BY Chofer_Dni

--Chofer

INSERT LOS_MODERADAMENTE_ADECUADOS.Chofer (chof_id, chof_habilitado)
	SELECT usua_id, 1
	FROM LOS_MODERADAMENTE_ADECUADOS.Usuario

--Usuario - Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
	SELECT DISTINCT Cliente_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Fecha_Nac
	FROM gd_esquema.Maestra
	ORDER BY Cliente_Dni

--Contacto

INSERT LOS_MODERADAMENTE_ADECUADOS.Contacto (cont_mail, cont_telefono, cont_domicilio)
	SELECT a.Chofer_Mail, a.Chofer_Telefono, a.Chofer_Direccion
	FROM (SELECT DISTINCT Chofer_Dni, Chofer_Mail, Chofer_Telefono, Chofer_Direccion
		  FROM gd_esquema.Maestra) a
	ORDER BY a.Chofer_Dni

INSERT LOS_MODERADAMENTE_ADECUADOS.Contacto (cont_mail, cont_telefono, cont_domicilio)
	SELECT a.Cliente_Mail, a.Cliente_Telefono, a.Cliente_Direccion
	FROM (SELECT DISTINCT Cliente_Dni, Cliente_Mail, Cliente_Telefono, Cliente_Direccion
		  FROM gd_esquema.Maestra) a
	ORDER BY a.Cliente_Dni

--Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Cliente (clie_id, clie_codigo_postal, clie_habilitado)
	SELECT DISTINCT usua_id,  ROUND(10000*RAND(), 0), 1
	FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
		JOIN gd_esquema.Maestra ON usua_dni = Cliente_Dni

--Rol_X_Login_Usuario

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
VALUES (1,1)

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
	SELECT 2, clie_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
	SELECT 3, chof_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Chofer

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

--Marca

INSERT LOS_MODERADAMENTE_ADECUADOS.Marca(marc_nombre)
    SELECT DISTINCT Auto_Marca
	FROM gd_esquema.Maestra

--Modelo

INSERT LOS_MODERADAMENTE_ADECUADOS.Modelo(mode_codigo, mode_marca)
    SELECT DISTINCT Auto_Modelo, marc_id
	FROM gd_esquema.Maestra
		JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON marc_nombre = Auto_Marca
	
--Vehiculo

INSERT LOS_MODERADAMENTE_ADECUADOS.Vehiculo (vehi_chofer, vehi_patente, vehi_licencia, vehi_rodado, vehi_modelo, vehi_habilitado) 
	SELECT DISTINCT u.usua_id, Auto_Patente, Auto_Licencia, Auto_Rodado, mode_id, 1
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario u ON m.Chofer_Dni = u.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON mode_codigo = m.Auto_Modelo

--Turno_X_Vehiculo

INSERT LOS_MODERADAMENTE_ADECUADOS.Turno_X_Vehiculo (cod_turno, cod_vehiculo)
	SELECT DISTINCT turn_id, vehi_id
	FROM gd_esquema.Maestra 
		JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON Turno_Descripcion = turn_descripcion
		JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON Auto_Patente = vehi_patente

--Viaje

INSERT LOS_MODERADAMENTE_ADECUADOS.Viaje (viaj_chofer, viaj_vehiculo, viaj_cliente, viaj_turno, viaj_kms, viaj_inicio, viaj_fin)
	SELECT DISTINCT ch.chof_id, v.vehi_id, cl.clie_id, t.turn_id, m.Viaje_Cant_Kilometros, m.Viaje_Fecha, m.Viaje_Fecha
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario chofer ON m.Chofer_Dni = chofer.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ch ON chofer.usua_id = ch.chof_id
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON m.Cliente_Dni = cliente.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Cliente cl ON cliente.usua_id = cl.clie_id
		JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo v ON chofer.usua_id = v.vehi_chofer
		JOIN LOS_MODERADAMENTE_ADECUADOS.Turno t ON t.turn_descripcion = m.Turno_Descripcion

--Item_Rendicion

INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion (cod_rend, cod_viaje)
	SELECT rend_numero, viaj_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Rendicion
		JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON CONVERT(DATE, rend_fecha) = CONVERT(DATE, viaj_inicio)
												AND viaj_turno = rend_turno
												AND viaj_chofer = rend_chofer

--Factura

INSERT LOS_MODERADAMENTE_ADECUADOS.Factura (fact_numero, fact_cliente, fact_fecha_inicio, fact_fecha_fin, fact_importe_total) 
	SELECT DISTINCT Factura_Nro, cliente.clie_id, Factura_Fecha_Inicio, Factura_Fecha_Fin, sum(Viaje_Cant_Kilometros*Turno_Valor_Kilometro+Turno_Precio_Base)
	FROM gd_esquema.Maestra m
		JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario c ON m.Cliente_Dni = c.usua_dni
		JOIN LOS_MODERADAMENTE_ADECUADOS.Cliente cliente ON cliente.clie_id = c.usua_id
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro, cliente.clie_id, Factura_Fecha_Inicio, Factura_Fecha_Fin

--Item_Factura

INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Factura (cod_factura, cod_viaje)
	SELECT DISTINCT factura.fact_numero, viaje.viaj_id
	FROM LOS_MODERADAMENTE_ADECUADOS.Factura factura
		JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje viaje ON viaje.viaj_cliente = factura.fact_cliente
													AND CONVERT(DATE, viaje.viaj_inicio) BETWEEN CONVERT(DATE, factura.fact_fecha_inicio) AND CONVERT(DATE, factura.fact_fecha_fin)
GO

/* Procedures */

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.SPLOGIN
	@usuario varchar(20),
	@contrasenia varbinary(256)
AS
BEGIN

	DECLARE @pass varbinary(256), @intentos TINYINT

	SELECT @pass=logi_pass, @intentos=logi_intentos
	FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario
	WHERE logi_user = @usuario

	IF (@pass IS NULL) 
	BEGIN
		RAISERROR ('Usuario inexistente!', 16, 1)
		RETURN
	END

	IF (@intentos >= 3) 
	BEGIN
		RAISERROR ('Usuario inhabilitado!', 16, 1)
		RETURN
	END

	IF (@pass <> @contrasenia) 
	BEGIN
		UPDATE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario SET logi_intentos = @intentos + 1
		WHERE logi_user = @usuario
		DECLARE @error varchar(100)= 'Contrasenia Incorrecta! Intentos restantes: ' + str(2 - @intentos)
		RAISERROR (@error, 16, 1)
		RETURN
	END

	UPDATE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario SET logi_intentos = 0
	WHERE logi_user = @usuario

END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_INHABILITAR(@rol TINYINT) AS
BEGIN
	DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario 
	WHERE cod_rol = @rol

	UPDATE LOS_MODERADAMENTE_ADECUADOS.Rol SET rol_habilitado = 0
	WHERE rol_id = @rol
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_REHABILITAR(@rol TINYINT) AS
BEGIN
	UPDATE LOS_MODERADAMENTE_ADECUADOS.Rol SET rol_habilitado = 1
	WHERE rol_id = @rol
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_AGREGAR_FUNCIONALIDAD(@rol TINYINT, @funcionalidad TINYINT) AS
BEGIN
	INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol (cod_func, cod_rol)
	VALUES (@funcionalidad, @rol)
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_QUITAR_FUNCIONALIDAD(@rol TINYINT, @funcionalidad TINYINT) AS
BEGIN
	DELETE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
	WHERE cod_func = @funcionalidad AND cod_rol = @rol
END
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_ID_USUARIO(@usuario VARCHAR(20)) RETURNS INT AS
BEGIN
	RETURN	(SELECT logi_id
			FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario
			WHERE logi_user = @usuario)
END
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_CANTIDAD_DE_ROLES(@usuarioId int) RETURNS TINYINT
AS
BEGIN
	RETURN	(SELECT count(*)
			FROM LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
			WHERE cod_login = @usuarioId)
END
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES(@usuarioId int) RETURNS TABLE
AS
	RETURN	(	SELECT rol_nombre, rol_id
				FROM Rol
					JOIN Rol_X_Login_Usuario ON cod_rol = rol_id
				WHERE cod_login = @usuarioId)
GO