CREATE DATABASE dboCreacionEventos

use dboCreacionEventos

CREATE TABLE tblUsuario (
    cod_usuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre_usuario VARCHAR(100) NOT NULL,
    correo VARCHAR(255) NOT NULL,
    contrasena_encriptada VARCHAR(255) NOT NULL
);

CREATE TABLE tblEvento (
    cod_evento INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	tipo_evento varchar (55) not null,
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    ubicacion VARCHAR(255) NOT NULL,
    invitados_aprox INT NOT NULL,
    descripcion VARCHAR(MAX) NOT NULL,
    cod_usuario INT NOT NULL FOREIGN KEY REFERENCES tblUsuario(cod_usuario)
);

CREATE TABLE tblInvitado (
    cod_invitado INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    cod_evento INT NOT NULL FOREIGN KEY REFERENCES tblEvento(cod_evento),
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(255) NOT NULL,
    telefono VARCHAR(20) NOT NULL
);

CREATE TABLE tblHistorial (
    cod_historial INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    cod_evento INT NOT NULL FOREIGN KEY REFERENCES tblEvento(cod_evento),
    cod_usuario INT NOT NULL FOREIGN KEY REFERENCES tblUsuario(cod_usuario),
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    ubicacion VARCHAR(255) NOT NULL,
    invitados_aprox INT NOT NULL,
    descripcion VARCHAR(MAX) NOT NULL
);

CREATE TABLE tblNivelEvento (
    cod_nivel INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre_nivel VARCHAR(50) NOT NULL,
    precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE tblTareaEvento (
    cod_tarea INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    cod_evento INT NOT NULL FOREIGN KEY REFERENCES tblEvento(cod_evento),
    descripcion_tarea VARCHAR(255) NOT NULL,
    cod_nivel INT NOT NULL FOREIGN KEY REFERENCES tblNivelEvento(cod_nivel)
);

CREATE TABLE tblEventoUsuario (
    cod_evento INT NOT NULL FOREIGN KEY REFERENCES tblEvento(cod_evento),
    cod_usuario INT NOT NULL FOREIGN KEY REFERENCES tblUsuario(cod_usuario),
    PRIMARY KEY (cod_evento, cod_usuario)
);