USE [AlexandraViolin]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[CreateLogin]
	 @AccountID INT OUTPUT
	,@name NVARCHAR(20)  
	,@email VARCHAR(100) 
	,@password_hash NVARCHAR(128) 
AS
BEGIN 
	IF NOT EXISTS(SELECT 1 FROM [dbo].[Account] AS A WHERE A.[name] = @name AND A.[email] = @email)
	   AND @password_hash IS NOT NULL 
	BEGIN
		DECLARE @salt NVARCHAR(36) = N'59179AC1-C8DB-48DF-87B2-2FC28EC5C579'--CAST(NEWID() AS BINARY(36))
			   ,@passw_salt NVARCHAR(128);

		select @salt, '0x' + convert(nvarchar(256), HASHBYTES('MD5', @password_hash + @salt), 2);

		SET @passw_salt = '0x' + convert(nvarchar(256), HASHBYTES('MD5', @password_hash + @salt), 2); 

		INSERT INTO [dbo].[Account]([name], [email], [password_hash], [salt])
		SELECT @name, @email, @passw_salt, @salt; 

		SELECT @AccountID = SCOPE_IDENTITY(); 
	END	
END; 


DECLARE @AccountID INT, @pass nvarchar(256) --= N'cola';
SELECT @pass = N'0xB368B156DC4C7FF2002B4CB0DEB21E29';
select @pass as [@pass]
EXEC [dbo].[CreateLogin]
	 @AccountID OUTPUT
	,@name = N'dima'  
	,@email = N'dima@mail.ru' 
	,@password_hash = @pass; 
SELECT @AccountID as Account; 
SELECT * FROM [dbo].[fn_login](N'dima@mail.ru', @pass);  

DECLARE @AccountID INT, @pass nvarchar(256), @salt BINARY(36) = 0x7FD7CCB822332845B885FD0DFEAAEDE30000000000000000000000000000000000000000; --= N'cola';
SELECT @pass = N'0xB368B156DC4C7FF2002B4CB0DEB21E29';
	select a.*, HASHBYTES('MD5', @pass + a.[salt]), '0x' + convert(nvarchar(256), HASHBYTES('MD5', @pass + a.[salt]), 2)
	from [dbo].[Account] as a 
	where 
	--a.[email] = @email
	--and 
	a.[password_hash] = '0x' + convert(nvarchar(256), HASHBYTES('MD5', @pass + a.[salt]), 2)
	CAST(HASHBYTES('MD5', @pass + a.salt) AS NVARCHAR(4000))

DECLARE @pass nchar(64) = N'cola';
SELECT CAST(HASHBYTES('MD5', @pass) AS NVARCHAR(4000));

DECLARE @pass nchar(64) = N'coca';
SELECT CAST(HASHBYTES('MD5', @pass) AS NVARCHAR(4000)), HASHBYTES('MD5', @pass);

exec sp_executesql N'select a.* from dbo.fn_login(@p0,@p1) as a;',N'@p0 nvarchar(4000),@p1 nvarchar(4000)',@p0=N'dima',@p1=N'ꬒ任ꞁ㳂ꧧ쀣ᣧﴙ'
exec sp_executesql N'select a.* from dbo.fn_login(@p0,@p1) as a;',N'@p0 nvarchar(4000),@p1 nvarchar(4000)',@p0=N'dima@mail.ru',@p1=N'Ⓗﵷ㳵퉴Ờ䦛兰'
exec sp_executesql N'select a.* from dbo.fn_login(@p0,@p1) as a;',N'@p0 nvarchar(4000),@p1 nvarchar(4000)',@p0=N'dima@mail.ru',@p1=N'ካפֿ膧숼⏀᧽'
exec sp_executesql N'select a.* from dbo.fn_login(@p0,@p1) as a;',N'@p0 nvarchar(4000),@p1 nvarchar(4000)',@p0=N'dima@mail.ru',@p1=N'0xB368B156DC4C7FF2002B4CB0DEB21E29'

declare @val1 varchar(64),
        @val2 nvarchar(64),
        @val3 char(64),
        @val4 nchar(64)

DECLARE @salt nvarchar(36) = N'59179AC1-C8DB-48DF-87B2-2FC28EC5C579'--CAST(NEWID() AS nvarchar(36))
		,@passw_salt BINARY(64);

select  @val1 =  'coca',
        @val2 = N'coca',
        @val3 =  'coca',
        @val4 = N'coca'

--'0xDFD60F0C0198E723ED394EAD40BE3A11'

select '0xB368B156DC4C7FF2002B4CB0DEB21E29'
--, HASHBYTES('MD5', @val1)
, HASHBYTES('MD5', @val2 + @salt)
, HASHBYTES('MD5', N'0xB368B156DC4C7FF2002B4CB0DEB21E29' + @salt)
--, HASHBYTES('MD5', @val3)
--, HASHBYTES('MD5', @val4)
--, @salt
, '0x' + convert(nvarchar(256), HASHBYTES('MD5', @val2 + @salt), 2)
--, HASHBYTES('MD5', CAST(CAST (N'0xB368B156DC4C7FF2002B4CB0DEB21E29' as binary(256)) as nvarchar(256)) + @salt)

declare @b varbinary(max)
set @b = 0x5468697320697320612074657374

select cast(@b as varchar(max)) /*Returns "This is a test"*/
SELECT CONVERT(VARCHAR(1000), @b, 2);