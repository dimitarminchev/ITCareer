/*Problem 1. Служители и техните мениджъри*/
(
	SELECT first_name,last_name,  
		(SELECT CONCAT(first_name,last_name) FROM soft_uni.employees WHERE employee_id = e.manager_id ORDER by first_name ASC LIMIT 1) manager_name
	FROM soft_uni.employees AS e
	WHERE manager_id IS NOT NULL
)
UNION
(
	SELECT first_name,last_name, "(no manager)" AS manager_name
	FROM soft_uni.employees AS e
	WHERE manager_id IS NULL
)
ORDER BY manager_name;

/*Problem 2. Тримата най-добре платени*/
(
	SELECT first_name,last_name,"employee" AS position, salary
	FROM soft_uni.employees
	WHERE manager_id IS NOT NULL
    LIMIT 3
)
UNION
(
	SELECT first_name,last_name,"manager" AS position, salary
	FROM soft_uni.employees
	WHERE manager_id IS NULL
    LIMIT 3
)
ORDER BY salary DESC, first_name;

/*Problem 3. Планините в България*/
(
	SELECT mountain_range,  
		(SELECT peak_name FROM geography.peaks WHERE mountain_id = m.id ORDER by elevation DESC LIMIT 1) peak_name,
		(SELECT elevation FROM geography.peaks WHERE mountain_id = m.id ORDER by elevation DESC LIMIT 1) elevation
	FROM geography.mountains m  
	WHERE id IN (SELECT mountain_id FROM geography.mountains_countries WHERE country_code = "BG") 
    AND(SELECT id FROM geography.peaks AS p WHERE p.mountain_id = m.id LIMIT 1) IS NOT NULL
)
UNION
(
	SELECT mountain_range,  
		"no info" AS peak_name,
		"no info" AS elevation
	FROM geography.mountains m  
	WHERE id IN (SELECT mountain_id FROM geography.mountains_countries WHERE country_code = "BG") 
    AND(SELECT id FROM geography.peaks AS p WHERE p.mountain_id = m.id LIMIT 1) IS NULL
)
ORDER BY mountain_range;

/*Problem 4. Всички географски обекти в България */
(
	SELECT mountain_range as `name`,  
		"mountain" as `type`,
		(SELECT elevation FROM geography.peaks WHERE mountain_id = m.id ORDER by elevation DESC LIMIT 1) as `info`
	FROM geography.mountains m
)
UNION
(
	SELECT river_name as `name`,  
		"river" as `type`,
		length as `info`
	FROM geography.rivers 
)
UNION
(
	SELECT peak_name as `name`,  
		"peak" as `type`,
		 elevation as `info`
	FROM geography.peaks  
)
ORDER BY `name`;

/*to your MySQL server version for the right syntax to use near '(SELECT elevation FROM geography.peaks WHERE mountain_id = m.id ORDER by elevati' at line 4	0.000 sec
*/