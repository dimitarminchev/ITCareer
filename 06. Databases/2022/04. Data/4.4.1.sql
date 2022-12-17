/* 4.4.1. Служители и техните мениджъри */
USE `soft_uni`;
(
    /* managers */
	SELECT `first_name`, `last_name`, 'No manager' as `manager_name` 
	FROM `employees`
	WHERE `manager_id` IS NULL
)
UNION
(
    /* employees */
	SELECT `e`.`first_name`, `e`.`last_name`, concat(`m`.`first_name`,' ',`m`.`last_name`) as `manager_name` 
	FROM `employees` AS `e`
	LEFT JOIN  `employees` AS `m` ON `m`.`employee_id` = `e`.`manager_id`
	WHERE `e`.`manager_id` IS NOT NULL
)
ORDER BY `manager_name`;

