/* 01.01. Въведение в базите данни */

/* Problem 2. Създаване на нова база от данни */
CREATE SCHEMA IF NOT EXISTS `minions`;

/* Problem 3. Създаване на таблица */
CREATE TABLE IF NOT EXISTS `minions`.`minions` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NOT NULL,
  `age` INT(3) NULL,
  PRIMARY KEY (`id`)
);

/* Problem 4. Вмъкване на данни в таблицата */
INSERT INTO `minions`.`minions` (`id`, `name`, `age`) VALUES ('1', 'Kevin', '15');
INSERT INTO `minions`.`minions` (`id`, `name`, `age`) VALUES ('2', 'Bob', '22');
INSERT INTO `minions`.`minions` (`id`, `name`) VALUES ('3', 'Steward');

/* Извеждане на всички записи от таблица */
SELECT * FROM `minions`.`minions`;

/* Извеждане на всички записи с въраст различна от NULL */
SELECT * FROM `minions`.`minions` WHERE `age` IS NOT NULL;

/* Problem 5. Aктуализиране на един запис */
UPDATE `minions`.`minions` SET `age`='10' WHERE (`id` = '3');

/* Problem 6. Актуализиране на всички записи */
UPDATE `minions`.`minions` SET age = age + 1;

/* Problem 7. Изтриване на запис */
DELETE FROM `minions`.`minions` WHERE id=2;

/* Problem 8. Създаване на нова таблица */
CREATE TABLE IF NOT EXISTS `minions`.`towns`
(
   `id` INT NOT NULL,
   `name` VARCHAR(40) NOT NULL,
   PRIMARY KEY (`id`)
);
INSERT INTO `minions`.`towns` (`id`,`name`) VALUES (1,"Burgas");
INSERT INTO `minions`.`towns` (`id`,`name`) VALUES (2,"Sofia");
INSERT INTO `minions`.`towns` (`id`,`name`) VALUES (3,"Varna");

/* Problem 9. Свързване на таблици */
ALTER TABLE `minions`.`minions` 
ADD COLUMN `townid` INT NULL AFTER `age`;

ALTER TABLE `minions`.`minions` 
ADD CONSTRAINT `fk_minions_towns`
  FOREIGN KEY (`id`)
  REFERENCES `minions`.`towns` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
