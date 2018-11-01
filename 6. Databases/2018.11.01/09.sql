/* 09. Намерете имената на всички служители със заплата в диапазон */
USE soft_uni;
SELECT first_name, last_name, job_title as `JobTitle`
FROM employees
WHERE salary BETWEEN 20000 and 30000;