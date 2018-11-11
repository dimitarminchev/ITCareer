/* 702. Служители със заплата над ... */
USE company;
-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above(param INT) 
BEGIN

	-- Изпълнение на заявка
    SELECT first_name, last_name
    FROM employees
    WHERE salary >= param
    ORDER BY first_name ASC, last_name ASC;

END
$$
-- Извикване и изпълнение на съхранената процедура
CALL usp_get_employees_salary_above(48100);