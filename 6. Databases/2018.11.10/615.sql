/* 615. Employees Maximum Salaries */
USE soft_uni;

SELECT department_id, MAX(salary) AS max_salary
FROM employees
GROUP BY department_id
HAVING max_salary < 30000 OR max_salary > 70000
ORDER BY department_id ASC;