USE MASTER;
-------------------------------------------SE ELIMINA LA BASE DE DATOS EN CASO DE EXISTIR------------------------------------
DROP DATABASE IF EXISTS JPS_Loteria_Chances;
GO
-------------------------------------------SE CREA LA BASE DE DATOS JPS_Loteria_Chances--------------------------------------
CREATE DATABASE JPS_Loteria_Chances;
GO

USE JPS_Loteria_Chances;
GO

-------------------------------------------SE CREAN LAS TABLAS QUE UTILIZA EL PROGRAMA---------------------------------------

-------------------SE CREA LA TABLA Sorteos-------------------------
IF object_id(N'dbo.Sorteos',N'Table') IS NOT NULL
    DROP TABLE Sorteos;
GO
CREATE TABLE Sorteos(
    Id                  INT IDENTITY PRIMARY KEY,
    Numero              INT NOT NULL,
    Tipo                NVARCHAR(100) NOT NULL,
    Fecha               DATETIME NOT NULL,
    CantidadFracciones  INT NOT NULL,
    PrecioFraccion      INT NOT NULL,
    Leyenda             NVARCHAR(100),
    Estado              BIT NOT NULL
);

-------------------SE CREA LA TABLA Planes_De_Premios---------------
IF object_id(N'dbo.Planes_De_Premios',N'Table') IS NOT NULL
    DROP TABLE Planes_De_Premios;
GO
CREATE TABLE Planes_De_Premios(
    Id                  INT IDENTITY PRIMARY KEY,
    IdSorteo            INT NOT NULL FOREIGN KEY REFERENCES Sorteos(Id),
    Monto               INT NOT NULL,
    Cantidad            INT NOT NULL
);

-------------------SE CREA LA TABLA Resultados----------------------
IF object_id(N'dbo.Resultados',N'Table') IS NOT NULL
    DROP TABLE Resultados;
GO
CREATE TABLE Resultados(
    Id                  INT IDENTITY PRIMARY KEY,
    IdSorteo            INT NOT NULL FOREIGN KEY REFERENCES Sorteos(Id),
    MontoGanado         INT NOT NULL,
    NumeroGanador       INT NOT NULL,
    SerieGanadora       INT NOT NULL
);

-------------------SE CREA LA TABLA Usuarios------------------------
IF object_id(N'dbo.Usuarios',N'Table') IS NOT NULL
    DROP TABLE Usuarios;
GO
CREATE TABLE Usuarios(
    Id                  INT IDENTITY PRIMARY KEY,
    NombreUsuario       NVARCHAR(100) NOT NULL,
    Contrasenia         NVARCHAR(100) NOT NULL,
    Rol                 BIT NOT NULL
);

-------------------------------------------SE CREAN LOS PROCEDIMIENTOS ALMACENADOS-------------------------------------------

