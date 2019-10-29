CREATE DATABASE MiniORM;
USE MiniORM;

CREATE TABLE Projects
(
	Id INT UNIQUE PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE Departments
(
	Id INT UNIQUE PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE Employees
(
	Id INT UNIQUE PRIMARY KEY AUTO_INCREMENT,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	LastName VARCHAR(50) NOT NULL,
	IsEmployed INT NOT NULL,
	DepartmentId INT,
	FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
);

CREATE TABLE EmployeesProjects
(
	ProjectId INT NOT NULL,
	EmployeeId INT NOT NULL,
	FOREIGN KEY (ProjectId) REFERENCES Projects(Id),
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    PRIMARY KEY(ProjectId, EmployeeId)
);

INSERT INTO Departments (Name) VALUES ('Research');
INSERT INTO Employees (FirstName, MiddleName, LastName, IsEmployed, DepartmentId) VALUES
('Stamat', "Petkov", 'Ivanov', 1, 1),
('Petar', 'Ivanov', 'Petrov', 0, 1),
('Ivan', 'Petrov', 'Georgiev', 1, 1),
('Gosho', "Silistrieva", 'Ivanov', 1, 1);
INSERT INTO Projects (Name) 
VALUES ('C# Project'), ('Java Project');
INSERT INTO EmployeesProjects (ProjectId, EmployeeId) VALUES
(1, 1),
(1, 3),
(2, 2),
(2, 3);
