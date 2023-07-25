CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1007, 1), 
    [FirstName] VARCHAR(25) NOT NULL, 
    [LastName] VARCHAR(25) NOT NULL, 
    [Phone] VARCHAR(12) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [AddressLine] VARCHAR(35) NULL, 
    [City] VARCHAR(25) NULL, 
    [StateId] SMALLINT NULL, 
    [Zip] VARCHAR(10) NULL, 
    CONSTRAINT [FK_User_State] FOREIGN KEY ([StateId]) REFERENCES [State]([Id])
)
