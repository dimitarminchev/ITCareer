/* 18. Увеличаване на заплати */
USE soft_uni;

UPDATE employees SET salary=salary+salary*0.12
WHERE department_id IN (1,2,4,11);

SELECT salary * 1.12 as `salary` 
FROM employees
WHERE department_id IN (1,2,4,11)
ORDER BY salary ASC; 