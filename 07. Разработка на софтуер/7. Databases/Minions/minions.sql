USE [minions];

-- Create table
CREATE TABLE [minions] 
(
	[id] INT, 
	[name] VARCHAR(50), 
	[age] INT
);

-- Inser Data
INSERT INTO [minions] ([id], [name], [age]) VALUES ('1', 'Kevin', '15');
INSERT INTO [minions] ([id], [name], [age]) VALUES ('2', 'Bob', '22');
INSERT INTO [minions] ([id], [name], [age]) VALUES ('3', 'Steward', '42');

-- Select
SELECT [name],[age] FROM [minions];