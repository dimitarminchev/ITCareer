/* Задача 5.4. Служители без проект */
USE `soft_uni`;
SELECT `employees`.`employee_id`, `first_name`
FROM `employees` 
LEFT JOIN `employees_projects` 
ON `employees_projects`.`employee_id` = `employees`.`employee_id`
WHERE `employees_projects`.`project_id` IS NULL
ORDER BY `employees`.`employee_id` DESC
LIMIT 3