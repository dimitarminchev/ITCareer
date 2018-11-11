/* 703. Градове започващи със... */
USE company;
-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_get_towns_starting_with(str CHAR(1))
BEGIN
	-- Изпълнение на заявка
    SELECT `name` AS town_name
    FROM towns
    WHERE `name` LIKE CONCAT(str,'%')
    ORDER BY town_name ASC;
END
$$
-- Изпълнение на съхранената процедура
CALL usp_get_towns_starting_with('b');
