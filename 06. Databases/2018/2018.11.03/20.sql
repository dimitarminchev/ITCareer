/* 20. Служители и техните мениджъри */
USE soft_uni;

(
	SELECT first_name, last_name,"(no manager)" as manager_name
	FROM employees
	WHERE manager_id IS NULL
)
UNION
(
	SELECT first_name, last_name, 
	(
		SELECT concat(first_name," ",last_name)
		FROM employees
		WHERE e.manager_id = employee_id
	) as manager_name
	FROM employees e
	WHERE manager_id IS NOT NULL
);