/* 6. Игра на континенти */
USE geography;

SELECT c1.continent_name AS `from`, c2.continent_name AS `to`
FROM continents  AS c1
CROSS JOIN continents AS c2
ORDER BY `from` ASC, `to` ASC;
