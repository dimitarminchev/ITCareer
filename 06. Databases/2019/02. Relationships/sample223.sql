/* 2.2. Relationships */

-- Problem 3. Many-To-Many връзка
CREATE DATABASE IF NOT EXISTS `sample223`;

USE `sample223`;

CREATE TABLE IF  NOT EXISTS `students`
(
    `student_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS `exams`
(
    `exam_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(50) NOT NULL
);
ALTER TABLE `exams` AUTO_INCREMENT = 101;

CREATE TABLE IF NOT EXISTS `students_exams`
(
    `student_id` INT NOT NULL,
    `exam_id` INT NOT NULL,
    PRIMARY KEY (`student_id`,`exam_id`),
    FOREIGN KEY (`student_id`) REFERENCES `students`(`student_id`),
    FOREIGN KEY (`exam_id`) REFERENCES `exams`(`exam_id`)
);

INSERT INTO `students` (`name`) VALUES ("Mila");
INSERT INTO `students` (`name`) VALUES ("Tony");
INSERT INTO `students` (`name`) VALUES ("Ron");
   
INSERT INTO `exams` (/*exam_id,*/`name`) VALUES (/*101,*/"Spring MVC");
INSERT INTO `exams` (/*exam_id,*/`name`) VALUES (/*102,*/"Neo4j");
INSERT INTO `exams` (/*exam_id,*/`name`) VALUES (/*103,*/"Oracle 11g");
 
INSERT INTO `students_exams`(`student_id`,`exam_id`) VALUES (1,101);
INSERT INTO `students_exams`(`student_id`,`exam_id`)  VALUES (1,102);
INSERT INTO `students_exams`(`student_id`,`exam_id`)  VALUES (2,101);
INSERT INTO `students_exams`(`student_id`,`exam_id`)  VALUES (3,103);
INSERT INTO `students_exams`(`student_id`,`exam_id`) VALUES (2,102);
INSERT INTO `students_exams`(`student_id`,`exam_id`)  VALUES (2,103);
 