/* 221. One to One Relationship */
CREATE SCHEMA db221;
USE db221;
CREATE TABLE passports(
	passport_id INT,
    passport_number CHAR(8) NOT NULL ,
	CONSTRAINT pk_db22_passports PRIMARY KEY(passport_id)
);
CREATE TABLE persons(
	person_id INT,
    first_name VARCHAR(25) NOT NULL,
    salary DECIMAL(10,2) NULL,
    passport_id INT UNIQUE,
    CONSTRAINT pk_db22_persons PRIMARY KEY(person_id),
    FOREIGN KEY (passport_id) REFERENCES passports(passport_id)
);