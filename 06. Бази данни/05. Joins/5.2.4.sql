/* Задача 5.11. Резюме на служителите */
USE `soft_uni`;

SELECT `e`.`employee_id`, 
  concat(`e`.`first_name`," ",`e`.`last_name`) AS `employee_name`,
  concat(`m`.`first_name`," ",`m`.`last_name`) AS `manager_name`,
  `d`.`name` AS `department_name`

FROM `employees` AS `e`
INNER JOIN `employees` AS `m` ON  `m`.`employee_id` = `e`.`manager_id` 
INNER JOIN `departments` AS `d` ON `d`.`department_id` = `e`.`department_id`

ORDER BY `e`.`employee_id`
LIMIt 5;