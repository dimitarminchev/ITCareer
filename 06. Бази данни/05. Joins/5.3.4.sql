/* Задача 5.17. Служители без проект */
USE `soft_uni`;

SELECT `e`.`employee_id`, `first_name`, `last_name`
FROM `employees` AS `e`
LEFT JOIN `employees_projects` AS `ep` 
       ON `ep`.`employee_id` = `e`.`employee_id`
WHERE `ep`.`project_id` IS NULL
ORDER BY `first_name`, `last_name`
LIMIT 3;