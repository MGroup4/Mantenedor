/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Cliente_AgenteDeInmobiliaria]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Cliente] DROP CONSTRAINT [FK_Cliente_AgenteDeInmobiliaria]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Cliente]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Cliente]
GO

/* Create Table */

CREATE TABLE [Cliente]
(
	[ClienteID] int NOT NULL,
	[AgenteDeInmobiliariaID] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[DNI] int NULL,
	[Telefono] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Cliente]
 ADD CONSTRAINT [PK_Cliente]
	PRIMARY KEY CLUSTERED ([ClienteID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Cliente] ADD CONSTRAINT [FK_Cliente_AgenteDeInmobiliaria]
	FOREIGN KEY ([AgenteDeInmobiliariaID]) REFERENCES [AgenteDeInmobiliaria] ([AgenteDeInmobiliariaID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */
CREATE PROCEDURE SPMOSTRAR_CLIENTE
AS
SELECT * FROM Cliente
GO

CREATE PROCEDURE SPINSERTAR_CLIENTE
@ClienteID int,
@AgenteDeInmobiliariaID int,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
INSERT INTO Cliente VALUES (@ClienteID,@AgenteDeInmobiliariaID,@Nombre,@DNI,@Telefono)
GO

CREATE PROCEDURE SPEDITAR_CLIENTE
@ClienteID int,
@AgenteDeInmobiliariaID int,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
UPDATE Cliente SET
AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
Nombre = @Nombre,
DNI = @DNI,
Telefono = @Telefono
WHERE ClienteID = @ClienteID
GO

CREATE PROCEDURE SPELIMINAR_CLIENTE
@ClienteID int
AS
DELETE FROM Cliente WHERE ClienteID = @ClienteID