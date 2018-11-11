/* 702. Служители със заплата над ... */
USE company;
-- Деклариране на съхранена процедура
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
-- Извикване на съхранена процедура
CALL usp_get_employees_salary_above(48100);