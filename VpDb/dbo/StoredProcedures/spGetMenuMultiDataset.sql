CREATE PROCEDURE [dbo].[spGetMenuMultiDataset]
	@CategoryId int,
	@SpecialId int
AS
BEGIN
	-- 
	SELECT [M].[Id] AS [MenuItemId]
	FROM [MenuItem] [M]
	LEFT JOIN [Category] [C] ON
	[M].[CategoryId] = [C].[Id]
	LEFT JOIN [Special] [S] ON
	[M].[SpecialId] = [S].[Id]
	WHERE 
	[C].[Id] = @CategoryId AND 
	[s].[Id] = @SpecialId

	--
	SELECT [M].[SizeId]
	FROM [MenuItem] [M]
	LEFT JOIN [Category] [C] ON 
	[M].[CategoryId] = [C].[Id]
	Left JOIN [Special] [Sp] ON
	[M].[SpecialId] = [Sp].[Id]
	WHERE 
	[C].[Id] = @CategoryId AND 
	[Sp].[Id] = @SpecialId

	--
	SELECT [Sz].[Name] AS [SizeName]
	FROM [MenuItem] [M]
	LEFT JOIN [Category] [C] ON 
	[M].[CategoryId] = [C].[Id]
	LEFT JOIN [Size] [Sz] ON
	[M].[SizeId] = [Sz].[Id]
	Left JOIN [Special] [Sp] ON
	[M].[SpecialId] = [Sp].[Id]
	WHERE 
	[C].[Id] = @CategoryId AND 
	[Sp].[Id] = @SpecialId

	--
	SELECT
		CASE 
		WHEN [M].[CategoryId] = 1 THEN [C].[BasePrice]
		ELSE ([C].[BasePrice] + [Sz].[PriceMod] + [Sp].[PriceMod])
		END AS [Price]
	FROM [MenuItem] [M]
	LEFT JOIN [Category] [C] ON
	[M].[CategoryId] = [C].[Id]
	LEFT JOIN [Size] [Sz] ON
	[M].[SizeId] = [Sz].[Id]
	Left JOIN [Special] [Sp] ON
	[M].[SpecialId] = [Sp].[Id]
	WHERE 
	[C].[Id] = @CategoryId AND 
	[Sp].[Id] = @SpecialId
END
