/* Problem 4. Служители без проект */
SELECT e.employee_id, e.first_name 

FROM employees AS e
WHERE e.employee_id NOT IN   
(
	SELECT DISTINCT ep.employee_id 
	FROM employees_projects AS ep
)
ORDER BY e.employee_id desc
LIMIT 3;
