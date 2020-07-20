--Create the Database
CREATE DATABASE Liker

-- Create User table
CREATE TABLE [dbo].[User] (
	[UserId] INT IDENTITY (1, 1) NOT NULL,
	[Username] VARCHAR (100) NOT NULL,
	[DateCreated] DATE DEFAULT GETDATE(),
	[NumberOfRuns] INT DEFAULT 0,
	[FavouriteCount] INT DEFAULT 0,
	[LastRunDate] DATE NULL,
	CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);
--------------------------------------------------------------------

--Create Hashtag table
CREATE TABLE [dbo].[Hashtag] (
	[HashtagId] INT IDENTITY (1, 1) NOT NULL,
	[HashtagString] VARCHAR (100) NOT NULL
	CONSTRAINT [PK_dbo.Hashtag] PRIMARY KEY CLUSTERED ([HashtagId] ASC)
);
--------------------------------------------------------------------

-- Create UserHashtag mapping table
CREATE TABLE [dbo].[UserHashtag] (
	[UserHashtagId] INT IDENTITY (1, 1) NOT NULL,
	[UserId] INT NOT NULL,
	[HashtagId] INT NOT NULL,
	[IsFavourite] INT DEFAULT 0,
	[LikeCount] INT DEFAULT 0
	CONSTRAINT [PK_dbo.UserHashtag] PRIMARY KEY CLUSTERED ([UserHashtagId] ASC),
	CONSTRAINT [FK_dbo.HashtagId] FOREIGN KEY ([HashtagId]) REFERENCES [dbo].[Hashtag](HashtagId),
	CONSTRAINT [FK_dbo.UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User](UserId)
);
--------------------------------------------------------------------

-- Create FollowStats table
CREATE TABLE [dbo].[FollowStats] (
	[UserId] INT NOT NULL,
	[FollowingCount] INT DEFAULT 0,
	[FollowerCount] INT DEFAULT 0,
	[LastRunDate] DATE DEFAULT GETDATE(),
	CONSTRAINT [PK_dbo.FollowStats] PRIMARY KEY CLUSTERED ([UserId] ASC),
	CONSTRAINT [FK_dbo.FollowStats_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User](UserId)
);
--------------------------------------------------------------------

-- Create FollowStatsHistory
CREATE TABLE [dbo].[FollowStatsHistory] (
	[FollowStatsHistoryId] INT IDENTITY (1, 1) NOT NULL,
	[UserId] INT NOT NULL,
	[Date] DATE NOT NULL,
	[FollowingCount] INT DEFAULT 0,
	[FollowerCount] INT DEFAULT 0,
	CONSTRAINT [PK_dbo.FollowStatsHistory] PRIMARY KEY CLUSTERED ([FollowStatsHistoryId] ASC),
	CONSTRAINT [FK_dbo.FollowStatsHistory_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[FollowStats](UserId)
);