/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (select 1 from dbo.Customer)
BEGIN
   INSERT INTO dbo.Customer ([Name], Surname)
   VALUES
   ('Name1','Surname1'),
   ('Name2','Surname2'),
   ('Name3','Surname3');
END
