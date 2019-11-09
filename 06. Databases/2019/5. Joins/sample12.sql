/* Problem 2. Служител по продажбите */
SELECT 
  e.employee_id, e.first_name, 
  e.last_name, d.`name` AS department_name
  
FROM employees as e
JOIN departments as d 
  ON d.department_id = e.department_id
  
WHERE d.`name` = "Sales"
ORDER BY e.employee_id DESC;
