/* 
Задача 5.6. Минимална заплата
Напишете заявка, която връща стойността на най-ниската заплата от всички отдели и името на отдела, в който се дава.
*/
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
