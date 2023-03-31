
/*
Задача 7.2. Служители със заплата над...
Създайте съхранена процедура usp_get_employees_salary_above, която приема число като параметър и връща първото и последното име на всички служители, които имат заплата равна на поне даденото число. Резултатът трябва да се сортира по first_name, а след това и по last_name в азбучен ред. 
*/
DELIMITER $$
CREATE PROCEDURE usp_get_employees_salary_above(salaryVal INT)
BEGIN
	SELECT first_name, last_name
    FROM employees 
    WHERE salary>salaryVal;
END
$$
