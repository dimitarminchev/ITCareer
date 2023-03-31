/* Задача 5.10. Служители с проект */
USE `soft_uni`;
SELECT `e`.`employee_id`, `e`.`first_name`, `p`.`name` AS `project_name`
FROM `employees` AS `e`
INNER JOIN `employees_projects` AS `ep` ON `ep`.`employee_id` = `e`.`employee_id`
INNER JOIN `projects` AS `p` ON 
(
	 `p`.`project_id` = `ep`.`project_id` AND
     `p`.`start_date` > 13/8/2002 AND
     `p`.`end_date` IS NULL
)
ORDER BY `e`.`first_name`, `p`.`name`
LIMIT 5;
