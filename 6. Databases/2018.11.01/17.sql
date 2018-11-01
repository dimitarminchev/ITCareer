/* 17. Последните 7 наети служители */
USE soft_uni;
SELECT first_name, last_name, hire_date
FROM employees
ORDER BY hire_date DESC
LIMiT 7; 