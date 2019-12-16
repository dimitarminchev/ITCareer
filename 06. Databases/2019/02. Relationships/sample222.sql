/* 2.2. Relationships */

-- Problem 2. One-To-Many връзка
CREATE DATABASE IF NOT EXISTS `sample222`;

CREATE TABLE IF NOT EXISTS `sample222`.`manufactures`
(
	`manufacturer_id` INT AUTO_INCREMENT PRIMARY KEY,
	`name` VARCHAR(50),
	`established_on` DATETIME 
);

INSERT INTO  `sample222`.`manufactures` (`manufacturer_id`,`name`,`established_on`) VALUES ('1','BMW', STR_TO_DATE('01/03/1916', '%d/%m/%Y'));
INSERT INTO  `sample222`.`manufactures` (`name`,`established_on`) VALUES ('Tesla',STR_TO_DATE('01/01/2003', '%d/%m/%Y'));
INSERT INTO  `sample222`.`manufactures` (`name`,`established_on`) VALUES ('Lada',STR_TO_DATE('01/05/1966','%d/%m/%Y'));

CREATE TABLE IF NOT EXISTS `sample222`.`models`
(
	`model_id` INT AUTO_INCREMENT PRIMARY KEY,
	`name` VARCHAR(50),
	`manufacturer_id` INT ,
	CONSTRAINT `fk_manunfacturer_id` FOREIGN KEY(`manufacturer_id`) REFERENCES `sample222`.`manufactures` (`manufacturer_id`)
);

INSERT INTO  `sample222`.`models` (`model_id`,`name`,`manufacturer_id`) VALUES ('101','X1', '1');
INSERT INTO  `sample222`.`models` (`name`,`manufacturer_id`) VALUES ('i6', '1');
INSERT INTO  `sample222`.`models` (`name`,`manufacturer_id`) VALUES ('Model S', '2');
INSERT INTO  `sample222`.`models` (`name`,`manufacturer_id`) VALUES ('Model X', '2');
INSERT INTO  `sample222`.`models` (`name`,`manufacturer_id`) VALUES ('Model 3', '2');
INSERT INTO  `sample222`.`models` (`name`,`manufacturer_id`) VALUES ('Nova', '3');