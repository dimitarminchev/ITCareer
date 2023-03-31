/* Задача 5.9. Служители, наети по-късно */
USE `soft_uni`;
SELECT `e`.`first_name`, `e`.`last_name`, `e`.`hire_date`, `d`.`name` AS `dept_name`
FROM `employees` AS `e`
INNER JOIN `departments` AS `d` ON 
(
	`d`.`department_id` = `e`.`department_id` AND
    `d`.`name` IN ("Sales", "Finance") AND
    `e`.`hire_date` >= 1/1/1999
)
ORDER BY `e`.`hire_date`;