/* 1. Избор на база данни (soft_uni) */
USE `soft_uni`;

/* Задача: Служители по продажбите */
SELECT 
	e.employee_id,
    e.first_name,
    e.last_name,
    d.`name` as `department_name`

FROM employees AS e

INNER JOIN departments AS d
  ON d.department_id = e.department_id

WHERE d.`name` = "Sales"
  
ORDER BY e.employee_id DESC;