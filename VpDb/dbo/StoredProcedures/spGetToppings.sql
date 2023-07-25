CREATE PROCEDURE [dbo].[spGetToppings]

AS
BEGIN
	SELECT [Id],
	[Name],
	[PriceMod]
	FROM [dbo].[Topping]
END