USE GD1C2017;
GO

-- Eliminacion de objetos preexistentes

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Login_Usuario','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Login_Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Usuario','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Usuario;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Cliente','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Cliente;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Chofer','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Chofer;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Contacto','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Contacto;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Indice_Vehiculo','U') IS NOT NULL
  DROP INDEX LOS_MODERADAMENTE_ADECUADOS.Indice_Vehiculo;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Item_Factura','U') IS NOT NULL
  DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Factura','U') IS NOT NULL
  DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Factura;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion','U') IS NOT NULL
  DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.Viaje','U') IS NOT NULL
  DROP TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje;

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

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.USUARIO_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CLIENTE_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CLIENTE_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CLIENTE_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CLIENTE_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CHOFER_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CHOFER_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CHOFER_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CHOFER_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.ROL_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.TURNO_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.TURNO_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.TURNO_NUEVO') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.TURNO_NUEVO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_INHABILITAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_INHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CLIENTE_INHABILITAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CLIENTE_INHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CHOFER_INHABILITAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.CHOFER_INHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.TURNO_INHABILITAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.TURNO_INHABILITAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.REGISTRAR_VIAJE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.REGISTRAR_VIAJE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.FACTURA_GENERAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.FACTURA_GENERAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_ROL_UPDATE') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.USUARIO_ROL_UPDATE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.RENDICION_GENERAR') IS NOT NULL
  DROP PROCEDURE LOS_MODERADAMENTE_ADECUADOS.RENDICION_GENERAR;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ID') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ID;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDAD_GET_DESCRIPCION') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDAD_GET_DESCRIPCION;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ROL_GET_FUNCIONALIDADES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.ROL_GET_FUNCIONALIDADES;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.CHOFER_GET') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.CHOFER_GET;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_AUTOS_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_AUTOS_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_CHOFERES_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_CHOFERES_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_CLIENTES_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_CLIENTES_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_NO_CHOFERES_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_NO_CHOFERES_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_NO_CLIENTES_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_NO_CLIENTES_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.GET_TURNOS_CON_FILTROS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TURNOS_CON_FILTROS;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.TURNO_GET') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.TURNO_GET;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_GET_DE') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_GET_DE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_MAYOR_RECAUDACION') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_MAYOR_RECAUDACION;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_VIAJE_MAS_LARGO') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_VIAJE_MAS_LARGO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_CONSUMO') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_CONSUMO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_USO_MISMO_VEHICULO') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_USO_MISMO_VEHICULO;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET_VIAJES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET_VIAJES;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CLIENTE') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CLIENTE;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CHOFER') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CHOFER;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDADES_GET_TABLA_DE_ROL') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDADES_GET_TABLA_DE_ROL;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET;