-------------------SE CREA EL PROCEDIMIENTO DE InsertarSorteo-------
IF object_id(N'dbo.InsertarSorteo',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE InsertarSorteo;
GO
CREATE PROCEDURE InsertarSorteo
    @Numero             INT,
    @Tipo               NVARCHAR(100),
    @Fecha              DATETIME,
    @CantidadFracciones INT,
    @PrecioFraccion     INT,
    @Leyenda            NVARCHAR(100),
    @Estado             BIT
AS
BEGIN
    INSERT INTO Sorteos(Numero, Tipo, Fecha, CantidadFracciones, PrecioFraccion, Leyenda, Estado)
    VALUES(@Numero, @Tipo, @Fecha, @CantidadFracciones, @PrecioFraccion, @Leyenda, @Estado)
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE InsertarPlanDePremios-
IF object_id(N'dbo.InsertarPlanDePremios',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE InsertarPlanDePremios;
GO
CREATE PROCEDURE InsertarPlanDePremios
    @IdSorteo           INT,
    @Monto              INT,
    @Cantidad           INT
AS
BEGIN
    INSERT INTO Planes_De_Premios(IdSorteo, Monto, Cantidad)
    VALUES(@IdSorteo, @Monto, @Cantidad)
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE InsertarResultado-----
IF object_id(N'dbo.InsertarResultado',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE InsertarResultado;
GO
CREATE PROCEDURE InsertarResultado
    @IdSorteo           INT,
    @MontoGanado        INT,
    @NumeroGanador      INT,
    @SerieGanadora      INT
AS
BEGIN
    INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora)
    VALUES(@IdSorteo, @MontoGanado, @NumeroGanador, @SerieGanadora)
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE ActualizarSorteo------
IF object_id(N'dbo.ActualizarSorteo',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE ActualizarSorteo;
GO
CREATE PROCEDURE ActualizarSorteo
    @Id                 INT,
    @Numero             INT,
    @Tipo               NVARCHAR(100),
    @Fecha              DATETIME,
    @CantidadFracciones INT,
    @PrecioFraccion     INT,
    @Leyenda            NVARCHAR(100)
AS
BEGIN
    UPDATE Sorteos
    SET Fecha = @Fecha, CantidadFracciones = @CantidadFracciones, PrecioFraccion = @PrecioFraccion, Leyenda = @Leyenda
    WHERE Id = @Id
END
GO

  
-------------------SE CREA EL PROCEDIMIENTO DE EstablecerSorteoJugado-
IF object_id(N'dbo.EstablecerSorteoJugado',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE EstablecerSorteoJugado;
GO
CREATE PROCEDURE EstablecerSorteoJugado
    @Id             INT
AS
BEGIN
    UPDATE Sorteos
    SET Estado = 1
    WHERE Id = @Id
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE ActualizarPlanDePremios-
IF object_id(N'dbo.ActualizarPlanDePremios',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE ActualizarPlanDePremios;
GO
CREATE PROCEDURE ActualizarPlanDePremios
    @Id                 INT,
    @IdSorteo           INT,
    @Monto              INT,
    @Cantidad           INT
AS
BEGIN
    UPDATE Planes_De_Premios
    SET Monto = @Monto, Cantidad = @Cantidad
    WHERE Id = @Id
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE EliminarSorteo---------
IF object_id(N'dbo.EliminarSorteo',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE EliminarSorteo;
GO
CREATE PROCEDURE EliminarSorteo
    @IdSorteo           INT
AS
BEGIN
    DELETE FROM Planes_De_Premios WHERE IdSorteo = @IdSorteo
    DELETE FROM Sorteos WHERE Id=@IdSorteo
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE EliminarPlanDePremios--
IF object_id(N'dbo.EliminarPlanDePremios',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE EliminarPlanDePremios;
GO
CREATE PROCEDURE EliminarPlanDePremios
    @IdSorteo           INT
AS
BEGIN
    DELETE FROM Planes_De_Premios WHERE IdSorteo = @IdSorteo
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE ObtenerPlanDePremios---
IF object_id(N'dbo.ObtenerPlanDePremios',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE ObtenerPlanDePremios;
GO
CREATE PROCEDURE ObtenerPlanDePremios
    @IdSorteo           INT
AS
BEGIN
    SELECT Id, IdSorteo, Monto, Cantidad
    FROM Planes_De_Premios
    WHERE IdSorteo = @IdSorteo
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE ObtenerResultados------
IF object_id(N'dbo.ObtenerResultados',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE ObtenerResultados;
GO
CREATE PROCEDURE ObtenerResultados
    @IdSorteo           INT
AS
BEGIN
    SELECT MontoGanado, NumeroGanador, SerieGanadora
    FROM Resultados
    WHERE IdSorteo = @IdSorteo
END
GO
-------------------SE CREA EL PROCEDIMIENTO DE Top5NumerosConPrimerPremioFiltro------

IF object_id(N'dbo.Top5NumerosConPrimerPremioFiltro',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE Top5NumerosConPrimerPremioFiltro;
GO
CREATE PROCEDURE Top5NumerosConPrimerPremioFiltro
    @Tipo      NVARCHAR(100)     
AS
BEGIN
    SELECT TOP 5 NumeroGanador, Cantidad
    FROM
    (SELECT R1.NumeroGanador, COUNT(R1.NumeroGanador) AS Cantidad
    FROM Resultados AS R1 INNER JOIN Sorteos as S ON R1.IdSorteo = S.Id 
    WHERE R1.MontoGanado = (SELECT TOP 1 R2.MontoGanado FROM Resultados AS R2 WHERE R1.IdSorteo = R2.IdSorteo ORDER BY R2.MontoGanado DESC) and S.Tipo = @Tipo
    GROUP BY R1.NumeroGanador) AS NCPP
	
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE Top5NumerosMasDineroRepartidoFiltro------
IF object_id(N'dbo.Top5NumerosMasDineroRepartidoFiltro',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE Top5NumerosMasDineroRepartidoFiltro;
GO
CREATE PROCEDURE Top5NumerosMasDineroRepartidoFiltro
    @Tipo      NVARCHAR(100)     
AS
BEGIN
    SELECT TOP 5 NMDR.NumeroGanador, NMDR.MontoRepartido
    FROM
    (SELECT R.NumeroGanador, SUM(R.MontoGanado) AS MontoRepartido
    FROM Resultados AS R INNER JOIN Sorteos as S ON R.IdSorteo = S.Id where S.Tipo = @Tipo
    GROUP BY R.NumeroGanador) AS NMDR
	ORDER BY NMDR.MontoRepartido DESC
	
END
GO

-------------------SE CREA EL PROCEDIMIENTO DE Top10NumerosMasJugadosFiltro------
IF object_id(N'dbo.Top10NumerosMasJugadosFiltro',N'PROCEDURE') IS NOT NULL
    DROP PROCEDURE Top10NumerosMasJugadosFiltro;
GO
CREATE PROCEDURE Top10NumerosMasJugadosFiltro
    @Tipo      NVARCHAR(100)     
AS
BEGIN
	SELECT TOP 10 NMJ.NumeroGanador, NMJ.Cantidad
    FROM
    (SELECT NumeroGanador, COUNT(R.NumeroGanador) AS Cantidad
    FROM Resultados AS R INNER JOIN Sorteos as S ON R.IdSorteo = S.Id where S.Tipo = @Tipo
    GROUP BY R.NumeroGanador) AS NMJ
	ORDER BY NMJ.Cantidad DESC
	
END
GO





-------------------------------------------SE CREAN LAS VISTAS---------------------------------------------------------------

-------------------SE CREA LA VISTA DE ObtenerSorteos-----------------
IF object_id(N'dbo.ObtenerSorteos',N'VIEW') IS NOT NULL
    DROP VIEW ObtenerSorteos;
GO
CREATE VIEW ObtenerSorteos
AS
    SELECT Id, Numero, Tipo, Fecha, CantidadFracciones, PrecioFraccion, Leyenda, Estado
    FROM Sorteos
GO
-------------------SE CREA LA VISTA DE Top5NumerosConPrimerPremio-----
IF object_id(N'dbo.Top5NumerosConPrimerPremio',N'VIEW') IS NOT NULL
    DROP VIEW Top5NumerosConPrimerPremio;
GO
CREATE VIEW Top5NumerosConPrimerPremio
AS
    SELECT TOP 5 NumeroGanador, Cantidad
    FROM
    (SELECT R1.NumeroGanador, COUNT(R1.NumeroGanador) AS Cantidad
    FROM Resultados AS R1
    WHERE R1.MontoGanado = (SELECT TOP 1 R2.MontoGanado FROM Resultados AS R2 WHERE R1.IdSorteo = R2.IdSorteo ORDER BY R2.MontoGanado DESC)
    GROUP BY R1.NumeroGanador) AS NCPP
GO

-------------------SE CREA LA VISTA DE Top5NumerosMasDineroRepartido--
IF object_id(N'dbo.Top5NumerosMasDineroRepartido',N'VIEW') IS NOT NULL
    DROP VIEW Top5NumerosMasDineroRepartido;
GO
CREATE VIEW Top5NumerosMasDineroRepartido
AS
    SELECT TOP 5 NMDR.NumeroGanador, NMDR.MontoRepartido
    FROM
    (SELECT R.NumeroGanador, SUM(R.MontoGanado) AS MontoRepartido
    FROM Resultados AS R INNER JOIN Sorteos as S ON R.IdSorteo = S.Id
    GROUP BY R.NumeroGanador) AS NMDR
	ORDER BY NMDR.MontoRepartido DESC
GO

-------------------SE CREA LA VISTA DE Top10NumerosMasJugados--
IF object_id(N'dbo.Top10NumerosMasJugados',N'VIEW') IS NOT NULL
    DROP VIEW Top10NumerosMasJugados;
GO
CREATE VIEW Top10NumerosMasJugados
AS
    SELECT TOP 10 NMJ.NumeroGanador, NMJ.Cantidad
    FROM
    (SELECT NumeroGanador, COUNT(R.NumeroGanador) AS Cantidad
    FROM Resultados AS R
    GROUP BY R.NumeroGanador) AS NMJ
	ORDER BY NMJ.Cantidad DESC
GO


-------------------SE CREA LA VISTA DE PorcentajeAparicionNumeros-
IF object_id(N'dbo.PorcentajeAparicionNumeros',N'VIEW') IS NOT NULL
    DROP VIEW PorcentajeAparicionNumeros;
GO
CREATE VIEW PorcentajeAparicionNumeros
AS
    SELECT R.NumeroGanador, COUNT(R.NumeroGanador) / COUNT(*) AS Porcentaje
    FROM Resultados AS R
    GROUP BY R.NumeroGanador
    ORDER BY Porcentaje DESC OFFSET 0 ROWS
GO

-------------------------------------------SE INSERTAN LOS DATOS POR DEFECTO-------------------------------------------------

-------------------SE INSERTA LOS USUARIOS POR DEFECTO-----------------
INSERT INTO Usuarios(NombreUsuario, Contrasenia, Rol) VALUES('admin', 'admin', 1)
INSERT INTO Usuarios(NombreUsuario, Contrasenia, Rol) VALUES('usuario', 'usuario', 0)






--ESTO NO

 INSERT INTO Sorteos(Numero, Tipo, Fecha, CantidadFracciones, PrecioFraccion, Leyenda, Estado)
    VALUES(1,'Chances','10/29/2019',30,2500,'Sin leyenda',0)

	

	-- Loteria #1
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 1000000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 500000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 250000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 100000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 100000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 100000, 30, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 50000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 50000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 50000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(1, 50000, 20, 100)

	--Loteria #2
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 2000000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 1500000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 1000000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 500000, 30, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 500000, 40, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 500000, 50, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 500000, 50, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 500000, 50, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 250000, 30, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 250000, 30, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 250000, 30, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 250000, 40, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 250000, 40, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 100000, 40, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(2, 100000, 50, 100)

	--Chances #1
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(3, 5000000, 10, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(3, 2500000, 20, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(3, 1000000, 30, 100)

	--Chances #2
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(4, 10000000, 50, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(4, 5000000, 50, 100)
	INSERT INTO Resultados(IdSorteo, MontoGanado, NumeroGanador, SerieGanadora) VALUES(4, 2500000, 50, 100)




