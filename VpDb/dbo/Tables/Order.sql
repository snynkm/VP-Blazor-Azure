CREATE TABLE [dbo].[Order]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1337, 1), 
    [BranchId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [CustomerType] CHAR NOT NULL,
    [DiscountId] SMALLINT NULL,
    [OrderType] CHAR NOT NULL,
    [PaymentType] SMALLINT NOT NULL, 
    [Date] DATETIME2(0) NOT NULL, 
    [Subtotal] DECIMAL(5, 2) NOT NULL, 
    [Tax] DECIMAL(5, 2) NOT NULL, 
    [Total] DECIMAL(5, 2) NOT NULL,    
    [StatusId] SMALLINT NOT NULL 
    CONSTRAINT [FK_Order_Branch] FOREIGN KEY ([BranchId]) REFERENCES [Branch]([Id]), 
    CONSTRAINT [FK_Order_Discount] FOREIGN KEY ([DiscountId]) REFERENCES [Discount]([Id]), 
    CONSTRAINT [FK_Order_Status] FOREIGN KEY ([StatusId]) REFERENCES [Status]([Id]), 
    CONSTRAINT [FK_Order_Payment] FOREIGN KEY ([PaymentType]) REFERENCES [Payment]([Id])
)
