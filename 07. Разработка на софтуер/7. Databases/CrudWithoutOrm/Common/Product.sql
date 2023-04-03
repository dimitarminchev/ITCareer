-- Note: Do not forget to create database first.
CREATE TABLE [Products]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(100) NOT NULL,
	[Price] DECIMAL(10,2),
	[Stock] INT
);
