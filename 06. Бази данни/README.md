# Модул 6. Бази данни
[Материали](06.%20Бази%20данни.%20Материали.zip) |
[Задачи](06.%20Бази%20данни.%20Задачи.pdf) |
[Решения](06.%20Бази%20данни.%20Решения.zip) 

## Съдържание
1. [Въведение в базите данни](01.%20Introduction/)
2. [Моделиране на релационни бази от данни](02.%20Relationships/)	
3. [Заявки за извличане и промяна на данни](03.%20Queries/)	
4. [Сложни заявки за извличане на данни](04.%20Data/) 
5. [Съединения на таблици](05.%20Joins/)
6. [Агрегация и групиране на данни](06.%20Aggregation/)
7. [Скаларни функции, работа с дати, транзакции](07.%20Transactions)
8. [Подготовка за изпит](08.%20Exam%20Preparation) 

## 1. Въведение в базите данни
Базата данни е организирана колекция от информация, като налага правила на съдържащите се данни.
Системата за Управление на Релационна База от Данни (СУРДБ) предоставя инструменти за управление на база данни.
Релационно съхранение, първо предложено от Едгар Код през 1970 г.

### Инсталация
http://dev.mysql.com/downloads/windows/installer/
- MySQL Community Server
- MySQL Workbench

### Типове данни 
https://dev.mysql.com/doc/refman/5.5/en/storage-requirements.html

#### Numeric
| Data Type                  | Storage Required                                  |
|----------------------------|---------------------------------------------------|
| TINYINT                    | 1 byte                                            |
| SMALLINT                   | 2 bytes                                           |
| MEDIUMINT                  | 3 bytes                                           |
| INT, INTEGER               | 4 bytes                                           |
| BIGINT                     | 8 bytes                                           |
| FLOAT(p)                   | 4 bytes if 0 <= p <= 24, 8 bytes if 25 <= p <= 53 |
| FLOAT                      | 4 bytes                                           |
| DOUBLE [PRECISION], REAL   | 8 bytes                                           |
| DECIMAL(M,D), NUMERIC(M,D) | Varies; see following discussion                  |
| BIT(M)                     | approximately (M+7)/8 bytes                       |

#### Date and Time 
| Data Type | Storage Required |
|-----------|------------------|
| DATE      | 3 bytes          |
| TIME      | 3 bytes          |
| DATETIME  | 8 bytes          |
| TIMESTAMP | 4 bytes          |
| YEAR      | 1 byte           |

#### String 
| Data Type | Storage |
| --- | --- |
| CHAR(M) | The compact family of InnoDB row formats optimize storage for variable-length character sets. See COMPACT Row Format Storage Characteristics. Otherwise, M × w bytes, <= M <= 255, where w is the number of bytes required for the maximum-length character in the character set. |
| BINARY(M)	M bytes | 0 <= M <= 255 |
| VARCHAR(M), VARBINARY(M) | L + 1 bytes if column values require 0 − 255 bytes | L + 2 bytes if values may require more than 255 bytes |
| TINYBLOB, TINYTEXT | L + 1 bytes, where L < 2^8 |
| BLOB, TEXT | L + 2 bytes, where L < 2^16 |
| MEDIUMBLOB, MEDIUMTEXT | L + 3 bytes, where L < 2^24 |
| LONGBLOB, LONGTEXT | L + 4 bytes, where L < 2^32 |            
| ENUM('value1','value2'...)  | 1 or 2 bytes  depending on the number of enumeration values (65,535 values maximum) |
| SET('value1','value2'...)	  | 1,2,3,4 or 8 bytes depending on the number of set members (64 members maximum) |

### Упражнение
```sql
/* Създаване на нова база данни */
CREATE SCHEMA minions;

/* Избор на база данни по подразбиране */
USE minions;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS minions
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
age INT NULL,
CONSTRAINT pk_minions PRIMARY KEY (id)
);

/* Извеждане на всички записи от таблица  */
SELECT * FROM minions;

/* Добавяне на нови записи в таблица */
INSERT INTO minions (name, age) VALUES ('Kevin', '15');
INSERT INTO minions (name, age) VALUES ('Bob', '22');
INSERT INTO minions (name) VALUES ('Steward');

/* Актуализация на запис от таблица */
UPDATE minions SET age=10 WHERE id=3;

/* Актуализация на всички записи от таблица */
UPDATE minions SET age=age+1;

/* Изтриване на запис от таблица */
DELETE FROM minions WHERE id=2;

/* Изтриване на всички записи от таблица */
DELETE FROM minions;

/* Изтриване на таблица */
DROP TABLE minions;

/* Изтриване на база данни */
DROP SCHEMA minions;
```

