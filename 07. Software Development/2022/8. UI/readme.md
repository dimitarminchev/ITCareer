# UI

1. Install [Microsoft SQL Server Express Edition](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)

2. Install [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

3. Locate your connection string
```
Data Source=localhost\SQLEXPRESS; Initial Catalog=shop; Integrated Security=SSPI
```
4. Update Connection String in Files
- [Data/ProductContext.cs]
- [UWPApp/Model/Products.cs]

5. Create Sample Database
```
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
CREATE TABLE products
(
	Id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Price DECIMAL(10,2),
	Stock INT
);
GO
```
Enojy :)