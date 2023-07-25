CREATE PROCEDURE [dbo].[spGetBranchesAndStates]
AS
BEGIN
	SELECT 
	[Branch].[Id],
	[Branch].[City],
	[AddressLine],
	[Zip],
	[Phone],
	[State].[Id] AS [StateId],
	[State].[Name] AS [StateName]
	FROM [dbo].[Branch]
	LEFT JOIN [dbo].[State] ON
	[Branch].[StateId] = [State].[Id]
END

