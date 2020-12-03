IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Alquiler]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Alquiler]
GO

/* Create Table */

CREATE TABLE [Alquiler]
(
	[AlquilerID] int NOT NULL,
	[FechaInicio] date NULL,
	[FechaFin] date NULL,
	[Precio] float NULL,
	[DNICliente] int NULL,
	[Cuotas] int NULL,
	[PrecioPorCuotas] float NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Alquiler] 
 ADD CONSTRAINT [PK_Alquiler]
	PRIMARY KEY CLUSTERED ([AlquilerID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Alquiler] ADD CONSTRAINT [FK_Alquiler_AgenteDeInmobiliaria]
	FOREIGN KEY ([AgenteDeInmobiliariaID]) REFERENCES [AgenteDeInmobiliaria] ([AgenteDeInmobiliariaID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_ALQUILER
AS
SELECT * FROM ALQUILER
GO

CREATE PROCEDURE SPINSERTAR_ALQUILER
@AlquilerID int,
@AgenteDeInmobiliariaID int,
@FechaInicio date,
@FechaFin date,
@Precio float,
@DNICliente int,
@Cuotas int,
@PrecioPorCuotas float
AS
INSERT INTO Alquiler VALUES(@AlquilerID,@AgenteDeInmobiliariaID,@FechaInicio,@FechaFin,@Precio,@DNICliente,@Cuotas,@PrecioPorCuotas)
GO

CREATE PROCEDURE SPEDITAR_ALQUILER
@AlquilerID int,
@AgenteDeInmobiliariaID int,
@FechaInicio date,
@FechaFin date,
@Precio float,
@DNICliente int,
@Cuotas int,
@PrecioPorCuotas float
AS
UPDATE Alquiler SET
AlquilerID = @AlquilerID,
AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
FechaInicio = @FechaInicio,
FechaFin = @FechaFin,
DNICliente = @DNICliente,
Cuotas = @Cuotas,
PrecioPorCuotas = @PrecioPorCuotas
WHERE AlquilerID = AlquilerID
GO

CREATE PROCEDURE SPELIMINAR_ALQUILER
@AlquilerID int
AS
DELETE FROM Alquiler WHERE AlquilerID = @AlquilerID
GO