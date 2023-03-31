/* Задача 5.3. Служебни отдели */
USE `soft_uni`;
SELECT `employee_id`, `first_name`, `salary`, `departments`.`name` AS `deparment_name`		
FROM `employees` 
JOIN `departments` ON `departments`.`department_id` = `employees`.`department_id`
WHERE `salary` >= 15000
ORDER BY `departments`.`department_id`  DESC
LIMIT 5