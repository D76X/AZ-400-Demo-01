CREATE PROCEDURE [dbo].[spCustomer_Get]
	@Id int	
AS
BEGIN
	SELECT Id, [Name], Surname FROM [dbo].[Customer] WHERE Id = @Id;
END
