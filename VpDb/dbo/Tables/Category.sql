CREATE TABLE [dbo].[Category]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(20) NULL, 
    [BasePrice] DECIMAL(5, 2) NULL, 
    [Description] VARCHAR(255) NULL, 
)
