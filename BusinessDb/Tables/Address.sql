﻿CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Country] NVARCHAR(50) NOT NULL, 
    [ZipCode] NVARCHAR(50) NOT NULL, 
    [AddressLine1] NVARCHAR(50) NOT NULL, 
    [AddressLine2] VARBINARY(50) NOT NULL 
)
