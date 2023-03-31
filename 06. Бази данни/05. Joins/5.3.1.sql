/* Задача 5.14. Държави с реки */
USE `geography`;

SELECT `c`.`country_name`,	`r`.`river_name`
FROM `countries_rivers` AS `cr`
LEFT JOIN `rivers` AS `r` ON `r`.`id` = `cr`.`river_id`
LEFT JOIN `countries` AS `c` ON `c`.`country_code` = `cr`.`country_code`
WHERE `c`.`continent_code` = "AF"
ORDER BY `c`.`country_name`
LIMIT 5;	