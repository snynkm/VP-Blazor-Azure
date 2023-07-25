CREATE TABLE [dbo].[Transaction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Type] VARCHAR(20) NULL, 
    [CardNum] VARCHAR(20) NULL, 
    [Zip] VARCHAR(10) NULL
)
