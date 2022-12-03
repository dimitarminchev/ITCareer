/* database people */
CREATE DATABASE IF NOT EXISTS `people`;
USE `people`;

CREATE TABLE IF NOT EXISTS `people`
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

INSERT INTO `people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Dimitar Minchev", "183","85","m","1978-08-23");
INSERT INTO `people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Anelia Tzvetanova", "172","65","f","1986-09-11");
INSERT INTO `people` (`name`,`height`,`weight`,`gender`,`birthdate`) 
VALUES ("Peter Minchev", "106","15","m","2015-06-30");

CREATE TABLE IF NOT EXISTS `users`
(
	`id` BIGINT AUTO_INCREMENT NOT NULL,
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(26) NOT NULL,
    `profile_picture` BLOB,
    `last_login_time` DATETIME, 
    `is_deleted` INT NULL, 
    CONSTRAINT `pk_users` PRIMARY KEY (`id`)
);

INSERT INTO `users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Pesho","1234",now(),0);
INSERT INTO `users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Maria","qwerty",now(),0);
INSERT INTO `users` (`username`,`password`,`last_login_time`,`is_deleted`) 
VALUES ("Georgi","gogo",now(),1);

ALTER TABLE `users` 
DROP PRIMARY KEY;

ALTER TABLE `users`
ADD CONSTRAINT `pk_users` PRIMARY KEY (`id`,`username`);

ALTER TABLE `users`
MODIFY COLUMN `last_login_time` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE `users` 
DROP PRIMARY KEY;

ALTER TABLE `users`
ADD CONSTRAINT `pk_users` PRIMARY KEY (`id`);

ALTER TABLE `users`
MODIFY COLUMN `username` VARCHAR(30) NOT NULL UNIQUE;