IF OBJECT_ID('LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET_VIAJES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET_VIAJES;

IF OBJECT_ID(N'LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_USUARIOS') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_USUARIOS;

IF OBJECT_ID(N'LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CLIENTES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CLIENTES;

IF OBJECT_ID(N'LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CHOFERES') IS NOT NULL
  DROP FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CHOFERES;

IF TYPE_ID(N'LOS_MODERADAMENTE_ADECUADOS.TABLA_ROL_X_FUNCIONALIDAD') IS NOT NULL
  DROP TYPE LOS_MODERADAMENTE_ADECUADOS.TABLA_ROL_X_FUNCIONALIDAD;

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'LOS_MODERADAMENTE_ADECUADOS')
  DROP SCHEMA LOS_MODERADAMENTE_ADECUADOS
GO

-- Creacion del esquema

CREATE SCHEMA LOS_MODERADAMENTE_ADECUADOS;
GO

-- Creacion de las tablas

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol(
  rol_id TINYINT IDENTITY PRIMARY KEY,
  rol_nombre NVARCHAR(200) NOT NULL,
  rol_detalle NVARCHAR(200),
  rol_habilitado BIT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(
  func_id TINYINT IDENTITY PRIMARY KEY,
  func_descripcion NVARCHAR(200)
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol(
  cod_func TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Funcionalidad(func_id),
  cod_rol TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
  PRIMARY KEY (cod_func, cod_rol)
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(
  logi_id INT IDENTITY PRIMARY KEY,
  logi_user NVARCHAR(20) UNIQUE NOT NULL,
  logi_pass VARBINARY(256) NOT NULL,
  logi_habilitado BIT NOT NULL,
  logi_intentos TINYINT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Usuario(
  usua_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id),
  usua_dni NUMERIC(18,0) UNIQUE NOT NULL,
  usua_nombre VARCHAR(255) NOT NULL,
  usua_apellido VARCHAR(255) NOT NULL,
  usua_fecha_nacimiento DATETIME NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Cliente(
  clie_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
  clie_codigo_postal NUMERIC(18,0) NOT NULL,
  clie_habilitado BIT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Chofer(
  chof_id INT PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
  chof_habilitado BIT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Contacto(
  cont_id INT IDENTITY(2,1) PRIMARY KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id),
  cont_mail NVARCHAR(255),
  cont_telefono NUMERIC(18,0) UNIQUE NOT NULL,
  cont_domicilio NVARCHAR(255) NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario(
  cod_rol TINYINT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rol(rol_id),
  cod_login INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id),
  PRIMARY KEY (cod_rol, cod_login)
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Turno(
  turn_id TINYINT IDENTITY PRIMARY KEY,
  turn_hora_inicio NUMERIC(18,0) NOT NULL,
  turn_hora_fin NUMERIC(18,0) NOT NULL,
  turn_descripcion NVARCHAR(255) NOT NULL,
  turn_valor_kilometro NUMERIC(10,2) NOT NULL,
  turn_precio_base NUMERIC(10,2) NOT NULL,
  turn_habilitado BIT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Rendicion(
  rend_numero INT IDENTITY PRIMARY KEY,
  rend_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
  rend_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
  rend_fecha DATETIME NOT NULL,
  rend_porcentaje NUMERIC(2,2) NOT NULL CHECK (rend_porcentaje <=1 AND rend_porcentaje >= 0),
  rend_importe_total NUMERIC(10,2) NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Marca(
  marc_id TINYINT IDENTITY PRIMARY KEY,
  marc_nombre VARCHAR(255) NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Modelo(
  mode_id INT IDENTITY PRIMARY KEY,
  mode_codigo VARCHAR(255) NOT NULL,
  mode_marca TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Marca(marc_id)
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Vehiculo(
  vehi_id INT IDENTITY PRIMARY KEY,
  vehi_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
  vehi_patente VARCHAR(10) UNIQUE NOT NULL,
  vehi_licencia VARCHAR(26) NOT NULL,
  vehi_rodado VARCHAR(10),
  vehi_modelo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Modelo(mode_id),
  vehi_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
  vehi_habilitado BIT NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Viaje(
  viaj_id INT IDENTITY PRIMARY KEY,
  viaj_chofer INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id),
  viaj_vehiculo INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id),
  viaj_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id),
  viaj_turno TINYINT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Turno(turn_id),
  viaj_kms NUMERIC(18,0) NOT NULL CHECK (viaj_kms>0),
  viaj_inicio DATETIME NOT NULL,
  viaj_fin DATETIME NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion(
  cod_rend INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Rendicion(rend_numero),
  cod_viaje INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Viaje(viaj_id),
  PRIMARY KEY (cod_rend, cod_viaje)
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Factura(
  fact_numero INT IDENTITY PRIMARY KEY,
  fact_cliente INT NOT NULL FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id),
  fact_fecha_inicio DATETIME NOT NULL,
  fact_fecha_fin DATETIME NOT NULL,
  fact_importe_total NUMERIC(18,2) NOT NULL
);

CREATE TABLE LOS_MODERADAMENTE_ADECUADOS.Item_Factura(
  cod_factura INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Factura(fact_numero),
  cod_viaje INT FOREIGN KEY REFERENCES LOS_MODERADAMENTE_ADECUADOS.Viaje(viaj_id),
  PRIMARY KEY (cod_factura, cod_viaje)
);

-- Migracion

-- Indices

CREATE INDEX Indice_Login_Usuario ON LOS_MODERADAMENTE_ADECUADOS.Login_Usuario(logi_id, logi_user)
CREATE INDEX Indice_Usuario ON LOS_MODERADAMENTE_ADECUADOS.Usuario(usua_id, usua_nombre, usua_apellido, usua_dni)
CREATE INDEX Indice_Cliente ON LOS_MODERADAMENTE_ADECUADOS.Cliente(clie_id)
CREATE INDEX Indice_Chofer ON LOS_MODERADAMENTE_ADECUADOS.Chofer(chof_id)
CREATE INDEX Indice_Contacto ON LOS_MODERADAMENTE_ADECUADOS.Contacto(cont_id)
CREATE INDEX Indice_Vehiculo ON LOS_MODERADAMENTE_ADECUADOS.Vehiculo(vehi_id, vehi_modelo)
GO

-- Rol

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol (rol_nombre, rol_detalle, rol_habilitado)
VALUES  ('Administrador', 'Rol de administrador', 1),
        ('Cliente', 'Rol de cliente', 1),
        ('Chofer', 'Rol de chofer', 1)

-- Funcionalidad

INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad (func_descripcion)
VALUES  ('ABM de Rol'),
        ('ABM de Cliente'),
        ('ABM de Automovil'),
        ('ABM de Turno'),
        ('ABM de Chofer'),
        ('Registro de Viaje'),
        ('Facturacion de Clientes'),
        ('Rendicion de Viajes'),
        ('Listado Estadistico')

-- Funcionalidad_X_Rol

INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol (cod_func, cod_rol)
VALUES  (1, 1),
        (2, 1),
        (3, 1),
        (4, 1),
        (5, 1),
        (6, 1),
        (7, 1),
        (8, 1),
        (9, 1),
        (6, 2),
        (6, 3)

-- Login_Usuario

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

-- Usuario - Chofer

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
  SELECT DISTINCT Chofer_Dni, Chofer_Nombre, Chofer_Apellido, Chofer_Fecha_Nac
  FROM gd_esquema.Maestra
  ORDER BY Chofer_Dni

-- Chofer

INSERT LOS_MODERADAMENTE_ADECUADOS.Chofer (chof_id, chof_habilitado)
  SELECT usua_id, 1
  FROM LOS_MODERADAMENTE_ADECUADOS.Usuario

-- Usuario - Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario (usua_dni, usua_nombre, usua_apellido, usua_fecha_nacimiento)
  SELECT DISTINCT Cliente_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Fecha_Nac
  FROM gd_esquema.Maestra
  ORDER BY Cliente_Dni

-- Contacto

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

-- Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Cliente (clie_id, clie_codigo_postal, clie_habilitado)
  SELECT DISTINCT usua_id, 0, 1
  FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
    JOIN gd_esquema.Maestra ON usua_dni = Cliente_Dni

-- Rol_X_Login_Usuario

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
VALUES (1,1)

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
  SELECT 2, clie_id
  FROM LOS_MODERADAMENTE_ADECUADOS.Cliente

INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario (cod_rol, cod_login)
  SELECT 3, chof_id
  FROM LOS_MODERADAMENTE_ADECUADOS.Chofer

-- Turno

INSERT LOS_MODERADAMENTE_ADECUADOS.Turno (turn_descripcion, turn_hora_inicio, turn_hora_fin, turn_valor_kilometro, turn_precio_base, turn_habilitado)
  SELECT DISTINCT Turno_Descripcion, Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Valor_Kilometro, Turno_Precio_Base, 1
  FROM gd_esquema.Maestra

-- Rendicion

SET IDENTITY_INSERT LOS_MODERADAMENTE_ADECUADOS.Rendicion ON

INSERT LOS_MODERADAMENTE_ADECUADOS.Rendicion (rend_numero, rend_turno, rend_chofer, rend_fecha, rend_porcentaje, rend_importe_total)
  SELECT Rendicion_Nro, t.turn_id, c.usua_id, Rendicion_Fecha, 0.3, sum(Rendicion_Importe)
  FROM gd_esquema.Maestra m
    JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario c ON m.Chofer_Dni = c.usua_dni
    JOIN LOS_MODERADAMENTE_ADECUADOS.Turno t ON m.Turno_Descripcion = t.turn_descripcion
  WHERE Rendicion_Nro IS NOT NULL
  GROUP BY Rendicion_Nro, t.turn_id, c.usua_id, Rendicion_Fecha

SET IDENTITY_INSERT LOS_MODERADAMENTE_ADECUADOS.Rendicion OFF

-- Marca

INSERT LOS_MODERADAMENTE_ADECUADOS.Marca(marc_nombre)
  SELECT DISTINCT Auto_Marca
  FROM gd_esquema.Maestra

-- Modelo

INSERT LOS_MODERADAMENTE_ADECUADOS.Modelo(mode_codigo, mode_marca)
  SELECT DISTINCT Auto_Modelo, marc_id
  FROM gd_esquema.Maestra
    JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON marc_nombre = Auto_Marca

-- Vehiculo

INSERT LOS_MODERADAMENTE_ADECUADOS.Vehiculo (vehi_chofer, vehi_patente, vehi_licencia, vehi_rodado, vehi_modelo, vehi_turno, vehi_habilitado)
  SELECT DISTINCT usua_id, Auto_Patente, Auto_Licencia, Auto_Rodado, mode_id,
    ( SELECT TOP 1 turn_id
      FROM gd_esquema.Maestra
        JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON Turno_Descripcion = turn_descripcion
      WHERE m.Auto_Licencia = Auto_Licencia
      ORDER BY Viaje_Fecha DESC), 1
  FROM gd_esquema.Maestra m
    JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario ON Chofer_Dni = usua_dni
    JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON mode_codigo = Auto_Modelo

-- Viaje

INSERT LOS_MODERADAMENTE_ADECUADOS.Viaje (viaj_chofer, viaj_vehiculo, viaj_cliente, viaj_turno, viaj_kms, viaj_inicio, viaj_fin)
  SELECT DISTINCT ch.chof_id, v.vehi_id, cl.clie_id, t.turn_id, m.Viaje_Cant_Kilometros, m.Viaje_Fecha, m.Viaje_Fecha
  FROM gd_esquema.Maestra m
    JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario chofer ON m.Chofer_Dni = chofer.usua_dni
    JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ch ON chofer.usua_id = ch.chof_id
    JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON m.Cliente_Dni = cliente.usua_dni
    JOIN LOS_MODERADAMENTE_ADECUADOS.Cliente cl ON cliente.usua_id = cl.clie_id
    JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo v ON chofer.usua_id = v.vehi_chofer
    JOIN LOS_MODERADAMENTE_ADECUADOS.Turno t ON t.turn_descripcion = m.Turno_Descripcion

-- Item_Rendicion

INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion (cod_rend, cod_viaje)
  SELECT rend_numero, viaj_id
  FROM LOS_MODERADAMENTE_ADECUADOS.Rendicion
    JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON CONVERT(DATE, rend_fecha) = CONVERT(DATE, viaj_inicio)
      AND viaj_turno = rend_turno
      AND viaj_chofer = rend_chofer

-- Factura
SET IDENTITY_INSERT LOS_MODERADAMENTE_ADECUADOS.Factura ON

INSERT LOS_MODERADAMENTE_ADECUADOS.Factura (fact_numero, fact_cliente, fact_fecha_inicio, fact_fecha_fin, fact_importe_total)
  SELECT DISTINCT Factura_Nro, cliente.clie_id, Factura_Fecha_Inicio, Factura_Fecha_Fin, sum(Viaje_Cant_Kilometros * Turno_Valor_Kilometro + Turno_Precio_Base)
  FROM gd_esquema.Maestra m
    JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario c ON m.Cliente_Dni = c.usua_dni
    JOIN LOS_MODERADAMENTE_ADECUADOS.Cliente cliente ON cliente.clie_id = c.usua_id
  WHERE Factura_Nro IS NOT NULL
  GROUP BY Factura_Nro, cliente.clie_id, Factura_Fecha_Inicio, Factura_Fecha_Fin

SET IDENTITY_INSERT LOS_MODERADAMENTE_ADECUADOS.Factura OFF

-- Item_Factura

INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Factura (cod_factura, cod_viaje)
  SELECT DISTINCT factura.fact_numero, viaje.viaj_id
  FROM LOS_MODERADAMENTE_ADECUADOS.Factura factura
    JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje viaje ON viaje.viaj_cliente = factura.fact_cliente
      AND viaje.viaj_inicio BETWEEN factura.fact_fecha_inicio AND factura.fact_fecha_fin
GO

-- Procedimientos

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.SPLOGIN(  @usuario varchar(20),
                                                  @contrasenia varbinary(256))
AS
BEGIN

  DECLARE @pass varbinary(256), @intentos TINYINT, @habilitado BIT

  SELECT @pass=logi_pass, @intentos=logi_intentos, @habilitado = logi_habilitado
  FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario
  WHERE logi_user = @usuario

  IF (@pass IS NULL)
  BEGIN
    RAISERROR ('Usuario inexistente!', 16, 1)
    RETURN
  END

  IF (@habilitado = 0)
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

    IF(@intentos = 2)
    BEGIN
      UPDATE LOS_MODERADAMENTE_ADECUADOS.Login_Usuario SET logi_habilitado = 0
      WHERE logi_user = @usuario
    END
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
    AND cod_login <> 1

  IF(@rol = 2)
  BEGIN
    UPDATE LOS_MODERADAMENTE_ADECUADOS.Cliente SET clie_habilitado = 0
  END

  IF(@rol = 3)
  BEGIN
    UPDATE LOS_MODERADAMENTE_ADECUADOS.Chofer SET chof_habilitado = 0
  END

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Rol SET rol_habilitado = 0
  WHERE rol_id = @rol
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_INHABILITAR(@idAutomovil INT) AS
BEGIN
  UPDATE LOS_MODERADAMENTE_ADECUADOS.Vehiculo SET vehi_habilitado = 0
  WHERE vehi_id = @idAutomovil
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CLIENTE_INHABILITAR(@id INT) AS
BEGIN
  UPDATE LOS_MODERADAMENTE_ADECUADOS.Cliente SET clie_habilitado = 0
  WHERE clie_id = @id

  DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
  WHERE cod_login = @id
    AND cod_rol = 2
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CHOFER_INHABILITAR(@id INT) AS
BEGIN
  UPDATE LOS_MODERADAMENTE_ADECUADOS.Chofer SET chof_habilitado = 0
  WHERE chof_id = @id

  DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
  WHERE cod_login = @id
    AND cod_rol = 3
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.TURNO_INHABILITAR(@id INT) AS
BEGIN
  UPDATE LOS_MODERADAMENTE_ADECUADOS.Turno SET turn_habilitado = 0
  WHERE turn_id = @id
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.USUARIO_ROL_UPDATE( @idUsuario INT,
                                                            @idRol TINYINT,
                                                            @habilitado BIT)
AS
BEGIN
  IF(@habilitado = 0)
  BEGIN
    DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    WHERE cod_rol = @idRol
      AND cod_login = @idUsuario
  END
  ELSE
  BEGIN
    DECLARE @existe TINYINT = ( SELECT count(*)
                                FROM LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
                                WHERE cod_rol = @idRol
                                  AND cod_login = @idUsuario)

    IF(@existe = 0)
    BEGIN
      INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
      VALUES (@idRol, @idUsuario)
    END
  END

  IF(@idRol = 2)
  BEGIN
    UPDATE LOS_MODERADAMENTE_ADECUADOS.Cliente SET clie_habilitado = @habilitado
    WHERE clie_id = @idUsuario
  END

  IF(@idRol = 3)
  BEGIN
    UPDATE LOS_MODERADAMENTE_ADECUADOS.Chofer SET chof_habilitado = @habilitado
    WHERE chof_id = @idUsuario
  END
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_UPDATE( @automovilId INT,
                                                          @chofer INT,
                                                          @patente VARCHAR(10),
                                                          @licencia VARCHAR(26),
                                                          @rodado VARCHAR(10),
                                                          @modelo VARCHAR(255),
                                                          @marca VARCHAR(255),
                                                          @turno TINYINT,
                                                          @habilitado BIT)
AS
BEGIN
  DECLARE @yaTieneVehiculoHabilitado INT = (SELECT ISNULL(count(*), 0)
                                            FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
                                            WHERE vehi_chofer = @chofer
                                              AND vehi_habilitado = 1
                                              AND vehi_id <> @automovilId)

  IF(@habilitado = 1 AND @yaTieneVehiculoHabilitado <> 0)
  BEGIN
    RAISERROR('El chofer indicado ya tiene un vehiculo habilitado, si quiere habilitar este, por favor deshabilite el otro primero.', 16, 1)
    RETURN
  END

  DECLARE @_modelo INT = (SELECT mode_id
                          FROM LOS_MODERADAMENTE_ADECUADOS.Modelo
                          WHERE mode_codigo = @modelo)
  IF(@_modelo IS NULL)  INSERT LOS_MODERADAMENTE_ADECUADOS.Modelo
                        VALUES (@modelo, (SELECT marc_id
                                          FROM LOS_MODERADAMENTE_ADECUADOS.Marca
                                          WHERE marc_nombre = @marca))

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Vehiculo SET vehi_chofer = @chofer,
                                                  vehi_patente = @patente,
                                                  vehi_licencia = @licencia,
                                                  vehi_rodado = @rodado,
                                                  vehi_modelo = ISNULL(@_modelo, SCOPE_IDENTITY()),
                                                  vehi_turno = @turno,
                                                  vehi_habilitado = @habilitado
  WHERE vehi_id = @automovilId

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Modelo SET mode_marca = (SELECT marc_id
                                                              FROM LOS_MODERADAMENTE_ADECUADOS.Marca
                                                              WHERE marc_nombre = @marca)
  WHERE mode_codigo = @modelo
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_NUEVO(@chofer INT,
                                                        @patente VARCHAR(10),
                                                        @licencia VARCHAR(26),
                                                        @rodado VARCHAR(10),
                                                        @modelo VARCHAR(255),
                                                        @marca VARCHAR(255),
                                                        @turno TINYINT,
                                                        @habilitado BIT)
AS
BEGIN
  DECLARE @yaTieneVehiculoHabilitado INT = (SELECT ISNULL(count(*),0)
                                            FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
                                            WHERE vehi_chofer = @chofer
                                              AND vehi_habilitado = 1)

  IF(@habilitado = 1 AND @yaTieneVehiculoHabilitado <> 0)
  BEGIN
    RAISERROR('El chofer indicado ya tiene un vehiculo habilitado, si quiere habilitar este, por favor deshabilite el otro primero.', 16, 1)
    RETURN
  END

  DECLARE @_modelo INT = (SELECT mode_id
                          FROM LOS_MODERADAMENTE_ADECUADOS.Modelo
                          WHERE mode_codigo = @modelo)
  IF(@_modelo IS NULL)  INSERT LOS_MODERADAMENTE_ADECUADOS.Modelo
                        VALUES (@modelo, (SELECT marc_id
                                          FROM LOS_MODERADAMENTE_ADECUADOS.Marca
                                          WHERE marc_nombre = @marca))

  INSERT LOS_MODERADAMENTE_ADECUADOS.Vehiculo 
  VALUES (@chofer, @patente, @licencia, @rodado, ISNULL(@_modelo, SCOPE_IDENTITY()), @turno, @habilitado)
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.USUARIO_NUEVO(@nombre VARCHAR(255),
                                                      @apellido VARCHAR(255),
                                                      @dni NUMERIC(18,0),
                                                      @mail VARCHAR(255),
                                                      @telefono NUMERIC(18,0),
                                                      @domicilio VARCHAR(255),
                                                      @fechaNac DATETIME,
                                                      @nombreDeUsuario NVARCHAR(20),
                                                      @contrasenia VARBINARY(256))
AS
BEGIN

  INSERT LOS_MODERADAMENTE_ADECUADOS.Login_Usuario
  VALUES (@nombreDeUsuario, @contrasenia, 1, 0)

  INSERT LOS_MODERADAMENTE_ADECUADOS.Usuario
  VALUES (@dni, @nombre, @apellido, @fechaNac)

  INSERT LOS_MODERADAMENTE_ADECUADOS.Contacto
  VALUES (@mail, @telefono, @domicilio)

END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CHOFER_UPDATE(@id INT,
                                                      @nombre VARCHAR(255),
                                                      @apellido VARCHAR(255),
                                                      @dni NUMERIC(18,0),
                                                      @mail VARCHAR(255),
                                                      @telefono NUMERIC(18,0),
                                                      @domicilio VARCHAR(255),
                                                      @fechaNac DATETIME,
                                                      @habilitado BIT)
AS
BEGIN
  IF(@habilitado = 0)
  BEGIN
    DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    WHERE cod_login = @id
      AND cod_rol = 3
  END
  ELSE
  BEGIN
  IF((SELECT rol_habilitado
      FROM LOS_MODERADAMENTE_ADECUADOS.Rol
      WHERE rol_id = 3) = 0)
  BEGIN
    RAISERROR('El rol de Chofer se encuentra deshabilitado. Si quiere habilitar el chofer, debe habilitar el rol primero.', 16, 1)
    RETURN
  END
  IF(@id NOT IN ( SELECT cod_login
                  FROM LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
                  WHERE cod_rol = 3))
  BEGIN
    INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    VALUES (3, @id)
  END
  END

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Chofer SET chof_habilitado = @habilitado
  WHERE chof_id = @id

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Usuario SET  usua_nombre = @nombre,
                                                  usua_apellido = @apellido,
                                                  usua_dni = @dni,
                                                  usua_fecha_nacimiento = @fechaNac
  WHERE usua_id = @id

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Contacto SET cont_mail = @mail,
                                                  cont_telefono = @telefono,
                                                  cont_domicilio = @domicilio
  WHERE cont_id = @id
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CHOFER_NUEVO( @id INT,
                                                      @habilitado BIT)
AS
BEGIN

  IF(@habilitado = 1 AND (SELECT rol_habilitado
                          FROM LOS_MODERADAMENTE_ADECUADOS.Rol
                          WHERE rol_id = 3) = 0)
  BEGIN
    RAISERROR('El rol de Chofer se encuentra deshabilitado. Si quiere habilitar el chofer, debe habilitar el rol primero.', 16, 1)
    RETURN
  END
  INSERT LOS_MODERADAMENTE_ADECUADOS.Chofer
  VALUES (@id, @habilitado)
  IF(@habilitado = 1)
  BEGIN
    INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    VALUES (3, @id)
  END
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CLIENTE_UPDATE( @id INT,
                                                        @nombre VARCHAR(255),
                                                        @apellido VARCHAR(255),
                                                        @dni NUMERIC(18,0),
                                                        @mail VARCHAR(255),
                                                        @telefono NUMERIC(18,0),
                                                        @domicilio VARCHAR(255),
                                                        @fechaNac DATETIME,
                                                        @codigoPostal NUMERIC(18,0),
                                                        @habilitado BIT)
AS
BEGIN
  IF(@habilitado = 0)
  BEGIN
    DELETE LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    WHERE cod_login = @id
      AND cod_rol = 2
  END
  ELSE
  BEGIN
  IF((SELECT rol_habilitado
      FROM LOS_MODERADAMENTE_ADECUADOS.Rol
      WHERE rol_id = 2) = 0)
  BEGIN
    RAISERROR('El rol de Cliente se encuentra deshabilitado. Si quiere habilitar el cliente, debe habilitar el rol primero.', 16, 1)
    RETURN
  END
  IF(@id NOT IN ( SELECT cod_login
                  FROM LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
                  WHERE cod_rol = 2))
    BEGIN
      INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
      VALUES (2, @id)
    END
  END
  UPDATE LOS_MODERADAMENTE_ADECUADOS.Cliente SET  clie_habilitado = @habilitado,
                                                  clie_codigo_postal = @codigoPostal
  WHERE clie_id = @id

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Usuario SET  usua_nombre = @nombre,
                                                  usua_apellido = @apellido,
                                                  usua_dni = @dni,
                                                  usua_fecha_nacimiento = @fechaNac
  WHERE usua_id = @id

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Contacto SET cont_mail = @mail,
                                                  cont_telefono = @telefono,
                                                  cont_domicilio = @domicilio
  WHERE cont_id = @id
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.CLIENTE_NUEVO(@id INT,
                                                      @codigoPostal NUMERIC(18,0),
                                                      @habilitado BIT)
AS
BEGIN
  IF(@habilitado = 1 AND (SELECT rol_habilitado
                          FROM LOS_MODERADAMENTE_ADECUADOS.Rol
                          WHERE rol_id = 2) = 0)
  BEGIN
    RAISERROR('El rol de Cliente se encuentra deshabilitado. Si quiere habilitar el cliente, debe habilitar el rol primero.', 16, 1)
    RETURN
  END

  INSERT LOS_MODERADAMENTE_ADECUADOS.Cliente
  VALUES (@id, @codigoPostal, @habilitado)
  IF(@habilitado = 1)
  BEGIN
    INSERT LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
    VALUES (2, @id)
  END
END
GO

CREATE TYPE LOS_MODERADAMENTE_ADECUADOS.TABLA_ROL_X_FUNCIONALIDAD AS TABLE( idFuncionalidad TINYINT,
                                                                            descripcion VARCHAR(255),
                                                                            habilitado BIT
)
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_UPDATE( @id TINYINT,
                                                    @nombre VARCHAR(200),
                                                    @detalle VARCHAR(200),
                                                    @funcionalidades TABLA_ROL_X_FUNCIONALIDAD READONLY,
                                                    @habilitado BIT)
AS
BEGIN
  IF (@habilitado = 0)
  BEGIN
    EXEC LOS_MODERADAMENTE_ADECUADOS.ROL_INHABILITAR @id
  END

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Rol SET  rol_nombre = @nombre,
                                              rol_detalle = @detalle,
                                              rol_habilitado = @habilitado
  WHERE rol_id = @id

  DELETE LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
  WHERE cod_rol = @id

  INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
    SELECT idFuncionalidad, @id
    FROM @funcionalidades
    WHERE habilitado = 1
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.ROL_NUEVO(@nombre VARCHAR(200),
                                                  @detalle VARCHAR(200),
                                                  @funcionalidades TABLA_ROL_X_FUNCIONALIDAD READONLY,
                                                  @habilitado BIT)
AS
BEGIN
  INSERT LOS_MODERADAMENTE_ADECUADOS.Rol
  VALUES (@nombre, @detalle, @habilitado)

  DECLARE @rol TINYINT = SCOPE_IDENTITY()

  INSERT LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
    SELECT idFuncionalidad, @rol
    FROM @funcionalidades
    WHERE habilitado = 1
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.TURNO_UPDATE( @id TINYINT,
                                                      @horaInicio NUMERIC(18,0),
                                                      @horaFin NUMERIC(18,0),
                                                      @descripcion NVARCHAR(255),
                                                      @valorKilometro NUMERIC(10,2),
                                                      @precioBase NUMERIC(10,2),
                                                      @habilitado BIT)
AS
BEGIN
  DECLARE @colision VARCHAR(255) = (SELECT TOP 1 turn_descripcion
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Turno
                                    WHERE turn_hora_inicio < @horaFin
                                      AND turn_hora_fin > @horaInicio
                                      AND turn_habilitado = 1
                                      AND @habilitado = 1
                                      AND turn_id <> @id)

  IF(@colision IS NOT NULL)
  BEGIN
    DECLARE @error VARCHAR(255) = 'El horario seleccionado se solapa con el del turno ' + @colision + ', puede deshabilitarlo y volver a intentar.'
    RAISERROR(@error, 16, 1)
    RETURN
  END

  UPDATE LOS_MODERADAMENTE_ADECUADOS.Turno SET  turn_hora_inicio = @horaInicio,
                                                turn_hora_fin = @horaFin,
                                                turn_descripcion = @descripcion,
                                                turn_valor_kilometro = @valorKilometro,
                                                turn_precio_base = @precioBase,
                                                turn_habilitado = @habilitado
  WHERE turn_id = @id
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.TURNO_NUEVO(  @horaInicio NUMERIC(18,0),
                                                      @horaFin NUMERIC(18,0),
                                                      @descripcion NVARCHAR(255),
                                                      @valorKilometro NUMERIC(10,2),
                                                      @precioBase NUMERIC(10,2),
                                                      @habilitado BIT)
AS
BEGIN
  DECLARE @colision VARCHAR(255) = (SELECT TOP 1 turn_descripcion
                                    FROM LOS_MODERADAMENTE_ADECUADOS.Turno
                                    WHERE turn_hora_inicio < @horaFin
                                      AND turn_hora_fin > @horaInicio
                                      AND turn_habilitado = 1
                                      AND @habilitado = 1)

  IF(@colision IS NOT NULL)
  BEGIN
    DECLARE @error VARCHAR(255) = 'El horario seleccionado se solapa con el del turno ' + @colision + ', puede deshabilitarlo y volver a intentar.'
    RAISERROR(@error, 16, 1)
    RETURN
  END

  INSERT LOS_MODERADAMENTE_ADECUADOS.Turno
  VALUES (@horaInicio, @horaFin, @descripcion, @valorKilometro, @precioBase, @habilitado)
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.REGISTRAR_VIAJE(@chofer INT,
                                                        @vehiculo INT,
                                                        @cliente INT,
                                                        @turno TINYINT,
                                                        @kms NUMERIC(18,0),
                                                        @inicio DATETIME,
                                                        @fin DATETIME)
AS
BEGIN
  DECLARE @colision INT = ( SELECT count(*)
                            FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
                            WHERE viaj_inicio < @fin
                              AND viaj_fin > @inicio
                              AND viaj_cliente = @cliente)

  IF(@colision <> 0)
  BEGIN
    DECLARE @error VARCHAR(255) = 'El cliente seleccionado ya tiene un viaje realizado durante el periodo indicado.'
    RAISERROR(@error, 16, 1)
    RETURN
  END

  INSERT LOS_MODERADAMENTE_ADECUADOS.Viaje
  VALUES (@chofer, @vehiculo, @cliente, @turno, @kms, @inicio, @fin)
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.FACTURA_GENERAR(@idCliente INT,
                                                        @fechaInicio DATETIME,
                                                        @fechaFin DATETIME,
                                                        @importeTotal NUMERIC(18,2))
AS
BEGIN
  INSERT LOS_MODERADAMENTE_ADECUADOS.Factura
  VALUES (@idCliente, @fechaInicio, @fechaFin, @importeTotal)

  DECLARE @idFactura INT = SCOPE_IDENTITY()

  INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Factura (cod_factura, cod_viaje)
    SELECT @idFactura, viaj_id
    FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
    WHERE viaj_inicio BETWEEN @fechaInicio AND @fechaFin
      AND viaj_cliente = @idCliente
END
GO

CREATE PROC LOS_MODERADAMENTE_ADECUADOS.RENDICION_GENERAR(@idChofer INT,
                                                          @fecha DATETIME,
                                                          @turno TINYINT,
                                                          @porcentaje NUMERIC(2,2),
                                                          @importeTotal NUMERIC(18,2))
AS
BEGIN
  INSERT LOS_MODERADAMENTE_ADECUADOS.Rendicion
  VALUES (@turno, @idChofer, @fecha, @porcentaje, @importeTotal)

  DECLARE @idRendicion INT = SCOPE_IDENTITY()

  INSERT LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion (cod_rend, cod_viaje)
    SELECT @idRendicion, viaj_id
    FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
    WHERE CONVERT(DATE, viaj_inicio) = CONVERT(DATE, @fecha)
      AND viaj_turno = @turno
      AND viaj_chofer = @idChofer
END
GO

-- Funciones

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ID(@usuario VARCHAR(20)) RETURNS INT AS
BEGIN
  RETURN (SELECT logi_id
          FROM LOS_MODERADAMENTE_ADECUADOS.Login_Usuario
          WHERE logi_user = @usuario)
END
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.USUARIO_GET_ROLES(@usuarioId int) RETURNS TABLE
AS
  RETURN (SELECT rol_nombre AS Nombre, rol_id, rol_detalle AS Descripcion, rol_habilitado AS Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Rol
            JOIN Rol_X_Login_Usuario ON cod_rol = rol_id
          WHERE cod_login = @usuarioId)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDAD_GET_DESCRIPCION(@funcionalidadId TINYINT) RETURNS varchar(200)
AS
BEGIN
  RETURN (SELECT func_descripcion
          FROM LOS_MODERADAMENTE_ADECUADOS.Funcionalidad
          WHERE func_id = @funcionalidadId)
END
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.ROL_GET_FUNCIONALIDADES(@rolId TINYINT) RETURNS TABLE
AS
  RETURN (SELECT cod_func
          FROM LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
          WHERE cod_rol = @rolId)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.CHOFER_GET(@id INT) RETURNS TABLE
AS
  RETURN (SELECT  usua_id,
                  usua_nombre AS Nombre,
                  usua_apellido AS Apellido,
                  usua_dni AS DNI,
                  cont_mail AS Mail,
                  cont_telefono AS Telefono,
                  cont_domicilio AS Domicilio,
                  usua_fecha_nacimiento AS Fecha_Nac,
                  chof_habilitado AS Chofer_Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
            JOIN LOS_MODERADAMENTE_ADECUADOS.Contacto ON (cont_id = usua_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ON (chof_id = usua_id)
          WHERE usua_id = @id)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_AUTOS_CON_FILTROS ( @modelo varchar(255),
                                                                    @patente varchar(10),
                                                                    @marca varchar(255),
                                                                    @DNIchofer NUMERIC(18,0))
RETURNS TABLE
AS
  RETURN (SELECT  vehi_id,
                  vehi_chofer,
                  vehi_turno,
                  vehi_patente AS Patente,
                  vehi_licencia AS Licencia,
                  vehi_rodado AS Rodado,
                  mode_codigo AS Modelo,
                  marc_nombre AS Marca,
                  (usua_apellido + ', ' + usua_nombre) AS Chofer,
                  usua_dni AS DNI_Chofer,
                  turn_descripcion AS Turno,
                  vehi_habilitado AS Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
            JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ON (vehi_chofer = chof_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario ON (chof_id = usua_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON (vehi_modelo = mode_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON (mode_marca = marc_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON (turn_id = vehi_turno)
          WHERE (@modelo = '' OR CHARINDEX(@modelo, mode_codigo) > 0)
            AND (@patente = '' OR CHARINDEX(@patente, vehi_patente) > 0)
            AND (@marca = '' OR @marca = marc_nombre)
            AND (@DNIchofer = 0 OR usua_dni = @DNIchofer))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS (@nombre varchar(255),
                                                                      @apellido varchar(255),
                                                                      @dni numeric(18,0))
RETURNS TABLE
AS
  RETURN (SELECT  usua_id,
                  usua_apellido AS Apellido,
                  usua_nombre AS Nombre,
                  usua_dni AS DNI,
                  cont_mail AS Mail,
                  cont_telefono AS Telefono,
                  cont_domicilio AS Domicilio,
                  usua_fecha_nacimiento AS Fecha_Nac,
                  logi_habilitado AS Usuario_Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
            JOIN LOS_MODERADAMENTE_ADECUADOS.Contacto ON (cont_id = usua_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Login_Usuario ON (logi_id = usua_id)
          WHERE (@nombre = '' OR CHARINDEX(@nombre, usua_nombre) > 0)
            AND (@apellido = '' OR CHARINDEX(@apellido, usua_apellido) > 0)
            AND (@dni = 0 OR @dni = usua_dni))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_CHOFERES_CON_FILTROS (@nombre varchar(255),
                                                                      @apellido varchar(255),
                                                                      @dni numeric(18,0))
RETURNS TABLE
AS
  RETURN (SELECT  u.*, chof_habilitado AS Chofer_Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS (@nombre, @apellido, @dni) u
            JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ON usua_id = chof_id)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_CLIENTES_CON_FILTROS (@nombre varchar(255),
                                                                      @apellido varchar(255),
                                                                      @dni numeric(18,0))
RETURNS TABLE
AS
  RETURN (SELECT  u.*, clie_codigo_postal AS Codigo_Postal, clie_habilitado AS Cliente_Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS (@nombre, @apellido, @dni) u
            JOIN LOS_MODERADAMENTE_ADECUADOS.Cliente ON usua_id = clie_id)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_NO_CHOFERES_CON_FILTROS ( @nombre varchar(255),
                                                                          @apellido varchar(255),
                                                                          @dni numeric(18,0))
RETURNS TABLE
AS
  RETURN (SELECT *
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS(@nombre, @apellido, @dni)
          WHERE usua_id NOT IN (SELECT chof_id
                                FROM LOS_MODERADAMENTE_ADECUADOS.Chofer))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_NO_CLIENTES_CON_FILTROS ( @nombre varchar(255),
                                                                          @apellido varchar(255),
                                                                          @dni numeric(18,0))
RETURNS TABLE
AS
  RETURN (SELECT *
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS(@nombre, @apellido, @dni)
          WHERE usua_id NOT IN (SELECT clie_id
                                FROM LOS_MODERADAMENTE_ADECUADOS.Cliente))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TURNOS_CON_FILTROS (@descripcion varchar(255))
RETURNS TABLE
AS
  RETURN (SELECT  turn_id,
                  turn_hora_inicio AS Hora_Inicio,
                  turn_hora_fin AS Hora_Fin,
                  turn_descripcion AS Descripcion,
                  turn_valor_kilometro AS Valor_Km,
                  turn_precio_base AS Precio_Base,
                  turn_habilitado AS Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Turno
          WHERE @descripcion = ''
            OR CHARINDEX(@descripcion, turn_descripcion) > 0)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.TURNO_GET(@id INT) RETURNS TABLE
AS
  RETURN (SELECT  turn_id,
                  turn_hora_inicio AS Hora_Inicio,
                  turn_hora_fin AS Hora_Fin,
                  turn_descripcion AS Descripcion,
                  turn_valor_kilometro AS Valor_Km,
                  turn_precio_base AS Precio_Base,
                  turn_habilitado AS Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Turno
          WHERE turn_id = @id)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.AUTOMOVIL_GET_DE (@idChofer INT)
RETURNS TABLE
AS
  RETURN (SELECT  vehi_id,
                  vehi_chofer,
                  vehi_turno,
                  vehi_patente AS Patente,
                  vehi_licencia AS Licencia,
                  vehi_rodado AS Rodado,
                  mode_codigo AS Modelo,
                  marc_nombre AS Marca,
                  turn_descripcion AS Turno,
                  vehi_habilitado AS Habilitado
          FROM LOS_MODERADAMENTE_ADECUADOS.Vehiculo
            JOIN LOS_MODERADAMENTE_ADECUADOS.Chofer ON (vehi_chofer = chof_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Modelo ON (vehi_modelo = mode_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Marca ON (mode_marca = marc_id)
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON (turn_id = vehi_turno)
          WHERE chof_id = @idChofer
            AND vehi_habilitado = 1)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_MAYOR_RECAUDACION (@anio INT,
                                                                                  @trimestre TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT TOP 5  usua_apellido AS Apellido,
                        usua_nombre AS Nombre,
                        usua_dni AS DNI,
                        sum(rend_importe_total) AS Recaudado
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
            JOIN LOS_MODERADAMENTE_ADECUADOS.Rendicion ON (usua_id = rend_chofer)
          WHERE YEAR(rend_fecha) = @anio
            AND MONTH(rend_fecha) BETWEEN (3 * @trimestre - 2) AND (3 * @trimestre)
          GROUP BY usua_apellido, usua_nombre, usua_dni
          ORDER BY sum(rend_importe_total) DESC)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CHOFER_VIAJE_MAS_LARGO (@anio INT,
                                                                                @trimestre TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT TOP 5  usua_apellido AS Apellido,
                        usua_nombre AS Nombre,
                        usua_dni AS DNI,
                        MAX(viaj_kms) AS Cantidad_Kms,
                        (SELECT TOP 1 CONVERT(DATE, viaj_inicio)
                          FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
                          WHERE viaj_chofer = u.usua_id
                            AND YEAR(viaj_inicio) = @anio
                            AND MONTH(viaj_inicio) BETWEEN (3*@trimestre - 2) AND (3*@trimestre)
                            AND viaj_kms = (SELECT MAX(viaj_kms)
                                            FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
                                            WHERE viaj_chofer = u.usua_id
                                              AND YEAR(viaj_inicio) = @anio
                                              AND MONTH(viaj_inicio) BETWEEN (3*@trimestre - 2) AND (3*@trimestre))) AS Fecha_Viaje
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario u
            JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON (usua_id = viaj_chofer)
          WHERE YEAR(viaj_inicio) = @anio
            AND MONTH(viaj_inicio) BETWEEN (3*@trimestre - 2) AND (3*@trimestre)
          GROUP BY usua_apellido, usua_nombre, usua_dni, usua_id
          ORDER BY MAX(viaj_kms) DESC)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_CONSUMO(@anio INT,
                                                                              @trimestre TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT TOP 5  usua_apellido AS Apellido,
                        usua_nombre AS Nombre,
                        usua_dni AS DNI,
                        sum(fact_importe_total) AS Consumido
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
            JOIN LOS_MODERADAMENTE_ADECUADOS.Factura ON fact_cliente = usua_id
          WHERE YEAR(fact_fecha_inicio) = @anio
            AND MONTH(fact_fecha_inicio) BETWEEN (3*@trimestre - 2) AND (3*@trimestre)
          GROUP BY usua_apellido, usua_nombre, usua_dni
          ORDER BY sum(fact_importe_total) DESC)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.ESTADISTICA_CLIENTE_MAYOR_USO_MISMO_VEHICULO( @anio INT,
                                                                                          @trimestre TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT TOP 5  usua_apellido AS Apellido,
                        usua_nombre AS Nombre,
                        usua_dni AS DNI,
                        count(*) AS Cantidad_de_Veces,
                        vehi_patente AS Patente_Vehiculo
          FROM LOS_MODERADAMENTE_ADECUADOS.Usuario
            JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON viaj_cliente = usua_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON viaj_vehiculo = vehi_id
          WHERE YEAR(viaj_inicio) = @anio
            AND MONTH(viaj_inicio) BETWEEN (3*@trimestre - 2) AND (3*@trimestre)
          GROUP BY usua_apellido, usua_nombre, usua_dni, vehi_patente
          ORDER BY count(*) DESC)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET(@idCliente INT,
                                                        @fecha DATETIME)
RETURNS TABLE
AS
  RETURN (SELECT  fact_numero,
                  fact_fecha_inicio,
                  fact_fecha_fin,
                  fact_importe_total
          FROM LOS_MODERADAMENTE_ADECUADOS.Factura
          WHERE fact_cliente = @idCliente
          AND @fecha BETWEEN fact_fecha_inicio AND fact_fecha_fin)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.FACTURA_GET_VIAJES(@idFactura INT)
RETURNS TABLE
AS
  RETURN (SELECT  chofer.usua_apellido AS Apellido_Chofer,
                  chofer.usua_nombre AS Nombre_Chofer,
                  chofer.usua_dni AS DNI_Chofer,
                  vehi_patente AS Patente,
                  viaj_inicio AS Inicio,
                  viaj_fin AS Fin,
                  turn_descripcion AS Turno,
                  viaj_kms AS Kms,
                  turn_precio_base AS Precio_Base,
                  turn_valor_kilometro AS Valor_Kilometro,
                  (turn_valor_kilometro * viaj_kms + turn_precio_base) AS Monto
          FROM LOS_MODERADAMENTE_ADECUADOS.Item_Factura
            JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON cod_viaje = viaj_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON viaj_vehiculo = vehi_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario chofer ON chofer.usua_id = viaj_chofer
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON viaj_turno = turn_id
          WHERE cod_factura = @idFactura)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CLIENTE(@idCliente INT,
                                                                  @fecha DATETIME)
RETURNS TABLE
AS
  RETURN (SELECT  chofer.usua_apellido AS Apellido_Chofer,
                  chofer.usua_nombre AS Nombre_Chofer,
                  chofer.usua_dni AS DNI_Chofer,
                  vehi_patente AS Patente,
                  viaj_inicio AS Inicio,
                  viaj_fin AS Fin,
                  turn_descripcion AS Turno,
                  viaj_kms AS Kms,
                  turn_precio_base AS Precio_Base,
                  turn_valor_kilometro AS Valor_Kilometro,
                  (turn_valor_kilometro * viaj_kms + turn_precio_base) AS Monto
          FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
            JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON viaj_vehiculo = vehi_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario chofer ON chofer.usua_id = viaj_chofer
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON viaj_turno = turn_id
          WHERE viaj_cliente = @idCliente
            AND MONTH(viaj_inicio) = MONTH(@fecha)
            AND YEAR(viaj_inicio) = YEAR(@fecha))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.VIAJES_GET_DE_CHOFER( @idChofer INT,
                                                                  @fecha DATETIME,
                                                                  @turno TINYINT,
                                                                  @porcentaje NUMERIC(2,2))
RETURNS TABLE
AS
  RETURN (SELECT  cliente.usua_apellido AS Apellido_Cliente,
                  cliente.usua_nombre AS Nombre_Cliente,
                  cliente.usua_dni AS DNI_Cliente,
                  vehi_patente AS Patente,
                  viaj_inicio AS Inicio,
                  viaj_fin AS Fin,
                  turn_descripcion AS Turno,
                  viaj_kms AS Kms,
                  turn_precio_base AS Precio_Base,
                  turn_valor_kilometro AS Valor_Kilometro,
                  (turn_valor_kilometro * viaj_kms + turn_precio_base) * @porcentaje AS Monto
          FROM LOS_MODERADAMENTE_ADECUADOS.Viaje
            JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON viaj_vehiculo = vehi_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON cliente.usua_id = viaj_cliente
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON viaj_turno = turn_id
          WHERE viaj_chofer = @idChofer
            AND CONVERT(DATE, viaj_inicio) = CONVERT(DATE, @fecha)
            AND viaj_turno = @turno)

GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.FUNCIONALIDADES_GET_TABLA_DE_ROL(@idRol TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT  func_id,
                  func_descripcion AS Descripcion, 
                  Habilitado = CONVERT(BIT, CASE
                                              WHEN (@idRol IN ( SELECT cod_rol
                                                                FROM LOS_MODERADAMENTE_ADECUADOS.Funcionalidad_X_Rol
                                                                WHERE cod_func = func_id)) THEN 1
                                              ELSE 0
                                            END)
          FROM LOS_MODERADAMENTE_ADECUADOS.Funcionalidad f)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET(@idChofer INT,
                                                          @fecha DATETIME,
                                                          @turno TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT  rend_numero,
                  rend_fecha,
                  rend_turno,
                  rend_importe_total,
                  rend_porcentaje
          FROM LOS_MODERADAMENTE_ADECUADOS.Rendicion
          WHERE rend_chofer = @idChofer
            AND CONVERT(DATE, @fecha) = CONVERT(DATE, rend_fecha)
            AND rend_turno = @turno)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.RENDICION_GET_VIAJES( @idRendicion INT)
RETURNS TABLE
AS
  RETURN (SELECT  cliente.usua_apellido AS Apellido_Cliente,
                  cliente.usua_nombre AS Nombre_Cliente,
                  cliente.usua_dni AS DNI_Cliente,
                  vehi_patente AS Patente,
                  viaj_inicio AS Inicio,
                  viaj_fin AS Fin,
                  turn_descripcion AS Turno,
                  viaj_kms AS Kms,
                  turn_precio_base AS Precio_Base,
                  turn_valor_kilometro AS Valor_Kilometro,
                  (turn_valor_kilometro * viaj_kms + turn_precio_base) * rend_porcentaje AS Monto
          FROM LOS_MODERADAMENTE_ADECUADOS.Rendicion
            JOIN LOS_MODERADAMENTE_ADECUADOS.Item_Rendicion ON cod_rend = rend_numero
            JOIN LOS_MODERADAMENTE_ADECUADOS.Viaje ON cod_viaje = viaj_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Vehiculo ON viaj_vehiculo = vehi_id
            JOIN LOS_MODERADAMENTE_ADECUADOS.Usuario cliente ON cliente.usua_id = viaj_cliente
            JOIN LOS_MODERADAMENTE_ADECUADOS.Turno ON viaj_turno = turn_id
          WHERE rend_numero = @idRendicion)
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_USUARIOS (@nombre varchar(255),
                                                                    @apellido varchar(255),
                                                                    @dni numeric(18,0),
                                                                    @rol TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT  usua_id,
                  Apellido,
                  Nombre,
                  DNI,
                  Habilitado = CONVERT(BIT, CASE
                                              WHEN (usua_id IN (SELECT cod_login
                                                                FROM LOS_MODERADAMENTE_ADECUADOS.Rol_X_Login_Usuario
                                                                WHERE cod_rol = @rol)) THEN 1
                                              ELSE 0
                                            END)
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_USUARIOS_CON_FILTROS(@nombre, @apellido, @dni))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CHOFERES (@nombre varchar(255),
                                                                    @apellido varchar(255),
                                                                    @dni numeric(18,0),
                                                                    @rol TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT  *
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_USUARIOS(@nombre, @apellido, @dni, @rol)
          WHERE usua_id IN (SELECT chof_id
                            FROM LOS_MODERADAMENTE_ADECUADOS.Chofer))
GO

CREATE FUNCTION LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_CLIENTES (@nombre varchar(255),
                                                                    @apellido varchar(255),
                                                                    @dni numeric(18,0),
                                                                    @rol TINYINT)
RETURNS TABLE
AS
  RETURN (SELECT  *
          FROM LOS_MODERADAMENTE_ADECUADOS.GET_TABLA_ROL_USUARIOS(@nombre, @apellido, @dni, @rol)
          WHERE usua_id IN (SELECT clie_id
                            FROM LOS_MODERADAMENTE_ADECUADOS.Cliente))
GO
