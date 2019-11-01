/* 17. Мениджъри с точно 5 подчинени */
USE soft_uni;

/* v2
SELECT first_name, last_name
FROM employees e
WHERE employee_id IN
(
	SELECT DISTINCT manager_id 
    FROM employees
    WHERE e.employee_id = manager_id
) 
AND EXISTS 
(
    SELECT 1 
    FROM employees
    WHERE e.employee_id = manager_id
    LIMIT 4,1
)
AND NOT EXISTS 
(
    SELECT 1 
    FROM employees
    WHERE e.employee_id = manager_id
    LIMIT 5,1
)
ORDER BY e.first_name, e.last_name;
*/

SELECT first_name, last_name
FROM employees e
WHERE manager_id IS NOT NULL AND 
(
	SELECT COUNT(*)
	FROM employees
	WHERE e.employee_id = manager_id
) = 5
ORDER BY first_name, last_name;