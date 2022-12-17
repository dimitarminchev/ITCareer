/* 5.4.2. Игра на континенти */
USE `geography`;

SELECT `c1`.`continent_name` AS `FROM`,
       `c2`.`continent_name` AS `TO`
FROM `continents` AS `c1`
CROSS JOIN `continents` AS `c2`

ORDER BY `c1`.`continent_name`, `c2`.`continent_name`;