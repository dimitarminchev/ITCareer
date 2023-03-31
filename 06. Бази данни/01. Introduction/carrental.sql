/* database carrental */
CREATE DATABASE IF NOT EXISTS `carrental`;
USE `carrental`;

CREATE TABLE IF NOT EXISTS `categories` 
(
	`id` INT NOT NULL AUTO_INCREMENT,
    `category` VARCHAR(50) NOT NULL,
    `daily_rate` INT NULL,
    `weekly_rate` INT NULL,
    `monthly_rate` INT NULL,
    `weekend_rate` INT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS `car`
(
	`id` INT NOT NULL AUTO_INCREMENT,
    `model` VARCHAR(50) NOT NULL,
    `plate_number` VARCHAR(50) NOT NULL,
    `car_year` DATETIME NULL,
    `category_id` INT NOT NULL,
    `doors` INT NULL, 
    `picture` BLOB NULL,
    `car_condition` VARCHAR(50) NULL,
    `available` BOOL NOT NULL,
    PRIMARY KEY(`id`)
);

CREATE TABLE IF NOT EXISTS `employees` 
(
    `id` INT NOT NULL AUTO_INCREMENT,
    `first_name` VARCHAR(50) NOT NULL,
    `last_name` VARCHAR(50) NOT NULL,
    `title` VARCHAR(50) NULL,
    `notes` TEXT NULL,
    PRIMARY KEY(`id`)
);

CREATE TABLE IF NOT EXISTS `customers`  
(
    `id` INT NOT NULL AUTO_INCREMENT,
    `driver_licence_number` VARCHAR(50) NOT NULL,
    `full_name` VARCHAR(50) NOT NULL,
    `address` VARCHAR(50) NULL,
    `city` VARCHAR(50) NULL,
    `zip_code` VARCHAR(50) NULL,
    `notes` TEXT NULL,
    PRIMARY KEY(`id`)
);

CREATE TABLE IF NOT EXISTS `rental_orders`  
(
    `id` INT NOT NULL AUTO_INCREMENT,
    `employee_id` INT NOT NULL,
    `customer_id` INT NOT NULL,
    `car_id` INT NULL,
    `car_condition` VARCHAR(50) NULL,
    `tank_level` INT NULL,
    `kilometrage_start` INT NULL,
    `kilometrage_end` INT NULL,
    `total_kilometrage` INT NULL,
    `start_date` DATETIME NULL,
    `end_date` DATETIME NULL,
    `total_days` INT NULL,
    `rate_applied` VARCHAR(50) NULL,
    `tax_rate` VARCHAR(50) NULL,
    `order_status` VARCHAR(50) NULL,
    `notes` TEXT NULL,
    PRIMARY KEY(`id`)
);

ALTER TABLE `car`
ADD CONSTRAINT `fk_car_category` FOREIGN KEY(`id`)
	REFERENCES `car-rental`.`categories`(`id`) 
    ON DELETE NO ACTION 
    ON UPDATE NO action;
    
ALTER TABLE `rental_orders`
ADD CONSTRAINT `fk_employee_order` FOREIGN KEY(`id`)
	REFERENCES `car-rental`.`employees`(`id`) 
    ON DELETE NO ACTION 
    ON UPDATE NO action;
    
ALTER TABLE `rental_orders`
ADD CONSTRAINT `fk_car_order` FOREIGN KEY(`id`)
	REFERENCES `car-rental`.`car`(`id`) 
    ON DELETE NO ACTION 
    ON UPDATE NO action;
    
ALTER TABLE `rental_orders`
ADD CONSTRAINT `fk_order_customer` FOREIGN KEY(`id`)
	REFERENCES `car-rental`.`customers`(`id`) 
    ON DELETE NO ACTION 
    ON UPDATE NO action;

/* DROP SCHEMA `carrental`; */