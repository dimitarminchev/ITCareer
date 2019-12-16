/* 2.2. Relationships */

-- Problem 4. Самообръщаша се връзка
CREATE DATABASE IF NOT EXISTS `sample224`;

USE `sample224`;

CREATE TABLE IF NOT EXISTS `teacher`
(
    `teacher_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(50) NOT NULL,
    `manager_id` INT NULL,
    FOREIGN KEY (`manager_id`) REFERENCES `teacher`(`teacher_id`)
);
 
ALTER TABLE `teacher` AUTO_INCREMENT = 101;
 
INSERT INTO `teacher` (`name`) VALUES ("John");
INSERT INTO `teacher` (`name`) VALUES ("Maya");
INSERT INTO `teacher` (`name`) VALUES ("Silvia");
INSERT INTO `teacher` (`name`) VALUES ("Ted");
INSERT INTO `teacher` (`name`) VALUES ("Mark");
INSERT INTO `teacher` (`name`) VALUES ("Greata");
 
UPDATE `teacher` SET `manager_id` = 106 WHERE `teacher_id` = 102;
UPDATE `teacher` SET `manager_id` = 106 WHERE `teacher_id` = 103;
UPDATE `teacher` SET `manager_id` = 105 WHERE `teacher_id` = 104;
UPDATE `teacher` SET `manager_id` = 101 WHERE `teacher_id` = 105;
UPDATE `teacher` SET `manager_id` = 101 WHERE `teacher_id` = 106;