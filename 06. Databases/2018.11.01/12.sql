/* 12. Намерете всички служители със заплата повече от 50000 */
use soft_uni;
SELECT first_name, last_name, salary
FROM employees
WHERE salary >= 50000
ORDER BY salary DESC;