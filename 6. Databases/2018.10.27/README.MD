#  Въведение в Базите от Данни

- MySQL Community Server http://dev.mysql.com/downloads/mysql/
- HeidiSQL http://www.heidisql.com/download.php
```
/* HeidiSQL fix for MySQL Server 8+ (must be Executed in MySQL Workbench) */
ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'root';
```

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
## Упражнение 3
```
/* Избор на база данни по подразбиране */
USE minions;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS users
(
id BIGINT NOT NULL AUTO_INCREMENT,
username VARCHAR(30) NOT NULL,
password VARCHAR(26) NOT NULL,
profile_picture BLOB,
last_login_time DATETIME,
is_deleted INT,
CONSTRAINT pk_users PRIMARY KEY (id)
);

/* Добавяне на нови записи в таблица */
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('pesho', '123456', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('gosho', '234567', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('mitko', '345678', NULL, NOW(), 1);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('cecko', '456789', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('bosko', '5678910', NULL, NOW(), 1);

/* Извеждане на броя записи от таблица  */
SELECT COUNT(*) FROM users;

/* Актуализация на първичния ключ */
ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id, username);

/* Задаване на стойност по подразбиране на поле */
ALTER TABLE users
	CHANGE COLUMN last_login_time last_login_time DATETIME NULL DEFAULT CURRENT_TIMESTAMP;

/* Задаване на изискване за уникалност на поле от таблицата */
ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id),
	ADD CONSTRAINT uc_username UNIQUE (username);
```
## Упражнение 4
```
/* Създаване на нова база данни */
CREATE SCHEMA movies;

/* Избор на база данни по подразбиране */
USE movies;

/* Създаване на нови таблици */
CREATE TABLE IF NOT EXISTS directors
(
id INT NOT NULL AUTO_INCREMENT,
director_name VARCHAR(50) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_directors PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS genres
(
id INT NOT NULL AUTO_INCREMENT,
genre_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_genres PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS categories
(
id INT NOT NULL AUTO_INCREMENT,
category_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_categories PRIMARY KEY (id)
);
CREATE TABLE IF NOT EXISTS movies
(
id INT NOT NULL AUTO_INCREMENT,
title VARCHAR(50) NOT NULL,
director_id INT NOT NULL,
copyright_year SMALLINT,
length INT,
genre_id INT,
category_id INT,
rating FLOAT,
notes VARCHAR(1000),
CONSTRAINT pk_movies PRIMARY KEY (id)
);

/* Добавяне на нови записи в таблица */
INSERT INTO directors (director_name, notes) VALUES ('Ben Affleck', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Woody Allen', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Luc Besson', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Cameron Crowe', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Clint Eastwood', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Action', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Comedy', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Horror', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Thriller', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Drama', 'sample notes');
INSERT INTO categories (category_name, notes) VALUES ('0-3', 'suitable for infants');
INSERT INTO categories (category_name, notes) VALUES ('7-12', 'suitable for kids');
INSERT INTO categories (category_name, notes) VALUES ('12-16', 'suitable for teenagers');
INSERT INTO categories (category_name, notes) VALUES ('16-18', NULL);
INSERT INTO categories (category_name, notes) VALUES ('18+', 'suitable for adults');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Titanic', 1, 1998, 181, 1, 4, 8.2, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Avatar', 4, 2008, 160, 2, 3, 9.22, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 1', 2, 1980, 90, 3, 1, 9.99, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 2', 3, 1983, 92, 5, 2, 10.1, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 3', 1, 1986, 95, 1, 5, 6.2, 'sample notes');

/* Извеждане на броя записи в таблиците  */
SELECT COUNT(*) FROM directors;
SELECT COUNT(*) FROM genres;
SELECT COUNT(*) FROM categories;
SELECT COUNT(*) FROM movies;
```
