/*Problem 1. Най-висока заплата по длъжности*/
SELECT job_title, salary
FROM soft_uni.employees AS e
WHERE salary = 
(
	SELECT salary
	FROM soft_uni.employees AS emp
	WHERE e.department_id=emp.department_id
    ORDER BY salary DESC LIMIT 1
)
ORDER BY salary DESC, job_title;


/*Problem 2. Най-ниско платени служители по отдели*/
SELECT first_name, last_name, salary, (SELECT `name` FROM soft_uni.departments AS eee WHERE e.department_id=eee.department_id LIMIT 1) department_name
FROM soft_uni.employees AS e
WHERE salary = 
(
	SELECT salary
	FROM soft_uni.employees AS emp
	WHERE e.department_id=emp.department_id
    ORDER BY salary LIMIT 1
)
ORDER BY salary, first_name, last_name;


/*Problem 3. Мениджъри сЪС същото презиме */
SELECT first_name, last_name,employee_id,manager_id
FROM soft_uni.employees AS e
WHERE employee_id = ANY
(
	SELECT manager_id
	FROM soft_uni.employees AS emp
	WHERE e.middle_name=emp.middle_name
)
ORDER BY first_name;


/*Problem 3. Мениджъри сЪС същото презиме */
SELECT first_name, last_name,employee_id,manager_id
FROM soft_uni.employees AS e
WHERE employee_id = ANY
(
	SELECT manager_id
	FROM soft_uni.employees AS emp
	WHERE e.middle_name=emp.middle_name
)
ORDER BY first_name;


/*Problem 4. Мениджъри с по-ниска заплата*/
SELECT first_name, last_name
FROM soft_uni.employees AS e
WHERE employee_id = ANY
(
	SELECT manager_id
	FROM soft_uni.employees AS emp
	WHERE e.salary<emp.salary
)
ORDER BY first_name DESC;


/*Problem 5. Мениджъри с точно 5 подчинени*/
SELECT e.first_name, e.last_name
FROM soft_uni.employees e 
WHERE e.employee_id IN (SELECT DISTINCT manager_id FROM employees)
  AND  (SELECT manager_id FROM soft_uni.employees AS emp WHERE emp.manager_id = e.employee_id LIMIT 4,1) IS NOT NULL
  AND  (SELECT manager_id FROM soft_uni.employees AS ee WHERE ee.manager_id = e.employee_id LIMIT 5,1) IS NULL
ORDER BY e.first_name, e.last_name;

/*Problem 6. Планините в България */
SELECT mountain_range,  
	(SELECT peak_name FROM geography.peaks WHERE mountain_id = m.id ORDER by elevation DESC LIMIT 1) peak_name,
	(SELECT elevation FROM geography.peaks WHERE mountain_id = m.id ORDER by elevation DESC LIMIT 1) elevation
FROM geography.mountains m  
WHERE id IN (SELECT mountain_id FROM geography.mountains_countries WHERE country_code = "BG")
ORDER BY elevation DESC;
 
 /*Problem 7. Неописаните планини в България */
SELECT mountain_range, id  
FROM geography.mountains m
WHERE id IN (SELECT mountain_id FROM geography.mountains_countries WHERE country_code = 'BG')
AND(SELECT id FROM geography.peaks AS p WHERE p.mountain_id = m.id LIMIT 1) IS NULL
ORDER BY id DESC;