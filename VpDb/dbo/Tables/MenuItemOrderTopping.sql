CREATE TABLE [dbo].[MenuItemOrderTopping]
(
	[OrderId] INT NOT NULL, 
    [OrderLineId] SMALLINT NOT NULL, 
    [ToppingId] SMALLINT NOT NULL
    PRIMARY KEY CLUSTERED ([OrderId] ASC, [OrderLineId] ASC, [ToppingId] ASC), 
    CONSTRAINT [FK_MenuItemOrderTopping_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order]([Id]),
    CONSTRAINT [FK_MenuItemOrderTopping_Topping] FOREIGN KEY ([ToppingId]) REFERENCES [dbo].[Topping]([Id])
)
