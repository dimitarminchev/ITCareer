# 3. Заявки за извличане и промяна на данни
- [Structured Query Language (SQL)](http://en.wikipedia.org/wiki/SQL)
- [Create, Read, Update and Delete (CRUD)](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete)

Примери
```sql
SELECT first_name, last_name, job_title FROM employees;
SELECT * FROM projects WHERE start_date='2003-06-01';
INSERT INTO projects(name, start_date) VALUES('Introduction to SQL Course', '2006-01-01');
UPDATE projects SET end_date='2006-08-31' WHERE start_date='2006-01-01';
DELETE FROM projects  WHERE start_date = '2006-01-01';
```
Псевдоними
```sql
SELECT c.duration, c.acg AS 'Access Control Gateway' FROM calls AS c;
```
Kонкатенация
```sql
SELECT concat(`first_name`,' ',`last_name`) AS 'Full Name',  `employee_id` AS `No.` FROM `employees`;
```
Филтриране на колони
```sql
SELECT DISTINCT `department_id` FROM `employees`;
SELECT `last_name`, `department_id` FROM `employees` WHERE `department_id` = 1;
SELECT `last_name`, `salary` FROM `employees` WHERE `salary` <= 20000;
```
Сравняване
```sql
SELECT `last_name` FROM `employees` WHERE NOT (`manager_id` = 3 OR `manager_id` = 4);
SELECT `last_name`, `salary`FROM `employees` WHERE `salary` BETWEEN 20000 AND 22000;
SELECT `first_name`, `last_name`, `manager_id` FROM `employees` WHERE `manager_id` IN (109, 3, 16);
```
NULL
```sql
SELECT `last_name`, `manager_id` FROM `employees` WHERE `manager_id` IS NULL;
SELECT `last_name`, `manager_id` FROM `employees` WHERE `manager_id` IS NOT NULL;
```
Вмъкване на данни
```sql
INSERT INTO `towns` VALUES (33, 'Paris');
INSERT INTO projects(`name`, `start_date`) VALUES ('Reflective Jacket', NOW())
INSERT INTO `employees_projects` VALUES (229, 1), (229, 2), (229, 3); 
```
Създаване на таблици
```sql
CREATE TABLE `customer_contacts` AS SELECT `customer_id`, `first_name`, `email`, `phone` FROM `customers`;
INSERT INTO projects(name, start_date) SELECT CONCAT(name,' ', ' Restructuring'), NOW() FROM departments;
```
Изтриване на данни
```sql
DELETE FROM `employees` WHERE `employee_id` = 1;
TRUNCATE TABLE users;
```
Актуализиране на данни
```sql
UPDATE `employees` SET `last_name` = 'Brown' WHERE `employee_id` = 1;
UPDATE `employees` SET `salary` = `salary` * 1.10, `job_title` = CONCAT('Senior',' ', `job_title`) WHERE `department_id` = 3;
```