/* database hotel */
CREATE SCHEMA IF NOT EXISTS `hotel`;
USE `hotel`;

CREATE TABLE IF NOT EXISTS `employees` 
( 
	`id` INT NOT NULL,
	`first_name` TEXT,
    `last_name` TEXT,
    `title` TEXT,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `customers` 
( 
	`account_number` INT NOT NULL,
	`first_name` TEXT,
    `last_name` TEXT,
    `phone_number` TEXT,
    `emergency_name` TEXT,
    `emergency_number` TEXT,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `room_status` 
( 
	`room_status` INT NOT NULL,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `room_types` 
( 
	`room_type` INT NOT NULL,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `bed_types` 
( 
	`bed_type` INT NOT NULL,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `rooms` 
( 
	`room_number` INT NOT NULL,
	`room_type` INT,
    `bed_type` INT,
    `rate` INT,
    `room_status` INT,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `payments` 
( 
	`id` INT NOT NULL,
	`employee_id` INT,
    `payment_date` DATE,
    `account_number` INT,
    `first_date_occupied` DATE,
    `last_date_occupied` DATE,
    `total_days` INT,
    `tax_rate` FLOAT,
    `tax_amount` FLOAT,
    `payment_total` FLOAT,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 

CREATE TABLE IF NOT EXISTS `occupancies` 
( 
	`id` INT NOT NULL,
	`employee_id` INT,
    `date_occupied` DATE,
    `account_number` INT,
    `room_number` INT,
    `rate_applied` INT,
    `phone_charge` INT,
    `notes` TEXT,
    PRIMARY KEY (`id`)
); 