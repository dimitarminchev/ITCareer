-- Crate Database 
CREATE SCHEMA minions;

-- Use Database minions
USE minions;

-- Create Table minions
CREATE TABLE IF NOT EXISTS minions
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
age INT NULL,
CONSTRAINT pk_minions PRIMARY KEY (id)
);

-- Create Table towns
CREATE TABLE IF NOT EXISTS towns
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
CONSTRAINT pk_towns PRIMARY KEY (id)
);

-- Alter Table minions
ALTER TABLE minions
ADD COLUMN town_id INT NOT NULL;
ALTER TABLE minions
ADD CONSTRAINT fk_minions_towns FOREIGN KEY (town_id) REFERENCES towns(id);

-- Insert Records in Both Tables
INSERT INTO towns (name) VALUES ('Sofia');
INSERT INTO towns (name) VALUES ('Plovdiv'); 
INSERT INTO towns (name) VALUES ('Varna');
INSERT INTO minions (name, age, town_id) VALUES ('Kevin', 22, 1);
INSERT INTO minions (name, age, town_id) VALUES ('Bob', 15, 3);
INSERT INTO minions (name, age, town_id) VALUES ('Steward', 10, 2);
