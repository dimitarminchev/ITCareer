/*
Задача 4.14. Най-ниско платени служители по отдели
Напишете заявка, която извежда името и фамилията, заплатата и името на отдела на всички служители, получаващи най-ниска заплата в своя отдел. Резултатът да е сортиран по заплата, име и фамилия, във възходящ ред.
*/
USE `soft_uni`;
SELECT `first_name`,`last_name`,`salary`,`department_id`
FROM `employees` AS e
WHERE `salary` = 
(
	SELECT `salary`
    FROM `employees` AS em
    WHERE e.`department_id`=em.`department_id`
    ORDER BY `salary` ASC
    LIMIT 1
)
ORDER BY `salary`,`first_name`,`last_name`;