/* 2. One-To-Many Relationship */

/* Create Tables */
CREATE TABLE `manufacturers`
(
	`manufacturer_id` INT NOT NULL PRIMARY KEY,
	`name` TEXT,
    `established_on` DATE
);

CREATE TABLE `models`
(
	`model_id` INT NOT NULL PRIMARY KEY,
    `name` TEXT,
    `manufacturer_id` INT,

    /* Foreign key: manufacturer_id => manufacturers.manufacturer_id */
    CONSTRAINT `fk_models_manufacturers`
    FOREIGN KEY (`manufacturer_id`) 
    REFERENCES `manufacturers`(`manufacturer_id`)
);

/* Insert Data */
INSERT INTO `manufacturers` (`manufacturer_id`,`name`,`established_on`) VALUES (1,"BMW", "01/03/1916");
INSERT INTO `manufacturers` (`manufacturer_id`,`name`,`established_on`) VALUES (2,"Tesla","01/01/2003");
INSERT INTO `manufacturers` (`manufacturer_id`,`name`,`established_on`) VALUES (3,"Lada","01/05/1966");

INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (101,"X1",1);
INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (102,"i6",1);
INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (103,"Model S",2);
INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (104,"Model X",2);
INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (10,"Model 3",2);
INSERT INTO `models` (`model_id`,`name`,`manufacturer_id`) VALUES (106,"Nova",3);