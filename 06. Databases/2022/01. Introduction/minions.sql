/* Създаване на база от данни */
CREATE SCHEMA `minions` ;

/* Създаване на таблица */
CREATE TABLE `minions`.`minions` (
  `id` INT(11) NOT NULL,
  `name` VARCHAR(50) NOT NULL,
  `age` INT(3) NULL,
  PRIMARY KEY (`id`));
  
/* Добавяне на запис */
INSERT INTO `minions`.`minions` (`id`,`name`,`age`) VALUES ('1','Kevin','15');  
INSERT INTO `minions`.`minions` (`id`,`name`,`age`) VALUES ('2','Bob','22');  
INSERT INTO `minions`.`minions` (`id`,`name`) VALUES ('3','Steward');  
  
/* Извличане на записи */
SELECT * FROM `minions`.`minions`;

/* Актуализация на запис */ 
UPDATE `minions`.`minions` SET `age`=10 WHERE `name`='Steward';

/* Изтриване на запис */
/* DELETE FROM `minions`.`minions` WHERE `id`=2; */

/* Създаване на таблица towns */
CREATE TABLE `minions`.`towns` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NULL,
   PRIMARY KEY (`id`)
);

/* Актуализиараме таблица minions */ 
ALTER TABLE `minions`.`minions` ADD COLUMN `townid` INT NULL AFTER `age`, ADD INDEX `fk_minions_tows_idx` (`townid` ASC) VISIBLE;
ALTER TABLE `minions`.`minions` ADD CONSTRAINT `fk_minions_tows`  FOREIGN KEY (`townid`)  REFERENCES `minions`.`towns` (`id`);

/* Изпразване на таблицата */
TRUNCATE TABLE `minions`.`minions`;
TRUNCATE TABLE `minions`.`towns`;

/* Добавяне на записите */
INSERT INTO `minions`.`towns`  (`id`,`name`) VALUES (1,'Sofia');
INSERT INTO `minions`.`towns`  (`id`,`name`) VALUES (2,'Plovdiv'); 
INSERT INTO `minions`.`towns`  (`id`,`name`) VALUES (3,'Varna');
INSERT INTO `minions`.`minions` (`id`,`name`, `age`, `townid`) VALUES (1,'Kevin', 22, 1);
INSERT INTO `minions`.`minions` (`id`,`name`, `age`, `townid`) VALUES (2,'Bob', 15, 3);
INSERT INTO `minions`.`minions` (`id`,`name`, `age`, `townid`) VALUES (3,'Steward', NULL, 2);