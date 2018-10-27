#  Въведение в Базите от Данни

- MySQL Community Server http://dev.mysql.com/downloads/mysql/
- HeidiSQL http://www.heidisql.com/download.php
```
/* HeidiSQL fix for MySQL Server 8+ (must be Executed in MySQL Workbench) */
ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'root';
```
## Упражнение
```
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
## Помощни материали
- [Minions.sql](Minions.sql)
- [People.sql](People.sql)
- [Users.sql](Users.sql)
- [Movies.sql](Movies.sql)
