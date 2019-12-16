/* 2.6. Relationships */

-- Problem 1. База данни за онлайн магазин
CREATE SCHEMA IF NOT EXISTS `sample261`;

CREATE TABLE IF NOT EXISTS `sample261`.`items`
(
`item_id` INT(11) PRIMARY KEY,
`name` VARCHAR(50),
`item_type_id` INT(11)
);

CREATE TABLE IF NOT EXISTS `sample261`.`item_types`
(
`item_type_id` INT(11) PRIMARY KEY,
`name` VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS `sample261`.`customers`
(
`customer_id` INT(11) PRIMARY KEY,
`name` VARCHAR(50),
`birthday` DATE,
`city_id` INT(11)
);

CREATE TABLE IF NOT EXISTS `sample261`.`orders`
(
`order_id` INT(11) PRIMARY KEY,
`customer_id` INT(11)
);

CREATE TABLE IF NOT EXISTS `sample261`.`cities`
(
`city_id` INT(11) PRIMARY KEY,
`name` VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS `sample261`.`order_items`
(
`order_id` INT(11) ,
`item_id` INT(11),
PRIMARY KEY(`order_id`,`item_id`)
);
ALTER TABLE `sample261`.`items`
ADD CONSTRAINT `fk_item_type_id`
	FOREIGN KEY (`item_type_id`)
    REFERENCES `sample261`.`item_types` (`item_type_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
    ALTER TABLE `sample261`.`customers`
ADD CONSTRAINT `fk_city_id`
	FOREIGN KEY (`city_id`)
    REFERENCES `sample261`.`cities` (`city_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
    ALTER TABLE `sample261`.`orders`
ADD CONSTRAINT `fk_customer_id`
	FOREIGN KEY (`customer_id`)
    REFERENCES `sample261`.`customers` (`customer_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
     ALTER TABLE `sample261`.`order_items`
ADD CONSTRAINT `fk_order_id`
	FOREIGN KEY (`order_id`)
    REFERENCES `sample261`.`orders` (`order_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;
    
    ALTER TABLE `sample261`.`order_items`
ADD CONSTRAINT `fk_item_id`
	FOREIGN KEY (`item_id`)
    REFERENCES `sample261`.`items` (`item_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION;