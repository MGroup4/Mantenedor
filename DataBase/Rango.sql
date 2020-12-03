/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Rango]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Rango]
GO

/* Create Table */

CREATE TABLE [Rango]
(
	RangoID int NOT NULL,
	Nombre varchar(50) NOT NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Rango] 
 ADD CONSTRAINT [PK_Rango]
	PRIMARY KEY CLUSTERED ([RangoID] ASC)
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_RANGO
AS
SELECT * FROM Rango
GO

CREATE PROCEDURE SPINSERTAR_RANGO
@RangoID int,
@Nombre varchar(50)
AS
INSERT INTO Rango VALUES (@RangoID,@Nombre)
GO

CREATE PROCEDURE SPEDITAR_RANGO
@RangoID int,
@Nombre varchar(50)
AS
UPDATE Rango SET 
Nombre = @Nombre
WHERE RangoID = @RangoID
GO

CREATE PROCEDURE SPELIMINAR_RANGO
@RangoID int
AS
DELETE FROM Rango WHERE RangoID = @RangoID
GO