CREATE TABLE [dbo].[Discount]
(
	[Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] VARCHAR(10) NOT NULL, 
    [Type] CHAR NOT NULL, 
    [PercentAmt] DECIMAL(5, 2) NULL, 
    [FlatAmt] DECIMAL(5, 2) NULL, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL
)
