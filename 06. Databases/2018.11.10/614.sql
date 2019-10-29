/* 614. Employees Average Salaries */
USE soft_uni;

DROP TABLE IF EXISTS table614;

CREATE TABLE IF NOT EXISTS table614 AS
(	
	SELECT * FROM employees
    WHERE salary >= 30000
);

DELETE FROM table614 WHERE manager_id=42;

UPDATE table614 SET salary = salary + 5000 WHERE department_id =1;

SELECT department_id, AVG(salary) AS avg_salary
FROM table614
GROUP BY department_id
ORDER BY department_id ASC;