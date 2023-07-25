CREATE PROCEDURE [dbo].[spGetCategorySizeSpecialUrl]
AS
BEGIN
	SELECT 
	DISTINCT [SpecialId],
	[C].[Id] AS [CategoryId],
	[C].[Name] AS [CategoryName],
	[C].[Description] AS [CategoryDescription],
	[Sp].[Name] AS [SpecialName],
	[Sp].[Description] AS [SpecialDescription],
	[Url].[UrlExtension]
	FROM 
	[MenuItem] [M]
	LEFT JOIN [Category] [C] ON 
	[M].[CategoryId] = [C].[Id]
	Left JOIN [Special] [Sp] ON
	[M].[SpecialId] = [Sp].[Id]
	LEFT JOIN [Url] ON
	[M].[UrlId] = [Url].[Id]
	ORDER BY [CategoryId] ASC, [SpecialId] ASC
END