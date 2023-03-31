/* 1. One-To-One Relationship */

/* Create Tables */
CREATE TABLE `passports`
(
	`passport_id` INT NOT NULL PRIMARY KEY,
	`passport_number` TEXT
);

CREATE TABLE `persons`
(
	`person_id` INT NOT NULL PRIMARY KEY,
    `first_name` TEXT,
	`salary` FLOAT,
    `passport_id` INT,

    /* Foreign key: passport_id => passports.passport_id */
    CONSTRAINT `fk_persons_passports`
    FOREIGN KEY (`passport_id`) 
    REFERENCES `passports`(`passport_id`)
);

/* Insert Data */
INSERT INTO `passports` (`passport_id`,`passport_number`) VALUES (101,"N34FG21B");
INSERT INTO `passports` (`passport_id`,`passport_number`) VALUES (102,"K65LO4R7");
INSERT INTO `passports` (`passport_id`,`passport_number`) VALUES (103,"ZE657QP2");

INSERT INTO `persons` (`person_id`,`first_name`,`salary`,`passport_id`) VALUES (1,"Roberto",43300.00,102);
INSERT INTO `persons` (`person_id`,`first_name`,`salary`,`passport_id`) VALUES (2,"Tom",56100.00,103);
INSERT INTO `persons` (`person_id`,`first_name`,`salary`,`passport_id`) VALUES (3,"Yana",60200.00,101);
