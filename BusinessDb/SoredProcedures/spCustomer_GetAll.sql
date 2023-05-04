CREATE PROCEDURE [dbo].[spCustomer_GetAll]
	--@param1 int = 0,
	--@param2 int
AS
BEGIN
	--SELECT @param1, @param2
	SELECT Id, [Name], Surname
	FROM dbo.Customer
END
