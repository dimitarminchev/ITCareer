/* 4.3. Всички служители от отдел финанси */
SELECT `first_name`, `last_name`, `department_id`, `salary`
FROM `soft_uni`.`employees` AS e 
WHERE EXISTS
( 
	SELECT d.`department_id`
    FROM `soft_uni`.`departments` AS d
	WHERE e.`department_id` = d.`department_id` AND d.`name` = 'Finance' 
);
