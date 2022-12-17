/* 5.1.6. Минимална заплата */
USE `soft_uni`;

SELECT `employees`.`salary`, `departments`.`name`
FROM `employees`, `departments`
WHERE `employees`.`department_id` = `departments`.`department_id` AND
     `employees`.`department_id` =
(
    SELECT `department_id`
    FROM `employees`
	ORDER BY `salary` ASC
    LIMIT 1
)
LIMIT 1
