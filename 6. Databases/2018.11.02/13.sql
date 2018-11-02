/* 13. Най-висока заплата по длъжности */
USE soft_uni;

SELECT job_title, salary 
FROM employees e
WHERE salary =
(
    SELECT salary 
    FROM employees
    WHERE e.department_id = department_id
    ORDER BY salary DESC LIMIT 1
)
ORDER BY salary DESC, job_title ASC;