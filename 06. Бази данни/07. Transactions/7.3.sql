/*
Задача 7.3. Градове започващи със...
Създайте съхранена процедура usp_get_towns_starting_with , която приема низ като параметър и връща всички имена на градове започващи с този низ. Резултатът трябва да бъде сортиран по името на града по азбучен ред.
*/
DELIMITER $$
CREATE PROCEDURE usp_get_towns_starting_with (start_letter TEXT)
BEGIN
	SELECT 	`name`
    FROM towns 
    WHERE LOWER(SUBSTRING(`name`,1, LENGTH(start_letter)))=LOWER(start_letter);
END
$$
