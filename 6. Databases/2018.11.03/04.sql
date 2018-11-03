/* 04. Служители без проект */
USE soft_uni;

SELECT e.employee_id, first_name
FROM employees AS e
LEFT JOIN employees_projects AS ep ON ep.employee_id=e.employee_id 
WHERE ep.employee_id IS NULL
ORDER BY e.employee_id DESC
LIMIT 3;