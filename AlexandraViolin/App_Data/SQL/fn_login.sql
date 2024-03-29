USE [AlexandraViolin]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[fn_login](@email varchar(100), @password_hash nvarchar(128)) 
RETURNS TABLE 
AS
RETURN 
(
	select a.ID, a.name, a.email
	from [dbo].[Account] as a 
	where a.[email] = @email
	and a.[password_hash] = '0x' + convert(nvarchar(256), HASHBYTES('MD5', @password_hash + a.[salt]), 2)
)


--DECLARE @HashThis nvarchar(4000);  
--SET @HashThis = CONVERT(nvarchar(4000),'coca');  
--SELECT len(HASHBYTES('MD5', @HashThis + 'asfdf')), HASHBYTES('MD5',cast(newid() as nvarchar(4000)))