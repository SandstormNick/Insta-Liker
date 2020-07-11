--Create the Database
CREATE DATABASE Liker

-- Create User table
USE Liker
CREATE TABLE [dbo].[User] (
	[UserId] INT IDENTITY (1, 1) NOT NULL,
	[Username] VARCHAR (100) NOT NULL,
	CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED ([UserId] ASC)
); 