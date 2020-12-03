/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_AgenteDeInmobiliaria_Usuario]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [AgenteDeInmobiliaria] DROP CONSTRAINT [FK_AgenteDeInmobiliaria_Usuario]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[AgenteDeInmobiliaria]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [AgenteDeInmobiliaria]
GO

/* Create Table */

CREATE TABLE [AgenteDeInmobiliaria]
(
	[AgenteDeInmobiliariaID] int NOT NULL,
	[Nombre] varchar(50) NULL,
	[UsuarioID] int NOT NULL,
	[Dni] int NULL,
	[Telefono] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [AgenteDeInmobiliaria] 
 ADD CONSTRAINT [PK_AgenteDeInmobiliaria]
	PRIMARY KEY CLUSTERED ([AgenteDeInmobiliariaID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [AgenteDeInmobiliaria] ADD CONSTRAINT [FK_AgenteDeInmobiliaria_Usuario]
	FOREIGN KEY ([UsuarioID]) REFERENCES [Usuario] ([UsuarioID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_AGDIM
AS
SELECT * FROM AgenteDeInmobiliaria
GO

CREATE PROCEDURE SPINSERTAR_AGDIM
@AgenteDeInmobiliariaID int,
@Nombre varchar(50),
@UsuarioID int,
@DNI int,
@Telefono int
AS
INSERT INTO AgenteDeInmobiliraria VALUES (@AgenteDeInmobiliariaID,@Nombre,@UsuarioID,@Dni,@Telefono)
GO

CREATE PROCEDURE SPEDITAR_AGDIM
@AgenteDeInmobiliariaID int,
@Nombre varchar(50),
@UsuarioID int,
@DNI int,
@Telefono int
AS
UPDATE AgenteDeInmobiliaria SET
AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID,
Nombre = @Nombre,
UsuarioID = @UsuarioID,
DNI = @DNI,
Telefono = @Telefono
WHERE AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID
GO

CREATE PROCEDURE SPELIMINAR_AGDIM
@AgenteDeInmobiliariaID int
AS
DELETE FROM AgenteDeInmobiliaria WHERE AgenteDeInmobiliariaID = @AgenteDeInmobiliariaID
GO