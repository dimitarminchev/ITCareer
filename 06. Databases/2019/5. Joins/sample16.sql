/* Problem 6. Минимална заплата */
SELECT e.salary, d.`name`

FROM employees AS e

JOIN departments AS D
 ON d.department_id = e.department_id
 
ORDER BY e.salary ASC
LIMIT 1;
 
