/*
Задача 7.1. Служители със заплата над 35000
Създайте съхранена процедура usp_get_employees_salary_above_35000 която връща първото и последното име на всички служители, които имат заплата над 35000. Резултатът трябва да бъде сортиран по first_name, а след това и по last_name в азбучен ред. 
*/
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above_35000()
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE salary>35000;
END
$$