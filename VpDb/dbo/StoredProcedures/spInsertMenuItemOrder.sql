CREATE PROCEDURE [dbo].[spInsertMenuItemOrder]
	@OrderLineId SMALLINT,
	@OrderId INT,
	@MenuItemId SMALLINT,
	@Quantity SMALLINT
AS
BEGIN
	INSERT INTO [dbo].[MenuItemOrder] ([OrderLineId], [OrderId], [MenuItemId], [Quantity])
	VALUES (@OrderLineId, @OrderId, @MenuItemId, @Quantity)
END