## 2. Моделиране на релационни бази от данни
### Връзка: едно към едно [1..1]
```sql
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

### Едно към много [1..N]
```sql
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

### Много към много [N..M]
```sql
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

### Релационна схема  (Entity/Relationship)
#### softuni
![softuni.png](02.%20Relationships/softuni.png)

#### geography
![geography.png](02.%20Relationships/geography.png)

#### diablo
![diablo.png](02.%20Relationships/diablo.png)

### Каскадни операции
```sql
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

## 3. Заявки за извличане и промяна на данни
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

## 4. Сложни заявки за извличане на данни

### Форматиране
**Псевдонимите** служат за именуване на колони и таблици
```sql
SELECT c.duration, c.acg AS 'Access Control Gateway' 
FROM calls AS c;
```
Клаузата **ORDER BY** се ползва за сортиране на редовете, във възходящ **ASC** (по подразбиране) или в низходящ **DESC** ред.
```sql
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` ASC;
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` DESC;
```
Клаузата **LIMIT** ни помага да ограничим броя на извежданите записи.
```sql
-- Извежда данни за най-високия връх на планетата
SELECT * FROM `geography`.`peaks` ORDER BY `elevation` DESC LIMIT 1;

-- Извличане на третия от най-старите служители
SELECT `last_name`, `hire_date` FROM `soft_uni`.`employees` ORDER BY `hire_date` LIMIT 2, 1;
```

### Подзаявки
Заявките могат да бъдат вложени една в друга
```sql
SELECT * 
FROM employees 
WHERE department_id IN 
(
   SELECT department_id 
   FROM departments 
   WHERE name = 'Finance'
);
```
**SELECT** изразите може да бъдат влагани в **WHERE** клаузата
```sql
SELECT FirstName, LastName, Salary 
FROM Employees
WHERE Salary = 
(
	SELECT Salary 
	FROM Employees 
	ORDER BY Salary DESC LIMIT 1
)
```

#### Всички върхове в България
Покажете списък с имената на всички върхове в България
- Намерете планините в България
- После покажете върховете от тези планини
- Сортирайте резултата по височина, в намаляващ ред 
```sql
SELECT peak_name, elevation 
FROM peaks 
WHERE mountain_id IN
(
    SELECT mountain_id 
    FROM mountains_countries   
    WHERE country_code = 'BG'
)
ORDER BY elevation DESC;
```

#### Оператори ALL, ANY и SOME
- **ALL** = дали условието е в сила за всички стойности
- **ANY** = дали условието е в сила за поне една от стойностите
- **SOME** = синоним на ANY
```sql
SELECT FirstName, LastName, DepartmentID, Salary 
FROM Employees
WHERE DepartmentID = ANY 
(
	SELECT DepartmentID 
	FROM Departments 
	WHERE Name='Sales'
)
```
Таблична подзаявка
```sql
SELECT FirstName, LastName, DepartmentID, Salary 
FROM Employees
WHERE (DepartmentID, ManagerID) = ANY 
(
	SELECT DepartmentID, ManagerID 
	FROM Departments 
	WHERE Name='Sales'
)
```

### Взаимосвързани заявки
Таблиците от външния SELECT може да бъдат споменати във вътрешния SELECT чрез псевдоними и използвани в неговите условия. Такива заявки наричаме **взаимосвързани**.
```sql
SELECT FirstName, LastName, DepartmentID, Salary
FROM Employees e 
WHERE Salary = 
(
	SELECT Salary 
	FROM Employees 
	WHERE DepartmentID = e.DepartmentID   
	ORDER BY Salary DESC LIMIT 1
)
ORDER BY DepartmentID
```
При други подзаявки вътрешния SELECT не ползва външния и може да бъде ползван самостоятелно. Такива заявки наричаме **необвързани**. 
```sql
SELECT FirstName, LastName, DepartmentID, Salary
FROM Employees 
WHERE Salary = 
(
	SELECT Salary 
	FROM Employees 
	ORDER BY Salary DESC LIMIT 1
)
ORDER BY DepartmentID
```

