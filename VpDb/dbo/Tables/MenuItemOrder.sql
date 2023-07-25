CREATE TABLE [dbo].[MenuItemOrder] (
    [OrderLineId]   SMALLINT        NOT NULL,
    [OrderId]        INT            NOT NULL,
    [MenuItemId]     SMALLINT       NOT NULL,
    [Quantity]       SMALLINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderLineId] ASC, [OrderId] ASC),
    CONSTRAINT [FK_OrderLine_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_OrderLine_MenuItem] FOREIGN KEY ([MenuItemId]) REFERENCES [dbo].[MenuItem] ([Id]),
);

