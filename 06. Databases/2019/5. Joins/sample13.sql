/* Problem 3. Служебни отдели */
SELECT e.employee_id,
	e.first_name, e.salary,
	d.`name` AS department_name
FROM employees AS e

JOIN departments AS d 
  ON d.department_id = e.department_id
  
WHERE e.salary > 15000
ORDER BY d.department_id DESC;
