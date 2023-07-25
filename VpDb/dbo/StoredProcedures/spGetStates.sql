CREATE PROCEDURE [dbo].[spGetStates]
AS
BEGIN
	SELECT 
	[Id],
	[Name]
	FROM [dbo].[State] 
END