/* Задача 5.2. Служител по продажбите */
USE `soft_uni`;
SELECT `employee_id`, `first_name`, `last_name`, `departments`.`name` AS `deparment_name`		
FROM `employees` 
JOIN `departments` ON `departments`.`department_id` = `employees`.`department_id`
WHERE `departments`.`name` = "Sales"		
ORDER BY `employees`.`employee_id` DESC;