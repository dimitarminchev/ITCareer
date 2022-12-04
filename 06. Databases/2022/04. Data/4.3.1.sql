USE `soft_uni`;

SELECT DISTINCT e.`job_title`, e.`salary` 
FROM `employees` AS e 
WHERE e.`salary` = 
(
	SELECT es.`salary` 
    FROM `employees` AS es
    WHERE es.`job_title` = e.`job_title`
    ORDER BY es.`salary`
    DESC LIMIT 1
)
ORDER BY e.`salary` DESC, e.`job_title`