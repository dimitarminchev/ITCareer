/* 05. Мениджър на служителите */
USE soft_uni;

SELECT e1.employee_id, e1.first_name, e1.manager_id, 
       concat(e2.first_name," ",e2.last_name) AS manager_name
FROM employees AS e1
JOIN employees AS e2 ON e1.manager_id = e2.employee_id
WHERE e1.manager_id IN (3,7)
ORDER BY first_name ASC;