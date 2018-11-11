/* 701. Служители със заплата над 35000 */
USE company;

-- Изтриване на процедурата 
DROP PROCEDURE IF EXISTS usp_get_employees_salary_above_35000;

-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above_35000()
BEGIN

	-- Изпълнение на заявка
	SELECT first_name, last_name
    FROM employees
    WHERE salary > 35000
    ORDER BY first_name ASC, last_name ASC;

END 
$$

-- Извикване и изпълнение на съхранената процедура
CALL usp_get_employees_salary_above_35000();