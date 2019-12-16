/* Problem 1. Адреси с градове */
SELECT e.first_name, e.last_name, t.`name` AS town, a.address_text
FROM employees AS e
INNER JOIN addresses AS a ON a.address_id = e.address_id
INNER JOIN towns AS t ON t.town_id = a.town_id
ORDER BY e.first_name, e.last_name;

/* Problem 2. Служители, наети по-късно */
SELECT e.first_name, e.last_name, e.hire_date, d.`name` AS "department"
FROM employees AS e
INNER JOIN departments AS d ON 
(
  e.department_id = d.department_id
  AND DATE(e.hire_date) > '1999/1/1'
  AND d.name IN ('Sales', 'Finance')
)
ORDER BY e.hire_date ASC;

/* Problem 3. Служители с проект */
SELECT 	e.employee_id, e.first_name, p.`name` AS project_name
FROM employees AS e
INNER JOIN employees_projects AS ep ON ep.employee_id = e.employee_id
ИNNER JOIN projects AS p ON p.project_id = ep.project_id AND p.start_date > "2002/08/13"
ORDER BY e.first_name, p.`name`
LIMIT 5;
 
/* Problem 4. Резюме на служителите */
SELECT
	e.employee_id,
	CONCAT(e.first_name," ",e.last_name) AS "employee_name",
	CONCAT(m.first_name," ",m.last_name) AS "manager_name",
	d.`name` AS "department_name"
FROM employees AS e
INNER JOIN employees AS m  ON m.employee_id = e.manager_id
INNER JOIN departments AS d  ON d.department_id = e.department_id
ORDER BY e.employee_id LIMIT 5;

/* Problem 5. Най-високи върхове в България */
SELECT mc.country_code, m.mountain_range, p.peak_name, p.elevation
FROM mountains as m
INNER JOIN mountains_countries AS mc ON mc.mountain_id = m.id AND mc.country_code = "BG"
INNER JOIN peaks AS p ON p.mountain_id = m.id
WHERE p.elevation > 2835    
ORDER BY p.elevation DESC;

/* Problem 6. Планински вериги */
SELECT 
	mc.country_code, 
    c.country_name, 
    m.mountain_range 
FROM mountains_countries AS mc
INNER JOIN mountains AS m ON m.id = mc.mountain_id
INNER JOIN countries AS c ON c.country_code = mc.country_code AND c.country_code IN ("BG","US","RU")
ORDER BY mc.country_code, m.mountain_range;