CREATE TABLE [dbo].[OrderTransaction]
(
	[OrderId] INT NOT NULL, 
    [TransactionId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([OrderId] ASC, [TransactionId] ASC),
    CONSTRAINT [FK_OrderTransaction_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order]([Id]), 
    CONSTRAINT [FK_OrderTransaction_Transaction] FOREIGN KEY ([TransactionId]) REFERENCES [dbo].[Transaction]([Id]),
)
