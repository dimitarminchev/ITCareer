/* 16. Мениджъри с по-ниска заплата */
USE soft_uni;

SELECT m.first_name, m.last_name
FROM employees m 
WHERE m.employee_id IN 
(
	SELECT DISTINCT manager_id FROM employees
)
AND m.salary < ANY 
(
	SELECT salary 
    FROM employees 
    WHERE manager_id = m.employee_id
);