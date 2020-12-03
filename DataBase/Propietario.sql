/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Propietario_AgenteDeInmobiliaria]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Propietario] DROP CONSTRAINT [FK_Propietario_AgenteDeInmobiliaria]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Propietario]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Propietario]
GO

/* Create Table */

CREATE TABLE [Propietario]
(
	[PropietarioID] int NOT NULL,
	[AgenteDeInmobiliariaID] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[DNI] int NULL,
	[Telefono] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Propietario] 
 ADD CONSTRAINT [PK_Propietario]
	PRIMARY KEY CLUSTERED ([PropietarioID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Propietario] ADD CONSTRAINT [FK_Propietario_AgenteDeInmobiliaria]
	FOREIGN KEY ([AgenteDeInmobiliariaID]) REFERENCES [AgenteDeInmobiliaria] ([AgenteDeInmobiliariaID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_PROPIETARIO
AS
SELECT * FROM Propietario
GO

CREATE PROCEDURE SPINSERTAR_PROPIETARIO
@PropietarioID varchar,
@AgenteDeInmobiliariaID varchar,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
INSERT INTO Propietario VALUES (@PropietarioID,@AgenteDeInmobiliariaID,@Nombre,@DNI,@Telefono)
GO

CREATE PROCEDURE SPEDITAR_PROPIETARIO
@PropietarioID varchar,
@AgenteDeInmobiliariaID varchar,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
UPDATE Propietario
SET AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
Nombre = @Nombre,
DNI = @DNI,
Telefono = @Telefono
WHERE PropietarioID = @PropietarioID
GO

CREATE PROCEDURE SPELIMINAR_PROPIETARIO
@PropietarioID varchar
AS
DELETE FROM Propietario WHERE PropietarioID = @PropietarioID
GO