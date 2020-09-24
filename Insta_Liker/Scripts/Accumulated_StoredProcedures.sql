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

	--User can't be mapped to the same hashtag twice
	IF NOT EXISTS (SELECT 1 FROM UserHashtag WHERE HashtagId = @hashtagID AND UserId = @userId )
	BEGIN
		INSERT INTO [dbo].[UserHashtag] (UserId, HashtagId, IsFavourite)
		VALUES (@userId, @hashtagID, @isFavourite)

		DECLARE @userFavCount INT
		SELECT @userFavCount = FavouriteCount FROM [dbo].[User]
		SET @userFavCount = @userFavCount + 1
		UPDATE [dbo].[User] SET FavouriteCount = @userFavCount WHERE UserId = @userId
	END
END
GO
-------------------------------

--sp_SetUserHashtag - Link User to the Hashtags
CREATE PROCEDURE sp_GetUsernames

AS
BEGIN
	SELECT Username FROM [dbo].[User]
	WHERE IsActive = 1
END
GO
-------------------------------

--sp_GetFavouriteHashtagsForUser - Get the Favourite Hashtags based on a Username parameter
CREATE PROCEDURE sp_GetFavouriteHashtagsForUser
@username VARCHAR(100)

AS
BEGIN
	DECLARE @userId INT
	SELECT @userId = UserId FROM [User] WHERE Username = @username

	SELECT HashtagString FROM Hashtag AS H
	INNER JOIN UserHashtag AS UH ON H.HashtagId = UH.HashtagId
	WHERE UH.UserId = @userId
	AND UH.IsFavourite = 1
END
GO
-------------------------------

--sp_UpdateUserRunCount - Iterate NumberOfRuns by 1 on User table when the LikerBot runs successfully
CREATE PROCEDURE sp_UpdateUserRunCount
@username VARCHAR(100)

AS
BEGIN
	DECLARE @userId INT
	SELECT @userId = UserId FROM [User] WHERE Username = @username

	DECLARE @runCount INT
	SELECT @runCount = NumberOfRuns FROM [User] WHERE UserId = @userId

	UPDATE [User] SET NumberOfRuns = @runCount + 1 WHERE UserId = @userId

	EXEC sp_UpdateLastRunDate @userId
END
GO
-------------------------------

--sp_UpdateLastRunDate - Update LastRunDate on User table with current date
CREATE PROCEDURE sp_UpdateLastRunDate
@userId INT

AS
BEGIN
	UPDATE [User] Set LastRunDate = GETDATE() WHERE UserId = @userId
END
GO
-------------------------------

--sp_UpdateUserHashtagLikeCount - Update LikeCount on the UserHashtag for the User and specific Hashtag
CREATE PROCEDURE sp_UpdateUserHashtagLikeCount
@username VARCHAR(100),
@hashtag VARCHAR(100),
@likeCount INT

AS
BEGIN
	DECLARE @userId INT
	SELECT @userId = UserId FROM [User] WHERE Username = @username

	DECLARE @hashtagId INT
	SELECT @hashtagId = HashtagId FROM Hashtag WHERE HashtagString = @hashtag

	UPDATE UserHashtag SET LikeCount = @likeCount
	WHERE UserId = @userId AND HashtagId = @hashtagId
END
GO
-------------------------------

--sp_CheckUserHashtagExists - Checks if a User is linked to a Hashtag
CREATE PROCEDURE sp_CheckUserHashtagExists
@userId INT,
@hashtag VARCHAR(100)

AS
BEGIN
	DECLARE @hashtagId INT
	SELECT @hashtagId = HashtagId FROM Hashtag WHERE HashtagString = @hashtag

	IF EXISTS (SELECT 1 FROM UserHashtag WHERE UserId = @userId AND HashtagId = @hashtagId)
	BEGIN
		SELECT 1
	END
	ELSE
	BEGIN
		SELECT 0
	END
END
GO
-------------------------------

--sp_GetUserId - Get UserId using the username
CREATE PROCEDURE sp_GetUserId
@username VARCHAR(100)

AS
BEGIN
	SELECT UserId FROM [dbo].[User] WHERE Username = @username;
END
GO
-------------------------------

--sp_GetUserLastRunDate - Get the LastRunDate for a User using the username
CREATE PROCEDURE sp_GetUserLastRunDate
@username VARCHAR(100)

AS
BEGIN
	SELECT LastRunDate FROM [dbo].[User] WHERE Username = @username
END
GO
-------------------------------

--sp_GetUserRunCount - Get the NumberOfRuns for a User using the username
CREATE PROCEDURE sp_GetUserRunCount
@username VARCHAR(100)

AS
BEGIN
	SELECT NumberOfRuns FROM [dbo].[User] WHERE Username = @username
END
GO
-------------------------------

--sp_GetUserDateCreated - Get the DateCreated for a User using the username
CREATE PROCEDURE sp_GetUserDateCreated
@username VARCHAR(100)

AS
BEGIN
	SELECT DateCreated FROM [dbo].[User] WHERE Username = @username
END
GO