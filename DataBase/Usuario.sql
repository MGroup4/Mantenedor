/* Drop Foreign Key Constraint */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Usuario_Rango]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Propiedad] DROP CONSTRAINT [FK_Propiedad_AgenteDeInmobiliaria]
GO

/* Drop Table */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Usuario]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Usuario]
GO

/* Create Table */

CREATE TABLE [Usuario]
(
	[UsuarioID] int NOT NULL,
	[Contrasenia] varchar(50) NULL,
	[RangoID] int,
	[Nombre] varchar(50) NULL,
	[DNI] int NULL,
	[Telefono] int NULL
)
GO

/* Create Primary Key */

ALTER TABLE [Usuario] 
 ADD CONSTRAINT [PK_Usuario]
	PRIMARY KEY CLUSTERED ([UsuarioID] ASC)
GO

/* Create Foreign Key Constraint */

ALTER TABLE [Usuario] ADD CONSTRAINT [FK_Usuario_Rango]
	FOREIGN KEY ([RangoID]) REFERENCES [Rango] ([RangoID]) ON DELETE No Action ON UPDATE No Action
GO

/* Create Procedures CRUD */

CREATE PROCEDURE SPMOSTRAR_USUARIO
AS
SELECT * FROM USUARIO 
GO

CREATE PROCEDURE SPINSERTAR_USUARIO
@UsuarioID int,
@Contrasenia varchar(50),
@RangoID int,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
INSERT INTO Usuario VALUES (@UsuarioID,@Contrasenia,@RangoID,@Nombre,@DNI,@Telefono)
GO

CREATE PROCEDURE SPEDITAR_USUARIO
@UsuarioID int,
@Contrasenia varchar(50),
@RangoID int,
@Nombre varchar(50),
@DNI int,
@Telefono int
AS
UPDATE Usuario SET 
Contrasenia = @Contrasenia,
RangoID = @RangoID,
Nombre = @Nombre,
DNI = @DNI,
Telefono = @Telefono
WHERE UsuarioID = @UsuarioID
GO

CREATE PROCEDURE SPELIMINAR_USUARIO
@UsuarioID int
AS
DELETE FROM Usuario WHERE UsuarioID = @UsuarioID
GO

/* Insert values */