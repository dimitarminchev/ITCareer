/* 01.01. Въведение в базите данни */

/* Problem 10. Създаване на нова база данни */
CREATE SCHEMA IF NOT EXISTS `school`;

/* students */
CREATE TABLE IF NOT EXISTS `school`.`students` 
( 
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
    `age` INT(3) NULL,
	`phone_number` VARCHAR(50)  NULL,
    PRIMARY KEY (`id`)
); 
INSERT INTO `school`.`students` (`id`, `name`, `age`) VALUES ('1', 'Mitko', '42');
INSERT INTO `school`.`students` (`id`, `name`, `age`) VALUES ('2', 'Ani', '36');
INSERT INTO `school`.`students` (`id`, `name`, `age`) VALUES ('3', 'Peter', '4');

/* classes */
CREATE TABLE IF NOT EXISTS `school`.`classes` 
(
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
	`max_students` INT(3) NULL,
	PRIMARY KEY (`id`)
);
INSERT INTO `school`.`classes` (`id`, `name`, `max_students`) VALUES ('1', 'Introduction to programming', '15');
INSERT INTO `school`.`classes` (`id`, `name`, `max_students`) VALUES ('2', 'Algorithms and data structure', '10');
INSERT INTO `school`.`classes` (`id`, `name`, `max_students`) VALUES ('3', 'Databases', '2');

/* teachers */
CREATE TABLE IF NOT EXISTS `school`.`teachers`
(
	`id` INT(3) NOT NULL,
	`name` VARCHAR(50) NOT NULL,
	`class` TEXT NULL,
	PRIMARY KEY (`id`)
);
INSERT INTO `school`.`teachers` (`id`, `name`, `class`) VALUES ('1', 'Dimitar Minchev', 'Introduction to programming');
INSERT INTO `school`.`teachers` (`id`, `name`, `class`) VALUES ('2', 'Dimitar Minchev', 'Algorithms and data structure');
INSERT INTO `school`.`teachers` (`id`, `name`, `class`) VALUES ('3', 'Dimitar Minchev', 'Databases');

/* Problem 11. Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS `school`.`towns`
(
   `id` INT(3) NOT NULL,
   `name` VARCHAR(40) NOT NULL,
   PRIMARY KEY (`id`)
);
INSERT INTO `school`.`towns` (`id`,`name`) VALUES (1,"Burgas");
INSERT INTO `school`.`towns` (`id`,`name`) VALUES (2,"Sofia");
INSERT INTO `school`.`towns` (`id`,`name`) VALUES (3,"Varna");

/* Problem 9. Свързване на таблици */
ALTER TABLE `school`.`students` 
ADD COLUMN `townid` INT NULL AFTER `phone_number`;

ALTER TABLE `school`.`students` 
ADD CONSTRAINT `fk_students_towns`
  FOREIGN KEY (`id`)
  REFERENCES `school`.`towns` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;