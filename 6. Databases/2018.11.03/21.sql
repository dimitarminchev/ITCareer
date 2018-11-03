/* 21. Тримата най-добре платени */
USE soft_uni;
(
	SELECT first_name, last_name, "manager" as position, salary
	FROM employees
	WHERE employee_id in
	(	
		SELECT DISTINCT manager_id
		FROM employees
		WHERE manager_id IS NOT NULL
	)	
	ORDER BY salary DESC LIMIT 3
)
UNION
(
	SELECT first_name, last_name, "employee" as position, salary
	FROM employees
	WHERE employee_id not in
	(
		SELECT DISTINCT manager_id
		FROM employees
		WHERE manager_id IS NOT NULL
	)
	ORDER BY salary DESC LIMIT 3
)
ORDER BY salary DESC, first_name, last_name;