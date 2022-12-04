USE `soft_uni`;

SELECT `manager`.`first_name`, `manager`.`last_name`
FROM `employees` as `manager`
WHERE (`manager`.`employee_id`, `manager`.`middle_name`) IN 
(
	SELECT `manager_id`, `middle_name`
	FROM `employees`
) 
ORDER BY `manager`.`first_name`, `manager`.`last_name`