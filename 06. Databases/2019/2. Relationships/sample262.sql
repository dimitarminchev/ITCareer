/* 2.6. Relationships */

-- Problem 2. Университетска база данни
/* DROP DATABASE IF EXISTS `sample262`; */
CREATE DATABASE IF NOT EXISTS `sample262`;
USE `sample262`;
CREATE TABLE IF NOT EXISTS `subjects`
(
	`subject_id` INT NOT NULL PRIMARY KEY,
    `name` VARCHAR(50)
); 
CREATE TABLE IF NOT EXISTS `majors`
(
	`major_id` INT NOT NULL PRIMARY KEY,
    `name`  VARCHAR(50)
);
CREATE TABLE IF NOT EXISTS `students`
(
	`student_id` INT NOT NULL PRIMARY KEY,
    `student_number`  VARCHAR(12),
    `student_name`  VARCHAR(50),
    `major_id` INT NOT NULL,
    FOREIGN KEY (`major_id`) REFERENCES `majors`(`major_id`)
); 
CREATE TABLE IF NOT EXISTS `payments`
(
	`payment_id` INT NOT NULL PRIMARY KEY,
    `payment_date`  DATE,
    `payment_amount` DECIMAL(8,2),
    `student_id` INT NOT NULL,
    FOREIGN KEY (`student_id`) REFERENCES `students`(`student_id`)
);
CREATE TABLE IF NOT EXISTS `agenda`
(
	`student_id` INT NOT NULL,
    `subject_id` INT NOT NULL,
    FOREIGN KEY (`student_id`) REFERENCES `students`(`student_id`),
    FOREIGN KEY (`subject_id`) REFERENCES `subjects`(`subject_id`),
    PRIMARY KEY(`student_id`,`subject_id`)
);