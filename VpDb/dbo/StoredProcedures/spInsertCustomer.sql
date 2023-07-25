CREATE PROCEDURE [dbo].[spInsertCustomer]
	@FirstName VARCHAR(25),
	@LastName VARCHAR(25),
	@Phone VARCHAR(12),
	@Email VARCHAR(50) = NULL,
	@AddressLine VARCHAR(35) = NULL,
	@City VARCHAR(25) = NULL,
	@StateId SMALLINT = NULL,
	@Zip VARCHAR(10) = NULL
AS
BEGIN
	INSERT INTO [dbo].[Guest] ([FirstName], [LastName], [Phone], [Email], [AddressLine], [City], [StateId], [Zip])
	VALUES 
	(
	@FirstName,
	@LastName,
	@Phone,
	ISNULL(@Email, NULL),
	ISNULL(@AddressLine, NULL),
	ISNULL(@City, NULL),
	ISNULL(@StateId, NULL),
	ISNULL(@Zip, NULL)
	)
END