#### EXISTS
При **EXISTS** условието е вярно, ако подзаявката връща записи
```sql
SELECT first_name, first_name, department_id, salary 
FROM employees e 
WHERE EXISTS
( 
	SELECT d.department_id FROM departments d
	WHERE e.department_id = d.department_id AND d.name = 'Finance' 
);
```

#### NOT EXISTS
Намерете най-високата заплата на служител извън отдел Финанси и работника, който я получава
```sql
SELECT first_name, first_name, department_id, salary 
FROM employees e WHERE NOT EXISTS
( 
	SELECT d.department_id 
	FROM departments d
	WHERE e.department_id = d.department_id AND d.name = 'Finance' 
)
ORDER BY salary DESC LIMIT 1;
```

### Обединяване на заявки
Да се изведе списък с имената на всички планини и реки
```sql
(
	SELECT river_name 
	FROM rivers
) 
UNION 
(
	SELECT mountain_range 
	FROM mountains
)
```
- Броят на колоните в двете заявки трябва да е един и същ
- За имена на колони в резултата се взимат имената на колоните от първата заявка
- Типът на колони от двете таблици не е нужно да е един и същ
- Може да дадете друго име на колоните чрез псевдоними
- В резултата няма да присъстват повтарящи се редове

## 5. Съединения на таблици 
- JOIN
- INNER JOIN
- OUTER JOIN (LEFT and RIGHT)
- FULL JOIN (LEFT JOIN UNION RIGHT JOIN) and CROSS JOIN

### JOIN
#### Декартово произведение
Декартово произведение получаваме, когато **JOIN** условието липсва или е невалидно.
```sql
USE `soft_uni`;
SELECT concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees`, `departments`;
```
293 employee x 16 departmens = 4688

#### Връзки между таблици 
Релациите между таблици са полезни, когато са съчетани с връзки **JOIN**. Така можем да извлечем данни едновременно от две таблици.
```sql
USE `soft_uni`;
SELECT  concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees` 
JOIN `departments` 
 ON `departments`.`department_id` = `employees`.`department_id`;
```
**Бележка**: връзките с JOIN са по-производителни от вложените SELECT

#### Задача: Върхове в Рила
Използвайте базата данни **Geography**. 
Изведете справка за всички върхове в планината **Rila**. 
Справката да включва имената на планината, на върха и височината на върха.
Върховете да са сортирани по височина, в намаляващ ред.
```sql
USE `geography`;
SELECT m.`mountain_range`, p.`peak_name`, p.`elevation`
FROM `mountains` AS m
JOIN `peaks` AS p 
 ON p.`mountain_id` = m.`id`
WHERE m.`mountain_range` = "Rila"
ORDER BY p.`elevation` DESC;
```

### INNER JOIN
Ако се използва само **JOIN**, се подразбира **INNER JOIN**.

#### Задача: Адреси с градове
Покажете информация за адреса на всички служители в базата данни **SoftUni**. Изберете първите 5 служителя. Подредете ги по **first_name**, после по **last_name** (възходящо). Съвет:  Използвайте връзка (**JOIN**) между три таблици.
```sql
SELECT e.first_name, e.last_name,  t.name as town, a.address_text
FROM employees AS e
 INNER JOIN addresses AS a ON e.address_id = a.address_id
 INNER JOIN towns AS t  ON a.town_id = t.town_id
ORDER BY e.first_name, e.last_name LIMIT 5;
```

#### Задача: Служители по продажбите
Намерете всички служители, които са в отдел **Sales**. Използвайте базата данни **SoftUni**.
Следвайте специфичния формат. Подредете ги по employee_id низходящо.
```sql
SELECT e.employee_id, e.first_name, e.last_name, d.name AS department_name
FROM employees AS e 
 INNER JOIN departments AS d ON e.department_id = d.department_id
WHERE d.name = 'Sales'
ORDER BY e.employee_id DESC;
```

