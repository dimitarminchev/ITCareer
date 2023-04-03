-- Step 1. Create Database
CREATE DATABASE [MiniORM];
USE [MiniORM];

-- Step 2. Create Tables 
CREATE TABLE [Projects]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
);
CREATE TABLE [Departments]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL
);
CREATE TABLE [Employees]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[FirstName] VARCHAR(50) NOT NULL,
	[MiddleName] VARCHAR(50),
	[LastName] VARCHAR(50) NOT NULL,
	[IsEmployed] BIT NOT NULL,
	[DepartmentId] INT
	CONSTRAINT FK_Employees_Departments FOREIGN KEY
	REFERENCES [Departments]([Id])
);
CREATE TABLE [EmployeesProjects]
(
	[ProjectId] INT NOT NULL
	CONSTRAINT FK_Employees_Projects REFERENCES [Projects]([Id]),
	[EmployeeId] INT NOT NULL
	CONSTRAINT FK_Employees_Employee REFERENCES [Employees]([Id]),
	CONSTRAINT PK_Projects_Employees
	PRIMARY KEY ([ProjectId], [EmployeeId])
);

-- Step 3. Insert Data
INSERT INTO [Departments] ([Name]) VALUES ('Research');
INSERT INTO [Employees] ([FirstName], [MiddleName], [LastName], [IsEmployed], [DepartmentId]) VALUES
('Stamat', NULL, 'Ivanov', 1, 1),
('Petar', 'Ivanov', 'Petrov', 0, 1),
('Ivan', 'Petrov', 'Georgiev', 1, 1),
('Gosho', NULL, 'Ivanov', 1, 1);
INSERT INTO [Projects] ([Name]) 
VALUES ('C# Project'), ('Java Project');
INSERT INTO [EmployeesProjects] ([ProjectId], [EmployeeId]) VALUES
(1, 1),
(1, 3),
(2, 2),
(2, 3);
