
DELIMITER $$
CREATE PROCEDURE usp_get_employees_from_town (town_name TEXT)
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE address_id = (SELECT id FROM  towns WHERE `name`=town_name LIMIT 1);
END
$$
