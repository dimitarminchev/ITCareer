/* CREATE FUNCTION `udf_get_salary_level` */
DELIMITER $$
USE `soft_uni`$$
CREATE FUNCTION udf_get_salary_level (salary DECIMAL(19,4))
RETURNS TEXT
DETERMINISTIC
BEGIN	
	-- Function logic here.
	IF(salary < 30000) THEN
		RETURN "Low";	
	END IF;
	IF(salary >= 30000 AND salary <= 50000) THEN
		RETURN "Average";	
	END IF;
	IF(salary > 50000) THEN
		RETURN "High";	
	END IF;
END
$$

/* FUNCTION USAGE `udf_get_salary_level` */
SELECT e.first_name, e.last_name, e.salary, udf_get_salary_level(e.salary) AS "Salary Level"
FROM soft_uni.employees AS e;