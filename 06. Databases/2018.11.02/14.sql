/* 14. Най-ниско платени служители по отдели */
USE soft_uni;

SELECT first_name, last_name, salary, 
(
	SELECT name
	FROM departments
	WHERE department_id = e.department_id
) AS department
FROM employees e
WHERE salary =
(
	SELECT salary
	WHERE department_id = e.department_id
	ORDER BY salary DESC
	LIMIT 1
)
ORDER BY salary, first_name, last_name;