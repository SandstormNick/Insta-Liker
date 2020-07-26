--Accumulated Stored Procedures
--Set the Database to Liker
-------------------------------

--sp_CreateUser - Create the User
CREATE PROCEDURE sp_CreateUser
@username VARCHAR(100)

AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM [dbo].[User] WHERE Username = @username)
	BEGIN
		DECLARE @userId INT
		INSERT INTO [dbo].[User] (Username)
		VALUES (@username)
		SET @userId = SCOPE_IDENTITY();
		SELECT UserId FROM [dbo].[User] WHERE UserId = @userId
	END

	--Return -1 if the username does already exist
	SELECT -1
END
GO
-------------------------------

--sp_CreateHashtag - Create Hashtag in Hashtag table
--Only Insert it if it does not exisit in the table
CREATE PROCEDURE sp_CreateHashtag
@hashtag VARCHAR(100)

AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM Hashtag WHERE @hashtag = HashtagString)
	BEGIN
		INSERT INTO [dbo].[Hashtag] (HashtagString)
		VALUES (@hashtag)
	END
END
GO
-------------------------------

--sp_SetUserHashtag - Link User to the Hashtags
CREATE PROCEDURE sp_SetUserHashtag
@userId INT,
@hashtag VARCHAR(100),
@isFavourite INT

AS
BEGIN
	DECLARE @hashtagID INT
	SELECT @hashtagID = HashtagId FROM Hashtag WHERE @hashtag = HashtagString

	IF NOT EXISTS (SELECT 1 FROM UserHashtag WHERE HashtagId = @hashtagID AND UserId = @userId )
	BEGIN
		INSERT INTO [dbo].[UserHashtag] (UserId, HashtagId, IsFavourite)
		VALUES (@UserId, @hashtagID, @isFavourite)
	END
END
GO
