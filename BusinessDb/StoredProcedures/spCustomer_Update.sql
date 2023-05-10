CREATE PROCEDURE [dbo].[spCustomer_Update]
    @Id int,
	@Name nvarchar(50),
	@Surname nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[Customer] 
	SET [Name] = @Name, Surname = @Surname
	WHERE Id = @Id;
END
