/* database school */
CREATE SCHEMA IF NOT EXISTS `school`;
USE `school`;

CREATE TABLE IF NOT EXISTS `students` 
( 
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
    `age` INT(3) NULL,
	`phone_number` VARCHAR(50)  NULL,
    PRIMARY KEY (`id`)
); 
INSERT INTO `students` (`id`, `name`, `age`) VALUES ('1', 'Mitko', '42');
INSERT INTO `students` (`id`, `name`, `age`) VALUES ('2', 'Ani', '36');
INSERT INTO `students` (`id`, `name`, `age`) VALUES ('3', 'Peter', '4');

CREATE TABLE IF NOT EXISTS `classes` 
(
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
	`max_students` INT(3) NULL,
	PRIMARY KEY (`id`)
);
INSERT INTO `classes` (`id`, `name`, `max_students`) VALUES ('1', 'Introduction to programming', '15');
INSERT INTO `classes` (`id`, `name`, `max_students`) VALUES ('2', 'Algorithms and data structure', '10');
INSERT INTO `classes` (`id`, `name`, `max_students`) VALUES ('3', 'Databases', '2');

CREATE TABLE IF NOT EXISTS `teachers`
(
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
	`class` TEXT NULL,
	PRIMARY KEY (`id`)
);
INSERT INTO `teachers` (`id`, `name`, `class`) VALUES ('1', 'Dimitar Minchev', 'Introduction to programming');
INSERT INTO `teachers` (`id`, `name`, `class`) VALUES ('2', 'Dimitar Minchev', 'Algorithms and data structure');
INSERT INTO `teachers` (`id`, `name`, `class`) VALUES ('3', 'Dimitar Minchev', 'Databases');

CREATE TABLE IF NOT EXISTS `towns`
(
   `id` INT(3) NOT NULL,
   `name` VARCHAR(40) NOT NULL,
   PRIMARY KEY (`id`)
);
INSERT INTO `towns` (`id`,`name`) VALUES (1,"Burgas");
INSERT INTO `towns` (`id`,`name`) VALUES (2,"Sofia");
INSERT INTO `towns` (`id`,`name`) VALUES (3,"Varna");

ALTER TABLE `students` 
ADD COLUMN `townid` INT NULL AFTER `phone_number`;

ALTER TABLE `students` 
ADD CONSTRAINT `fk_students_towns`
  FOREIGN KEY (`id`)
  REFERENCES `towns` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;