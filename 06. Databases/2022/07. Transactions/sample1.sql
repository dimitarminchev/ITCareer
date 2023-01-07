DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above_35000()
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE salary>35000;
END
$$