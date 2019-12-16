/* 01.03. Основни команди за работа с таблици */

/* Problem 7. Създайте таблицата People */
CREATE DATABASE IF NOT EXISTS `people`;
CREATE TABLE IF NOT EXISTS `people`.`people`
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `name` VARCHAR(200) NOT NULL,
    `picture` MEDIUMBLOB NULL,
    `height` NUMERIC(10,2) NULL,
    `weight` NUMERIC(10,2) NULL, 
    `gender` CHAR(1) NULL,
    `birthdate` DATETIME NOT NULL,
	`biography` VARCHAR(10000) NULL, 
    CONSTRAINT pk_people PRIMARY KEY (`id`)
);

INSERT INTO `people`.`people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Dimitar Minchev", "183","85","m","1978-08-23");
INSERT INTO `people`.`people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Anelia Tzvetanova", "172","65","f","1986-09-11");
INSERT INTO `people`.`people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Peter Minchev", "106","15","m","2015-06-30");

/* Problem 8. Направете таблицата потребители Users */
CREATE TABLE IF NOT EXISTS `people`.`users`
(
	`id` BIGINT AUTO_INCREMENT NOT NULL,
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(26) NOT NULL,
    `profile_picture` BLOB,
    `last_login_time` DATETIME, 
    `is_deleted` INT NULL, 
    CONSTRAINT `pk_users` PRIMARY KEY (`id`)
);

INSERT INTO `people`.`users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Pesho","1234",now(),0);
INSERT INTO `people`.`users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Maria","qwerty",now(),0);
INSERT INTO `people`.`users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Georgi","gogo",now(),1);

/* Problem 9. Сменете първичния ключ */
ALTER TABLE `people`.`users` 
DROP PRIMARY KEY;

ALTER TABLE `people`.`users`
ADD CONSTRAINT `pk_users` PRIMARY KEY (`id`,`username`);

/* Problem 10. Установете (настройте) стойност по подразбиране на поле */
ALTER TABLE `people`.`users`
MODIFY COLUMN `last_login_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP;

/* Problem 11.	Настройте уникално поле */
ALTER TABLE `people`.`users` 
DROP PRIMARY KEY;

ALTER TABLE `people`.`users`
ADD CONSTRAINT `pk_users` PRIMARY KEY (`id`);

ALTER TABLE `people`.`users`
MODIFY COLUMN `username` VARCHAR(30) NOT NULL UNIQUE;
