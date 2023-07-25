CREATE TABLE [dbo].[MenuItem]
(
    [Id] SMALLINT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] SMALLINT NOT NULL,
    [SizeId] SMALLINT NOT NULL, 
    [SpecialId] SMALLINT NOT NULL, 
    [UrlId] SMALLINT NOT NULL, 
    CONSTRAINT [FK_MenuItem_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]), 
    CONSTRAINT [FK_MenuItem_Size] FOREIGN KEY ([SizeId]) REFERENCES [Size]([Id]), 
    CONSTRAINT [FK_MenuItem_Special] FOREIGN KEY ([SpecialId]) REFERENCES [Special]([Id]), 
    CONSTRAINT [FK_MenuItem_Url] FOREIGN KEY ([UrlId]) REFERENCES [Url]([Id]), 
)
