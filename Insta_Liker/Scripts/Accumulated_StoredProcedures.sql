--Accumulated Stored Procedures
-------------------------------

--sp_CreateUser - Create the User
CREATE PROCEDURE sp_CreateUser
@username VARCHAR(100)

AS
BEGIN
	INSERT INTO [dbo].[User] (Username)
	VALUES (@username)
END
GO