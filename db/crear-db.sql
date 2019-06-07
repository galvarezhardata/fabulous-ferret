CREATE DATABASE [adventurous-armadillo];

USE [adventurous-armadillo];

CREATE TABLE [USERS] (
	[ID] int identity,
	[NAME] nvarchar(250),
	[PASSWORD] nvarchar(250),
	PRIMARY KEY (ID)
);

INSERT INTO [adventurous-armadillo].[dbo].[USERS] ([NAME], [PASSWORD])
VALUES ('german', 'lacontra2255');
