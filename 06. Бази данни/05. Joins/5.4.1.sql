/* Задача 5.18. Служител 24 */
USE `soft_uni`;

SELECT `e`.`employee_id`, `first_name`, 
CASE
    WHEN `p`.`start_date` >= 1/1/2005 THEN NULL
    ELSE `p`.`start_date`
END AS `start_date`

FROM `employees` AS `e`
JOIN `employees_projects` AS `ep` ON `ep`.`employee_id` = `e`.`employee_id`
JOIN `projects` AS `p` ON `p`.`project_id`=`ep`.`project_id`

WHERE `e`.`employee_id` = 24;
