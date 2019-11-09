/* Problem 4. Резюме на служителите */
SELECT
	e.employee_id,
	CONCAT(e.first_name," ",e.last_name) AS "employee_name",
	CONCAT(m.first_name," ",m.last_name) AS "manager_name",
	d.`name` AS "department_name"

FROM employees AS e
INNER JOIN employees AS m  ON m.employee_id = e.manager_id
INNER JOIN departments AS d  ON d.department_id = e.department_id

ORDER BY e.employee_id LIMIT 5;