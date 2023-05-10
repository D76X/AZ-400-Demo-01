CREATE PROCEDURE [dbo].[spCustomer_Insert]
	@Name nvarchar(50),
	@Surname nvarchar(50)
AS
BEGIN
	INSERT INTO [dbo].[Customer] ([Name], Surname) 
	VALUES (@Name, @Surname);
END
