USE `soft_uni`;

SELECT `manager`.`first_name`, `manager`.`last_name`
FROM `employees` AS `manager`
WHERE `manager`.`employee_id` IN 
(
	SELECT DISTINCT `manager_id` 
    FROM `employees`
)
AND `manager`.`salary` < ANY 
(
	SELECT `salary` 
    FROM `employees`
    WHERE `manager_id` = `manager`.`employee_id`
)
