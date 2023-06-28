CREATE DATABASE DB_UNIVERSIDAD;

USE DB_UNIVERSIDAD;

CREATE TABLE estudiante
(
	id_estudiante varchar(15) primary key,
	nombre varchar(50) not null,
	apellido varchar(70) not null,
	telefono varchar(20),
	edad int
)
select * from estudiante;

INSERT INTO estudiante values ('1', 'Carlos', 'Ramirez', '22222', 21);
INSERT INTO estudiante values ('2', 'Alejandro', 'Cardona', '33333', 22);

-- PROCEDIMIENTOS ALMACENADOS

CREATE PROCEDURE USP_INSERTAR_EST
(
	@id_estudiante varchar(50),
	@nombre varchar(50),
	@apellido varchar(70),
	@telefono varchar(20),
	@edad int 
)
AS
BEGIN
	INSERT INTO estudiante values (@id_estudiante, @nombre, @apellido, @telefono, @edad);
END

-- EJECUTAR EL PROCEDIMIENTO ALMACENADO

EXECUTE USP_INSERTAR_EST '4', 'Juan', 'Perez', '88888', 25;

CREATE PROCEDURE USP_ACTUALIZAR_EST
(
	@id_estudiante varchar(50),
	@nombre varchar(50),
	@apellido varchar(70),
	@telefono varchar(20),
	@edad int 
)
AS
BEGIN
	UPDATE estudiante SET nombre = @nombre, apellido = @apellido,  telefono = @telefono, edad = @edad WHERE id_estudiante = @id_estudiante;
END

EXECUTE USP_ACTUALIZAR_EST '1', 'Pedro', 'Hoyos', '99999', '25';
select * from estudiante;

CREATE PROCEDURE USP_OBTENER_EST
(
	@id_estudiante varchar(50)
)
AS
BEGIN
	SELECT * FROM estudiante where id_estudiante = @id_estudiante;
END

EXECUTE USP_OBTENER_EST '1';

CREATE PROCEDURE USP_ELIMINAR_EST
(
	@id_estudiante varchar(50)
)
AS
BEGIN
	DELETE FROM estudiante where id_estudiante = @id_estudiante;
END

EXECUTE USP_ELIMINAR_EST '';

CREATE PROCEDURE USP_LISTA_EST
AS
BEGIN
	SELECT * FROM estudiante;
END

EXECUTE USP_LISTA_EST;

SELECT * FROM estudiante;
