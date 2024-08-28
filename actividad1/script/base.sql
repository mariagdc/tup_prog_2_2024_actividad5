Use EnviosDB

Create Table Envios(
Id int Primary Key identity (1,1),
Valor_total DECIMAL(18,2)
)

GO

USE EnviosDB
CREATE TABLE Costos(
Id Int Primary Key Identity (1,1),
Tipo Int Not null Default 0,--valor fijo/concepto variable
Concepto Nvarchar(50),
valor_final Decimal(18,2),
Id_envio Int not null,
Precio_por_Unidad Decimal(18,2),
Unidades Decimal (18,2),
Foreign key (Id_Envio) References Envios (Id))
GO


Use EnviosDB
Insert Into Envios(Valor_total)
values (0)

INSERT INTO Costos(Concepto, Valor_final, Precio_por_Unidad, Unidades, Id_Envio)
Values (0,'Peaje Puente zArate',300,null,null,@Id_envio),
(1,'Combustible-Litros',null,1500.5,500,@Id_envio),
(0,'Peaje Puente ',300,null,null,@Id_envio),
(0,'Peaje zArate',300,null,null,@Id_envio),
(0,' Puente ',300,null,null,@Id_envio)
