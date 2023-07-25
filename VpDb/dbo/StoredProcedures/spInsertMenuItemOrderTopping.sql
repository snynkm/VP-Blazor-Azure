CREATE PROCEDURE [dbo].[spInsertMenuItemOrderTopping]
	@OrderId INT,
	@OrderLineId SMALLINT,
	@ToppingId SMALLINT
AS
BEGIN
	INSERT INTO [dbo].[MenuItemOrderTopping] ([OrderId], [OrderLineId], [ToppingId])
	VALUES (@OrderId, @OrderLineId, @ToppingId)
END
