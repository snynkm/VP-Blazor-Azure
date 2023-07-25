GO
USE [VpDb];

IF NOT EXISTS (SELECT 1 FROM [dbo].[Size])
BEGIN
	INSERT INTO [dbo].[Size] ([Name], [PriceMod])
	VALUES 
	('S',0.00),
	('M',4.00),
	('L',7.00),
	('J',9.00)
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Special])
BEGIN
	INSERT INTO [dbo].[Special] ([Name], [PriceMod], [Description])
	VALUES 
	('Cheese Louiz',0.00,'Our signature whole cheese pizza that delivers greatness.'),
	('Roni Tony',0.00,'Our tried and true pepperoni special for the OG fans.'),
	('Meat Lover',2.00,'A meat lovers delight that gets straight to the point.'),
	('Supreme',2.00,'Our premium special that offers the whole blend.'),
	('BBQ Chicken',2.00,'Fire up the charcoal with a smooth and smokey BBQ vibe.'),
	('Margherita',2.00,'The fancy and classic style that hits home.'),
	('Hawaiian',2.00,'Dance the tango with sweet and savory.')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[State])
BEGIN
	INSERT INTO [dbo].[State] ([Name])
	VALUES 
	('AL'),
	('AK'),
	('AZ'),
	('AR'),
	('AS'),
	('CA'),
	('CO'),
	('CT'),
	('DE'),
	('DC'),
	('FL'),
	('GA'),
	('GU'),
	('HI'),
	('ID'),
	('IL'),
	('IN'),
	('IA'),
	('KS'),
	('KY'),
	('LA'),
	('ME'),
	('MD'),
	('MA'),
	('MI'),
	('MN'),
	('MS'),
	('MO'),
	('MT'),
	('NE'),
	('NV'),
	('NH'),
	('NJ'),
	('NM'),
	('NY'),
	('NC'),
	('ND'),
	('MP'),
	('OH'),
	('OK'),
	('OR'),
	('PA'),
	('PR'),
	('RI'),
	('SC'),
	('SD'),
	('TN'),
	('TX'),
	('TT'),
	('UT'),
	('VT'),
	('VA'),
	('VI'),
	('WA'),
	('WV'),
	('WI'),
	('WY')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Status])
BEGIN
	INSERT INTO [dbo].[Status]([Name])
	VALUES 
	('queued'),
	('processing'),
	('processed'),
	('delivering'),
	('delivered')

END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Category])
BEGIN
	INSERT INTO [dbo].[Category] ([Name], [BasePrice], [Description])
	VALUES 
	('slice', 1.99, 'Swing by and grab a slice for a quick bite on the fly.'),
	('special', 7.99, 'Explore some of our signature whole specials.'),
	('custom',7.99, 'Put your chef hat on and build your own special pizza.')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Discount])
BEGIN
	INSERT INTO [dbo].[Discount] ([Code], [Type], [PercentAmt], [FlatAmt], [StartDate], [EndDate])
	VALUES 
	('VP20OFF', 'P', 20.00, null, '20220101 12:00:00 AM', '20991231 23:59:59 PM')	
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Topping])
BEGIN
	INSERT INTO [dbo].[Topping] ([Name], [PriceMod])
	VALUES 
	('Pepperoni', 0.99),
	('Sausage', 0.99),
	('Mushroom', 0.99),
	('Onion', 0.99),
	('Redpepper', 0.99),
	('Olive', 0.99),
	('Grilled Chicken', 1.99),
	('Pineapple', 0.99),
	('Ham', 0.99),
	('Anchovy', 1.99);
END


IF NOT EXISTS (SELECT 1 FROM [dbo].[Payment])
BEGIN
	INSERT INTO [dbo].[Payment] ([Name])
	VALUES 
	('Cash'),
	('Credit'),
	('Debit'),
	('Check'),
	('Block')
END


