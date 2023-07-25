CREATE PROCEDURE [dbo].[spInsertOrder]
	@BranchId INT,
	@CustomerId INT,
	@CustomerType CHAR(1),
	@DiscountId SMALLINT = NULL,
	@OrderType CHAR(1),
	@PaymentType SMALLINT,
	@Date DATETIME,
	@Subtotal DECIMAL(5,2),
	@Tax DECIMAL(5,2),
	@Total DECIMAL(5,2),
	@StatusId SMALLINT

AS
BEGIN
	INSERT INTO [dbo].[Order] ([BranchId], [CustomerId], [CustomerType], [DiscountId], [OrderType], [PaymentType], [Date], [Subtotal], [Tax], [Total], [StatusId])
	VALUES (@BranchId, @CustomerId, @CustomerType, @DiscountId, @OrderType, @PaymentType, @Date, @Subtotal, @Tax, @Total, @StatusId)
END
