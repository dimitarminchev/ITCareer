-- Drop Database
DROP DATABASE IF EXISTS shop;
GO

-- Create Database
CREATE DATABASE shop;
GO

-- Use Dataase
USE shop;
GO

-- Create Table
CREATE TABLE product
(
	Id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Price DECIMAL(10,2),
	Stock INT
);
GO