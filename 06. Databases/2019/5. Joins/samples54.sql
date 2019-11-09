USE soft_uni;

-- 01. Employee 24
SELECT e.employee_id, e.first_name,
CASE
 WHEN p.start_date >= '2005-01-01' THEN NULL
 ELSE p.name
END as 'project_name'
 FROM employees AS e
INNER JOIN employees_projects AS ep ON ep.employee_id = e.employee_id
INNER JOIN projects AS p ON p.project_id = ep.project_id
WHERE e.employee_id = 24
order by `project_name`;

USE geography;

-- 02. Игра с континенти
SELECT c1.continent_name AS "FROM", c2.continent_name AS "TO"
FROM continents c1
CROSS JOIN continents c2
ORDER BY c1.continent_name, c2.continent_name;

-- 03. Европейското по футбол
SELECT c1.capital as Place, c1.country_name AS "Player 1 (Host)", " " AS Host, " " AS Guest, c2.country_name AS "Player 2 (Guest)"
FROM countries c1
CROSS JOIN countries c2
WHERE c1.continent_code = "EU" AND c2.continent_code = "EU"
  AND c1.country_code <> c2.country_code
ORDER BY RAND()

-- 04. Highest Peak and Longest River by Country
SELECT c.country_name, MAX(p.elevation) AS 'MaxPeakElevation', MAX(r.length) AS 'MaxRiverLength' 
FROM countries AS c
LEFT JOIN mountains_countries AS mc ON mc.country_code = c.country_code
LEFT JOIN peaks AS p ON p.mountain_id = mc.mountain_id
LEFT JOIN countries_rivers AS cr ON cr.country_code = c.country_code
LEFT JOIN rivers AS r ON r.Id = cr.river_id
GROUP BY c.country_name
ORDER BY `MaxPeakElevation` DESC, `MaxRiverLength` DESC, c.country_name ASC
limit 5;

-- 05. *continents and currencies
SELECT usages.continent_code, usages.currency_code, usages.usages FROM
(
SELECT con.continent_code, cu.currency_code, COUNT(cu.currency_code) AS usages FROM continents AS con
INNER JOIN countries AS c ON c.continent_code = con.continent_code
INNER JOIN currencies AS cu ON cu.currency_code = c.currency_code
GROUP BY con.continent_code, cu.currency_code
) AS usages
INNER JOIN
(SELECT usages.continent_code, MAX(usages.usages) AS maxUsage FROM 
(
SELECT con.continent_code, cu.currency_code, COUNT(cu.currency_code) AS usages FROM continents AS con
INNER JOIN countries AS c ON c.continent_code = con.continent_code
INNER JOIN currencies AS cu ON cu.currency_code = c.currency_code
GROUP BY con.continent_code, cu.currency_code
HAVING COUNT(cu.currency_code) > 1
) as usages
GROUP BY usages.continent_code
) AS max_usages ON max_usages.continent_code = usages.continent_code AND max_usages.maxUsage = usages.usages
ORDER BY usages.continent_code, usages.currency_code;

