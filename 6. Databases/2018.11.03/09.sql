/* 09. Служители, наети по-късно */
USE soft_uni;

SELECT first_name, last_name, hire_date, d.name AS dept_name
FROM employees AS e
INNER JOIN departments AS d ON d.department_id=e.department_id
WHERE hire_date > "1/1/1999" AND d.name IN ("Sales","Finance")
ORDER BY hire_date ASC;