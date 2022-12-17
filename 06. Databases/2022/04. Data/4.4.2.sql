/* 4.4.2. Тримата най-добре платени*/
USE `soft_uni`;

(
    /* managers */
	SELECT `first_name`, `last_name`, 'No manager' as `manager_name` 
	FROM `employees`
	WHERE `manager_id` IS NULL
    ORDER BY `salary` DESC
    LIMIT 3
)
UNION
(
    /* employees */
	SELECT `e`.`first_name`, `e`.`last_name`, concat(`m`.`first_name`,' ',`m`.`last_name`) as `manager_name`
	FROM `employees` AS `e`
	LEFT JOIN  `employees` AS `m` ON `m`.`employee_id` = `e`.`manager_id`
	WHERE `e`.`manager_id` IS NOT NULL
    ORDER BY `e`.`salary` DESC
    LIMIT 3
);

