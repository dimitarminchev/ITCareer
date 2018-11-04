/* 8. Най-висок връх и най-дълга река по държава */
USE geography;

SELECT c.country_name as `country`, 
       MAX(p.elevation) AS `peak`, 
       MAX(r.length) AS `river`
       
FROM countries AS c

LEFT JOIN mountains_countries AS mc ON mc.country_code = c.country_code
LEFT JOIN peaks AS p ON p.mountain_id = mc.mountain_id
LEFT JOIN countries_rivers AS cr ON cr.country_code = c.country_code
LEFT JOIN rivers AS r ON r.id = cr.river_id

GROUP BY `country`
ORDER BY `peak` DESC, `river` DESC, `country` ASC
LIMIT 5;