#### Задача: Служители наети след дата
Покажете всички служители, които:
- Са наети след **1/1/1999**.
- Са в някой от отделите **Sales** или **Finance**.
- Сортирайте по **hire_date** (възходящо).
```sql
SELECT e.first_name, e.last_name, e.hire_date, d.name
FROM employees e
  INNER JOIN departments AS d
  ON (e.department_id = d.department_id AND DATE(e.hire_date) > '1999/1/1' AND d.name IN ('Sales', 'Finance'))
ORDER BY e.hire_date;
```

### 5.3. OUTER JOIN 
#### LEFT OUTER JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от лявата таблица.
```sql
SELECT * FROM employees AS e
LEFT OUTER JOIN departments AS d
ON e.department_id = d.department_id;
```

#### RIGHT OUTER JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от дясната таблица.
```sql
SELECT * FROM employees AS e
RIGHT OUTER JOIN departments AS d
ON e.department_id = d.department_id;
```

#### Задача: Страни, в които няма планини
Изведете броя на страните, в които няма планини.
Използвайте базата данни **Geography**.
```sql
SELECT  COUNT(*) AS country_count  
FROM  countries AS c
LEFT JOIN mountains_countries AS mc
ON c.country_code = mc.country_code
WHERE mc.mountain_id IS NULL;
```

### 5.4. FULL JOIN AND CROSS JOIN
- FULL JOIN обединява LEFT JOIN и RIGHT JOIN.
- CROSS JOIN комбинира всеки ред от първата таблица с всеки ред от втората.

#### FULL JOIN
Тази връзка връща записите, отговарящи на свързващото условие и също така несъвпадащите записи от лявата и от дясната таблица.
```sql
SELECT * FROM employees AS e
LEFT OUTER JOIN departments AS d
ON e.department_id=d.department_id
UNION
SELECT * FROM employees AS e
RIGHT OUTER JOIN departments AS d
ON e.department_id=d.department_id;
```

#### CROSS JOIN
При тази връзка всеки ред от първата таблица е комбиниран с всеки ред от втората.
```sql
SELECT * FROM employees AS e
CROSS JOIN departments AS d;
```

## 6. Агрегация и групиране на данни
- GROUP BY
- COUNT, SUM, MAX, MIN, AVG
- HAVING

### Групиране
С **GROUP BY** можете да извлечете всяка отделна група и да използвате "агрегираща" функция върху нея (AVG, MIN, MAX):

```sql
SELECT e.`department_id` 
FROM `employees` AS e
GROUP BY e.`department_id`;
```

С **DISTINCT** ще получите всички уникални стойности:
```sql
SELECT DISTINCT e.`department_id`
FROM `employees` AS e;
```

### Агрегации
Агрегиращите функции се използват, за да се извършват операции върху една или повече групи елементи, извършвайки анализ върху тях. 

**COUNT** брои всички стойности (които не са NULL) в една или повече колони, според даден критерий.
```sql
SELECT e.`department_id`, COUNT(e.`salary`) AS 'Salary Count'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

**SUM** сумира всички стойности в колоната
```sql
SELECT e.`department_id`, SUM(e.`salary`) AS 'TotalSalary'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

**MAX** дава максималната стойност в колоната.
```sql
SELECT e.`department_id`, MAX(e.`salary`) AS 'MaxSalary'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

**MIN** връща минималната стойност в колоната.
```sql
SELECT e.`department_id`, MIN(e.`salary`) AS 'MinSalary'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

**AVG** изчислява средната стойност в колона.
```sql
SELECT e.`department_id`, AVG(e.`salary`) AS 'AvgSalary'
FROM `employees` AS e
GROUP BY e.`department_id`;
```

### Филтриране
Клаузата **HAVING** се използва, за да се филтрира информация според стойностите от агрегирането. Това значи, че не можем да използваме HAVING без да сме извършили групиране преди това. За разлика от HAVING, WHERE извършва филтриране преди да се случи агрегирането.

```sql
SELECT e.`department_id`,  SUM(e.salary) AS 'TotalSalary'
FROM `employees` AS e
GROUP BY e.`department_id`
HAVING `TotalSalary` < 250000;
```

## 7. Скаларни функции, работа с дати, транзакции
- CREATE PROCEDURE
- CREATE FUNCTION
- START TRANSACTION + ROLLBACK + COMMIT
- CREATE TRIGGER (BEFORE|AFTER + INSERT|UPDATE|DELETE)

