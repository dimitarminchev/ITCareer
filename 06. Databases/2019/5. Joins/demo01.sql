/* 1. Избор на база данни (soft_uni) */
USE `soft_uni`;

/* 2. Декатртово произведение (293 employee x 16 departmens = 4688 записа) */
SELECT concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees`, `departments`;