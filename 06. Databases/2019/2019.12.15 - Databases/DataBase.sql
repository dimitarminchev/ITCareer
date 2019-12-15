-- Step 1. Database
DROP SCHEMA IF EXISTS `plant_service`;
CREATE SCHEMA `plant_service`;
USE `plant_service`;

-- Step 2. Tables
CREATE TABLE IF NOT EXISTS `cities` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`name` varchar(30) NOT NULL,
	`country_name` varchar(80) NOT NULL
); 
CREATE TABLE IF NOT EXISTS `users` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`username` varchar(50) NOT NULL UNIQUE,
	`password` varchar(255) NOT NULL,
	`first_name` varchar(50) NOT NULL ,
	`last_name` varchar(50)   ,
	`age` INT(11) NOT NULL,
	`money` decimal(15,2) NOT NULL ,
	`city_id` INT(11)  NOT NULL,
	`register_date` DATE NOT NULL,
	CONSTRAINT `fk_users_cities` FOREIGN KEY(`city_id`) REFERENCES cities(id)
);
CREATE TABLE IF NOT EXISTS `orders` 
(
	`id` INT(11) AUTO_INCREMENT primary key,
	`user_id` INT(11)  NOT NULL,
	`order_date` DATE NOT NULL,
	`is_completed` TINYINT(1) DEFAULT FALSE,
	CONSTRAINT `fk_orders_users` FOREIGN KEY(`user_id`) REFERENCES users(id)
);
CREATE TABLE IF NOT EXISTS `plants` 
(
	`id` INT(11) AUTO_INCREMENT primary key,
	`name` varchar(50) NOT NULL,
	`price` decimal(15,2) NOT NULL ,
	`color` varchar(50) ,
	`quantity` INT(11) DEFAULT 0
); 
CREATE TABLE IF NOT EXISTS `info_plants` 
(
	`id` INT(11) AUTO_INCREMENT primary key,
	`plant_id` INT(11) NOT NULL UNIQUE,
	`family` varchar(50) NOT NULL,
	`genus`  varchar(40) NOT NULL,
	`purpose`  varchar(60),
	CONSTRAINT `fk_info_plants_plants` FOREIGN KEY(`plant_id`) REFERENCES plants(id)
);
CREATE TABLE IF NOT EXISTS plants_orders 
(
	`plant_id` INT(11)  NOT NULL ,
	`order_id` INT(11) NOT NULL ,
	CONSTRAINT `pk_plants_orders` PRIMARY KEY(`plant_id`,`order_id`),
	CONSTRAINT `fk_plants_orders_plants` FOREIGN KEY(`plant_id`) REFERENCES plants(id),
	CONSTRAINT `fk_plants_orders_orders` FOREIGN KEY(`order_id`) REFERENCES orders(id)
);