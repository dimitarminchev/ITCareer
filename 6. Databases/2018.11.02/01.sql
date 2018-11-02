/* 01. Намерете всички служители със заплата над 50000 */
USE soft_uni;

SELECT first_name, last_name, salary
FROM employees
WHERE salary >= 50000
ORDER BY salary DESC;