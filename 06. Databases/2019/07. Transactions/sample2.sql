
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above(salaryVal INT)
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE salary>salaryVal;
END
$$
