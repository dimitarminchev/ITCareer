/* 07. Намерете всички различни работни заплати */
USE soft_uni;
SELECT DISTINCT salary 
FROM employees
ORDER BY salary;