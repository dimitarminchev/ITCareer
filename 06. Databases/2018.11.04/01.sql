/* 01. Държави с реки */
USE geography;

SELECT country_name, river_name
FROM countries as c

LEFT JOIN countries_rivers AS cr ON cr.country_code=c.country_code
LEFT JOIN rivers AS r ON cr.river_id=r.id
LEFT JOIN continents AS cn ON cn.continent_code=c.continent_code
 
WHERE cn.continent_name="Africa"
ORDER BY c.country_name 
LIMIT 5;