CREATE TABLE [dbo].[Special]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(20) NULL, 
    [PriceMod] DECIMAL(5, 2) NULL, 
    [Description] VARCHAR(255) NULL, 
)
