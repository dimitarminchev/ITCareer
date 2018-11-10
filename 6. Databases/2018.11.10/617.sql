/* 617. 3rd Highest Salary */
USE soft_uni;

SELECT e.department_id,MAX(e.salary) AS max_salary
FROM employees AS e
JOIN
(
	SELECT e.department_id ,MAX(e.salary) AS max_salary
	FROM employees AS e
	JOIN 
	(
		SELECT e.department_id ,MAX(e.salary) AS max_salary
		FROM employees AS e
		GROUP BY e.department_id
	) AS e3
	ON e.department_id = e3.department_id AND e.salary < e3.max_salary
	GROUP BY e.department_id
) AS e2
ON e.department_id = e2.department_id AND e.salary < e2.max_salary

GROUP BY e.department_id
ORDER BY department_id;