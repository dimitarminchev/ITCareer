/*
Задача 4.17. Мениджъри с точно 5 подчинени
Изведете името и фамилията на всички мениджъри с точно 5 подчинени.
*/
USE `soft_uni`;
SELECT `manager`.`first_name`, `manager`.`last_name`
FROM `employees` AS `manager`
WHERE `manager`.`employee_id` IN 
(
	SELECT DISTINCT `manager_id` 
    FROM `employees`
)
AND EXISTS 
(
	SELECT 1 
	FROM `employees`
	WHERE `manager_id` = `manager`.`employee_id`
	LIMIT 4,1
)
AND NOT EXISTS 
(
	SELECT 1 
	FROM `employees`
	WHERE `manager_id` = `manager`.`employee_id`
	LIMIT 5,1
)
ORDER BY `manager`.`first_name`, `manager`.`last_name`;
	