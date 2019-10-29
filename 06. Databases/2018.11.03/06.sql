/* 6. Минимална заплата */
USE soft_uni;

SELECT e.salary,d.name
FROM employees AS e
JOIN departments AS d ON d.department_id=e.department_id
ORDER BY e.salary ASC
LIMIT 1;