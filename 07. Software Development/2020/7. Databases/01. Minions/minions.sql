/* Minions Database */
CREATE SCHEMA IF NOT EXISTS `minions`;
CREATE TABLE IF NOT EXISTS `minions`.`minions` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NOT NULL,
  `age` INT(3) NULL,
  PRIMARY KEY (`id`)
);
INSERT INTO `minions`.`minions` (`id`, `name`, `age`) VALUES ('1', 'Kevin', '15');
INSERT INTO `minions`.`minions` (`id`, `name`, `age`) VALUES ('2', 'Bob', '22');
INSERT INTO `minions`.`minions` (`id`, `name`, `age`) VALUES ('3', 'Steward','42');
