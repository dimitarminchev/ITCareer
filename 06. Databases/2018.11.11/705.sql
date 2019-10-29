/* 705. Функция за ниво на заплата */
USE company;

-- Изтриване на функцията 
DROP FUNCTION IF EXISTS ufn_get_salary_level;

-- Създаване на функция
DELIMITER $$
CREATE FUNCTION ufn_get_salary_level(salary DECIMAL(19,4))
RETURNS TEXT
DETERMINISTIC
BEGIN
	-- Тяло на функцията
    DECLARE result TEXT;
    IF salary < 30000 THEN
      SET result := "Low";
    ELSEIF salary BETWEEN 30000 AND 50000 THEN
      SET result := "Average";
	ELSE 
      SET result := "High";
    END IF;
    RETURN result;
END
$$

-- Извикване на функция
SELECT salary, ufn_get_salary_level(salary) AS salary_Level
FROM employees;