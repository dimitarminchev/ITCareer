/* 05. Последните 7 наети служителя */
USE soft_uni;

SELECT first_name, last_name, hire_date 
FROM employees
ORDER BY hire_date DESC
LIMit 7; 