/* Създаване на база данни */
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

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS towns
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
CONSTRAINT pk_towns PRIMARY KEY (id)
);

/* Редакция на таблица */
ALTER TABLE minions
ADD COLUMN town_id INT NOT NULL;
ALTER TABLE minions
ADD CONSTRAINT fk_minions_towns FOREIGN KEY (town_id) REFERENCES towns(id);

/* Добавяне на записи в двете таблици */
INSERT INTO towns (name) VALUES ('Sofia');
INSERT INTO towns (name) VALUES ('Plovdiv'); 
INSERT INTO towns (name) VALUES ('Varna');
INSERT INTO minions (name, age, town_id) VALUES ('Kevin', 22, 1);
INSERT INTO minions (name, age, town_id) VALUES ('Bob', 15, 3);
INSERT INTO minions (name, age, town_id) VALUES ('Steward', 10, 2);
