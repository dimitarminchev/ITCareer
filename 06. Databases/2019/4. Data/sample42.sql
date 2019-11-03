/*Problem 1. Най-ниско платени служители*/
SELECT first_name, last_name, salary	 
FROM soft_uni.employees
WHERE salary = 
	(
		SELECT salary	 
		FROM soft_uni.employees
		ORDER BY salary LIMIT 1
    );
    
/*Problem 2. Служители с близки до най-ниските заплати*/
SELECT first_name, last_name, salary	 
FROM soft_uni.employees
WHERE salary <= 
	(
		SELECT salary	 
		FROM soft_uni.employees
		ORDER BY salary LIMIT 1
    ) * 1.10
    LIMIT 35;
    
    
/*Problem 3. Всички мениджъри*/
SELECT first_name, last_name, job_title	 
FROM soft_uni.employees
WHERE manager_id IS NULL
ORDER BY first_name;

/*Problem 4. Служителите от San Francisco*/
SELECT first_name AS "employee_id", last_name AS "employee_name"	 
FROM soft_uni.employees
WHERE address_id = ANY
	(	
	SELECT address_id FROM soft_uni.addresses WHERE town_id = 
		(
			SELECT town_id FROM soft_uni.towns WHERE `name` = "San Francisco" LIMIT 1
        )
    )
ORDER BY first_name;
