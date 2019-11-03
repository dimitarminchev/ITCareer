/* Problem 1. Намерете всички служители със заплата над 50000*/
SELECT `first_name`,`last_name`,`salary` AS "Salary"
FROM soft_uni.employees 
WHERE salary >50000 
ORDER BY salary DESC;

/* Problem 2. Намерете 5 най-добре платени служители*/
SELECT `first_name`,`last_name`,`salary` AS "Salary"
FROM soft_uni.employees 
ORDER BY salary DESC LIMIT 5;

/* Problem 3. Сортирайте таблицата със служители*/
SELECT *
FROM soft_uni.employees 
ORDER BY salary DESC, first_name, last_name DESC, middle_name;


/* Problem 4. Намерете първите 10 започнати проекта*/
SELECT *
FROM soft_uni.projects 
ORDER BY start_date, `name`;


/*Problem 5. Последните 7 наети служителя*/
SELECT  first_name, last_name, hire_date	 
FROM soft_uni.employees 
ORDER BY hire_date LIMIT 7;

/*Problem 6. Всички планински върхове*/
SELECT peak_name FROM geography.peaks ORDER BY peak_name;

/*Problem 7. Най-големи държави по население*/
SELECT  country_name, population	
FROM geography.countries
WHERE continent_code = (SELECT continent_code FROM geography.continents WHERE continent_name="Europe" LIMIT 1)
ORDER BY population DESC, country_name  LIMIT 30;


/*Problem 8.*/
(
	SELECT country_name, country_code, 'EURO' as 'currency'
	FROM geography.countries
	WHERE currency_code = 'EUR'
) UNION (
	SELECT country_name, country_code, 'NOT EURO' as 'currency'
	FROM geography.countries
	WHERE currency_code <> 'EUR'
)
ORDER BY country_name ASC;