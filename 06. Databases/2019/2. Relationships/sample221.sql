/* 2.2. Relationships */

-- Problem 1. One-To-One връзка
CREATE DATABASE IF NOT EXISTS `sample221`;

CREATE TABLE `sample221`.`passports` (
  `passport_id` INT PRIMARY KEY AUTO_INCREMENT ,
  `passport_number` TEXT
);

ALTER TABLE `sample221`.`passports` AUTO_INCREMENT=101;

INSERT INTO `sample221`.`passports` (`passport_number`) VALUES ("N34FG21B");
INSERT INTO `sample221`.`passports` (`passport_number`) VALUES ("K65LO4R7");
INSERT INTO `sample221`.`passports` (`passport_number`) VALUES ("ZE657QP2");

CREATE TABLE `sample221`.`persons` (
  `person_id` INT PRIMARY KEY AUTO_INCREMENT,
  `first_name` TEXT,
  `salary` DECIMAL(10,2) DEFAULT 0,
  `passport_id` INT,
  CONSTRAINT `fk_passport` FOREIGN KEY (`passport_id`) REFERENCES `sample221`.`passports`(`passport_id`)
);

INSERT INTO `sample221`.`persons` (`first_name`,`salary`,`passport_id`) VALUES ("Roberto","43300.00",102);
INSERT INTO `sample221`.`persons` (`first_name`,`salary`,`passport_id`) VALUES ("Tom","56100.00",103);
INSERT INTO `sample221`.`persons` (`first_name`,`salary`,`passport_id`) VALUES ("Yana","60200.00",101);