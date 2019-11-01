/* 11. Намерете всички служители без мениджър */
use soft_uni;
SELECT first_name, last_name
FROM employees
WHERE manager_id IS NULL;