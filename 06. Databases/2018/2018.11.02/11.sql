/* 11. Всички мениджъри */
USE soft_uni;

SELECT e.first_name, e.last_name, e.job_title 
FROM employees e 
WHERE e.employee_id in 
(
        SELECT DISTINCT manager_id 
        FROM employees
)
ORDER BY e.first_name, e.last_name