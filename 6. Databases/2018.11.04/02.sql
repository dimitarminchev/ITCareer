/* 02. Държави без планини */
USE geography;

SELECT country_name
FROM countries AS c
LEFT JOIN mountains_countries AS mc 
       ON mc.country_code = c.country_code          
WHERE mc.country_code IS NULL;