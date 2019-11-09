/* Problem 2. Служители, наети по-късно */
SELECT e.first_name, e.last_name, e.hire_date, d.`name` AS "department"
FROM employees AS e

INNER JOIN departments AS d ON 
(
  e.department_id = d.department_id
  AND DATE(e.hire_date) > '1999/1/1'
  AND d.name IN ('Sales', 'Finance')
)
ORDER BY e.hire_date ASC;