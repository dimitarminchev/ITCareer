#  Въведение в Базите от Данни

MySQL Community Server
http://dev.mysql.com/downloads/mysql/

HeidiSQL 
http://www.heidisql.com/download.php

## Упражнение 1
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

## Упражнение 2
```
/* Избор на база данни по подразбиране */
USE minions;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS people
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(200) NOT NULL,
picture BLOB,
height NUMERIC(10, 2),
weight NUMERIC(10, 2),
gender CHAR(1) NOT NULL,
birthdate DATETIME NOT NULL,
biography VARCHAR(10000),
CONSTRAINT pk_people PRIMARY KEY (id)
);

/* Добавяне на нови записи в таблица */
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Kevin', NULL, 1.82, 82.24, 'm', '2001-02-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Marie Poppinz', NULL, 1.60, 40.55, 'f', '2001-03-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Steward', NULL, 1.84, 95.00, 'm', '2001-04-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Bob Bob', NULL, 1.86, 101.99, 'm', '2001-11-06', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('An Ann Annie', NULL, 1.72, 60.22, 'f', '2001-12-01', 'Some biography here');

/* Извеждане на броя записи от таблица  */
SELECT COUNT(*) FROM people;
```
