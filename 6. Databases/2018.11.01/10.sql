/* 10.  Намерете имената на всички служители */
USE soft_uni;
SELECT concat(first_name,' ',middle_name,' ',last_name) as full_name
FROM employees
WHERE salary in (25000,14000,12500,23600);