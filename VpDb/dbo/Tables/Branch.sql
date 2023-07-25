CREATE TABLE [dbo].[Branch]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressLine] VARCHAR(50) NULL, 
    [City] VARCHAR(20) NULL,
    [StateId] SMALLINT NULL, 
    [Zip] VARCHAR(10) NULL, 
    [Phone] VARCHAR(10) NULL, 
    CONSTRAINT [FK_Branch_State] FOREIGN KEY ([StateId]) REFERENCES [State]([Id])

)
