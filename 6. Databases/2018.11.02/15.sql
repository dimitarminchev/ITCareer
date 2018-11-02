/* 15. Мениджъри с същото презиме */
USE soft_uni;

SELECT m.first_name, m.last_name 
FROM employees m 
WHERE m.employee_id IN 
(
	SELECT DISTINCT manager_id 
    FROM employees
)
AND EXISTS 
(
	SELECT 1 FROM employees e
    WHERE e.manager_id = m.employee_id AND e.middle_name = m.middle_name
)
ORDER BY m.first_name, m.last_name;