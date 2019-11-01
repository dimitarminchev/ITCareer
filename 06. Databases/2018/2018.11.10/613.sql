/* 613. Employees Minimum Salaries */
USE soft_uni;

SELECT department_id, MIN(salary) as minimum_salary
FROM employees
WHERE department_id IN (2,5,7) 
GROUP BY department_id
ORDER BY department_id;