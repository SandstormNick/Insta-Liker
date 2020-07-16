--Create the Database
CREATE DATABASE Liker

-- Create User table
USE Liker
CREATE TABLE [dbo].[User] (
	[UserId] INT IDENTITY (1, 1) NOT NULL,
	[Username] VARCHAR (100) NOT NULL,
	CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);
--------------------------------------------------------------------

--Alter User Table
--Add LastRunDate = The last time the Liker Bot was run for the user
USE Liker
ALTER TABLE [dbo].[User]
ADD [LastRunDate] DATE;
--------------------------------------------------------------------

--Add NumberOfRuns = Keeps a count of every time the Liker Bot was run for a user
ALTER TABLE [dbo].[User]
ADD [NumberOfRuns] INT;
--------------------------------------------------------------------

--Add FavouriteCount = Keeps a count of the number of favourite hashtags for a user
--Add functionality to limit favourite hashtags to 5. In stored procs AND/OR the Code
ALTER TABLE [dbo].[User]
ADD [FavouriteCount] INT;
--------------------------------------------------------------------

-- Create UserHashtag mapping table
USE Liker
CREATE TABLE [dbo].[UserHashtag] (
	[UserId] INT NOT NULL,
	[HashtagId] INT NOT NULL,
	CONSTRAINT [FK_dbo.HashtagId] FOREIGN KEY ([HashtagId]) REFERENCES [dbo].[Hashtag](HashtagId),
	CONSTRAINT [FK_dbo.UserId] FOREIGN KEY (UserId) REFERENCES [dbo].[User](UserId)
);
--------------------------------------------------------------------

--Give UserHashtag table a PK
USE Liker
ALTER TABLE [dbo].[UserHashtag]
ADD ID INT NOT NULL

ALTER TABLE [dbo].[UserHashtag]
ADD PRIMARY KEY (ID)
--------------------------------------------------------------------

--Add IsFavourite Column in UserHashtag
USE Liker
ALTER TABLE [dbo].[UserHashtag]
ADD IsFavourite INT NOT NULL
--------------------------------------------------------------------

--Add LikeCount Column in UserHashtag
-- Counts the number of likes are performed for this Hashtag on the associated user account
USE Liker
ALTER TABLE [dbo].[UserHashtag]
ADD LikeCount INT