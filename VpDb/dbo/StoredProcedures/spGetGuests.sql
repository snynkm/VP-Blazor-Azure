CREATE PROCEDURE [dbo].[spGetGuests]

AS
BEGIN 
	SELECT TOP 10 * 
	FROM [dbo].[Guest]
END