### Функции
- Винаги връщат стойност
- Могат да приемат параметри
- Могат да са вложени

**Деклариране на функция
```sql
DELIMITER $$
CREATE FUNCTION udf_project_weeks (start_date DATETIME, end_date DATETIME)
RETURNS INT
BEGIN
	DECLARE project_weeks INT;
	IF(end_date IS NULL) THEN
		SET end_date := NOW();	
	END IF;
	SET project_weeks := DATEDIFF(DATE(end_date), DATE(start_date)) / 7;
	RETURN project_weeks;
END $$
```

**Изпълнение на функция**
```sql
SELECT p.project_id, 
	DATE(p.start_date) AS 'start_date', 
	DATE(p.end_date) AS 'end_date',
	udf_project_weeks(p.start_date, p.end_date) AS 'project_weeks'
FROM projects AS p;
```

### Транзакции
Транзакцията е поредица от действия (операции в базата данни) изпълнявани като цялост или всички се изпълняват заедно успешно или нито едно от тях не се изпълнява.

Транзакциите гарантират пълнотата и цялостността на базата данни.
- Всички промени в транзакцията са временни.
- Промените се съхраняват едва след изпълнението на **COMMIT**.
- По всяко време всички промени могат да се отменят чрез **ROLLBACK**.
- Всички операции се изпълняват като едно цяло.

```sql
START TRANSACTION
UPDATE accounts SET balance = balance – withdraw_amount
WHERE id = account
IF ROW_COUNT() <> 1 THEN -- Affected rows are different than one.
	SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid account';
	ROLLBACK;
ELSE 
	COMMIT;
END IF;
```

### Съхранени процедури
Съхранените процедури:
- Капсулират повтаряща се програмна логика.
- Могат да приемат входни параметри.
- Могат да връщат изходни резултати.

**Създаване на съхранена процедура**
```sql
DELIMITER $$
CREATE PROCEDURE usp_select_employees_by_seniority() 
BEGIN
  SELECT * 
  FROM employees
  WHERE ROUND((DATEDIFF(NOW(), hire_date) / 365.25)) < 15;
END $$
```

**Изпълняване на съхранени процедури**
```sql
CALL usp_select_employees_by_seniority();
```

**Изтриване на съхранени процедури**
```sql
DROP PROCEDURE usp_select_employees_by_seniority;
```

**Дефиниране на параметризирани процедури**
```sql
DELIMITER $$
CREATE PROCEDURE usp_select_employees_by_seniority(min_years_at_work INT)
BEGIN
  SELECT first_name, last_name, hire_date,
    ROUND(DATEDIFF(NOW(),DATE(hire_date)) / 365.25,0) AS 'years'
  FROM employees
  WHERE ROUND(DATEDIFF(NOW(),DATE(hire_date)) / 365.25,0) > min_years_at_work
  ORDER BY hire_date;
END $$

CALL usp_select_employees_by_seniority(15);
```

**Връщане на стойности**
```sql
CREATE PROCEDURE usp_add_numbers
(first_number INT,
second_number INT,
   OUT result INT)
BEGIN
   SET result = first_number + second_number
END $$
DELIMITER ;

SET @answer=0;
CALL usp_add_numbers(5, 6,@answer);
SELECT @answer;

-- 11
```

### Тригери
Тригерите много приличат на съхранените процедури.
Извикват се в случай на дадено събитие.
Не извикваме тригерите изрично.
- Тригерите се прикрепят към таблицата.
- Тригерите се изпълняват, когато определена SQL заявка се изпълнява върху съдържанието на таблицата.
- Например при добавяне на нов ред в таблицата.

```sql
DELIMITER $$
CREATE TRIGGER tr_delete_records
AFTER DELETE
ON employees_projects
FOR EACH ROW
BEGIN
	INSERT INTO employees_projects_history
	      (employee_id, project_id)
	VALUES(old.employee_id, old.project_id);
END $$
```

## 8. Подготовка за изпит
- [Buhtig Source Control]((08.%20Exam%20Preparation/Buhtig%20Source%20Control)
- [Colonial Journey Management System]((08.%20Exam%20Preparation/Colonial%20Journey%20Management%20System)
- [Plant Service]((08.%20Exam%20Preparation/Plan%20Service)