IF NOT EXISTS (SELECT 1 FROM [dbo].[Branch])
BEGIN
	INSERT INTO [dbo].[Branch] ([AddressLine], [City], [StateId], [Zip], [Phone])
	VALUES 
	('122 Main St',  'Los Angeles',6, '90011', '8001239999'),
	('88 Broad St',  'New York City',35, '10001', '8889998989'),
	('57 W Test Dr',  'Coast City',10, '20001', '8081231234')
END

IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO [dbo].[User] ([FirstName], [LastName], [Phone], [Email], [AddressLine], [City], [StateId], [Zip])
	VALUES 
	('Jim','Test', 8888888888, 'testemail2@test.com', '123 Test St', 'Los Angeles', 6, 90011)
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Url])
BEGIN
	INSERT INTO [dbo].[Url] ([Description], [UrlExtension])
	VALUES 
	('cheese_slice', 'https://images.unsplash.com/photo-1579487442164-9cb4eb0aeaaf?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=688&q=80'),
	('pep_slice', 'https://images.unsplash.com/photo-1604467758117-72d987cb513b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=688&q=80'),
	('cheeseLouiz', 'https://images.unsplash.com/photo-1513104890138-7c749659a591?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80'),
	('roniTony', 'https://img.freepik.com/free-photo/delicious-salami-pizza_1004-25.jpg?w=1380&t=st=1681250195~exp=1681250795~hmac=9db42ceae7139c6b4dd027ace0a114b0e3dd56046582bac2e90004067039a774'),
	('meatLover', 'https://images.unsplash.com/photo-1599321955726-e048426594af?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80'),
	('supreme', 'https://img.freepik.com/free-photo/thin-mixed-pizza-wit-various-ingredients-close-up-view_141793-13100.jpg?w=1380&t=st=1681251914~exp=1681252514~hmac=7a4944c4f202cd5bc31d4c8327a23e888dd3be88cf49f6f93ac940b50c7c9e7c'),
	('bbqChicken', 'https://img.freepik.com/free-photo/pizza-yummy-with-cheese-light-surface_140725-14196.jpg?w=1380&t=st=1681251396~exp=1681251996~hmac=1f15792a8586f429acf8a56cb7c467ef0a75b5f05239d6b89b50d00410d5ad7e'),
	('margherita', 'https://media.istockphoto.com/id/917527628/photo/pizza-margherita.jpg?s=612x612&w=is&k=20&c=c1VwS3LcGQhHcEWOaAMb2gZ-wSwTyzDtzk7shJc35hY='),
	('hawaiian', 'https://media.istockphoto.com/id/537640710/photo/homemade-pineapple-and-ham-hawaiian-pizza.jpg?s=612x612&w=is&k=20&c=1GsNWM-D_AOnczHiX9L2BhJIXC5TYPNzfg_ekLvx2Qg='),
	('custom', 'https://images.unsplash.com/photo-1579751626657-72bc17010498?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1169&q=80')
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[MenuItem])
BEGIN
	INSERT INTO [dbo].[MenuItem]
	([CategoryId],[SizeId],[SpecialId],[UrlId])
	VALUES
	(1,3,1,1),
	(1,3,2,2),
	(2,1,1,3),
	(2,1,2,4),
	(2,1,3,5),
	(2,1,4,6),
	(2,1,5,7),
	(2,1,6,8),
	(2,1,7,9),
	(2,2,1,3),
	(2,2,2,4),
	(2,2,3,5),
	(2,2,4,6),
	(2,2,5,7),
	(2,2,6,8),
	(2,2,7,9),
	(2,3,1,3),
	(2,3,2,4),
	(2,3,3,5),
	(2,3,4,6),
	(2,3,5,7),
	(2,3,6,8),
	(2,3,7,9),
	(2,4,1,3),
	(2,4,2,4),
	(2,4,3,5),
	(2,4,4,6),
	(2,4,5,7),
	(2,4,6,8),
	(2,4,7,9),
	(3,1,1,10),
	(3,2,1,10),
	(3,3,1,10),
	(3,4,1,10)
END


