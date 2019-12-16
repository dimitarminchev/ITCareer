/* 4.3. Най-високата заплата от всеки отдел и работника, който я получава */
SELECT `first_name`, `last_name`, `department_id`, `salary`
FROM `soft_uni`.`employees` AS e 
WHERE `salary` = 
(
	SELECT `salary` 
	FROM `soft_uni`.`employees` 
	WHERE `department_id` = e.`department_id`
    ORDER BY `salary` DESC LIMIT 1
)
ORDER BY `department_id`;
