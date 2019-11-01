/* 02. Служител по продажбите */
USE soft_uni;

SELECT employee_id, first_name, last_name, d.name as department_name
FROM employees AS e
JOIN departments AS d ON e.department_id = d.department_id
WHERE d.name = "Sales"
ORDER BY e.employee_id DESC;
