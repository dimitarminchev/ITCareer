/* database minions */

/* Създаване на нова база от данни */
CREATE SCHEMA IF NOT EXISTS `minions`;
USE `minions`;

/* Създаване на таблица */
CREATE TABLE IF NOT EXISTS `minions` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NOT NULL,
  `age` INT(3) NULL,
  PRIMARY KEY (`id`)
);

/* Вмъкване на данни в таблицата */
INSERT INTO `minions` (`id`, `name`, `age`) VALUES ('1', 'Kevin', '15');
INSERT INTO `minions` (`id`, `name`, `age`) VALUES ('2', 'Bob', '22');
INSERT INTO `minions` (`id`, `name`) VALUES ('3', 'Steward');

/* Извеждане на всички записи от таблица */
SELECT * FROM `minions`;

/* Извеждане на всички записи с въраст различна от NULL */
SELECT * FROM `minions` WHERE `age` IS NOT NULL;

/* Aктуализиране на един запис */
UPDATE `minions` SET `age`='10' WHERE (`id` = '3');

/* Актуализиране на всички записи */
UPDATE `minions` SET age = age + 1;

/* Изтриване на запис */
DELETE FROM `minions` WHERE id=2;

/* Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS `towns`
(
   `id` INT NOT NULL,
   `name` VARCHAR(40) NOT NULL,
   PRIMARY KEY (`id`)
);

/* Добавяне на данни в таблицата */
INSERT INTO `towns` (`id`,`name`) VALUES (1,"Burgas");
INSERT INTO `towns` (`id`,`name`) VALUES (2,"Sofia");
INSERT INTO `towns` (`id`,`name`) VALUES (3,"Varna");

/* Свързване на таблици */
ALTER TABLE `minions` 
ADD COLUMN `townid` INT NULL AFTER `age`;

ALTER TABLE `minions` 
ADD CONSTRAINT `fk_minions_towns`
  FOREIGN KEY (`id`)
  REFERENCES `towns` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
