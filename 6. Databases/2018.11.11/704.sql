/* 704. Служители от град */
USE company;
-- Създаване на съхранена процедура
DELIMITER $$
CREATE PROCEDURE usp_get_employees_from_town(city TEXT) 
BEGIN
	-- Изпълнение на заявка
    SELECT e.first_name, e.last_name
    FROM employees AS e
    JOIN addresses AS a ON a.address_id=e.address_id
    JOIN towns AS t ON t.town_id=a.town_id
    WHERE name = city
    ORDER BY e.first_name ASC, e.last_name ASC; 
END
$$
-- Извикване и изпълнение на съхранената процедура
CALL usp_get_employees_from_town("Sofia");