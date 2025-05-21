CREATE DATABASE RedSismica;
GO

USE RedSismica;
GO

-- Usuario
CREATE TABLE Usuario (
    idUsuario INT IDENTITY PRIMARY KEY,
    nombreUsuario NVARCHAR(50) NOT NULL,
    contraseña NVARCHAR(100) NOT NULL
);

-- Empleado
CREATE TABLE Empleado (
    idEmpleado INT IDENTITY PRIMARY KEY,
    mail NVARCHAR(100) NOT NULL,
    idRol INT
);

-- Rol
CREATE TABLE Rol (
    idRol INT IDENTITY PRIMARY KEY,
    nombre NVARCHAR(50) NOT NULL
);

-- Relación Empleado-Rol (1:1)
ALTER TABLE Empleado
ADD CONSTRAINT FK_Empleado_Rol FOREIGN KEY (idRol) REFERENCES Rol(idRol);

-- Sesion
CREATE TABLE Sesion (
    idSesion INT IDENTITY PRIMARY KEY,
    fechaHoraInicio DATETIME NOT NULL,
    fechaHoraFin DATETIME,
    idUsuario INT NOT NULL,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);

-- EstacionSismologica
CREATE TABLE EstacionSismologica (
    idEstacion INT IDENTITY PRIMARY KEY,
    codigoEstacion NVARCHAR(20) NOT NULL,
    nombre NVARCHAR(100) NOT NULL
);

-- Sismografo
CREATE TABLE Sismografo (
    idSismografo INT IDENTITY PRIMARY KEY,
    idEstacion INT NOT NULL,
    FOREIGN KEY (idEstacion) REFERENCES EstacionSismologica(idEstacion)
);

-- Estado
CREATE TABLE Estado (
    idEstado INT IDENTITY PRIMARY KEY,
    ambito NVARCHAR(50),
    nombreEstado NVARCHAR(50) NOT NULL
);

-- CambioEstado
CREATE TABLE CambioEstado (
    idCambioEstado INT IDENTITY PRIMARY KEY,
    idEstado INT NOT NULL,
    idSismografo INT NOT NULL,
    fechaHoraInicio DATETIME NOT NULL,
    fechaHoraFin DATETIME,
    FOREIGN KEY (idEstado) REFERENCES Estado(idEstado),
    FOREIGN KEY (idSismografo) REFERENCES Sismografo(idSismografo)
);

-- MotivoTipo
CREATE TABLE MotivoTipo (
    idMotivoTipo INT IDENTITY PRIMARY KEY,
    descripcion NVARCHAR(255) NOT NULL
);

-- MotivoFueraServicio
CREATE TABLE MotivoFueraServicio (
    idMotivo INT IDENTITY PRIMARY KEY,
    idMotivoTipo INT NOT NULL,
    comentario NVARCHAR(255),
    FOREIGN KEY (idMotivoTipo) REFERENCES MotivoTipo(idMotivoTipo)
);

-- OrdenInspeccion
CREATE TABLE OrdenInspeccion (
    idOrden INT IDENTITY PRIMARY KEY,
    nroOrden INT NOT NULL,
    fechaHoraInicio DATETIME,
    fechaHoraFinalizacion DATETIME,
    fechaHoraCierre DATETIME,
    observacionCierre NVARCHAR(255),
    idUsuario INT,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);

