/*
Задача 4.16. Мениджъри с по-ниска заплата
Напишете заявка, извеждаща списък на всички мениджъри с поне един подчинен, който има по-висока заплата от тяхната.
*/
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
);
