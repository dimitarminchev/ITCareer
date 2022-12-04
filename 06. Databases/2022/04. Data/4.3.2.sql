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