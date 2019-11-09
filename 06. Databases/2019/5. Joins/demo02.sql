/* 1. Избор на база данни (soft_uni) */
USE `soft_uni`;

/* 2. Присъединяване на таблица (JOIN) = 293 записа */
SELECT  concat(`first_name`," ",`last_name`) AS `name`, `name` AS `department`
FROM `employees` 
JOIN `departments` ON `departments`.`department_id` = `employees`.`department_id`;