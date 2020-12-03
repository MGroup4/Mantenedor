	/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Venta_AgenteDeInmobiliaria]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Venta] DROP CONSTRAINT [FK_Venta_AgenteDeInmobiliraria]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Venta]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Venta]
GO

/* Create Table */

CREATE TABLE [Venta]
(
	[VentaID] int NOT NULL,
	[AgenteDeInmobiliariaID] int NOT NULL,
	[Fecha] datetime NULL,
	[Precio] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Venta] 
 ADD CONSTRAINT [PK_Venta]
	PRIMARY KEY CLUSTERED ([VentaID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Venta] ADD CONSTRAINT [FK_Venta_AgenteDeInmobiliaria]
	FOREIGN KEY ([AgenteDeInmobiliariaID]) REFERENCES [AgenteDeInmobiliaria] ([AgenteDeInmobiliariaID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_VENTA
AS
SELECT * FROM Venta
GO

CREATE PROCEDURE SPINSERTAR_VENTA
@VentaID int,
@AgenteDeInmobiliariaID int,
@Fecha datetime,
@Precio int
AS
INSERT INTO Venta VALUES (@VentaID,@AgenteDeInmobiliariaID,@Fecha,@Precio)
GO

CREATE PROCEDURE SPEDITAR_VENTA
@VentaID int,
@AgenteDeInmobiliariaID int,
@Fecha datetime,
@Precio int
AS
UPDATE Venta SET
AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
Fecha = @Fecha,
Precio = @Precio
WHERE VentaID = @VentaID
GO

CREATE PROCEDURE SPELIMINAR_VENTA
@VentaID int
AS
DELETE FROM Venta WHERE VentaID = @VentaID
GO