/* 20. Най-големи по население страни */
USE geography;

SELECT country_name, population
FROM countries
WHERE continent_code="EU"
ORDER BY population DESC
LIMIT 30;