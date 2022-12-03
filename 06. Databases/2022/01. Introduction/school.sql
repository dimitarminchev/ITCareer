/* Създаване на нова база данни */
CREATE SCHEMA `school`;

/* Създаване на таблица */
CREATE TABLE `school`.`students` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NULL,
  `age` INT NULL,
  `phone_number` VARCHAR(50) NULL,
   PRIMARY KEY (`id`)
);
CREATE TABLE `school`.`classes` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NULL,
  `max_students` INT NULL,
   PRIMARY KEY (`id`)
);
CREATE TABLE `school`.`teachers` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NULL,
  `class` INT NULL,
   PRIMARY KEY (`id`)
);

/* Създаване на нова таблица */
CREATE TABLE `school`.`towns` 
(
  `id` INT NOT NULL,
  `name` VARCHAR(50) NULL,
   PRIMARY KEY (`id`)
);