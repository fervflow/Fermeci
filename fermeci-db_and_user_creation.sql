-- Script de creacion de base de datos y login correspondiente.
-- Se puede ejecutar todo el script sin intervencion.
-- BORRARA LA BASE DE DATOS LLAMADA fermeci
USE master;

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'fermeci')
BEGIN
	USE master;
	ALTER DATABASE fermeci SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE fermeci;
END
GO

CREATE DATABASE fermeci;
GO

USE fermeci;

CREATE TABLE personal(
	id_personal		INT IDENTITY(1,1) PRIMARY KEY,
	ci				VARCHAR(15) UNIQUE,
	nombre			VARCHAR(40),
	apellido		VARCHAR(40),
	direccion		VARCHAR(50),
	telefono		VARCHAR(15),
	usuario			VARCHAR(20) UNIQUE,
	codigo_acceso	VARCHAR(20),
);
GO

CREATE TABLE propiertario(
	id_propietario	INT PRIMARY KEY,
	FOREIGN KEY (id_propietario) REFERENCES personal(id_personal),
	
);
CREATE TABLE empleado(
	id_empleado		INT PRIMARY KEY,
    tuno            VARCHAR(10),
	FOREIGN KEY (id_empleado) REFERENCES personal(id_personal),
);
CREATE TABLE proveedor(
	id_proveedor	INT identity(1,1) PRIMARY KEY,
	nombre			VARCHAR(40),
	direccion		VARCHAR(50),
	telefono		VARCHAR(15),
	ubicacion		VARCHAR(50),
);
CREATE TABLE cliente(
	id_cliente  	INT identity(1,1) PRIMARY KEY,
	ci				VARCHAR(15) UNIQUE,
	nombres			VARCHAR(40),
	apellidos		VARCHAR(40),
	direccion		VARCHAR(50),
	telefono		VARCHAR(15),
);

CREATE TABLE tipo_producto(
    tipo    VARCHAR(30) PRIMARY KEY,
	codigo	VARCHAR(5) NOT NULL,
);
GO

CREATE TABLE producto_proveedor(
    id_proveedor INT FOREIGN KEY REFERENCES proveedor(id_proveedor),
    tipo_producto VARCHAR(30) FOREIGN KEY REFERENCES tipo_producto(tipo),
);
GO

CREATE TABLE producto(
    id_producto     INT IDENTITY(1, 1) PRIMARY KEY,
	codigo_producto VARCHAR(60),
    nombre          VARCHAR(30),
    tipo            VARCHAR(30) FOREIGN KEY REFERENCES tipo_producto(tipo),
    marca           VARCHAR(20),
    cantidad        INT,
    precio_compra   MONEY,
    precio_venta    MONEY,
    descripcion     TEXT,
);
GO

CREATE TABLE venta(
    id_venta    INT IDENTITY(1, 1) PRIMARY KEY,
    id_cliente  INT FOREIGN KEY REFERENCES cliente(id_cliente),
    fecha       DATE,
    hora        TIME,
    detalle     TEXT,
    monto_total MONEY,
    tipo_pago   VARCHAR(20),
    estado_venta VARCHAR(20),
);
GO

CREATE TABLE detalle_venta(
    id_venta        INT FOREIGN KEY REFERENCES venta(id_venta),
    id_producto     INT FOREIGN KEY REFERENCES producto(id_producto),
    nombre_producto VARCHAR(30),
    cantidad        INT,
    precio_total    MONEY,
);
GO

INSERT INTO personal VALUES
	('1010', 'Erick', 'Velasco Flores', 'Av. los Ilustres #204', '61626364', 'erick', '123'),
	('2020', 'Fernando', 'Alonso', 'Av. Murillo #1', '70707171', 'feral', '321'),
	('3030', 'Maria', 'Martinez', 'Calle Oruro #99', '62-2-3030', 'marimar', 'mari123');
GO

INSERT INTO propiertario VALUES (1),(3);
INSERT INTO empleado VALUES (2, 'Tarde');

INSERT INTO tipo_producto VALUES
    ('HERRAMIENTAS', 'HRRTS'),
    ('PINTURAS', 'PINTS'),
    ('ACCESORIOS DE PINTURA', 'APINT'),
    ('ACCESORIOS DE BA�O', 'ABANO'),
    ('ACCESORIOS DE ELECTRICIDAD', 'AELEC');
GO

-- Creacion del login y usuario para la base de datos
USE master;
IF EXISTS (SELECT * FROM sys.server_principals WHERE name = 'fermeci_admin')
BEGIN
	DROP LOGIN fermeci_admin;
END
CREATE LOGIN fermeci_admin WITH PASSWORD = 'admin123', CHECK_POLICY = OFF;
GO
USE fermeci;
DROP USER IF EXISTS fermeci_admin;
GO
CREATE USER fermeci_admin FOR LOGIN fermeci_admin;
GO
ALTER USER fermeci_admin WITH DEFAULT_SCHEMA = [dbo];
ALTER ROLE [db_owner] ADD MEMBER fermeci_admin;
GO