
/*
Задача 7.4. Служители от град
Напишете съхранена процедура usp_get_employees_from_town която приема името на град като параметър и връща първото и последното име на всички служители, които живеят в дадения град. Резултатът трябва да бъде сортиран по first_name, а след това по last_name в азбучен ред.
*/
DELIMITER $$
CREATE PROCEDURE usp_get_employees_from_town (town_name TEXT)
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE address_id = (SELECT id FROM  towns WHERE `name`=town_name LIMIT 1);
END
$$
