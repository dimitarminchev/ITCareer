/* 04. Служители без проект */
USE soft_uni;

SELECT e.employee_id, first_name, last_name
FROM employees AS e
LEFT JOIN employees_projects as ep ON e.employee_id = ep.employee_id
WHERE ep.project_id IS NULL 
ORDER BY first_name ASC, last_name ASC
LIMIT 3;
