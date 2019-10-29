/* 02. Намерете 5 най-добре платени служители0 */
USE soft_uni;

SELECT first_name, last_name
FROM employees
ORDER BY salary DESC
LIMIT 5;