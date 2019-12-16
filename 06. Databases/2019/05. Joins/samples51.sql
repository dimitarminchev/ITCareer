/* Problem 1. Адрес на служител */
SELECT e.employee_id, e.job_title, 
       a.address_id, a.address_text
FROM employees AS e
JOIN addresses AS a ON a.address_id = e.address_id
ORDER BY a.address_id
LIMIT 5;

/* Problem 2. Служител по продажбите */
SELECT 
  e.employee_id, e.first_name, 
  e.last_name, d.`name` AS department_name
FROM employees as e
JOIN departments as d ON d.department_id = e.department_id
WHERE d.`name` = "Sales"
ORDER BY e.employee_id DESC;

/* Problem 3. Служебни отдели */
SELECT e.employee_id,
	e.first_name, e.salary,
	d.`name` AS department_name
FROM employees AS e
JOIN departments AS d ON d.department_id = e.department_id
WHERE e.salary > 15000
ORDER BY d.department_id DESC;

/* Problem 4. Служители без проект */
SELECT e.employee_id, e.first_name 

FROM employees AS e
WHERE e.employee_id NOT IN   
(
	SELECT DISTINCT ep.employee_id 
	FROM employees_projects AS ep
)
ORDER BY e.employee_id desc
LIMIT 3;

/* Problem 5. Мениджър на служителите */
SELECT
	e.employee_id,
	e.first_name,
	e.manager_id,
	m.first_name AS manager_name
FROM employees AS e
JOIN employees AS m ON m.employee_id = e.manager_id
WHERE e.employee_id IN (3,7) 
ORDER BY e.first_name;

/* Problem 6. Минимална заплата */
SELECT e.salary, d.`name`
FROM employees AS e
JOIN departments AS D ON d.department_id = e.department_id
ORDER BY e.salary ASC
LIMIT 1;

/* Problem 7. Държави без планини */
SELECT country_name FROM countries
WHERE country_code NOT IN 
(
	SELECT DISTINCT country_code 
	FROM mountains_countries
); 