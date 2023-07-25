CREATE PROCEDURE [dbo].[spGetDiscounts]
AS
BEGIN
	SELECT
	[Id],
	[Code],
	[Type],
	[PercentAmt],
	[FlatAmt]
	FROM [dbo].[Discount]
	WHERE GETDATE() BETWEEN
	[Discount].[StartDate] AND
	[Discount].[EndDate]
END