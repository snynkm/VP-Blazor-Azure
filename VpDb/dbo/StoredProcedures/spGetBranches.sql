CREATE PROCEDURE [dbo].[spGetBranches]
AS
BEGIN
	SELECT 
	[Branch].[Id],
	[Branch].[City],
	[AddressLine],
	[StateId],
	[Zip],
	[Phone]
	FROM [dbo].[Branch]
	LEFT JOIN [dbo].[State] ON
	[Branch].[StateId] = [State].[Id]
END

