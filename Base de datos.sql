

create database ProyectoFinal

use ProyectoFinal

CREATE TABLE EMPLEADOS(
	Id INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50),
	Apellido VARCHAR(50),
	Contraseña VARCHAR(50),
	Correo VARCHAR(100),	
	Cargo VARCHAR(50),
	Id_Departamento int
	)

CREATE TABLE Documentos(
	Id INT PRIMARY KEY IDENTITY,
	Id_Empleado INT,
	Nombre VARCHAR(120),
	Secuencia VARCHAR(60),
	Id_Departamento int,
	Fecha Date )

CREATE TABLE Departamentos(

	Id INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50),
	Siglas VARCHAR(15))
GO


CREATE PROCEDURE GuardarEmpleado @nombre VARCHAR(50), @apellido VARCHAR(50), @contraseña VARCHAR(50),
	@correo VARCHAR(100), @cargo VARCHAR(50), @id_departamento INT
AS

INSERT INTO EMPLEADOS(Nombre, Apellido, Contraseña, Correo, Cargo, Id_Departamento)
	VALUES (@nombre, @apellido, @contraseña, @correo, @cargo, @id_departamento)

GO

CREATE PROCEDURE CrearDepartamento @nombre VARCHAR(60), @siglas VARCHAR(15)
AS
INSERT INTO Departamentos(Nombre, Siglas)
	VALUES (@nombre, @siglas)
GO


CREATE PROCEDURE GuardarReporte @idEmpleado INT, @nombreReporte NVARCHAR(100), @depatamentoDestino INT
AS

DECLARE @idDeptOrigen INT
DECLARE @DeptOrigen NVARCHAR(15)
DECLARE @DeptDestino NVARCHAR(15)
DECLARE @secuencia NVARCHAR(50)

SELECT  @DeptOrigen = D.Siglas, @idDeptOrigen = D.Id FROM EMPLEADOS E JOIN Departamentos D
	ON (E.Id_Departamento = D.Id) WHERE E.Id = @idEmpleado

SELECT @DeptDestino = Siglas FROM Departamentos WHERE Id = @depatamentoDestino

DECLARE @cantidadReportes INT

SELECT @cantidadReportes = COUNT(Nombre) FROM  REPORTES WHERE Id_Departamento = @idDeptOrigen

SET @secuencia = CONVERT(VARCHAR,YEAR(GETDATE())) + 
	'-' + @DeptOrigen + '-' + @DeptDestino + '-0' + CONVERT(nvarchar, @cantidadReportes)

INSERT INTO REPORTES(Id_Empleado, Nombre, Secuencia, Id_Departamento, Fecha)
	VALUES (@idEmpleado, @nombreReporte, @secuencia, @idDeptOrigen,GETDATE())

GO


EXEC GuardarReporte 1, 'Ingresos',  4
GO



INSERT INTO Departamentos(Nombre, Siglas)
	VALUES ('Contabilidad', 'Cont')

INSERT INTO EMPLEADOS(Nombre, Apellido, Contraseña, Correo, Cargo, Id_Departamento)
	VALUES ('Juan', 'Ortiz', '12345', 'jortiz@hotmail.com', 'Contador', 1)

INSERT INTO REPORTES(Id_Empleado, Nombre, Secuencia, Id_Departamento, Fecha)
	VALUES (3, 'Reunion de hoy', '2021-IT-Fin-002', 1, '2021-04-20')

SELECT * FROM Departamentos
SELECT * FROM REPORTES
SELECT * FROM EMPLEADOS



SELECT E.Nombre, D.Nombre FROM EMPLEADOS E JOIN Departamentos D
	ON (E.Id_Departamento = D.Id)

