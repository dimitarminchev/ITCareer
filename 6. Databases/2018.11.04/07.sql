/* 7. Европейското по футбол */
USE geography;

SELECT c1.capital AS place, c1.country_name AS `Player 1`, NULL AS `Host`,
       NULL AS `Guest`, c2.country_name AS `Player 2`
FROM countries AS c1
CROSS JOIN countries AS c2
WHERE c1.continent_code = "EU" AND c2.continent_code = "EU" AND
      c1.country_code != c2.country_code
ORDER BY RAND();