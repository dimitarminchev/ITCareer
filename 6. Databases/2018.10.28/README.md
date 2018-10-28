# Моделиране на релационни бази от данни
## Връзка: едно към много
```
CREATE TABLE country (
  id INT PRIMARY KEY,
  name TEXT
);
CREATE TABLE city (
  id INT PRIMARY KEY,
  name TEXT,
  country_id INT,
  CONSTRAINT fk_country FOREIGN KEY (id) REFERENCES country(id)
);
```
## Връзка: Много към много
```
CREATE TABLE employees (
  employee_id INT PRIMARY KEY,
  employee_name VARCHAR(50)
);
CREATE TABLE projects (
  project_id INT PRIMARY KEY,
  project_name VARCHAR(50)
);
CREATE TABLE employees_projects (
  employee_id INT,
  project_id INT,
  CONSTRAINT pk_employees_projects PRIMARY KEY(employee_id, project_id),
  CONSTRAINT fk_employees_projects_employees FOREIGN KEY(employee_id) REFERENCES employees(employee_id),
  CONSTRAINT fk_employees_projects_projects FOREIGN KEY(project_id) REFERENCES projects(project_id)
);
```
## Връзка: едно към едно
```
CREATE TABLE drivers (
  driver_id INT PRIMARY KEY,
  driver_name VARCHAR(50)
);
CREATE TABLE cars (
  car_id INT PRIMARY KEY,
  driver_id INT UNIQUE,
  CONSTRAINT fk_cars_drivers FOREIGN KEY (driver_id) REFERENCES drivers(driver_id)
);
```
## Релационна схема  (Entity/Relationship)
- [softuni.sql](softuni.sql)
- [softuni.mwb](softuni.mwb)

![softuni.png](softuni.png)

##  Упражнение
- [221. One to One Relationship](221.sql)
- [221. One to Many Relationship](222.sql)
- [223. Many to Many Relationship](223.sql)
- [224. Cross-Reference Relationship](224.sql)

## Каскадни операции
```
CREATE SCHEMA THES;
USE THES;
CREATE TABLE drivers(
  driver_id INT PRIMARY KEY,
  driver_name VARCHAR(50)
);
CREATE TABLE cars(
  car_id INT PRIMARY KEY,
  driver_id INT,
  CONSTRAINT fk_car_driver FOREIGN KEY(driver_id)
  REFERENCES drivers(driver_id) ON DELETE CASCADE ON UPDATE CASCADE
);
INSERT INTO drivers VALUES (1,'Драган'),(2,'Кънчо'),(3,'Янка');
INSERT INTO cars VALUES (1,1),(2,3),(3,1),(4,2),(5,2),(6,3);

/* Каскадно актуализиране */
UPDATE drivers SET driver_id=42 WHERE driver_id=1;

/* Каскадно изтриеване */
DELETE FROM drivers WHERE driver_id=2;
```
##  Упражнение
- [261. База данни за онлайн магазин](261.sql)
- [262. Университетска база данни](262.sql)
