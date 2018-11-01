/* 13. Намете 5 най-добре платени служителя */
use soft_uni;
SELECT first_name,last_name
FROM employees
ORDER BY salary DESC
LIMIT 5;