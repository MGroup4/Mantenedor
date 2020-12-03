/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Propiedad_AgenteDeInmobiliaria]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Propiedad] DROP CONSTRAINT [FK_Propiedad_AgenteDeInmobiliaria]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Propiedad]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Propiedad]
GO

/* Create Table */

CREATE TABLE [Propiedad]
(
	[PropiedadID] int NOT NULL,
	[AgenteDeInmobiliariaID] int NOT NULL,
	[ValorDeVenta] int NULL,
	[Ubicacion] varchar(50) NULL,
	[Dormitorios] int NULL,
	[Banios] int NULL,
	[Estacionamiento] int NULL,
	[Tamanio] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Propiedad] 
 ADD CONSTRAINT [PK_Propiedad]
	PRIMARY KEY CLUSTERED ([PropiedadID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Propiedad] ADD CONSTRAINT [FK_Propiedad_AgenteDeInmobiliaria]
	FOREIGN KEY ([AgenteDeInmobiliariaID]) REFERENCES [AgenteDeInmobiliaria] ([AgenteDeInmobiliariaID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_PROPIEDAD
AS
SELECT * FROM PROPIEDAD
GO

CREATE PROCEDURE SPINSERTAR_PROPIEDAD
@PropiedadID int,
@AgenteDeInmobiliariaID int,
@ValorDeVenta int,
@Ubicacion varchar(50),
@Dormitorios int,
@Banios int,
@Estacionamiento int,
@Tamanio int
AS
INSERT INTO Propiedad VALUES(@PropiedadID,@AgenteDeInmobiliariaID,@ValorDeVenta,@Ubicacion,@Dormitorios,@Banios,@Estacionamiento,@Tamanio)
GO

CREATE PROCEDURE SPEDITAR_PROPIEDAD
@PropiedadID int,
@AgenteDeInmobiliariaID int,
@ValorDeVenta int,
@Ubicacion varchar(50),
@Dormitorios int,
@Banios int,
@Estacionamiento int,
@Tamanio int
AS
UPDATE Propiedad SET
PropiedadID = @PropiedadID,
AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
ValorDeVenta = @ValorDeVenta,
Ubicacion = @Ubicacion,
Dormitorios = @Dormitorios,
Banios = @Banios,
Estacionamiento = @Estacionamiento,
Tamanio = @Tamanio
WHERE PropiedadID = @PropiedadID
GO

CREATE PROCEDURE SPELIMINAR_PROPIEDAD
@PropiedadID int
AS
DELETE FROM Propiedad WHERE PropiedadID = @PropiedadID
GO