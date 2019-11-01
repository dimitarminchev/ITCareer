/* 09. Най-ниско платени служители */
USE soft_uni;

SELECT first_name,last_name,salary
FROM employees
WHERE salary =
(
	SELECT salary FROM employees ORDER BY salary ASC LIMIT 1
);