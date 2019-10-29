/* 11. Резюме на служителите */
USE soft_uni;

SELECT e1.employee_id, 
CONCAT(e1.first_name," ",e1.last_name) AS employee_name,
CONCAT(e2.first_name," ",e2.last_name) AS manager_name,
d.name AS department_name

FROM employees AS e1
INNER JOIN employees AS e2 ON e2.employee_id = e1.manager_id
INNER JOIN departments AS d ON d.department_id = e1.department_id 

ORDER BY employee_id
LIMIT 5;