/* Problem 1. Държави с реки */
SELECT  c.country_name,r.river_name

FROM countries AS c
LEFT JOIN countries_rivers AS cr ON cr.country_code = c.country_code
LEFT JOIN rivers AS r ON r.id = cr.river_id
LEFT JOIN continents AS con ON con.continent_code = c.continent_code

WHERE con.continent_name = 'Africa'
ORDER BY c.country_name
LIMIT 5;

/* Problem 2. Държави без планини */
SELECT country_name
FROM countries AS c
LEFT JOIN mountains_countries AS mc 
  ON mc.country_code = c.country_code
WHERE mc.mountain_id IS NULL;

/* Problem 3. Планините в България  */
SELECT m.mountain_range, p.peak_name, p.elevation 
FROM peaks AS p
LEFT JOIN mountains AS m ON m.id = p.mountain_id
LEFT JOIN mountains_countries AS mc ON mc.mountain_id=p.mountain_id
WHERE mc.country_code = "BG"
ORDER BY p.elevation DESC;

/* Problem 4. Служители без проект */
SELECT e.employee_id,e.first_name,e.last_name
FROM employees AS e 
LEFT JOIN employees_projects AS ep
ON ep.employee_id = e.employee_id 
WHERE ep.project_id IS NULL
ORDER BY e.first_name, e.last_name;